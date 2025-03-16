using CSProjeDemo2.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo2.Concrete
{
    public class Yonetici : Personel
    {
        private double? _saatlikUcret = 1000;
        public double? bonus {  get; set; }
        public double? SaatlikUcret
        {
            get { return _saatlikUcret; }
            set {
                if (value > 500) 
                { 
                    _saatlikUcret = value;
                }
                else
                {
                    throw new Exception("Saatlik ücret 500'den büyük olmalıdır.");
                }
            }
        }
        public override double MaasHesapla(int calismaSaati)
        {
            return (double)((calismaSaati * _saatlikUcret) + bonus);
        }
    }
}
