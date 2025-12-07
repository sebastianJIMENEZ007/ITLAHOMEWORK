using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using projectFinal.Models;

namespace projectFinal.Data
{
    public class PedidoRepository
    {
        public void Insertar(Pedido p)
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();

                string query = @"INSERT INTO Pedidos
                    (NombreCliente, Fecha, Direccion, Telefono, Descripcion, Estado, Total)
                    VALUES (@n, @f, @d, @t, @desc, @e, @tot)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@n", p.NombreCliente);
                cmd.Parameters.AddWithValue("@f", p.Fecha);
                cmd.Parameters.AddWithValue("@d", p.Direccion);
                cmd.Parameters.AddWithValue("@t", p.Telefono);
                cmd.Parameters.AddWithValue("@desc", p.Descripcion);
                cmd.Parameters.AddWithValue("@e", p.Estado);
                cmd.Parameters.AddWithValue("@tot", p.Total);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
