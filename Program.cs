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
                Console.WriteLine("\n1. Thêm xe mới");
                Console.WriteLine("2. Hiển thị danh sách xe");
                Console.WriteLine("3. Tìm kiếm xe theo tên");
                Console.WriteLine("4. Xóa xe theo ID");
                Console.WriteLine("5. Sắp xếp xe theo giá tăng dần");
                Console.WriteLine("6. Chỉnh sửa thông tin xe");
                Console.WriteLine("7. Thoát");
                Console.Write("Chọn chức năng: ");

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
                        Console.WriteLine("Lựa chọn không hợp lệ! Hãy chọn lại.");
                        break;
                }
            }
        }
    }
}
