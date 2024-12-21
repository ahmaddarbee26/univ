namespace University
{
    partial class main
    {
        
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
            login = new Button();
            Password = new TextBox();
            Email = new TextBox();
            label1 = new Label();
            label2 = new Label();
            clear = new Button();
            exit = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // login
            // 
            login.Location = new Point(437, 329);
            login.Margin = new Padding(3, 4, 3, 4);
            login.Name = "login";
            login.Size = new Size(119, 41);
            login.TabIndex = 0;
            login.Text = "Login";
            login.UseVisualStyleBackColor = true;
            login.Click += button1_Click;
            // 
            // Password
            // 
            Password.Location = new Point(345, 252);
            Password.Margin = new Padding(3, 4, 3, 4);
            Password.Name = "Password";
            Password.Size = new Size(220, 27);
            Password.TabIndex = 1;
            Password.TextChanged += Password_TextChanged;
            // 
            // Email
            // 
            Email.Location = new Point(345, 191);
            Email.Margin = new Padding(3, 4, 3, 4);
            Email.Name = "Email";
            Email.Size = new Size(220, 27);
            Email.TabIndex = 2;
            Email.TextChanged += Email_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(263, 200);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 3;
            label1.Text = "Email";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(232, 261);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 4;
            label2.Text = "password";
            // 
            // clear
            // 
            clear.Location = new Point(315, 330);
            clear.Margin = new Padding(3, 4, 3, 4);
            clear.Name = "clear";
            clear.Size = new Size(96, 40);
            clear.TabIndex = 6;
            clear.Text = "clear";
            clear.UseVisualStyleBackColor = true;
            clear.Click += clear_Click;
            // 
            // exit
            // 
            exit.Location = new Point(381, 416);
            exit.Margin = new Padding(3, 4, 3, 4);
            exit.Name = "exit";
            exit.Size = new Size(110, 38);
            exit.TabIndex = 7;
            exit.Text = "exit";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.Font = new Font("Trebuchet MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(374, 78);
            label3.Name = "label3";
            label3.Size = new Size(131, 36);
            label3.TabIndex = 8;
            label3.Text = "welcome";
            // 
            // main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 562);
            Controls.Add(label3);
            Controls.Add(exit);
            Controls.Add(clear);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Email);
            Controls.Add(Password);
            Controls.Add(login);
            Margin = new Padding(3, 4, 3, 4);
            Name = "main";
            Text = "main ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button login;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label label3;
    }
}

