using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSamples_0.Models
{

    /*
     
      public Personel()
    {
    }
     
     
     
     */


    public class Egitmen : Personel
    {
        /*
        
        public Egitmen():base()
        {
        }
        
        */
        public Egitmen(int yas) : base(37)
        {

        }
        public Egitmen()
        {

        }
        public Egitmen(string isim, string soyIsim) : base(isim,soyIsim)
        {
           
        }
    }
}
