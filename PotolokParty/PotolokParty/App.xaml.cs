using PotolokParty.Pages;
using PotolokParty.Service;
using Xamarin.Forms;

namespace PotolokParty
{
    public partial class App : Application
    {
        internal static RepositoryAlpha repository;
        public App()
        {
            repository = new RepositoryAlpha();

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
