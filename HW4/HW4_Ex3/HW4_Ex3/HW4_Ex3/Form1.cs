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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sideA = double.Parse(textBox1.Text);
            sideB = double.Parse(textBox2.Text);
            angle = double.Parse(textBox3.Text);
            if (sideA == sideB)
            { 
                Issosceles triangle = new Issosceles(sideA, sideB, angle);
                label5.Text = "The triangle is Isosceles";
                textBox4.Text = triangle.Find();
            }
            else
            {
                if (angle == 90)
                { 
                    Rectangular triangle = new Rectangular(sideA, sideB, angle);
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

        private void textBox1_TextChanged(object sender, EventArgs e)
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
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    abstract public class Triangle
    {
       public double a, b, an;
        virtual public double Square() 
        {
            return a*b / 2;
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
        override public double Square()
        {
            return 0.5 * a * b * Math.Sin(an * Math.PI / 180);
        }

    }
    public class Issosceles : Triangle
    {
        public Issosceles(double sideA, double sideB, double angle)
        {
            a = sideA;
            b = sideB;
            an = angle;
        }
        override public double Square()
        {
            return 0.5 * a * a * Math.Sin(an * Math.PI / 180);
        }
        
    }

    public class Rectangular : Triangle
    {
        public Rectangular(double sideA, double sideB, double angle)
        {
            a = sideA;
            b = sideB;
            an = angle;
        }
       
    }
}
