using System;

namespace Generator
{
	public interface INoiseGenerator
	{
		INoiseSettings Settings
		{
			get;
			set;
		}

		void Free();

		float[,] Generate();

		string Name();
	}
}