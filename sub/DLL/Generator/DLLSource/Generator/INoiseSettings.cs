using System;

namespace Generator
{
	public interface INoiseSettings
	{
		int RandomSeed
		{
			get;
			set;
		}

		int ResultX
		{
			get;
			set;
		}

		int ResultY
		{
			get;
			set;
		}
	}
}