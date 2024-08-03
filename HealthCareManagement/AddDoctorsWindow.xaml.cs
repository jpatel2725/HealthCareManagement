using System.Windows;

namespace HealthCareManagement
{
    public partial class AddDoctorsWindow : Window
    {
        public AddDoctorsWindow()
        {
            InitializeComponent();
        }

        private void AddDoctor_Click(object sender, RoutedEventArgs e)
        {
            // Logic to add a doctor
            MessageBox.Show("Doctor added successfully!");
            this.Close();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
