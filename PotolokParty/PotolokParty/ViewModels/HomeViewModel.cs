using PotolokParty.Models;
using PotolokParty.Pages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace PotolokParty.ViewModels
{
    internal class HomeViewModel
    {
        private readonly INavigation navigation;
        // TO DO: Add class News
        public List<string> News { get; set; }
        public List<Models.Application> Applications { get; set; }
        public ICommand SelectApplicationCommand { get; private set; }

        public HomeViewModel()
        {

        }

        public HomeViewModel(INavigation navigation)
        {
            News = (List<string>)App.repository.News;
            Applications = (List<Models.Application>)App.repository.Applications;
            this.navigation = navigation;
            SelectApplicationCommand = new Command(SelectApplication);
        }

        private async void SelectApplication()
        {
            await navigation.PushAsync(new ApplicationPage());
        }
    }
}
