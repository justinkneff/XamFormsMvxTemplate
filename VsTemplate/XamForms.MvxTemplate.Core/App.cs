using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.IoC;
using System;
using System.Globalization;
using System.Resources;
using Xamarin.Forms;
using $safeprojectname$.Resources;
using $safeprojectname$.Services;
using $safeprojectname$.ViewModels;

namespace $safeprojectname$
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            if (Device.OS != TargetPlatform.WinPhone && Device.OS != TargetPlatform.Windows)
            {
                AppResources.Culture = DependencyService.Get<ILocalizeService>().GetCurrentCultureInfo();
            }

            RegisterAppStart<MainViewModel>();
        }
    }
}
