using CarMax.Models;
using CarMax.ViewModels;
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
	public partial class HomePage : ContentPage
	{
		public HomePage ()
		{
			InitializeComponent ();
            BindingContext = new HomePageViewModel();
            //localimage.Source = ImageSource.FromFile("image1.jpg");
        }
        public async void OnListViewItemSelected(object sender, ItemTappedEventArgs e)
        {
            var mydetails = e.Item as CarDetail;
            await Navigation.PushAsync(new CarDetailsPage(mydetails.Name, mydetails.Price,mydetails.State_registered, mydetails.Transmission, mydetails.Color));
            //    viewModel.meth(e.SelectedItem as BloodBankDetail);
            // BloodBankViewModel selectedItem = e.SelectedItem as BloodBankDetail;           
        }
    }
}