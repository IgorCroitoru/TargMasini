using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Masina;
namespace AdministrareVanzariTxt
{
    public class Database
    {
        private string numeFisier = "Vanzari.txt";

        public Database(string numeFisier)
        {
            this.numeFisier = numeFisier;

            if (!File.Exists(numeFisier))
            {
                // daca fisierul nu exista atunci il cream si si adaugam
                // o linie noua tu toate datele care vor fi pe coloane in caz ca il convertim
                //la fisier csv/excel
                //Stream streamFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
               // streamFisierText.Close();

                using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, true))
                {
                    streamWriterFisierText.WriteLine("IDtranzactie;Firma;Model;AnFabricatie;Culoare;Optiuni;NumeCumparator;NumeVanzator;Pret;DataVanzare");

                }
            }
        }

        public void AddTranzactie(MasinaClass masina)
        {
            // instructiunea 'using' va apela la final streamWriterFisierText.Close();
            
            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, true))
            {
                if (masina.GetIDtranzactie() != 0)
                {
                    streamWriterFisierText.WriteLine(masina.ConversieLaSir_PentruFisier());
                }
            }
        }
        public MasinaClass[] GetTranzactii(int nrVanz)
        {
            MasinaClass[] tranzactii = new MasinaClass[nrVanz];
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;
                int contor = 0;

                // citeste cate o linie si creaza un obiect de tip Student
                // pe baza datelor din linia citita
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    try
                    {
                        tranzactii[contor++] = new MasinaClass(linieFisier);
                    }
                    catch (Exception e) 
                    {
                        contor--;
                        Console.WriteLine("Error: {0}", e.Message);
                    }
                    //tranzactii[contor++] = new MasinaClass(linieFisier);
                }
            }


            return tranzactii;
        }
    }
    
}
