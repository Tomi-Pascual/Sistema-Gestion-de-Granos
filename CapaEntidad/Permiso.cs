using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Permiso
    {
        //
        //ATRIBUTOS
        //
        private int idPermiso;
        private Rol oRol;
        private string nombreMenu;
        private string fechaRegistro;

        //
        //PROPIEDADES
        //
        public int IdPermiso { get; set; }
        public Rol ORol { get; set; }
        public string NombreMenu { get; set; }
        public string FechaRegistro { get; set; }
    }
}
