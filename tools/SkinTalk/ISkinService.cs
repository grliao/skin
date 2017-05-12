using AForge.Imaging;
using SkinTalk.Core;
using SkinTalkAPI.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
//using System.Linq;
using System.Runtime.Serialization;
//using System.ServiceModel;
//using System.ServiceModel.Web;
using System.Text;
//using System.Threading.Tasks;

namespace SkinTalk
{
    //[ServiceContract]
    public interface ISkinService
    {
       /// <summary>
       /// 分析图片
       /// </summary>
       /// <param name="imageType"></param>
       /// <param name="rgb"></param>
       /// <param name="resize"></param>
       /// <param name="image"></param>
       /// <returns></returns>
        //[OperationContract]
        //[WebInvoke(Method = "POST", UriTemplate = "processImage", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        ImageInfo ProcessImage(AnalysisType imageType, string rgb, bool resize, string image);

        /// <summary>
        /// 分析图片
        /// </summary>
        /// <param name="imageType"></param>
        /// <param name="rgb"></param>
        /// <param name="resize"></param>
        /// <param name="image"></param>
        /// <returns></returns>
        ImageInfo ProcessImage(AnalysisType imageType, string rgb, bool resize, Bitmap image);
    }
}
