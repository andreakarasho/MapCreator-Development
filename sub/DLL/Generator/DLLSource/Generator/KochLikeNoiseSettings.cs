using System;
using System.ComponentModel;

namespace Generator
{
	public class KochLikeNoiseSettings : INoiseSettings
	{
		private int _resultX = 7168;

		private int _resultY = 4096;

		private int _initalGridX = 2;

		private int _initalGridY = 2;

		private int _randomSeed = 0;

		private int _rndMin = -1;

		private int _rndMax = 1;

		private double _h = 1;

		private double _scale = 1;

		[Category("Settings")]
		[Description("H controls roughness. 1-2 is good for landscapes, 3 or more is practicaly a gradiant, less then 0.5 is very rough.")]
		public double H
		{
			get
			{
				return this._h;
			}
			set
			{
				this._h = value;
			}
		}

		[Category("Settings")]
		[Description("Inital Grid X.")]
		public int InitalGridX
		{
			get
			{
				return this._initalGridX;
			}
			set
			{
				this._initalGridX = value;
			}
		}

		[Category("Settings")]
		[Description("Inital Grid Y.")]
		public int InitalGridY
		{
			get
			{
				return this._initalGridY;
			}
			set
			{
				this._initalGridY = value;
			}
		}

		[Category("Random")]
		[Description("Maximum value for random.")]
		public int RandomMax
		{
			get
			{
				return this._rndMax;
			}
			set
			{
				this._rndMax = value;
			}
		}

		[Category("Random")]
		[Description("Minimum value for random.")]
		public int RandomMin
		{
			get
			{
				return this._rndMin;
			}
			set
			{
				this._rndMin = value;
			}
		}

		[Category("Random")]
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

		[Category("Settings")]
		[Description("Scale controls height. Not much use when normalising.")]
		public double Scale
		{
			get
			{
				return this._scale;
			}
			set
			{
				this._scale = value;
			}
		}

		public KochLikeNoiseSettings()
		{
		}
	}
}