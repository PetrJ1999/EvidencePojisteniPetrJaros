using EvidencePojisteni;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePojisteni
{
    internal class UzivatelskeRozhrani
    {
        HlavniObrazovka hlavniObrazovka = new();
        ManazerEvidence manazerEvidence = new();

        public void HlavniNabidka()
        {
            bool ukonceni = false;
            do
            {
                // Zobrazení hlavní nabídky
                hlavniObrazovka.Vykresli();
                char volba = Console.ReadKey().KeyChar;
                // Volba akce
                switch (volba)
                {
                    // Reagistrace pojištěného
                    case '1':
                        {
                            manazerEvidence.Registruj();
                            Console.Write("\nData byla uložena. Pokračujte libovolnou klávesou...");
                            Console.ReadLine();
                        }
                        break;
                    // Výpis všech pojištěných
                    case '2':
                        {
                            Console.WriteLine();
                            Console.WriteLine(manazerEvidence.VypisPojistene());
                            Console.WriteLine("\nPokračujte libovolnou klávesou...");
                            Console.ReadLine();

                        }
                        break;
                    // Vyhledání pojištěného
                    case '3':
                        {
                            Console.WriteLine();
                            Console.WriteLine(manazerEvidence.NalezniPodleUdaju());
                            Console.WriteLine("\nPokračujte libovolnou klávesou...");
                            Console.ReadLine();
                        }
                        break;
                    // Ukončí aplikaci
                    case '4':
                        {
                            ukonceni = true;
                            Console.WriteLine();
                            Console.WriteLine("\nDěkujeme za použití aplikace a přejeme hezký zbytek dne.");
                        }
                        break;
                    default:
                        {
                            Console.WriteLine("\nneplatná volba");
                        }
                        break;
                }
            }
            while (ukonceni == false);
        
        }

    }
}
