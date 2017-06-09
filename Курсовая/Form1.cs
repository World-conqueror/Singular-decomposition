using System;
using System.Windows.Forms;
namespace Курсовая
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int m; private int n; private int x; private int y; private int d = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            m = Convert.ToInt32(numericUpDown1.Value);
            n = Convert.ToInt32(numericUpDown2.Value);
            Matrix_A = new MaskedTextBox[m, n]; d = 1;
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                {
                    MaskedTextBox newMaskedTextBox = new MaskedTextBox(); x = 10 + j * 30;
                    newMaskedTextBox.Name = "newMaskedTextBox";
                    Matrix_A[i, j] = newMaskedTextBox;
                    newMaskedTextBox.Location = new System.Drawing.Point(x, 80 + i * 20);
                    newMaskedTextBox.Size = new System.Drawing.Size(30, 20);
                    Controls.Add(newMaskedTextBox);
                }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double[,] A = new double[m, n];
                double[] W = new double[Math.Min(m, n)];
                double[,] U = new double[m, n];
                double[,] VT = new double[m, n];
                for (int i = 0; i < m; i++)
                    for (int j = 0; j < n; j++)
                        A[i, j] = Convert.ToDouble(Matrix_A[i, j].Text);
                alglib.svd.rmatrixsvd(A, m, n, 0, 0, 2, ref W, ref U, ref VT);
                Matrix_W = new MaskedTextBox[Math.Min(m, n)]; d = 2;
                for (int i = 0; i < Math.Min(m, n); i++)
                {
                    MaskedTextBox newMaskedTextBox = new MaskedTextBox();
                    newMaskedTextBox.Name = "newMaskedTextBox";
                    Matrix_W[i] = newMaskedTextBox;
                    Matrix_W[i].Text = Convert.ToString(W[i]);
                    newMaskedTextBox.Location = new System.Drawing.Point(x + 50 + i * 50, 80);
                    newMaskedTextBox.Size = new System.Drawing.Size(50, 20);
                    Controls.Add(newMaskedTextBox);
                }
            }
            catch (System.FormatException) { }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double[,] A = new double[m, n];
                double[] W = new double[Math.Min(m, n)];
                double[,] U = new double[m, n];
                double[,] VT = new double[m, n];
                for (int i = 0; i < m; i++)
                    for (int j = 0; j < n; j++)
                        A[i, j] = Convert.ToDouble(Matrix_A[i, j].Text);
                alglib.svd.rmatrixsvd(A, m, n, 1, 1, 2, ref W, ref U, ref VT);
                Matrix_W = new MaskedTextBox[Math.Min(m, n)];
                for (int i = 0; i < Math.Min(m, n); i++)
                {
                    MaskedTextBox newMaskedTextBox = new MaskedTextBox();
                    newMaskedTextBox.Name = "newMaskedTextBox";
                    Matrix_W[i] = newMaskedTextBox;
                    Matrix_W[i].Text = Convert.ToString(W[i]);
                    newMaskedTextBox.Location = new System.Drawing.Point(x + 50 + i * 50, 80);
                    newMaskedTextBox.Size = new System.Drawing.Size(50, 20);
                    Controls.Add(newMaskedTextBox);
                }
                Matrix_U = new MaskedTextBox[m, Math.Min(m, n)];
                for (int i = 0; i < m; i++)
                    for (int j = 0; j < Math.Min(m, n); j++)
                    {
                        MaskedTextBox newMaskedTextBox = new MaskedTextBox();
                        newMaskedTextBox.Name = "newMaskedTextBox";
                        Matrix_U[i, j] = newMaskedTextBox;
                        Matrix_U[i, j].Text = Convert.ToString(U[i, j]); y = 120 + i * 20;
                        newMaskedTextBox.Location = new System.Drawing.Point(x + 50 + j * 50, y);
                        newMaskedTextBox.Size = new System.Drawing.Size(50, 20);
                        Controls.Add(newMaskedTextBox);
                    }
                Matrix_VT = new MaskedTextBox[Math.Min(m, n), n]; d = 3;
                for (int i = 0; i < Math.Min(m, n); i++)
                    for (int j = 0; j < n; j++)
                    {
                        MaskedTextBox newMaskedTextBox = new MaskedTextBox();
                        newMaskedTextBox.Name = "newMaskedTextBox";
                        Matrix_VT[i, j] = newMaskedTextBox;
                        Matrix_VT[i, j].Text = Convert.ToString(VT[i, j]);
                        newMaskedTextBox.Location = new System.Drawing.Point(x + 50 + j * 50, y + 40 + i * 20);
                        newMaskedTextBox.Size = new System.Drawing.Size(50, 20);
                        Controls.Add(newMaskedTextBox);
                    }
            }
            catch (System.FormatException) { }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                double[,] A = new double[m, n];
                double[] W = new double[Math.Min(m, n)];
                double[,] U = new double[m, n];
                double[,] VT = new double[m, n];
                for (int i = 0; i < m; i++)
                    for (int j = 0; j < n; j++)
                        A[i, j] = Convert.ToDouble(Matrix_A[i, j].Text);
                alglib.svd.rmatrixsvd(A, m, n, 2, 2, 2, ref W, ref U, ref VT);
                Matrix_W = new MaskedTextBox[Math.Min(m, n)];
                for (int i = 0; i < Math.Min(m, n); i++)
                {
                    MaskedTextBox newMaskedTextBox = new MaskedTextBox();
                    newMaskedTextBox.Name = "newMaskedTextBox";
                    Matrix_W[i] = newMaskedTextBox;
                    Matrix_W[i].Text = Convert.ToString(W[i]);
                    newMaskedTextBox.Location = new System.Drawing.Point(x + 50 + i * 50, 80);
                    newMaskedTextBox.Size = new System.Drawing.Size(50, 20);
                    Controls.Add(newMaskedTextBox);
                }
                Matrix_U = new MaskedTextBox[m, m];
                for (int i = 0; i < m; i++)
                    for (int j = 0; j < m; j++)
                    {
                        MaskedTextBox newMaskedTextBox = new MaskedTextBox();
                        newMaskedTextBox.Name = "newMaskedTextBox";
                        Matrix_U[i, j] = newMaskedTextBox;
                        Matrix_U[i, j].Text = Convert.ToString(U[i, j]); y = 120 + i * 20;
                        newMaskedTextBox.Location = new System.Drawing.Point(x + 50 + j * 50, y);
                        newMaskedTextBox.Size = new System.Drawing.Size(50, 20);
                        Controls.Add(newMaskedTextBox);
                    }
                Matrix_VT = new MaskedTextBox[n, n]; d = 4;
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                    {
                        MaskedTextBox newMaskedTextBox = new MaskedTextBox();
                        newMaskedTextBox.Name = "newMaskedTextBox";
                        Matrix_VT[i, j] = newMaskedTextBox;
                        Matrix_VT[i, j].Text = Convert.ToString(VT[i, j]);
                        newMaskedTextBox.Location = new System.Drawing.Point(x + 50 + j * 50, y + 40 + i * 20);
                        newMaskedTextBox.Size = new System.Drawing.Size(50, 20);
                        Controls.Add(newMaskedTextBox);
                    }
            }
            catch (System.FormatException) { }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            switch (d)
            {
                case 1:
                    for (int i = 0; i < m; i++)
                        for (int j = 0; j < n; j++)
                            Controls.Remove(Matrix_A[i, j]);
                    d = 0; break;
                case 2:
                    for (int i = 0; i < Math.Min(m, n); i++)
                        Controls.Remove(Matrix_W[i]);
                    d = 1; break;
                case 3:
                    for (int i = 0; i < Math.Min(m, n); i++)
                        Controls.Remove(Matrix_W[i]);
                    for (int i = 0; i < m; i++)
                        for (int j = 0; j < Math.Min(m, n); j++)
                            Controls.Remove(Matrix_U[i, j]);
                    for (int i = 0; i < Math.Min(m, n); i++)
                        for (int j = 0; j < n; j++)
                            Controls.Remove(Matrix_VT[i, j]);
                    d = 1; break;
                case 4:
                    for (int i = 0; i < Math.Min(m, n); i++)
                        Controls.Remove(Matrix_W[i]);
                    for (int i = 0; i < m; i++)
                        for (int j = 0; j < m; j++)
                            Controls.Remove(Matrix_U[i, j]);
                    for (int i = 0; i < n; i++)
                        for (int j = 0; j < n; j++)
                            Controls.Remove(Matrix_VT[i, j]);
                    d = 1; break;
            }
        }
    }
}