using PotolokParty.Models;
using PotolokParty.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace PotolokParty.ViewModels
{
    internal class HomeViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private readonly INavigation navigation;
        private List<Order> orders;
        private List<string> news;

        // TO DO: Add class News
        public List<string> News { get => news; set => SetField(ref news, value); }
        public List<Order> Orders { get => orders; set => SetField(ref orders, value); }
        public ICommand SelectApplicationCommand { get; set; }

        public HomeViewModel()
        {
            Debug.Print("HomeViewModelStart");
            SelectApplicationCommand = new Command(SelectApplication);
        }

        public HomeViewModel(INavigation navigation) : base()
        {
            this.navigation = navigation;
        }

        private async void SelectApplication()
        {
            Debug.Print("SelectApplicationCommand");
            await navigation.PushAsync(new OrderPage());
        }

        protected void OnPropertyChanged(string propertyName)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}
