using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using PROJECT;

namespace University
{
    public partial class studentpanel : Form
    {
        public studentpanel()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            string enrollKey = textBox1.Text;
            string connectionString = "Server=DESKTOP-KCI0579;Database=university;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {


                connection.Open();

                string query = "SELECT CourseName FROM Courses WHERE EnrollKey = @EnrollKey";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@EnrollKey", enrollKey);

                var courseName = command.ExecuteScalar();

                if (courseName != null)
                {
                    cource.Items.Add(courseName.ToString());
                    MessageBox.Show("Course added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Invalid enroll key.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void enroll_Click(object sender, EventArgs e)
        {
            label1_Click(sender, e);
        }

        private void cource_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCourse = cource.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(selectedCourse))
            {
                MessageBox.Show($"You selected the course: {selectedCourse}", "Course Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void do_exam_Click(object sender, EventArgs e)
        {
            string selectedCourse = cource.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedCourse))
            {
                MessageBox.Show("Please select a course to do the exam.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var examForm = new exampanel();
            examForm.course = selectedCourse;
            examForm.Show();
            this.Hide();
        }
    }

}



