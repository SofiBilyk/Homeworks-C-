using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW4_Ex2
{

    public partial class Form1 : Form
    {
        public enum Figure
        {
            TriangleF,
            CircleF,
            SquareF,
            RectangleF,
            ThrombF
        }
        public double TrySide(string a)
        {
            double A;
            bool indicate = double.TryParse(a, out A);
            if (indicate == false || A <= 0)
            {
                return 0;
            }
            return A;
        }
        public double TryAngle(string a)
        {
            double A;
            bool indicate = double.TryParse(a, out A);
            if (indicate == false || A <= 0 || A >= 180)
            {
                return 0;
            }
            
            return A;
        }
        public bool TryTriangle(double a, double b, double c)
        {
            
            if (a > b + c || b > a + c || c > b + a)
            {
                return false;
            }

            return true;
        }
        public double sideA, sideB, sideC;
        public string Message1, Message2;
        Figure figure;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Write the sideA";
            label2.Text = "Write the sideB";
            label4.Text = "Write the sideC";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            figure = Figure.TriangleF;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Write the radius";
            label2.Text = "_";
            label4.Text = "_";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            figure = Figure.CircleF;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "Write the side";
            label2.Text = "_";
            label4.Text = "_";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            figure = Figure.SquareF;
        }


        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "Write the sideA";
            label2.Text = "Write the sideB";
            label4.Text = "_";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            figure = Figure.RectangleF;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = "Write the sideA";
            label2.Text = "Write the angle";
            label4.Text = "_";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            figure = Figure.ThrombF;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            switch (figure)
            {
                case Figure.SquareF:
                    {
                        sideA = TrySide(textBox2.Text);
                        if (sideA != 0)
                        {
                            Square square = new Square(sideA);
                            textBox1.Text = square.Count();
                        }
                        else
                        textBox1.Text = "Write a correct data";
                        
                        break;
                    }
                case Figure.TriangleF:
                    {
                        sideA = TrySide(textBox2.Text);
                        sideB = TrySide(textBox3.Text);
                        sideC = TrySide(textBox4.Text);
                        if (sideA != 0 && sideB != 0 && sideC != 0 && TryTriangle(sideA, sideB, sideC))
                        {
                            Triangle triangle = new Triangle(sideA, sideB, sideC);
                            textBox1.Text = triangle.Count();
                        }
                        else
                        textBox1.Text = "Write a correct data";
                        
                        break;
                    }
                case Figure.CircleF:
                    {
                        sideA = TrySide(textBox2.Text);
                        if (sideA != 0)
                        {
                            Circle circle = new Circle(sideA);
                            textBox1.Text = circle.Count();
                        }
                        else
                        textBox1.Text = "Write a correct data";
                        
                        break;
                    }
                case Figure.RectangleF:
                    {
                        sideA = TrySide(textBox2.Text);
                        sideB = TrySide(textBox3.Text);
                        if (sideA != 0 && sideB != 0)
                        {
                            Rectangle rectangle = new Rectangle(sideA, sideB);
                            textBox1.Text = rectangle.Count();
                        }
                        else
                        textBox1.Text = "Write a correct data";
                        
                        break;
                    }
                case Figure.ThrombF:
                    {
                        sideA = TrySide(textBox2.Text);
                        sideB = TrySide(textBox3.Text);
                        if (sideA != 0 && sideB != 0 && TryAngle(textBox3.Text) != 0)
                        {
                            Rhomb rhomb = new Rhomb(sideA, sideB);
                            textBox1.Text = rhomb.Count();
                        }
                        else
                        textBox1.Text = "Write a correct data";
                        
                        break;
                    }
            }
           
                
                    
                    
                
            
        }
    }

    abstract class Figure
    {
        abstract public double CountS();
        abstract public double CountP();
        public string Count()
        {
            return "P = " + CountP() + "   S = " + CountS();
        }
    }

    class Triangle : Figure
    {
        public double a;
        public double b;
        public double c;
        public double p;
        public Triangle(double sideA, double sideB, double sideC)
        {
            a = sideA;
            b = sideB;
            c = sideC;
            p = (a + b + c) / 2;
        }

        public override double CountP()
        {
            return a + b + c;
        }

        public override double CountS()
        {
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));

        }
    }
        class Circle : Figure
        {
            public double r;

            public Circle(double sideA)
            {
                r = sideA;
            }
            public override double CountP()
            {
                return 2 * Math.PI * r;
            }

            public override double CountS()
            {
                return Math.PI * r * r;
            }
        }

        class Square : Figure
        {
            public double a;
            public Square(double sideA)
            {
                a = sideA;
            }
            public override double CountP()
            {
                return a * 4;
            }

            public override double CountS()
            {
                return a * a;
            }
        }

        class Rectangle : Figure
        {
            public double a;
            public double b;
            public Rectangle(double sideA, double sideB)
            {
                a = sideA;
                b = sideB;
            }
            public override double CountP()
            {
                return (a + b) * 2;
            }

            public override double CountS()
            {
                return a * b;
            }
        }

        class Rhomb : Figure
        {
            public double a;
            public double b;
            public Rhomb(double sideA, double sideB)
            {
                a = sideA;
                b = sideB;
            }
            public override double CountP()
            {
                return a * 4;
            }

            public override double CountS()
            {
                return a * a * Math.Sin(b * 180 / Math.PI);
            }

        }
    
}
