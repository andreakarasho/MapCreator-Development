using System;

namespace Generator
{
	internal interface IPostProcessor
	{
		void Free();

		float[,] Process(float[,] input);
	}
}