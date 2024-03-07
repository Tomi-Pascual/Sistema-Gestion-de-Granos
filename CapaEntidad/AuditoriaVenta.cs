using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class AuditoriaVenta
    {
        //
        //ATRIBUTOS
        //
        private int idAuditoria;
        private int idVenta;
        private int idUsuario;
        private string fechaAuditoria;
        private string operacion;
        private decimal montoTotal;
        private string tipoDocumento;
        private string numeroDocumento;
        private string documentoCliente;
        private string nombreCliente;

        //
        //PROPIEDADES
        //
        public int IdAuditoria { get; set; }
        public int IdVenta { get; set; }
        public int IdUsuario { get; set; }
        public string FechaAuditoria { get; set; }
        public string Operacion { get; set; }
        public decimal MontoTotal { get; set; }
    }
}
