using AdministrareVanzariTxt;

using Masina;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Formsuri
{
    public partial class Chart : Form
    {
        public Chart()
        {
            InitializeComponent();
         
        }

        private void Chart_Load(object sender, EventArgs e)
        {

            chartStatistica.Series.Add("Pret");
            chartStatistica.Series["Pret"].ChartType = SeriesChartType.Line;
            chartStatistica.Series["Pret"].XValueType = ChartValueType.DateTime;
            chartStatistica.Series["Pret"].ChartArea = "ChartArea1";
            chartStatistica.Series["Pret"].BorderWidth = 2;
            chartStatistica.Series["Pret"].MarkerStyle = MarkerStyle.Circle;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonCauta_Click(object sender, EventArgs e)
        {
            bool hasError = false;
            if (string.IsNullOrEmpty(textBoxMarca.Text))
            {
                errorProvider1.SetError(textBoxMarca, "Nu ati introdus marca");
                hasError = true;
            }
            else
            {
                errorProvider1.Clear();
            }
            if (string.IsNullOrEmpty(textBoxModel.Text))
            {
                errorProvider2.SetError(textBoxModel, "Nu ati introdus modelul");
                hasError = true;
            }
            else
            {
                errorProvider2.Clear();
            }
            if (hasError==false) 
            {
                Database admin = new Database("C:\\Users\\Igor\\source\\repos\\TargMasini\\Test.txt");
                List<MasinaClass> lista = admin.GetTranzactii();
               
                foreach (MasinaClass c in lista)
                {

                    if (c.Firma.ToLower() == textBoxMarca.Text.ToLower() && c.Model.ToLower() == textBoxModel.Text.ToLower() && dateTimePickerFrom.Value.Date <= c.DataVanzare.Date && dateTimePickerTo.Value.Date >= c.DataVanzare.Date)
                    {
                        chartStatistica.Series["Pret"].Points.AddXY(c.DataVanzare, c.Pret);
                    }

                }
                chartStatistica.Refresh();
            }

        }
    }
}
