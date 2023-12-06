namespace CapaPresentacion
{
    partial class frmCompras
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
            label10 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            cbotipodocumento = new ComboBox();
            txtfecha = new TextBox();
            groupBox2 = new GroupBox();
            txtidproveedor = new TextBox();
            txtrazonsocial = new TextBox();
            btnbuscarprov = new FontAwesome.Sharp.IconButton();
            label4 = new Label();
            label5 = new Label();
            txtdocproveedor = new TextBox();
            groupBox3 = new GroupBox();
            txtcantidad = new TextBox();
            label11 = new Label();
            label9 = new Label();
            txtprecioventa = new TextBox();
            label8 = new Label();
            txtpreciocompra = new TextBox();
            txtidproducto = new TextBox();
            txtproducto = new TextBox();
            btnbuscarproducto = new FontAwesome.Sharp.IconButton();
            label6 = new Label();
            label7 = new Label();
            txtcodigoproducto = new TextBox();
            dataGridView1 = new DataGridView();
            IdProducto = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            PrecioCompra = new DataGridViewTextBoxColumn();
            PrecioVenta = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            btneliminar = new DataGridViewButtonColumn();
            btnagregar = new FontAwesome.Sharp.IconButton();
            label12 = new Label();
            txttotal = new TextBox();
            btnregistrar = new FontAwesome.Sharp.IconButton();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label10
            // 
            label10.BackColor = Color.White;
            label10.BorderStyle = BorderStyle.FixedSingle;
            label10.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(104, 9);
            label10.Name = "label10";
            label10.Size = new Size(1029, 663);
            label10.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(123, 18);
            label1.Name = "label1";
            label1.Size = new Size(228, 29);
            label1.TabIndex = 21;
            label1.Text = "Registrar Compra";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cbotipodocumento);
            groupBox1.Controls.Add(txtfecha);
            groupBox1.Location = new Point(123, 63);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(460, 103);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Información Compra";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(230, 39);
            label3.Name = "label3";
            label3.Size = new Size(124, 20);
            label3.TabIndex = 3;
            label3.Text = "Tipo Documento:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 39);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 2;
            label2.Text = "Fecha:";
            // 
            // cbotipodocumento
            // 
            cbotipodocumento.FormattingEnabled = true;
            cbotipodocumento.Location = new Point(230, 64);
            cbotipodocumento.Name = "cbotipodocumento";
            cbotipodocumento.Size = new Size(222, 28);
            cbotipodocumento.TabIndex = 1;
            // 
            // txtfecha
            // 
            txtfecha.Location = new Point(13, 64);
            txtfecha.Name = "txtfecha";
            txtfecha.Size = new Size(198, 27);
            txtfecha.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(txtidproveedor);
            groupBox2.Controls.Add(txtrazonsocial);
            groupBox2.Controls.Add(btnbuscarprov);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtdocproveedor);
            groupBox2.Location = new Point(605, 63);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(507, 103);
            groupBox2.TabIndex = 23;
            groupBox2.TabStop = false;
            groupBox2.Text = "Información Proveedor";
            // 
            // txtidproveedor
            // 
            txtidproveedor.Location = new Point(458, 32);
            txtidproveedor.Name = "txtidproveedor";
            txtidproveedor.Size = new Size(41, 27);
            txtidproveedor.TabIndex = 28;
            txtidproveedor.Visible = false;
            // 
            // txtrazonsocial
            // 
            txtrazonsocial.Location = new Point(268, 62);
            txtrazonsocial.Name = "txtrazonsocial";
            txtrazonsocial.Size = new Size(231, 27);
            txtrazonsocial.TabIndex = 27;
            // 
            // btnbuscarprov
            // 
            btnbuscarprov.BackColor = Color.LightGray;
            btnbuscarprov.Cursor = Cursors.Hand;
            btnbuscarprov.FlatAppearance.BorderColor = Color.Black;
            btnbuscarprov.FlatStyle = FlatStyle.Flat;
            btnbuscarprov.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnbuscarprov.ForeColor = Color.White;
            btnbuscarprov.IconChar = FontAwesome.Sharp.IconChar.SearchLocation;
            btnbuscarprov.IconColor = Color.Black;
            btnbuscarprov.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnbuscarprov.IconSize = 22;
            btnbuscarprov.Location = new Point(220, 62);
            btnbuscarprov.Name = "btnbuscarprov";
            btnbuscarprov.Size = new Size(39, 28);
            btnbuscarprov.TabIndex = 26;
            btnbuscarprov.UseVisualStyleBackColor = false;
            btnbuscarprov.Click += btnbuscarprov_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(268, 36);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 3;
            label4.Text = "Razón Social:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 39);
            label5.Name = "label5";
            label5.Size = new Size(148, 20);
            label5.TabIndex = 2;
            label5.Text = "Numero Documento:";
            // 
            // txtdocproveedor
            // 
            txtdocproveedor.Location = new Point(13, 64);
            txtdocproveedor.Name = "txtdocproveedor";
            txtdocproveedor.Size = new Size(196, 27);
            txtdocproveedor.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.White;
            groupBox3.Controls.Add(txtcantidad);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(txtprecioventa);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(txtpreciocompra);
            groupBox3.Controls.Add(txtidproducto);
            groupBox3.Controls.Add(txtproducto);
            groupBox3.Controls.Add(btnbuscarproducto);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(txtcodigoproducto);
            groupBox3.Location = new Point(123, 172);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(859, 100);
            groupBox3.TabIndex = 29;
            groupBox3.TabStop = false;
            groupBox3.Text = "Información Producto";
            // 
            // txtcantidad
            // 
            txtcantidad.Location = new Point(717, 64);
            txtcantidad.Name = "txtcantidad";
            txtcantidad.Size = new Size(125, 27);
            txtcantidad.TabIndex = 34;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(718, 39);
            label11.Name = "label11";
            label11.Size = new Size(72, 20);
            label11.TabIndex = 33;
            label11.Text = "Cantidad:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(597, 39);
            label9.Name = "label9";
            label9.Size = new Size(94, 20);
            label9.TabIndex = 32;
            label9.Text = "Precio Venta:";
            // 
            // txtprecioventa
            // 
            txtprecioventa.Location = new Point(598, 64);
            txtprecioventa.Name = "txtprecioventa";
            txtprecioventa.Size = new Size(110, 27);
            txtprecioventa.TabIndex = 31;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(480, 39);
            label8.Name = "label8";
            label8.Size = new Size(110, 20);
            label8.TabIndex = 30;
            label8.Text = "Precio Compra:";
            // 
            // txtpreciocompra
            // 
            txtpreciocompra.Location = new Point(480, 64);
            txtpreciocompra.Name = "txtpreciocompra";
            txtpreciocompra.Size = new Size(110, 27);
            txtpreciocompra.TabIndex = 29;
            // 
            // txtidproducto
            // 
            txtidproducto.Location = new Point(149, 34);
            txtidproducto.Name = "txtidproducto";
            txtidproducto.Size = new Size(41, 27);
            txtidproducto.TabIndex = 28;
            txtidproducto.Visible = false;
            // 
            // txtproducto
            // 
            txtproducto.Location = new Point(245, 64);
            txtproducto.Name = "txtproducto";
            txtproducto.Size = new Size(226, 27);
            txtproducto.TabIndex = 27;
            // 
            // btnbuscarproducto
            // 
            btnbuscarproducto.BackColor = Color.LightGray;
            btnbuscarproducto.Cursor = Cursors.Hand;
            btnbuscarproducto.FlatAppearance.BorderColor = Color.Black;
            btnbuscarproducto.FlatStyle = FlatStyle.Flat;
            btnbuscarproducto.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnbuscarproducto.ForeColor = Color.White;
            btnbuscarproducto.IconChar = FontAwesome.Sharp.IconChar.SearchLocation;
            btnbuscarproducto.IconColor = Color.Black;
            btnbuscarproducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnbuscarproducto.IconSize = 22;
            btnbuscarproducto.Location = new Point(198, 63);
            btnbuscarproducto.Name = "btnbuscarproducto";
            btnbuscarproducto.Size = new Size(39, 28);
            btnbuscarproducto.TabIndex = 26;
            btnbuscarproducto.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(245, 36);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 3;
            label6.Text = "Producto:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 39);
            label7.Name = "label7";
            label7.Size = new Size(125, 20);
            label7.TabIndex = 2;
            label7.Text = "Codigo Producto:";
            // 
            // txtcodigoproducto
            // 
            txtcodigoproducto.Location = new Point(13, 64);
            txtcodigoproducto.Name = "txtcodigoproducto";
            txtcodigoproducto.Size = new Size(177, 27);
            txtcodigoproducto.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IdProducto, Producto, PrecioCompra, PrecioVenta, Cantidad, SubTotal, btneliminar });
            dataGridView1.Location = new Point(123, 286);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(859, 377);
            dataGridView1.TabIndex = 30;
            // 
            // IdProducto
            // 
            IdProducto.HeaderText = "IdProducto";
            IdProducto.MinimumWidth = 6;
            IdProducto.Name = "IdProducto";
            IdProducto.Visible = false;
            IdProducto.Width = 125;
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.MinimumWidth = 6;
            Producto.Name = "Producto";
            Producto.Width = 170;
            // 
            // PrecioCompra
            // 
            PrecioCompra.HeaderText = "Precio Compra";
            PrecioCompra.MinimumWidth = 6;
            PrecioCompra.Name = "PrecioCompra";
            PrecioCompra.Width = 140;
            // 
            // PrecioVenta
            // 
            PrecioVenta.HeaderText = "Precio Venta";
            PrecioVenta.MinimumWidth = 6;
            PrecioVenta.Name = "PrecioVenta";
            PrecioVenta.Visible = false;
            PrecioVenta.Width = 125;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.Width = 120;
            // 
            // SubTotal
            // 
            SubTotal.HeaderText = "Sub Total";
            SubTotal.MinimumWidth = 6;
            SubTotal.Name = "SubTotal";
            SubTotal.Width = 130;
            // 
            // btneliminar
            // 
            btneliminar.HeaderText = "";
            btneliminar.MinimumWidth = 6;
            btneliminar.Name = "btneliminar";
            btneliminar.Resizable = DataGridViewTriState.True;
            btneliminar.SortMode = DataGridViewColumnSortMode.Automatic;
            btneliminar.Width = 40;
            // 
            // btnagregar
            // 
            btnagregar.IconChar = FontAwesome.Sharp.IconChar.Add;
            btnagregar.IconColor = Color.Green;
            btnagregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnagregar.Location = new Point(998, 182);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(108, 90);
            btnagregar.TabIndex = 31;
            btnagregar.Text = "Agregar";
            btnagregar.TextAlign = ContentAlignment.TopCenter;
            btnagregar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnagregar.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.White;
            label12.Location = new Point(998, 552);
            label12.Name = "label12";
            label12.Size = new Size(100, 20);
            label12.TabIndex = 32;
            label12.Text = "Total a pagar:";
            // 
            // txttotal
            // 
            txttotal.Location = new Point(998, 577);
            txttotal.Multiline = true;
            txttotal.Name = "txttotal";
            txttotal.Size = new Size(114, 27);
            txttotal.TabIndex = 33;
            txttotal.Text = "0";
            // 
            // btnregistrar
            // 
            btnregistrar.IconChar = FontAwesome.Sharp.IconChar.Tag;
            btnregistrar.IconColor = Color.DodgerBlue;
            btnregistrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnregistrar.IconSize = 30;
            btnregistrar.Location = new Point(998, 625);
            btnregistrar.Name = "btnregistrar";
            btnregistrar.Size = new Size(114, 38);
            btnregistrar.TabIndex = 34;
            btnregistrar.Text = "Registrar";
            btnregistrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnregistrar.UseVisualStyleBackColor = true;
            btnregistrar.Click += btnregistrar_Click;
            // 
            // frmCompras
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1249, 694);
            Controls.Add(btnregistrar);
            Controls.Add(txttotal);
            Controls.Add(label12);
            Controls.Add(btnagregar);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(label10);
            Name = "frmCompras";
            Text = "frmCompras";
            Load += frmCompras_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label10;
        private Label label1;
        private GroupBox groupBox1;
        private ComboBox cbotipodocumento;
        private TextBox txtfecha;
        private Label label3;
        private Label label2;
        private GroupBox groupBox2;
        private Label label4;
        private Label label5;
        private ComboBox comboBox1;
        private TextBox txtdocproveedor;
        private TextBox txtidproveedor;
        private TextBox txtrazonsocial;
        private FontAwesome.Sharp.IconButton btnbuscarprov;
        private GroupBox groupBox3;
        private TextBox txtidproducto;
        private TextBox txtproducto;
        private FontAwesome.Sharp.IconButton btnbuscarproducto;
        private Label label6;
        private Label label7;
        private TextBox txtcodigoproducto;
        private TextBox txtcantidad;
        private Label label11;
        private Label label9;
        private TextBox txtprecioventa;
        private Label label8;
        private TextBox txtpreciocompra;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn IdProducto;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn PrecioCompra;
        private DataGridViewTextBoxColumn PrecioVenta;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn SubTotal;
        private DataGridViewButtonColumn btneliminar;
        private FontAwesome.Sharp.IconButton btnagregar;
        private Label label12;
        private TextBox txttotal;
        private FontAwesome.Sharp.IconButton btnregistrar;
    }
}