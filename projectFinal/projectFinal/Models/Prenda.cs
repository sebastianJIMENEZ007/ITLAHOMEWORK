using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectFinal.Models
{
    public class Prenda
    {
        public int Id { get; set; }
        public string Tipo { get; set; } // Camisa, pantalón, etc
        public string Color { get; set; }

        public Prenda() { }

        public Prenda(int id, string tipo, string color)
        {
            Id = id;
            Tipo = tipo;
            Color = color;
        }
    }
}
