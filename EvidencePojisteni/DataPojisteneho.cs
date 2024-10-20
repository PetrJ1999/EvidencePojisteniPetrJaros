using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePojisteni
{
    internal class DataPojisteneho
    {
        // List s uloženými pojištěnci
        private static List<Pojistenec> pojisteny = new List<Pojistenec>();

        // Vrací List pojištěnců pouze pro čtení
        public static IReadOnlyList<Pojistenec> ZiskejPojistene() => pojisteny.AsReadOnly();

        // Přidání nového pojištěnce do privátního Listu pojištěných
        public static void PridejPojisteneho(Pojistenec pojistenec)
        {
            pojisteny.Add(pojistenec);
        }
    }
}
