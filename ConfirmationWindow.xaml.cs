using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Xml.Serialization;

namespace WpfIPLTicketHub
{
    public partial class ConfirmationWindow : Window
    {
        private string matchFilePath;
        private string seatsFilePath;

        public ConfirmationWindow()
        {
            InitializeComponent();
            // Construct the project-relative paths to XML files
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            matchFilePath = Path.Combine(baseDirectory, @"..\..\..\Data\XMLFile.xml");
            seatsFilePath = Path.Combine(baseDirectory, @"..\..\..\Data\XMLFile1.xml");

            LoadMatchDetails();
            LoadSeatsBooked();
        }

        private void LoadMatchDetails()
        {
            try
            {
                // Deserialize the match details
                XmlSerializer serializer = new XmlSerializer(typeof(Match));
                using (StreamReader file = new StreamReader(matchFilePath))
                {
                    Match match = (Match)serializer.Deserialize(file);
                    MatchText.Text = $"{match.T1} vs {match.T2}";
                    VenueText.Text = match.Venue;
                    TimeText.Text = match.Time;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading match details: " + ex.Message);
            }
        }

        private void LoadSeatsBooked()
        {
            try
            {
                // Deserialize the booked seats
                XmlSerializer serializer = new XmlSerializer(typeof(List<string>));
                using (StreamReader file = new StreamReader(seatsFilePath))
                {
                    List<string> bookedSeats = (List<string>)serializer.Deserialize(file);
                    SeatsBookedText.Text = string.Join(", ", bookedSeats);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading booked seats: " + ex.Message);
            }
        }
        private void PaymentScreen_click(object sender, RoutedEventArgs e)
        {
            PaymentWindow paymentwindow = new PaymentWindow();
            paymentwindow.Show();
            this.Close();
        }
    }

    // Define the Match class to match the structure of your XML
    public class Match
    {
        public string T1 { get; set; }
        public string T2 { get; set; }
        public string Venue { get; set; }
        public string Time { get; set; }
    }
}
