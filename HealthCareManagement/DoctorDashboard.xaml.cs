using System.Windows;

namespace HealthCareManagement
{
    public partial class DoctorDashboard : Window
    {
        public DoctorDashboard()
        {
            InitializeComponent();
        }

        private void ViewPatients_Click(object sender, RoutedEventArgs e)
        {
            ViewPatientsWindow viewPatientsWindow = new ViewPatientsWindow();
            viewPatientsWindow.Show();
        }

        private void ViewAppointments_Click(object sender, RoutedEventArgs e)
        {
            ViewAppointmentsWindow viewAppointmentsWindow = new ViewAppointmentsWindow();
            viewAppointmentsWindow.Show();
        }

        private void ViewEmergencyList_Click(object sender, RoutedEventArgs e)
        {
            ViewEmergencyListWindow viewEmergencyListWindow = new ViewEmergencyListWindow();
            viewEmergencyListWindow.Show();
        }

        private void ViewRegularList_Click(object sender, RoutedEventArgs e)
        {
            ViewRegularListWindow viewRegularListWindow = new ViewRegularListWindow();
            viewRegularListWindow.Show();
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            MainWindow loginWindow = new MainWindow();
            loginWindow.Show();
            this.Close();
        }
    }
}
