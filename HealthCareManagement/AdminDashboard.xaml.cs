using System.Windows;

namespace HealthCareManagement
{
    public partial class AdminDashboard : Window
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void ManageUsers_Click(object sender, RoutedEventArgs e)
        {
            ManageUsersWindow manageUsersWindow = new ManageUsersWindow();
            manageUsersWindow.Show();
        }

        private void AddDoctors_Click(object sender, RoutedEventArgs e)
        {
            AddDoctorsWindow addDoctorsWindow = new AddDoctorsWindow();
            addDoctorsWindow.Show();
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            MainWindow loginWindow = new MainWindow();
            loginWindow.Show();
            this.Close();
        }
    }
}
