using System.Windows;

namespace HealthCareManagement
{
    public partial class SignupWindow : Window
    {
        public SignupWindow()
        {
            InitializeComponent();
        }

        private void Signup_Click(object sender, RoutedEventArgs e)
        {
            // Add logic to save user details
            MessageBox.Show("User signed up successfully!");
            MainWindow loginWindow = new MainWindow();
            loginWindow.Show();
            this.Close();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            MainWindow loginWindow = new MainWindow();
            loginWindow.Show();
            this.Close();
        }
    }
}
