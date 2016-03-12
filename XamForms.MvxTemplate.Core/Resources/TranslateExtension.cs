using System;
using System.Globalization;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamForms.MvxTemplate.Core.Resources
{
    [ContentProperty("Text")]
    public class TranslateExtension : IMarkupExtension
    {
        public string Text { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (Text == null)
            {
                return null;
            }

            var translation = App.ResM.GetString(Text, AppResources.Culture);

#if DEBUG
            if (translation == null)
            {
                throw new ArgumentException(string.Format("Key {0} was not found for culture {1}.", Text, CultureInfo.CurrentCulture));
            }
#endif
            return translation;
        }
    }
}
