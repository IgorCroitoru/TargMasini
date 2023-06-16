namespace Forms
{
    partial class ModificareTranzactie
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
            components = new System.ComponentModel.Container();
            buttonModifica = new Button();
            dateTimePicker1 = new DateTimePicker();
            textBoxFabricatie = new TextBox();
            lblAnFabr = new Label();
            lblDataTranz = new Label();
            textBoxSpecificatii = new TextBox();
            label6 = new Label();
            textBoxPret = new TextBox();
            lblPret = new Label();
            textBoxCuloare = new TextBox();
            lblCuloare = new Label();
            textBoxModel = new TextBox();
            lblModel = new Label();
            textBoxMarca = new TextBox();
            lblMarca = new Label();
            textBoxCumparator = new TextBox();
            lblCumparator = new Label();
            textBoxVanzator = new TextBox();
            lblVanzator = new Label();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            errorProvider3 = new ErrorProvider(components);
            errorProvider4 = new ErrorProvider(components);
            errorProvider5 = new ErrorProvider(components);
            errorProvider6 = new ErrorProvider(components);
            errorProvider7 = new ErrorProvider(components);
            errorProvider8 = new ErrorProvider(components);
            errorProvider9 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider9).BeginInit();
            SuspendLayout();
            // 
            // buttonModifica
            // 
            buttonModifica.BackColor = Color.FromArgb(0, 192, 192);
            buttonModifica.FlatAppearance.BorderSize = 0;
            buttonModifica.FlatStyle = FlatStyle.Flat;
            buttonModifica.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonModifica.ForeColor = SystemColors.ControlLightLight;
            buttonModifica.Location = new Point(63, 508);
            buttonModifica.Name = "buttonModifica";
            buttonModifica.Size = new Size(167, 36);
            buttonModifica.TabIndex = 38;
            buttonModifica.Text = "Modifica";
            buttonModifica.UseVisualStyleBackColor = false;
            buttonModifica.Click += buttonModifica_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.AccessibleRole = AccessibleRole.None;
            dateTimePicker1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePicker1.CalendarFont = new Font("Sitka Banner", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePicker1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.ImeMode = ImeMode.NoControl;
            dateTimePicker1.Location = new Point(63, 466);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(108, 27);
            dateTimePicker1.TabIndex = 37;
            // 
            // textBoxFabricatie
            // 
            textBoxFabricatie.Location = new Point(63, 255);
            textBoxFabricatie.Name = "textBoxFabricatie";
            textBoxFabricatie.Size = new Size(167, 23);
            textBoxFabricatie.TabIndex = 36;
            // 
            // lblAnFabr
            // 
            lblAnFabr.AutoSize = true;
            lblAnFabr.Font = new Font("Sitka Small", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblAnFabr.ForeColor = SystemColors.Control;
            lblAnFabr.Location = new Point(63, 232);
            lblAnFabr.Name = "lblAnFabr";
            lblAnFabr.Size = new Size(106, 20);
            lblAnFabr.TabIndex = 35;
            lblAnFabr.Text = "An fabricatie:";
            // 
            // lblDataTranz
            // 
            lblDataTranz.AutoSize = true;
            lblDataTranz.Font = new Font("Sitka Small", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblDataTranz.ForeColor = SystemColors.Control;
            lblDataTranz.Location = new Point(63, 443);
            lblDataTranz.Name = "lblDataTranz";
            lblDataTranz.Size = new Size(127, 20);
            lblDataTranz.TabIndex = 34;
            lblDataTranz.Text = "Data tranzactiei:";
            // 
            // textBoxSpecificatii
            // 
            textBoxSpecificatii.Location = new Point(63, 402);
            textBoxSpecificatii.Multiline = true;
            textBoxSpecificatii.Name = "textBoxSpecificatii";
            textBoxSpecificatii.Size = new Size(167, 38);
            textBoxSpecificatii.TabIndex = 33;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Small", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(63, 379);
            label6.Name = "label6";
            label6.Size = new Size(93, 20);
            label6.TabIndex = 32;
            label6.Text = "Specificatii:";
            // 
            // textBoxPret
            // 
            textBoxPret.Location = new Point(63, 353);
            textBoxPret.Name = "textBoxPret";
            textBoxPret.Size = new Size(167, 23);
            textBoxPret.TabIndex = 31;
            // 
            // lblPret
            // 
            lblPret.AutoSize = true;
            lblPret.Font = new Font("Sitka Small", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblPret.ForeColor = SystemColors.Control;
            lblPret.Location = new Point(63, 330);
            lblPret.Name = "lblPret";
            lblPret.Size = new Size(44, 20);
            lblPret.TabIndex = 30;
            lblPret.Text = "Pret:";
            // 
            // textBoxCuloare
            // 
            textBoxCuloare.Location = new Point(63, 304);
            textBoxCuloare.Name = "textBoxCuloare";
            textBoxCuloare.Size = new Size(167, 23);
            textBoxCuloare.TabIndex = 29;
            // 
            // lblCuloare
            // 
            lblCuloare.AutoSize = true;
            lblCuloare.Font = new Font("Sitka Small", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblCuloare.ForeColor = SystemColors.Control;
            lblCuloare.Location = new Point(63, 281);
            lblCuloare.Name = "lblCuloare";
            lblCuloare.Size = new Size(68, 20);
            lblCuloare.TabIndex = 28;
            lblCuloare.Text = "Culoare:";
            // 
            // textBoxModel
            // 
            textBoxModel.Location = new Point(63, 208);
            textBoxModel.Name = "textBoxModel";
            textBoxModel.Size = new Size(167, 23);
            textBoxModel.TabIndex = 27;
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Font = new Font("Sitka Small", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblModel.ForeColor = SystemColors.Control;
            lblModel.Location = new Point(63, 185);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(58, 20);
            lblModel.TabIndex = 26;
            lblModel.Text = "Model:";
            // 
            // textBoxMarca
            // 
            textBoxMarca.Location = new Point(63, 159);
            textBoxMarca.Name = "textBoxMarca";
            textBoxMarca.Size = new Size(167, 23);
            textBoxMarca.TabIndex = 25;
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Font = new Font("Sitka Small", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblMarca.ForeColor = SystemColors.Control;
            lblMarca.Location = new Point(63, 136);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(58, 20);
            lblMarca.TabIndex = 24;
            lblMarca.Text = "Marca:";
            // 
            // textBoxCumparator
            // 
            textBoxCumparator.Location = new Point(63, 110);
            textBoxCumparator.Name = "textBoxCumparator";
            textBoxCumparator.Size = new Size(167, 23);
            textBoxCumparator.TabIndex = 23;
            // 
            // lblCumparator
            // 
            lblCumparator.AutoSize = true;
            lblCumparator.Font = new Font("Sitka Small", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblCumparator.ForeColor = SystemColors.Control;
            lblCumparator.Location = new Point(63, 87);
            lblCumparator.Name = "lblCumparator";
            lblCumparator.Size = new Size(144, 20);
            lblCumparator.TabIndex = 22;
            lblCumparator.Text = "Nume Cumparator:";
            // 
            // textBoxVanzator
            // 
            textBoxVanzator.Location = new Point(63, 61);
            textBoxVanzator.Name = "textBoxVanzator";
            textBoxVanzator.Size = new Size(167, 23);
            textBoxVanzator.TabIndex = 21;
            // 
            // lblVanzator
            // 
            lblVanzator.AutoSize = true;
            lblVanzator.Font = new Font("Sitka Small", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblVanzator.ForeColor = SystemColors.Control;
            lblVanzator.Location = new Point(63, 38);
            lblVanzator.Name = "lblVanzator";
            lblVanzator.Size = new Size(122, 20);
            lblVanzator.TabIndex = 20;
            lblVanzator.Text = "Nume Vanzator:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            errorProvider4.ContainerControl = this;
            // 
            // errorProvider5
            // 
            errorProvider5.ContainerControl = this;
            // 
            // errorProvider6
            // 
            errorProvider6.ContainerControl = this;
            // 
            // errorProvider7
            // 
            errorProvider7.ContainerControl = this;
            // 
            // errorProvider8
            // 
            errorProvider8.ContainerControl = this;
            // 
            // errorProvider9
            // 
            errorProvider9.ContainerControl = this;
            // 
            // ModificareTranzactie
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 51, 90);
            ClientSize = new Size(292, 583);
            Controls.Add(buttonModifica);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBoxFabricatie);
            Controls.Add(lblAnFabr);
            Controls.Add(lblDataTranz);
            Controls.Add(textBoxSpecificatii);
            Controls.Add(label6);
            Controls.Add(textBoxPret);
            Controls.Add(lblPret);
            Controls.Add(textBoxCuloare);
            Controls.Add(lblCuloare);
            Controls.Add(textBoxModel);
            Controls.Add(lblModel);
            Controls.Add(textBoxMarca);
            Controls.Add(lblMarca);
            Controls.Add(textBoxCumparator);
            Controls.Add(lblCumparator);
            Controls.Add(textBoxVanzator);
            Controls.Add(lblVanzator);
            Name = "ModificareTranzactie";
            Text = "ModificareTranzactie";
            Load += ModificareTranzactie_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider4).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider5).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider6).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider7).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider8).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider9).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonModifica;
        private DateTimePicker dateTimePicker1;
        private TextBox textBoxFabricatie;
        private Label lblAnFabr;
        private Label lblDataTranz;
        private TextBox textBoxSpecificatii;
        private Label label6;
        private TextBox textBoxPret;
        private Label lblPret;
        private TextBox textBoxCuloare;
        private Label lblCuloare;
        private TextBox textBoxModel;
        private Label lblModel;
        private TextBox textBoxMarca;
        private Label lblMarca;
        private TextBox textBoxCumparator;
        private Label lblCumparator;
        private TextBox textBoxVanzator;
        private Label lblVanzator;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private ErrorProvider errorProvider3;
        private ErrorProvider errorProvider4;
        private ErrorProvider errorProvider5;
        private ErrorProvider errorProvider6;
        private ErrorProvider errorProvider7;
        private ErrorProvider errorProvider8;
        private ErrorProvider errorProvider9;
    }
}