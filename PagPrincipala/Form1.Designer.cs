namespace Forms
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panouStanga = new Panel();
            buttonStatistica = new Button();
            buttonBaza = new Button();
            panouLogo = new Panel();
            logoName = new Label();
            panelSus = new Panel();
            btnCloseChildForm = new Button();
            acasaText = new Label();
            panelDesktop = new Panel();
            panouStanga.SuspendLayout();
            panouLogo.SuspendLayout();
            panelSus.SuspendLayout();
            SuspendLayout();
            // 
            // panouStanga
            // 
            panouStanga.BackColor = Color.FromArgb(51, 51, 90);
            panouStanga.Controls.Add(buttonStatistica);
            panouStanga.Controls.Add(buttonBaza);
            panouStanga.Controls.Add(panouLogo);
            panouStanga.Dock = DockStyle.Left;
            panouStanga.Location = new Point(0, 0);
            panouStanga.Name = "panouStanga";
            panouStanga.Size = new Size(128, 648);
            panouStanga.TabIndex = 0;
            // 
            // buttonStatistica
            // 
            buttonStatistica.Dock = DockStyle.Top;
            buttonStatistica.FlatAppearance.BorderSize = 0;
            buttonStatistica.FlatStyle = FlatStyle.Flat;
            buttonStatistica.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonStatistica.ForeColor = Color.Gainsboro;
            //buttonStatistica.Image = Properties.Resources.image__1___1_;
            buttonStatistica.ImageAlign = ContentAlignment.MiddleLeft;
            buttonStatistica.Location = new Point(0, 118);
            buttonStatistica.Name = "buttonStatistica";
            buttonStatistica.Padding = new Padding(10, 0, 0, 0);
            buttonStatistica.Size = new Size(128, 46);
            buttonStatistica.TabIndex = 2;
            buttonStatistica.Text = "  Stitistica";
            buttonStatistica.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonStatistica.UseVisualStyleBackColor = true;
            buttonStatistica.Click += buttonStatistica_Click;
            // 
            // buttonBaza
            // 
            buttonBaza.Dock = DockStyle.Top;
            buttonBaza.FlatAppearance.BorderSize = 0;
            buttonBaza.FlatStyle = FlatStyle.Flat;
            buttonBaza.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonBaza.ForeColor = Color.Gainsboro;
           // buttonBaza.Image = Properties.Resources.image__2_;
            buttonBaza.ImageAlign = ContentAlignment.MiddleLeft;
            buttonBaza.Location = new Point(0, 72);
            buttonBaza.Name = "buttonBaza";
            buttonBaza.Padding = new Padding(10, 0, 0, 0);
            buttonBaza.Size = new Size(128, 46);
            buttonBaza.TabIndex = 1;
            buttonBaza.Text = "  Baza";
            buttonBaza.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonBaza.UseVisualStyleBackColor = true;
            buttonBaza.Click += buttonBaza_Click;
            // 
            // panouLogo
            // 
            panouLogo.BackColor = Color.FromArgb(39, 39, 58);
            panouLogo.Controls.Add(logoName);
            panouLogo.Dock = DockStyle.Top;
            panouLogo.Location = new Point(0, 0);
            panouLogo.Name = "panouLogo";
            panouLogo.Size = new Size(128, 72);
            panouLogo.TabIndex = 0;
            // 
            // logoName
            // 
            logoName.AutoSize = true;
            logoName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            logoName.ForeColor = Color.Gainsboro;
            logoName.Location = new Point(36, 27);
            logoName.Name = "logoName";
            logoName.Size = new Size(43, 21);
            logoName.TabIndex = 0;
            logoName.Text = "Târg";
            // 
            // panelSus
            // 
            panelSus.BackColor = Color.FromArgb(0, 150, 136);
            panelSus.Controls.Add(btnCloseChildForm);
            panelSus.Controls.Add(acasaText);
            panelSus.Dock = DockStyle.Top;
            panelSus.Location = new Point(128, 0);
            panelSus.Name = "panelSus";
            panelSus.Size = new Size(1014, 72);
            panelSus.TabIndex = 1;
            // 
            // btnCloseChildForm
            // 
            btnCloseChildForm.FlatAppearance.BorderSize = 0;
            btnCloseChildForm.FlatStyle = FlatStyle.Flat;
            //btnCloseChildForm.Image = Properties.Resources._648760621674742991_128__1_;
            btnCloseChildForm.Location = new Point(6, 20);
            btnCloseChildForm.Name = "btnCloseChildForm";
            btnCloseChildForm.Size = new Size(31, 39);
            btnCloseChildForm.TabIndex = 1;
            btnCloseChildForm.UseVisualStyleBackColor = true;
            btnCloseChildForm.Click += btnCloseChildForm_Click_1;
            // 
            // acasaText
            // 
            acasaText.AutoSize = true;
            acasaText.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            acasaText.ForeColor = Color.Gainsboro;
            acasaText.Location = new Point(451, 14);
            acasaText.Name = "acasaText";
            acasaText.Size = new Size(91, 37);
            acasaText.TabIndex = 0;
            acasaText.Text = "Acasă";
            acasaText.Click += label1_Click;
            // 
            // panelDesktop
            // 
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(128, 72);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(1014, 576);
            panelDesktop.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1142, 648);
            Controls.Add(panelDesktop);
            Controls.Add(panelSus);
            Controls.Add(panouStanga);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panouStanga.ResumeLayout(false);
            panouLogo.ResumeLayout(false);
            panouLogo.PerformLayout();
            panelSus.ResumeLayout(false);
            panelSus.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panouStanga;
        private Panel panouLogo;
        private Button buttonStatistica;
        private Button buttonBaza;
        private Panel panelSus;
        private Label logoName;
        private Label acasaText;
        private Panel panelDesktop;
        private Button btnCloseChildForm;
    }
}