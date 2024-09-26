using System;
using System.Data.SqlClient;
using System.Windows;

namespace WpfIPLTicketHub
{
    public partial class ForgotPasswordWindow : Window
    {
        private string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["IPLTicketHubDB"].ConnectionString;

        public ForgotPasswordWindow()
        {
            InitializeComponent();
        }

        private void ResetPasswordButton_Click(object sender, RoutedEventArgs e)
        {
            string email = EmailTextBox.Text;
            string newPassword = PasswordTextBox.Password;
            string confirmPassword = ConfirmPasswordTextBox.Password;
            string securityQuestionAnswer = SecurityQuestionTextBox.Text;

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            if (VerifySecurityQuestion(email, securityQuestionAnswer))
            {
                if (UpdatePassword(email, newPassword))
                {
                    MessageBox.Show("Password reset successfully.");
                    ClearFields(); // Clear all fields after success
                }
                else
                {
                    MessageBox.Show("Error resetting password.");
                }
            }
            else
            {
                MessageBox.Show("Incorrect security question answer.");
            }
        }

        private bool VerifySecurityQuestion(string email, string securityQuestionAnswer)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT COUNT(1) FROM Users WHERE Email = @Email AND SecurityQuestion = @SecurityQuestion";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@SecurityQuestion", securityQuestionAnswer);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count == 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }

        private bool UpdatePassword(string email, string newPassword)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE Users SET Password = @Password WHERE Email = @Email";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Password", newPassword);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }

        private void ClearFields()
        {
            EmailTextBox.Text = string.Empty;
            PasswordTextBox.Password = string.Empty;
            ConfirmPasswordTextBox.Password = string.Empty;
            SecurityQuestionTextBox.Text = string.Empty;
        }

        private void HomePageButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
