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

namespace University
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void add_teacher_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
       string.IsNullOrWhiteSpace(textBox2.Text) ||
       string.IsNullOrWhiteSpace(textBox3.Text) ||
       string.IsNullOrWhiteSpace(textBox4.Text) ||
       string.IsNullOrWhiteSpace(textBox5.Text))
            {
                MessageBox.Show("Please fill all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // إنشاء الاتصال والاستعلام
            using (SqlConnection connection = new SqlConnection("Server=DESKTOP-KCI0579;Database=university;Trusted_Connection=True;TrustServerCertificate=True;"))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO Teachers (Id, Name, Email, Password, College) VALUES (@Id, @Name, @Email, @Password, @College)";
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@Id", textBox1.Text);
                    command.Parameters.AddWithValue("@Name", textBox2.Text);
                    command.Parameters.AddWithValue("@Email", textBox3.Text);
                    command.Parameters.AddWithValue("@Password", textBox4.Text);
                    command.Parameters.AddWithValue("@College", textBox5.Text);

                    // تنفيذ الإدخال
                    command.ExecuteNonQuery();

                    MessageBox.Show("Teacher added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }



        private void add_student_Click(object sender, EventArgs e, SqlConnection connection)
        {
            SqlConnection connection = new SqlConnection("Server=DESKTOP-KCI0579;Database=university;Trusted_Connection=True;TrustServerCertificate=True;");
            connection.Open();
            string query = "INSERT INTO Students (Id, Name, Email, Password, U_Major) VALUES (@Id, @Name, @Email, @Password, @U_Major)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Id", textBox1.Text);
            command.Parameters.AddWithValue("@Name", textBox2.Text);
            command.Parameters.AddWithValue("@Email", textBox3.Text);
            command.Parameters.AddWithValue("@Password", textBox4.Text);
            command.Parameters.AddWithValue("@U_Major", textBox5.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Student added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("Please fill all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                add_teacher.Hide();

            }
        }
    }
}