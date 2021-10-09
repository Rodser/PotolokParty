using PotolokParty.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PotolokParty.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            BindingContext = new HomeViewModel(Navigation);
        }
    }
}