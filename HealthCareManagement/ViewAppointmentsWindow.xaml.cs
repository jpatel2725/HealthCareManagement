using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace HealthCareManagement
{
    public partial class ViewAppointmentsWindow : Window
    {
        private List<Appointment> _appointments;

        public ViewAppointmentsWindow()
        {
            InitializeComponent();
            LoadAppointments();
            dpFilterDate.SelectedDate = DateTime.Today; // Set DatePicker to today's date
            FilterAppointments(); // Filter appointments for today's date
        }

        private void LoadAppointments()
        {
            // Load appointments from data source
            _appointments = new List<Appointment>
            {
                new Appointment { PatientName = "John Doe", ContactNumber = "123-456-7890", AppointmentDate = new DateTime(2024, 7, 31), AppointmentTime = "10:00 AM", IsEmergency = false },
                new Appointment { PatientName = "Jane Smith", ContactNumber = "987-654-3210", AppointmentDate = new DateTime(2024, 8, 1), AppointmentTime = "11:00 AM", IsEmergency = true }
            };

            lstAppointments.ItemsSource = _appointments;
        }

        private void DpFilterDate_SelectedDateChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            FilterAppointments();
        }

        private void ChkEmergency_Checked(object sender, RoutedEventArgs e)
        {
            FilterAppointments();
        }

        private void ChkEmergency_Unchecked(object sender, RoutedEventArgs e)
        {
            FilterAppointments();
        }

        private void FilterAppointments()
        {
            DateTime? selectedDate = dpFilterDate.SelectedDate;
            bool showEmergencyOnly = chkEmergency.IsChecked ?? false;

            var filteredAppointments = _appointments.Where(a =>
                (!selectedDate.HasValue || a.AppointmentDate.Date == selectedDate.Value.Date) &&
                (!showEmergencyOnly || a.IsEmergency)).ToList();

            lstAppointments.ItemsSource = filteredAppointments;
        }

        private void ViewDetail_Click(object sender, RoutedEventArgs e)
        {
            // Get the selected appointment from the button's Tag property
            var appointment = (sender as FrameworkElement)?.Tag as Appointment;
            if (appointment != null)
            {
                // Open AddPrescriptionWindow and pass the selected appointment's details
                var addPrescriptionWindow = new AddPrescriptionWindow(appointment.PatientName, appointment.ContactNumber);
                addPrescriptionWindow.ShowDialog();
            }
        }
    }

    public class Appointment
    {
        public string PatientName { get; set; }
        public string ContactNumber { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string AppointmentTime { get; set; }
        public bool IsEmergency { get; set; }
        public string Prescription { get; set; }
    }
}
