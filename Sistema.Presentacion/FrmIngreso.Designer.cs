namespace Sistema.Presentacion
{
    partial class FrmIngreso
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
            this.ErrorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnInsertar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.GrbDetalle = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.TxtTotalImpuesto = new System.Windows.Forms.TextBox();
            this.TxtSubTotal = new System.Windows.Forms.TextBox();
            this.DgvDetalle = new System.Windows.Forms.DataGridView();
            this.BtnBuscarArticulo = new System.Windows.Forms.Button();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.Articulo = new System.Windows.Forms.Label();
            this.GrbCabecera = new System.Windows.Forms.GroupBox();
            this.TxtNumero = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtImpuesto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.TxtSerie = new System.Windows.Forms.TextBox();
            this.CboComprobante = new System.Windows.Forms.ComboBox();
            this.BtnBuscarProveedor = new System.Windows.Forms.Button();
            this.TxtNombreProveedor = new System.Windows.Forms.TextBox();
            this.TxtIdProveedor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.BtnAnular = new System.Windows.Forms.Button();
            this.ChkSeleccionar = new System.Windows.Forms.CheckBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.DgvListado = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabGeneral = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.GrbDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetalle)).BeginInit();
            this.GrbCabecera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // ErrorIcono
            // 
            this.ErrorIcono.ContainerControl = this;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(158, 563);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(142, 30);
            this.BtnCancelar.TabIndex = 7;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // BtnInsertar
            // 
            this.BtnInsertar.Location = new System.Drawing.Point(12, 563);
            this.BtnInsertar.Name = "BtnInsertar";
            this.BtnInsertar.Size = new System.Drawing.Size(140, 30);
            this.BtnInsertar.TabIndex = 6;
            this.BtnInsertar.Text = "Insertar";
            this.BtnInsertar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 521);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "(*) Indica que los campos son obligatorios";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.GrbDetalle);
            this.tabPage2.Controls.Add(this.GrbCabecera);
            this.tabPage2.Controls.Add(this.BtnCancelar);
            this.tabPage2.Controls.Add(this.BtnInsertar);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1062, 604);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // GrbDetalle
            // 
            this.GrbDetalle.Controls.Add(this.label10);
            this.GrbDetalle.Controls.Add(this.label9);
            this.GrbDetalle.Controls.Add(this.label8);
            this.GrbDetalle.Controls.Add(this.TxtTotal);
            this.GrbDetalle.Controls.Add(this.TxtTotalImpuesto);
            this.GrbDetalle.Controls.Add(this.TxtSubTotal);
            this.GrbDetalle.Controls.Add(this.DgvDetalle);
            this.GrbDetalle.Controls.Add(this.BtnBuscarArticulo);
            this.GrbDetalle.Controls.Add(this.TxtCodigo);
            this.GrbDetalle.Controls.Add(this.Articulo);
            this.GrbDetalle.Location = new System.Drawing.Point(15, 164);
            this.GrbDetalle.Name = "GrbDetalle";
            this.GrbDetalle.Size = new System.Drawing.Size(1024, 354);
            this.GrbDetalle.TabIndex = 9;
            this.GrbDetalle.TabStop = false;
            this.GrbDetalle.Text = "Detalle";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(763, 320);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Total";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(763, 294);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Total Impuesto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(763, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Sub Total";
            // 
            // TxtTotal
            // 
            this.TxtTotal.Enabled = false;
            this.TxtTotal.Location = new System.Drawing.Point(876, 313);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(121, 20);
            this.TxtTotal.TabIndex = 6;
            // 
            // TxtTotalImpuesto
            // 
            this.TxtTotalImpuesto.Enabled = false;
            this.TxtTotalImpuesto.Location = new System.Drawing.Point(876, 287);
            this.TxtTotalImpuesto.Name = "TxtTotalImpuesto";
            this.TxtTotalImpuesto.Size = new System.Drawing.Size(121, 20);
            this.TxtTotalImpuesto.TabIndex = 5;
            // 
            // TxtSubTotal
            // 
            this.TxtSubTotal.Enabled = false;
            this.TxtSubTotal.Location = new System.Drawing.Point(876, 261);
            this.TxtSubTotal.Name = "TxtSubTotal";
            this.TxtSubTotal.Size = new System.Drawing.Size(121, 20);
            this.TxtSubTotal.TabIndex = 4;
            // 
            // DgvDetalle
            // 
            this.DgvDetalle.AllowUserToAddRows = false;
            this.DgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDetalle.Location = new System.Drawing.Point(16, 58);
            this.DgvDetalle.Name = "DgvDetalle";
            this.DgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvDetalle.Size = new System.Drawing.Size(979, 183);
            this.DgvDetalle.TabIndex = 3;
            // 
            // BtnBuscarArticulo
            // 
            this.BtnBuscarArticulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnBuscarArticulo.Location = new System.Drawing.Point(419, 20);
            this.BtnBuscarArticulo.Name = "BtnBuscarArticulo";
            this.BtnBuscarArticulo.Size = new System.Drawing.Size(106, 23);
            this.BtnBuscarArticulo.TabIndex = 2;
            this.BtnBuscarArticulo.Text = "Buscar";
            this.BtnBuscarArticulo.UseVisualStyleBackColor = true;
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(84, 23);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(327, 20);
            this.TxtCodigo.TabIndex = 1;
            this.TxtCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtCodigo_KeyDown);
            // 
            // Articulo
            // 
            this.Articulo.AutoSize = true;
            this.Articulo.Location = new System.Drawing.Point(13, 30);
            this.Articulo.Name = "Articulo";
            this.Articulo.Size = new System.Drawing.Size(42, 13);
            this.Articulo.TabIndex = 0;
            this.Articulo.Text = "Articulo";
            // 
            // GrbCabecera
            // 
            this.GrbCabecera.Controls.Add(this.TxtNumero);
            this.GrbCabecera.Controls.Add(this.label5);
            this.GrbCabecera.Controls.Add(this.TxtImpuesto);
            this.GrbCabecera.Controls.Add(this.label4);
            this.GrbCabecera.Controls.Add(this.textBox4);
            this.GrbCabecera.Controls.Add(this.TxtSerie);
            this.GrbCabecera.Controls.Add(this.CboComprobante);
            this.GrbCabecera.Controls.Add(this.BtnBuscarProveedor);
            this.GrbCabecera.Controls.Add(this.TxtNombreProveedor);
            this.GrbCabecera.Controls.Add(this.TxtIdProveedor);
            this.GrbCabecera.Controls.Add(this.label2);
            this.GrbCabecera.Controls.Add(this.lblProveedor);
            this.GrbCabecera.Controls.Add(this.TxtId);
            this.GrbCabecera.Location = new System.Drawing.Point(15, 21);
            this.GrbCabecera.Name = "GrbCabecera";
            this.GrbCabecera.Size = new System.Drawing.Size(1024, 137);
            this.GrbCabecera.TabIndex = 8;
            this.GrbCabecera.TabStop = false;
            this.GrbCabecera.Text = "Cabecera";
            // 
            // TxtNumero
            // 
            this.TxtNumero.AutoSize = true;
            this.TxtNumero.Location = new System.Drawing.Point(341, 78);
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(55, 13);
            this.TxtNumero.TabIndex = 15;
            this.TxtNumero.Text = "NUMERO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(216, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "SERIE";
            // 
            // TxtImpuesto
            // 
            this.TxtImpuesto.Location = new System.Drawing.Point(551, 103);
            this.TxtImpuesto.Name = "TxtImpuesto";
            this.TxtImpuesto.Size = new System.Drawing.Size(66, 20);
            this.TxtImpuesto.TabIndex = 13;
            this.TxtImpuesto.Text = "0.18";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(484, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Impuesto (*)";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(344, 102);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(134, 20);
            this.textBox4.TabIndex = 11;
            // 
            // TxtSerie
            // 
            this.TxtSerie.Location = new System.Drawing.Point(219, 103);
            this.TxtSerie.Name = "TxtSerie";
            this.TxtSerie.Size = new System.Drawing.Size(119, 20);
            this.TxtSerie.TabIndex = 10;
            // 
            // CboComprobante
            // 
            this.CboComprobante.FormattingEnabled = true;
            this.CboComprobante.Items.AddRange(new object[] {
            "FACTURA",
            "BOLETA",
            "TICKET",
            "NOTA CREDITO"});
            this.CboComprobante.Location = new System.Drawing.Point(91, 102);
            this.CboComprobante.Name = "CboComprobante";
            this.CboComprobante.Size = new System.Drawing.Size(100, 21);
            this.CboComprobante.TabIndex = 9;
            this.CboComprobante.Text = "FACTURA";
            this.CboComprobante.UseWaitCursor = true;
            // 
            // BtnBuscarProveedor
            // 
            this.BtnBuscarProveedor.Location = new System.Drawing.Point(487, 33);
            this.BtnBuscarProveedor.Name = "BtnBuscarProveedor";
            this.BtnBuscarProveedor.Size = new System.Drawing.Size(130, 20);
            this.BtnBuscarProveedor.TabIndex = 8;
            this.BtnBuscarProveedor.Text = "Buscar";
            this.BtnBuscarProveedor.UseVisualStyleBackColor = true;
            this.BtnBuscarProveedor.Click += new System.EventHandler(this.BtnBuscarProveedor_Click);
            // 
            // TxtNombreProveedor
            // 
            this.TxtNombreProveedor.Enabled = false;
            this.TxtNombreProveedor.Location = new System.Drawing.Point(187, 33);
            this.TxtNombreProveedor.Name = "TxtNombreProveedor";
            this.TxtNombreProveedor.Size = new System.Drawing.Size(294, 20);
            this.TxtNombreProveedor.TabIndex = 7;
            // 
            // TxtIdProveedor
            // 
            this.TxtIdProveedor.Enabled = false;
            this.TxtIdProveedor.Location = new System.Drawing.Point(77, 33);
            this.TxtIdProveedor.Name = "TxtIdProveedor";
            this.TxtIdProveedor.Size = new System.Drawing.Size(100, 20);
            this.TxtIdProveedor.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Comprobante (*)";
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Location = new System.Drawing.Point(5, 33);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(66, 13);
            this.lblProveedor.TabIndex = 4;
            this.lblProveedor.Text = "Proveedor(*)";
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(487, 10);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(105, 20);
            this.TxtId.TabIndex = 3;
            this.TxtId.Visible = false;
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            // 
            // BtnAnular
            // 
            this.BtnAnular.Location = new System.Drawing.Point(133, 355);
            this.BtnAnular.Name = "BtnAnular";
            this.BtnAnular.Size = new System.Drawing.Size(93, 23);
            this.BtnAnular.TabIndex = 6;
            this.BtnAnular.Text = "Anular";
            this.BtnAnular.UseVisualStyleBackColor = true;
            // 
            // ChkSeleccionar
            // 
            this.ChkSeleccionar.AutoSize = true;
            this.ChkSeleccionar.Location = new System.Drawing.Point(6, 359);
            this.ChkSeleccionar.Name = "ChkSeleccionar";
            this.ChkSeleccionar.Size = new System.Drawing.Size(82, 17);
            this.ChkSeleccionar.TabIndex = 4;
            this.ChkSeleccionar.Text = "Seleccionar";
            this.ChkSeleccionar.UseVisualStyleBackColor = true;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(491, 16);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(105, 20);
            this.BtnBuscar.TabIndex = 3;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(6, 16);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(454, 20);
            this.TxtBuscar.TabIndex = 2;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(667, 360);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Total:";
            // 
            // DgvListado
            // 
            this.DgvListado.AllowUserToAddRows = false;
            this.DgvListado.AllowUserToDeleteRows = false;
            this.DgvListado.AllowUserToOrderColumns = true;
            this.DgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.DgvListado.Location = new System.Drawing.Point(6, 53);
            this.DgvListado.Name = "DgvListado";
            this.DgvListado.ReadOnly = true;
            this.DgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListado.Size = new System.Drawing.Size(899, 291);
            this.DgvListado.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BtnAnular);
            this.tabPage1.Controls.Add(this.ChkSeleccionar);
            this.tabPage1.Controls.Add(this.BtnBuscar);
            this.tabPage1.Controls.Add(this.TxtBuscar);
            this.tabPage1.Controls.Add(this.lblTotal);
            this.tabPage1.Controls.Add(this.DgvListado);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(927, 604);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.tabPage1);
            this.tabGeneral.Controls.Add(this.tabPage2);
            this.tabGeneral.Location = new System.Drawing.Point(12, 12);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.SelectedIndex = 0;
            this.tabGeneral.Size = new System.Drawing.Size(1070, 630);
            this.tabGeneral.TabIndex = 1;
            // 
            // FrmIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 654);
            this.Controls.Add(this.tabGeneral);
            this.Name = "FrmIngreso";
            this.Text = "Ingresos";
            this.Load += new System.EventHandler(this.FrmIngreso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.GrbDetalle.ResumeLayout(false);
            this.GrbDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetalle)).EndInit();
            this.GrbCabecera.ResumeLayout(false);
            this.GrbCabecera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabGeneral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider ErrorIcono;
        private System.Windows.Forms.TabControl tabGeneral;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button BtnAnular;
        private System.Windows.Forms.CheckBox ChkSeleccionar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView DgvListado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnInsertar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox GrbDetalle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.TextBox TxtTotalImpuesto;
        private System.Windows.Forms.TextBox TxtSubTotal;
        private System.Windows.Forms.DataGridView DgvDetalle;
        private System.Windows.Forms.Button BtnBuscarArticulo;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label Articulo;
        private System.Windows.Forms.GroupBox GrbCabecera;
        private System.Windows.Forms.Label TxtNumero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtImpuesto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox TxtSerie;
        private System.Windows.Forms.ComboBox CboComprobante;
        private System.Windows.Forms.Button BtnBuscarProveedor;
        private System.Windows.Forms.TextBox TxtNombreProveedor;
        private System.Windows.Forms.TextBox TxtIdProveedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.TextBox TxtId;
    }
}