using System;
using System.IO;
using AdministrareVanzariTxt;
using Masina;
using System.Globalization;
using StringFormat;
using ClassFilter;
namespace TargMasini
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numeFisier = "Vanzari.txt";
            MasinaClass vanzare = new MasinaClass();
            Database adminVanzari = new Database(numeFisier);
            Filter filtru = new Filter();
            int nrVanzari = File.ReadAllLines(numeFisier).Length;

            //doua variabile de tip data care le vom folosi la cautarea vanzarilor
            DateTime data_from = DateTime.MinValue;
            DateTime data_to = DateTime.MaxValue;

            string optiune;
            do
            {
                Console.WriteLine("I. Introducere date vanzare");
                Console.WriteLine("A. Afisare vanzari");
                Console.WriteLine("F. Afisare vanzari din fisier");
                Console.WriteLine("S. Salvare vanzare in fisier");
                Console.WriteLine("X. Inchidere program");
                Console.WriteLine("T. Cauta vanzare");
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
                    case "T":
                        filtru = new Filter();
                        string optiunea3;
                        do
                        {
                            Console.WriteLine("1. Adauga filtru firma:");
                            Console.WriteLine("2. Adauga filtru model:");
                            Console.WriteLine("3. Adauga filtru cumparator:");
                            Console.WriteLine("4. Adauga filtru vanzatori:");
                            Console.WriteLine("5. Adauga filtru interval de timp: ");
                            Console.WriteLine("6. Cauta cu filtrele selectate: ");
                            Console.WriteLine("R. Reseteaza filtre: ");
                            Console.WriteLine("X. Opreste cautarea");
                            optiunea3 = Console.ReadLine();
                          

                            switch (optiunea3.ToUpper())
                            {
                                case "1":
                                    Console.WriteLine("Introdu firma masinii:");
                                    filtru.Firma = Console.ReadLine();
                                    break;
                                case "2":
                                    Console.WriteLine("Introdu modelul masinii:");
                                    filtru.Model = Console.ReadLine();
                                    break;
                                case "3":
                                    Console.WriteLine("Introdu nume cumparator:");
                                    filtru.NumeCumparator = Console.ReadLine();
                                    break;
                                case "4":
                                    Console.WriteLine("Indtrodu nume vanzator:");
                                    filtru.NumeVanzator = Console.ReadLine();
                                    break;
                                case "5":
                                    Console.WriteLine("Introdu data de la (zz.ll.aaaa): ");
                                    filtru.DataFrom = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
                                    Console.WriteLine("Introdu data pana la (zz.ll.aaaa): ");
                                    filtru.DataTo = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
                                    break;
                                case "6":

                                    var searchResults = adminVanzari.Search(masina =>
                                        (filtru.Firma == null || masina.Firma.Format() == filtru.Firma.Format()) &&
                                        (filtru.Model == null || masina.Model.Format() == filtru.Model.Format()) &&
                                        (filtru.NumeCumparator == null || masina.NumeCumparator.Format() == filtru.NumeCumparator.Format()) &&
                                        (filtru.NumeVanzator == null || masina.NumeVanzator.Format() == filtru.NumeVanzator.Format()) &&
                                        (filtru.DataFrom == null || masina.DataVanzare >=filtru.DataFrom) &&
                                        (filtru.DataTo == null || masina.DataVanzare <= filtru.DataTo));
                                    adminVanzari.PrintVanzari(searchResults);
                                    break;
                                default:
                                    Console.WriteLine("Optiune inexistenta");
                                    break;
                                case "R":
                                    filtru = new Filter();
                                    
                                    break;

                            }

                        } while (optiunea3.ToUpper() != "X");
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
