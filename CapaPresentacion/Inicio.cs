﻿using CapaEntidad;
using CapaPresentacion;
using CapaNegocio;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion.Modales;

namespace CapaPresentación
{
    public partial class Inicio : Form
    {
        private static Usuario usuarioActual;
        private static IconMenuItem MenuActivo = null;
        private static Form FormularioActivo = null;

        public Inicio(Usuario objusuario = null)
        {
            if (objusuario == null)
            {
                usuarioActual = new Usuario() { NombreCompleto = "ADMIN PREDEFINIDO", IdUsuario = 1 };
            }
            else
            {
                usuarioActual = objusuario;
            }

            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            List<Permiso> listaPermisos = new CN_Permiso().Listar(usuarioActual.IdUsuario);

            foreach (IconMenuItem iconMenu in menu.Items)
            {
                bool encontrado = listaPermisos.Any(m => m.NombreMenu == iconMenu.Name);
                if (encontrado == false)
                {
                    iconMenu.Visible = false;
                }
            }

            lblUsuario.Text = usuarioActual.NombreCompleto;
        }


        private void AbrirFormulario(IconMenuItem menu, Form formulario)
        {
            if (MenuActivo != null)
            {
                MenuActivo.BackColor = Color.White;
            }
            MenuActivo = menu;
            menu.BackColor = Color.Silver;

            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }
            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.White;
            contenedor.Controls.Add(formulario);
            formulario.Show();
        }

        private void menuusuario_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmSeguridad());
        }

        private void submenuClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuventas, new frmCliente());
        }

        private void submenudetventa_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuventas, new frmDetalleVentas());
        }

        private void submenuVentas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuventas, new frmVentas(usuarioActual));
        }

        private void submenuCategoria_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menucompras, new frmCategoria());
        }

        private void submenuCompras_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menucompras, new frmCompras(usuarioActual));
        }

        private void submenudetcompra_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menucompras, new frmDetalleCompra());
        }

        private void submenunegocio_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menucompras, new frmNegocio());
        }

        private void submenuProducto_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menucompras, new frmProducto());
        }

        private void submenuProveedores_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menucompras, new frmProveedor());
        }

        private void submenureportecompras_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menureportes, new frmReporteCompras());
        }

        private void submenureporteventas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menureportes, new frmReporteVentas());

        }

        private void menuacercade_Click(object sender, EventArgs e)
        {
            MD_AcercaDe md = new MD_AcercaDe();
            md.ShowDialog();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Desea Salir?","Mensaje",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
