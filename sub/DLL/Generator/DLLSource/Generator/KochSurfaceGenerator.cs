using Laan.Risk.Terrain.Generator;
using System;
using System.Drawing;

namespace Generator
{
	public class KochSurfaceGenerator : IGenerator
	{
		private INoiseSettings _settings;

		public KochSurfaceGenerator(int seed, int size)
		{
			KochLikeNoiseSettings kochLikeNoiseSetting = new KochLikeNoiseSettings()
			{
				RandomSeed = seed,
				ResultX = size,
				ResultY = size
			};
			this._settings = kochLikeNoiseSetting;
		}

		public string DisplayName()
		{
			return "Bevan - Koch Surface";
		}

		public Bitmap Execute()
		{
			INoiseGenerator kochLikeNoise = new KochLikeNoise()
			{
				Settings = this._settings
			};
			float[,] singleArray = kochLikeNoise.Generate();
			kochLikeNoise.Free();
			kochLikeNoise = null;
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