using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Xsl;

namespace Lab2
{
    public partial class Form1 : Form
    {
        string path = "DataBase.xml";
        List<Sportsman> result = new List<Sportsman>();

        private Sportsman OurSportsman()
        {
            string[] info = new string[6];
            if (checkBox1.Checked) info[0] = Convert.ToString(checkBox1.Text);
            if (checkBox2.Checked) info[1] = Convert.ToString(checkBox2.Text);
            if (checkBox3.Checked) info[2] = Convert.ToString(checkBox3.Text);
            if (checkBox4.Checked) info[3] = Convert.ToString(checkBox4.Text);
            if (checkBox5.Checked) info[4] = Convert.ToString(checkBox5.Text);
            if (checkBox6.Checked) info[5] = Convert.ToString(checkBox6.Text);
            if (checkBox7.Checked) info[6] = Convert.ToString(checkBox7.Text);
            Sportsman IdealSportsman = new Sportsman(info);
            return IdealSportsman;

        }

        private void Output(List<Sportsman> result)
        {
            int i = 1;
            Console.WriteLine("Alg +");
            foreach (Sportsman n in result)
            {
                richTextBox1.AppendText(i++ + "." + "\n");
                richTextBox1.AppendText("Section: " + n.Section + "\n");
                richTextBox1.AppendText("Visitor" + n.Visitor + "\n");
                richTextBox1.AppendText("Name: " + n.Name + "\n");
                richTextBox1.AppendText("Surname: " + n.Surname + "\n");
                richTextBox1.AppendText("Faculty: " + n.Faculty + "\n");
                richTextBox1.AppendText("Schedule :" + n.Schedule + "\n");
                richTextBox1.AppendText("Competition" + n.Competition + "\n");
                richTextBox1.AppendText("-------------------------------------------------\n");
            }
        }













        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            Sportsman _sportsman = OurSportsman();
            if (radioButton1.Checked)
            {
                IStrategy CurrentStrategy = new Linq(path);
                result = CurrentStrategy.Algorithm(_sportsman, path);
                Output(result);
            }
           if (radioButton2.Checked)
            {
                IStrategy CurrentStrategy = new Dom(path);
                result = CurrentStrategy.Algorithm(_sportsman, path);
                Output(result);

            }
            if (radioButton3.Checked)
            {
                IStrategy CurrentStrategy = new Sax(path);
                result = CurrentStrategy.Algorithm(_sportsman, path);
                Output(result);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            XslCompiledTransform xslt = new XslCompiledTransform();
            xslt.Load("XSL.xsl");
            string input = @"DataBase.xml";
            string result = @"information.html";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox1.Text = null;
            checkBox2.Text = null;
            checkBox3.Text = null;
            checkBox4.Text = null;
            checkBox5.Text = null;
            checkBox6.Text = null;
            checkBox7.Text = null;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;

        }
    }
}
