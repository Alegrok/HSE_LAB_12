using System;
using System.Collections.Generic;

namespace HSE_LAB_12
{
	public class PointTree
	{
		private Point root = null;
		List<Animals> list = new List<Animals>();

		public PointTree()
		{
			root = null;
		}

		public PointTree(Animals a)
		{
			list.Add(a);
			int i = 0;
			root = MakeTree(list.Count, root, ref i);
		}

		public Point Root
		{
			get
			{
				return root;
			}
		}

		public int Count
		{
			get
			{
				return list.Count;
			}
		}

		public void Add(Animals a)
		{
			list.Add(a);
			int i = 0;
			root = MakeTree(list.Count, root, ref i);
		}

		private Point MakeTree(int size, Point p, ref int i)
		{
			Point r;
			int nl, nr;
			if (size == 0)
			{
				p = null;
				return p;
			}
			nl = size / 2;
			nr = size - nl - 1;
			r = new Point(list[i]);
			i++;
			r.left = MakeTree(nl, r.left, ref i);
			r.right = MakeTree(nr, r.left, ref i);
			return r;
		}

		public void ShowTree(Point p, int l)
		{
			if (p != null)
			{
				ShowTree(p.left, l + 3);
				for (int i = 0; i < l; i++) Console.Write(" ");
				Console.WriteLine(p.data);
				ShowTree(p.right, l + 3);
			}
		}

		public Animals FindMax()
		{
			Animals max = new Animals();
			int i = 0;
			while (i < list.Count)
			{
				if (list[i].Weight > max.Weight) max = list[i];
				i++;
			}
			return max;
		}

		public void CreateFindTree()
		{
			Point beg = new Point(root.data);
			AddFindTree(beg, root);
			root = beg;
		}

		private void AddFindTree(Point beg, Point p)
		{
			if (p != null)
			{
				AddFindTree(beg, p.left);
				if (p.data != beg.data) AddFindTree(beg, p.data);
				AddFindTree(beg, p.right);
			}
		}

		private Point AddFindTree(Point root, Animals a)
		{
			Point p = root;
			Point r = null;
			bool ok = false;
			while (p != null && !ok)
			{
				r = p;
				if (a.Weight == p.data.Weight) ok = true;
				else if (a.Weight < p.data.Weight) p = p.left;
				else p = p.right;
			}
			if (ok) return p;
			Point NewPoint = new Point(a);
			if (a.Weight < r.data.Weight) r.left = NewPoint;
			else r.right = NewPoint;
			return NewPoint;
		}
	}

	public class Point
	{
		public Animals data;
		public Point left;
		public Point right;

		public Point()
		{
			data = default;
			left = null;
			right = null;
		}

		public Point(Animals d)
		{
			data = d;
			left = null;
			right = null;
		}

		public override string ToString()
		{
			return data.ToString() + " ";
		}
	}
}
