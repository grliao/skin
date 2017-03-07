using SkinTalk.Core;
using SkinTalkAPI.Calculator;
using SkinTalkAPI.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SkinTalk
{
    public class SkinService : ISkinService
    {
        public ImageInfo ProcessImage(AnalysisType imageType, string rgb, bool resize, string image)
        {
            ImageInfo result = new ImageInfo();

            if (string.IsNullOrWhiteSpace(image))
            {
                return  result;
            }

            Bitmap inputImage = GetImageFromByte(image);

            return ProcessImage(imageType, rgb, resize, inputImage);
        }

        public ImageInfo ProcessImage(AnalysisType imageType, string rgb, bool resize, Bitmap inputImage)
        {
            ImageInfo result = new ImageInfo();

            if (resize)
            {
                inputImage = new System.Drawing.Bitmap(inputImage, new System.Drawing.Size(900, 900));
                int cutSize = 480;
                int startX = inputImage.Width / 2 - cutSize / 2;
                int startY = inputImage.Height / 2 - cutSize / 2;
                System.Drawing.Rectangle section = new System.Drawing.Rectangle(new System.Drawing.Point(startX, startY), new System.Drawing.Size(cutSize, cutSize));
                inputImage = AbstractCalculator.cropImage(inputImage, section);
            }

            int r, g, b;

            this.ReadRGBFromHexColor(rgb, out r, out g, out b);

            AbstractCalculator abstractCalculator = null;
            switch (imageType)
            {
                case AnalysisType.Lens:
                    abstractCalculator = new InstallLensCalculator(inputImage);
                    break;

                case AnalysisType.Human:
                    abstractCalculator = new HumanSkinCalculator(inputImage);
                    break;

                case AnalysisType.Inflammation:
                    abstractCalculator = new InflammationCalculator(inputImage);
                    break;

                case AnalysisType.Mositure:
                    abstractCalculator = new MositureCalculator(inputImage);
                    break;

                case AnalysisType.Oil:
                    abstractCalculator = new OilValueCalclator(inputImage);
                    break;

                case AnalysisType.Pigment:
                    abstractCalculator = new PigmentCalculator(inputImage);
                    break;

                case AnalysisType.Pores:
                    abstractCalculator = new PoresCalculator(inputImage);
                    break;

                case AnalysisType.Texture:
                    abstractCalculator = new TextureCalculator(inputImage);
                    break;
            }

            if (abstractCalculator == null)
            {
                return result;
            }

            if (r != -1 && g != -1 && b != -1)
            {
                abstractCalculator.setSpecifyColor(r, g, b);
            }

            abstractCalculator.calculate();
            result = abstractCalculator.calcResult;
            result.ImageInBase64 = null;

            return result;
        }

        private System.Drawing.Bitmap GetImageFromByte(string remoteImgPath)
        {
            System.Drawing.Bitmap result;

            byte[] datas;
            using (WebClient webClient = new WebClient())
            {
                datas = webClient.DownloadData(remoteImgPath);
            }


            using (MemoryStream ms = new MemoryStream(datas))
            {
                result = new System.Drawing.Bitmap(ms);
            }
            return result;
        }

     

        private void ReadRGBFromHexColor(string rgbHexStr, out int r, out int g, out int b)
        {
            if (rgbHexStr == null || rgbHexStr.Length != 6)
            {
                r = (g = (b = -1));
            }
            else
            {
                string hexValue = rgbHexStr.Substring(0, 2);
                if (!int.TryParse(hexValue, NumberStyles.HexNumber, null, out r))
                {
                    r = -1;
                }
                hexValue = rgbHexStr.Substring(2, 2);
                if (!int.TryParse(hexValue, NumberStyles.HexNumber, null, out g))
                {
                    g = -1;
                }
                hexValue = rgbHexStr.Substring(4, 2);
                if (!int.TryParse(hexValue, NumberStyles.HexNumber, null, out b))
                {
                    b = -1;
                }
            }
        }
    }
}
