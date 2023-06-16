using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Masina;
namespace AdministrareVanzariTxt
{
    public class Database
    {
        private string numeFisier = "Vanzari.txt";
        private string numeFisier1 = "C:\\Users\\Igor\\source\\repos\\TargMasini\\Test.txt";

        public Database(string numeFisier)
        {
            this.numeFisier = numeFisier;

            if (!File.Exists(numeFisier))
            {
                // daca fisierul nu exista atunci il cream si si adaugam
                // o linie noua tu toate datele care vor fi pe coloane in caz ca il convertim

                using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, true))
                {
                    // putem folosi linia de mai jos in caz ca vrem sa convertim fisierul la unul csv sau excel 
                    // si sa avem denumirile coloanelor
                    // streamWriterFisierText.WriteLine("IDtranzactie;Firma;Model;AnFabricatie;Culoare;Optiuni;NumeCumparator;NumeVanzator;Pret;DataVanzare");

                }
            }
        }

       

        public void AddTranzactie(MasinaClass masina)
        {
            // instructiunea 'using' va apela la final streamWriterFisierText.Close();

            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier1, true))
            {
                if (masina.GetIDtranzactie() != 0)
                {
                    streamWriterFisierText.WriteLine(masina.ConversieLaSir_PentruFisier());
                }
            }
        }


        
    public List<MasinaClass> GetTranzactii()
        {
            List<MasinaClass> tranzactii = new List<MasinaClass>();
            using (StreamReader streamReader = new StreamReader(numeFisier1))
            {
                string linieFisier;
                

                // citeste cate o linie si creaza un obiect de tip Student
                // pe baza datelor din linia citita
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    try
                    {
                        tranzactii.Add(new MasinaClass(linieFisier));
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error: {0}", e.Message);
                    }

                }
            }

            return tranzactii;
        }

        public IEnumerable<MasinaClass> Search(Func<MasinaClass, bool> predicate)
        {
            {
                List<MasinaClass> vanzari = GetTranzactii();
                foreach (MasinaClass masina in vanzari)
                {
                    if (predicate(masina))
                    {
                        yield return masina;
                    }
                }

            }
        }

        public void PrintVanzari(IEnumerable<MasinaClass> masini)
        {
            if (masini.Count() == 0)
            {
                Console.WriteLine("Nu au fost gasite vanzari dupa parametrii propusi");
            }
            else 
            {
                foreach (MasinaClass masina in masini)
                {
                    Console.WriteLine(masina);
                }
            }
        }
        //FUNCTIE PENTRU A MODIFICA DATELE IN FISIER
        public void UpdateProperty(List<MasinaClass> changes, int id_del, object new_value, string property_name)
        {
            foreach (MasinaClass masina in changes)
            {
                if (masina.IDtranzactie == id_del)
                {
                    Type type = typeof(MasinaClass);
                    PropertyInfo propInfo = type.GetProperty(property_name);

                    propInfo.SetValue(masina, new_value);
                }
            }
        }
        public int GetLastId()
        {
            int id = 0;
            List<MasinaClass> listMasini = GetTranzactii();
            if (listMasini.Count > 0)
            {
                id = listMasini[listMasini.Count - 1].IDtranzactie;
                // Use the lastID as needed
            }
            return id;
        }


    }

}
