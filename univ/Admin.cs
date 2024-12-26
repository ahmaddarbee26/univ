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

namespace univ
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void add_teacher_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Server=DESKTOP-KCI0579;Database=univ;Trusted_Connection=True;TrustServerCertificate=True;");
            connection.Open();
            string query = "INSERT INTO Teacher (Id, Name, Email, Password, College,CourseId) VALUES (@Id, @Name, @Email, @Password, @College, @CourseId)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Id", textBox8.Text);
            command.Parameters.AddWithValue("@Name", textBox9.Text);
            command.Parameters.AddWithValue("@Email", textBox10.Text);
            command.Parameters.AddWithValue("@Password", textBox11.Text);
            command.Parameters.AddWithValue("@College", textBox12.Text);
            command.Parameters.AddWithValue("@CourseId", textBox13.Text);

            command.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Teacher added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (textBox8.Text == "" || textBox9.Text == "" || textBox10.Text == "" || textBox11.Text == "" || textBox12.Text == "")
            {
                MessageBox.Show("Please fill all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void add_student_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Server=DESKTOP-KCI0579;Database=univ;Trusted_Connection=True;TrustServerCertificate=True;");
            connection.Open();
            string query = "INSERT INTO Students (Id, Name, Email, Password,U_Major ) VALUES (@Id, @Name, @Email, @Password, @U_Major)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Id", textBox8.Text);
            command.Parameters.AddWithValue("@Name", textBox9.Text);
            command.Parameters.AddWithValue("@Email", textBox10.Text);
            command.Parameters.AddWithValue("@Password", textBox11.Text);
            command.Parameters.AddWithValue("@U_Major", textBox12.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Student added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (textBox8.Text == "" || textBox9.Text == "" || textBox10.Text == "" || textBox11.Text == "" || textBox12.Text == "")
            {
                MessageBox.Show("Please fill all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                add_teacher.Hide();

            }
        }

        private void addcourse_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Server=DESKTOP-KCI0579;Database=univ;Trusted_Connection=True;TrustServerCertificate=True;");
            connection.Open();
            string query = "INSERT INTO Courses (Id, Name, Descrpition, level,Enrollkey ,TeacherId,ExamId ) VALUES (@Id, @Name, @Descrpition, @level, @Enrollkey, @TeacherId,@ExamId)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Id", textBox1.Text);
            command.Parameters.AddWithValue("@Name", textBox2.Text);
            command.Parameters.AddWithValue("@Descrpition", textBox3.Text);
            command.Parameters.AddWithValue("@level", textBox4.Text);
            command.Parameters.AddWithValue("@Enrollkey", textBox5.Text);
            command.Parameters.AddWithValue("@TeacherId", textBox7.Text);
            command.Parameters.AddWithValue("@ExamId", textBox6.Text);

            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("course added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox7.Text == "" || textBox6.Text == "")
            {
                MessageBox.Show("Please fill all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void update_Click(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection("Server=DESKTOP-KCI0579;Database=univ;Trusted_Connection=True;TrustServerCertificate=True;");
            connection.Open();
            string query = "UPDATE Courses SET Name = @Name, Descrpition = @Descrpition, level = @level, Enrollkey = @Enrollkey, TeacherId = @TeacherId WHERE Id = @Id";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Id", textBox1.Text);
            command.Parameters.AddWithValue("@Name", textBox2.Text);
            command.Parameters.AddWithValue("@Descrpition", textBox3.Text);
            command.Parameters.AddWithValue("@level", textBox4.Text);
            command.Parameters.AddWithValue("@Enrollkey", textBox5.Text);
            command.Parameters.AddWithValue("@TeacherId", textBox7.Text);

            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Course updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox7.Text == "")
            {
                MessageBox.Show("Please fill all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }



        private void delete_Click(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection("Server=DESKTOP-KCI0579;Database=univ;Trusted_Connection=True;TrustServerCertificate=True;");
            connection.Open();
            string query = "DELETE FROM Courses WHERE Id = @Id";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Id", textBox1.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Course deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please provide the course ID to delete!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }


        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void assign_Click(object sender, EventArgs e)
        {
            
        }
    }
}
