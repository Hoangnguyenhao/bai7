using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai7.Properties.Models
{
    public class Car : Vehicle
    {
        public override void DisplayInfo()
        {
            Console.WriteLine($"ID: {ID}, Tên: {Name}, Hãng: {Manufacturer}, Giá: {Price} VND, Số lượng: {Quantity}");
        }
    }
}