using Chap14Part2;
using System;

namespace Chap14Part2
{
   abstract class Shape
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

        abstract public string draw();       
        
        }
    }

    class Rectangle : Shape
    {
        private int width, height;

        public Rectangle(int newx, int newy, int newHeight, int newWidth):
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
            return "Drawing a rectangle at: " + base.X + ", " + base.Y + " Width: " + this.Width + ", Height: " + this.Height;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Shape aShape = new Shape(10, 30);
            Console.ReadKey();
        }
    }
}
