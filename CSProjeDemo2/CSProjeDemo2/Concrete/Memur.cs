using CSProjeDemo2.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo2.Concrete
{
    public class Memur : Personel
    {
        private double? _saatlikUcret;
        public int? Kademe { get; set; }
        public double? SaatlikUcret
        {
           get { return _saatlikUcret; }
           set { _saatlikUcret = 500; }
        }
        //Memur kademesine göre saat ucreti guncellenir.
        public void UpdateSaatlikUcret()
        {
            _saatlikUcret = 500 * Kademe;
        }

        public override double MaasHesapla(int calismaSaati)
        {
            UpdateSaatlikUcret();
            if(calismaSaati <= 180)
                return (double)_saatlikUcret * calismaSaati;
            return (double)((180 * _saatlikUcret) + ((calismaSaati - 180) * 1.5 * _saatlikUcret));
        }
    }
}
