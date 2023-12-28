using Core;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class CarDetailDto : IDto
    {
        public string? BrandName;
        public string? ColorName;

        public int CarId { get; set; }

        public int? BrandId { get; set; }    //Brand -->Marka

        public int? ColorId { get; set; }

        public int? ModelYear { get; set; }  //ModelYılı

        public decimal? DailyPrice { get; set; } //Günlük kiralama ücreti

        public string? Description { get; set; } //Açıklama

        public string? CarName { get; set; }
    }
}