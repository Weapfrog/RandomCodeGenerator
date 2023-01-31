
namespace RandomWordGenerator
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
            this.wordLabel = new System.Windows.Forms.Label();
            this.stopBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.createdWordsLabel = new System.Windows.Forms.Label();
            this.timerLabel = new System.Windows.Forms.Label();
            this.timerSecondsTick = new System.Windows.Forms.Label();
            this.backgroundWorkerWord = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerTime = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // wordLabel
            // 
            this.wordLabel.AutoSize = true;
            this.wordLabel.BackColor = System.Drawing.Color.Lime;
            this.wordLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.wordLabel.Location = new System.Drawing.Point(131, 41);
            this.wordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.wordLabel.Name = "wordLabel";
            this.wordLabel.Size = new System.Drawing.Size(0, 22);
            this.wordLabel.TabIndex = 0;
            // 
            // stopBtn
            // 
            this.stopBtn.Location = new System.Drawing.Point(310, 69);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(115, 47);
            this.stopBtn.TabIndex = 1;
            this.stopBtn.Text = "STOP";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(310, 16);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(115, 47);
            this.startBtn.TabIndex = 2;
            this.startBtn.Text = "START";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // createdWordsLabel
            // 
            this.createdWordsLabel.AutoSize = true;
            this.createdWordsLabel.Location = new System.Drawing.Point(79, 41);
            this.createdWordsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.createdWordsLabel.Name = "createdWordsLabel";
            this.createdWordsLabel.Size = new System.Drawing.Size(66, 22);
            this.createdWordsLabel.TabIndex = 3;
            this.createdWordsLabel.Text = "Code:";
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Location = new System.Drawing.Point(79, 82);
            this.timerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.timerLabel.Size = new System.Drawing.Size(71, 22);
            this.timerLabel.TabIndex = 4;
            this.timerLabel.Text = "Timer:";
            // 
            // timerSecondsTick
            // 
            this.timerSecondsTick.AutoSize = true;
            this.timerSecondsTick.ForeColor = System.Drawing.SystemColors.ControlText;
            this.timerSecondsTick.Location = new System.Drawing.Point(142, 82);
            this.timerSecondsTick.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timerSecondsTick.Name = "timerSecondsTick";
            this.timerSecondsTick.Size = new System.Drawing.Size(21, 22);
            this.timerSecondsTick.TabIndex = 5;
            this.timerSecondsTick.Text = "0";
            // 
            // backgroundWorkerWord
            // 
            this.backgroundWorkerWord.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // backgroundWorkerTime
            // 
            this.backgroundWorkerTime.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(445, 150);
            this.Controls.Add(this.timerSecondsTick);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.createdWordsLabel);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.wordLabel);
            this.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "RANDOM WORD GENERATOR";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label wordLabel;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Label createdWordsLabel;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Label timerSecondsTick;
        private System.ComponentModel.BackgroundWorker backgroundWorkerWord;
        private System.ComponentModel.BackgroundWorker backgroundWorkerTime;
    }
}

