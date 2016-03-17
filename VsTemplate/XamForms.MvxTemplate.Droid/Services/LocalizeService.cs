using Xamarin.Forms;
using $safeprojectname$.Services;

[assembly: Dependency(typeof(LocalizeService))]
namespace $safeprojectname$.Services
{
    public class LocalizeService : Core.Services.ILocalizeService
    {
        public System.Globalization.CultureInfo GetCurrentCultureInfo()
        {
            var androidLocale = Java.Util.Locale.Default;
            var netLanguage = androidLocale.ToString().Replace("_", "-"); // turns pt_BR into pt-BR
            return new System.Globalization.CultureInfo(netLanguage);
        }
    }
}