﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Rol
    {
        //
        //ATRIBUTOS
        //
        private int idRol;
        private string descripcion;
        private string fechaRegistro;

        //
        //PROPIEDADES
        //
        public int IdRol {  get; set; }
        public string Descripcion { get; set; }
        public string FechaRegistro { get; set; }

    }
}
