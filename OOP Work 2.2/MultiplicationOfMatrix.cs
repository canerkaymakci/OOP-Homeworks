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
    public partial class MultiplicationOfMatrix : UserControl
    {
        TextBox[,] matrix1 = new TextBox[5, 5];
        TextBox[,] matrix2 = new TextBox[5, 5];
        Label[,] labelMultiple = new Label[5, 5];

        public MultiplicationOfMatrix()
        {
            InitializeComponent();
            TextBox[,] box1 = new TextBox[5, 5]{{textBox1,textBox10,textBox15,textBox20,textBox25}, { textBox2, textBox9, textBox14, textBox19, textBox24 },
                { textBox3, textBox8, textBox13, textBox18, textBox23 },{textBox4,textBox7,textBox12,textBox17,textBox22},{textBox5,textBox6,textBox11,textBox16,textBox21} };

            TextBox[,] box2 = new TextBox[5, 5]{{textBox50,textBox45,textBox40,textBox35,textBox30}, { textBox49, textBox44, textBox39, textBox34, textBox29 },
                { textBox48, textBox43, textBox38, textBox33, textBox28 },{textBox47,textBox42,textBox37,textBox32,textBox27},{textBox46,textBox41,textBox36,textBox31,textBox26} };

            Label[,] labels = new Label[,] {{label1, label2, label3, label4, label5}, {label10, label9, label8, label7, label6},
                {label15, label14, label13, label12, label11}, {label20, label19, label18, label17, label16}, {label25, label24, label23, label22, label21}};

            matrix1 = box1;
            matrix2 = box2;
            labelMultiple = labels;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBoxY.SelectedIndex == comboBoxX2.SelectedIndex)
            {
                WriteMatrix.ShowTwoMatrix(matrix1, matrix2, 5, 5, 5, 5, false);
                WriteMatrix.ClearSubmit(labelMultiple);
                WriteMatrix.ShowTwoMatrix(matrix1, matrix2, comboBoxX1.SelectedIndex + 1, comboBoxY.SelectedIndex + 1, comboBoxX2.SelectedIndex + 1, comboBoxY2.SelectedIndex + 1, true);
                labelX.Show();
            }
            else
            {
                WriteMatrix.ShowTwoMatrix(matrix1, matrix2, 5, 5, 5, 5, false);
                WriteMatrix.ClearSubmit(labelMultiple);
                labelX.Hide();
                MessageBox.Show("N value of First Matrix and M value of Second Matrix must be same.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            
        }

        private void buttonMultiple_Click(object sender, EventArgs e)
        {
            WriteMatrix.ClearSubmit(labelMultiple);
            WriteMatrix.MultiplicationOfMatrix(matrix1,matrix2,labelMultiple,comboBoxX1.SelectedIndex+1,comboBoxY.SelectedIndex+1,comboBoxX2.SelectedIndex+1,comboBoxY2.SelectedIndex+1);
        }
    }
}
