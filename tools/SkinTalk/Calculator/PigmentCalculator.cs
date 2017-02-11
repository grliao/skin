using AForge.Imaging;
using AForge.Math;
using System;
using System.Drawing;
namespace SkinTalkAPI.Calculator
{
	internal class PigmentCalculator : AbstractCalculator
	{
		private int drak;
		private int tw;
		private int th;
		private int pigmentSelected = 0;
		public PigmentCalculator(System.Drawing.Bitmap image) : base(image)
		{
		}
		public override void calculate()
		{
			base.convertToGrayPicture();
			ImageStatistics stat = new ImageStatistics(this.image);
			Histogram CalstatGary = stat.Gray;
			int median = CalstatGary.Median;
			double mean = CalstatGary.Mean;
			double sd = CalstatGary.StdDev;
			int drak = median - (int)sd / 2;
			base.calculate();
		}
		protected override void processPixel(int x, int y, bool isValidArea)
		{
			if (isValidArea)
			{
				if ((int)this.image.GetPixel(x, y).R <= this.drak)
				{
					int redCounter = 0;
					for (int i = 0; i < 9; i++)
					{
						this.tw = x + i / 3 - 1;
						this.th = y + i % 3 - 1;
						if (this.tw >= 0 && this.th >= 0 && this.cloneImage.Width > this.tw && this.cloneImage.Height > this.th)
						{
							if ((int)this.cloneImage.GetPixel(this.tw, this.th).R <= this.drak)
							{
								redCounter++;
							}
						}
					}
					if (redCounter > 4)
					{
						this.pigmentSelected++;
						this.cloneImage.SetPixel(x, y, System.Drawing.Color.FromArgb(0, 255, 0));
					}
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
			int totalSelected = this.pigmentSelected;
			int percentage = (int)((float)this.pigmentSelected / (float)this.totalPixelPoint * 100f);
			percentage = base.randomResult(percentage);
			percentage = 100 - percentage;
			this.calcResult.Score = percentage;
			this.calcResult.ImageInBase64 = base.getResultImageInBase64();
		}
	}
}
