using System;

namespace Generator
{
	public class PerlinNoise : INoiseGenerator
	{
		private double[,] _ResultGrid;

		private int _seedOffset;

		private PerlinNoiseSettings _settings;

		private int[] _Primes = new int[] { 10719073, 10719077, 10719089, 10719109, 10719113, 10719119, 10719139, 10719143, 10719151, 10719157, 10719161, 10719187, 10719193, 10719199, 10719217, 10719227, 10719239, 10719251, 10719259, 10719301, 10719329, 10719343, 10719353, 10719377, 10719419, 10719421, 10719451, 10719463, 10719487, 10719497, 10719517, 10719523, 10719557, 10719601, 10719607, 10719613, 10719649, 10719659, 10719671, 10719691, 10719697, 10719701, 10719721, 10719733, 10719749, 10719767, 10719791, 10719811, 10719827, 10719829, 10719851, 10719853, 10719881, 10719883, 10719889, 10719913, 10719967, 10719997, 10720007, 10720019, 10720027, 10720033, 10720043, 10720069, 10720091, 10720153, 10720159, 10720163, 10720181, 10720187, 10720189, 10720211, 10720247, 10720249, 10720253, 10720261, 10720267, 10720271, 10720289, 10720309, 10720321, 10720337, 10720357, 10720399, 10720429, 10720433, 10720453, 10720471, 10720483, 10720487, 10720511, 10720519, 10720531, 10720573, 10720583, 10720601, 10720627, 10720663, 10720667, 10720679, 10720709, 10720711, 10720733, 10720751, 10720753, 10720771, 10720777, 10720781, 10720793, 10720799, 10720837, 10720859, 10720867, 10720873, 10720877, 10720891, 10720907, 10720939, 10720943, 10720951, 10720973, 10720979, 10720991, 10721003, 10721041, 10721047, 10721057, 10721077, 10721089, 10721099, 10721107, 10721141, 10721143, 10721153, 10721159, 10721219 };

		public INoiseSettings Settings
		{
			get
			{
				return this._settings;
			}
			set
			{
				this._settings = (PerlinNoiseSettings)value;
			}
		}

		public PerlinNoise()
		{
			this._settings = new PerlinNoiseSettings();
		}

		public void Free()
		{
			this._ResultGrid = null;
		}

		float[,] Generator.INoiseGenerator.Generate()
		{
			this._ResultGrid = new double[this._settings.ResultX, this._settings.ResultY];
			this._seedOffset = this._settings.RandomSeed;
			while (this._seedOffset >= (int)this._Primes.Length)
			{
				PerlinNoise length = this;
				length._seedOffset = length._seedOffset - (int)this._Primes.Length;
			}
			for (int i = 0; i < this._settings.ResultY; i++)
			{
				for (int j = 0; j < this._settings.ResultX; j++)
				{
					double num = this.PerlinNoise_2D((double)j / (double)this._settings.CorsenessX, (double)i / (double)this._settings.CorsenessY, this._settings.Octaves, this._settings.Persistence);
					this._ResultGrid[j, i] = num;
				}
			}
			return Common.ConvertDoubleArrayToFloat(this._ResultGrid);
		}

		private int GetPrime(int index)
		{
			int length = (int)this._Primes.Length;
			while (index >= length)
			{
				index = index - length;
			}
			return this._Primes[index];
		}

		private double InterpolatedNoise_2D(int octave, double x, double y)
		{
			int num = (int)Math.Floor(x);
			double num1 = x - (double)num;
			int num2 = (int)Math.Floor(y);
			double num3 = y - (double)num2;
			double num4 = this.SmoothNoise_2D(octave, num, num2);
			double num5 = this.SmoothNoise_2D(octave, num + 1, num2);
			double num6 = this.SmoothNoise_2D(octave, num, num2 + 1);
			double num7 = this.SmoothNoise_2D(octave, num + 1, num2 + 1);
			double num8 = Common.Cosine_Interpolate(num4, num5, num1);
			double num9 = Common.Cosine_Interpolate(num6, num7, num1);
			return Common.Cosine_Interpolate(num8, num9, num3);
		}

		public string Name()
		{
			return "Perlin";
		}

		private double Noise_2D(int octave, int x, int y)
		{
			double num;
			int num1 = this._seedOffset + octave * 3;
			int prime = this.GetPrime(num1);
			int prime1 = this.GetPrime(num1 + 1);
			int prime2 = this.GetPrime(num1 + 2);
			int num2 = x + y * 59;
			num2 = num2 << 13 ^ num2;
			int num3 = prime * num2 * num2 * num2 + prime1 * num2 + prime2;
			double num4 = (double)num3 / 2147483647;
			if (this._settings.FlatEdges)
			{
				if (x <= 0 | y <= 0 | x >= this._settings.ResultX / this._settings.CorsenessX | y >= this._settings.ResultY / this._settings.CorsenessY)
				{
					if (num4 > 0)
					{
						num = 0;
						return num;
					}
				}
			}
			num = num4;
			return num;
		}

		private double PerlinNoise_2D(double x, double y, int Number_Of_Octaves, double persistence)
		{
			double num = 0;
			double num1 = persistence;
			double numberOfOctaves = (double)(Number_Of_Octaves - 1);
			for (int i = 0; (double)i < numberOfOctaves; i++)
			{
				double num2 = Math.Pow(2, (double)i);
				double num3 = Math.Pow(num1, (double)i);
				num = num + this.InterpolatedNoise_2D(i, x * num2, y * num2) * num3;
			}
			return num;
		}

		private int ScaleNoise(double noise)
		{
			int num;
			if (noise > 1)
			{
				noise = 1;
			}
			if (noise < -1)
			{
				noise = -1;
			}
			num = (noise >= 0 ? (int)Math.Round(noise * 2147483647) : (int)Math.Round(Math.Abs(noise) * -2147483648));
			return num;
		}

		private double SmoothNoise_2D(int octave, int x, int y)
		{
			double num = (this.Noise_2D(octave, x - 1, y - 1) + this.Noise_2D(octave, x + 1, y - 1) + this.Noise_2D(octave, x - 1, y + 1) + this.Noise_2D(octave, x + 1, y + 1)) / 16;
			double num1 = (this.Noise_2D(octave, x - 1, y) + this.Noise_2D(octave, x + 1, y) + this.Noise_2D(octave, x, y - 1) + this.Noise_2D(octave, x, y + 1)) / 8;
			double num2 = this.Noise_2D(octave, x, y) / 4;
			return num + num1 + num2;
		}
	}
}