using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Xml.Serialization;

namespace WpfIPLTicketHub
{
    public partial class TicketWindow : Window
    {
        private List<string> selectedSeats = new List<string>();
        private string filePath = ""; // Path to XML file

        public TicketWindow()
        {
            InitializeComponent();

            // Construct the project-relative path to XML file
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            filePath = Path.Combine(baseDirectory, @"..\..\..\Data\XMLFile1.xml");
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            if (checkBox != null && checkBox.IsChecked == true)
            {
                string seat = checkBox.Name.Replace("CheckBox", "");
                selectedSeats.Add(seat);

                UpdateSelectedSeatsText();
                SaveSelectedSeatsToXml();
            }
        }
        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            if (checkBox != null && checkBox.IsChecked == false)
            {
                string seat = checkBox.Name.Replace("CheckBox", "");
                selectedSeats.Remove(seat);

                UpdateSelectedSeatsText();
                SaveSelectedSeatsToXml();
            }
        }

        private void UpdateSelectedSeatsText()
        {
            SelectedSeatsText.Text = "Selected Seats: " + string.Join(", ", selectedSeats);
        }

        private void SaveSelectedSeatsToXml()
        {
            try
            {
                // Create an instance of XmlSerializer for type List<string>
                XmlSerializer serializer = new XmlSerializer(typeof(List<string>));

                // Create a StreamWriter to write XML to file
                using (StreamWriter file = new StreamWriter(filePath))
                {
                    serializer.Serialize(file, selectedSeats);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving selected seats to XML: " + ex.Message);
            }
        }

        private void ProceedButton_Click(object sender, RoutedEventArgs e)
        {
            SaveSelectedSeatsToXml();
            ConfirmationWindow confirmationWindow = new ConfirmationWindow();
            confirmationWindow.Show();
            this.Close();
        }
    }
}
