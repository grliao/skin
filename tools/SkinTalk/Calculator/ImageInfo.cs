using System;
using System.Runtime.Serialization;
namespace SkinTalkAPI.Model
{
    [DataContract]
	public class ImageInfo
	{
        [DataMember]
		public string ImageInBase64
		{
			get;
			set;
		}

        [DataMember]
		public int Score
		{
			get;
			set;
		}

        [DataMember]
		public string PassValidation
		{
			get;
			set;
		}
	}
}
