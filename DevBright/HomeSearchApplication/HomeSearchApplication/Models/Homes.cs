using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeSearchApplication.Models
{
    public class Homes
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Zip { get; set; }
        public int Bedrooms { get; set; }
        public string Img { get; set; }
    }
}