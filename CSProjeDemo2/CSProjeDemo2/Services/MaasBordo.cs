using CSProjeDemo2.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo2.Services
{
    public static class MaasBordo
    {
        public static List<Personel> azCalisan = new List<Personel>();

        public static string BordroOlustur(Personel personel, int sure)
        {
            if (sure < 150)
            {
                azCalisan.Add(personel);
            }

            var baslik = $"MaasBordro_{DateTime.Now.ToString("MMMM")}_{DateTime.Now.Year}";
            string icerik = 
                $"{{\n" +
                $"\"Personel Ismi\": \"{personel.Ad}\",\n" +
                $"\"Calisma Saati\": {sure}, \n" +
                $"\"Toplam Odeme\": {personel.MaasHesapla(sure)}\n" +
                $"}}";

            if (!Directory.Exists($"..\\..\\..\\Personeller\\{personel.Ad}{personel.Soyad}")) 
            {
                Directory.CreateDirectory($"..\\..\\..\\Personeller\\{personel.Ad}{personel.Soyad}");
            }

            File.WriteAllText($"..\\..\\..\\Personeller\\{personel.Ad}{personel.Soyad}\\{baslik}.json", icerik);


            return $"{icerik}\n-------------------------------------------------------------------\n";

        }

        public static void AzCalisanListele()
        {

            Console.WriteLine("\n-------------------------------------------------------------------\n");
            Console.WriteLine("150 saatten az çalışanlar:");

            foreach (var personel in azCalisan)
            {
                Console.WriteLine($"{personel.Ad} {personel.Soyad}");
            }
        }
    }
}
