using System.Windows;

namespace HealthCareManagement
{
    public partial class ManageUsersWindow : Window
    {
        public ManageUsersWindow()
        {
            InitializeComponent();
        }

        private void AddUser_Click(object sender, RoutedEventArgs e)
        {
            // Logic to add a user
            MessageBox.Show("User added successfully!");
        }

        private void EditUser_Click(object sender, RoutedEventArgs e)
        {
            // Logic to edit a user
            MessageBox.Show("User edited successfully!");
        }

        private void DeleteUser_Click(object sender, RoutedEventArgs e)
        {
            // Logic to delete a user
            MessageBox.Show("User deleted successfully!");
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
