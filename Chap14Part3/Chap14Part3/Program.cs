using System;

namespace Chap14Part3
{
    public interface Shape
    {
        void setX(int newx);
        void setY(int newY);
        int getX();
        int getY();
        void move(int newx, int newy);
        void draw();
    }

    public class Rectangle : Shape
    {
        int x, y, width, height;

        public Rectangle(int newx, int newy, int neww, int newh)
        {
            x = newx;
            y = newy;
            width = neww;
            height = newh;
        }

       public  void setX(int newx)
        {
            x = newx;
        }

       public  void setY(int newy)
        {
            y = newy;
        }

        public int getX()
        {
            return x;
        }

        public int getY()
        {
            return y;
        }

        public void move (int newx, int newy)
        {
            x = newx;
            y = newy;
        }

        public void draw()
        {
            Console.WriteLine("drawing a rectangle at " + x + ", " + y);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(10, 15, 20, 25);
            rect.draw();
            Console.ReadKey();
        }
    }
}
