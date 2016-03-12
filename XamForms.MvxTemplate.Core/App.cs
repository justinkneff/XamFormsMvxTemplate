using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.IoC;
using System;
using System.Globalization;
using System.Resources;
using XamForms.MvxTemplate.Core.Resources;
using XamForms.MvxTemplate.Core.ViewModels;

namespace XamForms.MvxTemplate.Core
{
    public class App : MvxApplication
    {
        internal static CultureInfo UserCultureInfo { get; private set; }

        internal static ResourceManager ResM
        {
            get
            {
                if (UserCultureInfo != null)
                {
                    AppResources.Culture = UserCultureInfo;
                }

                return AppResources.ResourceManager;
            }
        }

        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<MainViewModel>();
        }

        public static void ChangeUserCulture(CultureInfo newCultureInfo)
        {
            if (newCultureInfo == null)
            {
                throw new ArgumentNullException(nameof(newCultureInfo), "You need to specify a new culture in order to replace the previous one.");
            }
            UserCultureInfo = newCultureInfo;
        }
    }
}
