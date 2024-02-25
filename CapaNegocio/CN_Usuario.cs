using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Usuario
    {
        private CD_Usuario objcd_usuario = new CD_Usuario();

        public List<Usuario> Listar()
        {
            try
            {
                return objcd_usuario.Listar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int Registrar(Usuario obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Documento == "")
            {
                Mensaje += "Debe introducir el número de documento del usuario\n";
            }
            else if (!ValidarInt(obj.Documento))
            {
                Mensaje += ("Por favor, introduce solo números en el campo de cocumento.\n");
            }

            if (obj.NombreCompleto == "")
            {
                Mensaje += "Debe introducir el nombre completo del usuario\n";
            }
            else if (!ValidarString(obj.NombreCompleto))
            {
                Mensaje += ("Por favor, introduce solo letras en el campo de nombre completo.");
            }

            if (obj.Correo == "")
            {
                Mensaje += "Debe introducir el correo del usuario\n";
            }
            else if (ValidarCorreoElectronico(obj.Correo))
            {
                Mensaje += "Debe ingresar correctamente el correo del usuario\n";
            }

            if (obj.Clave == "")
            {
                Mensaje += "Debe introducir la clave del usuario\n";
            }

            if (Mensaje !=  string.Empty)
            {
                return 0;
            }
            else
            {
                try
                {
                    return objcd_usuario.Registrar(obj, out Mensaje);
                }
                catch(Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            
        }

        public bool Editar(Usuario obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Documento == "")
            {
                Mensaje += "Debe introducir el número de documento del usuario\n";
            }
            else if (!ValidarInt(obj.Documento))
            {
                Mensaje += ("Por favor, introduce solo números en el campo de cocumento.\n");
            }

            if (obj.NombreCompleto == "")
            {
                Mensaje += "Debe introducir el nombre completo del usuario\n";
            }
            else if (!ValidarString(obj.NombreCompleto))
            {
                Mensaje += ("Por favor, introduce solo letras en el campo de nombre completo.");
            }

            if (obj.Correo == "")
            {
                Mensaje += "Debe introducir el correo del usuario\n";
            }
            else if (ValidarCorreoElectronico(obj.Correo))
            {
                Mensaje += "Debe ingresar correctamente el correo del usuario\n";
            }

            if (obj.Clave == "")
            {
                Mensaje += "Debe introducir la clave del usuario\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                try
                {
                    return objcd_usuario.Editar(obj, out Mensaje);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        public bool Eliminar(Usuario obj, out string Mensaje)
        {
            try
            {
                return objcd_usuario.Eliminar(obj, out Mensaje);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private bool ValidarString(string input)
        {
            // Utilizar expresión regular para validar que solo se introduzcan letras
            return Regex.IsMatch(input, "^[a-zA-Z]+$");
        }

        private bool ValidarInt(string input)
        {
            // Utilizar TryParse para validar que solo se introduzcan números enteros
            return int.TryParse(input, out _);
        }

        private bool ValidarCorreoElectronico(string correo)
        {
            // Utilizar una expresión regular para validar el formato del correo electrónico
            string patronCorreo = @"/^([a-zA-Z0-9_.+-])+\@(([a-zA-Z0-9-])+\.)+([a-zA-Z0-9]{2,4})+$/";
            return Regex.IsMatch(correo, patronCorreo);
        }

        public bool ValidarLetrasYNumeros(string input)
        {
            // Utilizar una expresión regular para validar que la cadena contenga solo letras y números
            // ^[a-zA-Z0-9]+$ significa que debe haber al menos un carácter, y ese carácter puede ser una letra (mayúscula o minúscula) o un número.
            return Regex.IsMatch(input, "^[a-zA-Z0-9]+$");
        }
    }
}
