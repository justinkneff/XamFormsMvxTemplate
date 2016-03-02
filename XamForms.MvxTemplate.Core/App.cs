using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.IoC;
using XamForms.MvxTemplate.Core.ViewModels;

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

            RegisterAppStart<MainViewModel>();
        }
    }
}
