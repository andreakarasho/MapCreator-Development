using Laan.Risk.Terrain.Generator;
using System;
using System.Drawing;

namespace Generator
{
	public class PerlinGenerator : IGenerator
	{
		private INoiseSettings _settings;

		public PerlinGenerator(int seed, int size)
		{
			PerlinNoiseSettings perlinNoiseSetting = new PerlinNoiseSettings()
			{
				RandomSeed = seed,
				ResultX = size,
				ResultY = size
			};
			this._settings = perlinNoiseSetting;
		}

		public string DisplayName()
		{
			return "Bevan - Perlin";
		}

		public Bitmap Execute()
		{
			INoiseGenerator perlinNoise = new PerlinNoise()
			{
				Settings = this._settings
			};
			float[,] singleArray = perlinNoise.Generate();
			perlinNoise.Free();
			perlinNoise = null;
			IPostProcessor normalize = new Normalize();
			singleArray = normalize.Process(singleArray);
			normalize.Free();
			normalize = null;
			Render2D render2D = new Render2D();
			Bitmap bitmap = render2D.RenderGreyscale(singleArray);
			render2D.Free();
			render2D = null;
			return bitmap;
		}

		public object Properties()
		{
			return this._settings;
		}
	}
}