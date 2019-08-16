using CarMax.Models;
using CarMax.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CarMax.ViewModels
{
   public class LandingPageViewModel : INotifyPropertyChanged
    {
        public IList<MasterPageItem> MenuList { get; set; }

        public LandingPageViewModel()
        {
            GetMenuList();
        }
        public void GetMenuList()
        {
            MenuList = new List<MasterPageItem>();
            MenuList.Add(new MasterPageItem
            {
                ImagePath = "bg.jpg",
                Text = "Home",
                TargetPage = typeof(HomePage)


            });
            MenuList.Add(new MasterPageItem
            {
                ImagePath = "image1.jpg",
                Text = "Order History",
                TargetPage = typeof(HistoryPage)

            });
            MenuList.Add(new MasterPageItem
            {
                ImagePath = "image1.jpg",
                Text = "Feedback",
                TargetPage = typeof(FeedbackPage)

            });
            MenuList.Add(new MasterPageItem
            {
                ImagePath = "image1.jpg",
                Text = "Privacy Policy",
                TargetPage = typeof(PrivacyPage)

            });

        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
