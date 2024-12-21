namespace PROJECT
{
    partial class exampanel
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
            question = new Label();
            choice1 = new RadioButton();
            choice2 = new RadioButton();
            choice3 = new RadioButton();
            choice4 = new RadioButton();
            submit = new Button();
            SuspendLayout();
            // 
            // question
            // 
            question.AutoSize = true;
            question.Location = new Point(24, 41);
            question.Name = "question";
            question.Size = new Size(70, 20);
            question.TabIndex = 0;
            question.Text = "question ";
            question.Click += label1_Click;
            // 
            // choice1
            // 
            choice1.AutoSize = true;
            choice1.Location = new Point(24, 99);
            choice1.Margin = new Padding(3, 4, 3, 4);
            choice1.Name = "choice1";
            choice1.Size = new Size(85, 24);
            choice1.TabIndex = 1;
            choice1.TabStop = true;
            choice1.Text = "choice 1";
            choice1.UseVisualStyleBackColor = true;
            choice1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // choice2
            // 
            choice2.AutoSize = true;
            choice2.Location = new Point(24, 188);
            choice2.Margin = new Padding(3, 4, 3, 4);
            choice2.Name = "choice2";
            choice2.Size = new Size(85, 24);
            choice2.TabIndex = 2;
            choice2.TabStop = true;
            choice2.Text = "choice 2";
            choice2.UseVisualStyleBackColor = true;
            choice2.CheckedChanged += choice2_CheckedChanged;
            // 
            // choice3
            // 
            choice3.AutoSize = true;
            choice3.Location = new Point(24, 296);
            choice3.Margin = new Padding(3, 4, 3, 4);
            choice3.Name = "choice3";
            choice3.Size = new Size(85, 24);
            choice3.TabIndex = 3;
            choice3.TabStop = true;
            choice3.Text = "choice 3";
            choice3.UseVisualStyleBackColor = true;
            choice3.CheckedChanged += choice3_CheckedChanged;
            // 
            // choice4
            // 
            choice4.AutoSize = true;
            choice4.Location = new Point(24, 398);
            choice4.Margin = new Padding(3, 4, 3, 4);
            choice4.Name = "choice4";
            choice4.Size = new Size(85, 24);
            choice4.TabIndex = 4;
            choice4.TabStop = true;
            choice4.Text = "choice 4";
            choice4.UseVisualStyleBackColor = true;
            choice4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // submit
            // 
            submit.Location = new Point(46, 476);
            submit.Margin = new Padding(3, 4, 3, 4);
            submit.Name = "submit";
            submit.Size = new Size(157, 56);
            submit.TabIndex = 5;
            submit.Text = "submit";
            submit.UseVisualStyleBackColor = true;
            submit.Click += submit_Click;
            // 
            // exampanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 562);
            Controls.Add(submit);
            Controls.Add(choice4);
            Controls.Add(choice3);
            Controls.Add(choice2);
            Controls.Add(choice1);
            Controls.Add(question);
            Margin = new Padding(3, 4, 3, 4);
            Name = "exampanel";
            Text = "exampanel";
            Load += exampanel_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label question;
        private System.Windows.Forms.RadioButton choice1;
        private System.Windows.Forms.RadioButton choice2;
        private System.Windows.Forms.RadioButton choice3;
        private System.Windows.Forms.RadioButton choice4;
        private System.Windows.Forms.Button submit;
    }
}