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
            //Data Transformation Object
            //CarTest();
            //BrandTest();
            //ColorTest();

        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());

            // Yeni bir renk ekleme
            Color newColor = new Color
            {
                ColorId = 5,
                ColorName = "Mavi"
            };
            colorManager.Add(newColor);
            Console.WriteLine("Renk eklendi.");

            //GetById
            int colorIdToGet = 2; // Örnek olarak 1 numaralı rengi getirmek istiyoruz.
            Color colorById = colorManager.GetById(colorIdToGet);

            if (colorById != null)
            {
                Console.WriteLine($"ID'si {colorIdToGet} olan renk: {colorById.ColorName}");
            }
            else
            {
                Console.WriteLine($"ID'si {colorIdToGet} olan renk bulunamadı.");
            }

            // Silme Testi
            int colorIdToDelete = 3;
            Color colorToDelete = colorManager.GetById(colorIdToDelete);

            if (colorToDelete != null)
            {
                // Marka varsa silme işlemini gerçekleştir
                colorManager.Delete(colorToDelete);
                Console.WriteLine($"ID'si {colorToDelete} olan renk silindi.");
            }
            else
            {
                Console.WriteLine($"ID'si {colorIdToDelete} olan marka bulunamadığı için silme işlemi yapılamadı.");
            }

            // Renkleri listeleme
            Console.WriteLine("Tüm Renkler: ");
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.ColorName);
            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }
            //Ekleme
            Brand newBrand = new Brand
            {
                BrandId = 13,
                BrandName = "Asdfgh"
            };
            brandManager.Add(newBrand);
            Console.WriteLine("Marka eklendi");


            // GetById (Id'ye Göre Getirme) Testi

            int targetBrandId = 9; // Örnek olarak 9 numaralı markayı getirmek istiyoruz.
            Brand targetBrand = brandManager.GetById(targetBrandId);

            if (targetBrand != null)
            {
                Console.WriteLine($"ID'si {targetBrandId} olan marka: {targetBrand.BrandName}");
            }
            else
            {
                Console.WriteLine($"ID'si {targetBrandId} olan marka bulunamadı.");
            }

            //SİLME

            int brandIdToDelete = 13; // Sileceğimiz markanın ID'si
            Brand brandToDelete = brandManager.GetById(brandIdToDelete);

            if (brandToDelete != null)
            {
                // Marka varsa silme işlemini gerçekleştir
                brandManager.Delete(brandToDelete);
                Console.WriteLine($"ID'si {brandIdToDelete} olan marka silindi.");
            }
            else
            {
                Console.WriteLine($"ID'si {brandIdToDelete} olan marka bulunamadığı için silme işlemi yapılamadı.");
            }
            //Listeleme
            List<Brand> allBrands = brandManager.GetAll();
            Console.WriteLine("Tüm Markalar: ");
            foreach (var brand in allBrands)
            {
                Console.WriteLine("Id: " + brand.BrandId + ", Marka Adı : " + brand.BrandName);
            }

        }

        private static void CarTest()
        {
           
                EfCarDal efCarDal = new EfCarDal();

                Console.WriteLine("Araç Detayları:");

                foreach (var carDetail in efCarDal.GetCarDetails())
                {
                Console.WriteLine("Car Name: " + carDetail.CarName + ", Brand: " + carDetail.BrandName + ", Color: " + carDetail.ColorName + ", Daily Price: " + carDetail.DailyPrice);
            }



            //CarManager carManager = new CarManager(new EfCarDal());

            ////Insert Ekleme testi
            //Car newCar = new Car
            //{
            //    CarName = "Renault",
            //    BrandId = 2,
            //    ColorId = 3,
            //    ModelYear = 2022,
            //    DailyPrice = 1500,
            //    Description = "2022 Model Renault"
            //};
            //carManager.Add(newCar);
            //Console.WriteLine("Araba Eklendi.");

            ////GetAll(Tümünü Getrime) Testi
            //List<Car> allCars = carManager.GetAll();
            //Console.WriteLine("Tüm Araçlar: ");
            //foreach (var car in allCars)
            //{
            //    Console.WriteLine("ID: " + car.CarId + ", Ad: " + car.CarName + ", Marka ID: " + car.BrandId + ", Renk ID: " + car.ColorId + ", Model Yılı: " + car.ModelYear + ", Günlük Fiyat: " + car.DailyPrice + ", Açıklama: " + car.Description);
            //}

            //// GetById (Id'ye Göre Getirme) Testi
            //int carIdToGet = newCar.CarId; // Eklenen aracın ID'sini al
            //Car carById = carManager.GetById(carIdToGet);

            //if (carById != null)
            //{
            //    Console.WriteLine("ID'si " + carIdToGet + " olan araç: " + carById.CarName);
            //}
            //else
            //{
            //    Console.WriteLine("ID'si " + carIdToGet + " olan araç bulunamadı.");
            //}

            //// Update (Güncelleme) Testi
            //if (carById != null)
            //{
            //    carById.CarName = "Updated Renault";
            //    carById.ModelYear = 2023;
            //    carById.DailyPrice = 1600;
            //    carById.Description = "Güncellenmiş Renault";

            //    carManager.Update(carById);
            //    Console.WriteLine("Araba Güncellendi.");
            //}
            //// Delete (Silme) Testi
            //if (carById != null)
            //{
            //    carManager.Delete(carById);
            //    Console.WriteLine("Araba Silindi.");
            //}
        }
    }
}
