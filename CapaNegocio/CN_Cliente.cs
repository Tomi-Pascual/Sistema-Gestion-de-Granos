using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Cliente
    {
        private CD_Cliente objcd_cliente = new CD_Cliente();

        public List<Cliente> Listar()
        {
            return objcd_cliente.Listar();
        }

        public int Registrar(Cliente obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Documento == "")
            {
                Mensaje += "Debe introducir el número de documento del cliente\n";
            }

            if (obj.NombreCompleto == "")
            {
                Mensaje += "Debe introducir el nombre completo del cliente\n";
            }

            if (obj.Correo == "")
            {
                Mensaje += "Debe introducir el correo del cliente\n";
            }

            if (obj.Telefono == "")
            {
                Mensaje += "Debe introducir el telefono del cliente\n";
            }

            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objcd_cliente.Registrar(obj, out Mensaje);
            }

        }

        public bool Editar(Cliente obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Documento == "")
            {
                Mensaje += "Debe introducir el número de documento del cliente\n";
            }

            if (obj.NombreCompleto == "")
            {
                Mensaje += "Debe introducir el nombre completo del cliente\n";
            }

            if (obj.Correo == "")
            {
                Mensaje += "Debe introducir el correo del cliente\n";
            }

            if (obj.Telefono == "")
            {
                Mensaje += "Debe introducir el telefono del cliente\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcd_cliente.Editar(obj, out Mensaje);
            }
        }

        public bool Eliminar(Cliente obj, out string Mensaje)
        {
            return objcd_cliente.Eliminar(obj, out Mensaje);
        }
    }
}
