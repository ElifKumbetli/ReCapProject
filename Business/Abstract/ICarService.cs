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

    }
}
