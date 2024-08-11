using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1
{
    public class UYE : IUYE
    {
        // UYE nin temel propertyleri
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int UyeNumarasi { get; set; }
        public List<Kitap> OduncAlinanKitaplar { get; set; } // OduncAlınanKitaplar adında Kitap listesi oluşturabilme özelliği ekledik

        public UYE(string ad, string soyad, int uyeNumarasi) // Constructor metodu instance alırken ad soyad ve uye numarısı girmesi zorunlu
        {
            // Girilen bilgilerin ataması
            Ad = ad;
            Soyad = soyad;
            UyeNumarasi = uyeNumarasi;
            OduncAlinanKitaplar = new List<Kitap>();
        }

        public void KitapOduncAl(Kitap kitap) // IUYE ınterface inden implement ettiğimiz Kitab veritipinde kitap nesnesini belirterek oluşturduğumuz ödünç al metodu 
        {
            if (kitap.DurumuGetir() == Durum.OduncAlabilir) // belirtilen kitabın durumu OduncAlabilir ise
            {
                OduncAlinanKitaplar.Add(kitap); // Kitabı OduncAlınanKitaplar listesine ekle
                kitap.DurumuBelirle(Durum.OduncVerildi); // Durumunu ÖdüncVerildi yap
            }
        }
        public void KitapIadeEt(Kitap kitap) // IUYE ınterface inden implement ettiğimiz Kitab veritipinde kitap nesnesini belirterek oluşturduğumuz iade et metodu
        {
            if (OduncAlinanKitaplar.Contains(kitap)) // OduncAlınanKitaplar listesi belirtilen kitap nesnesini içeriyorsa
            {
                OduncAlinanKitaplar.Remove(kitap); // OduncAlınanKitaplar listesinden çıkar
                kitap.DurumuBelirle(Durum.OduncAlabilir); // Durumunu ÖdüncAlabilir yap
            }
        }

        
    }
}
