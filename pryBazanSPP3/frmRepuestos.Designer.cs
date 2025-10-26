namespace pryBazanSPP3
{
    partial class frmRepuestos
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
            gbRepuesto = new GroupBox();
            lblMarca = new Label();
            lblOrigen = new Label();
            lblNumero = new Label();
            lblDescripcion = new Label();
            lblPrecio = new Label();
            btnGrabar = new Button();
            gbConsulta = new GroupBox();
            lstConsulta = new ListBox();
            lblMarcaConsulta = new Label();
            rbNacional = new RadioButton();
            rbImportado = new RadioButton();
            cmbMarca = new ComboBox();
            cmbOrigen = new ComboBox();
            NupNúmero = new NumericUpDown();
            txtDescripcion = new TextBox();
            NupPrecio = new NumericUpDown();
            cmbMarcaConsulta = new ComboBox();
            btnBuscar = new Button();
            gbRepuesto.SuspendLayout();
            gbConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NupNúmero).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NupPrecio).BeginInit();
            SuspendLayout();
            // 
            // gbRepuesto
            // 
            gbRepuesto.Controls.Add(NupPrecio);
            gbRepuesto.Controls.Add(txtDescripcion);
            gbRepuesto.Controls.Add(NupNúmero);
            gbRepuesto.Controls.Add(cmbOrigen);
            gbRepuesto.Controls.Add(cmbMarca);
            gbRepuesto.Controls.Add(btnGrabar);
            gbRepuesto.Controls.Add(lblPrecio);
            gbRepuesto.Controls.Add(lblDescripcion);
            gbRepuesto.Controls.Add(lblNumero);
            gbRepuesto.Controls.Add(lblOrigen);
            gbRepuesto.Controls.Add(lblMarca);
            gbRepuesto.Location = new Point(40, 34);
            gbRepuesto.Name = "gbRepuesto";
            gbRepuesto.Size = new Size(372, 367);
            gbRepuesto.TabIndex = 0;
            gbRepuesto.TabStop = false;
            gbRepuesto.Text = "Repuesto";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(29, 55);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(40, 15);
            lblMarca.TabIndex = 0;
            lblMarca.Text = "Marca";
            // 
            // lblOrigen
            // 
            lblOrigen.AutoSize = true;
            lblOrigen.Location = new Point(29, 104);
            lblOrigen.Name = "lblOrigen";
            lblOrigen.Size = new Size(43, 15);
            lblOrigen.TabIndex = 1;
            lblOrigen.Text = "Origen";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(29, 157);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(51, 15);
            lblNumero.TabIndex = 2;
            lblNumero.Text = "Número";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(29, 210);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(69, 15);
            lblDescripcion.TabIndex = 3;
            lblDescripcion.Text = "Descripción";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(29, 262);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(40, 15);
            lblPrecio.TabIndex = 4;
            lblPrecio.Text = "Precio";
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(231, 315);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(101, 33);
            btnGrabar.TabIndex = 5;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            // 
            // gbConsulta
            // 
            gbConsulta.Controls.Add(btnBuscar);
            gbConsulta.Controls.Add(cmbMarcaConsulta);
            gbConsulta.Controls.Add(rbImportado);
            gbConsulta.Controls.Add(rbNacional);
            gbConsulta.Controls.Add(lblMarcaConsulta);
            gbConsulta.Controls.Add(lstConsulta);
            gbConsulta.Location = new Point(40, 455);
            gbConsulta.Name = "gbConsulta";
            gbConsulta.Size = new Size(372, 265);
            gbConsulta.TabIndex = 1;
            gbConsulta.TabStop = false;
            gbConsulta.Text = "Consulta";
            // 
            // lstConsulta
            // 
            lstConsulta.FormattingEnabled = true;
            lstConsulta.ItemHeight = 15;
            lstConsulta.Location = new Point(18, 38);
            lstConsulta.Name = "lstConsulta";
            lstConsulta.Size = new Size(338, 94);
            lstConsulta.TabIndex = 0;
            // 
            // lblMarcaConsulta
            // 
            lblMarcaConsulta.AutoSize = true;
            lblMarcaConsulta.Location = new Point(18, 156);
            lblMarcaConsulta.Name = "lblMarcaConsulta";
            lblMarcaConsulta.Size = new Size(40, 15);
            lblMarcaConsulta.TabIndex = 1;
            lblMarcaConsulta.Text = "Marca";
            // 
            // rbNacional
            // 
            rbNacional.AutoSize = true;
            rbNacional.Location = new Point(18, 190);
            rbNacional.Name = "rbNacional";
            rbNacional.Size = new Size(72, 19);
            rbNacional.TabIndex = 2;
            rbNacional.TabStop = true;
            rbNacional.Text = "Nacional";
            rbNacional.UseVisualStyleBackColor = true;
            // 
            // rbImportado
            // 
            rbImportado.AutoSize = true;
            rbImportado.Location = new Point(18, 225);
            rbImportado.Name = "rbImportado";
            rbImportado.Size = new Size(81, 19);
            rbImportado.TabIndex = 3;
            rbImportado.TabStop = true;
            rbImportado.Text = "Importado";
            rbImportado.UseVisualStyleBackColor = true;
            // 
            // cmbMarca
            // 
            cmbMarca.FormattingEnabled = true;
            cmbMarca.Items.AddRange(new object[] { "P", "F", "R" });
            cmbMarca.Location = new Point(111, 55);
            cmbMarca.Name = "cmbMarca";
            cmbMarca.Size = new Size(221, 23);
            cmbMarca.TabIndex = 4;
            // 
            // cmbOrigen
            // 
            cmbOrigen.FormattingEnabled = true;
            cmbOrigen.Items.AddRange(new object[] { "N", "I" });
            cmbOrigen.Location = new Point(111, 104);
            cmbOrigen.Name = "cmbOrigen";
            cmbOrigen.Size = new Size(221, 23);
            cmbOrigen.TabIndex = 6;
            // 
            // NupNúmero
            // 
            NupNúmero.Location = new Point(111, 157);
            NupNúmero.Maximum = new decimal(new int[] { 6, 0, 0, 0 });
            NupNúmero.Name = "NupNúmero";
            NupNúmero.Size = new Size(221, 23);
            NupNúmero.TabIndex = 7;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(111, 210);
            txtDescripcion.MaxLength = 50;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(228, 23);
            txtDescripcion.TabIndex = 8;
            // 
            // NupPrecio
            // 
            NupPrecio.DecimalPlaces = 2;
            NupPrecio.Location = new Point(111, 262);
            NupPrecio.Name = "NupPrecio";
            NupPrecio.Size = new Size(228, 23);
            NupPrecio.TabIndex = 9;
            // 
            // cmbMarcaConsulta
            // 
            cmbMarcaConsulta.FormattingEnabled = true;
            cmbMarcaConsulta.Items.AddRange(new object[] { "P", "F", "R" });
            cmbMarcaConsulta.Location = new Point(93, 153);
            cmbMarcaConsulta.Name = "cmbMarcaConsulta";
            cmbMarcaConsulta.Size = new Size(263, 23);
            cmbMarcaConsulta.TabIndex = 4;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(231, 212);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(101, 32);
            btnBuscar.TabIndex = 5;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // frmRepuestos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 739);
            Controls.Add(gbConsulta);
            Controls.Add(gbRepuesto);
            Name = "frmRepuestos";
            Text = "Repuestos";
            gbRepuesto.ResumeLayout(false);
            gbRepuesto.PerformLayout();
            gbConsulta.ResumeLayout(false);
            gbConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NupNúmero).EndInit();
            ((System.ComponentModel.ISupportInitialize)NupPrecio).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbRepuesto;
        private Label lblDescripcion;
        private Label lblNumero;
        private Label lblOrigen;
        private Label lblMarca;
        private NumericUpDown NupNúmero;
        private ComboBox cmbOrigen;
        private ComboBox cmbMarca;
        private Button btnGrabar;
        private Label lblPrecio;
        private GroupBox gbConsulta;
        private RadioButton rbImportado;
        private RadioButton rbNacional;
        private Label lblMarcaConsulta;
        private ListBox lstConsulta;
        private NumericUpDown NupPrecio;
        private TextBox txtDescripcion;
        private ComboBox cmbMarcaConsulta;
        private Button btnBuscar;
    }
}
