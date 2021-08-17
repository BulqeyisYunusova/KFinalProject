using Entities.Concrete;
using Entities.Concrete.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
   public static class Messages
    {
        
        public static string ProductAdded = "Urun eklendi";

        public static string ProductNameInvalid = "Urun ismi 2 karakter olmali";
        public static string ProductsListed="Urunler listelendi";
        public static string CategoriesListed = "Kategoriyalar listelendi";

        public static string MaintenanseTime = "Sistem bakimda";

        public static string ProductUpdated = "Urun guncellendi";
    }
}
