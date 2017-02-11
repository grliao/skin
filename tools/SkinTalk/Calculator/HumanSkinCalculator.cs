using AForge.Imaging;
using AForge.Math;
using System;
using System.Drawing;
namespace SkinTalkAPI.Calculator
{
	internal class HumanSkinCalculator : AbstractCalculator
	{
		private int thershold = 30;
		private System.Drawing.Bitmap croppedImage;
		private int totalcroppedPixel;
		private int skinCount = 0;
		public HumanSkinCalculator(System.Drawing.Bitmap image) : base(image)
		{
		}
		public override void calculate()
		{
			int iStartX = this.image.Width / 2 - this.thershold;
			int iStartY = this.image.Height / 2 - this.thershold;
			int newImageSize = this.thershold * 2;
			System.Drawing.Rectangle section = new System.Drawing.Rectangle(new System.Drawing.Point(iStartX, iStartY), new System.Drawing.Size(newImageSize, newImageSize));
			this.croppedImage = AbstractCalculator.cropImage(this.image, section);
			ImageStatistics stat = new ImageStatistics(this.croppedImage);
			int totalPixel = this.croppedImage.Width * this.croppedImage.Height;
			Histogram histogramRed = stat.Red;
			double averageRedValue = histogramRed.Mean;
			int noDiffCount = 0;
			int bigDiffCount = 0;
			for (int i = 0; i < this.croppedImage.Width; i++)
			{
				for (int j = 0; j < this.croppedImage.Height; j++)
				{
					double redDiff = Math.Abs((double)this.croppedImage.GetPixel(i, j).R - averageRedValue);
					if (redDiff < 3.0)
					{
						noDiffCount++;
					}
					if (redDiff > 20.0)
					{
						bigDiffCount++;
					}
				}
			}
			int failLine = (int)((double)totalPixel * 0.85);
			if (noDiffCount <= failLine && bigDiffCount <= failLine)
			{
				base.calculate();
			}
		}
		protected override void processPixel(int x, int y, bool isValidArea)
		{
			int cropperAreaX = x % (this.thershold * 2);
			int cropperAreaY = y % (this.thershold * 2);
			if (isValidArea)
			{
				System.Drawing.Color color = this.image.GetPixel(x, y);
				System.Drawing.Color croppedColor = this.croppedImage.GetPixel(cropperAreaX, cropperAreaY);
				int colorTotal = (int)(color.R + color.G + color.B);
				int croppedColorTotal = (int)(croppedColor.R + croppedColor.G + croppedColor.B);
				if (Math.Abs(colorTotal - croppedColorTotal) < 60 && color.R > 100 && color.R < 210 && color.G > 70 && color.G < 210)
				{
					this.skinCount++;
				}
			}
		}
		protected override float invalidZoneWidthPrecentage()
		{
			return 0f;
		}
		protected override float invalidZoneHeightPrecentage()
		{
			return 0f;
		}
		protected override void processResult()
		{
			int skinPrecent = this.skinCount / this.totalPixelPoint;
			if (skinPrecent > 50 && skinPrecent <= 99)
			{
				this.calcResult.PassValidation = "Y";
			}
			else
			{
				this.calcResult.PassValidation = "N";
			}
			this.calcResult.Score = 0;
		}
	}
}
