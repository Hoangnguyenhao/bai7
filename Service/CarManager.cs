using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai7.Properties.Models.Service
{
    public class CarManager
    {
        private List<Car> cars = new List<Car>();

        public void AddCar()
        {
            try
            {
                Console.Write("Nhập ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nhập tên xe: ");
                string name = Console.ReadLine();
                Console.Write("Nhập hãng xe: ");
                string manufacturer = Console.ReadLine();
                Console.Write("Nhập giá: ");
                double price = double.Parse(Console.ReadLine());
                Console.Write("Nhập số lượng: ");
                int quantity = int.Parse(Console.ReadLine());

                cars.Add(new Car { ID = id, Name = name, Manufacturer = manufacturer, Price = price, Quantity = quantity });
                Console.WriteLine("Thêm xe thành công!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi nhập dữ liệu: " + ex.Message);
            }
        }

        public void ShowCars()
        {
            if (cars.Count == 0)
            {
                Console.WriteLine("Danh sách xe trống!");
                return;
            }
            foreach (var car in cars)
            {
                car.DisplayInfo();
            }
        }

        public void SearchCarByName()
        {
            Console.Write("Nhập tên xe cần tìm: ");
            string name = Console.ReadLine();
            var foundCars = cars.Where(c => c.Name.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();
            if (foundCars.Count == 0)
            {
                Console.WriteLine("Không tìm thấy xe nào!");
            }
            else
            {
                foreach (var car in foundCars)
                {
                    car.DisplayInfo();
                }
            }
        }

        public void RemoveCarByID()
        {
            Console.Write("Nhập ID xe cần xóa: ");
            int id = int.Parse(Console.ReadLine());
            var car = cars.FirstOrDefault(c => c.ID == id);
            if (car != null)
            {
                cars.Remove(car);
                Console.WriteLine("Xóa xe thành công!");
            }
            else
            {
                Console.WriteLine("Không tìm thấy xe có ID này!");
            }
        }

        public void SortCarsByPrice()
        {
            cars = cars.OrderBy(c => c.Price).ToList();
            Console.WriteLine("Đã sắp xếp danh sách xe theo giá tăng dần!");
        }

        public void EditCarByID()
        {
            Console.Write("Nhập ID xe cần chỉnh sửa: ");
            int id = int.Parse(Console.ReadLine());
            var car = cars.FirstOrDefault(c => c.ID == id);
            if (car != null)
            {
                Console.Write("Nhập tên mới: ");
                car.Name = Console.ReadLine();
                Console.Write("Nhập hãng mới: ");
                car.Manufacturer = Console.ReadLine();
                Console.Write("Nhập giá mới: ");
                car.Price = double.Parse(Console.ReadLine());
                Console.Write("Nhập số lượng mới: ");
                car.Quantity = int.Parse(Console.ReadLine());
                Console.WriteLine("Cập nhật xe thành công!");
            }
            else
            {
                Console.WriteLine("Không tìm thấy xe có ID này!");
            }
        }
    }
}