using CapaEntidad;
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
        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menucompras, new frmProducto());
        }

        private void menuusuario_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmSeguridad());
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menucompras, new frmCategoria());
        }

        private void submenuVentas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuventas, new frmVentas());
        }

        private void submenuClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuventas, new frmCliente());
        }

        private void submenuProveedores_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menucompras, new frmProveedor());
        }

        private void submenuCompras_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menucompras, new frmCompras(usuarioActual));
        }

        private void menureportes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menureportes, new frmReportes());
        }

        private void submenunegocio_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menucompras, new frmNegocio());
        }
    }
}
