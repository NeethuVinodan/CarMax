using CarMax.Models;
using CarMax.ViewModels;
using CarMax.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CarMax
{
    public partial class MainPage : MasterDetailPage
    {
       
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new LandingPageViewModel();
            try
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(HomePage)));
            }
            catch (Exception ex)
            {

            }
            IsPresented = false;
        }
        private void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedMenuItem = (MasterPageItem)e.SelectedItem;
            Type selectedPage = selectedMenuItem.TargetPage;
            Detail = new NavigationPage((Page)Activator.CreateInstance(selectedPage));
            IsPresented = false;
        }
    }
}
