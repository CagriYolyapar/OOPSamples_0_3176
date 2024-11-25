using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSamples_0.Models
{
    public abstract class Personel
    {
        public Personel()
        {

        }

        public Personel(int yas)
        {
            Yas = yas;
        }
      
        public Personel(string isim,string soyIsim)
        {
            Isim = isim;
            SoyIsim = soyIsim;
        }
        public string Isim { get; set; }
        public string SoyIsim { get; set; }
        public int Yas { get; set; }

    }
}
