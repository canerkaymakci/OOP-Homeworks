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
    public partial class TransposeOfMatrix : UserControl
    {
        TextBox[,] matrix = new TextBox[5, 5];
        Label[,] labelTranspose = new Label[5, 5];

        public TransposeOfMatrix()
        {
            InitializeComponent();

            TextBox[,] box1 = new TextBox[5, 5]{{textBox1,textBox10,textBox15,textBox20,textBox25}, { textBox2, textBox9, textBox14, textBox19, textBox24 },
                { textBox3, textBox8, textBox13, textBox18, textBox23 },{textBox4,textBox7,textBox12,textBox17,textBox22},{textBox5,textBox6,textBox11,textBox16,textBox21} };

            Label[,] labels = new Label[,] {{label1, label2, label3, label4, label5}, {label10, label9, label8, label7, label6},
                {label15, label14, label13, label12, label11}, {label20, label19, label18, label17, label16}, {label25, label24, label23, label22, label21}};


            matrix = box1;
            labelTranspose = labels;

        }

        private void buttonSet_Click(object sender, EventArgs e)
        {
            WriteMatrix.ShowOneMatrix(matrix, 5, 5, false);
            WriteMatrix.ClearSubmit(labelTranspose);
            WriteMatrix.ShowOneMatrix(matrix, comboBox1.SelectedIndex + 1, comboBox2.SelectedIndex + 1, true);
        }

        private void buttonTranspose_Click(object sender, EventArgs e)
        {
            WriteMatrix.ClearSubmit(labelTranspose);
            WriteMatrix.TransposeOfMatrix(matrix,labelTranspose,comboBox1.SelectedIndex+1, comboBox2.SelectedIndex + 1);
        }
    }
}
