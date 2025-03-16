using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1.Abstract
{
    public interface IUye
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string UyeNumarasi { get; set; }
        public List<Kitap> OduncAlinanKitaplar {  get; set; }
        public void OduncAlma(Kitap kitap);
        public void GeriVerme(Kitap kitap);
    }
}
