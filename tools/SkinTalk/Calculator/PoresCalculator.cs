using System;
using System.Drawing;
namespace SkinTalkAPI.Calculator
{
	internal class PoresCalculator : AbstractCalculator
	{
		private int pixelSelected;
		public PoresCalculator(System.Drawing.Bitmap image) : base(image)
		{
			this.color_r = 100;
			this.color_g = 100;
			this.color_b = 100;
		}
		public override void calculate()
		{
			base.calculate();
		}
		protected override void processPixel(int x, int y, bool isValidArea)
		{
			if (isValidArea)
			{
				if ((int)this.image.GetPixel(x, y).B < this.color_b)
				{
					this.pixelSelected++;
					this.cloneImage.SetPixel(x, y, System.Drawing.Color.FromArgb(0, 255, 0));
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
			int percentage = (int)((float)this.pixelSelected / (float)this.totalPixelPoint * 100f);
			percentage = base.randomResult(percentage);
			this.calcResult.Score = percentage;
			this.calcResult.ImageInBase64 = base.getResultImageInBase64();
		}
	}
}
