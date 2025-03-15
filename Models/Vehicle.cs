using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai7.Properties.Models
{
    public abstract class Vehicle
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public abstract void DisplayInfo();
    }
}