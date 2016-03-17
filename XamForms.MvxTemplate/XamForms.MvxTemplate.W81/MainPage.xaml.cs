using MvvmCross.Core.ViewModels;
using MvvmCross.Core.Views;
using MvvmCross.Forms.Presenter.Windows81;
using MvvmCross.Platform;
using Xamarin.Forms.Platform.WinRT;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace XamForms.MvxTemplate.W81
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : WindowsPage
    {
        public MainPage()
        {
            // WindowsPage initialization
            InitializeComponent();

            // Start MvvMCross
            var start = Mvx.Resolve<IMvxAppStart>();
            start.Start();

            // Locate the MvvMCross-Forms Presenter
            var presenter = Mvx.Resolve<IMvxViewPresenter>() as MvxFormsWindows81PagePresenter;


            // Xamarin.Forms.Platform.WinRT.dll Loads the Xamarin Form found at presenter.MvxFormsApp
            LoadApplication(presenter.MvxFormsApp);
        }
    }
}
