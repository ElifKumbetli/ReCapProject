using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        //global
        //içinde arabaları barındıran bir liste
        List<Car> _cars;
        public InMemoryCarDal()
        {
            //Id, BrandId, ColorId, ModelYear, DailyPrice,
            //Description alanlarını ekleyiniz.
            //(Brand = Marka)

            //Çalıştırdığımızda  bellekte bir ürün oluştur.
            _cars = new List<Car> {
        new Car {CarId=1,BrandId=1,ColorId = 1,ModelYear= 2019,
            DailyPrice= 1000, Description ="Toyota" },

        new Car {CarId=2,BrandId=1,ColorId = 2,ModelYear= 2020,
            DailyPrice= 1500, Description ="Ford" },

        new Car {CarId=3,BrandId=2,ColorId = 3,ModelYear= 2021,
            DailyPrice= 2000, Description ="Honda" },

        new Car {CarId=4,BrandId=2,ColorId = 4,ModelYear= 2022,
            DailyPrice= 2500, Description ="Volkswagen" },

        new Car {CarId=5,BrandId=2,ColorId = 5,ModelYear= 2023,
            DailyPrice= 3000, Description ="BMW" }
};


        }

        //Heap te 5 tane referans numarası var.

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        //SingleOrDefault tek tek dolaşmaya yarıyor.
        //SingleOrDefault(c=>); Bu kod yapacağımız bir foreach e tekabül ediyor.

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);

            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int carId)
        {
          return _cars.Where(c => c. CarId == carId).ToList();
        }
        //Where-->Yeni liste haline getirip döndz

        public void Update(Car car)
        {
            //Gönderdiğim araba Id sine sahip listedeki arabayı bul demek.
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;

        }
    }
}
