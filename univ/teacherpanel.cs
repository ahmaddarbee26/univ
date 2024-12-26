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

namespace Univ
{
    public partial class teacherpanel : Form
    {
        private int _teacherId;

        public teacherpanel(int teacherId)
        {
            InitializeComponent();
            _teacherId = teacherId;
            LoadCourses();
        }

        private void LoadCourses()
        {
            string connectionString = "Server=DESKTOP-KCI0579;Database=univ;Trusted_Connection=True;TrustServerCertificate=True;";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT Id, Name FROM Courses WHERE TeacherId = @TeacherId";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@TeacherId", _teacherId);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        checkedListBox1.Items.Add($"{reader["Id"]}: {reader["Name"]}");
                    }

                    reader.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCourses2()
        {
            string connectionString = "Server=DESKTOP-KCI0579;Database=univ;Trusted_Connection=True;TrustServerCertificate=True;";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT Id, Name FROM Courses WHERE TeacherId = @TeacherId";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@TeacherId", _teacherId);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        checkedListBox1.Items.Add(new KeyValuePair<int, string>((int)reader["Id"], reader["Name"].ToString()));
                    }

                    reader.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void create_exam_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = checkedListBox1.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedItem))
            {
                MessageBox.Show($"You selected: {selectedItem}", "Item Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            var checkedItems = checkedListBox1.CheckedItems;

            string checkedItemsList = string.Join(", ", checkedItems.Cast<string>());

            MessageBox.Show($"Checked items: {checkedItemsList}", "Checked Items", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    }
