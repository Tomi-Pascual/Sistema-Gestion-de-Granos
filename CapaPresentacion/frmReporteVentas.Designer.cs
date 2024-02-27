namespace CapaPresentacion
{
    partial class frmReporteVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteVentas));
            label5 = new Label();
            dtpfechafin = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            label9 = new Label();
            dtpfechainicio = new DateTimePicker();
            dgvdata = new DataGridView();
            FechaRegistro = new DataGridViewTextBoxColumn();
            TipoDocumento = new DataGridViewTextBoxColumn();
            NumeroDocumento = new DataGridViewTextBoxColumn();
            MontoTotal = new DataGridViewTextBoxColumn();
            UsuarioRegistro = new DataGridViewTextBoxColumn();
            DocumentoCliente = new DataGridViewTextBoxColumn();
            NombreCliente = new DataGridViewTextBoxColumn();
            CodigoProducto = new DataGridViewTextBoxColumn();
            NombreProducto = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            PrecioVenta = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            label1 = new Label();
            btndescarcar = new FontAwesome.Sharp.IconButton();
            btnbuscarpor = new FontAwesome.Sharp.IconButton();
            txtbuscarpor = new TextBox();
            cbbuscarpor = new ComboBox();
            label11 = new Label();
            btnbuscarreporte = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dgvdata).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.BackColor = Color.White;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.FlatStyle = FlatStyle.System;
            label5.Location = new Point(12, 112);
            label5.Name = "label5";
            label5.Size = new Size(1221, 573);
            label5.TabIndex = 93;
            // 
            // dtpfechafin
            // 
            dtpfechafin.CustomFormat = "dd/MM/yyyy";
            dtpfechafin.Format = DateTimePickerFormat.Short;
            dtpfechafin.Location = new Point(340, 61);
            dtpfechafin.Name = "dtpfechafin";
            dtpfechafin.Size = new Size(127, 27);
            dtpfechafin.TabIndex = 90;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(262, 64);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 89;
            label3.Text = "Fecha Fin:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(24, 64);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 88;
            label2.Text = "Fecha Inicio:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(24, 21);
            label9.Name = "label9";
            label9.Size = new Size(202, 29);
            label9.TabIndex = 87;
            label9.Text = "Reporte Ventas";
            // 
            // dtpfechainicio
            // 
            dtpfechainicio.CustomFormat = "dd/MM/yyyy";
            dtpfechainicio.Format = DateTimePickerFormat.Short;
            dtpfechainicio.Location = new Point(119, 61);
            dtpfechainicio.Name = "dtpfechainicio";
            dtpfechainicio.Size = new Size(127, 27);
            dtpfechainicio.TabIndex = 85;
            // 
            // dgvdata
            // 
            dgvdata.AllowUserToAddRows = false;
            dgvdata.AllowUserToOrderColumns = true;
            dgvdata.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdata.Columns.AddRange(new DataGridViewColumn[] { FechaRegistro, TipoDocumento, NumeroDocumento, MontoTotal, UsuarioRegistro, DocumentoCliente, NombreCliente, CodigoProducto, NombreProducto, Categoria, PrecioVenta, Cantidad, SubTotal });
            dgvdata.Location = new Point(24, 177);
            dgvdata.Name = "dgvdata";
            dgvdata.RowHeadersWidth = 51;
            dgvdata.RowTemplate.Height = 29;
            dgvdata.Size = new Size(1197, 487);
            dgvdata.TabIndex = 94;
            // 
            // FechaRegistro
            // 
            FechaRegistro.HeaderText = "Fecha Registro";
            FechaRegistro.MinimumWidth = 6;
            FechaRegistro.Name = "FechaRegistro";
            FechaRegistro.Width = 125;
            // 
            // TipoDocumento
            // 
            TipoDocumento.HeaderText = "Tipo Documento";
            TipoDocumento.MinimumWidth = 6;
            TipoDocumento.Name = "TipoDocumento";
            TipoDocumento.Width = 125;
            // 
            // NumeroDocumento
            // 
            NumeroDocumento.HeaderText = "Numero Documento";
            NumeroDocumento.MinimumWidth = 6;
            NumeroDocumento.Name = "NumeroDocumento";
            NumeroDocumento.Width = 125;
            // 
            // MontoTotal
            // 
            MontoTotal.HeaderText = "Monto Total";
            MontoTotal.MinimumWidth = 6;
            MontoTotal.Name = "MontoTotal";
            MontoTotal.Width = 125;
            // 
            // UsuarioRegistro
            // 
            UsuarioRegistro.HeaderText = "UsuarioRegistro";
            UsuarioRegistro.MinimumWidth = 6;
            UsuarioRegistro.Name = "UsuarioRegistro";
            UsuarioRegistro.Width = 125;
            // 
            // DocumentoCliente
            // 
            DocumentoCliente.HeaderText = "Documento Cliente";
            DocumentoCliente.MinimumWidth = 6;
            DocumentoCliente.Name = "DocumentoCliente";
            DocumentoCliente.Width = 125;
            // 
            // NombreCliente
            // 
            NombreCliente.HeaderText = "Nombre Cliente";
            NombreCliente.MinimumWidth = 6;
            NombreCliente.Name = "NombreCliente";
            NombreCliente.Width = 125;
            // 
            // CodigoProducto
            // 
            CodigoProducto.HeaderText = "Codigo Producto";
            CodigoProducto.MinimumWidth = 6;
            CodigoProducto.Name = "CodigoProducto";
            CodigoProducto.Width = 125;
            // 
            // NombreProducto
            // 
            NombreProducto.HeaderText = "Nombre Producto";
            NombreProducto.MinimumWidth = 6;
            NombreProducto.Name = "NombreProducto";
            NombreProducto.Width = 125;
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Categoria";
            Categoria.MinimumWidth = 6;
            Categoria.Name = "Categoria";
            Categoria.Width = 125;
            // 
            // PrecioVenta
            // 
            PrecioVenta.HeaderText = "Precio Venta";
            PrecioVenta.MinimumWidth = 6;
            PrecioVenta.Name = "PrecioVenta";
            PrecioVenta.Width = 125;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.Width = 125;
            // 
            // SubTotal
            // 
            SubTotal.HeaderText = "Sub Total";
            SubTotal.MinimumWidth = 6;
            SubTotal.Name = "SubTotal";
            SubTotal.Width = 125;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.White;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.FlatStyle = FlatStyle.System;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(1221, 92);
            label1.TabIndex = 86;
            // 
            // btndescarcar
            // 
            btndescarcar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btndescarcar.BackColor = Color.LightGray;
            btndescarcar.Cursor = Cursors.Hand;
            btndescarcar.FlatStyle = FlatStyle.Popup;
            btndescarcar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btndescarcar.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            btndescarcar.IconColor = Color.LimeGreen;
            btndescarcar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btndescarcar.IconSize = 23;
            btndescarcar.Location = new Point(1064, 134);
            btndescarcar.Name = "btndescarcar";
            btndescarcar.Size = new Size(157, 29);
            btndescarcar.TabIndex = 101;
            btndescarcar.Text = "Descargar Excel";
            btndescarcar.TextAlign = ContentAlignment.TopRight;
            btndescarcar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btndescarcar.UseVisualStyleBackColor = false;
            btndescarcar.Click += btndescarcar_Click;
            // 
            // btnbuscarpor
            // 
            btnbuscarpor.BackColor = Color.White;
            btnbuscarpor.Cursor = Cursors.Hand;
            btnbuscarpor.FlatStyle = FlatStyle.Flat;
            btnbuscarpor.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnbuscarpor.IconChar = FontAwesome.Sharp.IconChar.SearchLocation;
            btnbuscarpor.IconColor = Color.Black;
            btnbuscarpor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnbuscarpor.IconSize = 22;
            btnbuscarpor.Location = new Point(515, 134);
            btnbuscarpor.Name = "btnbuscarpor";
            btnbuscarpor.Size = new Size(39, 28);
            btnbuscarpor.TabIndex = 98;
            btnbuscarpor.TextAlign = ContentAlignment.TopRight;
            btnbuscarpor.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnbuscarpor.UseVisualStyleBackColor = false;
            btnbuscarpor.Click += btnbuscarpor_Click;
            // 
            // txtbuscarpor
            // 
            txtbuscarpor.Location = new Point(304, 134);
            txtbuscarpor.Name = "txtbuscarpor";
            txtbuscarpor.Size = new Size(200, 27);
            txtbuscarpor.TabIndex = 97;
            // 
            // cbbuscarpor
            // 
            cbbuscarpor.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbuscarpor.FormattingEnabled = true;
            cbbuscarpor.Location = new Point(120, 133);
            cbbuscarpor.Name = "cbbuscarpor";
            cbbuscarpor.Size = new Size(172, 28);
            cbbuscarpor.TabIndex = 96;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Location = new Point(32, 136);
            label11.Name = "label11";
            label11.Size = new Size(82, 20);
            label11.TabIndex = 95;
            label11.Text = "Buscar por:";
            // 
            // btnbuscarreporte
            // 
            btnbuscarreporte.BackColor = Color.LightGray;
            btnbuscarreporte.Cursor = Cursors.Hand;
            btnbuscarreporte.FlatStyle = FlatStyle.Popup;
            btnbuscarreporte.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnbuscarreporte.IconChar = FontAwesome.Sharp.IconChar.SearchLocation;
            btnbuscarreporte.IconColor = Color.Black;
            btnbuscarreporte.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnbuscarreporte.IconSize = 24;
            btnbuscarreporte.ImageAlign = ContentAlignment.TopCenter;
            btnbuscarreporte.Location = new Point(482, 60);
            btnbuscarreporte.Name = "btnbuscarreporte";
            btnbuscarreporte.Size = new Size(105, 28);
            btnbuscarreporte.TabIndex = 100;
            btnbuscarreporte.Text = "Buscar";
            btnbuscarreporte.TextAlign = ContentAlignment.TopRight;
            btnbuscarreporte.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnbuscarreporte.UseVisualStyleBackColor = false;
            btnbuscarreporte.Click += btnbuscarreporte_Click;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.White;
            iconButton1.FlatStyle = FlatStyle.Popup;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Broom;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 24;
            iconButton1.Location = new Point(563, 134);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(39, 28);
            iconButton1.TabIndex = 102;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // frmReporteVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1249, 694);
            Controls.Add(iconButton1);
            Controls.Add(dtpfechafin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label9);
            Controls.Add(dtpfechainicio);
            Controls.Add(dgvdata);
            Controls.Add(btndescarcar);
            Controls.Add(btnbuscarpor);
            Controls.Add(txtbuscarpor);
            Controls.Add(cbbuscarpor);
            Controls.Add(label11);
            Controls.Add(btnbuscarreporte);
            Controls.Add(label1);
            Controls.Add(label5);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmReporteVentas";
            Text = "frmReporteVentas";
            Load += frmReporteVentas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvdata).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private DateTimePicker dtpfechafin;
        private Label label3;
        private Label label2;
        private Label label9;
        private DateTimePicker dtpfechainicio;
        private DataGridView dgvdata;
        private Label label1;
        private FontAwesome.Sharp.IconButton btndescarcar;
        private FontAwesome.Sharp.IconButton btnbuscarpor;
        private TextBox txtbuscarpor;
        private ComboBox cbbuscarpor;
        private Label label11;
        private FontAwesome.Sharp.IconButton btnbuscarreporte;
        private DataGridViewTextBoxColumn FechaRegistro;
        private DataGridViewTextBoxColumn TipoDocumento;
        private DataGridViewTextBoxColumn NumeroDocumento;
        private DataGridViewTextBoxColumn MontoTotal;
        private DataGridViewTextBoxColumn UsuarioRegistro;
        private DataGridViewTextBoxColumn DocumentoCliente;
        private DataGridViewTextBoxColumn NombreCliente;
        private DataGridViewTextBoxColumn CodigoProducto;
        private DataGridViewTextBoxColumn NombreProducto;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn PrecioVenta;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn SubTotal;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}