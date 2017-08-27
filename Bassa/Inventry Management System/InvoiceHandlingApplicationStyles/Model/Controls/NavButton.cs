﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace InvoiceHandlingApplicationStyles.Model.Controls
{
    public class NavButton : Button
    {
        static NavButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(NavButton), new FrameworkPropertyMetadata(typeof(NavButton)));
        }

        public static readonly DependencyProperty ImageProperty =
            DependencyProperty.Register("Image", typeof(ImageSource), typeof(NavButton), new PropertyMetadata(null));

        public ImageSource Image
        {
            get { return (ImageSource)GetValue(ImageProperty); }
            set { SetValue(ImageProperty, value); }
        }

        public static readonly DependencyProperty IsActiveProperty =
            DependencyProperty.Register("IsActive", typeof(bool), typeof(NavButton), new PropertyMetadata(null));

        public bool IsActive
        {
            get { return (bool)GetValue(IsActiveProperty); }
            set { SetValue(IsActiveProperty, (bool)value); }
        }
    }
}
