using System;
using System.Globalization;
using Xamarin.Forms;

namespace Shopping.Libraries.Converters
{
    public class EstablishmentTypeConversor : IValueConverter
    {
        public EstablishmentTypeConversor()
        {
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Enums.EstablishmentType type = (Enums.EstablishmentType)value;

            return (type == Enums.EstablishmentType.Store) ? "Loja" : "Restaurante";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

