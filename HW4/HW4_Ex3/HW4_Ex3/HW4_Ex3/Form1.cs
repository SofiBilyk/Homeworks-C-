using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW4_Ex3
{
    public partial class Form1 : Form
    {
        public double sideA, sideB, angle;
        public int Try(string a, string b, string c)
        {
            bool indicate = double.TryParse(a, out sideA);
            if (indicate == false || sideA <= 0)
            {
                return 0;
            }
            indicate = double.TryParse(b, out sideB);
            if (indicate == false || sideB <= 0)
            {
                return 0;
            }
            indicate = double.TryParse(c, out angle);
            if (indicate == false || angle <= 0)
            {
                return 0;
            }
            if (angle >= 180 || angle <= 0)
            {
                return 0;
            }
            return 1;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
            if (Try(textBox1.Text, textBox2.Text, textBox3.Text) == 0)
                label5.Text = "Write correct data";
            else
            {
                if (sideA == sideB)
                {
                    Issosceles triangle = new Issosceles(sideA, angle);
                    label5.Text = "The triangle is Isosceles";
                    textBox4.Text = triangle.Find();
                }
                else
                {
                    if (angle == 90)
                    {
                        Rectangular triangle = new Rectangular(sideA, sideB);
                        label5.Text = "The triangle is Rectangular";
                        textBox4.Text = triangle.Find();
                    }
                    else
                    {
                        Usual triangle = new Usual(sideA, sideB, angle);
                        label5.Text = "The triangle is Usual";
                        textBox4.Text = triangle.Find();
                    }
                }
            }

        }

        
    }

    abstract public class Triangle
    {
       public double a, b, an;
        virtual public double Square() 
        {
            return 0.5 * a * b * Math.Sin(an * Math.PI / 180);
        }
        virtual public double Perimetr() 
        {
            return a + b + Math.Sqrt(a * a + b * b - 2 * a * b * Math.Cos(an*Math.PI/180));
        }
        public string Find()
        {
            return "P = " + Perimetr().ToString() + "       S = " + Square().ToString();
        }
    }
    public class Usual : Triangle
    {
        public Usual(double sideA, double sideB, double angle)
        {
            a = sideA;
            b = sideB;
            an = angle;
        }

    }
    public class Issosceles : Triangle
    {
        public Issosceles(double sideA, double angle)
        {
            a = sideA;
            b = sideA;
            an = angle;
        }
        override public double Square()
        {
            return 0.5 * a * a * Math.Sin(an * Math.PI / 180);
        }
        virtual public double Perimetr()
        {
            return a + a + Math.Sqrt(a * a + a * a - 2 * a * a * Math.Cos(an * Math.PI / 180));
        }
    }

    public class Rectangular : Triangle
    {
        public Rectangular(double sideA, double sideB)
        {
            a = sideA;
            b = sideB;
            an = 90;
        }
        virtual public double Square() => a * b / 2;
        virtual public double Perimetr() => a + b + Math.Sqrt(a * a + b * b);
    }
}
