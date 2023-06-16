using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formsuri
{
    public partial class Form1 : Form
    {
        private Button currentButton;
        private Form activeForm;
        public Form1()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = Color.FromArgb(0, 150, 136);
                    currentButton = (Button)btnSender;
                    currentButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
                    currentButton.BackColor = color;
                    btnCloseChildForm.Visible = true;


                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panouStanga.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            acasaText.Location = new Point(435, 14);
            acasaText.Text = childForm.Text;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            btnCloseChildForm.Visible = false;
        }

        private void buttonBaza_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormaBazaDate(), sender);
            acasaText.Location = new Point(435, 14);

        }

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Reset()
        {
            DisableButton();
            acasaText.Text = "Acasa";
            panelSus.BackColor = Color.FromArgb(0, 150, 136);
            //panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            btnCloseChildForm.Visible = false;
        }

        private void btnCloseChildForm_Click_1(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

        private void buttonBaza_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new FormaBazaDate(), sender);
        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

        private void buttonStatistica_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Chart(), sender);
        }
    }
   }
