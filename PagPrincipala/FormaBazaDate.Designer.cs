namespace Forms
{
    partial class FormaBazaDate
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panelAdd = new Panel();
            buttonAdauga = new Button();
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
            dataGridDate = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            ColMarca = new DataGridViewTextBoxColumn();
            ColModel = new DataGridViewTextBoxColumn();
            ColCuloare = new DataGridViewTextBoxColumn();
            ColAnFabr = new DataGridViewTextBoxColumn();
            Optiuni = new DataGridViewTextBoxColumn();
            ColCumparator = new DataGridViewTextBoxColumn();
            ColVanzator = new DataGridViewTextBoxColumn();
            ColPret = new DataGridViewTextBoxColumn();
            ColDataTranz = new DataGridViewTextBoxColumn();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            errorProvider3 = new ErrorProvider(components);
            errorProvider4 = new ErrorProvider(components);
            errorProvider5 = new ErrorProvider(components);
            errorProvider6 = new ErrorProvider(components);
            errorProvider7 = new ErrorProvider(components);
            errorProvider8 = new ErrorProvider(components);
            errorProvider9 = new ErrorProvider(components);
            buttonModifica = new CustomControls.RJControls.RJButton();
            buttonSterge = new CustomControls.RJControls.RJButton();
            buttonRefresh = new CustomControls.RJControls.RJButton();
            datePickerInterval = new DateTimePicker();
            buttonDataTranzactii = new CustomControls.RJControls.RJButton();
            panelAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridDate).BeginInit();
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
            // panelAdd
            // 
            panelAdd.BackColor = Color.FromArgb(51, 51, 90);
            panelAdd.Controls.Add(buttonAdauga);
            panelAdd.Controls.Add(dateTimePicker1);
            panelAdd.Controls.Add(textBoxFabricatie);
            panelAdd.Controls.Add(lblAnFabr);
            panelAdd.Controls.Add(lblDataTranz);
            panelAdd.Controls.Add(textBoxSpecificatii);
            panelAdd.Controls.Add(label6);
            panelAdd.Controls.Add(textBoxPret);
            panelAdd.Controls.Add(lblPret);
            panelAdd.Controls.Add(textBoxCuloare);
            panelAdd.Controls.Add(lblCuloare);
            panelAdd.Controls.Add(textBoxModel);
            panelAdd.Controls.Add(lblModel);
            panelAdd.Controls.Add(textBoxMarca);
            panelAdd.Controls.Add(lblMarca);
            panelAdd.Controls.Add(textBoxCumparator);
            panelAdd.Controls.Add(lblCumparator);
            panelAdd.Controls.Add(textBoxVanzator);
            panelAdd.Controls.Add(lblVanzator);
            panelAdd.Dock = DockStyle.Right;
            panelAdd.Location = new Point(777, 0);
            panelAdd.Name = "panelAdd";
            panelAdd.Size = new Size(221, 577);
            panelAdd.TabIndex = 0;
            // 
            // buttonAdauga
            // 
            buttonAdauga.BackColor = Color.FromArgb(0, 192, 192);
            buttonAdauga.FlatAppearance.BorderSize = 0;
            buttonAdauga.FlatStyle = FlatStyle.Flat;
            buttonAdauga.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAdauga.ForeColor = SystemColors.ControlLightLight;
            buttonAdauga.Location = new Point(21, 503);
            buttonAdauga.Name = "buttonAdauga";
            buttonAdauga.Size = new Size(167, 36);
            buttonAdauga.TabIndex = 19;
            buttonAdauga.Text = "Adauga";
            buttonAdauga.UseVisualStyleBackColor = false;
            buttonAdauga.Click += buttonAdauga_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.AccessibleRole = AccessibleRole.None;
            dateTimePicker1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePicker1.CalendarFont = new Font("Sitka Banner", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePicker1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.ImeMode = ImeMode.NoControl;
            dateTimePicker1.Location = new Point(21, 461);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(108, 27);
            dateTimePicker1.TabIndex = 18;
            // 
            // textBoxFabricatie
            // 
            textBoxFabricatie.Location = new Point(21, 250);
            textBoxFabricatie.Name = "textBoxFabricatie";
            textBoxFabricatie.Size = new Size(167, 23);
            textBoxFabricatie.TabIndex = 17;
            // 
            // lblAnFabr
            // 
            lblAnFabr.AutoSize = true;
            lblAnFabr.Font = new Font("Sitka Small", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblAnFabr.ForeColor = SystemColors.Control;
            lblAnFabr.Location = new Point(21, 227);
            lblAnFabr.Name = "lblAnFabr";
            lblAnFabr.Size = new Size(106, 20);
            lblAnFabr.TabIndex = 16;
            lblAnFabr.Text = "An fabricatie:";
            // 
            // lblDataTranz
            // 
            lblDataTranz.AutoSize = true;
            lblDataTranz.Font = new Font("Sitka Small", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblDataTranz.ForeColor = SystemColors.Control;
            lblDataTranz.Location = new Point(21, 438);
            lblDataTranz.Name = "lblDataTranz";
            lblDataTranz.Size = new Size(127, 20);
            lblDataTranz.TabIndex = 14;
            lblDataTranz.Text = "Data tranzactiei:";
            // 
            // textBoxSpecificatii
            // 
            textBoxSpecificatii.Location = new Point(21, 397);
            textBoxSpecificatii.Multiline = true;
            textBoxSpecificatii.Name = "textBoxSpecificatii";
            textBoxSpecificatii.Size = new Size(167, 38);
            textBoxSpecificatii.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Small", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(21, 374);
            label6.Name = "label6";
            label6.Size = new Size(93, 20);
            label6.TabIndex = 12;
            label6.Text = "Specificatii:";
            // 
            // textBoxPret
            // 
            textBoxPret.Location = new Point(21, 348);
            textBoxPret.Name = "textBoxPret";
            textBoxPret.Size = new Size(167, 23);
            textBoxPret.TabIndex = 11;
            // 
            // lblPret
            // 
            lblPret.AutoSize = true;
            lblPret.Font = new Font("Sitka Small", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblPret.ForeColor = SystemColors.Control;
            lblPret.Location = new Point(21, 325);
            lblPret.Name = "lblPret";
            lblPret.Size = new Size(44, 20);
            lblPret.TabIndex = 10;
            lblPret.Text = "Pret:";
            // 
            // textBoxCuloare
            // 
            textBoxCuloare.Location = new Point(21, 299);
            textBoxCuloare.Name = "textBoxCuloare";
            textBoxCuloare.Size = new Size(167, 23);
            textBoxCuloare.TabIndex = 9;
            // 
            // lblCuloare
            // 
            lblCuloare.AutoSize = true;
            lblCuloare.Font = new Font("Sitka Small", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblCuloare.ForeColor = SystemColors.Control;
            lblCuloare.Location = new Point(21, 276);
            lblCuloare.Name = "lblCuloare";
            lblCuloare.Size = new Size(68, 20);
            lblCuloare.TabIndex = 8;
            lblCuloare.Text = "Culoare:";
            // 
            // textBoxModel
            // 
            textBoxModel.Location = new Point(21, 203);
            textBoxModel.Name = "textBoxModel";
            textBoxModel.Size = new Size(167, 23);
            textBoxModel.TabIndex = 7;
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Font = new Font("Sitka Small", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblModel.ForeColor = SystemColors.Control;
            lblModel.Location = new Point(21, 180);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(58, 20);
            lblModel.TabIndex = 6;
            lblModel.Text = "Model:";
            // 
            // textBoxMarca
            // 
            textBoxMarca.Location = new Point(21, 154);
            textBoxMarca.Name = "textBoxMarca";
            textBoxMarca.Size = new Size(167, 23);
            textBoxMarca.TabIndex = 5;
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Font = new Font("Sitka Small", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblMarca.ForeColor = SystemColors.Control;
            lblMarca.Location = new Point(21, 131);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(58, 20);
            lblMarca.TabIndex = 4;
            lblMarca.Text = "Marca:";
            // 
            // textBoxCumparator
            // 
            textBoxCumparator.Location = new Point(21, 105);
            textBoxCumparator.Name = "textBoxCumparator";
            textBoxCumparator.Size = new Size(167, 23);
            textBoxCumparator.TabIndex = 3;
            // 
            // lblCumparator
            // 
            lblCumparator.AutoSize = true;
            lblCumparator.Font = new Font("Sitka Small", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblCumparator.ForeColor = SystemColors.Control;
            lblCumparator.Location = new Point(21, 82);
            lblCumparator.Name = "lblCumparator";
            lblCumparator.Size = new Size(144, 20);
            lblCumparator.TabIndex = 2;
            lblCumparator.Text = "Nume Cumparator:";
            // 
            // textBoxVanzator
            // 
            textBoxVanzator.Location = new Point(21, 56);
            textBoxVanzator.Name = "textBoxVanzator";
            textBoxVanzator.Size = new Size(167, 23);
            textBoxVanzator.TabIndex = 1;
            // 
            // lblVanzator
            // 
            lblVanzator.AutoSize = true;
            lblVanzator.Font = new Font("Sitka Small", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblVanzator.ForeColor = SystemColors.Control;
            lblVanzator.Location = new Point(21, 33);
            lblVanzator.Name = "lblVanzator";
            lblVanzator.Size = new Size(122, 20);
            lblVanzator.TabIndex = 0;
            lblVanzator.Text = "Nume Vanzator:";
            // 
            // dataGridDate
            // 
            dataGridDate.AllowUserToAddRows = false;
            dataGridDate.AllowUserToDeleteRows = false;
            dataGridDate.AllowUserToOrderColumns = true;
            dataGridDate.AllowUserToResizeColumns = false;
            dataGridDate.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridDate.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridDate.BackgroundColor = SystemColors.ButtonFace;
            dataGridDate.BorderStyle = BorderStyle.None;
            dataGridDate.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridDate.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(37, 150, 190);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(37, 150, 190);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridDate.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridDate.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridDate.Columns.AddRange(new DataGridViewColumn[] { Id, ColMarca, ColModel, ColCuloare, ColAnFabr, Optiuni, ColCumparator, ColVanzator, ColPret, ColDataTranz });
            dataGridDate.Dock = DockStyle.Bottom;
            dataGridDate.EnableHeadersVisualStyles = false;
            dataGridDate.GridColor = Color.LightGray;
            dataGridDate.Location = new Point(0, 33);
            dataGridDate.Name = "dataGridDate";
            dataGridDate.ReadOnly = true;
            dataGridDate.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridDate.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridDate.RowHeadersVisible = false;
            dataGridDate.RowHeadersWidth = 20;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Rubik", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(243, 227, 243);
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridDate.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridDate.RowTemplate.Height = 28;
            dataGridDate.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridDate.Size = new Size(777, 544);
            dataGridDate.TabIndex = 20;
            dataGridDate.SelectionChanged += dataGridDate_SelectionChanged;
            // 
            // Id
            // 
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Rubik", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Id.DefaultCellStyle = dataGridViewCellStyle3;
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 55;
            // 
            // ColMarca
            // 
            ColMarca.HeaderText = "Marca";
            ColMarca.Name = "ColMarca";
            ColMarca.ReadOnly = true;
            // 
            // ColModel
            // 
            ColModel.HeaderText = "Model";
            ColModel.Name = "ColModel";
            ColModel.ReadOnly = true;
            // 
            // ColCuloare
            // 
            ColCuloare.HeaderText = "Culoare";
            ColCuloare.Name = "ColCuloare";
            ColCuloare.ReadOnly = true;
            ColCuloare.Width = 95;
            // 
            // ColAnFabr
            // 
            ColAnFabr.HeaderText = "An Fabricatie";
            ColAnFabr.Name = "ColAnFabr";
            ColAnFabr.ReadOnly = true;
            ColAnFabr.Width = 95;
            // 
            // Optiuni
            // 
            Optiuni.HeaderText = "Optiuni";
            Optiuni.Name = "Optiuni";
            Optiuni.ReadOnly = true;
            // 
            // ColCumparator
            // 
            ColCumparator.HeaderText = "Cumparator";
            ColCumparator.Name = "ColCumparator";
            ColCumparator.ReadOnly = true;
            ColCumparator.Width = 110;
            // 
            // ColVanzator
            // 
            ColVanzator.HeaderText = "Vanzator";
            ColVanzator.Name = "ColVanzator";
            ColVanzator.ReadOnly = true;
            ColVanzator.Width = 110;
            // 
            // ColPret
            // 
            ColPret.HeaderText = "Pret";
            ColPret.Name = "ColPret";
            ColPret.ReadOnly = true;
            ColPret.Width = 66;
            // 
            // ColDataTranz
            // 
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            ColDataTranz.DefaultCellStyle = dataGridViewCellStyle4;
            ColDataTranz.HeaderText = "Data tranz.";
            ColDataTranz.Name = "ColDataTranz";
            ColDataTranz.ReadOnly = true;
            ColDataTranz.Width = 80;
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
            // buttonModifica
            // 
            buttonModifica.BackColor = Color.FromArgb(7, 48, 66);
            buttonModifica.BackgroundColor = Color.FromArgb(7, 48, 66);
            buttonModifica.BorderColor = Color.PaleVioletRed;
            buttonModifica.BorderRadius = 0;
            buttonModifica.BorderSize = 0;
            buttonModifica.FlatAppearance.BorderSize = 0;
            buttonModifica.FlatStyle = FlatStyle.Flat;
            buttonModifica.ForeColor = Color.White;
            buttonModifica.Location = new Point(0, 0);
            buttonModifica.Name = "buttonModifica";
            buttonModifica.Size = new Size(81, 32);
            buttonModifica.TabIndex = 22;
            buttonModifica.Text = "Modifica";
            buttonModifica.TextColor = Color.White;
            buttonModifica.UseVisualStyleBackColor = false;
            buttonModifica.Click += buttonModifica_Click;
            // 
            // buttonSterge
            // 
            buttonSterge.BackColor = Color.FromArgb(7, 48, 66);
            buttonSterge.BackgroundColor = Color.FromArgb(7, 48, 66);
            buttonSterge.BorderColor = Color.PaleVioletRed;
            buttonSterge.BorderRadius = 0;
            buttonSterge.BorderSize = 0;
            buttonSterge.FlatAppearance.BorderSize = 0;
            buttonSterge.FlatStyle = FlatStyle.Flat;
            buttonSterge.ForeColor = Color.White;
            buttonSterge.Location = new Point(87, 0);
            buttonSterge.Name = "buttonSterge";
            buttonSterge.Size = new Size(81, 32);
            buttonSterge.TabIndex = 23;
            buttonSterge.Text = "Sterge";
            buttonSterge.TextColor = Color.White;
            buttonSterge.UseVisualStyleBackColor = false;
            buttonSterge.Click += buttonSterge_Click;
            // 
            // buttonRefresh
            // 
            buttonRefresh.BackColor = Color.FromArgb(7, 48, 66);
            buttonRefresh.BackgroundColor = Color.FromArgb(7, 48, 66);
            buttonRefresh.BorderColor = Color.PaleVioletRed;
            buttonRefresh.BorderRadius = 0;
            buttonRefresh.BorderSize = 0;
            buttonRefresh.FlatAppearance.BorderSize = 0;
            buttonRefresh.FlatStyle = FlatStyle.Flat;
            buttonRefresh.ForeColor = Color.White;
            buttonRefresh.Location = new Point(174, 0);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(81, 32);
            buttonRefresh.TabIndex = 24;
            buttonRefresh.Text = "Refresh";
            buttonRefresh.TextColor = Color.White;
            buttonRefresh.UseVisualStyleBackColor = false;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // datePickerInterval
            // 
            datePickerInterval.Anchor = AnchorStyles.None;
            datePickerInterval.CalendarFont = new Font("Rubik", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            datePickerInterval.CustomFormat = "";
            datePickerInterval.Font = new Font("Rubik Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            datePickerInterval.Format = DateTimePickerFormat.Short;
            datePickerInterval.Location = new Point(664, 5);
            datePickerInterval.Name = "datePickerInterval";
            datePickerInterval.Size = new Size(107, 23);
            datePickerInterval.TabIndex = 25;
            // 
            // buttonDataTranzactii
            // 
            buttonDataTranzactii.BackColor = Color.FromArgb(7, 48, 66);
            buttonDataTranzactii.BackgroundColor = Color.FromArgb(7, 48, 66);
            buttonDataTranzactii.BorderColor = Color.PaleVioletRed;
            buttonDataTranzactii.BorderRadius = 0;
            buttonDataTranzactii.BorderSize = 0;
            buttonDataTranzactii.FlatAppearance.BorderSize = 0;
            buttonDataTranzactii.FlatStyle = FlatStyle.Flat;
            buttonDataTranzactii.ForeColor = Color.White;
            buttonDataTranzactii.Location = new Point(533, 0);
            buttonDataTranzactii.Name = "buttonDataTranzactii";
            buttonDataTranzactii.Size = new Size(112, 32);
            buttonDataTranzactii.TabIndex = 26;
            buttonDataTranzactii.Text = "Afiseaza din data:";
            buttonDataTranzactii.TextColor = Color.White;
            buttonDataTranzactii.UseVisualStyleBackColor = false;
            buttonDataTranzactii.Click += buttonDataTranzactii_Click;
            // 
            // FormaBazaDate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 51, 76);
            ClientSize = new Size(998, 577);
            Controls.Add(buttonDataTranzactii);
            Controls.Add(datePickerInterval);
            Controls.Add(buttonRefresh);
            Controls.Add(buttonSterge);
            Controls.Add(buttonModifica);
            Controls.Add(dataGridDate);
            Controls.Add(panelAdd);
            Name = "FormaBazaDate";
            Text = "Baza de date";
            Load += FormaBazaDate_Load;
            panelAdd.ResumeLayout(false);
            panelAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridDate).EndInit();
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
        }

        #endregion

        private Panel panelAdd;
        private TextBox textBoxVanzator;
        private Label lblVanzator;
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
        private TextBox textBoxFabricatie;
        private Label lblAnFabr;
        private DateTimePicker dateTimePicker1;
        private Button buttonAdauga;
        private DataGridView dataGridDate;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private ErrorProvider errorProvider3;
        private ErrorProvider errorProvider4;
        private ErrorProvider errorProvider5;
        private ErrorProvider errorProvider6;
        private ErrorProvider errorProvider7;
        private ErrorProvider errorProvider8;
        private ErrorProvider errorProvider9;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn ColMarca;
        private DataGridViewTextBoxColumn ColModel;
        private DataGridViewTextBoxColumn ColCuloare;
        private DataGridViewTextBoxColumn ColAnFabr;
        private DataGridViewTextBoxColumn Optiuni;
        private DataGridViewTextBoxColumn ColCumparator;
        private DataGridViewTextBoxColumn ColVanzator;
        private DataGridViewTextBoxColumn ColPret;
        private DataGridViewTextBoxColumn ColDataTranz;
        private CustomControls.RJControls.RJButton buttonModifica;
        private CustomControls.RJControls.RJButton buttonSterge;
        private CustomControls.RJControls.RJButton buttonRefresh;
        private DateTimePicker datePickerInterval;
        private CustomControls.RJControls.RJButton buttonDataTranzactii;
    }
}