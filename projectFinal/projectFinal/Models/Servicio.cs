using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectFinal.Models
{
    public class Servicio
    {
        public int Id { get; set; }
        public string Nombre { get; set; } // Lavado, Planchado, etc
        public decimal Precio { get; set; }

        public Servicio() { }

        public Servicio(int id, string nombre, decimal precio)
        {
            Id = id;
            Nombre = nombre;
            Precio = precio;
        }
    }
}
