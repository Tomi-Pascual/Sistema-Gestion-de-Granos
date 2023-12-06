using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Negocio
    {
        private CD_Negocio objcd_Negocio = new CD_Negocio();

        public Negocio ObtenerDatos()
        {
            return objcd_Negocio.ObtenerDatos();
        }

        public bool GuardarDatos(Negocio obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Nombre == "")
            {
                Mensaje += "Debe introducir el nombre del Negocio\n";
            }
            else if (!ValidarString(obj.Nombre))
            {
                Mensaje += ("Por favor, introduce solo letras en el campo de Nombre.\n");
            }

            if (obj.RUC == "")
            {
                Mensaje += "Debe introducir el R.U.C del Negocio\n";
            }
            else if (!ValidarLetrasYNumeros(obj.RUC))
            {
                Mensaje += ("Por favor, introduce solo numeros y/o letras en el campo de R.U.C.\n");
            }

            if (obj.Direccion == "")
            {
                Mensaje += "Debe introducir la dirección del Negocio\n";
            }
            else if (ValidarLetrasYNumeros(obj.Direccion))
            {
                Mensaje += "Debe introducir solo numeros y/o letras en el campo Dirección\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcd_Negocio.GuardarDatos(obj, out Mensaje);
            }

        }

        public byte[] ObtenerLogo(out bool obtenido)
        {
            return objcd_Negocio.ObtenerLogo(out obtenido);
        }

        public bool ActualizarLogo(byte[] imagen, out string mensaje)
        {
            return objcd_Negocio.ActualizarLogo(imagen, out mensaje);
        }

        private bool ValidarString(string input)
        {
            // Utilizar expresión regular para validar que solo se introduzcan letras
            return Regex.IsMatch(input, "^[a-zA-Z]+$");
        }

        public bool ValidarLetrasYNumeros(string input)
        {
            // Utilizar una expresión regular para validar que la cadena contenga solo letras y números
            // ^[a-zA-Z0-9]+$ significa que debe haber al menos un carácter, y ese carácter puede ser una letra (mayúscula o minúscula) o un número.
            return Regex.IsMatch(input, "^[a-zA-Z0-9]+$");
        }
    }
}
