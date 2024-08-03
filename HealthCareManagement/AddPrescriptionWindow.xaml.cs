using System.Collections.Generic;
using System.Windows;

namespace HealthCareManagement
{
    public partial class AddPrescriptionWindow : Window
    {
        private string _patientName;
        private string _contactNumber;

        public AddPrescriptionWindow(string patientName, string contactNumber)
        {
            InitializeComponent();
            _patientName = patientName;
            _contactNumber = contactNumber;
            LoadPatientData();
        }

        private void LoadPatientData()
        {
            txtPatientName.Text = _patientName;
            txtContactNumber.Text = _contactNumber;

            // Load past prescriptions from data source
            var prescriptions = new List<string>
            {
                "Prescription 1",
                "Prescription 2"
            };

            lstPrescriptions.ItemsSource = prescriptions;
        }

        private void SavePrescription_Click(object sender, RoutedEventArgs e)
        {
            // Logic to save prescription
            string prescriptionDetails = txtPrescriptionDetails.Text;
            MessageBox.Show($"Prescription for {_patientName} saved successfully!");
            this.Close();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
