namespace Univ
{
    partial class studentpanel
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
            label1 = new Label();
            textBox1 = new TextBox();
            enroll = new Button();
            cource = new ListBox();
            do_exam = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(152, 150);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 0;
            label1.Text = "enrollment key";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(285, 146);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(114, 27);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // enroll
            // 
            enroll.Location = new Point(273, 229);
            enroll.Margin = new Padding(3, 4, 3, 4);
            enroll.Name = "enroll";
            enroll.Size = new Size(126, 44);
            enroll.TabIndex = 2;
            enroll.Text = "enroll";
            enroll.UseVisualStyleBackColor = true;
            enroll.Click += enroll_Click;
            // 
            // cource
            // 
            cource.FormattingEnabled = true;
            cource.Location = new Point(262, 315);
            cource.Margin = new Padding(3, 4, 3, 4);
            cource.Name = "cource";
            cource.Size = new Size(172, 124);
            cource.TabIndex = 3;
            cource.SelectedIndexChanged += cource_SelectedIndexChanged;
            // 
            // do_exam
            // 
            do_exam.Location = new Point(273, 484);
            do_exam.Margin = new Padding(3, 4, 3, 4);
            do_exam.Name = "do_exam";
            do_exam.Size = new Size(110, 29);
            do_exam.TabIndex = 4;
            do_exam.Text = "do exam";
            do_exam.UseVisualStyleBackColor = true;
            do_exam.Click += do_exam_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(233, 52);
            label2.Name = "label2";
            label2.Size = new Size(252, 28);
            label2.TabIndex = 5;
            label2.Text = "welcome our students";
            // 
            // studentpanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 562);
            Controls.Add(label2);
            Controls.Add(do_exam);
            Controls.Add(cource);
            Controls.Add(enroll);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "studentpanel";
            Text = "studentpanel";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button enroll;
        private System.Windows.Forms.ListBox cource;
        private System.Windows.Forms.Button do_exam;
        private System.Windows.Forms.Label label2;
    }
}