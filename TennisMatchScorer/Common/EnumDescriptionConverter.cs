using System;
using TennisMatchScorer.ViewModel;
using Windows.UI.Xaml.Data;

namespace TennisMatchScorer.Common
{
    public class EnumDescriptionConverter : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (!(value is Enum)) return null;
        
            return ((FinalSetFormats) value).GetAttribute<DescriptionAttribute>().Description;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}