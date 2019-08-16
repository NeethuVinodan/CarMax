using System;
using System.Collections.Generic;
using System.Text;

namespace CarMax.Models
{
    public class Token
    {
        public int Id { get; set; }
        public string access_token { get; set; }
        public string error_msg { get; set; }
        public DateTime expire_date { get; set; }
        public Token() { }
    }
}
