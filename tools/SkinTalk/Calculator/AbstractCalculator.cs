using AForge.Imaging;
using AForge.Imaging.Filters;
using SkinTalkAPI.Model;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
namespace SkinTalkAPI.Calculator
{
	internal abstract class AbstractCalculator
	{
		public ImageInfo calcResult;
		protected System.Drawing.Bitmap image;
		protected System.Drawing.Bitmap cloneImage;
		protected int totalPixelPoint;
		protected int color_r;
		protected int color_g;
		protected int color_b;
		private Random random;
		public AbstractCalculator(System.Drawing.Bitmap image)
		{
			this.random = new Random();
			this.calcResult = new ImageInfo();
			this.image = image;
			this.cloneImage = AForge.Imaging.Image.Clone(this.image);
		}
		public void setSpecifyColor(int r, int g, int b)
		{
			this.color_r = r;
			this.color_g = g;
			this.color_b = b;
		}
		public virtual void calculate()
		{
			this.totalPixelPoint = (int)((float)this.image.Width * (1f - this.invalidZoneWidthPrecentage()) * (float)this.image.Height * (1f - this.invalidZoneHeightPrecentage()));
			int validZoneMinX = (int)((float)this.image.Width * this.invalidZoneWidthPrecentage());
			int validZoneMaxX = this.image.Width - validZoneMinX;
			int validZoneMinY = (int)((float)this.image.Height * this.invalidZoneHeightPrecentage());
			int validZoneMaxY = this.image.Height - validZoneMinY;
			for (int i = 0; i < this.image.Width; i++)
			{
				for (int j = 0; j < this.image.Height; j++)
				{
					bool isValidArea = false;
					if (i >= validZoneMinX && i <= validZoneMaxX && j >= validZoneMinY && j <= validZoneMaxY)
					{
						isValidArea = true;
					}
					this.processPixel(i, j, isValidArea);
				}
			}
			this.processResult();
		}
		public static System.Drawing.Bitmap cropImage(System.Drawing.Bitmap source, System.Drawing.Rectangle section)
		{
			return source.Clone(section, source.PixelFormat);
		}
		protected void convertToGrayPicture()
		{
			FiltersSequence PigmentFilter = new FiltersSequence(new IFilter[]
			{
				Grayscale.CommonAlgorithms.BT709
			});
			this.image = PigmentFilter.Apply(this.image);
		}
		protected void convertToInvertPicture()
		{
			try
			{
				for (int i = 0; i < this.image.Width; i++)
				{
					for (int j = 0; j < this.image.Height; j++)
					{
						System.Drawing.Color color = this.image.GetPixel(i, j);
						this.image.SetPixel(i, j, System.Drawing.Color.FromArgb((int)(255 - color.R), (int)(255 - color.G), (int)(255 - color.B)));
					}
				}
			}
			catch (ArgumentException)
			{
				Console.Write("There was an error.Check the path to the image file.");
			}
		}
		protected string getResultImageInBase64()
		{
			string result;
			using (Stream sc = new MemoryStream())
			{
				this.cloneImage.Save(sc, System.Drawing.Imaging.ImageFormat.Jpeg);
				string uniqueFilename = string.Format("{0}.jpg", Guid.NewGuid());
				result = Convert.ToBase64String(this.ConvertMemoryStreamToByteArray(sc));
			}
			return result;
		}
		protected int randomResult(int tempPercentage)
		{
			if (tempPercentage >= 100)
			{
				tempPercentage = this.random.Next(92, 99);
			}
			else
			{
				if (tempPercentage <= 5)
				{
					tempPercentage = this.random.Next(1, 15);
				}
			}
			return tempPercentage;
		}
		private byte[] ConvertMemoryStreamToByteArray(Stream ms)
		{
			byte[] result = new byte[ms.Length];
			ms.Position = 0L;
			ms.Read(result, 0, (int)ms.Length);
			return result;
		}
		protected abstract float invalidZoneWidthPrecentage();
		protected abstract float invalidZoneHeightPrecentage();
		protected abstract void processPixel(int x, int y, bool isValidArea);
		protected abstract void processResult();
	}
}
