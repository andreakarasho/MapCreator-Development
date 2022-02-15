using System;
using System.ComponentModel;

namespace Generator
{
	public class PerlinNoiseSettings : INoiseSettings
	{
		private int _numberOfOctaves = 5;

		private double _persistence = 0.7;

		private int _resultX = 7168;

		private int _resultY = 4096;

		private int _corsenessX = 10;

		private int _corsenessY = 10;

		private bool _flatEdges = false;

		private int _randomSeed = 0;

		[Category("Corseness")]
		[Description("Corseness on X.")]
		public int CorsenessX
		{
			get
			{
				return this._corsenessX;
			}
			set
			{
				this._corsenessX = value;
				if (this._corsenessX <= 1)
				{
					this._corsenessX = 2;
					throw new Exception("Corseness X must be 2 or greater.");
				}
			}
		}

		[Category("Corseness")]
		[Description("Corseness on Y.")]
		public int CorsenessY
		{
			get
			{
				return this._corsenessY;
			}
			set
			{
				this._corsenessY = value;
				if (this._corsenessY <= 1)
				{
					this._corsenessY = 2;
					throw new Exception("Corseness Y must be 2 or greater.");
				}
			}
		}

		[Category("General")]
		[Description("Edges will be zero or less.")]
		public bool FlatEdges
		{
			get
			{
				return this._flatEdges;
			}
			set
			{
				this._flatEdges = value;
			}
		}

		[Category("General")]
		[Description("Number of interations that will be run. More generates a finer noise.")]
		public int Octaves
		{
			get
			{
				return this._numberOfOctaves;
			}
			set
			{
				this._numberOfOctaves = value;
			}
		}

		[Category("General")]
		[Description("Persistence.")]
		public double Persistence
		{
			get
			{
				return this._persistence;
			}
			set
			{
				this._persistence = value;
			}
		}

		[Category("General")]
		[Description("Inital seed for random number generator. Zero means it is taken from the clock.")]
		public int RandomSeed
		{
			get
			{
				return this._randomSeed;
			}
			set
			{
				this._randomSeed = value;
			}
		}

		[Category("Result Size")]
		[Description("Width of resulting data.")]
		public int ResultX
		{
			get
			{
				return this._resultX;
			}
			set
			{
				this._resultX = value;
			}
		}

		[Category("Result Size")]
		[Description("Height of resulting data.")]
		public int ResultY
		{
			get
			{
				return this._resultY;
			}
			set
			{
				this._resultY = value;
			}
		}

		public PerlinNoiseSettings()
		{
		}
	}
}