using CapaDatos;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Modales;
using CapaPresentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmPermisoUsuario : Form
    {
        private CN_Usuario objcn_Usuario = new CN_Usuario();
        public frmPermisoUsuario()
        {
            InitializeComponent();
        }

        private void frmPermisoUsuario_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in dgvdata.Columns)
            {
                if (columna.Visible && columna.Name != "btnseleccionar")
                {
                    cbbusqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            cbbusqueda.SelectedIndex = 0;
            cbbusqueda.DisplayMember = "Texto";
            cbbusqueda.ValueMember = "Valor";

            dgvdata.Rows.Clear();

            //MOSTRAR LOS USUARIOS
            List<Usuario> listaUsuarios = objcn_Usuario.Listar();
            listaUsuarios = listaUsuarios.OrderBy(p => p.NombreCompleto).ToList();

            foreach (Usuario oUsuario in listaUsuarios)
            {
                dgvdata.Rows.Add(new object[] {"", oUsuario.IdUsuario, oUsuario.Documento, oUsuario.NombreCompleto,
                oUsuario.Correo, oUsuario.Clave,
                oUsuario.Estado == true ? 1 : 0,
                oUsuario.Estado == true ? "Activo" : "No Activo"});
            }

            //CONFIGURA QUE NO ESTE SELECCIONADA NINGUNA FILA
            dgvdata.ClearSelection();

            txtid.Text = "";
        }

        private void btnverpermisos_Click(object sender, EventArgs e)
        {
            if (txtid.Text.Trim() != "")
            {
                using (var modal = new MD_DetallePermisoUsuario("VerDetalle", Convert.ToInt32(txtid.Text)))
                {
                    var resultado = modal.ShowDialog();
                    dgvdata.Rows.Clear();

                    List<Usuario> listaUsuarios = objcn_Usuario.Listar();
                    listaUsuarios = listaUsuarios.OrderBy(p => p.NombreCompleto).ToList();

                    foreach (Usuario oUsuario in listaUsuarios)
                    {
                        dgvdata.Rows.Add(new object[] {"", oUsuario.IdUsuario, oUsuario.Documento, oUsuario.NombreCompleto,
                            oUsuario.Correo, oUsuario.Clave,
                            oUsuario.Estado == true ? 1 : 0,
                            oUsuario.Estado == true ? "Activo" : "No Activo"});
                    }

                    dgvdata.ClearSelection();

                    txtid.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnadministrarusuario_Click(object sender, EventArgs e)
        {
            if (txtid.Text.Trim() != "")
            {
                using (var modal = new MD_DetallePermisoUsuario("Editar", Convert.ToInt32(txtid.Text)))
                {
                    var resultado = modal.ShowDialog();
                    dgvdata.Rows.Clear();

                    List<Usuario> listaUsuarios = objcn_Usuario.Listar();
                    listaUsuarios = listaUsuarios.OrderBy(p => p.NombreCompleto).ToList();

                    foreach (Usuario oUsuario in listaUsuarios)
                    {
                        dgvdata.Rows.Add(new object[] {"", oUsuario.IdUsuario, oUsuario.Documento, oUsuario.NombreCompleto,
                            oUsuario.Correo, oUsuario.Clave,
                            oUsuario.Estado == true ? 1 : 0,
                            oUsuario.Estado == true ? "Activo" : "No Activo"});
                    }

                    dgvdata.ClearSelection();

                    txtid.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cbbusqueda.SelectedItem).Valor.ToString();

            if (dgvdata.Rows.Count > 0)
            {
                foreach (DataGridViewRow fila in dgvdata.Rows)
                {
                    if (fila.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtbusqueda.Text.Trim().ToUpper()))
                    {
                        fila.Visible = true;
                    }
                    else
                    {
                        fila.Visible = false;
                    }
                }
            }
        }

        private void btnlimpiarbuscador_Click(object sender, EventArgs e)
        {
            txtbusqueda.Text = "";

            foreach (DataGridViewRow fila in dgvdata.Rows)
            {
                fila.Visible = true;
            }

            dgvdata.ClearSelection();
            txtid.Text = "";
        }

        private void dgvdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                e.PaintBackground(e.ClipBounds, true);

                var w = Properties.Resources.check20.Width;
                var h = Properties.Resources.check20.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.check20, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void dgvdata_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;

            if (indice >= 0)
            {
                txtid.Text = dgvdata.Rows[indice].Cells["IdUsuario"].Value.ToString();
            }
        }

        private void dgvdata_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int indiceFila = e.RowIndex;
            int indiceColumna = e.ColumnIndex;

            if (indiceFila >= 0 && indiceColumna >= 0)
            {
                btnverpermisos_Click(sender, e);
            }
        }
    }
}
