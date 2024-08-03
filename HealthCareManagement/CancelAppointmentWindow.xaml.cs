using System.Windows;

namespace HealthCareManagement
{
    public partial class CancelAppointmentWindow : Window
    {
        public CancelAppointmentWindow()
        {
            InitializeComponent();
            LoadAppointments();
        }

        private void LoadAppointments()
        {
            // Load reserved appointments from data source
            cmbAppointments.Items.Add("Appointment with Dr. Smith on 01/01/2024");
            cmbAppointments.Items.Add("Appointment with Dr. Johnson on 02/01/2024");
            // Add more appointments
        }

        private void CancelAppointment_Click(object sender, RoutedEventArgs e)
        {
            // Logic to cancel appointment
            MessageBox.Show("Appointment cancelled successfully!");
            this.Close();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
