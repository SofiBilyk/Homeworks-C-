using System;

namespace Ex3
{
    class Rectangle
    {
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }
        public int GetRectangleArea()
        {
            return Width * Height;
        }
    }
    //квадрат наслідується від прямокутника!!!
    class Square : Rectangle
    {
        public override int Width
        {
            get { return base.Width; }
            set
            {
                base.Height = value;
                base.Width = value;
            }
        }
        public override int Height
        {
            get { return base.Height; }
            set
            {
                base.Height = value;
                base.Width = value;
            }
        }
    }
        class Program
        {
        public static void TestRectangleArea(Rectangle rect)
        {
            if (rect is Square)
            {
                rect.Height = 5;
                rect.Width = 10;
                if (rect.GetRectangleArea() != 25)
                    Console.WriteLine("Mistake");
            }
            else if (rect is Rectangle)
            {
                rect.Height = 5;
                rect.Width = 10;
                if (rect.GetRectangleArea() != 50)
                    Console.WriteLine("Mistake");
            }
        }
        static void Main(string[] args)
            {
                Rectangle rect = new Square();
                TestRectangleArea( rect);
                Console.WriteLine(rect.GetRectangleArea());
                Console.ReadKey();
            }
        }

   }

