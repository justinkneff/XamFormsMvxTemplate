using System;
using System.Globalization;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamForms.MvxTemplate.Core.Services;

namespace XamForms.MvxTemplate.Core.Resources
{
    [ContentProperty("Text")]
    public class TranslateExtension : IMarkupExtension
    {
        private readonly CultureInfo _cultureInfo;

        public TranslateExtension()
        {
            if (Device.OS == TargetPlatform.Android || Device.OS == TargetPlatform.iOS)
            {
                _cultureInfo = DependencyService.Get<ILocalizeService>().GetCurrentCultureInfo();
            }
        }

        public string Text { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (Text == null)
            {
                return null;
            }
            
			var translation = AppResources.ResourceManager.GetString(Text, _cultureInfo);

#if DEBUG
            if (translation == null)
            {
                throw new ArgumentException(string.Format("Key {0} was not found for culture {1}.", Text, _cultureInfo));
            }
#endif
            return translation;
        }
    }
}
