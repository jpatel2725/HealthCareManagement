using System.Windows;

namespace HealthCareManagement
{
    public partial class CreateAppointmentWindow : Window
    {
        public CreateAppointmentWindow()
        {
            InitializeComponent();
            LoadDoctors();
        }

        private void LoadDoctors()
        {
            // Load doctors from data source
            cmbDoctors.Items.Add("Dr. Smith");
            cmbDoctors.Items.Add("Dr. Johnson");
            // Add more doctors
        }

        private void ReserveAppointment_Click(object sender, RoutedEventArgs e)
        {
            // Logic to reserve appointment
            MessageBox.Show("Appointment reserved successfully!");
            this.Close();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
