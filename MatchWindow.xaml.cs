using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows;
using System.Xml.Serialization;
using System.IO;

namespace WpfIPLTicketHub
{
    public partial class MatchWindow : Window
    {
        private string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["IPLTicketHubDB"].ConnectionString;

        public MatchWindow()
        {
            InitializeComponent();
            LoadMatches();
        }

        private void LoadMatches()
        {
            List<Match> matches = new List<Match>();

            string query = "SELECT Id, T1, T2, Venue, Time FROM dbo.Matches";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        matches.Add(new Match
                        {
                            Id = reader.GetInt32(0),
                            T1 = reader.GetString(1),
                            T2 = reader.GetString(2),
                            Venue = reader.GetString(3),
                            Time = reader.GetDateTime(4)
                        });
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            MatchesListView.ItemsSource = matches;
        }

        private void ProceedToTicketBooking_Click(object sender, RoutedEventArgs e)
        {
            if (MatchesListView.SelectedItem != null)
            {
                Match selectedMatch = (Match)MatchesListView.SelectedItem;

                // Serialize selectedMatch to XML
                SerializeMatchToXML(selectedMatch);

                // Proceed to ticket booking window
                TicketWindow ticketWindow = new TicketWindow();
                ticketWindow.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select a match to proceed.");
            }
        }

        private void SerializeMatchToXML(Match match)
        {
            try
            {
                // Construct the project-relative path to XML file
                string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                string filePath = Path.Combine(baseDirectory, @"..\..\..\Data\XMLFile.xml");

                // Create an instance of XmlSerializer for type Match
                XmlSerializer serializer = new XmlSerializer(typeof(Match));

                // Create a StreamWriter to write XML to file
                using (StreamWriter file = new StreamWriter(filePath))
                {
                    serializer.Serialize(file, match);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving match details to XML: " + ex.Message);
            }
        }

        public class Match
        {
            public int Id { get; set; }
            public string T1 { get; set; }
            public string T2 { get; set; }
            public string Venue { get; set; }
            public DateTime Time { get; set; }
        }
    }
}
