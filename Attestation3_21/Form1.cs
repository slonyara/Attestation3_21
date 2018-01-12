using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormUtils1;
using ProgramUtils;
using ConsoleUtils;


namespace Attestation3_21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataGridViewUtils.InitGridForArr(dataGridView, 40, false, true, true, true, false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<ProgramUtils.Line> coordinates = RectangleDGVUtils.DGVToStudentsList(dataGridView);
            ProgramLogic matrix = new ProgramLogic(coordinates);

            label1.Text = "Отрезки с индексами: " + matrix.Result().ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs ee)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    string arrText = FilesUtils.Read(openFileDialog1.FileName);
                    int[,] arr = DataConverter.StrToArray2D<int>(arrText);


                    DataGridViewUtils.Array2ToGrid(dataGridView, arr);

                    MessagesUtils.Show("Данные загружены");

                }
                catch (Exception e)
                {
                    MessagesUtils.ShowError("Ошибка загрузки данных");
                }
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs ee)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {


                    string result = Convert.ToString(label1);

                    FilesUtils.Write(saveFileDialog.FileName, result);

                    MessagesUtils.Show("Данные сохранены");
                }
                catch (Exception e)
                {
                    MessagesUtils.ShowError("Ошибка сохранения данных");
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
