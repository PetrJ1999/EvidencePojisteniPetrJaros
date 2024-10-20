using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EvidencePojisteni
{
    internal class Pojistenec
    {
        public string jmeno { get; private  set; }
        public string prijmeni { get; private  set; }
        public int vek { get; private set; }
        public string tel { get;private set; }

        public Pojistenec(string Jmeno, string Prijmeni, int Vek, string Tel)
        {
            jmeno = Jmeno;
            prijmeni = Prijmeni;
            vek = Vek;
            tel = Tel;
        }
        
        // Základní výpis listu s formátem sloupců zarovnaných do leva
        public override string ToString()
        {
            return $"{jmeno,-10} {prijmeni, -10} {vek, -10} {tel, -10}";
        }



    }

}
