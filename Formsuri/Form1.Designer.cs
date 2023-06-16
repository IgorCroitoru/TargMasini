namespace Formsuri
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
            this.panelSus = new System.Windows.Forms.Panel();
            this.panouStanga = new System.Windows.Forms.Panel();
            this.panouLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBaza = new System.Windows.Forms.Button();
            this.acasaText = new System.Windows.Forms.Label();
            this.buttonStatistica = new System.Windows.Forms.Button();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.btnCloseChildForm = new System.Windows.Forms.PictureBox();
            this.panelSus.SuspendLayout();
            this.panouStanga.SuspendLayout();
            this.panouLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseChildForm)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSus
            // 
            this.panelSus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelSus.Controls.Add(this.btnCloseChildForm);
            this.panelSus.Controls.Add(this.acasaText);
            this.panelSus.Location = new System.Drawing.Point(128, 0);
            this.panelSus.Name = "panelSus";
            this.panelSus.Size = new System.Drawing.Size(1014, 72);
            this.panelSus.TabIndex = 1;
            // 
            // panouStanga
            // 
            this.panouStanga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(90)))));
            this.panouStanga.Controls.Add(this.buttonStatistica);
            this.panouStanga.Controls.Add(this.panouLogo);
            this.panouStanga.Controls.Add(this.buttonBaza);
            this.panouStanga.Location = new System.Drawing.Point(0, 0);
            this.panouStanga.Name = "panouStanga";
            this.panouStanga.Size = new System.Drawing.Size(128, 648);
            this.panouStanga.TabIndex = 0;
            // 
            // panouLogo
            // 
            this.panouLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panouLogo.Controls.Add(this.label1);
            this.panouLogo.Location = new System.Drawing.Point(0, 0);
            this.panouLogo.Name = "panouLogo";
            this.panouLogo.Size = new System.Drawing.Size(128, 72);
            this.panouLogo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(36, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Targ";
            // 
            // buttonBaza
            // 
            this.buttonBaza.FlatAppearance.BorderSize = 0;
            this.buttonBaza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBaza.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonBaza.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonBaza.Location = new System.Drawing.Point(0, 72);
            this.buttonBaza.Name = "buttonBaza";
            this.buttonBaza.Size = new System.Drawing.Size(128, 46);
            this.buttonBaza.TabIndex = 1;
            this.buttonBaza.Text = "Baza";
            this.buttonBaza.UseVisualStyleBackColor = true;
            this.buttonBaza.Click += new System.EventHandler(this.buttonBaza_Click_1);
            // 
            // acasaText
            // 
            this.acasaText.AutoSize = true;
            this.acasaText.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.acasaText.ForeColor = System.Drawing.SystemColors.Control;
            this.acasaText.Location = new System.Drawing.Point(451, 14);
            this.acasaText.Name = "acasaText";
            this.acasaText.Size = new System.Drawing.Size(91, 37);
            this.acasaText.TabIndex = 3;
            this.acasaText.Text = "Acasa";
            // 
            // buttonStatistica
            // 
            this.buttonStatistica.FlatAppearance.BorderSize = 0;
            this.buttonStatistica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStatistica.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonStatistica.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonStatistica.Location = new System.Drawing.Point(0, 118);
            this.buttonStatistica.Name = "buttonStatistica";
            this.buttonStatistica.Size = new System.Drawing.Size(128, 46);
            this.buttonStatistica.TabIndex = 2;
            this.buttonStatistica.Text = "Statistica";
            this.buttonStatistica.UseVisualStyleBackColor = true;
            this.buttonStatistica.Click += new System.EventHandler(this.buttonStatistica_Click_1);
            // 
            // panelDesktop
            // 
            this.panelDesktop.Location = new System.Drawing.Point(128, 72);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1014, 576);
            this.panelDesktop.TabIndex = 2;
            // 
            // btnCloseChildForm
            // 
            this.btnCloseChildForm.Image = global::Formsuri.Properties.Resources._4177409791543238955_1281;
            this.btnCloseChildForm.Location = new System.Drawing.Point(6, 27);
            this.btnCloseChildForm.Name = "btnCloseChildForm";
            this.btnCloseChildForm.Size = new System.Drawing.Size(24, 20);
            this.btnCloseChildForm.TabIndex = 4;
            this.btnCloseChildForm.TabStop = false;
            this.btnCloseChildForm.Click += new System.EventHandler(this.btnCloseChildForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 648);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panouStanga);
            this.Controls.Add(this.panelSus);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelSus.ResumeLayout(false);
            this.panelSus.PerformLayout();
            this.panouStanga.ResumeLayout(false);
            this.panouLogo.ResumeLayout(false);
            this.panouLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseChildForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSus;
        private System.Windows.Forms.Panel panouStanga;
        private System.Windows.Forms.Panel panouLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBaza;
        private System.Windows.Forms.Label acasaText;
        private System.Windows.Forms.Button buttonStatistica;
        private System.Windows.Forms.PictureBox btnCloseChildForm;
        private System.Windows.Forms.Panel panelDesktop;
    }
}

