
namespace OOP_Work_2._2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonSum = new System.Windows.Forms.Button();
            this.buttonWrite = new System.Windows.Forms.Button();
            this.labelPick = new System.Windows.Forms.Label();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.sumOfMatrix1 = new SumOfMatrix();
            this.traceOfMatrix1 = new TraceOfMatrix();
            this.inverseMatrix1 = new InverseMatrix();
            this.multiplicationOfMatrix1 = new MultiplicationOfMatrix();
            this.transposeOfMatrix1 = new TransposeOfMatrix();
            this.writeAMatrix1 = new WriteAMatrix();
            this.readLogs1 = new ReadLogs();
            this.SuspendLayout();
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.Location = new System.Drawing.Point(87, 242);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(235, 28);
            this.button6.TabIndex = 15;
            this.button6.Text = "Transpose of a Matrix";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.Location = new System.Drawing.Point(256, 192);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(82, 32);
            this.button5.TabIndex = 14;
            this.button5.Text = "Trace of a Matrix";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(70, 192);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(82, 32);
            this.button4.TabIndex = 13;
            this.button4.Text = "Inverse of a Matrix";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(70, 140);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 32);
            this.button3.TabIndex = 12;
            this.button3.Text = "Two Matrix Multiplication";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(256, 140);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 32);
            this.button2.TabIndex = 11;
            this.button2.Text = "Read a Matrix";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonSum
            // 
            this.buttonSum.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSum.Location = new System.Drawing.Point(256, 90);
            this.buttonSum.Name = "buttonSum";
            this.buttonSum.Size = new System.Drawing.Size(82, 32);
            this.buttonSum.TabIndex = 10;
            this.buttonSum.Text = "Sum of Two Matrices";
            this.buttonSum.UseVisualStyleBackColor = true;
            this.buttonSum.Click += new System.EventHandler(this.buttonSum_Click);
            // 
            // buttonWrite
            // 
            this.buttonWrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonWrite.Location = new System.Drawing.Point(70, 90);
            this.buttonWrite.Name = "buttonWrite";
            this.buttonWrite.Size = new System.Drawing.Size(82, 32);
            this.buttonWrite.TabIndex = 9;
            this.buttonWrite.Text = "Write a Matrix";
            this.buttonWrite.UseVisualStyleBackColor = true;
            this.buttonWrite.Click += new System.EventHandler(this.buttonWrite_Click);
            // 
            // labelPick
            // 
            this.labelPick.AutoSize = true;
            this.labelPick.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelPick.Location = new System.Drawing.Point(143, 30);
            this.labelPick.Name = "labelPick";
            this.labelPick.Size = new System.Drawing.Size(123, 22);
            this.labelPick.TabIndex = 8;
            this.labelPick.Text = "Pick a Method";
            // 
            // buttonMenu
            // 
            this.buttonMenu.Location = new System.Drawing.Point(345, 305);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(75, 23);
            this.buttonMenu.TabIndex = 21;
            this.buttonMenu.Text = "Menu";
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // sumOfMatrix1
            // 
            this.sumOfMatrix1.Location = new System.Drawing.Point(12, 12);
            this.sumOfMatrix1.Name = "sumOfMatrix1";
            this.sumOfMatrix1.Size = new System.Drawing.Size(408, 319);
            this.sumOfMatrix1.TabIndex = 16;
            // 
            // traceOfMatrix1
            // 
            this.traceOfMatrix1.Location = new System.Drawing.Point(12, 12);
            this.traceOfMatrix1.Name = "traceOfMatrix1";
            this.traceOfMatrix1.Size = new System.Drawing.Size(408, 319);
            this.traceOfMatrix1.TabIndex = 19;
            // 
            // inverseMatrix1
            // 
            this.inverseMatrix1.Location = new System.Drawing.Point(12, 9);
            this.inverseMatrix1.Name = "inverseMatrix1";
            this.inverseMatrix1.Size = new System.Drawing.Size(408, 319);
            this.inverseMatrix1.TabIndex = 18;
            // 
            // multiplicationOfMatrix1
            // 
            this.multiplicationOfMatrix1.Location = new System.Drawing.Point(12, 15);
            this.multiplicationOfMatrix1.Name = "multiplicationOfMatrix1";
            this.multiplicationOfMatrix1.Size = new System.Drawing.Size(408, 319);
            this.multiplicationOfMatrix1.TabIndex = 17;
            // 
            // transposeOfMatrix1
            // 
            this.transposeOfMatrix1.Location = new System.Drawing.Point(13, 9);
            this.transposeOfMatrix1.Name = "transposeOfMatrix1";
            this.transposeOfMatrix1.Size = new System.Drawing.Size(408, 319);
            this.transposeOfMatrix1.TabIndex = 20;
            // 
            // writeAMatrix1
            // 
            this.writeAMatrix1.Location = new System.Drawing.Point(13, 9);
            this.writeAMatrix1.Name = "writeAMatrix1";
            this.writeAMatrix1.Size = new System.Drawing.Size(408, 319);
            this.writeAMatrix1.TabIndex = 22;
            // 
            // readLogs1
            // 
            this.readLogs1.Location = new System.Drawing.Point(12, 12);
            this.readLogs1.Name = "readLogs1";
            this.readLogs1.Size = new System.Drawing.Size(408, 319);
            this.readLogs1.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(433, 346);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonSum);
            this.Controls.Add(this.buttonWrite);
            this.Controls.Add(this.labelPick);
            this.Controls.Add(this.sumOfMatrix1);
            this.Controls.Add(this.traceOfMatrix1);
            this.Controls.Add(this.inverseMatrix1);
            this.Controls.Add(this.multiplicationOfMatrix1);
            this.Controls.Add(this.transposeOfMatrix1);
            this.Controls.Add(this.writeAMatrix1);
            this.Controls.Add(this.readLogs1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "Form1";
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonSum;
        private System.Windows.Forms.Button buttonWrite;
        private System.Windows.Forms.Label labelPick;
        private SumOfMatrix sumOfMatrix1;
        private MultiplicationOfMatrix multiplicationOfMatrix1;
        private InverseMatrix inverseMatrix1;
        private TraceOfMatrix traceOfMatrix1;
        private TransposeOfMatrix transposeOfMatrix1;
        private System.Windows.Forms.Button buttonMenu;
        private WriteAMatrix writeAMatrix1;
        private ReadLogs readLogs1;
    }
}

