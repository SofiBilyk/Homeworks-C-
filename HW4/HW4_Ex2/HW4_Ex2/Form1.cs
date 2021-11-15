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
        public double sideA, sideB, sideC;
        public string Message1, Message2, figure;
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
            figure = "Triangle";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Write the radius";
            label2.Text = "_";
            label4.Text = "_";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            figure = "Circle";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "Write the side";
            label2.Text = "_";
            label4.Text = "_";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            figure = "Square";
        }


        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "Write the sideA";
            label2.Text = "Write the sideB";
            label4.Text = "_";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            figure = "Rectangle";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = "Write the sideA";
            label2.Text = "Write the angle";
            label4.Text = "_";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            figure = "Thromb";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (figure == "Triangle")
            {
                sideA = double.Parse(textBox2.Text);
                sideB = double.Parse(textBox3.Text);
                sideC = double.Parse(textBox4.Text);
                Triangle triangle = new Triangle(sideA, sideB, sideC);
                textBox1.Text = triangle.Count();
            }
            else
            {
                if (figure == "Circle")
                {
                    sideA = double.Parse(textBox2.Text);
                    Circle circle = new Circle(sideA);
                    textBox1.Text = circle.Count();
                }
                else
                {
                    if (figure == "Square")
                    {
                        sideA = double.Parse(textBox2.Text);
                        Square square = new Square(sideA);
                        textBox1.Text = square.Count();
                    }
                    else
                    {
                        if (figure == "Rectangle")
                        {
                            sideA = double.Parse(textBox2.Text);
                            sideB = double.Parse(textBox3.Text);
                            Rectangle rectangle = new Rectangle(sideA, sideB);
                            textBox1.Text = rectangle.Count();
                        }
                        else
                        {
                            sideA = double.Parse(textBox2.Text);
                            sideB = double.Parse(textBox3.Text);
                            Rhomb rhomb = new Rhomb(sideA, sideB);
                            textBox1.Text = rhomb.Count();
                        }
                    }
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

    abstract class Figure
    {
        abstract public double CountS();
        abstract public double CountP();
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
            return Math.Sqrt(p * (p - a)*(p-b)*(p-c));
        }
        public string Count()
        {
            return "P = " + CountP() + "   S = " + CountS();
        }
    }

    class Circle : Figure
    {
        public double r;
        
        public Circle (double sideA)
        {
            r = sideA;
        }
        public override double CountP()
        {
            return 2 * Math.PI * r;
        }

        public override double CountS()
        {
            return Math.PI * r*r;
        }
        public string Count()
        {
            return "P = " + CountP() + "   S = " + CountS();
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
        public string Count()
        {
            return "P = " + CountP() + "   S = " + CountS();
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
            return (a+b) * 2;
        }

        public override double CountS()
        {
            return a * b;
        }
        public string Count()
        {
            return "P = " + CountP() + "   S = " + CountS();
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
            return a * a * Math.Sin(b*180/Math.PI);
        }
        public string Count()
        {
            return "P = " + CountP() + "   S = " + CountS();
        }
    }
}
