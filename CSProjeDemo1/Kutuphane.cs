using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1
{
    public class Kutuphane
    {
        // Ana sınıfımız olan Kutuphane kitapapları ve üyeleri yönetebilmek adına Kitaplar ve Uyeler listelerini oluşturabilmek adına propertilerimizi ekledik
        public List<Kitap> Kitaplar { get; set; } 
        public List<UYE> Uyeler { get; set; }

        public Kutuphane() // Buradaki constructor metodumuz ile oluşturduğumuz instancelarda doğrudan Kitaplar ve Uyeler listemizi newledik.
        {
            Kitaplar = new List<Kitap>();
            Uyeler = new List<UYE>();
        }

        public void KitapEkle(Kitap kitap) // Kitap Ekleme metodu
        {
            Kitaplar.Add(kitap);
        }

        public void UyeEkle(UYE uye) // UYE Ekleme metodu
        {
            Uyeler.Add(uye);
        }

        public void KitapOduncVer(int uyeNumarasi, string isbnNo)  //  isbnNo ve uye numarası belirterek Kitap ödünç verme metodu 
        {
            UYE uye1 = Uyeler.FirstOrDefault(u => u.UyeNumarasi == uyeNumarasi); // Uyeler listesinden belirtilen uyenumarası çekildi
            Kitap kitap1 = Kitaplar.FirstOrDefault(k => k.ISBNNo == isbnNo); // Kitaplar listesinden belirtilen kitap çekildi
            if (uye1 != null && kitap1 != null && kitap1.DurumuGetir() == Durum.OduncAlabilir) // Kitap ve uye numarası sistemde var ise durumu OduncAlabilir ise 
            {
                uye1.KitapOduncAl(kitap1); // belirtilen uyeye belirtilen kitabı ödünç ver işlemi
            }
        }

        public void KitapIadeEt(int uyeNumarasi, string isbnNo) //  isbnNo ve uye numarası belirterek Kitabı iade etme metodu 
        {
            UYE uye1 = Uyeler.FirstOrDefault(u => u.UyeNumarasi == uyeNumarasi); // Uyeler listesinden belirtilen uyenumarası çekildi
            Kitap kitap1 = Kitaplar.FirstOrDefault(k => k.ISBNNo == isbnNo); // Kitaplar listesinden belirtilen kitap çekildi
            if (uye1 != null && kitap1 != null && kitap1.DurumuGetir() == Durum.OduncVerildi)  // Kitap ve uye numarası sistemde var ise durumu OduncVerildi ise
            {
                uye1.KitapIadeEt(kitap1); // Belirtilen üyeden belirtilen kitabın iadesini yap işlemi
            }
        }

        public List<Kitap> OduncAlinanKitaplar() // Ödünç alınan kitapları listeleme metodu
        {
            return Kitaplar.Where(k => k.DurumuGetir() == Durum.OduncVerildi).ToList(); // Kitaplar listesinde Durumu = OduncVerildi olanaları listele
        }

        public List<Kitap> MevcutKitaplar() // Kütüphanedeki mevcut kitaplar
        {
            return Kitaplar.Where(k => k.DurumuGetir() == Durum.OduncAlabilir).ToList(); // Kitaplar listesinde Durumu = OduncAlabilir olanaları listele
        }

        public List<UYE> TumUyeler() // Tüm üyeleri listeleme metodu
        {
            return Uyeler; // Uyeler listesini döndür
        }
    }
}
