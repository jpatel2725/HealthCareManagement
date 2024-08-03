using System;
using System.Windows;

namespace HealthCareManagement
{
    public partial class ProfileWindow : Window
    {
        public ProfileWindow()
        {
            InitializeComponent();
            LoadProfile();
        }

        private void LoadProfile()
        {
            // Load profile from data source
            txtName.Text = "John Doe";
            dpDOB.SelectedDate = new DateTime(1990, 1, 1);
            txtGender.Text = "Male";
            txtAddress.Text = "123 Main St";
            txtContactNumber.Text = "123-456-7890";
            txtWeight.Text = "70 kg";
            txtPastMedicalHistory.Text = "None";
            txtEmergencyNumber.Text = "098-765-4321";
            txtBloodGroup.Text = "O+";
            txtMaritalStatus.Text = "Single";
            txtInsuranceNumber.Text = "INS123456";
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            // Logic to save profile
            MessageBox.Show("Profile saved successfully!");
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
