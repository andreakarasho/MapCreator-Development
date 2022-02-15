using System;

namespace Generator
{
	public class KochLikeNoise : INoiseGenerator
	{
		private Random _rnd;

		private KochLikeNoiseSettings _settings;

		public INoiseSettings Settings
		{
			get
			{
				return this._settings;
			}
			set
			{
				this._settings = (KochLikeNoiseSettings)value;
			}
		}

		public KochLikeNoise()
		{
			this._settings = new KochLikeNoiseSettings();
		}

		private void FillGrid(ref double[,] grid, double[,] prevGrid, double scale, double n, double H)
		{
			double num;
			int i;
			int j;
			if (n != 0)
			{
				for (i = 0; i < prevGrid.GetLength(0); i++)
				{
					for (j = 0; j < prevGrid.GetLength(0); j++)
					{
						grid[i * 2, j * 2] = prevGrid[i, j];
					}
				}
				double num1 = Math.Pow(0.5, n * H / 2) * scale;
				for (i = 0; i < grid.GetLength(0); i++)
				{
					for (j = 0; j < grid.GetLength(0); j++)
					{
						if ((i % 2 != 0 ? true : j % 2 != 0))
						{
							if (i % 2 != 0)
							{
								num = (j % 2 != 0 ? (grid[i - 1, j - 1] + grid[i + 1, j - 1] + grid[i - 1, j + 1] + grid[i + 1, j + 1]) / 4 : (grid[i - 1, j] + grid[i + 1, j]) / 2);
							}
							else
							{
								num = (grid[i, j - 1] + grid[i, j + 1]) / 2;
							}
							grid[i, j] = num + this.GetRand() * num1;
						}
					}
				}
			}
			else
			{
				for (i = 0; i < grid.GetLength(0); i++)
				{
					for (j = 0; j < grid.GetLength(0); j++)
					{
						grid[i, j] = this.GetRand() * scale;
					}
				}
			}
		}

		public void Free()
		{
		}

		float[,] Generator.INoiseGenerator.Generate()
		{
			if (this._settings.RandomSeed == 0)
			{
				this._rnd = new Random();
			}
			else
			{
				this._rnd = new Random(this._settings.RandomSeed);
			}
			int initalGridX = this._settings.InitalGridX;
			int initalGridY = this._settings.InitalGridY;
			double[,] numArray = null;
			double num = 0;
			while (true)
			{
				if ((initalGridX > this.Settings.ResultX ? true : initalGridY > this.Settings.ResultY))
				{
					break;
				}
				double[,] numArray1 = numArray;
				numArray = new double[initalGridX, initalGridY];
				this.FillGrid(ref numArray, numArray1, this._settings.Scale, num, this._settings.H);
				initalGridX = initalGridX * 2 - 1;
				initalGridY = initalGridY * 2 - 1;
				num = num + 1;
			}
			return Common.ConvertDoubleArrayToFloat(numArray);
		}

		private double GetRand()
		{
			double num = this._rnd.NextDouble() * (double)(this._settings.RandomMax - this._settings.RandomMin) + (double)this._settings.RandomMin;
			return num;
		}

		public string Name()
		{
			return "Koch Surface (square)";
		}
	}
}