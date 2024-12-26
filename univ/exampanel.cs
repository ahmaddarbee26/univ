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
using Univ;

namespace PROJECT
{
    public partial class exampanel : Form
    {
        private int _examId;

        public exampanel(int examId)
        {
            InitializeComponent();
            _examId = examId;
            LoadQuestions();
        }

        private void LoadQuestions()
        {
            string connectionString = "Server=DESKTOP-KCI0579;Database=univ;Trusted_Connection=True;TrustServerCertificate=True;";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT text, [choice 1], [choice 2], [choice 3], [choice 4] FROM Questions WHERE ExamId = @ExamId";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ExamId", _examId);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    int yOffset = 20;
                    int questionIndex = 1;

                    while (reader.Read())
                    {
                        GroupBox questionGroup = new GroupBox
                        {
                            Text = $"Q{questionIndex}: {reader["text"]}",
                            AutoSize = true,
                            Location = new System.Drawing.Point(10, yOffset),
                            Width = 400,
                            Height = 150
                        };

                        RadioButton option1 = new RadioButton
                        {
                            Text = reader["choice 1"].ToString(),
                            Location = new System.Drawing.Point(10, 20),
                            AutoSize = true
                        };

                        RadioButton option2 = new RadioButton
                        {
                            Text = reader["choice 2"].ToString(),
                            Location = new System.Drawing.Point(10, 50),
                            AutoSize = true
                        };

                        RadioButton option3 = new RadioButton
                        {
                            Text = reader["choice 3"].ToString(),
                            Location = new System.Drawing.Point(10, 80),
                            AutoSize = true
                        };

                        RadioButton option4 = new RadioButton
                        {
                            Text = reader["choice 4"].ToString(),
                            Location = new System.Drawing.Point(10, 110),
                            AutoSize = true
                        };

                        questionGroup.Controls.Add(option1);
                        questionGroup.Controls.Add(option2);
                        questionGroup.Controls.Add(option3);
                        questionGroup.Controls.Add(option4);

                        this.Controls.Add(questionGroup);

                        yOffset += 180;
                        questionIndex++;
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








        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void exampanel_Load(object sender, EventArgs e)
        {


        }

        private void choice2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void choice3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=DESKTOP-KCI0579;Database=univ;Trusted_Connection=True;TrustServerCertificate=True;";
            int correctAnswers = 0;
            int totalQuestions = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT Id, answer FROM Questions WHERE ExamId = @ExamId";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ExamId", _examId);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        int questionId = Convert.ToInt32(reader["Id"]);
                        string correctAnswer = reader["answer"].ToString();
                        RadioButton selectedAnswer = null;

                        foreach (Control control in this.Controls)
                        {
                            if (control is GroupBox groupBox && groupBox.Text.StartsWith($"Q{questionId}:"))
                            {
                                foreach (Control radio in groupBox.Controls)
                                {
                                    if (radio is RadioButton radioButton && radioButton.Checked)
                                    {
                                        selectedAnswer = radioButton;
                                        break;
                                    }
                                }
                            }
                        }

                        if (selectedAnswer != null && selectedAnswer.Text == correctAnswer)
                        {
                            correctAnswers++;
                        }

                        totalQuestions++;
                    }

                    reader.Close();
                }

                MessageBox.Show($"You answered {correctAnswers} out of {totalQuestions} questions correctly.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
