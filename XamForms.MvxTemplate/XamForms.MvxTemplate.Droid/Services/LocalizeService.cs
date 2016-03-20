using System;
using System.Diagnostics;
using System.Globalization;
using Xamarin.Forms;
using XamForms.MvxTemplate.Droid.Services;

[assembly: Dependency(typeof(LocalizeService))]
namespace XamForms.MvxTemplate.Droid.Services
{
    public class LocalizeService : Core.Services.ILocalizeService
    {
        public CultureInfo GetCurrentCultureInfo()
        {
            var androidLocale = Java.Util.Locale.Default;
            var netLanguage = androidLocale.ToString().Replace("_", "-"); // turns pt_BR into pt-BR
            try {
                return new CultureInfo(netLanguage);
            }
            catch (CultureNotFoundException e)
            {
                Debug.Write(e.Message);
            }

            return new CultureInfo("en");
        }
    }
}