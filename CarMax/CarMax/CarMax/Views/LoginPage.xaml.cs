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
	public partial class LoginPage : ContentPage
	{
        LoginPageViewModel loginPageViewModel;

        public LoginPage ()
		{
            loginPageViewModel = new LoginPageViewModel();

            InitializeComponent ();
            BindingContext = loginPageViewModel;

        }


    }
}