using System;
using System.Drawing;
namespace SkinTalkAPI.Calculator
{
	internal class TextureCalculator : AbstractCalculator
	{
		private int pixelSelected;
		public TextureCalculator(System.Drawing.Bitmap image) : base(image)
		{
			this.color_r = 200;
			this.color_g = 180;
			this.color_b = 130;
		}
		public override void calculate()
		{
			base.calculate();
		}
		protected override void processPixel(int x, int y, bool isValidArea)
		{
			if (isValidArea)
			{
				System.Drawing.Color color = this.image.GetPixel(x, y);
				if ((int)color.R < this.color_r && (int)color.G < this.color_g && (int)color.B < this.color_b)
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
			percentage = 100 - percentage;
			this.calcResult.Score = percentage;
			this.calcResult.ImageInBase64 = base.getResultImageInBase64();
		}
	}
}
