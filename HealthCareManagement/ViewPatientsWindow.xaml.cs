using System.Collections.Generic;
using System.Windows;

namespace HealthCareManagement
{
    public partial class ViewPatientsWindow : Window
    {
        private Dictionary<string, string> _patients;

        public ViewPatientsWindow()
        {
            InitializeComponent();
            LoadPatients();
        }

        private void LoadPatients()
        {
            _patients = new Dictionary<string, string>
            {
                { "John Doe", "123-456-7890" },
                { "Jane Smith", "987-654-3210" }
            };

            foreach (var patient in _patients.Keys)
            {
                lbPatients.Items.Add(patient);
            }
        }

        private void ViewDetails_Click(object sender, RoutedEventArgs e)
        {
            if (lbPatients.SelectedItem != null)
            {
                string selectedPatient = lbPatients.SelectedItem.ToString();
                string contactNumber = _patients[selectedPatient];
                AddPrescriptionWindow addPrescriptionWindow = new AddPrescriptionWindow(selectedPatient, contactNumber);
                addPrescriptionWindow.Show();
            }
            else
            {
                MessageBox.Show("Please select a patient to view details.");
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
