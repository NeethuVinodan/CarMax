using System;
using System.Collections.Generic;
using System.Text;

namespace CarMax.Models
{
   public class CarDetail
    {
        public string Name { get; set; }
        public string Price { get; set; }
        public string State_registered { get; set; }
        public string Color { get; set; }
        public string Transmission { get; set; }
    }
    public class CarList
    {
        public List<CarDetail> Cardetail { get; set; }
    }
}
