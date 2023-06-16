using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using AdministrareVanzariTxt;
using Masina;
namespace Formsuri
{
    public delegate void ButtonModificaClickedEventHandler(object sender, EventArgs e);
    public partial class ModificareTranzactie : Form
    {
        public event ButtonModificaClickedEventHandler ButtonModificaClicked;
       
        //public event EventHandler ButtonClicked;
        private string filePath = "C:\\Users\\Igor\\source\\repos\\TargMasini\\Test.txt";
        private string vanzator = string.Empty;
        private string cumparator = string.Empty;
        private string specificatii = string.Empty;
        private int an = 0;
        private float pret = 0;
        private string culoare = string.Empty;
        private DateTime data;
        private string marca = string.Empty;
        private string model = string.Empty;
        private int id = 0;
        public ModificareTranzactie()
        {
            InitializeComponent();
        }

        public ModificareTranzactie(MasinaClass masina)
        {
            this.vanzator = masina.NumeVanzator;
            this.cumparator = masina.NumeCumparator;
            this.specificatii = masina.Optiuni;
            this.an = masina.AnFabricatie;
            this.model = masina.Model;
            this.culoare = masina.Culoare;
            this.marca = masina.Firma;
            this.data = masina.DataVanzare;
            this.pret = masina.Pret;
            this.id = masina.IDtranzactie;

            InitializeComponent();
        }


       

      

        private void panelAdd_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ModificareTranzactie_Load_1(object sender, EventArgs e)
        {
            textBoxCuloare.Text = culoare;
            textBoxCumparator.Text = cumparator;
            textBoxFabricatie.Text = Convert.ToString(an);
            textBoxMarca.Text = marca;
            textBoxModel.Text = model;
            textBoxVanzator.Text = vanzator;
            textBoxSpecificatii.Text = specificatii;
            dateTimePicker1.Value = data;
            textBoxPret.Text = pret.ToString();

        }

        public void buttonModifica_Click_1(object sender, EventArgs e)
        {
            bool hasErrors = false;
            //VALIDAREA DATELOR
            if (string.IsNullOrEmpty(textBoxVanzator.Text) || textBoxVanzator.Text.Split(' ').Length < 2)
            {
                errorProvider1.SetError(textBoxVanzator, "Introdu numele vanzatorului");
                hasErrors = true;
            }
            else
            {
                errorProvider1.Clear();
            }
            if (string.IsNullOrEmpty(textBoxCumparator.Text) || textBoxCumparator.Text.Split(' ').Length < 2)
            {

                errorProvider2.SetError(textBoxCumparator, "Introdu numele cumparatorului");
                hasErrors = true;

            }
            else
            {
                errorProvider2.Clear();
            }
            if (string.IsNullOrEmpty(textBoxCuloare.Text))
            {
                errorProvider3.SetError(textBoxCuloare, "Introdu culoarea");
                hasErrors = true;
            }
            else
            {
                errorProvider3.Clear();
            }
            if (string.IsNullOrEmpty(textBoxFabricatie.Text))
            {
                errorProvider4.SetError(textBoxFabricatie, "Introdu anul fabricarii");
                hasErrors = true;

            }
            else
            {
                errorProvider4.Clear();
            }
            if (int.TryParse(textBoxFabricatie.Text, out int yearValue) && textBoxFabricatie.Text.Length == 4)
            {
                errorProvider8.Clear();
            }
            else
            {
                hasErrors = true;
                errorProvider8.SetError(textBoxFabricatie, "Introdu anul corect");
            }
            if (int.TryParse(textBoxPret.Text, out int pretValue))
            {
                errorProvider9.Clear();
            }
            else
            {
                hasErrors = true;
                errorProvider9.SetError(textBoxPret, "Introdu pretul corect");
            }
            if (string.IsNullOrEmpty(textBoxMarca.Text))
            {
                errorProvider5.SetError(textBoxMarca, "Introdu marca automobilului");
                hasErrors = true;
            }
            else
            {
                errorProvider5.Clear();
            }
            if (string.IsNullOrEmpty(textBoxModel.Text))
            {
                errorProvider6.SetError(textBoxModel, "Introdu modelul automobilului");
                hasErrors = true;

            }
            else
            {
                errorProvider6.Clear();
            }
            if (string.IsNullOrEmpty(textBoxPret.Text))
            {
                errorProvider7.SetError(textBoxPret, "Introdu pretul");
                hasErrors = true;
            }
            else
            {
                errorProvider7.Clear();

            }
            if (hasErrors == false)
            {

                Database adminVanzari = new Database(filePath);
                MasinaClass masina = new MasinaClass();
                List<MasinaClass> listMasini = new List<MasinaClass>();
                masina.IDtranzactie = id;
                masina.Culoare = textBoxCuloare.Text;
                masina.AnFabricatie = Convert.ToInt32(textBoxFabricatie.Text);
                masina.Pret = Convert.ToInt32(textBoxPret.Text);
                masina.NumeCumparator = textBoxCumparator.Text;
                masina.NumeVanzator = textBoxVanzator.Text;
                masina.Optiuni = textBoxSpecificatii.Text;
                masina.Model = textBoxModel.Text;
                masina.Firma = textBoxMarca.Text;
                masina.DataVanzare = DateTime.ParseExact(dateTimePicker1.Text, "dd.MM.yyyy", CultureInfo.InvariantCulture);
                listMasini = adminVanzari.GetTranzactii();

                //inlocuieste in lista masina modificata
                for (int i = 0; i < listMasini.Count; i++)
                {
                    if (listMasini[i].IDtranzactie == id)
                    {
                        listMasini[i] = masina;
                        break;
                    }
                }
                //CURATA FISIERUL INAINTE DE A ADAUGA TOATA LISTA
                File.WriteAllText(filePath, string.Empty);
                foreach (var masinaAdd in listMasini)
                {
                    adminVanzari.AddTranzactie(masinaAdd);
                }
                //adminVanzari.AddTranzactie(masina);
                textBoxCuloare.Clear();
                textBoxCumparator.Clear();
                textBoxFabricatie.Clear();
                textBoxMarca.Clear();
                textBoxModel.Clear();
                textBoxPret.Clear();
                textBoxVanzator.Clear();
                textBoxSpecificatii.Clear();
                FormaBazaDate formaBaza = new FormaBazaDate();
                ButtonModificaClicked?.Invoke(this, EventArgs.Empty);
                formaBaza.RefreshGrid(adminVanzari.GetTranzactii());
                formaBaza.UpdateList();
                this.Close();



            }
        }
    }
}
