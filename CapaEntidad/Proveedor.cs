﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Proveedor
    {
        //
        //ATRIBUTOS
        //
        private int idProveedor;
        private string documento;
        private string razonSocial;
        private string correo;
        private string telefono;
        private bool estado;
        private string fechaRegistro;

        //
        //PROPIEDADES
        //
        public int IdProveedor { get; set; }
        public string Documento { get; set; }
        public string RazoSocial { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public bool Estado { get; set; }
        public string FechaRegistro { get; set; }
    }
}
