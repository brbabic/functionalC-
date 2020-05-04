using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
	public class ImmutableExample
	{
		public void StartExample ()
		{
			Rectangle r = new Rectangle();
			r.Height = 5;
			r.Length = 10;
			r.Grow(10, 10);

			ImmutableRectangle ir = new ImmutableRectangle(5, 10);
			ir.Grow(10, 10);
		}
	}

	#region Imumtable 
	public class ImmutableRectangle
	{
		int Length { get; }
		int Height { get; }

		public ImmutableRectangle(int length, int height)
		{
			Length = length;
			Height = height;
		}

		public ImmutableRectangle Grow(int length, int height) =>
			new ImmutableRectangle(Length + length, Height + height);
	}

	public class Rectangle
	{
		public int Length { get; set; }
		public int Height { get; set; }

		public void Grow(int length, int height)
		{
			Length += length;
			Height += height;
		}
	}
	#endregion
}
