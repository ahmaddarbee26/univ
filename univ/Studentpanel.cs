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

namespace Univ
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
            string connectionString = "Server=DESKTOP-KCI0579;Database=univ;Trusted_Connection=True;TrustServerCertificate=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))

            {


                connection.Open();

                string query = "SELECT Name FROM Courses WHERE EnrollKey = @EnrollKey";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@EnrollKey", enrollKey);

                var Name = command.ExecuteScalar();

                if (Name != null)
                {
                    cource.Items.Add(Name.ToString());
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

            int selectedExamId = GetExamIdForSelectedCourse();

            if (selectedExamId == 0)
            {
                MessageBox.Show("No exam available for this course.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var examForm = new exampanel(selectedExamId);
            examForm.Show();
            this.Hide();
        }

        private int GetExamIdForSelectedCourse()
        {
            string selectedCourse = cource.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedCourse)) return 0;

            string connectionString = "Server=DESKTOP-KCI0579;Database=univ;Trusted_Connection=True;TrustServerCertificate=True;";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT Id FROM Exam WHERE CourseId = (SELECT Id FROM Courses WHERE Name = @Name)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Name", selectedCourse);

                    connection.Open();
                    var result = command.ExecuteScalar();

                    return result != null ? Convert.ToInt32(result) : 0;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
    }
}




