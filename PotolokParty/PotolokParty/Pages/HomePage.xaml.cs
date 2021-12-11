using PotolokParty.Models;
using PotolokParty.ViewModels;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PotolokParty.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        HomeViewModel viewModel;
        public HomePage()
        {
            viewModel = new HomeViewModel(this.Navigation);
            InitializeComponent();
            BindingContext = viewModel;
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            //viewModel.News = new List<string> { "Hello", "News", "Carusel" };
            //viewModel.Orders = new List<Order> { 
            //    new Order { Id = 1, Amount = 200, Status = Status.active }, 
            //    new Order {
            //        Id = 2,
            //        Client = new Client
            //        {
            //            Name = "Petiy",
            //            Discont = 8.0,
            //            Pnone = "+79370702121"
            //        },
            //        Amount = 55500,
            //        Date = "21.12.21",
            //        Status = Status.processing,
            //        Address = new Address
            //        {
            //            City = "gorod",
            //            Street = "ulica2",
            //            House = 7,
            //            Apartment = 14
            //        },
            //        Ceilings = new List<Ceiling>
            //        {
            //            new Ceiling { Amount = 16000, Square = 20, Perimeter = 55 },
            //            new Ceiling { Amount = 15000, Square = 14, Perimeter = 26 },
            //            new Ceiling { Amount = 22000, Square = 34, Perimeter = 86 }
            //        } } };
            viewModel.Orders = await App.Repository.GetTasksAsync();
            viewModel.News = await App.Repository.GetNewsTasksAsync();
        }

        async void OnAddItemClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OrderPage(true));
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            await Navigation.PushAsync(new OrderPage
            {
                BindingContext = e.SelectedItem as Order
            });
        }
    }
}