using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {

        //Brand Messages
        public static string BrandAdded = "Marka eklendi";
        public static string BrandDeleted = "Marka silindi";
        public static string BrandUpdated = "Marka güncellendi";
        public static string BrandsListed = "Markalar listelendi";
        public static string BrandNameInvalid = "Marka ismi geçersiz";


        //public olduğu için
        //Car Messages
        public static string CarAdded = "Araba eklendi";
        public static string CarNameInvalid = "Araba ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string CarsListed = "Arabalar listelendi";

        //Color Messages
        public static string ColorAdded = "Renk eklendi";
        public static string ColorDeleted = "Renk silindi";
        public static string ColorUpdated = "Renk güncellendi";
        public static string ColorsListed = "Renkler listelendi";

        //Customer

        public static string CustomerAdded = "Müşteri eklendi";
        public static string CustomerDeleted = "Müşteri silindi";
        public static string CustomerUpdated = "Müşteri güncellendi";
        public static string CustomersListed = "Müşteriler listelendi";
        public static string CustomerMaintenanceTime = "Sistem bakımda";

        //Rental
        public static string RentalAdded = "Kiralama işlemi oluşturuldu.";
        public static string RentalDeleted = "Kiralama işlemi silindi.";
        public static string RentalUpdated = "Kiralama işlemi güncellendi.";
        public static string RentalsListed = "Kiralamalar listelendi.";
        public static string CompanyNameCannotBeEmpty = "Şirket adı boş olamaz";
        public static string CarNotReturned = "Araç İade Edilmedi";
    }
}

