namespace PagPrincipala
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            panouLateral = new Panel();
            btnStatistica = new Button();
            btnBaza = new Button();
            panelLogo = new Panel();
            panouLateral.SuspendLayout();
            SuspendLayout();
            // 
            // panouLateral
            // 
            panouLateral.BackColor = Color.FromArgb(51, 51, 76);
            panouLateral.Controls.Add(btnStatistica);
            panouLateral.Controls.Add(btnBaza);
            panouLateral.Controls.Add(panelLogo);
            panouLateral.Dock = DockStyle.Left;
            panouLateral.Location = new Point(0, 0);
            panouLateral.Name = "panouLateral";
            panouLateral.Size = new Size(129, 461);
            panouLateral.TabIndex = 0;
            panouLateral.UseWaitCursor = true;
            panouLateral.Paint += panel1_Paint;
            // 
            // btnStatistica
            // 
            btnStatistica.Dock = DockStyle.Top;
            btnStatistica.FlatAppearance.BorderSize = 0;
            btnStatistica.FlatStyle = FlatStyle.Flat;
            btnStatistica.ForeColor = Color.White;
            btnStatistica.Image = (Image)resources.GetObject("btnStatistica.Image");
            btnStatistica.ImageAlign = ContentAlignment.MiddleLeft;
            btnStatistica.Location = new Point(0, 118);
            btnStatistica.Name = "btnStatistica";
            btnStatistica.Padding = new Padding(10, 0, 0, 0);
            btnStatistica.Size = new Size(129, 64);
            btnStatistica.TabIndex = 1;
            btnStatistica.Text = "  Statistica";
            btnStatistica.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnStatistica.UseVisualStyleBackColor = true;
            btnStatistica.UseWaitCursor = true;
            btnStatistica.Click += btnStatistica_Click;
            // 
            // btnBaza
            // 
            btnBaza.Dock = DockStyle.Top;
            btnBaza.FlatAppearance.BorderSize = 0;
            btnBaza.FlatStyle = FlatStyle.Flat;
            btnBaza.ForeColor = Color.White;
            btnBaza.Image = (Image)resources.GetObject("btnBaza.Image");
            btnBaza.ImageAlign = ContentAlignment.MiddleLeft;
            btnBaza.Location = new Point(0, 56);
            btnBaza.Name = "btnBaza";
            btnBaza.Padding = new Padding(10, 0, 0, 0);
            btnBaza.Size = new Size(129, 62);
            btnBaza.TabIndex = 0;
            btnBaza.Text = "  Baza";
            btnBaza.TextAlign = ContentAlignment.MiddleRight;
            btnBaza.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBaza.UseVisualStyleBackColor = true;
            btnBaza.UseWaitCursor = true;
            btnBaza.Click += Form1_Load;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(129, 56);
            panelLogo.TabIndex = 0;
            panelLogo.UseWaitCursor = true;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 461);
            Controls.Add(panouLateral);
            Name = "MainMenu";
            Text = "PagPrincipala";
            TransparencyKey = Color.Olive;
            UseWaitCursor = true;
            panouLateral.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panouLateral;
        private Button btnBaza;
        private Panel panelLogo;
        private Button btnStatistica;
    }
}