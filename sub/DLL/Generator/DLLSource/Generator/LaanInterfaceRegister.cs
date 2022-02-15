using Laan.Risk.Terrain.Generator;
using System;

namespace Generator
{
	public class LaanInterfaceRegister
	{
		public LaanInterfaceRegister()
		{
		}

		public static IGenerator[] RegisterGenerator()
		{
			int num = (new Random()).Next();
			int num1 = 129;
			IGenerator[] perlinGenerator = new IGenerator[] { new PerlinGenerator(num, num1), new KochSurfaceGenerator(num, num1) };
			return perlinGenerator;
		}
	}
}