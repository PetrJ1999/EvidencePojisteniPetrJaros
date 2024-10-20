using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePojisteni
{
    internal class ManazerEvidence
    {
        public string jmeno { get; private set; }
        public string prijmeni { get; private set; }
        public int vek { get; private set; }
        public string tel { get; private set; }
        // Přidání nového pojistěného do listu
        public void Registruj()
        {
            Console.WriteLine();
            // Zadání jména
            Console.WriteLine("\nZadejte jméno: ");
            jmeno = Console.ReadLine();
            // Validace jména
            while (!KontrolaUdaje.ZkontrolujJmenoAPrijmeni(jmeno))
            {
                Console.WriteLine("Jméno je povinný údaj!");
                jmeno = Console.ReadLine();
            }
            // Zadání přijmení
            Console.WriteLine("Zadejte přijmení: ");
            prijmeni = Console.ReadLine();
            // Validace přijmení
            while (!KontrolaUdaje.ZkontrolujJmenoAPrijmeni(prijmeni))
            {
                Console.WriteLine("Přijmení je povinný údaj!");
                prijmeni = Console.ReadLine();
            }
            // Zadání věku
            Console.WriteLine("Uveďte věk: ");
            // Lokální proměnná pro ukládání věku
            int vstupVek;
            // Kontrola zda je věk číslo a je v rozsahu od 1 do 122
            while (!int.TryParse(Console.ReadLine(), out vstupVek) || vstupVek < 1 || vstupVek > 122)
            {
                    Console.WriteLine("Věk je povinný údaj v rozsahu od jednoho roku do sto dvaceti dvou let!");
            }
            // Přiřazení vstupní hodnoty k věku
            vek = vstupVek;
            // Zadaní tel. čísla
            Console.WriteLine("Zadejte telefoní číslo: ");
            tel = Console.ReadLine();
            // Kontrola tel. čísla
            while (!KontrolaUdaje.ZkontrolujTelCislo(tel))
            {
                tel = Console.ReadLine();
            }

            // Přidání nového pojištěnce do listu pojištěných
            DataPojisteneho.PridejPojisteneho(new Pojistenec(jmeno, prijmeni, vek, tel));
        }
        // Vypis všech pojištěných 
        public string VypisPojistene()
        {
            // Pokud list pojisteny obsakuje aspoň jednoho pojištěného k výpisu, tak jej vypíše
            if (DataPojisteneho.ZiskejPojistene().Count >= 1)
            {
                foreach (Pojistenec Pojisteny in DataPojisteneho.ZiskejPojistene())
                {
                    Console.WriteLine($"\n{Pojisteny}");
                }
                return " ";
            }
            // List pojisteny neobsahuje kohokoliv k výpisu
            else
            {
                return "\nZatím nikdo nebyl registrován.";
            }

        }
        // Vyhledávání pojištěného
        public string NalezniPodleUdaju()
        {
            // Zadání jména pro vyhledávání
            Console.WriteLine("\nZadejte jméno: ");
            jmeno = Console.ReadLine();
            // Validace jména
            while (!KontrolaUdaje.ZkontrolujJmenoAPrijmeni(jmeno))
            {
                Console.WriteLine("Jméno je povinný údaj!");
                jmeno = Console.ReadLine();
            }
            // Zadání přijmení pro vyhledávání
            Console.WriteLine("Zadejte přijmení: ");
            prijmeni = Console.ReadLine();
            // Validace přijmení
            while (!KontrolaUdaje.ZkontrolujJmenoAPrijmeni(prijmeni))
            {
                Console.WriteLine("Přijmení je povinný údaj!");
                prijmeni = Console.ReadLine();
            }
            // Kontrola shody zadaných údajů s udaji z Listu pojištěných
            Pojistenec? hledany = DataPojisteneho.ZiskejPojistene().FirstOrDefault(shoda => shoda.Jmeno == jmeno && shoda.Prijmeni == prijmeni);
            {
                if (hledany is not null)
                {
                    return $"\n{hledany.ToString()}";
                }
                // Shoda nebyla úspěšná
                return "\nZadaný pojištěnec nebyl nalezen.";
            }
        }

    }
}
