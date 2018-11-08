using System;
using System.Collections.Generic;

namespace Chap14Part4
{
    class Shape
    {
        private int x, y;

        public Shape(int newx, int newy)
        {
            x = newx;
            y = newy;
        }

        public int X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }

        public virtual string draw()
        {
            return "Drawing a shape at: " + this.X + ", " + this.Y;
        }
    }

    class Rectangle : Shape
    {
        private int width, height;

        public Rectangle(int newx, int newy, int newHeight, int newWidth) :
            base(newx, newy)
        {
            height = newHeight;
            width = newWidth;
        }

        public int Height
        {
            get
            {
                return height;
            }

            set
            {
                height = value;
            }
        }

        public int Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
            }
        }

        public override string draw()
        {
            {
                return "Drawing a rectangle at: " + base.X + ", " + base.Y + " Width: " + this.Width + ", Height: " + this.Height;
            }
        }
    }

    class Circle : Shape
    {
        private int radius;

        public Circle(int newx, int newy, int r)
            : base(newx, newy)
        {
            radius = r;
        }

        public override string draw()
        {
            {
                return "Drawing circle at " + X + " ," + Y + " with radius: " + radius;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            Shape s1 = new Shape(10, 20);
            shapes.Add(s1);
            Rectangle r1 = new Rectangle(1, 1, 10, 10);
            shapes.Add(r1);
            Circle c1 = new Circle(100, 200, 25);
            shapes.Add(c1);
            Rectangle r2 = new Rectangle(200, 300, 20, 30);
            shapes.Add(r2);

            for (int i = 0; i < shapes.Count; ++i)
                Console.WriteLine(shapes[i].draw());
            Console.ReadKey();
        }
    }
}
