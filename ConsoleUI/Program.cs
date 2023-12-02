using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            /*List<Car> Arabalar = new List<Car>();
            Arabalar = carManager.GetAll();
            foreach (Car car in Arabalar) {
            
                carManager.Delete(car);
            }
            Console.WriteLine("Arabalar silindi.");   */

            List<Car> Arabalar = new List<Car>();
          
            Car car1 = new Car();
            car1.CarName = "Toyota";
            car1.BrandId = 1;
            car1.ColorId = 1;
            car1.ModelYear = 2019;
            car1.DailyPrice = 1000;
            car1.Description = "2019 model Toyota";

            Arabalar.Add(car1);

            Car car2 = new Car();
            car2.CarName = "Ford";
            car2.BrandId = 1;
            car2.ColorId = 2;
            car2.ModelYear = 2020;
            car2.DailyPrice = 1500;
            car2.Description = "2020 model Ford";

            Arabalar.Add(car2);


            Car car3 = new Car();
            car3.CarName = "a";
            car3.BrandId = 1;
            car3.ColorId = 2;
            car3.ModelYear = 2020;
            car3.DailyPrice = 1500;
            car3.Description = "deneme";

            Arabalar.Add(car3);



            foreach (Car car in Arabalar) {

           carManager.Add(car);
           }
           Console.WriteLine("Arabalar eklendi.");  

        }
    }
}
