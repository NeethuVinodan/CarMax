using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarMax.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CarDetailsPage : ContentPage
    {
        public string nameview { get; set; }
        public string priceview { get; set; }
        public string stateregistered { get; set; }
        public string transmissionview { get; set; }
        public string colorview { get; set; }
        public CarDetailsPage (string Name, string Price, string State_registered, string Transmission, string Color)
		{
			InitializeComponent ();
            nameview = Name;
            priceview = Price;
            stateregistered = State_registered;
            transmissionview = Transmission;
            colorview = Color;
            BindingContext = this;
        }
        private async void btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
        private async void orderbtn_Clicked(object sender, EventArgs e)
        {
           
        }
    }
}