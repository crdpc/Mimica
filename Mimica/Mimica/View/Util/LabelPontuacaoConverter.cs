using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;
namespace Mimica.View.Util
{
    public class LabelPontuacaoConverter : IValueConverter

    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //byte Pontuacao = byte.Parse(value as byte);
            if((byte)value == 0)
            {
                return "Palavra";
            }
            else
            {
                return " Palavra - Pontuaçao: " + value;
            }
           
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
