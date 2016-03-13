using XamForms.MvxTemplate.Core.Services;
using Xamarin.Forms;
using XamForms.MvxTemplate.Droid.Services;

[assembly: Dependency(typeof(LocalizeService))]
namespace XamForms.MvxTemplate.Droid.Services
{
    public class LocalizeService : ILocalizeService
    {
        public System.Globalization.CultureInfo GetCurrentCultureInfo()
        {
            var androidLocale = Java.Util.Locale.Default;
            var netLanguage = androidLocale.ToString().Replace("_", "-"); // turns pt_BR into pt-BR
            return new System.Globalization.CultureInfo(netLanguage);
        }
    }
}