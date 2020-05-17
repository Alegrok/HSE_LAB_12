using System;
using System.Collections;
using System.Collections.Generic;


namespace HSE_LAB_12
{
	public class Tree<T> : IEnumerable<T>, ICloneable
	{
		public Point<T> root = null;
		List<T> list = new List<T>();

		public Tree()
		{
			root = null;
		}

		public Tree(params T[] arr)
		{
			foreach (T item in arr)
			{
				list.Add(item);
			}
			int i = 0;
			root = MakeTree(list.Count, root, ref i);
		}

		public int Count
		{
			get
			{
				return list.Count;
			}
		}

		Point<T> MakeTree(int size, Point<T> p, ref int i)
		{
			Point<T> r;
			int nl, nr;
			if (size == 0)
			{
				p = null;
				return p;
			}
			nl = size / 2;
			nr = size - nl - 1;
			r = new Point<T>(list[i]);
			i++;
			r.left = MakeTree(nl, r.left, ref i);
			r.right = MakeTree(nr, r.left, ref i);
			return r;
		}

		static void ShowTree(Point<T> p, int l)
		{
			if (p != null)
			{
				ShowTree(p.left, l + 3);
				for (int i = 0; i < l; i++) Console.Write(" ");
				Console.WriteLine(p.data);
				ShowTree(p.right, l + 3);
			}
		}

		public void Add(T d)
		{
			list.Add(d);
			int i = 0;
			root = MakeTree(list.Count, root, ref i);
		}

		public void Add(params T[] arr)
		{
			foreach (T item in arr)
			{
				list.Add(item);
			}
			int i = 0;
			root = MakeTree(list.Count, root, ref i);
		}

		public bool Find(T elem)
		{
			int i = 0;
			while (i < list.Count)
			{
				if (list[i].Equals(elem)) return true;
				i++;
			}
			return false;
		}

		public object Clone()
		{
			return root;
		}

		public object ShallowCopy()
		{
			return root;
		}

		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			int i = 0;
			while (i < list.Count)
			{
				yield return list[i];
				i++;
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public IEnumerator GetEnumerator()
		{
			return GetEnumerator();
		}

		public override int GetHashCode()
		{
			return root.GetHashCode() * Count;
		}

		public override bool Equals(object obj)
		{
			Tree<T> tmp = (Tree<T>)obj;
			return root.Equals(tmp.root);
		}
	}

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
