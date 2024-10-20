using System.ComponentModel.Design;

namespace EvidencePojisteni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UzivatelskeRozhrani uzivatelskeRozhrani = new();

            uzivatelskeRozhrani.HlavniNabidka();
            Console.ReadKey();
        }
    }
}
