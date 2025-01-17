﻿using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace Styles.Converter
{
    public sealed class ColorToSolidBrushConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (parameter == null)
                return new SolidColorBrush(Color.FromRgb(255, 255, 255));

            return new SolidColorBrush((Color)parameter);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
