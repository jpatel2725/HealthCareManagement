using System.Windows;

namespace HealthCareManagement
{
    public partial class ManageAppointmentsWindow : Window
    {
        public ManageAppointmentsWindow()
        {
            InitializeComponent();
        }

        private void CreateAppointment_Click(object sender, RoutedEventArgs e)
        {
            CreateAppointmentWindow createAppointmentWindow = new CreateAppointmentWindow();
            createAppointmentWindow.Show();
        }

        private void CancelAppointment_Click(object sender, RoutedEventArgs e)
        {
            CancelAppointmentWindow cancelAppointmentWindow = new CancelAppointmentWindow();
            cancelAppointmentWindow.Show();
        }

        private void ViewPastAppointments_Click(object sender, RoutedEventArgs e)
        {
            ViewPastAppointmentsWindow viewPastAppointmentsWindow = new ViewPastAppointmentsWindow();
            viewPastAppointmentsWindow.Show();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
