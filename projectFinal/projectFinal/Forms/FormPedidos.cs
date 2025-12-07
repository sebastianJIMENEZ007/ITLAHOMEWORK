using projectFinal.Data;
using projectFinal.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace projectFinal.Forms
{
    public partial class FormPedidos : Form
    {
        public FormPedidos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Pedido nuevo = new Pedido()
                {
                    NombreCliente = textBox1.Text,
                    Fecha = dateFecha.Value.ToShortDateString(),
                    Direccion = txtDireccion.Text,
                    Telefono = txtTelefono.Text,
                    Descripcion = txtDescripcion.Text,
                    Estado = cmbEstado.Text,
                    Total = decimal.Parse(txtTotal.Text)
                };

                PedidoRepository repo = new PedidoRepository();
                repo.Insertar(nuevo);

                MessageBox.Show("Pedido guardado correctamente!", "Éxito");

                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void FormPedidos_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void dateFecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Pedido nuevo = new Pedido()
                {
                    NombreCliente = textBox1.Text,
                    Fecha = dateFecha.Value.ToShortDateString(),
                    Direccion = txtDireccion.Text,
                    Telefono = txtTelefono.Text,
                    Descripcion = txtDescripcion.Text,
                    Estado = cmbEstado.Text,
                    Total = decimal.Parse(txtTotal.Text)
                };

                PedidoRepository repo = new PedidoRepository();
                repo.Insertar(nuevo);

                MessageBox.Show("Pedido guardado correctamente!", "Éxito");

                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LimpiarCampos()
        {
            textBox1.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtDescripcion.Clear();
            txtTotal.Clear();
            cmbEstado.SelectedIndex = -1;
        }

        private void lblNombreCliente_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
