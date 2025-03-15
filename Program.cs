using bai7.Properties.Models.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai7
{
    class Program
    {
        static void Main()
        {
            CarManager manager = new CarManager();
            while (true)
            {
                Console.WriteLine("\n1. Them xe moi");
                Console.WriteLine("2. Hien thi danh sach xe");
                Console.WriteLine("3. Tim kiem xe theo ten");
                Console.WriteLine("4. Xoa xe theo ID");
                Console.WriteLine("5. Sap xep xe theo gia tang dan");
                Console.WriteLine("6. Chinh sua thong tin xe");
                Console.WriteLine("7. Thoat");
                Console.Write("Chon chuc nang: ");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        manager.AddCar();
                        break;
                    case "2":
                        manager.ShowCars();
                        break;
                    case "3":
                        manager.SearchCarByName();
                        break;
                    case "4":
                        manager.RemoveCarByID();
                        break;
                    case "5":
                        manager.SortCarsByPrice();
                        break;
                    case "6":
                        manager.EditCarByID();
                        break;
                    case "7":
                        return;
                    default:
                        Console.WriteLine("Lua chon khong hop le! Hay chon lai.");
                        break;
                }
            }
        }
    }
}

