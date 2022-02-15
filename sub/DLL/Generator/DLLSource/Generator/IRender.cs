using System;
using System.Drawing;

namespace Generator
{
	internal interface IRender
	{
		void Free();

		Bitmap Render(float[,] ResultGrid);
	}
}