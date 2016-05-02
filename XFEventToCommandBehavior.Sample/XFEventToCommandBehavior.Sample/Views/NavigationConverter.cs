using System;
using System.Globalization;
using Xamarin.Forms;

namespace XFEventToCommandBehavior.Sample.Views
{
	public class NavigationConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			var url = "";

			var navigatingEventArgs = value as WebNavigatingEventArgs;
			if (navigatingEventArgs != null)
			{
				url = navigatingEventArgs.Url;
			}
			else
			{
				var navigatedEventArgs = value as WebNavigatedEventArgs;
				if (navigatedEventArgs != null)
				{
					url = navigatedEventArgs.Url;
				}
			}

			return url;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}

