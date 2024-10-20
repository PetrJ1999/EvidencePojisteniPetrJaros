using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EvidencePojisteni
{
    internal class KontrolaUdaje
    {
        // Validace Jména a Přijmení
        public static bool ZkontrolujJmenoAPrijmeni(string jmeno)
        {
            // Povolené znaky pro zadání jména 
            Regex shoda = new Regex(@"^[a-zA-ZáÁžŽýÝíÍšŠčČřŘ]+$");
            if (shoda.IsMatch(jmeno) && jmeno.Length < 2)
            {
                Console.WriteLine("\nMinimální délka jsou dva znaky.");
                return false;
            }
            else
            {
                return true;
            }
            
        }

        // Validace délky tel. čísla
        public static bool ZkontrolujTelCislo(string cislo)
        {
            // Kontorla zada jsou obsažena pouze čísla a případně znak "+"
            Regex pouzeCisla = new Regex(@"^\+?\d{9,}$");
            
            // Podmínkou je obsah telefonního čísla a minimální délka
            if (!pouzeCisla.IsMatch(cislo) || cislo.Length < 9)
            {
                Console.WriteLine("Telefonní číslo může obsahovat pouze číslice a případně znak '+'\nMinimální délka je devět čísel: ");
                return false;
            }
            else
            {
                return true;
            }         
        }
    }
}
