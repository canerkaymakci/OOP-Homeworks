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
    public partial class TraceOfMatrix : UserControl
    {
        TextBox[,] matrix = new TextBox[5, 5];

        public TraceOfMatrix()
        {
            InitializeComponent();

            TextBox[,] box1 = new TextBox[5, 5]{{textBox1,textBox10,textBox15,textBox20,textBox25}, { textBox2, textBox9, textBox14, textBox19, textBox24 },
                { textBox3, textBox8, textBox13, textBox18, textBox23 },{textBox4,textBox7,textBox12,textBox17,textBox22},{textBox5,textBox6,textBox11,textBox16,textBox21} };

            matrix = box1;
        }

        private void buttonSet_Click(object sender, EventArgs e)
        {
            WriteMatrix.ShowOneMatrix(matrix, 5, 5, false);
            labelTrace.Text = "";
            WriteMatrix.ShowOneMatrix(matrix,comboBox1.SelectedIndex+1,comboBox1.SelectedIndex+1,true);
        }

        private void buttonTrace_Click(object sender, EventArgs e)
        {
            labelTrace.Text = "";
            WriteMatrix.TraceOfMatrix(matrix,labelTrace,comboBox1.SelectedIndex+1);
        }
    }
}
