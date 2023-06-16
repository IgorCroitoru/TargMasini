namespace Formsuri
{
    partial class Chart
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chartStatistica = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBoxMarca = new System.Windows.Forms.TextBox();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonCauta = new CustomControls.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.chartStatistica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // chartStatistica
            // 
            chartArea1.Name = "ChartArea1";
            this.chartStatistica.ChartAreas.Add(chartArea1);
            this.chartStatistica.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend1.Name = "Legend1";
            this.chartStatistica.Legends.Add(legend1);
            this.chartStatistica.Location = new System.Drawing.Point(0, 154);
            this.chartStatistica.Name = "chartStatistica";
            this.chartStatistica.Size = new System.Drawing.Size(998, 423);
            this.chartStatistica.TabIndex = 0;
            this.chartStatistica.Text = "chart1";
            // 
            // textBoxMarca
            // 
            this.textBoxMarca.Location = new System.Drawing.Point(100, 76);
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.Size = new System.Drawing.Size(117, 20);
            this.textBoxMarca.TabIndex = 1;
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(100, 113);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(117, 20);
            this.textBoxModel.TabIndex = 2;
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(311, 78);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(97, 21);
            this.dateTimePickerFrom.TabIndex = 3;
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerTo.Location = new System.Drawing.Point(311, 113);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(97, 21);
            this.dateTimePickerTo.TabIndex = 4;
            this.dateTimePickerTo.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Rubik", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMarca.Location = new System.Drawing.Point(48, 78);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(46, 15);
            this.lblMarca.TabIndex = 5;
            this.lblMarca.Text = "Marca:";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Rubik", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblModel.Location = new System.Drawing.Point(48, 113);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(44, 15);
            this.lblModel.TabIndex = 6;
            this.lblModel.Text = "Model:";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Rubik", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFrom.Location = new System.Drawing.Point(267, 81);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(38, 15);
            this.lblFrom.TabIndex = 7;
            this.lblFrom.Text = "De la:";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Rubik", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTo.Location = new System.Drawing.Point(253, 116);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(52, 15);
            this.lblTo.TabIndex = 8;
            this.lblTo.Text = "Pana la:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // buttonCauta
            // 
            this.buttonCauta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.buttonCauta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.buttonCauta.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonCauta.BorderRadius = 0;
            this.buttonCauta.BorderSize = 0;
            this.buttonCauta.FlatAppearance.BorderSize = 0;
            this.buttonCauta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCauta.ForeColor = System.Drawing.Color.White;
            this.buttonCauta.Location = new System.Drawing.Point(458, 104);
            this.buttonCauta.Name = "buttonCauta";
            this.buttonCauta.Size = new System.Drawing.Size(92, 29);
            this.buttonCauta.TabIndex = 9;
            this.buttonCauta.Text = "Cauta";
            this.buttonCauta.TextColor = System.Drawing.Color.White;
            this.buttonCauta.UseVisualStyleBackColor = false;
            this.buttonCauta.Click += new System.EventHandler(this.buttonCauta_Click);
            // 
            // Chart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 577);
            this.Controls.Add(this.buttonCauta);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.textBoxMarca);
            this.Controls.Add(this.chartStatistica);
            this.Name = "Chart";
            this.Text = "Statistica";
            this.Load += new System.EventHandler(this.Chart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartStatistica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartStatistica;
        private System.Windows.Forms.TextBox textBoxMarca;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private CustomControls.RJControls.RJButton buttonCauta;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}