using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows;

namespace WpfIPLTicketHub
{
    public partial class MainWindow : Window
    {
        private string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["IPLTicketHubDB"].ConnectionString;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ForgotPasswordButton_Click(object sender, RoutedEventArgs e)
        {
            ForgotPasswordWindow forgotPasswordWindow = new ForgotPasswordWindow();
            forgotPasswordWindow.Show();
            this.Close();
        }

        private void SignInButton_Click(object sender, RoutedEventArgs e)
        {
            if (AuthenticateUser(SignInEmailTextBox.Text, SignInPasswordTextBox.Password))
            {
                MatchWindow matchWindow = new MatchWindow();
                matchWindow.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid email or password.");
            }
        }

        private void SignUpButton_Click(object sender, RoutedEventArgs e)
        {
            if (RegisterUser(FirstNameTextBox.Text, LastNameTextBox.Text, PhoneTextBox.Text, EmailTextBox.Text, PasswordTextBox.Password, ConfirmPasswordTextBox.Password, SecurityQuestionTextBox.Text))
            {
                MessageBox.Show("User registered successfully.");
                ClearUserInputFields();
            }
        }

        private bool RegisterUser(string firstName, string lastName, string phone, string email, string password, string confirmPassword, string securityQuestion)
        {
            if (!Regex.IsMatch(firstName, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("Firstname must contain only alphabets.");
                return false;
            }

            if (!Regex.IsMatch(lastName, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("Lastname must contain only alphabets.");
                return false;
            }

            if (!Regex.IsMatch(phone, @"^\d{10}$"))
            {
                MessageBox.Show("Phone number must contain exactly 10 digits.");
                return false;
            }

            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Email format is invalid.");
                return false;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.");
                return false;
            }

            if (Regex.IsMatch(securityQuestion, @"[^a-zA-Z0-9]"))
            {
                MessageBox.Show("Security question must not contain special characters.");
                return false;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO Users (FirstName, LastName, Phone, Email, Password, SecurityQuestion) VALUES (@FirstName, @LastName, @Phone, @Email, @Password, @SecurityQuestion)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@FirstName", firstName);
                    cmd.Parameters.AddWithValue("@LastName", lastName);
                    cmd.Parameters.AddWithValue("@Phone", phone);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@SecurityQuestion", securityQuestion);
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }

        private void ClearUserInputFields()
        {
            FirstNameTextBox.Text = string.Empty;
            LastNameTextBox.Text = string.Empty;
            PhoneTextBox.Text = string.Empty;
            EmailTextBox.Text = string.Empty;
            PasswordTextBox.Password = string.Empty;
            ConfirmPasswordTextBox.Password = string.Empty;
            SecurityQuestionTextBox.Text = string.Empty;
        }

        private bool AuthenticateUser(string email, string password)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT COUNT(1) FROM Users WHERE Email = @Email AND Password = @Password";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);
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
    }
}
