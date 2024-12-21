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

            string connectionString = "Server=DESKTOP-KCI0579;Database=university;Trusted_Connection=True;TrustServerCertificate=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT Role FROM Users1 WHERE Email = @Email AND Password = @Password";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Password", password);

                    var role = command.ExecuteScalar();

                    if (role != null)
                    {
                        string userRole = role.ToString();

                        if (userRole == "Admin")
                        {
                            MessageBox.Show("Welcome Admin!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            var adminForm = new admin();
                            adminForm.Show();
                            this.Hide();
                        }
                        else if (userRole == "Teacher")
                        {
                            MessageBox.Show("Welcome Teacher!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            var teacherForm = new teacherpanel();
                            teacherForm.Show();
                            this.Hide();
                        }
                        else if (userRole == "Student")
                        {
                            MessageBox.Show("Welcome Student!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            var studentForm = new studentpanel();
                            studentForm.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid credentials, please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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
