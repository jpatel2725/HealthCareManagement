﻿using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace HealthCareManagement
{
    public class EmergencyToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool isEmergency)
            {
                return isEmergency ? Brushes.Red : Brushes.Blue;
            }
            return Brushes.Black;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
