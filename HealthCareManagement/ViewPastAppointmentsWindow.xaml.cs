using System.Windows;

namespace HealthCareManagement
{
    public partial class ViewPastAppointmentsWindow : Window
    {
        public ViewPastAppointmentsWindow()
        {
            InitializeComponent();
            LoadPastAppointments();
        }

        private void LoadPastAppointments()
        {
            // Load past appointments from data source
            lbPastAppointments.Items.Add("Appointment with Dr. Smith on 01/01/2023");
            lbPastAppointments.Items.Add("Appointment with Dr. Johnson on 02/01/2023");
            // Add more past appointments
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
