using System;
using System.Collections;
using System.Drawing;
using System.Reflection;

namespace Generator
{
	public class ThreeDSpace
	{
		public ThreeDSpace.PointObjects pointObjects = new ThreeDSpace.PointObjects();

		public ThreeDSpace.Point3D viewpoint;

		public ThreeDSpace.Point3D screen;

		public ThreeDSpace()
		{
		}

		public PointF Render(ThreeDSpace.Point3D p)
		{
			PointF y = new Point();
			ThreeDSpace.Point3D point3D = this.viewpoint;
			ThreeDSpace.Point3D point3D1 = this.screen;
			y.Y = (p.Y - point3D.Y) * point3D1.Z / (p.Z - point3D.Z);
			y.X = (p.X - point3D.X) * point3D1.Z / (p.Z - point3D.Z);
			return y;
		}

		public class CubeObject : ThreeDSpace.RectangleObject
		{
			public CubeObject(float width, Color c) : base(width, width, width, c)
			{
			}

			public void Setup(float width, Color c)
			{
				base.Setup(width, width, width, c);
			}
		}

		public interface IPointObject
		{
			ThreeDSpace.Lines3D[] Lines
			{
				get;
				set;
			}

			ThreeDSpace.Point3D[] Points
			{
				get;
				set;
			}
		}

		public class LineObject : ThreeDSpace.IPointObject
		{
			private ThreeDSpace.Point3D _from;

			private ThreeDSpace.Point3D _to;

			ThreeDSpace.Lines3D[] Generator.ThreeDSpace.IPointObject.Lines
			{
				get
				{
					return this.GetLines();
				}
				set
				{
					throw new Exception("The method or operation is not implemented.");
				}
			}

			ThreeDSpace.Point3D[] Generator.ThreeDSpace.IPointObject.Points
			{
				get
				{
					return this.GetPoints();
				}
				set
				{
					throw new Exception("The method or operation is not implemented.");
				}
			}

			public LineObject(ThreeDSpace.Point3D from, ThreeDSpace.Point3D to)
			{
				this._from = from;
				this._to = to;
			}

			private ThreeDSpace.Lines3D[] GetLines()
			{
				ThreeDSpace.Lines3D[] lines3D = new ThreeDSpace.Lines3D[] { new ThreeDSpace.Lines3D(this._from, this._to) };
				return lines3D;
			}

			private ThreeDSpace.Point3D[] GetPoints()
			{
				return new ThreeDSpace.Point3D[] { this._from, this._to };
			}
		}

		public struct Lines3D
		{
			public ThreeDSpace.Point3D Start;

			public ThreeDSpace.Point3D End;

			public Lines3D(ThreeDSpace.Point3D start, ThreeDSpace.Point3D end)
			{
				this.Start = start;
				this.End = end;
			}
		}

		public struct Matrix
		{

		}

		public class MeshObject : ThreeDSpace.IPointObject
		{
			private float[,] _mesh;

			private Color _meshColor;

			private float _scale;

			ThreeDSpace.Lines3D[] Generator.ThreeDSpace.IPointObject.Lines
			{
				get
				{
					return this.GetLines();
				}
				set
				{
				}
			}

			ThreeDSpace.Point3D[] Generator.ThreeDSpace.IPointObject.Points
			{
				get
				{
					return this.GetPoints();
				}
				set
				{
				}
			}

			public float Scale
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

			public MeshObject(int meshX, int meshY, Color c)
			{
				this.Setup(meshX, meshY, c);
			}

			private ThreeDSpace.Lines3D[] GetLines()
			{
				int j;
				int length = this._mesh.GetLength(0);
				int num = this._mesh.GetLength(1);
				ThreeDSpace.Point3D[] points = this.GetPoints();
				ThreeDSpace.Lines3D[] lines3DArray = new ThreeDSpace.Lines3D[(length - 1) * num + length * (num - 1)];
				int num1 = 0;
				for (int i = 0; i < num; i++)
				{
					for (j = 0; j < length - 1; j++)
					{
						lines3DArray[num1].Start = points[i * length + j];
						lines3DArray[num1].End = points[i * length + j + 1];
						num1++;
					}
					if (i < num - 1)
					{
						for (j = 0; j < length; j++)
						{
							lines3DArray[num1].Start = points[i * length + j];
							lines3DArray[num1].End = points[(i + 1) * length + j];
							num1++;
						}
					}
				}
				return lines3DArray;
			}

			private ThreeDSpace.Point3D[] GetPoints()
			{
				int length = this._mesh.GetLength(0);
				int num = this._mesh.GetLength(1);
				ThreeDSpace.Point3D[] point3D = new ThreeDSpace.Point3D[length * num];
				int num1 = 0;
				float single = 1f / (float)(length - 1);
				float single1 = 1f / (float)(num - 1);
				for (int i = 0; i < length; i++)
				{
					for (int j = 0; j < num; j++)
					{
						point3D[num1] = new ThreeDSpace.Point3D(single * (float)i * this._scale, single1 * (float)j * this._scale, this._mesh[i, j] * this._scale, this._meshColor);
						num1++;
					}
				}
				return point3D;
			}

			public void Setup(int meshX, int meshY, Color c)
			{
				this._meshColor = c;
				this._mesh = new float[meshX, meshY];
			}
		}

		public struct Point3D
		{
			public float X;

			public float Y;

			public float Z;

			public Color color;

			public Point3D(float x, float y, float z, Color c)
			{
				this.X = x;
				this.Y = y;
				this.Z = z;
				this.color = c;
			}
		}

		public class PointObjects : ArrayList
		{
			public new ThreeDSpace.IPointObject this[int index]
			{
				get
				{
					return (ThreeDSpace.IPointObject)base[index];
				}
				set
				{
					base[index] = value;
				}
			}

			public PointObjects()
			{
			}

			public int Add(ThreeDSpace.IPointObject value)
			{
				return base.Add(value);
			}
		}

		public class RectangleObject : ThreeDSpace.IPointObject
		{
			private ThreeDSpace.Point3D[] _points;

			private ThreeDSpace.Lines3D[] _lines;

			ThreeDSpace.Lines3D[] Generator.ThreeDSpace.IPointObject.Lines
			{
				get
				{
					return this._lines;
				}
				set
				{
					this._lines = value;
				}
			}

			ThreeDSpace.Point3D[] Generator.ThreeDSpace.IPointObject.Points
			{
				get
				{
					return this._points;
				}
				set
				{
					this._points = value;
				}
			}

			public RectangleObject(float width, float height, float depth, Color c)
			{
				this.Setup(width, height, depth, c);
			}

			public void Setup(float width, float height, float depth, Color c)
			{
				this._points[0] = new ThreeDSpace.Point3D(0f, 0f, 0f, c);
				this._points[1] = new ThreeDSpace.Point3D(width, 0f, 0f, c);
				this._points[2] = new ThreeDSpace.Point3D(0f, height, 0f, c);
				this._points[3] = new ThreeDSpace.Point3D(width, height, 0f, c);
				this._points[4] = new ThreeDSpace.Point3D(0f, 0f, depth, c);
				this._points[5] = new ThreeDSpace.Point3D(width, 0f, depth, c);
				this._points[6] = new ThreeDSpace.Point3D(0f, height, depth, c);
				this._points[7] = new ThreeDSpace.Point3D(width, height, depth, c);
				this._lines[0] = new ThreeDSpace.Lines3D(this._points[0], this._points[1]);
				this._lines[1] = new ThreeDSpace.Lines3D(this._points[2], this._points[3]);
				this._lines[2] = new ThreeDSpace.Lines3D(this._points[0], this._points[2]);
				this._lines[3] = new ThreeDSpace.Lines3D(this._points[1], this._points[3]);
				this._lines[4] = new ThreeDSpace.Lines3D(this._points[4], this._points[5]);
				this._lines[5] = new ThreeDSpace.Lines3D(this._points[6], this._points[7]);
				this._lines[6] = new ThreeDSpace.Lines3D(this._points[4], this._points[6]);
				this._lines[7] = new ThreeDSpace.Lines3D(this._points[5], this._points[7]);
				this._lines[8] = new ThreeDSpace.Lines3D(this._points[0], this._points[4]);
				this._lines[9] = new ThreeDSpace.Lines3D(this._points[1], this._points[5]);
				this._lines[10] = new ThreeDSpace.Lines3D(this._points[2], this._points[6]);
				this._lines[11] = new ThreeDSpace.Lines3D(this._points[3], this._points[7]);
			}
		}
	}
}