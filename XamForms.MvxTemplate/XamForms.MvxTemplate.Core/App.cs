using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.IoC;
using XamForms.MvxTemplate.Core.ViewModels;
using Xamarin.Forms;
using XamForms.MvxTemplate.Core.Services;
using XamForms.MvxTemplate.Core.Resources;

namespace XamForms.MvxTemplate.Core
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
