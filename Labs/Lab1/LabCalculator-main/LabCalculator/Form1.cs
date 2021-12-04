using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace LabCalculator
{
    public partial class Form1 : Form
    {
        private int _columnNumb = 5;
        private int _rowNumb = 5;
        private TableData _table;

        public Dictionary<string, MyCell> cellList = new Dictionary<string, MyCell>(); //словник який зберігає назву клітини і її саму
        public Form1()
        {
            InitializeComponent();
            _table = new TableData(_columnNumb, _rowNumb);

            CreateDataGrid(_rowNumb, _columnNumb) ;
            //WindowState = FormWindowState.Maximized;
        }

        private void CreateDataGrid(int rows, int columns)
        {
            for (int i = 0; i < columns; ++i)
            {
                DataGridViewColumn exelColumn = new DataGridViewColumn();
                MyCell cell = new MyCell();
                exelColumn.CellTemplate = cell;
                exelColumn.HeaderText = BasedSystem26.To26System(i);
                exelColumn.Name = BasedSystem26.To26System(i);

                dataGridView1.Columns.Add(exelColumn);
            }

            for (int i = 0; i < rows; ++i)
            {
                dataGridView1.Rows.Add();  
            }

            for (int i = 0; i < dataGridView1.ColumnCount; ++i)
            {
                _table.SetCellsInColumn(i, dataGridView1);
            }

            SetRowNum(dataGridView1);

            dataGridView1.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }

        public void SetRowNum(DataGridView dataGridView)
        {
            for (int i = 0; i < dataGridView.RowCount; ++i)
            {
                dataGridView.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
        }

        private void AddRowBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();
            SetRowNum(dataGridView1);
            _table.SetCellsInRow(dataGridView1);
            _table.RowCount++;
        }

        private void DeleteRowBtn_Click(object sender, EventArgs e)
        {
            if (!_table.DeleteRow(dataGridView1))
                return;
            dataGridView1.Rows.RemoveAt(_table.RowCount);
            SetRowNum(dataGridView1);
        }

        private void AddColumnBtn_Click(object sender, EventArgs e)
        {
            DataGridViewColumn exelColumn = new DataGridViewColumn();
            MyCell cell = new MyCell();
            exelColumn.CellTemplate = cell;
            exelColumn.HeaderText = BasedSystem26.To26System(dataGridView1.ColumnCount);
            exelColumn.Name = BasedSystem26.To26System(dataGridView1.ColumnCount);

            dataGridView1.Columns.Add(exelColumn);

            _table.SetCellsInColumn(dataGridView1.ColumnCount-1, dataGridView1);
            _table.ColCount++;
        }

        private void DeleteColumnBtn_Click(object sender, EventArgs e)
        {
            if (!_table.DeleteColumn(dataGridView1))
                return;
            dataGridView1.Columns.RemoveAt(_table.ColCount);
        }

        private void CalculateExp()
        {
            int currRow = dataGridView1.CurrentCell.RowIndex;
            int currColumn = dataGridView1.CurrentCell.ColumnIndex;
            string cellName = BasedSystem26.To26System(currColumn) + (currRow + 1).ToString();
            if (dataGridView1.CurrentCell.Value == null)
            {
                _table.cellList[cellName].Clear();
                MessageBox.Show("ERROR ви не можете порахувати значення в пустій клітинці \n");
                return;
            }
            string expression;
            if (_table.cellList[cellName].Exp == "" || dataGridView1.CurrentCell.Value.ToString() != _table.cellList[cellName].Exp)
            {
                expression = (dataGridView1.CurrentCell.Value).ToString();
            }
            else
            {
                expression = _table.cellList[cellName].Exp;
            }
            _table.ChangeCellsAndPointers(dataGridView1, cellName, expression);
            dataGridView1.CurrentCell.Value = _table.cellList[cellName].Value;
            textBox2.Text = _table.cellList[cellName].Exp;
        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            CalculateExp();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            CalculateExp();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "TableFile|*.txt";
            openFileDialog.Title = "Open";
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;
            StreamReader sr = new StreamReader(openFileDialog.FileName);
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            int row; int column;
            Int32.TryParse(sr.ReadLine(), out row);
            Int32.TryParse(sr.ReadLine(), out column);
            CreateDataGrid(row, column);
            _table.Open(row, column, sr, dataGridView1);
            sr.Close();
        }
        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
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

        private void helpToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Короткі відомості про програму\n" +
               "Дана програма є аналогом усім добре відомої програми Exel з мінімальним функціоналом та вміє обчислювати такі операціі\n\t" +
               "1. '+, -, *, /'\n\t " +
               "2. 'mod, div'\n\t " +
               "3. '^'\n\t " +
               "4. 'inc, dec'",
               "HELP меню");
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            int row = dataGridView1.CurrentCell.RowIndex;
            int col = dataGridView1.CurrentCell.ColumnIndex;
            string cellName = BasedSystem26.To26System(col) + (row + 1).ToString();
            textBox2.Text = _table.cellList[cellName].Exp;
        }

        private void saveAsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "TableFile|*.txt";
            saveFileDialog.Title = "Save table file";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                FileStream fs = (FileStream)saveFileDialog.OpenFile();
                StreamWriter sw = new StreamWriter(fs);
                _table.Save(sw);
                sw.Close();
                fs.Close();
            }
        }

        
    }
}
