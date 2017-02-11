using System;
using System.Drawing;
namespace SkinTalkAPI.Calculator
{
	internal class InstallLensCalculator : AbstractCalculator
	{
		private int blackCount = 0;
		private int whiteCount = 0;
		public InstallLensCalculator(System.Drawing.Bitmap image) : base(image)
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
				int colorPointTotal = (int)(color.R + color.G + color.B);
				if (colorPointTotal > 50 && colorPointTotal < 300)
				{
					this.blackCount++;
				}
				else
				{
					if (colorPointTotal >= 380)
					{
						this.whiteCount++;
					}
				}
			}
		}
		protected override float invalidZoneWidthPrecentage()
		{
			return 0.1f;
		}
		protected override float invalidZoneHeightPrecentage()
		{
			return 0f;
		}
		protected override void processResult()
		{
			int blackPrecent = (int)((float)this.blackCount / (float)this.totalPixelPoint * 100f);
			int whitePrecent = (int)((float)this.whiteCount / (float)this.totalPixelPoint * 100f);
			if (blackPrecent >= 35 && whitePrecent >= 24)
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
