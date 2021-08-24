using System;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
   public static class Messages
    {
        
        public static string ProductAdded = "Ürün eklendi";

        public static string ProductNameInvalid = "Ürün ismi 2 karakter olmali";
        public static string ProductsListed= "Ürünler listelendi";
        public static string CategoriesListed = "Kategoriler listelendi";

        public static string MaintenanseTime = "Sistem bakımda";

        public static string ProductUpdated = "Ürün güncellendi";
        public static string ProductCountOfCategoryError= "Bir kategoride en fazla 10 ürün olabilir";
        public static string ProductNameAlreadyExists= "Bu isimde başka bir ürün zaten var";
        public static string CategoryLimitExceded="Kategori limiti aşıldığı için yeni ürün eklenemiyor";
        public static string AuthorizationDenied = "Yetkiniz yok";
    }
}
