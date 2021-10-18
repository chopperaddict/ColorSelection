using System;
using System . Collections . Generic;
using System . Globalization;
using System . Linq;
using System . Text;
using System . Threading . Tasks;
using System . Windows . Data;

namespace ColorSelection . Converts
{
	public partial class TextVerticalPositionConverter : IValueConverter
	{
		public object Convert ( object value, Type targetType, object parameter, CultureInfo culture )
		{
			double values = 0;
			Type t = value . GetType ( );
			if ( value != null )
			{

				values = System . Convert . ToDouble ( value );
				Console . WriteLine ( $"ActualHeight in Converter ={values}" );
				if ( values < 25 )
					values = 10;                  // OK
				else if ( values < 50 )
					values = 30;                      //OK
				else if ( values < 100 )
					values = 32;                        //ok
				else if ( values < 150 )
					values = 45;                                      //OK
				else if ( values < 200 )
					values = 52;                                //OK
				else if ( values < 250 )
					values = 50;                                   //OK
				else if ( values < 300 )
					values = 60;
				else
					values = 70;
			}
			Console . WriteLine ( $"Returning Height from Converter ={values}" );
			return values;
		}
		public object ConvertBack ( object value, Type targetTypes, object parameter, CultureInfo culture )
		{
			return ( object [ ] ) value;
		}
	}
}