using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Xsl;

namespace Lab2
{
    public partial class Form1 : Form
    {
        //private string path = "XMLFile1.xml";
        private string path = "XMLFile1.xml";
        private string pathXsl = "XSLFile1.xsl";
        public Form1()
        {
            InitializeComponent();
            buildBox(comboBox1, comboBox2, comboBox3, comboBox4, comboBox5, comboBox6);
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            comboBox3.Enabled = false;
            comboBox4.Enabled = false;
            comboBox5.Enabled = false;
            comboBox6.Enabled = false;
            radioButton1.Checked = true;
        }

        public void buildBox(ComboBox comboBox1, ComboBox comboBox2, ComboBox comboBox3, ComboBox comboBox4, ComboBox comboBox5, ComboBox comboBox6)
        {

            IStrategy p = new LinqToXml();
            List<Sportsmans> res = p.AnalizeFile(new Sportsmans(), path);
            List<string> section = new List<string>();
            List<string> status = new List<string>();
            List<string> name = new List<string>();
            List<string> surname = new List<string>();
            List<string> schedule = new List<string>();
            List<string> competition = new List<string>();
            foreach(Sportsmans elem in res)
            {
                if (!section.Contains(elem.section))
                {
                    section.Add(elem.section);
                }
                if (!status.Contains(elem.status))
                {
                    status.Add(elem.status);
                }
                if (!name.Contains(elem.name))
                {
                    name.Add(elem.name);
                }
                if (!surname.Contains(elem.surname))
                {
                    surname.Add(elem.surname);
                }
                if (!schedule.Contains(elem.schedule))
                {
                    schedule.Add(elem.schedule);
                }
                if (!competition.Contains(elem.competition))
                {
                    competition.Add(elem.competition);
                }
            }

            section = section.OrderBy(x => x).ToList();
            status = status.OrderBy(x => x).ToList();
            name = name.OrderBy(x => x).ToList();
            surname = surname.OrderBy(x => x).ToList();
            schedule = schedule.OrderBy(x => x).ToList();
            competition = competition.OrderBy(x => x).ToList();

            comboBox1.Items.AddRange(section.ToArray());
            comboBox1.Items.Add("vjghvj");
            comboBox2.Items.AddRange(status.ToArray());
            comboBox3.Items.AddRange(name.ToArray());
            comboBox4.Items.AddRange(surname.ToArray());
            comboBox5.Items.AddRange(schedule.ToArray());
            comboBox6.Items.AddRange(competition.ToArray());
        }


        private Sportsmans OurSearch()
        {
            string[] info = new string[7];
            if (checkBox1.Checked) { info[0] = Convert.ToString(checkBox1.Text); }
            if (checkBox2.Checked) { info[1] = Convert.ToString(checkBox2.Text); }
            if (checkBox3.Checked) { info[2] = Convert.ToString(checkBox3.Text); }
            if (checkBox4.Checked) { info[3] = Convert.ToString(checkBox4.Text); }
            if (checkBox5.Checked) { info[4] = Convert.ToString(checkBox5.Text); }
            if (checkBox6.Checked) { info[5] = Convert.ToString(checkBox6.Text); }
            Sportsmans idealSearch = new Sportsmans(info);
            return idealSearch;
        }

        private void Parsing4XML()
        {
            Sportsmans MyTemplate = OurSearch();
            List<Sportsmans> res;

            if (radioButton2.Checked)
            {
                IStrategy parser = new SAX();
                res = parser.AnalizeFile(MyTemplate, path);
                Output(res);
            }
            else if (radioButton3.Checked)
            {
                IStrategy parser = new DOM();
                res = parser.AnalizeFile(MyTemplate, path);
                Output(res);
            }
            else if (radioButton1.Checked)
            {
                IStrategy parser = new LinqToXml();
                res = parser.AnalizeFile(MyTemplate, path);
                Output(res);
            }
        }


        private void Output(List<Sportsmans> res)
        {
            richTextBox1.Clear();
            foreach(Sportsmans n in res)
            {
                richTextBox1.AppendText("Section:  " + n.section + "\n");
                richTextBox1.AppendText("Status:  " + n.status + "\n");
                richTextBox1.AppendText("Name:  " + n.name + "\n");
                richTextBox1.AppendText("Surname:  " + n.surname + "\n");
                richTextBox1.AppendText("Schedule:  " + n.schedule + "\n");
                richTextBox1.AppendText("Competition:  " + n.competition + "\n");
                richTextBox1.AppendText("#################################################\n");
            }
        }

        private void IntoHTML()
        {
            XslCompiledTransform xsl = new XslCompiledTransform();
            xsl.Load(pathXsl);
            string input = path; //!!!
            string result = @"HTML.html";
            xsl.Transform(input, result);
            MessageBox.Show("Done!");
        }

        private void Clear()
        {
            richTextBox1.Clear();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox1.Text = null;
            checkBox2.Text = null;
            checkBox3.Text = null;
            checkBox4.Text = null;
            checkBox5.Text = null;
            checkBox6.Text = null;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
        }

        private void OpenHTML()
        {
            button3.Enabled = true;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Parsing4XML();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IntoHTML();
            OpenHTML();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var OpenHTML = System.Diagnostics.Process.Start("HTML.html");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) { checkBox1.Enabled = true; } else { checkBox1.Enabled = false; }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked) { checkBox2.Enabled = true; } else { checkBox2.Enabled = false; }
        }
    

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked) { checkBox3.Enabled = true; } else { checkBox3.Enabled = false; }

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked) { checkBox4.Enabled = true; } else { checkBox4.Enabled = false; }

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked) { checkBox5.Enabled = true; } else { checkBox5.Enabled = false; }

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked) { checkBox6.Enabled = true; } else { checkBox6.Enabled = false; }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
