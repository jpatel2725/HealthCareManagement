using System.Windows;

namespace HealthCareManagement
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Password;

            // Add your authentication logic here
            if (username == "doctor" && password == "password")
            {
                DoctorDashboard doctorDashboard = new DoctorDashboard();
                doctorDashboard.Show();
                this.Close();
            }
            else if (username == "patient" && password == "password")
            {
                PatientDashboard patientDashboard = new PatientDashboard();
                patientDashboard.Show();
                this.Close();
            }
            else if (username == "admin" && password == "password")
            {
                AdminDashboard adminDashboard = new AdminDashboard();
                adminDashboard.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid credentials. Please try again.");
            }
        }

        private void Signup_Click(object sender, RoutedEventArgs e)
        {
            SignupWindow signupWindow = new SignupWindow();
            signupWindow.Show();
            this.Close();
        }
    }
}
