using AppName.Core.ViewModel;
using Xamarin.Forms;

namespace TestApp
{
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = Resolver.Locator.Resolve<MainViewModel>();
        }
    }
}
