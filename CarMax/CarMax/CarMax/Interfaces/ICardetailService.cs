using CarMax.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarMax.Interfaces
{
   public interface ICardetailService
    {
        List<CarDetail> GetJsonData();
    }
}
