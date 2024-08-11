using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1
{
    public abstract class Kitap // instance alınamaz (abstract class) // metotlarıda abstract olmalıdır.
    {
        // Kitap için temel özellikler(propertyler)
        public string ISBNNo { get; set; }

        public string Baslik { get; set; }

        public string Yazar { get; set; }

        public int YayinYili { get; set; }

        public abstract Durum DurumuGetir(); // Subclasların durumlarına erişim sağlama abstract metodu(gövde olmaz)
        public abstract void DurumuBelirle(Durum durum); //  subclasların durumunu set etme abstract metodu(gövde olmaz)


    }
}
