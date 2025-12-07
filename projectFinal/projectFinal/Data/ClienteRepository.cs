using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using projectFinal.Models;

namespace projectFinal.Data
{
    public class ClienteRepository
    {
        public void Insertar(Cliente c)
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO Clientes (Nombre, Telefono) VALUES (@n, @t)";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@n", c.Nombre);
                cmd.Parameters.AddWithValue("@t", c.Telefono);

                cmd.ExecuteNonQuery();
            }
        }

        public List<Cliente> Listar()
        {
            var clientes = new List<Cliente>();

            using (var conn = Database.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM Clientes";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    clientes.Add(new Cliente
                    {
                        Id = reader.GetInt32(0),
                        Nombre = reader.GetString(1),
                        Telefono = reader.GetString(2)
                    });
                }
            }

            return clientes;
        }
    }
}
