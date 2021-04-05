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
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";

        public static string MaintenenceTime = "Sistem bakımda";
        public static string ProductListed = "Ürünler eklendi";

        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir.";
        internal static string ProductNameAlreadyExists = "Bu isimde zaten başka bir ürün var";
        internal static string CategoryLimitExceded = "Kategori limiti aşıldığı için yeni ürün eklenemiyor";
    }
}
