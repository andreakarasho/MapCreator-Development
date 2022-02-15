using System;

namespace Generator
{
	public class Normalize : IPostProcessor
	{
		private float m_UpperLimit;

		private float m_LowerLimit;

		public float LowerLimit
		{
			get
			{
				return this.m_LowerLimit;
			}
			set
			{
				this.m_LowerLimit = value;
			}
		}

		public float UpperLimit
		{
			get
			{
				return this.m_UpperLimit;
			}
			set
			{
				this.m_UpperLimit = value;
			}
		}

		public Normalize() : this(10000f, -10000f)
		{
		}

		public Normalize(float upperLimit, float lowerLimit)
		{
			this.m_UpperLimit = upperLimit;
			this.m_LowerLimit = lowerLimit;
		}

		public void Free()
		{
		}

		public float[,] Process(float[,] input)
		{
			int i;
			int j;
			float[,] singleArray = new float[input.GetLength(0), input.GetLength(1)];
			float single = float.MaxValue;
			float single1 = float.MinValue;
			float mUpperLimit = 1f;
			for (i = 0; i < input.GetLength(0); i++)
			{
				for (j = 0; j < input.GetLength(1); j++)
				{
					if (input[i, j] > single1)
					{
						single1 = input[i, j];
					}
					if (input[i, j] < single)
					{
						single = input[i, j];
					}
				}
			}
			float single2 = single1 - single;
			mUpperLimit = (this.m_UpperLimit - this.m_LowerLimit) / single2;
			for (i = 0; i < input.GetLength(0); i++)
			{
				for (j = 0; j < input.GetLength(1); j++)
				{
					double mLowerLimit = (double)(input[i, j] - single);
					mLowerLimit = mLowerLimit * (double)mUpperLimit;
					mLowerLimit = mLowerLimit + (double)this.m_LowerLimit;
					if (mLowerLimit > (double)this.m_UpperLimit)
					{
						mLowerLimit = (double)this.m_UpperLimit;
					}
					if (mLowerLimit < (double)this.m_LowerLimit)
					{
						mLowerLimit = (double)this.m_LowerLimit;
					}
					singleArray[i, j] = (float)mLowerLimit;
				}
			}
			single = float.MaxValue;
			single1 = float.MinValue;
			for (i = 0; i < singleArray.GetLength(0); i++)
			{
				for (j = 0; j < singleArray.GetLength(1); j++)
				{
					if (singleArray[i, j] > single1)
					{
						single1 = singleArray[i, j];
					}
					if (singleArray[i, j] < single)
					{
						single = singleArray[i, j];
					}
				}
			}
			return singleArray;
		}
	}
}