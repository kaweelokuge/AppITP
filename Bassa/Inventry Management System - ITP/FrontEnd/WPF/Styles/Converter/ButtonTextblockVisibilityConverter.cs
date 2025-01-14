﻿using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Styles.Converter
{
    public sealed class ButtonTextblockVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return Visibility.Collapsed;

            if (String.IsNullOrEmpty((string)value))
                return Visibility.Collapsed;

            return Visibility.Visible;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
