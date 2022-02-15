using System;
using System.Drawing;

namespace Generator
{
	public class Simple3d : IRender
	{
		public Simple3d()
		{
		}

		public void Free()
		{
		}

		public Bitmap Render(float[,] ResultGrid)
		{
			Bitmap bitmap = new Bitmap(ResultGrid.GetLength(0), ResultGrid.GetLength(1));
			bitmap.SetPixel(3, 3, Color.Green);
			return bitmap;
		}
	}
}