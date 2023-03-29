using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//clasa pentru obiect filtru
namespace ClassFilter
{
    public class Filter
    {
        public int IDtranzactie { set; get; }
        public string Firma { set; get; }
        public string Model { set; get; }
        public int AnFabricatie { set; get; }
        public string Culoare { set; get; }
        public string Optiuni { set; get; }
        public string NumeCumparator { set; get; }
        public string NumeVanzator { set; get; }
        public float Pret { set; get; }
        public float PretDela {set; get; }
        public float PretPanala { set; get; }
        public DateTime DataFrom { set; get; }
        public DateTime DataTo { set; get; }
    }
}
