
namespace OOP_Work_2._2
{
    partial class ReadLogs
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblLogs = new System.Windows.Forms.Label();
            this.rtbMatrix = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblLogs
            // 
            this.lblLogs.AutoSize = true;
            this.lblLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLogs.Location = new System.Drawing.Point(181, 0);
            this.lblLogs.Name = "lblLogs";
            this.lblLogs.Size = new System.Drawing.Size(49, 22);
            this.lblLogs.TabIndex = 0;
            this.lblLogs.Text = "Logs";
            // 
            // rtbMatrix
            // 
            this.rtbMatrix.Location = new System.Drawing.Point(3, 25);
            this.rtbMatrix.Name = "rtbMatrix";
            this.rtbMatrix.Size = new System.Drawing.Size(402, 258);
            this.rtbMatrix.TabIndex = 1;
            this.rtbMatrix.Text = "";
            // 
            // ReadLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rtbMatrix);
            this.Controls.Add(this.lblLogs);
            this.Name = "ReadLogs";
            this.Size = new System.Drawing.Size(408, 319);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogs;
        private System.Windows.Forms.RichTextBox rtbMatrix;
    }
}
