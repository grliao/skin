//  Copyright (c) Microsoft Corporation. All rights reserved.

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Reflection;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using System.ServiceModel.Web;
using System.Text;
using System.Web;
using Yyf.Core.Common.WCF.HttpMultipartParser;


namespace Yyf.Core.Common.WCF.HtmlForm
{
    public class FormDataRequestFormatter : IDispatchMessageFormatter
    {
        OperationDescription operation;

        internal FormDataRequestFormatter( OperationDescription operation )
        {
            if (operation.BeginMethod != null || operation.EndMethod != null)
                throw new InvalidOperationException("The async programming model is not supported by this formatter.");

            this.operation = operation;
        }

        public void DeserializeRequest(System.ServiceModel.Channels.Message message, object[] parameters)
        {
            string contentType = WebOperationContext.Current.IncomingRequest.ContentType;

      
            ParameterInfo[] paramInfos = operation.SyncMethod.GetParameters();
           

            if (contentType == "application/x-www-form-urlencoded")
            {
                Stream s = StreamMessageHelper.GetStream(message);
                string formData = new StreamReader(s).ReadToEnd();
                NameValueCollection parsedForm = HttpUtility.ParseQueryString(formData);
                UriTemplateMatch match = message.Properties["UriTemplateMatchResults"] as UriTemplateMatch;

                List<string> keys = new List<string>();
                keys.AddRange(parsedForm.AllKeys);

                var binder = CreateParameterBinder(match);
                object[] values = (from p in paramInfos
                                   select binder(p)).ToArray<Object>();

                for (int index = 0; index < paramInfos.Length; index++)
                {
                    ParameterInfo eachParam = paramInfos[index];

                    if (keys.Contains(eachParam.Name))
                    {
                        parameters[index] = parsedForm[eachParam.Name];
                    }

                    if (paramInfos[index].GetType() == typeof(NameValueCollection))
                    {
                        parameters[index] = parsedForm;
                    }
                }
                
                //values.CopyTo(parameters, 0);
            }
            else if (contentType.StartsWith("multipart/form-data"))
            {

                Stream s = StreamMessageHelper.GetStream(message);
                MultipartFormDataParser parser = new MultipartFormDataParser(s);

                for (int index = 0; index < paramInfos.Length; index++)
                {
                    ParameterInfo eachParam = paramInfos[index];
                    if (parser.Parameters.ContainsKey(eachParam.Name))
                    {
                        parameters[index] = parser.Parameters[eachParam.Name].Data;
                    }
                    else if(parser.Files.ContainsKey(eachParam.Name))
                    {
                        parameters[index] = parser.Files[eachParam.Name];
                    }
                }
            }
        }

        private Func<ParameterInfo, object> CreateParameterBinder(UriTemplateMatch match)
        {
            QueryStringConverter converter = new QueryStringConverter();

            return delegate( ParameterInfo pi )
            {
                string value = match.BoundVariables[pi.Name];

                if (converter.CanConvert(pi.ParameterType) && value != null)
                    return converter.ConvertStringToValue(value, pi.ParameterType);
                else

                return value;
            };
        }

        public System.ServiceModel.Channels.Message SerializeReply(System.ServiceModel.Channels.MessageVersion messageVersion, object[] parameters, object result)
        {
            throw new NotSupportedException();
        }
    }
}
