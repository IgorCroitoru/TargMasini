using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AdministrareVanzariTxt;

using Masina;


namespace Forms
{
    public partial class FormaBazaDate : Form
    {
        Database adminVanzari = new Database("C:\\Users\\Igor\\source\\repos\\TargMasini\\Test.txt");
        private ErrorProvider errorProvider;
        string filePath = "C:\\Users\\Igor\\source\\repos\\TargMasini\\Test.txt";
        //List<MasinaClass> vanzari = new List<MasinaClass>();
        public FormaBazaDate()
        {

            InitializeComponent();
            errorProvider = new ErrorProvider();
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }



        private void FormaBazaDate_Load(object sender, EventArgs e)
        {
            List<MasinaClass> vanzari = adminVanzari.GetTranzactii();
            DataGridUpdate(vanzari);



        }
        private void DataGridUpdate(List<MasinaClass> data)
        {
            foreach (MasinaClass masina in data)
            {
                dataGridDate.Rows.Add(new object[] { masina.GetIDtranzactie(),
                    masina.Firma,
                    masina.Model,
                    masina.Culoare,
                    masina.AnFabricatie,
                    masina.Optiuni,
                    masina.NumeCumparator,
                    masina.NumeVanzator,
                    masina.Pret,
                    masina.DataVanzare.ToString("dd.MM.yyyy"),
                     });
            }
        }



        //BUTON ADAUGARE FISIER
        private void buttonAdauga_Click(object sender, EventArgs e)
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

                MasinaClass masina = new MasinaClass();

                masina.IDtranzactie = adminVanzari.GetLastId() + 1;
                masina.Culoare = textBoxCuloare.Text;
                masina.AnFabricatie = Convert.ToInt32(textBoxFabricatie.Text);
                masina.Pret = Convert.ToInt32(textBoxPret.Text);
                masina.NumeCumparator = textBoxCumparator.Text;
                masina.NumeVanzator = textBoxVanzator.Text;
                masina.Optiuni = textBoxSpecificatii.Text;
                masina.Model = textBoxModel.Text;
                masina.Firma = textBoxMarca.Text;
                masina.DataVanzare = DateTime.ParseExact(dateTimePicker1.Text, "dd.MM.yyyy", CultureInfo.InvariantCulture);
                adminVanzari.AddTranzactie(masina);

                textBoxCuloare.Clear();
                textBoxCumparator.Clear();
                textBoxFabricatie.Clear();
                textBoxMarca.Clear();
                textBoxModel.Clear();
                textBoxPret.Clear();
                textBoxVanzator.Clear();
                textBoxSpecificatii.Clear();


            }


        }



        private void buttonModifica_Click(object sender, EventArgs e)
        {
            MasinaClass masina = new MasinaClass();
            foreach (DataGridViewRow row in dataGridDate.SelectedRows)
            {
                masina.IDtranzactie = Convert.ToInt32(row.Cells[0].Value);
                masina.Firma = row.Cells[1].Value.ToString();
                masina.Model = row.Cells[2].Value.ToString();
                masina.Culoare = row.Cells[3].Value.ToString();
                masina.AnFabricatie = Convert.ToInt32(row.Cells[4].Value);
                masina.Optiuni = row.Cells[5].Value.ToString();
                masina.NumeCumparator = row.Cells[6].Value.ToString();
                masina.NumeVanzator = row.Cells[7].Value.ToString();
                masina.Pret = Convert.ToInt32(row.Cells[8].Value);
                masina.DataVanzare = DateTime.ParseExact(row.Cells[9].Value.ToString(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
            }
            ModificareTranzactie modificare = new ModificareTranzactie(masina);
            modificare.ShowDialog();
        }

        //butoanele nu sunt apasabile daca nu respecta conditii
        private void dataGridDate_SelectionChanged(object sender, EventArgs e)
        {
            buttonSterge.Enabled = dataGridDate.SelectedRows.Count > 0;
            buttonModifica.Enabled = dataGridDate.SelectedRows.Count == 1;
        }

        private void buttonSterge_Click(object sender, EventArgs e)
        {
            List<MasinaClass> list = adminVanzari.GetTranzactii();
            List<MasinaClass> itemsToRemove = new List<MasinaClass>();

            foreach (DataGridViewRow row in dataGridDate.SelectedRows)
            {
                int id = Convert.ToInt32(row.Cells[0].Value);

                foreach (var masina in list)
                {
                    if (masina.IDtranzactie == id)
                    {
                        itemsToRemove.Add(masina);
                    }
                }
            }

            foreach (var masinaToRemove in itemsToRemove)
            {
                list.Remove(masinaToRemove);
            }

            File.WriteAllText(filePath, string.Empty);
            foreach (var masina in list)
            {
                adminVanzari.AddTranzactie(masina);
            }

            RefreshGrid(adminVanzari.GetTranzactii());

        }

        public void RefreshGrid(List<MasinaClass> currentList)
        {
            dataGridDate.Rows.Clear();
            DataGridUpdate(currentList);
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            RefreshGrid(adminVanzari.GetTranzactii());
        }

        public List<MasinaClass> GetFromDate()
        {
            List<MasinaClass> list = new List<MasinaClass>();


            return list;
        }

        private void buttonDataTranzactii_Click(object sender, EventArgs e)
        {
            List<MasinaClass> newList = new List<MasinaClass>();
            DateTime date = datePickerInterval.Value;
            foreach (var masina in adminVanzari.GetTranzactii())
            {
                if (masina.DataVanzare.Date == date.Date)
                {
                    newList.Add(masina);
                }
            }
            RefreshGrid(newList);
        }


    }
}
