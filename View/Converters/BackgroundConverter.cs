using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace View.Converters
{
	/// <summary>
	/// BackgroundConverter.
	/// </summary>
	public class BackgroundConverter : IValueConverter
	{
		/// <inheritdoc />
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			var hasErrors = (bool) value;

			if (hasErrors)
			{
				return (SolidColorBrush)(new BrushConverter().ConvertFrom("#FEE"));
			}

			return Brushes.Transparent;
		}

		/// <inheritdoc />
		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
