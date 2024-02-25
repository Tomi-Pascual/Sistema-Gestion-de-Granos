﻿namespace CapaPresentacion.Modales
{
    partial class MD_DetallePermisoUsuario
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
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            lbltitulo = new Label();
            label1 = new Label();
            cbestado = new ComboBox();
            label8 = new Label();
            txtnombrecompleto = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtid = new TextBox();
            dgvdata = new DataGridView();
            btnSeleccionar = new DataGridViewButtonColumn();
            IdComponente = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            TipoPermiso = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            EstadoValor = new DataGridViewTextBoxColumn();
            btnagregarpermiso = new FontAwesome.Sharp.IconButton();
            btneliminarpermiso = new FontAwesome.Sharp.IconButton();
            btnguardarpermiso = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dgvdata).BeginInit();
            SuspendLayout();
            // 
            // lbltitulo
            // 
            lbltitulo.BackColor = Color.White;
            lbltitulo.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lbltitulo.Location = new Point(12, 9);
            lbltitulo.Name = "lbltitulo";
            lbltitulo.Padding = new Padding(20, 0, 0, 0);
            lbltitulo.Size = new Size(1121, 58);
            lbltitulo.TabIndex = 50;
            lbltitulo.Text = "Permisos del Usuario";
            lbltitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Font = new Font("Microsoft Sans Serif", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 78);
            label1.Name = "label1";
            label1.Padding = new Padding(25, 5, 0, 0);
            label1.Size = new Size(1121, 58);
            label1.TabIndex = 52;
            label1.Text = "Información del Usuario";
            // 
            // cbestado
            // 
            cbestado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbestado.FormattingEnabled = true;
            cbestado.Location = new Point(684, 105);
            cbestado.Name = "cbestado";
            cbestado.Size = new Size(211, 28);
            cbestado.TabIndex = 56;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Location = new Point(684, 82);
            label8.Name = "label8";
            label8.Size = new Size(57, 20);
            label8.TabIndex = 55;
            label8.Text = "Estado:";
            // 
            // txtnombrecompleto
            // 
            txtnombrecompleto.Location = new Point(401, 106);
            txtnombrecompleto.Name = "txtnombrecompleto";
            txtnombrecompleto.Size = new Size(254, 27);
            txtnombrecompleto.TabIndex = 54;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(401, 83);
            label3.Name = "label3";
            label3.Size = new Size(137, 20);
            label3.TabIndex = 53;
            label3.Text = "Nombre Completo:";
            // 
            // label2
            // 
            label2.BackColor = Color.White;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 145);
            label2.Name = "label2";
            label2.Padding = new Padding(25, 5, 0, 0);
            label2.Size = new Size(1121, 474);
            label2.TabIndex = 57;
            label2.Text = "Lista de Permisos";
            // 
            // txtid
            // 
            txtid.Location = new Point(401, 155);
            txtid.Name = "txtid";
            txtid.Size = new Size(41, 27);
            txtid.TabIndex = 58;
            txtid.Text = "0";
            txtid.Visible = false;
            // 
            // dgvdata
            // 
            dgvdata.AllowUserToAddRows = false;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.Padding = new Padding(2);
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgvdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdata.Columns.AddRange(new DataGridViewColumn[] { btnSeleccionar, IdComponente, Nombre, TipoPermiso, Estado, EstadoValor });
            dgvdata.Location = new Point(306, 201);
            dgvdata.MultiSelect = false;
            dgvdata.Name = "dgvdata";
            dgvdata.ReadOnly = true;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = SystemColors.Control;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = Color.White;
            dataGridViewCellStyle10.SelectionForeColor = Color.Black;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dgvdata.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dgvdata.RowHeadersWidth = 51;
            dgvdata.RowTemplate.Height = 28;
            dgvdata.Size = new Size(811, 403);
            dgvdata.TabIndex = 59;
            dgvdata.CellClick += dgvdata_CellClick;
            dgvdata.CellPainting += dgvdata_CellPainting;
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.HeaderText = "";
            btnSeleccionar.MinimumWidth = 6;
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.ReadOnly = true;
            btnSeleccionar.Width = 30;
            // 
            // IdComponente
            // 
            IdComponente.HeaderText = "IdComponente";
            IdComponente.MinimumWidth = 6;
            IdComponente.Name = "IdComponente";
            IdComponente.ReadOnly = true;
            IdComponente.Visible = false;
            IdComponente.Width = 125;
            // 
            // Nombre
            // 
            Nombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // TipoPermiso
            // 
            TipoPermiso.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TipoPermiso.HeaderText = "TipoPermiso";
            TipoPermiso.MinimumWidth = 6;
            TipoPermiso.Name = "TipoPermiso";
            TipoPermiso.ReadOnly = true;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 6;
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            Estado.Width = 150;
            // 
            // EstadoValor
            // 
            EstadoValor.HeaderText = "Estado Valor";
            EstadoValor.MinimumWidth = 6;
            EstadoValor.Name = "EstadoValor";
            EstadoValor.ReadOnly = true;
            EstadoValor.Visible = false;
            EstadoValor.Width = 125;
            // 
            // btnagregarpermiso
            // 
            btnagregarpermiso.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnagregarpermiso.BackColor = Color.DarkOrange;
            btnagregarpermiso.Cursor = Cursors.Hand;
            btnagregarpermiso.FlatStyle = FlatStyle.Popup;
            btnagregarpermiso.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            btnagregarpermiso.IconColor = Color.Black;
            btnagregarpermiso.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnagregarpermiso.IconSize = 27;
            btnagregarpermiso.ImageAlign = ContentAlignment.BottomCenter;
            btnagregarpermiso.Location = new Point(40, 201);
            btnagregarpermiso.Name = "btnagregarpermiso";
            btnagregarpermiso.Size = new Size(240, 40);
            btnagregarpermiso.TabIndex = 60;
            btnagregarpermiso.Text = "Agregar Permisos";
            btnagregarpermiso.TextAlign = ContentAlignment.MiddleRight;
            btnagregarpermiso.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnagregarpermiso.UseVisualStyleBackColor = false;
            btnagregarpermiso.Click += btnagregarpermiso_Click;
            // 
            // btneliminarpermiso
            // 
            btneliminarpermiso.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btneliminarpermiso.BackColor = Color.DarkOrange;
            btneliminarpermiso.Cursor = Cursors.Hand;
            btneliminarpermiso.FlatStyle = FlatStyle.Popup;
            btneliminarpermiso.IconChar = FontAwesome.Sharp.IconChar.TimesSquare;
            btneliminarpermiso.IconColor = Color.Black;
            btneliminarpermiso.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btneliminarpermiso.IconSize = 26;
            btneliminarpermiso.Location = new Point(40, 252);
            btneliminarpermiso.Name = "btneliminarpermiso";
            btneliminarpermiso.Size = new Size(240, 40);
            btneliminarpermiso.TabIndex = 61;
            btneliminarpermiso.Text = "Eliminar Permisos";
            btneliminarpermiso.TextAlign = ContentAlignment.MiddleRight;
            btneliminarpermiso.TextImageRelation = TextImageRelation.ImageBeforeText;
            btneliminarpermiso.UseVisualStyleBackColor = false;
            btneliminarpermiso.Click += btneliminarpermiso_Click;
            // 
            // btnguardarpermiso
            // 
            btnguardarpermiso.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnguardarpermiso.BackColor = Color.DarkOrange;
            btnguardarpermiso.Cursor = Cursors.Hand;
            btnguardarpermiso.FlatStyle = FlatStyle.Popup;
            btnguardarpermiso.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            btnguardarpermiso.IconColor = Color.Black;
            btnguardarpermiso.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnguardarpermiso.IconSize = 24;
            btnguardarpermiso.Location = new Point(40, 564);
            btnguardarpermiso.Name = "btnguardarpermiso";
            btnguardarpermiso.Size = new Size(240, 40);
            btnguardarpermiso.TabIndex = 62;
            btnguardarpermiso.Text = "Guardar Permisos";
            btnguardarpermiso.TextAlign = ContentAlignment.MiddleRight;
            btnguardarpermiso.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnguardarpermiso.UseVisualStyleBackColor = false;
            btnguardarpermiso.Click += btnguardarpermiso_Click;
            // 
            // MD_DetallePermisoUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1145, 628);
            Controls.Add(btnguardarpermiso);
            Controls.Add(btneliminarpermiso);
            Controls.Add(btnagregarpermiso);
            Controls.Add(dgvdata);
            Controls.Add(txtid);
            Controls.Add(label2);
            Controls.Add(cbestado);
            Controls.Add(label8);
            Controls.Add(txtnombrecompleto);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(lbltitulo);
            Name = "MD_DetallePermisoUsuario";
            Text = "MD_DetallePermisoUsuario";
            Load += MD_DetallePermisoUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)dgvdata).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbltitulo;
        private Label label1;
        private ComboBox cbestado;
        private Label label8;
        private TextBox txtnombrecompleto;
        private Label label3;
        private Label label2;
        private TextBox txtid;
        private DataGridView dgvdata;
        private DataGridViewButtonColumn btnSeleccionar;
        private DataGridViewTextBoxColumn IdComponente;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn TipoPermiso;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn EstadoValor;
        private FontAwesome.Sharp.IconButton btnagregarpermiso;
        private FontAwesome.Sharp.IconButton btneliminarpermiso;
        private FontAwesome.Sharp.IconButton btnguardarpermiso;
    }
}