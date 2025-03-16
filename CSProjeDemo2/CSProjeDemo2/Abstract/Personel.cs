using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo2.Abstract
{
    public abstract class Personel
    {
        public int? PersonelNo { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public abstract double MaasHesapla(int calismaSaati);
    }
}
