using CarMax.Models;
using CarMax.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CarMax.ViewModels
{
    public class HomePageViewModel : INotifyPropertyChanged
    {
        private readonly CardetailService _cardetailService;
        public IList<CarDetail> CarList { get; private set; }
        public HomePageViewModel()
        {
            _cardetailService = new CardetailService();
            //_banklistService = new BloodBankService();
            CarList = _cardetailService.GetJsonData();

           
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
