﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Usuario
    {
        //
        //ATRIBUTOS
        //
        private int idUsuario;
        private string documento;
        private string nombreCompleto;
        private string correo;
        private string clave;
        private Rol oRol;
        private bool estado;
        private string fechaRegistro;

        //
        //PROPIEDADES
        //
        public int IdUsuario { get; set; }
        public string Documento { get; set; }
        public string NombreCompleto { get; set; }
        public string Correo { get; set; }
        public string Clave { get; set; }
        public Rol ORol { get; set; }
        public bool Estado { get; set; }
        public string FechaRegistro { get; set; }
    }
}
