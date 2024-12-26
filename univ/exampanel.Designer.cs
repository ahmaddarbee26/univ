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
            submit = new Button();
            SuspendLayout();
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "exampanel";
            Text = "exampanel";
            Load += exampanel_Load;
            ResumeLayout(false);
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