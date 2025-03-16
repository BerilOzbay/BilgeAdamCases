using CSProjeDemo1.Abstract;
using CSProjeDemo1.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1.Concreate
{
    public class Kutuphane
    {
        // Uyeleri ve kitapları tutmak ve projenin her namescapesinden guncel listeye ulaşmak için
        //static listeler tanımlanmıştır.
        public static List<Kitap> Kitaplar = new List<Kitap>();
        public static List<Uye> Uyeler = new List<Uye>();

        //---- KİTAP CRUD İSLEMLERİ-----
        public void KitapGuncelle(Kitap kitap)
        {
            Kitap secilenKitap = Kitaplar.FirstOrDefault(k => k.ISBN == kitap.ISBN);
            if (secilenKitap != null)
            {
                secilenKitap.Yazar = kitap.Yazar;
                secilenKitap.Durum = kitap.Durum;
                secilenKitap.Baslik = kitap.Baslik;
                secilenKitap.YayinYili = kitap.YayinYili;
            }
            else
            {
                throw new Exception("Böyle bir kitap bulunamadı");
            }

        }
        public void KitapEkle(Kitap kitap)
        {
            if (Kitaplar.Any(k => k.ISBN != kitap.ISBN))
            {
                Kitaplar.Add(kitap);
            }
        }
        public void KitapSil(Kitap kitap)
        {
            if (Kitaplar.Any(k => k.ISBN == kitap.ISBN))
            {
                Kitaplar.Remove(kitap);
            }
            else
            {
                throw new Exception("Böyle bir kitap bulunamadı");
            }
        }
        public List<Kitap> KitaplariListele()
        {
            return Kitaplar;
        }
        public List<Kitap> DurumaGoreKitaplar(Durum durum)
        {
            return Kitaplar.Where(k => k.Durum == durum).ToList();
        }
        // ---------------------------------------------------------------------------------


        //-------- UYE CRUD ISLEMLERİ ---------------
        public void UyeGuncelle(Uye uye)
        {
            Uye secilenUye = Uyeler.FirstOrDefault(u => u.UyeNumarasi == uye.UyeNumarasi);
            if (secilenUye != null)
            {
                secilenUye.Ad = uye.Ad;
                secilenUye.Soyad = uye.Soyad;
            }
            else
            {
                throw new Exception("Böyle bir üye bulunamadı");
            }

        }
        public void UyeEkle(Uye uye)
        {
            if (Uyeler.Any(u => u.UyeNumarasi != uye.UyeNumarasi))
            {
                Uyeler.Add(uye);
            }
        }
        public void UyeSil(Uye uye)
        {
            if (Uyeler.Any(u => u.UyeNumarasi == uye.UyeNumarasi))
            {
                Uyeler.Remove(uye);
            }
            else
            {
                throw new Exception("Böyle bir üye bulunamadı");
            }
        }
        public List<Kitap> UyeninAldigiKitaplar(Uye uye)
        {
            return uye.OduncAlinanKitaplar; 
        }
        
        public List<Uye> UyeleriListele()
        {
            return Uyeler;
        }
        
    }
}
