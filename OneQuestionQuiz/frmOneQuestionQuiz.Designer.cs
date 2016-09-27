namespace OneQuestionQuiz
{
    partial class frmOneQuestionQuiz
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.grpRadioButtons = new System.Windows.Forms.GroupBox();
            this.rdoBuddy = new System.Windows.Forms.RadioButton();
            this.rdoBandit = new System.Windows.Forms.RadioButton();
            this.rdoSimba = new System.Windows.Forms.RadioButton();
            this.rdoCharlie = new System.Windows.Forms.RadioButton();
            this.lblResult = new System.Windows.Forms.Label();
            this.grpRadioButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(12, 9);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(151, 13);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "What is Jasmyn\'s dog\'s name?";
            this.lblQuestion.Click += new System.EventHandler(this.label1_Click);
            // 
            // grpRadioButtons
            // 
            this.grpRadioButtons.Controls.Add(this.rdoBuddy);
            this.grpRadioButtons.Controls.Add(this.rdoBandit);
            this.grpRadioButtons.Controls.Add(this.rdoSimba);
            this.grpRadioButtons.Controls.Add(this.rdoCharlie);
            this.grpRadioButtons.Location = new System.Drawing.Point(28, 59);
            this.grpRadioButtons.Name = "grpRadioButtons";
            this.grpRadioButtons.Size = new System.Drawing.Size(200, 100);
            this.grpRadioButtons.TabIndex = 1;
            this.grpRadioButtons.TabStop = false;
            // 
            // rdoBuddy
            // 
            this.rdoBuddy.AutoSize = true;
            this.rdoBuddy.Location = new System.Drawing.Point(128, 52);
            this.rdoBuddy.Name = "rdoBuddy";
            this.rdoBuddy.Size = new System.Drawing.Size(55, 17);
            this.rdoBuddy.TabIndex = 3;
            this.rdoBuddy.TabStop = true;
            this.rdoBuddy.Text = "Buddy";
            this.rdoBuddy.UseVisualStyleBackColor = true;
            this.rdoBuddy.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdoBandit
            // 
            this.rdoBandit.AutoSize = true;
            this.rdoBandit.Location = new System.Drawing.Point(20, 29);
            this.rdoBandit.Name = "rdoBandit";
            this.rdoBandit.Size = new System.Drawing.Size(55, 17);
            this.rdoBandit.TabIndex = 2;
            this.rdoBandit.TabStop = true;
            this.rdoBandit.Text = "Bandit";
            this.rdoBandit.UseVisualStyleBackColor = true;
            this.rdoBandit.CheckedChanged += new System.EventHandler(this.rdbBandit_CheckedChanged);
            // 
            // rdoSimba
            // 
            this.rdoSimba.AutoSize = true;
            this.rdoSimba.Location = new System.Drawing.Point(128, 29);
            this.rdoSimba.Name = "rdoSimba";
            this.rdoSimba.Size = new System.Drawing.Size(54, 17);
            this.rdoSimba.TabIndex = 1;
            this.rdoSimba.TabStop = true;
            this.rdoSimba.Text = "Simba";
            this.rdoSimba.UseVisualStyleBackColor = true;
            this.rdoSimba.CheckedChanged += new System.EventHandler(this.rdbSimba_CheckedChanged);
            // 
            // rdoCharlie
            // 
            this.rdoCharlie.AutoSize = true;
            this.rdoCharlie.Location = new System.Drawing.Point(20, 52);
            this.rdoCharlie.Name = "rdoCharlie";
            this.rdoCharlie.Size = new System.Drawing.Size(57, 17);
            this.rdoCharlie.TabIndex = 0;
            this.rdoCharlie.TabStop = true;
            this.rdoCharlie.Text = "Charlie";
            this.rdoCharlie.UseVisualStyleBackColor = true;
            this.rdoCharlie.CheckedChanged += new System.EventHandler(this.rdbCharlie_CheckedChanged);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(25, 171);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 2;
            // 
            // frmOneQuestionQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(319, 258);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.grpRadioButtons);
            this.Controls.Add(this.lblQuestion);
            this.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Name = "frmOneQuestionQuiz";
            this.Text = "One Question Quiz";
            this.Load += new System.EventHandler(this.lblQuestion_Load);
            this.grpRadioButtons.ResumeLayout(false);
            this.grpRadioButtons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.GroupBox grpRadioButtons;
        private System.Windows.Forms.RadioButton rdoBandit;
        private System.Windows.Forms.RadioButton rdoSimba;
        private System.Windows.Forms.RadioButton rdoCharlie;
        private System.Windows.Forms.RadioButton rdoBuddy;
        private System.Windows.Forms.Label lblResult;
    }
}

