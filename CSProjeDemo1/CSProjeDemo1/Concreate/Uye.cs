using CSProjeDemo1.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1.Concreate
{
    public class Uye : IUye
    {
        public string Ad { get ; set ; }
        public string Soyad { get ; set ; }
        public string UyeNumarasi { get ; set ; }
        public List<Kitap> OduncAlinanKitaplar { get; set; }

        // Kitap odunc alma ve odunc verme methodları talimata gore buraya eklenmistir.
        //Parametre olarak kitap alınıp durumları kontrol edilerek, degisim saglanmistir.
        public void GeriVerme(Kitap kitap)
        {
            kitap.Durum = Enums.Durum.OduncAlabilir;
        }

        public void OduncAlma(Kitap kitap)
        {
            if(kitap.Durum == Enums.Durum.OduncAlabilir)
            {
                kitap.Durum = Enums.Durum.OduncVerildi;
                OduncAlinanKitaplar.Add(kitap);
            }
        }

    }
}
