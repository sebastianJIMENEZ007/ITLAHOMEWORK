using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectFinal.Models
{
    public class Pedido
    {
        public int PedidoID { get; set; }
        public string NombreCliente { get; set; }
        public string Fecha { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
        public decimal Total { get; set; }
    }
}
