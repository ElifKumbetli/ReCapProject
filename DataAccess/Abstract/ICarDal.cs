using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
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


    public interface ICarDal : IEntityRepository<Car>

    {
        List<CarDetailDto> GetCarDetails();
    }
}
