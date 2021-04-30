using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Work_2._2
{
    public partial class SumOfMatrix : UserControl
    {

        TextBox[,] matrix1 = new TextBox[5, 5];
        TextBox[,] matrix2 = new TextBox[5, 5];
        Label[,] labelSum=new Label[5,5];

        public SumOfMatrix()
        {
            InitializeComponent();
            TextBox[,] box1 = new TextBox[5, 5]{{textBox1,textBox10,textBox15,textBox20,textBox25}, { textBox2, textBox9, textBox14, textBox19, textBox24 },
                { textBox3, textBox8, textBox13, textBox18, textBox23 },{textBox4,textBox7,textBox12,textBox17,textBox22},{textBox5,textBox6,textBox11,textBox16,textBox21} };

            TextBox[,] box2 = new TextBox[5, 5]{{textBox50,textBox45,textBox40,textBox35,textBox30}, { textBox49, textBox44, textBox39, textBox34, textBox29 },
                { textBox48, textBox43, textBox38, textBox33, textBox28 },{textBox47,textBox42,textBox37,textBox32,textBox27},{textBox46,textBox41,textBox36,textBox31,textBox26} };

            Label[,] labels = new Label[,] {{label1, label2, label3, label4, label5}, {label10, label9, label8, label7, label6},
                {label15, label14, label13, label12, label11}, {label20, label19, label18, label17, label16}, {label25, label24, label23, label22, label21}};

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    box1[i, j].Hide();
                    box2[i, j].Hide();
                }
            }

            matrix1 = box1;
            matrix2 = box2;
            labelSum = labels;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            WriteMatrix.ClearSubmit(labelSum);
            WriteMatrix.SumOfMatrix(matrix1,matrix2,labelSum,comboBoxX.SelectedIndex+1,comboBoxY.SelectedIndex+1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WriteMatrix.ShowTwoMatrix(matrix1,matrix2, 5, 5,5,5, false);
            WriteMatrix.ClearSubmit(labelSum);
            WriteMatrix.ShowTwoMatrix(matrix1,matrix2, comboBoxX.SelectedIndex + 1, comboBoxY.SelectedIndex + 1, comboBoxX.SelectedIndex + 1, comboBoxY.SelectedIndex + 1, true);
            labelPlus.Show();
        }

       
    }
}
