using System;
using System.Collections.Generic;
using System.Text;

namespace CarMax.Models
{
   public class MasterPageItem
    {
        public string Text { get; set; }
        //public string Detail { get; set; }
        public string ImagePath { get; set; }
        public Type TargetPage { get; set; }
    }
}
