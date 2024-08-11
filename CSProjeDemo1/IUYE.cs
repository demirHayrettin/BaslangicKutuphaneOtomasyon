using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1
{
    // UYE class'ı nın özelliklerini ve gerekleştirebilecekleri metotları belirten IUYE interface/i oluşturuldu.
    public interface IUYE
    {
        // Temel özellikler(propertyler)
        string Ad { get; set; }
        string Soyad { get; set; }
        int UyeNumarasi { get; set; } 
        List<Kitap> OduncAlinanKitaplar { get; set; } // ÜYE nin ödünç aldığı kitapları görebilmesi için  Kitap Listesi veritipinde  OduncAlinanKitaplar isimli properti ekledik

        public void KitapOduncAl(Kitap kitap) // Burada KitapOduncAl metodu içi boş oluşturuldu ancak UYE clasında implement ettiğimizde yapmasını istediğimiz işlemler ile doldurulacak
        {

        }
        public void KitapIadeEt(Kitap kitap) // Burada KitapIadeEt metodu içi boş oluşturuldu ancak UYE clasında implement ettiğimizde yapmasını istediğimiz işlemler ile doldurulacak
        {

        }
    }
}
