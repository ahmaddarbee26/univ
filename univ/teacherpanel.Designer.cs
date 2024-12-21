namespace University
{
    partial class teacherpanel
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
            create_exam = new Button();
            view_marks = new Button();
            checkedListBox1 = new CheckedListBox();
            SuspendLayout();
            // 
            // create_exam
            // 
            create_exam.Location = new Point(53, 254);
            create_exam.Margin = new Padding(3, 4, 3, 4);
            create_exam.Name = "create_exam";
            create_exam.Size = new Size(149, 51);
            create_exam.TabIndex = 0;
            create_exam.Text = "create exam";
            create_exam.UseVisualStyleBackColor = true;
            create_exam.Click += create_exam_Click;
            // 
            // view_marks
            // 
            view_marks.Location = new Point(281, 254);
            view_marks.Margin = new Padding(3, 4, 3, 4);
            view_marks.Name = "view_marks";
            view_marks.Size = new Size(145, 51);
            view_marks.TabIndex = 1;
            view_marks.Text = "view marks";
            view_marks.UseVisualStyleBackColor = true;
            view_marks.Click += button2_Click;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(146, 81);
            checkedListBox1.Margin = new Padding(3, 4, 3, 4);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(177, 114);
            checkedListBox1.TabIndex = 2;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // teacherpanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 562);
            Controls.Add(checkedListBox1);
            Controls.Add(view_marks);
            Controls.Add(create_exam);
            Margin = new Padding(3, 4, 3, 4);
            Name = "teacherpanel";
            Text = "teacherpanel";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button create_exam;
        private System.Windows.Forms.Button view_marks;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}