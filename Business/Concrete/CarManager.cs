using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
//Manager -->İş sınıfının somut sınıfı 
{


    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

       

        public IResult Add(Car car)
        {
            //if (car.CarName.Length >= 2 && car.DailyPrice > 0)
            //{
            //    _carDal.Add(car);
            //    Console.WriteLine("Car eklendi.");
            //}
            //else
            //    Console.WriteLine("Car eklenemedi!");

            //magic strings
            if (car.CarName.Length < 2 && car.DailyPrice > 0)
            {
                return new ErrorResult(Messages.CarNameInvalid);
            }
            _carDal.Add(car);
            return new SuccessResult(Messages.CarAdded);

        }


        public IDataResult<List<Car>> GetAll()
        {   //İŞ KODLARI
            //Yetkisi var mı?
            if (DateTime.Now.Hour == 14)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);//bakım zamanı
            }

            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.CarsListed);
        }

        public IDataResult<Car> GetById(int carId)
        {
            return new SuccessDataResult<Car>(_carDal.Get(c => c.CarId == carId));

        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails());
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.BrandId == id));
        }


        public IDataResult<List<Car>> GetCarsByColorId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.ColorId == id));
        }



        IResult ICarService.Delete(Car car)
        {
            return new SuccessResult(Messages.RentalDeleted);
        }

        IResult ICarService.Update(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
