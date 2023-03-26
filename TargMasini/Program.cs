using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using AdministrareVanzariTxt;
using Masina;
using System.Globalization;

namespace TargMasini
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numeFisier = "Vanzari.txt";
            MasinaClass vanzare = new MasinaClass();
            Database adminVanzari = new Database(numeFisier);
            int nrVanzari = File.ReadAllLines(numeFisier).Length;

            string optiune;
            do
            {
                Console.WriteLine("I. Introducere date vanzare");
                Console.WriteLine("A. Afisare vanzari");
                Console.WriteLine("F. Afisare vanzari din fisier");
                Console.WriteLine("S. Salvare vanzare in fisier");
                Console.WriteLine("X. Inchidere program");
                Console.WriteLine("C. Cauta vanzare");
                Console.WriteLine("Alegeti o optiune");
                optiune = Console.ReadLine();
                switch (optiune.ToUpper())
                {
                    case "I":
                        int idVanzare = nrVanzari + 1;
                        vanzare.IDtranzactie = idVanzare;
                        Console.WriteLine("INTRODUCETI DATE VANZARE #{0}\n", idVanzare);
                        Console.WriteLine("INTRODUCETI FIRMA MASINII: ");
                        vanzare.Firma = Console.ReadLine();
                        Console.WriteLine("INTRODUCETI MODELUL MASINII: ");
                        vanzare.Model = Console.ReadLine();
                        Console.WriteLine("INTRODUCETI ANUL FABRICARII: ");
                        vanzare.AnFabricatie = int.Parse(Console.ReadLine());
                        Console.WriteLine("INTRODUCETI CULOAREA: ");
                        vanzare.Culoare = Console.ReadLine();
                        Console.WriteLine("INTRODUCETI ALTE OPTIUNI ALE MASINII: ");
                        vanzare.Optiuni = Console.ReadLine();
                        Console.WriteLine("INTRODUCETI NUMELE COMPLET AL CUMPARATORULUI: ");
                        vanzare.NumeCumparator = Console.ReadLine();
                        Console.WriteLine("INTRODUCETI NUMELE COMPLET AL VANZATORULUI: ");
                        vanzare.NumeVanzator = Console.ReadLine();
                        Console.WriteLine("INTRODUCETI PRETUL: ");
                        vanzare.Pret = float.Parse(Console.ReadLine());
                        Console.WriteLine("INTRODUCETI DATA VANZARII SUB FORMA (ZZ.LL.AAAA): ");
                        vanzare.DataVanzare = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
                        break;
                  
                    case "F":
                        MasinaClass[] vanzari = adminVanzari.GetTranzactii(nrVanzari);
                        foreach (MasinaClass masina in vanzari)
                        {
                            Console.WriteLine(masina);
                        }
                        break;

                    case "S":
                        adminVanzari.AddTranzactie(vanzare);
                       
                        break;
                    case "X":
                        return;
                    default:
                        Console.WriteLine("Optiune inexistenta");

                        break;
                }
            } while (optiune.ToUpper() != "X");

            Console.ReadKey();
        }
    }
}
