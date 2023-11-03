using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{

    /*ICarDal yani bizim Car ile yapacağımız v.tabanında yapacağımız
    operasyonları içeren interface.
    Operasyon--> Ekle, Sil, Güncelle,Listele,Filtrele vb.*/


    public interface ICarDal

    {

        List <Car> GetAll();

        List<Car> GetById();
        

        void Add(Car car);

        void Update(Car car);

        void Delete(Car car);
    }
}
