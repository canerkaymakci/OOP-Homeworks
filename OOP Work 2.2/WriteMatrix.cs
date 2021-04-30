using System.Windows.Forms;
using System;
using System.IO;

namespace OOP_Work_2._2
{
    public static class WriteMatrix
    {
        public static void ShowOneMatrix(TextBox[,] x,int a,int b,bool f)
        {
            for (int i = 0; i < a ; i++)
            {
                for (int j = 0; j < b ; j++)
                {
                    if(f)
                        x[i, j].Show();

                    if(!f)
                        x[i,j].Hide();
                }
            }
        }

        public static void ShowTwoMatrix(TextBox[,] matrix1,TextBox[,] matrix2, int a, int b,int c,int d, bool f)
        {
            for (int i = 0; i < a; i++)
            {
                int k = 4;
                for (int j = 0; j < b; j++)
                {
                    if (f)
                    {
                        matrix1[i, k].Show();
                    }

                    if (!f)
                    {
                        matrix1[i, k].Hide();
                    }
                    k--;
                }
            }
            for (int i = 0; i < c; i++)
            {
                for (int j = 0; j < d; j++)
                {
                    if (f)
                    {
                        matrix2[i, j].Show();
                    }

                    if (!f)
                    {
                        matrix2[i, j].Hide();
                    }
                }
            }
        }

        public static void WriteAMatrix(TextBox[,] matrix, int x, int y)
        {
            File.AppendAllText("log.txt","===A Matrix had been written==="+Environment.NewLine);

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    File.AppendAllText("log.txt",matrix[i,j].Text+" ");
                }
                File.AppendAllText("log.txt",Environment.NewLine);
            }
        }

        public static void SumOfMatrix(TextBox[,] matrix1,TextBox[,] matrix2,Label[,] submit,int x,int y)
        {
            File.AppendAllText("log.txt","===Sum of Two Matrix==="+Environment.NewLine);
            File.AppendAllText("log.txt","===First Matrix==="+Environment.NewLine);
            for (int i = 0; i < x; i++)
            {
                int k = 4;
                for (int j = 0; j < y; j++)
                {
                    File.AppendAllText("log.txt",matrix1[i,k-y+1].Text+" ");
                    k++;
                }
                File.AppendAllText("log.txt",Environment.NewLine);
            }

            File.AppendAllText("log.txt", "===Second Matrix===" + Environment.NewLine);
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    File.AppendAllText("log.txt", matrix2[i,j].Text + " ");
                }
                File.AppendAllText("log.txt", Environment.NewLine);
            }

            File.AppendAllText("log.txt","===Submit==="+Environment.NewLine);
            for (int i = 0; i < x; i++)
            {
                int k = 4;
                for (int j = 0; j < y; j++)
                {
                    submit[i, j].Text = Convert.ToString(Convert.ToInt16(matrix1[i, k-y+1].Text) + Convert.ToInt16(matrix2[i, j].Text));
                    File.AppendAllText("log.txt",submit[i,j].Text+" ");
                    k++;
                }
                File.AppendAllText("log.txt",Environment.NewLine);
            }
            File.AppendAllText("log.txt",Environment.NewLine);
        }

        public static void MultiplicationOfMatrix(TextBox[,] matrix1, TextBox[,] matrix2, Label[,] submit, int x1,int y1, int x2, int y2)
        {
            File.AppendAllText("log.txt", "===Multiplication of Two Matrix===" + Environment.NewLine);
            File.AppendAllText("log.txt", "===First Matrix===" + Environment.NewLine);
            for (int i = 0; i < x1; i++)
            {
                int k = 4;
                for (int j = 0; j < y1; j++)
                {
                    File.AppendAllText("log.txt", matrix1[i, k - y1 + 1].Text + " ");
                    k++;
                }
                File.AppendAllText("log.txt", Environment.NewLine);
            }

            File.AppendAllText("log.txt", "===Second Matrix===" + Environment.NewLine);
            for (int i = 0; i < x2; i++)
            {
                for (int j = 0; j < y2; j++)
                {
                    File.AppendAllText("log.txt", matrix2[i, j].Text + " ");
                }
                File.AppendAllText("log.txt", Environment.NewLine);
            }

            File.AppendAllText("log.txt","===Submit==="+Environment.NewLine);
            for (int i = 0; i < x1; i++)
            {
                for (int l = 0; l < y2; l++)
                {
                    int k = 4, sum = 0;
                    for (int j = 0; j < x2; j++)
                    {
                        sum += Convert.ToInt16(matrix1[i, k - y1 + 1].Text) * Convert.ToInt16(matrix2[j, l].Text);

                        k++;
                    }
                    submit[i, l].Text = Convert.ToString(sum);
                    File.AppendAllText("log.txt",submit[i,l].Text+" ");
                }
                File.AppendAllText("log.txt",Environment.NewLine);
            }
            File.AppendAllText("log.txt",Environment.NewLine);
        }

        public static int Determinant(int[,] a, int b)
        {

            int sonuc = 0;

            if (b == 1)
            {
                sonuc = a[0, 0];
                return sonuc;
            }
            if (b == 2)
            {
                sonuc = a[0, 0] * a[1, 1] - a[0, 1] * a[1, 0];
                return sonuc;
            }

            for (int i = 0; i < b; i++)
            {
                int[,] temp = new int[b - 1, b - 1];

                for (int j = 1; j < b; j++)
                {
                    for (int k = 0; k < b; k++)
                    {
                        if (k < i) temp[j - 1, k] = a[j, k];
                        else if (k > i) temp[j - 1, k - 1] = a[j, k];
                    }
                }
                sonuc += a[0, i] * Convert.ToInt16(Math.Pow(-1, (int)i) * Determinant(temp, b - 1));
            }
            return sonuc;
        }

        public static void InverseOfMatrix(TextBox[,] matrix1,Label[,] submit,int x)
        {
            File.AppendAllText("log.txt","===Inverse of a Matrix==="+Environment.NewLine);
            File.AppendAllText("log.txt","===First Matrix==="+Environment.NewLine);
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    File.AppendAllText("log.txt",matrix1[i,j].Text+" ");
                }
                File.AppendAllText("log.txt",Environment.NewLine);
            }

            float[,] m1=new float[x,x];
            float[,] m2=new float[x,x];

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    m1[i, j] = Convert.ToInt16(matrix1[i, j].Text);
                }
            }

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    if (i == j) m2[i, j] = 1;
                    else m2[i, j] = 0;
                }
            }

            float temp1, temp2;

            for (int i = 0; i < x; i++)
            {
                temp1 = m1[i, i];
                for (int j = 0; j < x; j++)
                {
                    m1[i, j] = m1[i, j] / temp1;
                    m2[i, j] = m2[i, j] / temp1;
                }

                for (int k = 0; k < x; k++)
                {
                    if (k != i)
                    {
                        temp2 = m1[k, i];
                        for (int l = 0; l < x; l++)
                        {
                            m1[k, l] = m1[k, l] - (m1[i, l] * temp2);
                            m2[k, l] = m2[k, l] - (m2[i, l] * temp2);
                        }
                    }
                }
            }

            File.AppendAllText("log.txt","===Submit==="+Environment.NewLine);
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    submit[i, j].Text =String.Format("{0:0.##}",(m2[i, j]));
                    File.AppendAllText("log.txt",submit[i,j].Text+" ");
                }
                File.AppendAllText("log.txt",Environment.NewLine);
            }
            File.AppendAllText("log.txt",Environment.NewLine);
        }

        public static void TransposeOfMatrix(TextBox[,] matrix, Label[,] submit, int x, int y)
        {
            File.AppendAllText("log.txt", "===Transpose of a Matrix===" + Environment.NewLine);
            File.AppendAllText("log.txt", "===First Matrix===" + Environment.NewLine);
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    File.AppendAllText("log.txt",matrix[i,j].Text+" ");
                }
                File.AppendAllText("log.txt", Environment.NewLine);
            }

            int[,] lastMatrix=new int[y,x];

            File.AppendAllText("log.txt", "===Submit===" + Environment.NewLine);
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    lastMatrix[j,i]=Convert.ToInt32(matrix[i,j].Text);
                    submit[j, i].Text = Convert.ToString(lastMatrix[j, i]);
                }
            }

            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    File.AppendAllText("log.txt",submit[i,j].Text+" ");
                }
                File.AppendAllText("log.txt",Environment.NewLine);
            }
            File.AppendAllText("log.txt",Environment.NewLine);
        }

        public static void TraceOfMatrix(TextBox[,] matrix, Label submit, int xy)
        {
            File.AppendAllText("log.txt", "===Trace of a Matrix===" + Environment.NewLine);
            File.AppendAllText("log.txt", "===Matrix===" + Environment.NewLine);
            for (int i = 0; i < xy; i++)
            {
                for (int j = 0; j < xy; j++)
                {
                    File.AppendAllText("log.txt",matrix[i,j].Text+" ");
                }
                File.AppendAllText("log.txt",Environment.NewLine);
            }

            int sum = 0;
            for (int i = 0; i < xy; i++)
            {
                for (int j = 0; j < xy; j++)
                {
                    if (i == j)
                    {
                        sum += Convert.ToInt16(matrix[i, j].Text);
                    }
                }
            }
            submit.Text = Convert.ToString(sum);
            File.AppendAllText("log.txt", "===Submit : " + submit.Text + "==="+Environment.NewLine);
            File.AppendAllText("log.txt",Environment.NewLine);
        }

        public static void ClearSubmit(Label[,] a)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    a[i, j].Text = "";
                }
            }
        }
    }
}