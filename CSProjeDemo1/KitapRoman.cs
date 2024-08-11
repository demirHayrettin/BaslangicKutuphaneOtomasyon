using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1
{
    public class KitapRoman : Kitap
    {

        public Durum Durumu { get; set; } // Durumunu belirtmek üzere oluşturduğumuz property 

        public KitapRoman(string isbnNo, string baslik, string yazar, int yayinYili) // Buradaki oluşturduğumuz constructor metodu içerisinde olması gereken özellekleri belirterek instance alınırken zorunlu kıldık

        {       // Atasından gelen özellikler   
            ISBNNo = isbnNo;
            Baslik = baslik;
            Yazar = yazar;
            YayinYili = yayinYili;

            // Kendisinde bulunan özellik
            Durumu = Durum.OduncAlabilir;


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
