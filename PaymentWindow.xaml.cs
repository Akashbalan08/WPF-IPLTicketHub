using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WpfIPLTicketHub
{
    public partial class PaymentWindow : Window
    {
        public PaymentWindow()
        {
            InitializeComponent();
        }

        private void CardNumberTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !IsTextAllowed(e.Text, 16);
        }

        private void CVVTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !IsTextAllowed(e.Text, 3);
        }

        private void ExpiryDateTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !IsTextAllowed(e.Text, 4);
        }

        private bool IsTextAllowed(string text, int maxLength)
        {
            return text.All(char.IsDigit) && (text.Length + GetTextBoxText().Length <= maxLength);
        }

        private string GetTextBoxText()
        {
            if (Keyboard.FocusedElement is TextBox textBox)
            {
                return textBox.Text;
            }
            else if (Keyboard.FocusedElement is PasswordBox passwordBox)
            {
                return passwordBox.Password;
            }
            return string.Empty;
        }

        private void PayNowButton_Click(object sender, RoutedEventArgs e)
        {
            if (ValidateFields())
            {
                FinalWindow finalWindow = new FinalWindow();
                finalWindow.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Payment failed. Please correct the highlighted fields.", "Payment Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private bool ValidateFields()
        {
            bool isValid = true;

            if (CardNumberTextBox.Text.Length != 16 || !CardNumberTextBox.Text.All(char.IsDigit))
            {
                isValid = false;
                CardNumberTextBox.BorderBrush = System.Windows.Media.Brushes.Red;
            }
            else
            {
                CardNumberTextBox.BorderBrush = System.Windows.Media.Brushes.Black;
            }

            if (CVVTextBox.Password.Length != 3 || !CVVTextBox.Password.All(char.IsDigit))
            {
                isValid = false;
                CVVTextBox.BorderBrush = System.Windows.Media.Brushes.Red;
            }
            else
            {
                CVVTextBox.BorderBrush = System.Windows.Media.Brushes.Black;
            }

            if (ExpiryDateTextBox.Text.Length != 4 || !ExpiryDateTextBox.Text.All(char.IsDigit))
            {
                isValid = false;
                ExpiryDateTextBox.BorderBrush = System.Windows.Media.Brushes.Red;
            }
            else
            {
                ExpiryDateTextBox.BorderBrush = System.Windows.Media.Brushes.Black;
            }

            return isValid;
        }
    }
}
