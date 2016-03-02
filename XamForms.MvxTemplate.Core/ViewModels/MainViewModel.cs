using MvvmCross.Core.ViewModels;

namespace XamForms.MvxTemplate.Core.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        private string _title;

        public MainViewModel()
        {
            Title = "Welcome!";
        }

        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
                RaisePropertyChanged(() => Title);
            }
        }
    }
}
