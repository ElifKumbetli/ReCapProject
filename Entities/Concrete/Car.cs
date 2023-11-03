using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Car :IEntity
    {
        public int CarId { get; set; }

        public int BrandId { get; set; }    //Brand -->Marka

        public int ColorId { get; set; }  

        public int ModelYear { get; set; }  //ModelYılı

        public decimal DailyPrice { get; set; } //Günlük kiralama ücreti

        public string Description { get; set; } //Açıklama
    }


}
