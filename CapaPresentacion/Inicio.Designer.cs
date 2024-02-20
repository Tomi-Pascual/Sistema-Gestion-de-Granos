﻿namespace CapaPresentación
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            menu = new MenuStrip();
            menuseguridad = new FontAwesome.Sharp.IconMenuItem();
            menuventas = new FontAwesome.Sharp.IconMenuItem();
            submenuClientes = new ToolStripMenuItem();
            submenudetventa = new ToolStripMenuItem();
            submenuVentas = new ToolStripMenuItem();
            menucompras = new FontAwesome.Sharp.IconMenuItem();
            submenuCategoria = new ToolStripMenuItem();
            submenudetcompra = new ToolStripMenuItem();
            submenunegocio = new ToolStripMenuItem();
            submenuProducto = new ToolStripMenuItem();
            submenuProveedores = new ToolStripMenuItem();
            submenuCompras = new ToolStripMenuItem();
            menureportes = new FontAwesome.Sharp.IconMenuItem();
            submenureportecompras = new ToolStripMenuItem();
            submenureporteventas = new ToolStripMenuItem();
            menuacercade = new FontAwesome.Sharp.IconMenuItem();
            contenedor = new Panel();
            label1 = new Label();
            label2 = new Label();
            lblUsuario = new Label();
            menuStrip1 = new MenuStrip();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            menu.SuspendLayout();
            SuspendLayout();
            // 
            // menu
            // 
            menu.BackColor = Color.White;
            menu.ImageScalingSize = new Size(20, 20);
            menu.Items.AddRange(new ToolStripItem[] { menuseguridad, menuventas, menucompras, menureportes, menuacercade });
            menu.Location = new Point(0, 73);
            menu.Name = "menu";
            menu.Size = new Size(1253, 73);
            menu.TabIndex = 0;
            menu.Text = "menuStrip1";
            // 
            // menuseguridad
            // 
            menuseguridad.AutoSize = false;
            menuseguridad.IconChar = FontAwesome.Sharp.IconChar.UsersCog;
            menuseguridad.IconColor = Color.Black;
            menuseguridad.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuseguridad.IconSize = 50;
            menuseguridad.ImageScaling = ToolStripItemImageScaling.None;
            menuseguridad.Name = "menuseguridad";
            menuseguridad.Size = new Size(85, 69);
            menuseguridad.Text = "Seguridad";
            menuseguridad.TextImageRelation = TextImageRelation.ImageAboveText;
            menuseguridad.Click += menuusuario_Click;
            // 
            // menuventas
            // 
            menuventas.AutoSize = false;
            menuventas.DropDownItems.AddRange(new ToolStripItem[] { submenuClientes, submenudetventa, submenuVentas });
            menuventas.IconChar = FontAwesome.Sharp.IconChar.Tags;
            menuventas.IconColor = Color.Black;
            menuventas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuventas.IconSize = 50;
            menuventas.ImageScaling = ToolStripItemImageScaling.None;
            menuventas.Name = "menuventas";
            menuventas.Size = new Size(85, 69);
            menuventas.Text = "Ventas";
            menuventas.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // submenuClientes
            // 
            submenuClientes.Name = "submenuClientes";
            submenuClientes.Size = new Size(192, 26);
            submenuClientes.Text = "Clientes";
            submenuClientes.Click += submenuClientes_Click;
            // 
            // submenudetventa
            // 
            submenudetventa.Name = "submenudetventa";
            submenudetventa.Size = new Size(192, 26);
            submenudetventa.Text = "Detalle Venta";
            submenudetventa.Click += submenudetventa_Click;
            // 
            // submenuVentas
            // 
            submenuVentas.Name = "submenuVentas";
            submenuVentas.Size = new Size(192, 26);
            submenuVentas.Text = "Registrar Venta";
            submenuVentas.Click += submenuVentas_Click;
            // 
            // menucompras
            // 
            menucompras.AutoSize = false;
            menucompras.DropDownItems.AddRange(new ToolStripItem[] { submenuCategoria, submenudetcompra, submenunegocio, submenuProducto, submenuProveedores, submenuCompras });
            menucompras.IconChar = FontAwesome.Sharp.IconChar.DollyFlatbed;
            menucompras.IconColor = Color.Black;
            menucompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menucompras.IconSize = 50;
            menucompras.ImageScaling = ToolStripItemImageScaling.None;
            menucompras.Name = "menucompras";
            menucompras.Size = new Size(85, 69);
            menucompras.Text = "Compras";
            menucompras.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // submenuCategoria
            // 
            submenuCategoria.Name = "submenuCategoria";
            submenuCategoria.Size = new Size(208, 26);
            submenuCategoria.Text = "Categoria";
            submenuCategoria.Click += submenuCategoria_Click;
            // 
            // submenudetcompra
            // 
            submenudetcompra.Name = "submenudetcompra";
            submenudetcompra.Size = new Size(208, 26);
            submenudetcompra.Text = "Detalle Compra";
            submenudetcompra.Click += submenudetcompra_Click;
            // 
            // submenunegocio
            // 
            submenunegocio.Name = "submenunegocio";
            submenunegocio.Size = new Size(208, 26);
            submenunegocio.Text = "Negocio";
            submenunegocio.Click += submenunegocio_Click;
            // 
            // submenuProducto
            // 
            submenuProducto.Name = "submenuProducto";
            submenuProducto.Size = new Size(208, 26);
            submenuProducto.Text = "Producto";
            submenuProducto.Click += submenuProducto_Click;
            // 
            // submenuProveedores
            // 
            submenuProveedores.Name = "submenuProveedores";
            submenuProveedores.Size = new Size(208, 26);
            submenuProveedores.Text = "Proveedores";
            submenuProveedores.Click += submenuProveedores_Click;
            // 
            // submenuCompras
            // 
            submenuCompras.Name = "submenuCompras";
            submenuCompras.Size = new Size(208, 26);
            submenuCompras.Text = "Registrar Compra";
            submenuCompras.Click += submenuCompras_Click;
            // 
            // menureportes
            // 
            menureportes.AutoSize = false;
            menureportes.DropDownItems.AddRange(new ToolStripItem[] { submenureportecompras, submenureporteventas });
            menureportes.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            menureportes.IconColor = Color.Black;
            menureportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menureportes.IconSize = 50;
            menureportes.ImageScaling = ToolStripItemImageScaling.None;
            menureportes.Name = "menureportes";
            menureportes.Size = new Size(85, 69);
            menureportes.Text = "Reportes";
            menureportes.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // submenureportecompras
            // 
            submenureportecompras.Name = "submenureportecompras";
            submenureportecompras.Size = new Size(208, 26);
            submenureportecompras.Text = "Reporte Compras";
            submenureportecompras.Click += submenureportecompras_Click;
            // 
            // submenureporteventas
            // 
            submenureporteventas.Name = "submenureporteventas";
            submenureporteventas.Size = new Size(208, 26);
            submenureporteventas.Text = "Reporte Ventas";
            submenureporteventas.Click += submenureporteventas_Click;
            // 
            // menuacercade
            // 
            menuacercade.AutoSize = false;
            menuacercade.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            menuacercade.IconColor = Color.Black;
            menuacercade.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuacercade.IconSize = 50;
            menuacercade.ImageScaling = ToolStripItemImageScaling.None;
            menuacercade.Name = "menuacercade";
            menuacercade.Size = new Size(85, 69);
            menuacercade.Text = "Acerca de";
            menuacercade.TextImageRelation = TextImageRelation.ImageAboveText;
            menuacercade.Click += menuacercade_Click;
            // 
            // contenedor
            // 
            contenedor.Dock = DockStyle.Fill;
            contenedor.Location = new Point(0, 146);
            contenedor.Margin = new Padding(3, 4, 3, 4);
            contenedor.Name = "contenedor";
            contenedor.Size = new Size(1253, 683);
            contenedor.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkOrange;
            label1.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(22, 17);
            label1.Name = "label1";
            label1.Size = new Size(301, 39);
            label1.TabIndex = 2;
            label1.Text = "Gestion de Granos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkOrange;
            label2.Location = new Point(975, 29);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 5;
            label2.Text = "Usuario:";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.DarkOrange;
            lblUsuario.Location = new Point(1035, 29);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(76, 20);
            lblUsuario.TabIndex = 6;
            lblUsuario.Text = "lblUsuario";
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.DarkOrange;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RightToLeft = RightToLeft.Yes;
            menuStrip1.Size = new Size(1253, 73);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.DarkOrange;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 50;
            iconButton1.Location = new Point(1169, 10);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(72, 56);
            iconButton1.TabIndex = 7;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1253, 829);
            Controls.Add(iconButton1);
            Controls.Add(lblUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(contenedor);
            Controls.Add(menu);
            Controls.Add(menuStrip1);
            MainMenuStrip = menu;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Inicio_Load;
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menu;
        private FontAwesome.Sharp.IconMenuItem menuacercade;
        private FontAwesome.Sharp.IconMenuItem menuseguridad;
        private FontAwesome.Sharp.IconMenuItem menuventas;
        private FontAwesome.Sharp.IconMenuItem menucompras;
        private FontAwesome.Sharp.IconMenuItem menureportes;
        private Panel contenedor;
        private Label label1;
        private Label label2;
        private Label lblUsuario;
        private ToolStripMenuItem submenuClientes;
        private ToolStripMenuItem submenuProveedores;
        private ToolStripMenuItem submenuCategoria;
        private ToolStripMenuItem submenuProducto;
        private ToolStripMenuItem submenuVentas;
        private ToolStripMenuItem submenuCompras;
        private ToolStripMenuItem submenunegocio;
        private ToolStripMenuItem submenudetventa;
        private ToolStripMenuItem submenudetcompra;
        private ToolStripMenuItem submenureportecompras;
        private ToolStripMenuItem submenureporteventas;
        private MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}

