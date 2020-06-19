using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            for (int i = 0; i < b; i++)
            {
                dataGridView1.Columns.Add("", "");
            }
            for (int j = 0; j < a; j++)
            {
                dataGridView1.Rows.Add();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox4.Text);
            int b = int.Parse(textBox3.Text);
            for (int i = 0; i < b; i++)
            {
                dataGridView2.Columns.Add("", "");
            }
            for (int j = 0; j < a; j++)
            {
                dataGridView2.Rows.Add();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            int t = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);
            for (int i = 0; i < y; i++)
            {
                dataGridView3.Columns.Add("", "");
            }
            for (int j = 0; j < t; j++)
            {
                dataGridView3.Rows.Add();
            }
            int n = dataGridView1.ColumnCount;
            int m = dataGridView1.RowCount;
            int q = dataGridView2.ColumnCount;
            int r = dataGridView2.RowCount;
            int[,] a = new int[n, m];
            int[,] b = new int[n, m];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    a[i, j] = Convert.ToInt32(dataGridView1[i, j].Value);
            for (int i = 0; i < q; i++)
                for (int j = 0; j < r; j++)
                    b[i, j] = Convert.ToInt32(dataGridView2[i, j].Value);
            for (int i = 0; i < dataGridView3.Rows.Count; i++)
                for (int j = 0; j < dataGridView3.Columns.Count; j++)
                    dataGridView3[i, j].Value = a[i, j] + b[i, j];
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == textBox4.Text)
            {
                dataGridView3.Rows.Clear();
                dataGridView3.Columns.Clear();
                int[,] A = new int[dataGridView1.RowCount, dataGridView1.ColumnCount];
                int[,] B = new int[dataGridView2.RowCount, dataGridView2.ColumnCount];
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                    for (int j = 0; j < dataGridView1.RowCount; j++)
                        A[j, i] = Convert.ToInt32(dataGridView1[i, j].Value);
                for (int i = 0; i < dataGridView2.ColumnCount; i++)
                    for (int j = 0; j < dataGridView2.RowCount; j++)
                        B[j, i] = Convert.ToInt32(dataGridView2[i, j].Value);

                for (int i = 0; i < dataGridView2.ColumnCount; i++)
                {
                    dataGridView3.Columns.Add("", "");
                }
                for (int j = 0; j < dataGridView1.RowCount; j++)
                {
                    dataGridView3.Rows.Add();
                }

                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView2.ColumnCount; j++)
                    {
                        int s = 0;
                        for (int k = 0; k < dataGridView2.RowCount; k++)
                            s += A[i, k] * B[k, j];
                        dataGridView3[j, i].Value = s;
                    }
                }
            }
            else MessageBox.Show("Число столбцов первой матрицы не соответствует числу строк во второй", "Ошибка");         
        }
        public int MultyMatrix(int A, int B)
        {
          int C;
          C = A * B;
          return C;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            int t = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);
            for (int i = 0; i < y; i++)
            {
                dataGridView3.Columns.Add("", "");
            }
            for (int j = 0; j < t; j++)
            {
                dataGridView3.Rows.Add();
            }
            int n = dataGridView1.ColumnCount;
            int m = dataGridView1.RowCount;
            int[,] a = new int[n, m];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    a[i, j] = Convert.ToInt32(dataGridView1[i, j].Value);
            for (int i = 0; i < dataGridView3.Rows.Count; i++)
                for (int j = 0; j < dataGridView3.Columns.Count; j++)
                    dataGridView3[i, j].Value = a[j, i];
        }
        private void button6_Click(object sender, EventArgs e)
        {
            int t = int.Parse(textBox3.Text);
            int y = int.Parse(textBox4.Text);
            for (int i = 0; i < y; i++)
            {
                dataGridView3.Columns.Add("", "");
            }
            for (int j = 0; j < t; j++)
            {
                dataGridView3.Rows.Add();
            }
            int n = dataGridView2.ColumnCount;
            int m = dataGridView2.RowCount;
            int[,] b = new int[n, m];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    b[i, j] = Convert.ToInt32(dataGridView2[i, j].Value);
            for (int i = 0; i < dataGridView3.Rows.Count; i++)
                for (int j = 0; j < dataGridView3.Columns.Count; j++)
                    dataGridView3[i, j].Value = b[j, i];
        }
        private void button9_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            dataGridView3.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView2.Columns.Clear();
            dataGridView3.Columns.Clear();
        }
    }
}
