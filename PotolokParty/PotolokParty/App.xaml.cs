using PotolokParty.Data;
using PotolokParty.Pages;
using Xamarin.Forms;

namespace PotolokParty
{
    public partial class App : Application
    {
        public static Repository Repository { get; private set; }

        public App()
        {
            Repository = new Repository(new RestService());

            InitializeComponent();
            MainPage = new NavigationPage(new HomePage());            
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
