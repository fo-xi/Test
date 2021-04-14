using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace View.Converters
{
	public class BackgroundConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			var hasErrors = (bool) value;

			if (hasErrors)
			{
				return (SolidColorBrush)(new BrushConverter().ConvertFrom("#FEE"));
			}

			return (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFF"));
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
