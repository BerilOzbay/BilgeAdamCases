using CSProjeDemo2.Abstract;
using CSProjeDemo2.Concrete;
using CSProjeDemo2.Services;

namespace CSProjeDemo2UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = DosyaOku.DosyaOkuma();
            string tumRapor = "";
            foreach (var item in list)
            {
                if (item.Title == "Yonetici")
                {
                    Console.Write($"{item.Name} {item.Surname} çalışma süresi: ");
                    int sure = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Bonus ücreti giriniz: ");
                    double bonus = Convert.ToDouble(Console.ReadLine());

                    var yonetici = new Yonetici() { Ad = item.Name, Soyad = item.Surname, bonus = bonus };

                    tumRapor += MaasBordo.BordroOlustur(yonetici, sure);
                }

                else if (item.Title == "Memur")
                {
                    Console.Write($"{item.Name} {item.Surname} çalışma süresi: ");
                    int sure = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Personel kademesini giriniz: ");
                    int kademe = Convert.ToInt32(Console.ReadLine());

                    var memur = new Memur() { Ad = item.Name, Soyad = item.Surname, Kademe = kademe };

                    tumRapor += MaasBordo.BordroOlustur(memur, sure);
                }
            }

            Console.Clear();
            Console.WriteLine($"Tüm personel raporu: \n{tumRapor}");
            MaasBordo.AzCalisanListele();
            Console.ReadKey();
        }
    }
}
