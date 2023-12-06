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
    public class CN_Categoria
    {
        private CD_Categoria objcd_categoria = new CD_Categoria();

        public List<Categoria> Listar()
        {
            return objcd_categoria.Listar();
        }

        public int Registrar(Categoria obj, out string Mensaje)
        {
            Mensaje = string.Empty;
    
            if (obj.Descripcion == "")
            {
                Mensaje += "Debe introducir la descripcion de la categoria\n";
            }
            else if (ValidarLetrasYNumeros(obj.Descripcion))
            {
                Mensaje += "Por favor, ingrese solo letras y numeros en la Descripcion";
            }

            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objcd_categoria.Registrar(obj, out Mensaje);
            }

        }

        public bool Editar(Categoria obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Descripcion == "")
            {
                Mensaje += "Debe introducir la descripcion de la categoria\n";
            }
            else if (ValidarLetrasYNumeros(obj.Descripcion))
            {
                Mensaje += "Por favor, ingrese solo letras y numeros en la Descripcion";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcd_categoria.Editar(obj, out Mensaje);
            }
        }

        public bool Eliminar(Categoria obj, out string Mensaje)
        {
            return objcd_categoria.Eliminar(obj, out Mensaje);
        }

        public bool ValidarLetrasYNumeros(string input)
        {
            // Utilizar una expresión regular para validar que la cadena contenga solo letras y números
            // ^[a-zA-Z0-9]+$ significa que debe haber al menos un carácter, y ese carácter puede ser una letra (mayúscula o minúscula) o un número.
            return Regex.IsMatch(input, "^[a-zA-Z0-9]+$");
        }
    }
}
