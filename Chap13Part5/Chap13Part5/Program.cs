using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap13Part5
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

    class Rectangle: Shape
    {
        private int width, height; 

        public Rectangle(int newx, int newy, int newHeight, int newWidth) :base(newx, newy)
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
            return "Drawing at rectangle at: " + base.X + ", " + base.Y + ", " + "Width: " + this.Width + ", Height: " + this.Height;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Shape s1 = new Shape(10, 20);
            Console.WriteLine(s1.draw());

            Rectangle r1 = new Rectangle(30, 40, 10, 20);
            Console.WriteLine(r1.draw());

            Console.ReadKey();
        }
    }
}
