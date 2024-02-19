using CapaEntidad;
using CapaNegocio;
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
    public partial class frmDetalleVentas : Form
    {
        public frmDetalleVentas()
        {
            InitializeComponent();
        }

        private void frmDetalleVentas_Load(object sender, EventArgs e)
        {
            txtbusqueda.Select();
            txtfecha.Text = "";
            txttipodocumento.Text = "";
            txtusuario.Text = "";
            txtdoccliente.Text = "";
            txtnombrecliente.Text = "";

            dgvproducto.Rows.Clear();
            txtmontototal.Text = "0.00";
            txtpago.Text = "0.00";
            txtcambio.Text = "0.00";
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            Venta oVenta = new CN_Venta().ObtenerVenta(txtbusqueda.Text);

            if (oVenta.IdVenta != 0)
            {
                txtnumdoc.Text = oVenta.NumeroDocumento;

                txtfecha.Text = oVenta.FechaRegistro;
                txttipodocumento.Text = oVenta.TipoDocumento;
                txtusuario.Text = oVenta.OUsuario.NombreCompleto;

                txtdoccliente.Text = oVenta.DocumentoCliente;
                txtnombrecliente.Text = oVenta.NombreCliente;

                dgvproducto.Rows.Clear();

                foreach (Detalle_Venta dv in oVenta.ODetalleVenta)
                {
                    dgvproducto.Rows.Add(new object[]
                    {
                        dv.OProducto.Nombre, dv.PrecioVenta, dv.Cantidad, dv.SubTotal
                    });
                }

                txtmontototal.Text = oVenta.MontoTotal.ToString("0.00");
                txtpago.Text = oVenta.MontoPago.ToString("0.00");
                txtcambio.Text = oVenta.MontoCambio.ToString("0.00");
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtfecha.Text = "";
            txttipodocumento.Text = "";
            txtusuario.Text = "";
            txtdoccliente.Text = "";
            txtnombrecliente.Text = "";

            dgvproducto.Rows.Clear();
            txtmontototal.Text = "0.00";
            txtpago.Text = "0.00";
            txtcambio.Text = "0.00";
        }

    }
}
