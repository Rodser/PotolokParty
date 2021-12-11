using PotolokParty.Models;
using System.Collections.Generic;
using Xamarin.Forms;

namespace PotolokParty.ViewModels
{
    internal class OrderViewModel
    {
        public Order Application { get; set; }
        public Address Address { get; set; }
        public List<Ceiling> Ceilings { get; set; }
		private bool isNewOrder;
        private readonly INavigation navigation;

        public OrderViewModel()
        {
        }

        public OrderViewModel(INavigation navigation, bool isNew = false)
        {
			isNewOrder = isNew;
			this.navigation = navigation;
		}

		async void OnSaveButtonClicked(object sender)
		{
			var order = new Order
			{
				Address = Address,
				Ceilings = Ceilings,
			};
			await App.Repository.SaveTaskAsync(order, isNewOrder);
			await navigation.PopAsync();
		}

		async void OnDeleteButtonClicked(object sender)
		{
			var order = Application;
			await App.Repository.DeleteTaskAsync(order);
			await navigation.PopAsync();
		}

		async void OnCancelButtonClicked(object sender)
		{
			await navigation.PopAsync();
		}
	}
}
