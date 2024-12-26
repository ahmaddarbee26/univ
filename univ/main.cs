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
using univ;

namespace Univ
{
    public partial class main : Form
    {

        public main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string email = Email.Text;
            string password = Password.Text;

            string connectionString = "Server=DESKTOP-KCI0579;Database=univ;Trusted_Connection=True;TrustServerCertificate=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string adminQuery = "SELECT COUNT(*) FROM Admin WHERE Email = @Email AND Password = @Password";
                    SqlCommand adminCommand = new SqlCommand(adminQuery, connection);
                    adminCommand.Parameters.AddWithValue("@Email", email);
                    adminCommand.Parameters.AddWithValue("@Password", password);

                    var adminCount = (int)adminCommand.ExecuteScalar();

                    if (adminCount > 0)
                    {
                        MessageBox.Show("Welcome Admin!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        var adminForm = new Admin();
                        adminForm.Show();
                        this.Hide();
                        return;
                    }

                    
                    string teacherQuery = "SELECT Id FROM Teacher WHERE Email = @Email AND Password = @Password";
                    SqlCommand teacherCommand = new SqlCommand(teacherQuery, connection);
                    teacherCommand.Parameters.AddWithValue("@Email", email);
                    teacherCommand.Parameters.AddWithValue("@Password", password);

                    var result = teacherCommand.ExecuteScalar();

                    if (result != null)
                    {
                        int teacherId = Convert.ToInt32(result);

                        MessageBox.Show("Welcome Teacher!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        var teacherForm = new teacherpanel(teacherId);
                        teacherForm.Show();
                        this.Hide();
                    }
                    

                   
                    string studentQuery = "SELECT COUNT(*) FROM Students WHERE Email = @Email AND Password = @Password";
                    SqlCommand studentCommand = new SqlCommand(studentQuery, connection);
                    studentCommand.Parameters.AddWithValue("@Email", email);
                    studentCommand.Parameters.AddWithValue("@Password", password);

                    int studentCount = (int)studentCommand.ExecuteScalar();

                    if (studentCount > 0)
                    {
                        MessageBox.Show("Welcome Student!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        var studentForm = new studentpanel();
                        studentForm.Show();
                        this.Hide();
                        return;
                    }

                    
                    MessageBox.Show("Invalid credentials, please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }





        private void label1_Click(object sender, EventArgs e)
        {

        }




        private void clear_Click(object sender, EventArgs e)
        {
            Email.Text = string.Empty;
            Password.Text = string.Empty;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
