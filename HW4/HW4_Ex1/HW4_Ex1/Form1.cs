using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW4_Ex1
{

    public class Triangle
    {
        public double p;
        double A;
        double B;
        double C;
    }
    public partial class Form1 : Form
    {

        Triangle tr = new Triangle();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tr.p = tr.p + double.Parse(textBox1.Text) + double.Parse(textBox2.Text) + double.Parse(textBox3.Text);
            textBox4.Text = p.ToString();
            tr.p = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tr.A = Math.Acos((Math.Pow(double.Parse(textBox2.Text),2)+ Math.Pow(double.Parse(textBox3.Text), 2) - Math.Pow(double.Parse(textBox1.Text), 2))/(2* double.Parse(textBox2.Text)* double.Parse(textBox3.Text))) * 180 / Math.PI;
            textBox5.Text = tr.A.ToString();
            tr.B = Math.Acos((Math.Pow(double.Parse(textBox1.Text), 2) + Math.Pow(double.Parse(textBox3.Text), 2) - Math.Pow(double.Parse(textBox2.Text), 2)) / (2 * double.Parse(textBox1.Text) * double.Parse(textBox3.Text))) * 180 / Math.PI;
            textBox6.Text = B.ToString();
            C = Math.Acos((Math.Pow(double.Parse(textBox2.Text), 2) + Math.Pow(double.Parse(textBox1.Text), 2) - Math.Pow(double.Parse(textBox3.Text), 2)) / (2 * double.Parse(textBox2.Text) * double.Parse(textBox1.Text))) * 180 / Math.PI;
            textBox7.Text = C.ToString();
        }

       private void textBox1_TextChanged (object sender, EventArgs e)
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
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
