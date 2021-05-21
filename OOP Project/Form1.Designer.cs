
namespace OOP_Project
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
            this.components = new System.ComponentModel.Container();
            this.fruitBox = new System.Windows.Forms.GroupBox();
            this.fruitPictures = new System.Windows.Forms.PictureBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonExtractor = new System.Windows.Forms.Button();
            this.buttonCitrus = new System.Windows.Forms.Button();
            this.buttonContinue = new System.Windows.Forms.Button();
            this.statsBox = new System.Windows.Forms.GroupBox();
            this.labelVitaminCSum = new System.Windows.Forms.Label();
            this.labelVitaminASum = new System.Windows.Forms.Label();
            this.labelTotalVitaminC = new System.Windows.Forms.Label();
            this.labelTotalVitaminA = new System.Windows.Forms.Label();
            this.labelTotalWeightSum = new System.Windows.Forms.Label();
            this.labelVitaminCFruit = new System.Windows.Forms.Label();
            this.labelVitaminAFruit = new System.Windows.Forms.Label();
            this.labelTotalWeight = new System.Windows.Forms.Label();
            this.labelVitaminC = new System.Windows.Forms.Label();
            this.labelVitaminA = new System.Windows.Forms.Label();
            this.labelAnswer = new System.Windows.Forms.Label();
            this.timeBox = new System.Windows.Forms.GroupBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.timerGame = new System.Windows.Forms.Timer(this.components);
            this.fruitBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fruitPictures)).BeginInit();
            this.statsBox.SuspendLayout();
            this.timeBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // fruitBox
            // 
            this.fruitBox.Controls.Add(this.fruitPictures);
            this.fruitBox.Location = new System.Drawing.Point(12, 12);
            this.fruitBox.Name = "fruitBox";
            this.fruitBox.Size = new System.Drawing.Size(244, 193);
            this.fruitBox.TabIndex = 0;
            this.fruitBox.TabStop = false;
            this.fruitBox.Text = "Fruit";
            // 
            // fruitPictures
            // 
            this.fruitPictures.Location = new System.Drawing.Point(6, 19);
            this.fruitPictures.Name = "fruitPictures";
            this.fruitPictures.Size = new System.Drawing.Size(232, 168);
            this.fruitPictures.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fruitPictures.TabIndex = 0;
            this.fruitPictures.TabStop = false;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(323, 336);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonExtractor
            // 
            this.buttonExtractor.Location = new System.Drawing.Point(286, 182);
            this.buttonExtractor.Name = "buttonExtractor";
            this.buttonExtractor.Size = new System.Drawing.Size(154, 23);
            this.buttonExtractor.TabIndex = 2;
            this.buttonExtractor.Text = "Juice Extractor";
            this.buttonExtractor.UseVisualStyleBackColor = true;
            this.buttonExtractor.Click += new System.EventHandler(this.buttonExtractor_Click);
            // 
            // buttonCitrus
            // 
            this.buttonCitrus.Location = new System.Drawing.Point(286, 60);
            this.buttonCitrus.Name = "buttonCitrus";
            this.buttonCitrus.Size = new System.Drawing.Size(154, 23);
            this.buttonCitrus.TabIndex = 3;
            this.buttonCitrus.Text = "Citrus Juicer";
            this.buttonCitrus.UseVisualStyleBackColor = true;
            this.buttonCitrus.Click += new System.EventHandler(this.buttonCitrus_Click);
            // 
            // buttonContinue
            // 
            this.buttonContinue.Location = new System.Drawing.Point(286, 122);
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Size = new System.Drawing.Size(154, 23);
            this.buttonContinue.TabIndex = 4;
            this.buttonContinue.Text = "Continue";
            this.buttonContinue.UseVisualStyleBackColor = true;
            this.buttonContinue.Click += new System.EventHandler(this.buttonContinue_Click);
            // 
            // statsBox
            // 
            this.statsBox.Controls.Add(this.labelVitaminCSum);
            this.statsBox.Controls.Add(this.labelVitaminASum);
            this.statsBox.Controls.Add(this.labelTotalVitaminC);
            this.statsBox.Controls.Add(this.labelTotalVitaminA);
            this.statsBox.Controls.Add(this.labelTotalWeightSum);
            this.statsBox.Controls.Add(this.labelVitaminCFruit);
            this.statsBox.Controls.Add(this.labelVitaminAFruit);
            this.statsBox.Controls.Add(this.labelTotalWeight);
            this.statsBox.Controls.Add(this.labelVitaminC);
            this.statsBox.Controls.Add(this.labelVitaminA);
            this.statsBox.Location = new System.Drawing.Point(18, 211);
            this.statsBox.Name = "statsBox";
            this.statsBox.Size = new System.Drawing.Size(238, 301);
            this.statsBox.TabIndex = 5;
            this.statsBox.TabStop = false;
            this.statsBox.Text = "Stats";
            // 
            // labelVitaminCSum
            // 
            this.labelVitaminCSum.AutoSize = true;
            this.labelVitaminCSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelVitaminCSum.Location = new System.Drawing.Point(156, 244);
            this.labelVitaminCSum.Name = "labelVitaminCSum";
            this.labelVitaminCSum.Size = new System.Drawing.Size(0, 18);
            this.labelVitaminCSum.TabIndex = 9;
            // 
            // labelVitaminASum
            // 
            this.labelVitaminASum.AutoSize = true;
            this.labelVitaminASum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelVitaminASum.Location = new System.Drawing.Point(156, 187);
            this.labelVitaminASum.Name = "labelVitaminASum";
            this.labelVitaminASum.Size = new System.Drawing.Size(0, 18);
            this.labelVitaminASum.TabIndex = 8;
            // 
            // labelTotalVitaminC
            // 
            this.labelTotalVitaminC.AutoSize = true;
            this.labelTotalVitaminC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTotalVitaminC.Location = new System.Drawing.Point(6, 244);
            this.labelTotalVitaminC.Name = "labelTotalVitaminC";
            this.labelTotalVitaminC.Size = new System.Drawing.Size(112, 18);
            this.labelTotalVitaminC.TabIndex = 7;
            this.labelTotalVitaminC.Text = "Total Vitamin C:";
            // 
            // labelTotalVitaminA
            // 
            this.labelTotalVitaminA.AutoSize = true;
            this.labelTotalVitaminA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTotalVitaminA.Location = new System.Drawing.Point(6, 187);
            this.labelTotalVitaminA.Name = "labelTotalVitaminA";
            this.labelTotalVitaminA.Size = new System.Drawing.Size(114, 18);
            this.labelTotalVitaminA.TabIndex = 6;
            this.labelTotalVitaminA.Text = "Total Vitamin A: ";
            // 
            // labelTotalWeightSum
            // 
            this.labelTotalWeightSum.AutoSize = true;
            this.labelTotalWeightSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTotalWeightSum.Location = new System.Drawing.Point(156, 130);
            this.labelTotalWeightSum.Name = "labelTotalWeightSum";
            this.labelTotalWeightSum.Size = new System.Drawing.Size(0, 18);
            this.labelTotalWeightSum.TabIndex = 5;
            // 
            // labelVitaminCFruit
            // 
            this.labelVitaminCFruit.AutoSize = true;
            this.labelVitaminCFruit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelVitaminCFruit.Location = new System.Drawing.Point(156, 73);
            this.labelVitaminCFruit.Name = "labelVitaminCFruit";
            this.labelVitaminCFruit.Size = new System.Drawing.Size(0, 18);
            this.labelVitaminCFruit.TabIndex = 4;
            // 
            // labelVitaminAFruit
            // 
            this.labelVitaminAFruit.AutoSize = true;
            this.labelVitaminAFruit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelVitaminAFruit.Location = new System.Drawing.Point(156, 16);
            this.labelVitaminAFruit.Name = "labelVitaminAFruit";
            this.labelVitaminAFruit.Size = new System.Drawing.Size(0, 18);
            this.labelVitaminAFruit.TabIndex = 3;
            // 
            // labelTotalWeight
            // 
            this.labelTotalWeight.AutoSize = true;
            this.labelTotalWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTotalWeight.Location = new System.Drawing.Point(6, 130);
            this.labelTotalWeight.Name = "labelTotalWeight";
            this.labelTotalWeight.Size = new System.Drawing.Size(95, 18);
            this.labelTotalWeight.TabIndex = 2;
            this.labelTotalWeight.Text = "Total Weight:";
            // 
            // labelVitaminC
            // 
            this.labelVitaminC.AutoSize = true;
            this.labelVitaminC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelVitaminC.Location = new System.Drawing.Point(6, 73);
            this.labelVitaminC.Name = "labelVitaminC";
            this.labelVitaminC.Size = new System.Drawing.Size(79, 18);
            this.labelVitaminC.TabIndex = 1;
            this.labelVitaminC.Text = "Vitamin C: ";
            // 
            // labelVitaminA
            // 
            this.labelVitaminA.AutoSize = true;
            this.labelVitaminA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelVitaminA.Location = new System.Drawing.Point(6, 16);
            this.labelVitaminA.Name = "labelVitaminA";
            this.labelVitaminA.Size = new System.Drawing.Size(77, 18);
            this.labelVitaminA.TabIndex = 0;
            this.labelVitaminA.Text = "Vitamin A: ";
            // 
            // labelAnswer
            // 
            this.labelAnswer.AutoSize = true;
            this.labelAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAnswer.Location = new System.Drawing.Point(306, 227);
            this.labelAnswer.Name = "labelAnswer";
            this.labelAnswer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelAnswer.Size = new System.Drawing.Size(0, 31);
            this.labelAnswer.TabIndex = 6;
            this.labelAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeBox
            // 
            this.timeBox.Controls.Add(this.labelTime);
            this.timeBox.Location = new System.Drawing.Point(298, 398);
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(130, 114);
            this.timeBox.TabIndex = 7;
            this.timeBox.TabStop = false;
            this.timeBox.Text = "Time";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTime.Location = new System.Drawing.Point(36, 35);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(42, 46);
            this.labelTime.TabIndex = 8;
            this.labelTime.Text = "0";
            // 
            // timerGame
            // 
            this.timerGame.Interval = 1000;
            this.timerGame.Tick += new System.EventHandler(this.timerGame_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 549);
            this.Controls.Add(this.timeBox);
            this.Controls.Add(this.labelAnswer);
            this.Controls.Add(this.statsBox);
            this.Controls.Add(this.buttonContinue);
            this.Controls.Add(this.buttonCitrus);
            this.Controls.Add(this.buttonExtractor);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.fruitBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.fruitBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fruitPictures)).EndInit();
            this.statsBox.ResumeLayout(false);
            this.statsBox.PerformLayout();
            this.timeBox.ResumeLayout(false);
            this.timeBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox fruitBox;
        private System.Windows.Forms.PictureBox fruitPictures;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonExtractor;
        private System.Windows.Forms.Button buttonCitrus;
        private System.Windows.Forms.Button buttonContinue;
        private System.Windows.Forms.GroupBox statsBox;
        private System.Windows.Forms.Label labelTotalWeightSum;
        private System.Windows.Forms.Label labelVitaminCFruit;
        private System.Windows.Forms.Label labelVitaminAFruit;
        private System.Windows.Forms.Label labelTotalWeight;
        private System.Windows.Forms.Label labelVitaminC;
        private System.Windows.Forms.Label labelVitaminA;
        private System.Windows.Forms.Label labelVitaminCSum;
        private System.Windows.Forms.Label labelVitaminASum;
        private System.Windows.Forms.Label labelTotalVitaminC;
        private System.Windows.Forms.Label labelTotalVitaminA;
        private System.Windows.Forms.Label labelAnswer;
        private System.Windows.Forms.GroupBox timeBox;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timerGame;
    }
}

