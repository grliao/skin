using AForge.Imaging;
using AForge.Imaging.Filters;
using AForge.Math;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
namespace SkinTalkAPI
{
	public class ImageProcessor
	{
		private int skinTonePrecentage = -1;
		private static int RED = 0;
		private static int GREEN = 1;
		private static int BLUE = 2;
		private byte[] imageByte;
		private byte[] invertedImageByte;
		private byte[] grayImageByte;
		private System.Drawing.Bitmap image;
		public System.Drawing.Bitmap resultImage;
		private Random random;
		private ImageStatistics stat;
		public ImageProcessor()
		{
			this.random = new Random();
		}
		public void loadPic(System.Drawing.Bitmap inpic)
		{
			this.imageByte = this.imageToByteArray(inpic);
			this.image = AForge.Imaging.Image.Clone(inpic);
			this.stat = new ImageStatistics(this.image);
		}
		public System.Drawing.Bitmap getGrayPicture()
		{
			System.Drawing.Bitmap cloneImage = AForge.Imaging.Image.Clone(this.image);
			FiltersSequence PigmentFilter = new FiltersSequence(new IFilter[]
			{
				Grayscale.CommonAlgorithms.BT709
			});
			cloneImage = PigmentFilter.Apply(cloneImage);
			this.grayImageByte = this.imageToByteArray(cloneImage);
			return cloneImage;
		}
		public System.Drawing.Bitmap getInvertPicture()
		{
			this.invertPicture();
			return this.byteArrayToImage(this.invertedImageByte);
		}
		public int processTexture()
		{
			return this.processTexture(System.Drawing.Color.FromArgb(200, 180, 130));
		}
		public int processTexture(System.Drawing.Color colorParameter)
		{
			if (this.invertedImageByte == null)
			{
				this.getInvertPicture();
			}
			System.Drawing.Bitmap cloneImage = this.byteArrayToImage(this.invertedImageByte);
			int totalPixel = 0;
			int zoneASelected = 0;
			int zoneBSelected = 0;
			int zoneAminX = this.getCutOffImageOffset(cloneImage.Width, true);
			int zoneAminY = this.getCutOffImageOffset(cloneImage.Height, true);
			int zoneAmaxX = this.getCutOffImageOffset(cloneImage.Width, true);
			int zoneAmaxY = this.getCutOffImageOffset(cloneImage.Height, true);
			for (int i = 0; i < cloneImage.Width; i++)
			{
				for (int j = 0; j < cloneImage.Height; j++)
				{
					System.Drawing.Color color = cloneImage.GetPixel(i, j);
					totalPixel++;
					if (color.R < colorParameter.R && color.G < colorParameter.G && color.B < colorParameter.B)
					{
						if (zoneAminX <= i && i <= zoneAmaxX && zoneAminY <= j && j <= zoneAmaxY)
						{
							zoneASelected++;
						}
						else
						{
							zoneBSelected++;
						}
						cloneImage.SetPixel(i, j, System.Drawing.Color.FromArgb(0, 255, 0));
					}
				}
			}
			int totalSelected = zoneASelected + zoneBSelected;
			int percentage = (int)((float)totalSelected / (float)totalPixel * 100f);
			percentage += 20;
			if (percentage >= 100)
			{
				percentage = this.random.Next(92, 99);
			}
			else
			{
				if (percentage <= 5)
				{
					percentage = this.random.Next(1, 15);
				}
			}
			percentage = 100 - percentage;
			this.saveImage("texture_result.png", cloneImage);
			return percentage;
		}
		public int processPores()
		{
			return this.processPores(System.Drawing.Color.FromArgb(100, 100, 100));
		}
		public int processPores(System.Drawing.Color colorParameter)
		{
			System.Drawing.Bitmap cloneImage = AForge.Imaging.Image.Clone(this.image);
			int totalZoneAPixel = 0;
			int totalZoneBPixel = 0;
			int zoneASelected = 0;
			int zoneBSelected = 0;
			int zoneAminX = this.getCutOffImageOffset(cloneImage.Width, true);
			int zoneAminY = this.getCutOffImageOffset(cloneImage.Height, true);
			int zoneAmaxX = this.getCutOffImageOffset(cloneImage.Width, true);
			int zoneAmaxY = this.getCutOffImageOffset(cloneImage.Height, true);
			for (int i = 0; i < cloneImage.Width; i++)
			{
				for (int j = 0; j < cloneImage.Height; j++)
				{
					if (cloneImage.GetPixel(i, j).B < colorParameter.B)
					{
						if (zoneAminX <= i && i <= zoneAmaxX && zoneAminY <= j && j <= zoneAmaxY)
						{
							zoneASelected++;
						}
						else
						{
							zoneBSelected++;
							cloneImage.SetPixel(i, j, System.Drawing.Color.FromArgb(0, 255, 0));
						}
					}
					if (zoneAminX <= i && i <= zoneAmaxX && zoneAminY <= j && j <= zoneAmaxY)
					{
						totalZoneAPixel++;
					}
					else
					{
						totalZoneBPixel++;
					}
				}
			}
			int totalSelected = zoneBSelected;
			int percentage = (int)((float)totalSelected / (float)totalZoneBPixel * 100f);
			percentage = 100 - percentage;
			if (percentage >= 100)
			{
				percentage = this.random.Next(92, 99);
			}
			else
			{
				if (percentage <= 5)
				{
					percentage = this.random.Next(1, 15);
				}
			}
			percentage = 100 - percentage;
			this.saveImage("pores_result.png", cloneImage);
			return percentage;
		}
		public int processPorphyrin()
		{
			System.Drawing.Color color = System.Drawing.Color.FromArgb(180, 180, 180);
			return this.processPorphyrin(color);
		}
		public int processPorphyrin(System.Drawing.Color colorParameter)
		{
			System.Drawing.Bitmap bmap = this.filterColorImage(ImageProcessor.GREEN, ImageProcessor.RED, ImageProcessor.BLUE, (int)colorParameter.R);
			int totalPixel = 0;
			int countchange = 0;
			for (int i = 0; i < bmap.Width; i++)
			{
				for (int j = 0; j < bmap.Height; j++)
				{
					System.Drawing.Color color = bmap.GetPixel(i, j);
					totalPixel++;
					if (color.R > colorParameter.R)
					{
						int redCounter = 0;
						for (int k = 0; k < 9; k++)
						{
							int tw = i + k / 3 - 1;
							int th = j + k % 3 - 1;
							if (tw >= 0 && th >= 0 && bmap.Width > tw && bmap.Height > th)
							{
								if (bmap.GetPixel(tw, th).R > colorParameter.R)
								{
									redCounter++;
								}
							}
						}
						if (redCounter > 4)
						{
							countchange++;
							bmap.SetPixel(i, j, System.Drawing.Color.FromArgb(0, 255, 0));
						}
					}
				}
			}
			int selectCountAdjust = countchange * 10;
			int percentage = (int)((float)selectCountAdjust / (float)totalPixel * 100f);
			percentage = 100 - percentage;
			percentage = ((percentage > 80) ? (percentage - 10) : percentage);
			if (percentage >= 100)
			{
				percentage = this.random.Next(92, 99);
			}
			else
			{
				if (percentage <= 5)
				{
					percentage = this.random.Next(1, 15);
				}
			}
			this.saveImage("Porphyrin_result.png", bmap);
			return percentage;
		}
		public int processRedness()
		{
			System.Drawing.Bitmap cloneImage = AForge.Imaging.Image.Clone(this.image);
			int totalPixel = 0;
			int pigmentSelected = 0;
			int zoneAminX = this.getCutOffImageOffset(cloneImage.Width, true);
			int zoneAminY = this.getCutOffImageOffset(cloneImage.Height, true);
			int zoneAmaxX = this.getCutOffImageOffset(cloneImage.Width, true);
			int zoneAmaxY = this.getCutOffImageOffset(cloneImage.Height, true);
			for (int i = 0; i < cloneImage.Width; i++)
			{
				for (int j = 0; j < cloneImage.Height; j++)
				{
					System.Drawing.Color color = cloneImage.GetPixel(i, j);
					totalPixel++;
					if (color.B + color.G < 100)
					{
						int redCounter = 0;
						for (int k = 0; k < 9; k++)
						{
							int tw = i + k / 3 - 1;
							int th = j + k % 3 - 1;
							if (tw >= 0 && th >= 0 && cloneImage.Width > tw && cloneImage.Height > th)
							{
								color = cloneImage.GetPixel(tw, th);
								if (color.B + color.G < 100)
								{
									redCounter++;
								}
							}
						}
						if (redCounter > 4)
						{
							pigmentSelected++;
							cloneImage.SetPixel(i, j, System.Drawing.Color.FromArgb(0, 255, 0));
						}
					}
				}
			}
			int totalSelected = pigmentSelected;
			int percentage = (int)((float)totalSelected / (float)totalPixel * 100f);
			this.skinTonePrecentage = percentage;
			percentage = ((percentage < 50) ? (percentage + 10) : (percentage - 10));
			this.skinTonePrecentage = ((this.skinTonePrecentage < 50) ? (this.skinTonePrecentage + 15) : (this.skinTonePrecentage - 15));
			if (percentage >= 100)
			{
				percentage = this.random.Next(92, 99);
			}
			else
			{
				if (percentage <= 5)
				{
					percentage = this.random.Next(1, 15);
				}
			}
			if (this.skinTonePrecentage >= 100)
			{
				this.skinTonePrecentage = this.random.Next(92, 99);
			}
			else
			{
				if (this.skinTonePrecentage <= 5)
				{
					this.skinTonePrecentage = this.random.Next(1, 15);
				}
			}
			percentage = 100 - percentage;
			this.saveImage("redness_result.png", cloneImage);
			this.saveImage("skintone_result.png", cloneImage);
			return percentage;
		}
		public int processPigment()
		{
			System.Drawing.Bitmap cloneImage = this.getGrayPicture();
			System.Drawing.Bitmap grayImage = new System.Drawing.Bitmap(cloneImage.Width, cloneImage.Height);
			this.stat = new ImageStatistics(cloneImage);
			Histogram CalstatGary = this.stat.Gray;
			int median = CalstatGary.Median;
			double mean = CalstatGary.Mean;
			double sd = CalstatGary.StdDev;
			int drak = median - (int)sd / 2;
			int totalPixel = 0;
			int pigmentSelected = 0;
			int zoneAminX = this.getCutOffImageOffset(cloneImage.Width, true);
			int zoneAminY = this.getCutOffImageOffset(cloneImage.Height, true);
			int zoneAmaxX = this.getCutOffImageOffset(cloneImage.Width, true);
			int zoneAmaxY = this.getCutOffImageOffset(cloneImage.Height, true);
			for (int i = 0; i < cloneImage.Width; i++)
			{
				for (int j = 0; j < cloneImage.Height; j++)
				{
					System.Drawing.Color color = cloneImage.GetPixel(i, j);
					totalPixel++;
					if ((int)color.R <= drak)
					{
						int redCounter = 0;
						for (int k = 0; k < 9; k++)
						{
							int tw = i + k / 3 - 1;
							int th = j + k % 3 - 1;
							if (tw >= 0 && th >= 0 && cloneImage.Width > tw && cloneImage.Height > th)
							{
								color = cloneImage.GetPixel(tw, th);
								if ((int)color.R <= drak)
								{
									redCounter++;
								}
							}
						}
						if (redCounter > 4)
						{
							pigmentSelected++;
							grayImage.SetPixel(i, j, System.Drawing.Color.FromArgb(0, 255, 0));
						}
						else
						{
							grayImage.SetPixel(i, j, color);
						}
					}
				}
			}
			int totalSelected = pigmentSelected;
			int percentage = (int)((float)totalSelected / (float)totalPixel * 100f);
			if (percentage >= 100)
			{
				percentage = this.random.Next(92, 99);
			}
			else
			{
				if (percentage <= 5)
				{
					percentage = this.random.Next(1, 15);
				}
			}
			percentage = 100 - percentage;
			this.saveImage("pigment_result.png", grayImage);
			return percentage;
		}
		public int processSkinTone()
		{
			if (this.skinTonePrecentage == -1)
			{
				this.processRedness();
			}
			return this.skinTonePrecentage;
		}
		private System.Drawing.Bitmap filterColorImage(int removeColor, int targetColor, int compareColor, int targetColorOffset)
		{
			System.Drawing.Bitmap bmap = new System.Drawing.Bitmap(this.image.Width, this.image.Height);
			int[] array = new int[3];
			int[] getColor = array;
			for (int i = 0; i < this.image.Width; i++)
			{
				for (int j = 0; j < this.image.Height; j++)
				{
					System.Drawing.Color color = this.image.GetPixel(i, j);
					getColor[ImageProcessor.RED] = (int)color.R;
					getColor[ImageProcessor.GREEN] = (int)color.G;
					getColor[ImageProcessor.BLUE] = (int)color.B;
					getColor[removeColor] = 0;
					if (getColor[targetColor] <= getColor[compareColor] + 30 || getColor[targetColor] < targetColorOffset)
					{
						getColor[targetColor] = 0;
					}
					getColor[compareColor] = 0;
					bmap.SetPixel(i, j, System.Drawing.Color.FromArgb(getColor[ImageProcessor.RED], getColor[ImageProcessor.GREEN], getColor[ImageProcessor.BLUE]));
				}
			}
			return bmap;
		}
		private byte[] imageToByteArray(System.Drawing.Bitmap imageIn)
		{
			byte[] result;
			using (MemoryStream ms = new MemoryStream())
			{
				imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
				result = ms.ToArray();
			}
			return result;
		}
		private System.Drawing.Bitmap byteArrayToImage(byte[] byteArrayIn)
		{
			MemoryStream ms = new MemoryStream(byteArrayIn);
			return (System.Drawing.Bitmap)System.Drawing.Image.FromStream(ms);
		}
		private int getCutOffImageOffset(int imageEdgeLength, bool isMin)
		{
			return imageEdgeLength * (isMin ? 0 : 0);
		}
		private void invertPicture()
		{
			try
			{
				System.Drawing.Bitmap temp = (System.Drawing.Bitmap)this.image.Clone();
				for (int i = 0; i < temp.Width; i++)
				{
					for (int j = 0; j < temp.Height; j++)
					{
						System.Drawing.Color color = temp.GetPixel(i, j);
						temp.SetPixel(i, j, System.Drawing.Color.FromArgb((int)(255 - color.R), (int)(255 - color.G), (int)(255 - color.B)));
					}
				}
				this.invertedImageByte = this.imageToByteArray(temp);
			}
			catch (ArgumentException)
			{
				Console.Write("There was an error.Check the path to the image file.");
			}
		}
		private void grayPicture()
		{
			try
			{
				System.Drawing.Bitmap temp = (System.Drawing.Bitmap)this.image.Clone();
				for (int i = 0; i < temp.Width; i++)
				{
					for (int j = 0; j < temp.Height; j++)
					{
						System.Drawing.Color color = temp.GetPixel(i, j);
						int grayScale = (int)((double)color.R * 0.2125 + (double)color.G * 0.7154 + (double)color.B * 0.0721);
						temp.SetPixel(i, j, System.Drawing.Color.FromArgb(grayScale, grayScale, grayScale));
					}
				}
				this.grayImageByte = this.imageToByteArray(temp);
			}
			catch (ArgumentException)
			{
				Console.Write("There was an error.Check the path to the image file.");
			}
		}
		private void saveImage(string name, System.Drawing.Bitmap bitmap)
		{
			string path = "";
			File.Delete(path);
			bitmap.Save(path);
		}
	}
}
