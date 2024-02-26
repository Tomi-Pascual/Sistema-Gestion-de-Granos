﻿using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Cliente
    {
        private CD_Cliente objcd_cliente = new CD_Cliente();

        public List<Cliente> Listar()
        {
            try
            {
                return objcd_cliente.Listar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int Registrar(Cliente obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Documento == "")
            {
                Mensaje += "Debe introducir el número de documento del Cliente\n";
            }
            else if (!ValidarInt(obj.Documento))
            {
                Mensaje += ("Por favor, introduce solo números en el campo de Documento.\n");
            }

            if (obj.NombreCompleto == "")
            {
                Mensaje += "Debe introducir el Nombre Completo del Cliente\n";
            }
            else if (!ValidarString(obj.NombreCompleto))
            {
                Mensaje += ("Por favor, introduce solo letras en el campo de Nombre Completo.\n");
            }

            if (obj.Correo == "")
            {
                Mensaje += "Debe introducir el correo del Cliente\n";
            }

            if (obj.Telefono == "")
            {
                Mensaje += "Debe introducir el telefono del Cliente\n";
            }
            else if (!ValidarInt(obj.Telefono))
            {
                Mensaje += ("Por favor, introduce solo números en el campo de Telefono.\n");
            }

            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                try
                {
                    return objcd_cliente.Registrar(obj, out Mensaje);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }

        }

        public bool Editar(Cliente obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Documento == "")
            {
                Mensaje += "Debe introducir el número de documento del Cliente\n";
            }
            else if (!ValidarInt(obj.Documento))
            {
                Mensaje += ("Por favor, introduce solo números en el campo de Documento.\n");
            }

            if (obj.NombreCompleto == "")
            {
                Mensaje += "Debe introducir el Nombre Completo del Cliente\n";
            }
            else if (!ValidarString(obj.NombreCompleto))
            {
                Mensaje += ("Por favor, introduce solo letras en el campo de Nombre Completo.\n");
            }

            if (obj.Correo == "")
            {
                Mensaje += "Debe introducir el correo del Cliente\n";
            }
            else if (ValidarCorreoElectronico(obj.Correo))
            {
                Mensaje += "Debe ingresar correctamente el correo del Cliente\n";
            }

            if (obj.Telefono == "")
            {
                Mensaje += "Debe introducir el telefono del Cliente\n";
            }
            else if (!ValidarInt(obj.Telefono))
            {
                Mensaje += ("Por favor, introduce solo números en el campo de Telefono.\n");
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                try
                {
                    return objcd_cliente.Editar(obj, out Mensaje);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        public bool Eliminar(Cliente obj, out string Mensaje)
        {
            try
            {
                return objcd_cliente.Eliminar(obj, out Mensaje);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private bool ValidarString(string input)
        {
            // Utilizar expresión regular para validar que solo se introduzcan letras
            return Regex.IsMatch(input, @"^[a-zA-Z\s]+$");
        }

        private bool ValidarInt(string input)
        {
            // Utilizar TryParse para validar que solo se introduzcan números enteros
            return int.TryParse(input, out _);
        }

        private bool ValidarCorreoElectronico(string correo)
        {
            // Utilizar una expresión regular para validar el formato del correo electrónico
            string patronCorreo = @" / ^([a-zA-Z0-9_.+-])+\@(([a-zA-Z0-9-])+\.)+([a-zA-Z0-9]{2,4})+$/";
            return Regex.IsMatch(correo, patronCorreo);
        }
    }
}
