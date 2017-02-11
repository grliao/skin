using SkinTalkAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace SkinTalk
{
    [ServiceContract]
    public interface ISkinService
    {
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "processImage", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        ImageInfo ProcessImage(string imageType, string rgb, string resize, string image);
    }
}
