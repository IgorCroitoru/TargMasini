using Microsoft.Win32;

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masina
{
    public class MasinaClass
    {
        private const int IDTRANZACTIE = 0;
        private const int FIRMA = 1;
        private const int MODEL = 2;
        private const int CULOARE = 3;
        private const int ANFABRICATIE = 4;
        private const int OPTIUNI = 5;
        private const int NUMECUMPARATOR = 6;
        private const int NUMEVANZATOR = 7;
        private const int PRET = 8;
        private const int DATAVANZARE = 9;

        private char SEPARATOR_FISIER = ';';
        public int IDtranzactie { set; get; }
        public string Firma { set; get; }
        public string Model { set; get; }
        public int AnFabricatie { set; get; }
        public string Culoare { set; get; }
        public string Optiuni { set; get; }
        public string NumeCumparator { set; get; }
        public string NumeVanzator { set; get; }
        public float Pret { set; get; }
        public  DateTime DataVanzare { set; get; }



        public MasinaClass() { }

        public MasinaClass(string linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_FISIER);
            IDtranzactie = Convert.ToInt32(dateFisier[IDTRANZACTIE]);
            Firma = dateFisier[FIRMA];
            Model = dateFisier[MODEL];
            AnFabricatie = Convert.ToInt32(dateFisier[ANFABRICATIE]);
            Culoare = dateFisier[CULOARE];
            Optiuni = dateFisier[OPTIUNI];
            NumeCumparator = dateFisier[NUMECUMPARATOR];
            NumeVanzator = dateFisier[NUMEVANZATOR];
            Pret = Convert.ToSingle(dateFisier[PRET]);
            DataVanzare = DateTime.ParseExact(dateFisier[DATAVANZARE], "dd.MM.yyyy", CultureInfo.InvariantCulture);

        }

        //public string GetCumparator() { return NumeCumparator; }

        //public string GetVanzator() {  return NumeVanzator; }

        public int GetIDtranzactie() { return IDtranzactie; }
        
        public string ConversieLaSir_PentruFisier()
        {
            string FileObject = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}{0}{7}{0}{8}{0}{9}{0}{10}",
                SEPARATOR_FISIER,
                (IDtranzactie.ToString() ?? "0"),
                (Firma ?? "NECUNOSCUT"),
                (Model ?? "NECUNOSCUT"),
                (Culoare ?? "NECUNOSCUT"),
                (AnFabricatie.ToString() ?? "NECUNOSCUT"),
                (Optiuni ?? "NECUNOSCUT"),
                (NumeCumparator ?? "NECUNOSCUT"),
                (NumeVanzator ?? "NECUNOSCUT"),
                (Pret.ToString() ?? "0"),
                (DataVanzare.ToString("dd.MM.yyyy")) ?? "NECUNOSCUT");

            return FileObject;
        }
        public override string ToString()
        {
            return $"ID: {IDtranzactie}\nFirma: {Firma}\n" +
                   $"Model: {Model}\nCuloare: {Culoare}\n" +
                   $"An Fabricatir: {AnFabricatie}\nOptiuni: {Optiuni}\n" +
                   $"Nume Vanzator: {NumeVanzator}\nNume Cumparator: {NumeCumparator}\n" +
                   $"Pret: {Pret}\nData Vanzare: {DataVanzare.ToString("dd.MM.yyyy")}\n";

        }

    }
}
