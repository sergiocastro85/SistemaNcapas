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
            this.LblTotalArticulos = new System.Windows.Forms.Label();
            this.GrbDetalle = new System.Windows.Forms.GroupBox();
            this.PanelArticulos = new System.Windows.Forms.Panel();
            this.DgvArticulos = new System.Windows.Forms.DataGridView();
            this.BtnCerrarArticulos = new System.Windows.Forms.Button();
            this.BtnFiltrarArticulo = new System.Windows.Forms.Button();
            this.TxtBuscarArticulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.TxtTotalImpuesto = new System.Windows.Forms.TextBox();
            this.TxtSubTotal = new System.Windows.Forms.TextBox();
            this.DgvDetalle = new System.Windows.Forms.DataGridView();
            this.BtnVerArticulos = new System.Windows.Forms.Button();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.Articulo = new System.Windows.Forms.Label();
            this.GrbCabecera = new System.Windows.Forms.GroupBox();
            this.TxtNumero = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtImpuesto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtNumeroComprobante = new System.Windows.Forms.TextBox();
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
            this.PnMostrarDestalles = new System.Windows.Forms.Panel();
            this.DgvMostrarDetalles = new System.Windows.Forms.DataGridView();
            this.BtnCerrarD = new System.Windows.Forms.Button();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtSubtotalD = new System.Windows.Forms.TextBox();
            this.TxtTotalD = new System.Windows.Forms.TextBox();
            this.TxtImpuestoD = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.GrbDetalle.SuspendLayout();
            this.PanelArticulos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetalle)).BeginInit();
            this.GrbCabecera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.PnMostrarDestalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMostrarDetalles)).BeginInit();
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
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnInsertar
            // 
            this.BtnInsertar.Location = new System.Drawing.Point(12, 563);
            this.BtnInsertar.Name = "BtnInsertar";
            this.BtnInsertar.Size = new System.Drawing.Size(140, 30);
            this.BtnInsertar.TabIndex = 6;
            this.BtnInsertar.Text = "Insertar";
            this.BtnInsertar.UseVisualStyleBackColor = true;
            this.BtnInsertar.Click += new System.EventHandler(this.BtnInsertar_Click);
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
            this.tabPage2.Controls.Add(this.LblTotalArticulos);
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
            // LblTotalArticulos
            // 
            this.LblTotalArticulos.AutoSize = true;
            this.LblTotalArticulos.Location = new System.Drawing.Point(820, 537);
            this.LblTotalArticulos.Name = "LblTotalArticulos";
            this.LblTotalArticulos.Size = new System.Drawing.Size(31, 13);
            this.LblTotalArticulos.TabIndex = 10;
            this.LblTotalArticulos.Text = "Total";
            // 
            // GrbDetalle
            // 
            this.GrbDetalle.Controls.Add(this.PanelArticulos);
            this.GrbDetalle.Controls.Add(this.label10);
            this.GrbDetalle.Controls.Add(this.label9);
            this.GrbDetalle.Controls.Add(this.label8);
            this.GrbDetalle.Controls.Add(this.TxtTotal);
            this.GrbDetalle.Controls.Add(this.TxtTotalImpuesto);
            this.GrbDetalle.Controls.Add(this.TxtSubTotal);
            this.GrbDetalle.Controls.Add(this.DgvDetalle);
            this.GrbDetalle.Controls.Add(this.BtnVerArticulos);
            this.GrbDetalle.Controls.Add(this.TxtCodigo);
            this.GrbDetalle.Controls.Add(this.Articulo);
            this.GrbDetalle.Location = new System.Drawing.Point(15, 164);
            this.GrbDetalle.Name = "GrbDetalle";
            this.GrbDetalle.Size = new System.Drawing.Size(1024, 354);
            this.GrbDetalle.TabIndex = 9;
            this.GrbDetalle.TabStop = false;
            this.GrbDetalle.Text = "Detalle";
            // 
            // PanelArticulos
            // 
            this.PanelArticulos.BackColor = System.Drawing.Color.Cornsilk;
            this.PanelArticulos.Controls.Add(this.DgvArticulos);
            this.PanelArticulos.Controls.Add(this.BtnCerrarArticulos);
            this.PanelArticulos.Controls.Add(this.BtnFiltrarArticulo);
            this.PanelArticulos.Controls.Add(this.TxtBuscarArticulo);
            this.PanelArticulos.Controls.Add(this.label1);
            this.PanelArticulos.Location = new System.Drawing.Point(55, 49);
            this.PanelArticulos.Name = "PanelArticulos";
            this.PanelArticulos.Size = new System.Drawing.Size(940, 344);
            this.PanelArticulos.TabIndex = 10;
            this.PanelArticulos.Visible = false;
            // 
            // DgvArticulos
            // 
            this.DgvArticulos.AllowUserToAddRows = false;
            this.DgvArticulos.AllowUserToDeleteRows = false;
            this.DgvArticulos.AllowUserToOrderColumns = true;
            this.DgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvArticulos.Location = new System.Drawing.Point(22, 42);
            this.DgvArticulos.Name = "DgvArticulos";
            this.DgvArticulos.ReadOnly = true;
            this.DgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvArticulos.Size = new System.Drawing.Size(899, 279);
            this.DgvArticulos.TabIndex = 4;
            this.DgvArticulos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvArticulos_CellDoubleClick);
            // 
            // BtnCerrarArticulos
            // 
            this.BtnCerrarArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrarArticulos.ForeColor = System.Drawing.Color.Red;
            this.BtnCerrarArticulos.Location = new System.Drawing.Point(890, 5);
            this.BtnCerrarArticulos.Name = "BtnCerrarArticulos";
            this.BtnCerrarArticulos.Size = new System.Drawing.Size(31, 27);
            this.BtnCerrarArticulos.TabIndex = 3;
            this.BtnCerrarArticulos.Text = "X";
            this.BtnCerrarArticulos.UseVisualStyleBackColor = true;
            this.BtnCerrarArticulos.Click += new System.EventHandler(this.BtnCerrarArticulos_Click);
            // 
            // BtnFiltrarArticulo
            // 
            this.BtnFiltrarArticulo.Location = new System.Drawing.Point(444, 9);
            this.BtnFiltrarArticulo.Name = "BtnFiltrarArticulo";
            this.BtnFiltrarArticulo.Size = new System.Drawing.Size(154, 20);
            this.BtnFiltrarArticulo.TabIndex = 2;
            this.BtnFiltrarArticulo.Text = "Buscar";
            this.BtnFiltrarArticulo.UseVisualStyleBackColor = true;
            this.BtnFiltrarArticulo.Click += new System.EventHandler(this.BtnFiltrarArticulo_Click);
            // 
            // TxtBuscarArticulo
            // 
            this.TxtBuscarArticulo.Location = new System.Drawing.Point(78, 9);
            this.TxtBuscarArticulo.Name = "TxtBuscarArticulo";
            this.TxtBuscarArticulo.Size = new System.Drawing.Size(348, 20);
            this.TxtBuscarArticulo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar";
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
            this.DgvDetalle.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDetalle_CellEndEdit);
            this.DgvDetalle.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.DgvDetalle_RowsRemoved);
            // 
            // BtnVerArticulos
            // 
            this.BtnVerArticulos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnVerArticulos.Location = new System.Drawing.Point(419, 20);
            this.BtnVerArticulos.Name = "BtnVerArticulos";
            this.BtnVerArticulos.Size = new System.Drawing.Size(106, 23);
            this.BtnVerArticulos.TabIndex = 2;
            this.BtnVerArticulos.Text = "Ver";
            this.BtnVerArticulos.UseVisualStyleBackColor = true;
            this.BtnVerArticulos.Click += new System.EventHandler(this.BtnVerArticulos_Click);
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
            this.GrbCabecera.Controls.Add(this.TxtNumeroComprobante);
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
            // TxtNumeroComprobante
            // 
            this.TxtNumeroComprobante.Location = new System.Drawing.Point(344, 102);
            this.TxtNumeroComprobante.Name = "TxtNumeroComprobante";
            this.TxtNumeroComprobante.Size = new System.Drawing.Size(134, 20);
            this.TxtNumeroComprobante.TabIndex = 11;
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
            this.BtnAnular.Click += new System.EventHandler(this.BtnAnular_Click);
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
            this.ChkSeleccionar.CheckedChanged += new System.EventHandler(this.ChkSeleccionar_CheckedChanged);
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
            this.DgvListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListado_CellContentClick);
            this.DgvListado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListado_CellDoubleClick);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.PnMostrarDestalles);
            this.tabPage1.Controls.Add(this.BtnAnular);
            this.tabPage1.Controls.Add(this.ChkSeleccionar);
            this.tabPage1.Controls.Add(this.BtnBuscar);
            this.tabPage1.Controls.Add(this.TxtBuscar);
            this.tabPage1.Controls.Add(this.lblTotal);
            this.tabPage1.Controls.Add(this.DgvListado);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1062, 604);
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
            // PnMostrarDestalles
            // 
            this.PnMostrarDestalles.BackColor = System.Drawing.Color.Silver;
            this.PnMostrarDestalles.Controls.Add(this.DgvMostrarDetalles);
            this.PnMostrarDestalles.Controls.Add(this.TxtImpuestoD);
            this.PnMostrarDestalles.Controls.Add(this.TxtTotalD);
            this.PnMostrarDestalles.Controls.Add(this.TxtSubtotalD);
            this.PnMostrarDestalles.Controls.Add(this.label11);
            this.PnMostrarDestalles.Controls.Add(this.label7);
            this.PnMostrarDestalles.Controls.Add(this.lblSubtotal);
            this.PnMostrarDestalles.Controls.Add(this.BtnCerrarD);
            this.PnMostrarDestalles.Location = new System.Drawing.Point(194, 65);
            this.PnMostrarDestalles.Name = "PnMostrarDestalles";
            this.PnMostrarDestalles.Size = new System.Drawing.Size(688, 290);
            this.PnMostrarDestalles.TabIndex = 7;
            this.PnMostrarDestalles.Visible = false;
            // 
            // DgvMostrarDetalles
            // 
            this.DgvMostrarDetalles.AllowUserToAddRows = false;
            this.DgvMostrarDetalles.AllowUserToDeleteRows = false;
            this.DgvMostrarDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMostrarDetalles.Location = new System.Drawing.Point(17, 38);
            this.DgvMostrarDetalles.Name = "DgvMostrarDetalles";
            this.DgvMostrarDetalles.ReadOnly = true;
            this.DgvMostrarDetalles.Size = new System.Drawing.Size(660, 156);
            this.DgvMostrarDetalles.TabIndex = 0;
            // 
            // BtnCerrarD
            // 
            this.BtnCerrarD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrarD.ForeColor = System.Drawing.Color.Blue;
            this.BtnCerrarD.Location = new System.Drawing.Point(653, 8);
            this.BtnCerrarD.Name = "BtnCerrarD";
            this.BtnCerrarD.Size = new System.Drawing.Size(24, 27);
            this.BtnCerrarD.TabIndex = 1;
            this.BtnCerrarD.Text = "x";
            this.BtnCerrarD.UseVisualStyleBackColor = true;
            this.BtnCerrarD.Click += new System.EventHandler(this.BtnCerrarD_Click);
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(417, 207);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(46, 13);
            this.lblSubtotal.TabIndex = 2;
            this.lblSubtotal.Text = "Subtotal";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(417, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Total";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(417, 255);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Impuesto";
            // 
            // TxtSubtotalD
            // 
            this.TxtSubtotalD.Location = new System.Drawing.Point(491, 200);
            this.TxtSubtotalD.Name = "TxtSubtotalD";
            this.TxtSubtotalD.Size = new System.Drawing.Size(100, 20);
            this.TxtSubtotalD.TabIndex = 5;
            // 
            // TxtTotalD
            // 
            this.TxtTotalD.Location = new System.Drawing.Point(491, 226);
            this.TxtTotalD.Name = "TxtTotalD";
            this.TxtTotalD.Size = new System.Drawing.Size(100, 20);
            this.TxtTotalD.TabIndex = 6;
            // 
            // TxtImpuestoD
            // 
            this.TxtImpuestoD.Location = new System.Drawing.Point(491, 252);
            this.TxtImpuestoD.Name = "TxtImpuestoD";
            this.TxtImpuestoD.Size = new System.Drawing.Size(100, 20);
            this.TxtImpuestoD.TabIndex = 7;
            // 
            // FrmIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 654);
            this.Controls.Add(this.tabGeneral);
            this.Name = "FrmIngreso";
            this.Text = "Ingresos";
            this.Load += new System.EventHandler(this.FrmIngreso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.GrbDetalle.ResumeLayout(false);
            this.GrbDetalle.PerformLayout();
            this.PanelArticulos.ResumeLayout(false);
            this.PanelArticulos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetalle)).EndInit();
            this.GrbCabecera.ResumeLayout(false);
            this.GrbCabecera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabGeneral.ResumeLayout(false);
            this.PnMostrarDestalles.ResumeLayout(false);
            this.PnMostrarDestalles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMostrarDetalles)).EndInit();
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
        private System.Windows.Forms.Button BtnVerArticulos;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label Articulo;
        private System.Windows.Forms.GroupBox GrbCabecera;
        private System.Windows.Forms.Label TxtNumero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtImpuesto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtNumeroComprobante;
        private System.Windows.Forms.TextBox TxtSerie;
        private System.Windows.Forms.ComboBox CboComprobante;
        private System.Windows.Forms.Button BtnBuscarProveedor;
        private System.Windows.Forms.TextBox TxtNombreProveedor;
        private System.Windows.Forms.TextBox TxtIdProveedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label LblTotalArticulos;
        private System.Windows.Forms.Panel PanelArticulos;
        private System.Windows.Forms.DataGridView DgvArticulos;
        private System.Windows.Forms.Button BtnCerrarArticulos;
        private System.Windows.Forms.Button BtnFiltrarArticulo;
        private System.Windows.Forms.TextBox TxtBuscarArticulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PnMostrarDestalles;
        private System.Windows.Forms.TextBox TxtImpuestoD;
        private System.Windows.Forms.TextBox TxtTotalD;
        private System.Windows.Forms.TextBox TxtSubtotalD;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Button BtnCerrarD;
        private System.Windows.Forms.DataGridView DgvMostrarDetalles;
    }
}