﻿using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Styles.Converter
{
    public sealed class LengthToGridlengthConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return new GridLength(50);

            return new GridLength((double)value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
