using System;

namespace HSE_LAB_12
{
	public class Point<T> : ICloneable
	{
		public T data;
		public Point<T> left;
		public Point<T> right;

		public Point()
		{
			data = default(T);
			left = null;
			right = null;
		}

		public Point(T d)
		{
			data = d;
			left = null;
			right = null;
		}

		public Point(T d, Point<T> l, Point<T> p)
		{
			data = d;
			left = l;
			right = p;
		}

		public object Clone()
		{
			return new Point<T>(data, left, right);
		}

		public override string ToString()
		{
			return data.ToString() + " ";
		}
	}
}
