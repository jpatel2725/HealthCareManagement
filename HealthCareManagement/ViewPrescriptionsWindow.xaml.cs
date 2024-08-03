using System.Windows;

namespace HealthCareManagement
{
    public partial class ViewPrescriptionsWindow : Window
    {
        public ViewPrescriptionsWindow()
        {
            InitializeComponent();
            LoadPrescriptions();
        }

        private void LoadPrescriptions()
        {
            // Load prescriptions from data source
            lbPrescriptions.Items.Add("Prescription 1: Medicine A, Medicine B");
            lbPrescriptions.Items.Add("Prescription 2: Medicine C, Medicine D");
            // Add more prescriptions
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
