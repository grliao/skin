using System;
using System.Drawing;
namespace SkinTalkAPI.Calculator
{
	internal class OilValueCalclator : AbstractCalculator
	{
		private int pixelValidSelected;
		private int pixelInValidSelected;
		public OilValueCalclator(System.Drawing.Bitmap image) : base(image)
		{
			this.color_r = 88;
			this.color_g = 110;
			this.color_b = 95;
		}
		public override void calculate()
		{
			base.convertToInvertPicture();
			base.calculate();
		}
		protected override void processPixel(int x, int y, bool isValidArea)
		{
			System.Drawing.Color color = this.image.GetPixel(x, y);
			if ((int)color.R > this.color_r && (int)color.G > this.color_g && (int)color.B > this.color_b)
			{
				if (isValidArea)
				{
					this.pixelValidSelected++;
				}
				else
				{
					this.pixelInValidSelected++;
				}
				this.cloneImage.SetPixel(x, y, System.Drawing.Color.FromArgb(0, 255, 0));
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
			int selectedTotal = (int)((double)this.pixelValidSelected * 1.3 + (double)this.pixelInValidSelected);
			int percentage = (int)((float)selectedTotal / (float)this.totalPixelPoint * 100f);
			if (percentage >= 100)
			{
				percentage = 99;
			}
			this.calcResult.Score = percentage;
			this.calcResult.ImageInBase64 = base.getResultImageInBase64();
		}
	}
}
