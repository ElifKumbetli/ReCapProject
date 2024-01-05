using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    //interfaceler genelde Service olarak isimlendirilir.
    //Add ref. --> DataAcces, Entity
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll(); //Tüm araçları getirme

        IDataResult<Car> GetById(int carId);

        IDataResult<List<Car>> GetCarsByBrandId(int id);

        IDataResult<List<Car>> GetCarsByColorId(int id);

        IResult Add(Car car);

        IResult Update(Car car);

        IResult Delete(Car car);

        IDataResult<List<CarDetailDto>> GetCarDetails();

        //void olan IResult çünkü onda Data yok!
    }
}
