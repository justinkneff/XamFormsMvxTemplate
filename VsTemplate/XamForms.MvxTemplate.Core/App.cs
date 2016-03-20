using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.IoC;
using $safeprojectname$.ViewModels;
using Xamarin.Forms;
using $safeprojectname$.Services;
using $safeprojectname$.Resources;

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
            
			if (Device.OS == TargetPlatform.Android || Device.OS == TargetPlatform.iOS)
			{
				AppResources.Culture = DependencyService.Get<ILocalizeService>().GetCurrentCultureInfo();
			}

            RegisterAppStart<MainViewModel>();
        }
    }
}
