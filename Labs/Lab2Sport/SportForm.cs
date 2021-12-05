using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Xsl;

namespace Lab2Sport
{
    public partial class SportForm : Form
    {
        private string path = "XMLSport.xml";  
        private string pathXSL = "XSLSport.xsl";

        public SportForm()
        {
            InitializeComponent();
            BuiltBox(comboBoxSection, comboBoxStatus, comboBoxName, comboBoxSurname, comboBoxSchedule, comboBoxConpetition);
            comboBoxSection.Enabled = false;
            comboBoxStatus.Enabled = false;
            comboBoxName.Enabled = false;
            comboBoxSurname.Enabled = false;
            comboBoxSchedule.Enabled = false;
            comboBoxConpetition.Enabled = false;
        }

        public void BuiltBox(ComboBox comboBoxSection, ComboBox comboBoxStatus, ComboBox comboBoxName, ComboBox comboBoxSurname,
            ComboBox comboBoxSchedule, ComboBox comboBoxConpetition)
        {
            IAnalizatorXMLStrategy i = new LinqToXML();
            List<Sportsmans> res = i.AnalyzeFile(new Sportsmans(), path);
            List<string> section = new List<string>();
            List<string> status = new List<string>();
            List<string> name = new List<string>();
            List<string> surname = new List<string>();
            List<string> schedule = new List<string>();
            List<string> competition = new List<string>();

            foreach (Sportsmans elem in res)
            {
                if (!section.Contains(elem.Section))
                {
                    section.Add(elem.Section);
                }
                if (!status.Contains(elem.Status))
                {
                    status.Add(elem.Status);
                }
                if (!name.Contains(elem.Name))
                {
                    name.Add(elem.Name);
                }
                if (!surname.Contains(elem.Surname))
                {
                    surname.Add(elem.Surname);
                }
                if (!schedule.Contains(elem.Schedule))
                {
                    schedule.Add(elem.Schedule);
                }
                if (!competition.Contains(elem.Competition))
                {
                    competition.Add(elem.Competition);
                }
            }

            section = section.OrderBy(x => x).ToList();
            status = status.OrderBy(x => x).ToList();
            name = name.OrderBy(x => x).ToList();
            surname = surname.OrderBy(x => x).ToList();
            schedule = schedule.OrderBy(x => x).ToList();
            competition = competition.OrderBy(x => x).ToList();

            comboBoxSection.Items.AddRange(section.ToArray());
            comboBoxStatus.Items.AddRange(status.ToArray());
            comboBoxName.Items.AddRange(competition.ToArray());
            comboBoxSurname.Items.AddRange(name.ToArray());
            comboBoxSchedule.Items.AddRange(surname.ToArray());
            comboBoxConpetition.Items.AddRange(schedule.ToArray());
            
        }

        private Sportsmans OurSearch()
        {
            string[] info = new string[7];
            if (checkBoxSection.Checked) { info[0] = Convert.ToString(comboBoxSection.Text); }
            if (checkBoxStatus.Checked) { info[1] = Convert.ToString(comboBoxStatus.Text); }
            if (checkBoxName.Checked) { info[2] = Convert.ToString(comboBoxName.Text); }
            if (checkBoxSurname.Checked) { info[3] = Convert.ToString(comboBoxSurname.Text); }
            if (checkBoxSchedule.Checked) { info[4] = Convert.ToString(comboBoxSchedule.Text); }
            if (checkBoxCompetition.Checked) { info[5] = Convert.ToString(comboBoxConpetition.Text); }
            Sportsmans idealSearch = new Sportsmans(info);
            return idealSearch;
        }

        private void ParserForXML()
        {
            Sportsmans myTemplate = OurSearch();
            List<Sportsmans> res;

            if (radioButtonDOM.Checked)
            {
                IAnalizatorXMLStrategy parser = new DOM();
                res = parser.AnalyzeFile(myTemplate, path);
                Output(res);
            }
            else if (radioButtonLINQ.Checked)
            {
                IAnalizatorXMLStrategy parser = new LinqToXML();
                res = parser.AnalyzeFile(myTemplate, path);
                Output(res);
            }
            else if (radioButtonSAX.Checked)
            {
                IAnalizatorXMLStrategy parser = new SAX();
                res = parser.AnalyzeFile(myTemplate, path);
                Output(res);
            }
        }

        private void Output(List<Sportsmans> res)
        {
            richTextBox1.Clear();

            foreach (Sportsmans n in res)
            {
                richTextBox1.AppendText("Section: " + n.Section + "\n");
                richTextBox1.AppendText("Status: " + n.Status + "\n");
                richTextBox1.AppendText("Name: " + n.Name + "\n");
                richTextBox1.AppendText("Surname: " + n.Surname + "\n");
                richTextBox1.AppendText("Schedule: " + n.Schedule + "\n");
                richTextBox1.AppendText("Competition: " + n.Competition + "\n");
                richTextBox1.AppendText("##################################\n");
            }
        }


        private void buttonClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void Clear()
        {
            richTextBox1.Clear();
            radioButtonDOM.Checked = false;
            radioButtonLINQ.Checked = false;
            radioButtonSAX.Checked = false;
            comboBoxSection.Text = null;
            comboBoxStatus.Text = null;
            comboBoxName.Text = null;
            comboBoxSurname.Text = null;
            comboBoxSchedule.Text = null;
            comboBoxConpetition.Text = null;
            checkBoxSection.Checked = false;
            checkBoxStatus.Checked = false;
            checkBoxName.Checked = false;
            checkBoxSurname.Checked = false;
            checkBoxSchedule.Checked = false;
            checkBoxCompetition.Checked = false;
        }

        private void Help()
        {
            MessageBox.Show("Короткі відомості про програму\n" +
               "Дана програма допоможе вам знайти потрібну людину\n" );
        }
        private void buttonTransform_Click(object sender, EventArgs e)
        {
            IntoHTML();
            OpenHTML();
        }
        private void buttonOpenHTML_Click(object sender, EventArgs e)
        {
            var OpenHTML = System.Diagnostics.Process.Start("HTML.html");
        }
        private void OpenHTML()
        {
            buttonOpenHTML.Enabled = true;
        }
        private void IntoHTML()
        {
            XslCompiledTransform xsl = new XslCompiledTransform();
            xsl.Load(pathXSL);
            string input = path;
            string result = @"HTML.html";
            xsl.Transform(input, result);
            MessageBox.Show("HTML done!");
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            ParserForXML();
        }

        private void FilmsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Ви впевнені, що хочете закрити форму?",
                "WARNING",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);

            if (result == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help();
        }
        private void Sport_Load(object sender, EventArgs e)
        {

        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void checkBoxName_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSection.Checked) { comboBoxSection.Enabled = true; } else { comboBoxSection.Enabled = false; }
        }

        private void checkBoxGenre_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxStatus.Checked) { comboBoxStatus.Enabled = true; } else { comboBoxStatus.Enabled = false; }
        }

        private void checkBoxYear_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxName.Checked) { comboBoxName.Enabled = true; } else { comboBoxName.Enabled = false; }
        }

        private void checkBoxDirector_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSurname.Checked) { comboBoxSurname.Enabled = true; } else { comboBoxSurname.Enabled = false; }
        }

        private void checkBoxCountry_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSchedule.Checked) { comboBoxSchedule.Enabled = true; } else { comboBoxSchedule.Enabled = false; }
        }

        private void checkBoxLanguage_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCompetition.Checked) { comboBoxConpetition.Enabled = true; } else { comboBoxConpetition.Enabled = false; }
        }

        private void comboBoxName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxName_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
