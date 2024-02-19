namespace CapaPresentacion
{
    partial class frmReportes
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
            btndescarcar = new FontAwesome.Sharp.IconButton();
            btnlimpiar = new FontAwesome.Sharp.IconButton();
            btnbuscarreporte = new FontAwesome.Sharp.IconButton();
            txtbuscarpor = new TextBox();
            cbbuscarpor = new ComboBox();
            label11 = new Label();
            SubTotal = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            PrecioVenta = new DataGridViewTextBoxColumn();
            PrecioCompra = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            NombreProducto = new DataGridViewTextBoxColumn();
            CodigoProducto = new DataGridViewTextBoxColumn();
            RazonSocial = new DataGridViewTextBoxColumn();
            btnbuscar = new FontAwesome.Sharp.IconButton();
            DocumentoProveedor = new DataGridViewTextBoxColumn();
            MontoTotal = new DataGridViewTextBoxColumn();
            NumeroDocumento = new DataGridViewTextBoxColumn();
            TipoDocumento = new DataGridViewTextBoxColumn();
            FechaRegistro = new DataGridViewTextBoxColumn();
            dgvdata = new DataGridView();
            UsuarioRegistro = new DataGridViewTextBoxColumn();
            label5 = new Label();
            cbproveedor = new ComboBox();
            label4 = new Label();
            dtpfechafin = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            label9 = new Label();
            label1 = new Label();
            dtpfechainicio = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvdata).BeginInit();
            SuspendLayout();
            // 
            // btndescarcar
            // 
            btndescarcar.BackColor = Color.LightGray;
            btndescarcar.Cursor = Cursors.Hand;
            btndescarcar.FlatStyle = FlatStyle.Popup;
            btndescarcar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btndescarcar.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            btndescarcar.IconColor = Color.LimeGreen;
            btndescarcar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btndescarcar.IconSize = 23;
            btndescarcar.Location = new Point(1068, 143);
            btndescarcar.Name = "btndescarcar";
            btndescarcar.Size = new Size(157, 29);
            btndescarcar.TabIndex = 84;
            btndescarcar.Text = "Descargar Excel";
            btndescarcar.TextAlign = ContentAlignment.TopRight;
            btndescarcar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btndescarcar.UseVisualStyleBackColor = false;
            // 
            // btnlimpiar
            // 
            btnlimpiar.BackColor = Color.LightGray;
            btnlimpiar.Cursor = Cursors.Hand;
            btnlimpiar.FlatStyle = FlatStyle.Flat;
            btnlimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            btnlimpiar.IconColor = Color.Black;
            btnlimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnlimpiar.IconSize = 22;
            btnlimpiar.Location = new Point(800, 69);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(39, 28);
            btnlimpiar.TabIndex = 82;
            btnlimpiar.UseVisualStyleBackColor = false;
            // 
            // btnbuscarreporte
            // 
            btnbuscarreporte.BackColor = Color.LightGray;
            btnbuscarreporte.Cursor = Cursors.Hand;
            btnbuscarreporte.FlatStyle = FlatStyle.Flat;
            btnbuscarreporte.IconChar = FontAwesome.Sharp.IconChar.SearchLocation;
            btnbuscarreporte.IconColor = Color.Black;
            btnbuscarreporte.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnbuscarreporte.IconSize = 22;
            btnbuscarreporte.Location = new Point(752, 69);
            btnbuscarreporte.Name = "btnbuscarreporte";
            btnbuscarreporte.Size = new Size(39, 28);
            btnbuscarreporte.TabIndex = 81;
            btnbuscarreporte.UseVisualStyleBackColor = false;
            // 
            // txtbuscarpor
            // 
            txtbuscarpor.Location = new Point(304, 143);
            txtbuscarpor.Name = "txtbuscarpor";
            txtbuscarpor.Size = new Size(200, 27);
            txtbuscarpor.TabIndex = 80;
            // 
            // cbbuscarpor
            // 
            cbbuscarpor.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbuscarpor.FormattingEnabled = true;
            cbbuscarpor.Location = new Point(120, 142);
            cbbuscarpor.Name = "cbbuscarpor";
            cbbuscarpor.Size = new Size(172, 28);
            cbbuscarpor.TabIndex = 79;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Location = new Point(32, 145);
            label11.Name = "label11";
            label11.Size = new Size(82, 20);
            label11.TabIndex = 78;
            label11.Text = "Buscar por:";
            // 
            // SubTotal
            // 
            SubTotal.HeaderText = "Sub Total";
            SubTotal.MinimumWidth = 6;
            SubTotal.Name = "SubTotal";
            SubTotal.Width = 125;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.Width = 125;
            // 
            // PrecioVenta
            // 
            PrecioVenta.HeaderText = "Precio Venta";
            PrecioVenta.MinimumWidth = 6;
            PrecioVenta.Name = "PrecioVenta";
            PrecioVenta.Width = 125;
            // 
            // PrecioCompra
            // 
            PrecioCompra.HeaderText = "Precio Compra";
            PrecioCompra.MinimumWidth = 6;
            PrecioCompra.Name = "PrecioCompra";
            PrecioCompra.Width = 125;
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Categoria";
            Categoria.MinimumWidth = 6;
            Categoria.Name = "Categoria";
            Categoria.Width = 125;
            // 
            // NombreProducto
            // 
            NombreProducto.HeaderText = "Nombre Producto";
            NombreProducto.MinimumWidth = 6;
            NombreProducto.Name = "NombreProducto";
            NombreProducto.Width = 125;
            // 
            // CodigoProducto
            // 
            CodigoProducto.HeaderText = "Codigo Producto";
            CodigoProducto.MinimumWidth = 6;
            CodigoProducto.Name = "CodigoProducto";
            CodigoProducto.Width = 125;
            // 
            // RazonSocial
            // 
            RazonSocial.HeaderText = "Razon Social";
            RazonSocial.MinimumWidth = 6;
            RazonSocial.Name = "RazonSocial";
            RazonSocial.Width = 125;
            // 
            // btnbuscar
            // 
            btnbuscar.BackColor = Color.LightGray;
            btnbuscar.Cursor = Cursors.Hand;
            btnbuscar.FlatStyle = FlatStyle.Popup;
            btnbuscar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnbuscar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            btnbuscar.IconColor = Color.Black;
            btnbuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnbuscar.IconSize = 24;
            btnbuscar.ImageAlign = ContentAlignment.TopCenter;
            btnbuscar.Location = new Point(521, 141);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(94, 29);
            btnbuscar.TabIndex = 83;
            btnbuscar.Text = "Buscar";
            btnbuscar.TextAlign = ContentAlignment.TopRight;
            btnbuscar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnbuscar.UseVisualStyleBackColor = false;
            // 
            // DocumentoProveedor
            // 
            DocumentoProveedor.HeaderText = "Documento Proveedor";
            DocumentoProveedor.MinimumWidth = 6;
            DocumentoProveedor.Name = "DocumentoProveedor";
            DocumentoProveedor.Width = 125;
            // 
            // MontoTotal
            // 
            MontoTotal.HeaderText = "Monto Total";
            MontoTotal.MinimumWidth = 6;
            MontoTotal.Name = "MontoTotal";
            MontoTotal.Width = 125;
            // 
            // NumeroDocumento
            // 
            NumeroDocumento.HeaderText = "Numero Documento";
            NumeroDocumento.MinimumWidth = 6;
            NumeroDocumento.Name = "NumeroDocumento";
            NumeroDocumento.Width = 125;
            // 
            // TipoDocumento
            // 
            TipoDocumento.HeaderText = "Tipo Documento";
            TipoDocumento.MinimumWidth = 6;
            TipoDocumento.Name = "TipoDocumento";
            TipoDocumento.Width = 125;
            // 
            // FechaRegistro
            // 
            FechaRegistro.HeaderText = "Fecha Registro";
            FechaRegistro.MinimumWidth = 6;
            FechaRegistro.Name = "FechaRegistro";
            FechaRegistro.Width = 125;
            // 
            // dgvdata
            // 
            dgvdata.AllowUserToAddRows = false;
            dgvdata.AllowUserToOrderColumns = true;
            dgvdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdata.Columns.AddRange(new DataGridViewColumn[] { FechaRegistro, TipoDocumento, NumeroDocumento, MontoTotal, UsuarioRegistro, DocumentoProveedor, RazonSocial, CodigoProducto, NombreProducto, Categoria, PrecioCompra, PrecioVenta, Cantidad, SubTotal });
            dgvdata.Location = new Point(24, 186);
            dgvdata.Name = "dgvdata";
            dgvdata.RowHeadersWidth = 51;
            dgvdata.RowTemplate.Height = 29;
            dgvdata.Size = new Size(1203, 490);
            dgvdata.TabIndex = 77;
            // 
            // UsuarioRegistro
            // 
            UsuarioRegistro.HeaderText = "UsuarioRegistro";
            UsuarioRegistro.MinimumWidth = 6;
            UsuarioRegistro.Name = "UsuarioRegistro";
            UsuarioRegistro.Width = 125;
            // 
            // label5
            // 
            label5.BackColor = Color.White;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.FlatStyle = FlatStyle.System;
            label5.Location = new Point(12, 121);
            label5.Name = "label5";
            label5.Size = new Size(1225, 573);
            label5.TabIndex = 76;
            // 
            // cbproveedor
            // 
            cbproveedor.DropDownStyle = ComboBoxStyle.DropDownList;
            cbproveedor.FormattingEnabled = true;
            cbproveedor.Location = new Point(570, 70);
            cbproveedor.Name = "cbproveedor";
            cbproveedor.Size = new Size(172, 28);
            cbproveedor.TabIndex = 75;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Location = new Point(484, 73);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 74;
            label4.Text = "Proveedor:";
            // 
            // dtpfechafin
            // 
            dtpfechafin.CustomFormat = "dd/MM/yyyy";
            dtpfechafin.Format = DateTimePickerFormat.Short;
            dtpfechafin.Location = new Point(340, 70);
            dtpfechafin.Name = "dtpfechafin";
            dtpfechafin.Size = new Size(127, 27);
            dtpfechafin.TabIndex = 73;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(262, 73);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 72;
            label3.Text = "Fecha Fin:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(24, 73);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 71;
            label2.Text = "Fecha Inicio:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(24, 30);
            label9.Name = "label9";
            label9.Size = new Size(227, 29);
            label9.TabIndex = 70;
            label9.Text = "Reporte Compras";
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.FlatStyle = FlatStyle.System;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(1225, 92);
            label1.TabIndex = 69;
            // 
            // dtpfechainicio
            // 
            dtpfechainicio.CustomFormat = "dd/MM/yyyy";
            dtpfechainicio.Format = DateTimePickerFormat.Short;
            dtpfechainicio.Location = new Point(119, 70);
            dtpfechainicio.Name = "dtpfechainicio";
            dtpfechainicio.Size = new Size(127, 27);
            dtpfechainicio.TabIndex = 68;
            // 
            // frmReportes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1253, 822);
            Controls.Add(btndescarcar);
            Controls.Add(btnlimpiar);
            Controls.Add(btnbuscarreporte);
            Controls.Add(txtbuscarpor);
            Controls.Add(cbbuscarpor);
            Controls.Add(label11);
            Controls.Add(btnbuscar);
            Controls.Add(dgvdata);
            Controls.Add(label5);
            Controls.Add(cbproveedor);
            Controls.Add(label4);
            Controls.Add(dtpfechafin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label9);
            Controls.Add(label1);
            Controls.Add(dtpfechainicio);
            Name = "frmReportes";
            Text = "frmReportes";
            ((System.ComponentModel.ISupportInitialize)dgvdata).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btndescarcar;
        private FontAwesome.Sharp.IconButton btnlimpiar;
        private FontAwesome.Sharp.IconButton btnbuscarreporte;
        private TextBox txtbuscarpor;
        private ComboBox cbbuscarpor;
        private Label label11;
        private DataGridViewTextBoxColumn SubTotal;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn PrecioVenta;
        private DataGridViewTextBoxColumn PrecioCompra;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn NombreProducto;
        private DataGridViewTextBoxColumn CodigoProducto;
        private DataGridViewTextBoxColumn RazonSocial;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private DataGridViewTextBoxColumn DocumentoProveedor;
        private DataGridViewTextBoxColumn MontoTotal;
        private DataGridViewTextBoxColumn NumeroDocumento;
        private DataGridViewTextBoxColumn TipoDocumento;
        private DataGridViewTextBoxColumn FechaRegistro;
        private DataGridView dgvdata;
        private DataGridViewTextBoxColumn UsuarioRegistro;
        private Label label5;
        private ComboBox cbproveedor;
        private Label label4;
        private DateTimePicker dtpfechafin;
        private Label label3;
        private Label label2;
        private Label label9;
        private Label label1;
        private DateTimePicker dtpfechainicio;
    }
}