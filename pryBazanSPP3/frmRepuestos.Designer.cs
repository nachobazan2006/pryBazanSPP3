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
            txtPrecio = new TextBox();
            txtDescripcion = new TextBox();
            NupNúmero = new NumericUpDown();
            cmbOrigen = new ComboBox();
            cmbMarca = new ComboBox();
            btnGrabar = new Button();
            lblPrecio = new Label();
            lblDescripcion = new Label();
            lblNumero = new Label();
            lblOrigen = new Label();
            lblMarca = new Label();
            gbConsulta = new GroupBox();
            btnBuscar = new Button();
            cmbMarcaConsulta = new ComboBox();
            rbImportado = new RadioButton();
            rbNacional = new RadioButton();
            lblMarcaConsulta = new Label();
            lstConsulta = new ListBox();
            gbRepuesto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NupNúmero).BeginInit();
            gbConsulta.SuspendLayout();
            SuspendLayout();
            // 
            // gbRepuesto
            // 
            gbRepuesto.Controls.Add(txtPrecio);
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
            // txtPrecio
            // 
            txtPrecio.Location = new Point(111, 259);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(228, 23);
            txtPrecio.TabIndex = 9;
            txtPrecio.TextChanged += textBox1_TextChanged;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(111, 210);
            txtDescripcion.MaxLength = 50;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(228, 23);
            txtDescripcion.TabIndex = 8;
            // 
            // NupNúmero
            // 
            NupNúmero.Increment = new decimal(new int[] { 0, 0, 0, 0 });
            NupNúmero.Location = new Point(111, 157);
            NupNúmero.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            NupNúmero.Name = "NupNúmero";
            NupNúmero.Size = new Size(221, 23);
            NupNúmero.TabIndex = 7;
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
            // cmbMarca
            // 
            cmbMarca.FormattingEnabled = true;
            cmbMarca.Items.AddRange(new object[] { "P", "F", "R" });
            cmbMarca.Location = new Point(111, 55);
            cmbMarca.Name = "cmbMarca";
            cmbMarca.Size = new Size(221, 23);
            cmbMarca.TabIndex = 4;
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(231, 315);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(101, 33);
            btnGrabar.TabIndex = 5;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnGrabar_Click;
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
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(29, 210);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(69, 15);
            lblDescripcion.TabIndex = 3;
            lblDescripcion.Text = "Descripción";
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
            // lblOrigen
            // 
            lblOrigen.AutoSize = true;
            lblOrigen.Location = new Point(29, 104);
            lblOrigen.Name = "lblOrigen";
            lblOrigen.Size = new Size(43, 15);
            lblOrigen.TabIndex = 1;
            lblOrigen.Text = "Origen";
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
            // btnBuscar
            // 
            btnBuscar.Location = new Point(231, 212);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(101, 32);
            btnBuscar.TabIndex = 5;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
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
            // lblMarcaConsulta
            // 
            lblMarcaConsulta.AutoSize = true;
            lblMarcaConsulta.Location = new Point(18, 156);
            lblMarcaConsulta.Name = "lblMarcaConsulta";
            lblMarcaConsulta.Size = new Size(40, 15);
            lblMarcaConsulta.TabIndex = 1;
            lblMarcaConsulta.Text = "Marca";
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
            // frmRepuestos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(495, 739);
            Controls.Add(gbConsulta);
            Controls.Add(gbRepuesto);
            Name = "frmRepuestos";
            Text = "Repuestos";
            gbRepuesto.ResumeLayout(false);
            gbRepuesto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NupNúmero).EndInit();
            gbConsulta.ResumeLayout(false);
            gbConsulta.PerformLayout();
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
        private TextBox txtDescripcion;
        private ComboBox cmbMarcaConsulta;
        private Button btnBuscar;
        private TextBox txtPrecio;
    }
}
