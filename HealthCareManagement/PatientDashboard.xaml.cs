using System.Windows;

namespace HealthCareManagement
{
    public partial class PatientDashboard : Window
    {
        public PatientDashboard()
        {
            InitializeComponent();
        }

        private void ManageAppointment_Click(object sender, RoutedEventArgs e)
        {
            ManageAppointmentsWindow manageAppointmentWindow = new ManageAppointmentsWindow();
            manageAppointmentWindow.Show();
        }

        private void ViewPrescriptions_Click(object sender, RoutedEventArgs e)
        {
            ViewPrescriptionsWindow viewPrescriptionsWindow = new ViewPrescriptionsWindow();
            viewPrescriptionsWindow.Show();
        }

        private void Profile_Click(object sender, RoutedEventArgs e)
        {
            ProfileWindow profileWindow = new ProfileWindow();
            profileWindow.Show();
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            MainWindow loginWindow = new MainWindow();
            loginWindow.Show();
            this.Close();
        }
    }
}
