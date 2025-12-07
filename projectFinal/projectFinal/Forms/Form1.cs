using projectFinal.Data;
using projectFinal.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
            CargarPedidosDesdeDB();
        }

        private void CargarPedidosDesdeDB(string filtro = "")
        {
            flowLayoutPanel1.Controls.Clear();

            using (SqlConnection conn = Database.GetConnection())
            {
                string query = "SELECT NombreCliente, PedidoID, Telefono, Direccion, Estado, Total, Fecha, Descripcion FROM Pedidos";

                if (!string.IsNullOrEmpty(filtro))
                {
                    query += " WHERE NombreCliente LIKE @filtro OR Estado LIKE @filtro OR Descripcion LIKE @filtro";
                }

                SqlCommand cmd = new SqlCommand(query, conn);

                if (!string.IsNullOrEmpty(filtro))
                {
                    cmd.Parameters.AddWithValue("@filtro", "%" + filtro + "%");
                }

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        pedido pedidoUC = new pedido();
                        int pedidoId = Convert.ToInt32(reader["PedidoID"]);
                        pedidoUC.Id = pedidoId;

                        pedidoUC.NombreCliente = reader["NombreCliente"].ToString();
                        pedidoUC.Telefono = reader["Telefono"].ToString();
                        pedidoUC.Direccion = reader["Direccion"].ToString();
                        pedidoUC.Estado = reader["Estado"].ToString();
                        pedidoUC.Total = reader["Total"].ToString();
                        pedidoUC.Fecha = Convert.ToDateTime(reader["Fecha"]).ToShortDateString();
                        pedidoUC.Descripcion = reader["Descripcion"].ToString();

                     
                        pedidoUC.OnEliminar += (s, e) =>
                        {
                            flowLayoutPanel1.Controls.Remove(pedidoUC);
                           
                        };

                        flowLayoutPanel1.Controls.Add(pedidoUC);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar pedidos: " + ex.Message);
                }
            }
        }

       
        private void btnAbrirPedidos_Click_1(object sender, EventArgs e)
        {
            FormPedidos ventana = new FormPedidos();
            ventana.Show();
        }

     
        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = ""; 
            CargarPedidosDesdeDB();
        }

 

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string criterio = txtBuscar.Text.Trim();
            CargarPedidosDesdeDB(criterio);
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
 
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            string criterio = txtBuscar.Text.Trim();
            CargarPedidosDesdeDB(criterio);
            

        }
    }
}
