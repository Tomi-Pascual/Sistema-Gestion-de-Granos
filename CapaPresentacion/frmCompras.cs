﻿using CapaEntidad;
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
    public partial class frmCompras : Form
    {
        private Usuario _Usuario;


        public frmCompras(Usuario oUsuario = null)
        {
            _Usuario = oUsuario;
            InitializeComponent();
        }

        private void frmCompras_Load(object sender, EventArgs e)
        {
            MessageBox.Show(_Usuario.NombreCompleto);
        }
        
        private void btnbuscarprov_Click(object sender, EventArgs e)
        {

        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {

        }
    }
}
