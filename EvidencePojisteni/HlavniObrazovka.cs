using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePojisteni
{
    internal class HlavniObrazovka
    {
        // Zobrazení hlavní obrazovky
        public void Vykresli()
        {
            Console.Clear();
            Console.WriteLine("------------------------------");
            Console.WriteLine("Evidence pojištěnych");
            Console.WriteLine("------------------------------");

            Console.WriteLine("Vyberte si akci:" +
                              "\n1 - Přidat nového pojištěného" +
                              "\n2 - Vypsat všechny pojištěné" +
                              "\n3 - Vyhledat pojištěného" +
                              "\n4 - Konec");
        }

        
    }
}
