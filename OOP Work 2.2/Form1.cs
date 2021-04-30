using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Work_2._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            sumOfMatrix1.Hide();
            multiplicationOfMatrix1.Hide();
            inverseMatrix1.Hide();
            traceOfMatrix1.Hide();
            transposeOfMatrix1.Hide();
            writeAMatrix1.Hide();
            buttonMenu.Hide();
            readLogs1.Hide();

            File.Create("log.txt").Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonWrite_Click(object sender, EventArgs e)
        {
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button5.Hide();
            button6.Hide();
            buttonSum.Hide();
            buttonWrite.Hide();
            labelPick.Hide();
            writeAMatrix1.Show();
            buttonMenu.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button5.Hide();
            button6.Hide();
            buttonSum.Hide();
            buttonWrite.Hide();
            labelPick.Hide();
            traceOfMatrix1.Show();
            buttonMenu.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            inverseMatrix1.Show();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button5.Hide();
            button6.Hide();
            buttonSum.Hide();
            buttonWrite.Hide();
            labelPick.Hide();
            buttonMenu.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            multiplicationOfMatrix1.Show();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button5.Hide();
            button6.Hide();
            buttonSum.Hide();
            buttonWrite.Hide();
            labelPick.Hide();
            buttonMenu.Show();
        }

        private void buttonSum_Click(object sender, EventArgs e)
        {
            sumOfMatrix1.Show();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button5.Hide();
            button6.Hide();
            buttonSum.Hide();
            buttonWrite.Hide();
            labelPick.Hide();
            buttonMenu.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button5.Hide();
            button6.Hide();
            buttonSum.Hide();
            buttonWrite.Hide();
            labelPick.Hide();
            transposeOfMatrix1.Show();
            buttonMenu.Show();
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            sumOfMatrix1.Hide();
            multiplicationOfMatrix1.Hide();
            inverseMatrix1.Hide();
            traceOfMatrix1.Hide();
            transposeOfMatrix1.Hide();
            writeAMatrix1.Hide();
            button2.Show();
            button3.Show();
            button4.Show();
            button5.Show();
            button6.Show();
            buttonSum.Show();
            buttonWrite.Show();
            labelPick.Show();
            buttonMenu.Hide();
            readLogs1.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReadLogs.rtbLog.Text = "";
            ReadLogs.rtbLog.Text = File.ReadAllText("log.txt");
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button5.Hide();
            button6.Hide();
            buttonSum.Hide();
            buttonWrite.Hide();
            labelPick.Hide();
            buttonMenu.Show();
            readLogs1.Show();

        }
    }
}
