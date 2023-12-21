using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;


namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            Console.WriteLine("Tüm Brandler: ");

            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine("BrandId: " + brand.BrandId + ", BrandName: " + brand.BrandName);

            }




            /*List<Car> Arabalar = new List<Car>();
            Arabalar = carManager.GetAll();
            foreach (Car car in Arabalar) {
            
                carManager.Delete(car);
            }
            Console.WriteLine("Arabalar silindi.");   */

            //CarTest();
            //BrandManager brandManager = new BrandManager(new EfBrandDal());

            //List<Brand> Markalar = new List<Brand>();


            //Brand brand1 = new Brand();
            // brand1.BrandId = 1;
            //brand1.BrandName = "Marka1";
            //Markalar.Add(brand1);

            //Brand brand2 = new Brand();
            //brand2.BrandId = 2;
            //brand2.BrandName = "Marka2";
            //Markalar.Add(brand2);


            //Brand brand3 = new Brand();
            // brand3.BrandId = 3;
            //brand3.BrandName = "Marka3";
            //Markalar.Add(brand3);

            //foreach (Brand brand in Markalar)
            //{

            // brandManager.Add(brand);
            //}
            //Console.WriteLine("Markaalar eklendi.");
            //}


            //private static void CarTest()
            //{
            //    CarManager carManager = new CarManager(new EfCarDal());

            //    List<Car> Arabalar = new List<Car>();

            //    Car car1 = new Car();
            //    car1.CarName = "Toyota";
            //    car1.BrandId = 1;
            //    car1.ColorId = 1;
            //    car1.ModelYear = 2019;
            //    car1.DailyPrice = 1000;
            //    car1.Description = "2019 model Toyota";

            //    Arabalar.Add(car1);

            //    Car car2 = new Car();
            //    car2.CarName = "Ford";
            //    car2.BrandId = 1;
            //    car2.ColorId = 2;
            //    car2.ModelYear = 2020;
            //    car2.DailyPrice = 1500;
            //    car2.Description = "2020 model Ford";

            //    Arabalar.Add(car2);


            //    Car car3 = new Car();
            //    car3.CarName = "a";
            //    car3.BrandId = 1;
            //    car3.ColorId = 2;
            //    car3.ModelYear = 2020;
            //    car3.DailyPrice = 1500;
            //    car3.Description = "deneme";

            //    Arabalar.Add(car3);



            //    foreach (Car car in Arabalar)
            //    {

            //        carManager.Add(car);
            //    }
            //    Console.WriteLine("Arabalar eklendi.");
        }
        }
    }
