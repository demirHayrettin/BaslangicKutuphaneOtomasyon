using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1
{
    public class KitapTarih : Kitap
    {

        public Durum Durumu { get; set; } // Durumunu belirtmek üzere oluşturduğumuz property 

        public KitapTarih(string isbnNo, string baslik, string yazar, int yayinYili) // Buradaki oluşturduğumuz constructor metodu içerisinde olması gereken özellekleri belirterek instance alınırken zorunlu kıldık

        {       // Atasından gelen özellikler   
            ISBNNo = isbnNo;
            Baslik = baslik;
            Yazar = yazar;
            YayinYili = yayinYili;

            // Kendisinde bulunan özellik
            Durumu = Durum.OduncAlabilir; // nesnesini oluştururken başlangıçta ödünç alınabilir yaptık


        }
        public override Durum DurumuGetir() // atasından gelen durumgetirme metodu override ederek durumu döndür
        {
            return Durumu;
        }

        public override void DurumuBelirle(Durum durum) // atasından gelen durum belirleme metodu ile override ederek durumu belirle
        {
            Durumu = durum;
        }
    }
}