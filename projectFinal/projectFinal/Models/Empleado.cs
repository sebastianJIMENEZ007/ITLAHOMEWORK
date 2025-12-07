using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectFinal.Models
{
    public class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Cargo { get; set; }

        public Empleado() { }

        public Empleado(int id, string nombre, string cargo)
        {
            Id = id;
            Nombre = nombre;
            Cargo = cargo;
        }
    }
}
