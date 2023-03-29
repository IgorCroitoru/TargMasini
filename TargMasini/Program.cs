using System;
using System.IO;
using AdministrareVanzariTxt;
using Masina;
using System.Collections.Generic;
using System.Globalization;
using StringFormat;
using ClassFilter;
using System.Net.Mail;

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
           

            string optiune;
            //MENIUL PRINCIPAL
            do
            {
                Console.WriteLine("I. Introducere date vanzare");
                Console.WriteLine("A. Afisare vanzari");
                Console.WriteLine("F. Afisare vanzari din fisier");
                Console.WriteLine("S. Salvare vanzare in fisier");
                Console.WriteLine("T. Cauta vanzare");
                Console.WriteLine("D. Modificare date");
                Console.WriteLine("X. Inchidere program");
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
                        List<MasinaClass> vanzari = adminVanzari.GetTranzactii();
                        foreach (MasinaClass masina in vanzari)
                        {
                            Console.WriteLine(masina);
                        }
                        break;

                    case "S":
                        adminVanzari.AddTranzactie(vanzare);
                       
                        break;
                    case "T":
                        //MENIU PENTRU CAUTARE TRANZACTII DUPA FILTRE
                        filtru = new Filter();
                        string optiunea3;
                        do
                        {
                            Console.WriteLine("1. Adauga filtru firma:");
                            Console.WriteLine("2. Adauga filtru model:");
                            Console.WriteLine("3. Adauga filtru cumparator:");
                            Console.WriteLine("4. Adauga filtru vanzatori:");
                            Console.WriteLine("5. Adauga filtru interval de timp: ");
                            Console.WriteLine("6. Adauga filtru interval de pret: ");
                            Console.WriteLine("7. Cauta cu filtrele selectate: ");
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
                                    Console.WriteLine("Introduceti pretul de la: ");
                                    filtru.PretDela = Convert.ToSingle(Console.ReadLine());
                                    Console.WriteLine("Introduceti pretul pana la:");
                                    filtru.PretPanala = Convert.ToSingle(Console.ReadLine());   
                                    break;
                                case "7":
                                    //CAUTARE DUPA FILTRE
                                    var searchResults = adminVanzari.Search(masina =>
                                        (filtru.Firma == null || masina.Firma.Format() == filtru.Firma.Format()) &&
                                        (filtru.Model == null || masina.Model.Format() == filtru.Model.Format()) &&
                                        (filtru.NumeCumparator == null || masina.NumeCumparator.Format() == filtru.NumeCumparator.Format()) &&
                                        (filtru.NumeVanzator == null || masina.NumeVanzator.Format() == filtru.NumeVanzator.Format()) &&
                                        (filtru.DataFrom == DateTime.MinValue  || masina.DataVanzare >=filtru.DataFrom) &&
                                        (filtru.DataTo == DateTime.MinValue || masina.DataVanzare <= filtru.DataTo) &&
                                        (filtru.PretDela == 0.0 || masina.Pret >= filtru.PretDela) &&
                                        (filtru.PretPanala == 0.0 || masina.Pret <= filtru.PretPanala));
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
                    case "D":
                        //MENIU EDITARE DATE
                        string optiunea4;
                        do {
                            Console.WriteLine("SUNETI IN SECTIUNEA DE EDITARE A DATELOR:\n");
                            Console.WriteLine("1. Afisare toate vanzari");
                            Console.WriteLine("X. Iesire");
                            optiunea4 = Console.ReadLine();
                            switch (optiunea4.ToUpper())
                            {
                                case "1":
                                    //SALVAM IN vanzari O LISTA CU VANZARILE DIN FISIER
                                    
                                    vanzari = adminVanzari.GetTranzactii();

                                    //cream o copie a a listei cu vanzari 

                                    List<MasinaClass> changes = new List<MasinaClass>(vanzari);
                                    foreach (MasinaClass masina in vanzari)
                                    {
                                        Console.WriteLine(masina);
                                    }
                                    
                                    Console.WriteLine("INDTRODUCETI ID-UL VANZARII CARE DORITI SA O MODIFICATI");
                                    int id_del = Convert.ToInt32(Console.ReadLine());
                                    string optiunea5;
                                    do
                                    {
                                        Console.WriteLine("1. Modifica data vanzare");
                                        Console.WriteLine("2. Modifica Firma");
                                        Console.WriteLine("3. Modifica Model");
                                        Console.WriteLine("4. Modifica Culoare");
                                        Console.WriteLine("5. Modifica An productie");
                                        Console.WriteLine("6. Modifica Cumparator");
                                        Console.WriteLine("7. Modifica Vanzator");
                                        Console.WriteLine("8. Modifica Optiuni");
                                        Console.WriteLine("9. Modifica Pret");
                                        Console.WriteLine("0. Stergere tranzactie");
                                        Console.WriteLine("S. Salvare schimbari");
                                        Console.WriteLine("X. Iesire");
                                        optiunea5 = Console.ReadLine();
                                        
                                        switch (optiunea5.ToUpper())
                                        {
                                            case "0":
                                                //STERGEM DATELE EXISTENTE DIN FISIER SI LE ADUGAM DIN NOU PE TOATE EXCLUSIV ID-UL STERS
                                                File.WriteAllText(numeFisier, "");
                                                foreach (MasinaClass masina in vanzari)
                                                {
                                                    if (masina.IDtranzactie != id_del)
                                                    {
                                                        adminVanzari.AddTranzactie(masina);
                                                    }
                                                }
                                                break;
                                            case "1":
                                                Console.WriteLine("Introduceti data noua de vanzare:");
                                                DateTime new_data = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
                                                adminVanzari.UpdateProperty(changes, id_del, new_data, "DataVanzare");
                                                break;
                                            case "2":
                                                Console.WriteLine("Introduceti numele nou al firmei:");
                                                string nume = Console.ReadLine();
                                                adminVanzari.UpdateProperty(changes, id_del, nume, "Firma");
                                                break;
                                            case "3":
                                                Console.WriteLine("Introduceti modelul nou al masinii:");
                                                string model = Console.ReadLine();
                                                adminVanzari.UpdateProperty(changes, id_del, model, "Model");
                                                break;
                                            case "4":
                                                Console.WriteLine("Introduceti culoarea noua a masinii");
                                                string culoare = Console.ReadLine();
                                                adminVanzari.UpdateProperty(changes, id_del, culoare, "Culoare");

                                                break;
                                            case "5":
                                                Console.WriteLine("Introduceti noul al al productiei:");
                                                int an = Convert.ToInt32(Console.ReadLine());
                                                adminVanzari.UpdateProperty(changes, id_del, an, "AnFabricatie");
                                                break;
                                            case "6":
                                                Console.WriteLine("Introduceti noul cumparator");
                                                string cumparator = Console.ReadLine();
                                                adminVanzari.UpdateProperty(changes, id_del, cumparator, "NumeCumparator");

                                                break;
                                            case "7":
                                                Console.WriteLine("Introduceti noul vanzator");
                                                string vanzator = Console.ReadLine();
                                                adminVanzari.UpdateProperty(changes, id_del, vanzator, "NumeVanzator");
                                                break;
                                            case "8":
                                                Console.WriteLine("Introduceti noile optiuni");
                                                string optiuni = Console.ReadLine();
                                                adminVanzari.UpdateProperty(changes, id_del, optiuni, "Optiuni");
                                                break;
                                            case "9":
                                                Console.WriteLine("Introduceti noul pret");
                                                float pret = Convert.ToSingle(Console.ReadLine());
                                                adminVanzari.UpdateProperty(changes, id_del, pret, "Pret");
                                                break;
                                            case "S":
                                                //SALVAM DATELE
                                                File.WriteAllText(numeFisier, "");
                                                foreach (MasinaClass masina in vanzari)
                                                {
                                                    adminVanzari.AddTranzactie(masina);
                                                }
                                                Console.WriteLine("Datele au fost schimbate cu succes");
                                                break;
                                        }
                                    } while (optiunea5.ToUpper() != "X");
                                    break;
                            }
                        } while(optiunea4.ToUpper() != "X");
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
