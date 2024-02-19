﻿using CapaEntidad;
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
    public partial class frmDetalleCompra : Form
    {
        public frmDetalleCompra()
        {
            InitializeComponent();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            Compra oCompra = new CN_Compra().ObtenerCompra(txtbusqueda.Text);

            if (oCompra.IdCompra != 0)
            {
                txtnumdoc.Text = oCompra.NumeroDocumento;
                txtfecha.Text = oCompra.FechaRegistro;
                txttipodocumento.Text = oCompra.TipoDocumento;
                txtusuario.Text = oCompra.OUsuario.NombreCompleto;
                txtdocproveedor.Text = oCompra.OProveedor.Documento;
                txtrazonsocial.Text = oCompra.OProveedor.RazonSocial;

                dgvproducto.Rows.Clear();
                foreach (Detalle_Compra dc in oCompra.ODetalleCompra)
                {
                    dgvproducto.Rows.Add(new object[]
                    {
                        dc.OProducto.Nombre,
                        dc.PrecioCompra,
                        dc.Cantidad,
                        dc.MontoTotal
                    });
                }
                txtmontototal.Text = oCompra.MontoTotal.ToString("0.00");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtfecha.Text = "";
            txttipodocumento.Text = "";
            txtusuario.Text = "";
            txtdocproveedor.Text = "";
            txtrazonsocial.Text = "";

            dgvproducto.Rows.Clear();
            txtmontototal.Text = "0.00";
        }
    }
}
