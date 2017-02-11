using System;
using System.Drawing;
namespace SkinTalkAPI.Calculator
{
	internal class InflammationCalculator : AbstractCalculator
	{
		private int pigmentSelected = 0;
		public InflammationCalculator(System.Drawing.Bitmap image) : base(image)
		{
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
				if (color.B + color.G < 100)
				{
					int redCounter = 0;
					for (int i = 0; i < 9; i++)
					{
						int tw = x + i / 3 - 1;
						int th = y + i % 3 - 1;
						if (tw >= 0 && th >= 0 && this.image.Width > tw && this.image.Height > th)
						{
							color = this.image.GetPixel(tw, th);
							if (color.B + color.G < 100)
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
			percentage = ((percentage < 50) ? (percentage + 10) : (percentage - 10));
			percentage = base.randomResult(percentage);
			this.calcResult.Score = percentage;
			this.calcResult.ImageInBase64 = base.getResultImageInBase64();
		}
	}
}
