using System;

namespace Generator
{
	public class Common
	{
		public Common()
		{
		}

		public static float[,] ConvertDoubleArrayToFloat(double[,] arr)
		{
			float[,] singleArray = new float[checked((int)arr.GetLongLength(0)), checked((int)arr.GetLongLength(1))];
			for (int i = 0; (long)i < arr.GetLongLength(0); i++)
			{
				for (int j = 0; (long)j < arr.GetLongLength(0); j++)
				{
					if (arr[i, j] >= 3.40282346638529E+38)
					{
						singleArray[i, j] = float.MaxValue;
					}
					else if (arr[i, j] > -3.40282346638529E+38)
					{
						singleArray[i, j] = (float)arr[i, j];
					}
					else
					{
						singleArray[i, j] = float.MinValue;
					}
				}
			}
			return singleArray;
		}

		public static double Cosine_Interpolate(double a, double b, double x)
		{
			double num = x * 3.14159274101257;
			double num1 = (double)(1 - Math.Cos((double)num)) * 0.5;
			double num2 = a * (1 - num1) + b * num1;
			return num2;
		}

		public static double Cubic_Interpolate(double v0, double v1, double v2, double v3, double x)
		{
			double num = v3 - v2 - (v0 - v1);
			double num1 = v0 - v1 - num;
			double num2 = v2 - v0;
			double num3 = v1;
			double num4 = (double)(num * Math.Pow(x, 3) + num1 * Math.Pow(x, 2) + num2 * x + num3);
			return num4;
		}

		public static double Linear_Interpolate(double a, double b, double x)
		{
			double num = a * (1 - x) + b * x;
			return num;
		}
	}
}