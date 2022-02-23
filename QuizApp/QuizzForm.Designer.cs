
namespace QuizApp
{
    partial class QuizzForm
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
            this.lQuizz = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.timerQuizz = new System.Windows.Forms.Timer(this.components);
            this.tbTimer = new System.Windows.Forms.TextBox();
            this.panel = new System.Windows.Forms.Panel();
            this.btnNext = new System.Windows.Forms.Button();
            this.lChoiceD = new System.Windows.Forms.Label();
            this.lChoiceB = new System.Windows.Forms.Label();
            this.lChoiceC = new System.Windows.Forms.Label();
            this.lChoiceA = new System.Windows.Forms.Label();
            this.btnChoiceD = new System.Windows.Forms.Button();
            this.btnChoiceB = new System.Windows.Forms.Button();
            this.btnChoiceC = new System.Windows.Forms.Button();
            this.btnChoiceA = new System.Windows.Forms.Button();
            this.lQuestion = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lQuizz
            // 
            this.lQuizz.AutoSize = true;
            this.lQuizz.Location = new System.Drawing.Point(475, 65);
            this.lQuizz.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lQuizz.Name = "lQuizz";
            this.lQuizz.Size = new System.Drawing.Size(89, 24);
            this.lQuizz.TabIndex = 0;
            this.lQuizz.Text = "Quiz App";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(442, 172);
            this.btnStart.Margin = new System.Windows.Forms.Padding(6);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(138, 42);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // timerQuizz
            // 
            this.timerQuizz.Interval = 1000;
            this.timerQuizz.Tick += new System.EventHandler(this.timerQuizz_Tick);
            // 
            // tbTimer
            // 
            this.tbTimer.Location = new System.Drawing.Point(1006, 18);
            this.tbTimer.Name = "tbTimer";
            this.tbTimer.ReadOnly = true;
            this.tbTimer.Size = new System.Drawing.Size(83, 29);
            this.tbTimer.TabIndex = 2;
            this.tbTimer.Visible = false;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Aqua;
            this.panel.Controls.Add(this.btnNext);
            this.panel.Controls.Add(this.lChoiceD);
            this.panel.Controls.Add(this.lChoiceB);
            this.panel.Controls.Add(this.lChoiceC);
            this.panel.Controls.Add(this.lChoiceA);
            this.panel.Controls.Add(this.btnChoiceD);
            this.panel.Controls.Add(this.btnChoiceB);
            this.panel.Controls.Add(this.btnChoiceC);
            this.panel.Controls.Add(this.btnChoiceA);
            this.panel.Controls.Add(this.lQuestion);
            this.panel.Location = new System.Drawing.Point(142, 38);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(858, 261);
            this.panel.TabIndex = 3;
            this.panel.Visible = false;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(769, 186);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 33);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lChoiceD
            // 
            this.lChoiceD.AutoSize = true;
            this.lChoiceD.Location = new System.Drawing.Point(567, 195);
            this.lChoiceD.Name = "lChoiceD";
            this.lChoiceD.Size = new System.Drawing.Size(0, 24);
            this.lChoiceD.TabIndex = 2;
            this.lChoiceD.Click += new System.EventHandler(this.btnChoiceD_Click);
            // 
            // lChoiceB
            // 
            this.lChoiceB.AutoSize = true;
            this.lChoiceB.Location = new System.Drawing.Point(134, 195);
            this.lChoiceB.Name = "lChoiceB";
            this.lChoiceB.Size = new System.Drawing.Size(0, 24);
            this.lChoiceB.TabIndex = 2;
            this.lChoiceB.Click += new System.EventHandler(this.btnChoiceB_Click);
            // 
            // lChoiceC
            // 
            this.lChoiceC.AutoSize = true;
            this.lChoiceC.Location = new System.Drawing.Point(567, 136);
            this.lChoiceC.Name = "lChoiceC";
            this.lChoiceC.Size = new System.Drawing.Size(0, 24);
            this.lChoiceC.TabIndex = 2;
            this.lChoiceC.Click += new System.EventHandler(this.btnChoiceC_Click);
            // 
            // lChoiceA
            // 
            this.lChoiceA.AutoSize = true;
            this.lChoiceA.Location = new System.Drawing.Point(134, 136);
            this.lChoiceA.Name = "lChoiceA";
            this.lChoiceA.Size = new System.Drawing.Size(0, 24);
            this.lChoiceA.TabIndex = 2;
            this.lChoiceA.Click += new System.EventHandler(this.btnChoiceA_Click);
            // 
            // btnChoiceD
            // 
            this.btnChoiceD.Location = new System.Drawing.Point(479, 186);
            this.btnChoiceD.Name = "btnChoiceD";
            this.btnChoiceD.Size = new System.Drawing.Size(82, 42);
            this.btnChoiceD.TabIndex = 1;
            this.btnChoiceD.Text = "D";
            this.btnChoiceD.UseVisualStyleBackColor = true;
            this.btnChoiceD.Click += new System.EventHandler(this.btnChoiceD_Click);
            // 
            // btnChoiceB
            // 
            this.btnChoiceB.Location = new System.Drawing.Point(46, 186);
            this.btnChoiceB.Name = "btnChoiceB";
            this.btnChoiceB.Size = new System.Drawing.Size(82, 42);
            this.btnChoiceB.TabIndex = 1;
            this.btnChoiceB.Text = "B";
            this.btnChoiceB.UseVisualStyleBackColor = true;
            this.btnChoiceB.Click += new System.EventHandler(this.btnChoiceB_Click);
            // 
            // btnChoiceC
            // 
            this.btnChoiceC.Location = new System.Drawing.Point(479, 127);
            this.btnChoiceC.Name = "btnChoiceC";
            this.btnChoiceC.Size = new System.Drawing.Size(82, 42);
            this.btnChoiceC.TabIndex = 1;
            this.btnChoiceC.Text = "C";
            this.btnChoiceC.UseVisualStyleBackColor = true;
            this.btnChoiceC.Click += new System.EventHandler(this.btnChoiceC_Click);
            // 
            // btnChoiceA
            // 
            this.btnChoiceA.Location = new System.Drawing.Point(46, 127);
            this.btnChoiceA.Name = "btnChoiceA";
            this.btnChoiceA.Size = new System.Drawing.Size(82, 42);
            this.btnChoiceA.TabIndex = 1;
            this.btnChoiceA.Text = "A";
            this.btnChoiceA.UseVisualStyleBackColor = true;
            this.btnChoiceA.Click += new System.EventHandler(this.btnChoiceA_Click);
            // 
            // lQuestion
            // 
            this.lQuestion.AutoSize = true;
            this.lQuestion.Location = new System.Drawing.Point(42, 20);
            this.lQuestion.Name = "lQuestion";
            this.lQuestion.Size = new System.Drawing.Size(0, 24);
            this.lQuestion.TabIndex = 0;
            // 
            // QuizzForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 404);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.tbTimer);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lQuizz);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "QuizzForm";
            this.Text = "Quizz App";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lQuizz;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timerQuizz;
        private System.Windows.Forms.TextBox tbTimer;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label lChoiceA;
        private System.Windows.Forms.Button btnChoiceA;
        private System.Windows.Forms.Label lQuestion;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lChoiceD;
        private System.Windows.Forms.Label lChoiceB;
        private System.Windows.Forms.Label lChoiceC;
        private System.Windows.Forms.Button btnChoiceD;
        private System.Windows.Forms.Button btnChoiceB;
        private System.Windows.Forms.Button btnChoiceC;
    }
}

