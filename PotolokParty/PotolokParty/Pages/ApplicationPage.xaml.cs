using PotolokParty.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PotolokParty.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrderPage : ContentPage
    {
        public OrderPage(bool isNew = false)
		{
			InitializeComponent();
			BindingContext = new OrderViewModel(this.Navigation, isNew);
		}
	}
}