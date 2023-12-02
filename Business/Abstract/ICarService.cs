using Entities.Concrete;
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
        List <Car> GetAll();

        List<Car> GetCarsByBrandId(int id);

        List<Car> GetCarsByColorId(int id);

        void Add(Car car);

        void Update(Car car);

        void Delete(Car car);
    }
}
