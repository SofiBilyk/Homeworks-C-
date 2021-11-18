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
    public partial class Form2 : Form
    {
        public class Triangle
        {
            public double p = 0;
            public double A = 0;
            public double B = 0;
            public double C = 0;

            public int Try(string a, string b, string c)
            {
                bool indicate = double.TryParse(a, out A);
                if(indicate == false || A <= 0)
                {
                    return 0;
                }
                indicate = double.TryParse(b, out B);
                if (indicate == false || B <= 0)
                {
                    return 0;
                }
                indicate = double.TryParse(c, out C);
                if (indicate == false || C <= 0)
                {
                    return 0;
                }
                if (A > B + C || B > A + C || C > B + A)
                {
                    return 0;
                }
                return 1;
            }
        }

        Triangle tr = new Triangle();
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

           if(tr.Try(textBox1.Text, textBox2.Text, textBox3.Text) == 1)
            {
                        tr.p = tr.A + tr.B + tr.C;
                        textBox4.Text = tr.p.ToString();
                        tr.p = 0;
            }
                else
                    {
                        textBox4.Text = "There isn1t any triangle like that";
                    }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(tr.Try(textBox1.Text, textBox2.Text, textBox3.Text) == 1)
                    {
                        tr.A = Math.Acos((Math.Pow(double.Parse(textBox2.Text), 2) + Math.Pow(double.Parse(textBox3.Text), 2) - Math.Pow(double.Parse(textBox1.Text), 2)) / (2 * double.Parse(textBox2.Text) * double.Parse(textBox3.Text))) * 180 / Math.PI;
                        textBox5.Text = tr.A.ToString();
                        tr.B = Math.Acos((Math.Pow(double.Parse(textBox1.Text), 2) + Math.Pow(double.Parse(textBox3.Text), 2) - Math.Pow(double.Parse(textBox2.Text), 2)) / (2 * double.Parse(textBox1.Text) * double.Parse(textBox3.Text))) * 180 / Math.PI;
                        textBox6.Text = tr.B.ToString();
                        tr.C = Math.Acos((Math.Pow(double.Parse(textBox2.Text), 2) + Math.Pow(double.Parse(textBox1.Text), 2) - Math.Pow(double.Parse(textBox3.Text), 2)) / (2 * double.Parse(textBox2.Text) * double.Parse(textBox1.Text))) * 180 / Math.PI;
                        textBox7.Text = tr.C.ToString();
                        tr.A = 0;
                        tr.B = 0;
                        tr.C = 0;
                    }
                else
                    {
                        textBox5.Text = "There isn1t any triangle like that";
                        textBox6.Text = "";
                        textBox7.Text = "";
                    }
            
        }
    }
}
