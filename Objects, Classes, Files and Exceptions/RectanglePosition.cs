using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_Position
{
	public class Rectangle
	{
		public int Left { get; set; }
		public int Top { get; set; }
		public int Width { get; set; }
		public int Height { get; set; }

		public int Right { get { return Left + Width; } }
		public int Bottom { get { return Top + Height; } }

		public bool IsInside(Rectangle r)
		{
			return (Left >= r.Left) && (Right <= r.Right) && (Top >= r.Top) && (Bottom <= r.Bottom);
		}

		public static Rectangle ReadRectangle()
		{
			var rectangleInfo = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

			Rectangle r = new Rectangle();

			r.Left = rectangleInfo[0];
			r.Top = rectangleInfo[1];
			r.Width = rectangleInfo[2];
			r.Height = rectangleInfo[3];

			return r;
		}

	}

	public class RectanglePosition : Rectangle
	{
		static void Main()
		{
			Rectangle r1 = ReadRectangle();
			Rectangle r2 = ReadRectangle();

			Console.WriteLine(r1.IsInside(r2) ? "Inside" : "Not Inside");
		}
	}
}
