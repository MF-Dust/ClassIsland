﻿using System;
using System.Globalization;
using System.Windows.Data;
using ClassIsland.Core.Enums;

namespace ClassIsland.Converters;

public class NotificationModeToIntConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        return (int)(NotificationModes)value;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        return (NotificationModes)(int)value;
    }
}