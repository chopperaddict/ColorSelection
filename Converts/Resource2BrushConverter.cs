using System;
using System . Globalization;
using System . Windows;
using System . Windows . Data;
using System . Windows . Media;

using WPFLibrary2021;

namespace ColorSelection . Converts
{
	public class ResourceToBrushConverter : IValueConverter
	{
		public object Convert ( object value, Type targetType, object parameter, CultureInfo culture )
		{
			if ( value == null )
				return value;
			if ( value == DependencyProperty . UnsetValue )
				return DependencyProperty . UnsetValue;
			// We receive a Resource name and Return a Brush
			if ( parameter != null)
				return ( Brush ) Library1 . GetDictionaryBrush ( parameter . ToString ( ) );
			else
				return ( Brush ) Library1 . GetDictionaryBrush ( value. ToString ( ) );
		}
		public object ConvertBack ( object value, Type targetType, object parameter, CultureInfo culture )
		{
			return null as object;
		}
	}

}