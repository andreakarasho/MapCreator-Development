using System;
using System.Drawing;

namespace Generator
{
	public class Render2D : IRender
	{
		private TerranValues _settings;

		private float _boundsMin = float.MinValue;

		private float _boundsMax = float.MaxValue;

		public float BoundsMax
		{
			get
			{
				return this._boundsMax;
			}
			set
			{
				this._boundsMax = value;
			}
		}

		public float BoundsMin
		{
			get
			{
				return this._boundsMin;
			}
			set
			{
				this._boundsMin = value;
			}
		}

		public Render2D()
		{
			this._settings = new TerranValues();
		}

		public void Free()
		{
		}

		public Bitmap Render(float[,] ResultGrid)
		{
			return this.RenderGreyscale(ResultGrid);
		}

		public Bitmap RenderClouds(float[,] ResultGrid)
		{
			Bitmap bitmap = new Bitmap(ResultGrid.GetLength(0), ResultGrid.GetLength(1));
			for (int i = 0; i < ResultGrid.GetLength(1); i++)
			{
				for (int j = 0; j < ResultGrid.GetLength(0); j++)
				{
					bitmap.SetPixel(j, i, this.ScaleTwoColor(ResultGrid[j, i], Color.Blue, Color.White));
				}
			}
			return bitmap;
		}

		public Bitmap RenderFire(float[,] ResultGrid)
		{
			Bitmap bitmap = new Bitmap(ResultGrid.GetLength(0), ResultGrid.GetLength(1));
			for (int i = 0; i < ResultGrid.GetLength(1); i++)
			{
				for (int j = 0; j < ResultGrid.GetLength(0); j++)
				{
					bitmap.SetPixel(j, i, this.ScaleThreeColor(ResultGrid[j, i], Color.Orange, Color.Red, Color.Black));
				}
			}
			return bitmap;
		}

		public Bitmap RenderFire2(float[,] ResultGrid)
		{
			Bitmap bitmap = new Bitmap(ResultGrid.GetLength(0), ResultGrid.GetLength(1));
			for (int i = 0; i < ResultGrid.GetLength(1); i++)
			{
				for (int j = 0; j < ResultGrid.GetLength(0); j++)
				{
					bitmap.SetPixel(j, i, this.ScaleThreeColor(ResultGrid[j, i], Color.Red, Color.Orange, Color.Black));
				}
			}
			return bitmap;
		}

		public Bitmap RenderGreyscale(float[,] ResultGrid)
		{
			Bitmap bitmap = new Bitmap(ResultGrid.GetLength(0), ResultGrid.GetLength(1));
			for (int i = 0; i < ResultGrid.GetLength(0); i++)
			{
				for (int j = 0; j < ResultGrid.GetLength(1); j++)
				{
					bitmap.SetPixel(i, j, this.ScaleGreyscale(ResultGrid[i, j]));
				}
			}
			return bitmap;
		}

		public Bitmap RenderRainbow(float[,] ResultGrid)
		{
			Bitmap bitmap = new Bitmap(ResultGrid.GetLength(0), ResultGrid.GetLength(1));
			for (int i = 0; i < ResultGrid.GetLength(1); i++)
			{
				for (int j = 0; j < ResultGrid.GetLength(0); j++)
				{
					bitmap.SetPixel(j, i, this.ScaleThreeColor(ResultGrid[j, i], Color.Red, Color.Lime, Color.Blue));
				}
			}
			return bitmap;
		}

		public Bitmap RenderTerran(float[,] ResultGrid)
		{
			Bitmap bitmap = new Bitmap(ResultGrid.GetLength(0), ResultGrid.GetLength(1));
			for (int i = 0; i < ResultGrid.GetLength(0); i++)
			{
				for (int j = 0; j < ResultGrid.GetLength(1); j++)
				{
					bitmap.SetPixel(i, j, this.ScaleTerran(ResultGrid[i, j], this._settings));
				}
			}
			return bitmap;
		}

		private Color ScaleGreyscale(float val)
		{
			float single = this._boundsMax - this._boundsMin;
			float single1 = 255f / single * val;
			int num = (int)Math.Round((double)single1);
			return Color.FromArgb(num, num, num);
		}

		private Color ScaleTerran(float val, TerranValues vals)
		{
			Color color;
			float single = this._boundsMax - this._boundsMin;
			if (val <= this._boundsMax * vals.waterLevel)
			{
				color = vals.waterColor;
			}
			else if (val <= this._boundsMax * vals.beachLevel)
			{
				color = vals.beachColor;
			}
			else if (val <= this._boundsMax * vals.grassLevel)
			{
				color = vals.grassColor;
			}
			else if (val > this._boundsMax * vals.moutainLevel)
			{
				color = (val > this._boundsMax * vals.snowLevel ? Color.Red : vals.snowColor);
			}
			else
			{
				color = vals.moutainColor;
			}
			return color;
		}

		private Color ScaleThreeColor(float val, Color color1, Color color2, Color color3)
		{
			int r;
			int g;
			int b;
			float single;
			float single1 = (this._boundsMax - this._boundsMin) / 2f;
			if (val == this._boundsMin)
			{
				r = color1.R;
				g = color1.G;
				b = color1.B;
			}
			else if (val == single1)
			{
				r = color2.R;
				g = color2.G;
				b = color2.B;
			}
			else if (val == this._boundsMax)
			{
				r = color3.R;
				g = color3.G;
				b = color3.B;
			}
			else if (val >= single1)
			{
				if (val >= this._boundsMax)
				{
					throw new Exception("Out of range :(");
				}
				single = (val - single1) / (this._boundsMax - single1);
				r = (int)Math.Round(Common.Linear_Interpolate((double)color2.R, (double)color3.R, (double)single));
				g = (int)Math.Round(Common.Linear_Interpolate((double)color2.G, (double)color3.G, (double)single));
				b = (int)Math.Round(Common.Linear_Interpolate((double)color2.B, (double)color3.B, (double)single));
			}
			else
			{
				single = val / single1;
				r = (int)Math.Round(Common.Linear_Interpolate((double)color1.R, (double)color2.R, (double)single));
				g = (int)Math.Round(Common.Linear_Interpolate((double)color1.G, (double)color2.G, (double)single));
				b = (int)Math.Round(Common.Linear_Interpolate((double)color1.B, (double)color2.B, (double)single));
			}
			return Color.FromArgb(r, g, b);
		}

		private Color ScaleTwoColor(float val, Color color1, Color color2)
		{
			float single = (float)val / (this._boundsMax - this._boundsMin);
			int num = (int)Math.Round(Common.Linear_Interpolate((double)color1.R, (double)color2.R, (double)single));
			int num1 = (int)Math.Round(Common.Linear_Interpolate((double)color1.G, (double)color2.G, (double)single));
			int num2 = (int)Math.Round(Common.Linear_Interpolate((double)color1.B, (double)color2.B, (double)single));
			return Color.FromArgb(num, num1, num2);
		}
	}
}