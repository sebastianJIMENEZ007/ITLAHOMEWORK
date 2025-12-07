using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectFinal
{
    public partial class pedido : UserControl
    {
        public pedido()
        {
            InitializeComponent();
        }

        private void pedido_Load(object sender, EventArgs e)
        {


        }
        private int _id; // campo interno

        
        public int Id
        {
            get { return _id; }
            set
            {
                _id = value;
                lblID.Text = "ID: " + value.ToString(); // ahora se muestra en pantalla
            }
        }

        public string NombreCliente
        {
            get { return lblNombre.Text; }
            set { lblNombre.Text = value; }
        }

        public string Telefono
        {
            get { return lblTelefono.Text; }
            set { lblTelefono.Text = value; }
        }

        public string Direccion
        {
            get { return lblDireccion.Text; }
            set { lblDireccion.Text = value; }
        }

        public string Estado
        {
            get { return lblEstado.Text; }
            set { lblEstado.Text = value; }
        }

        public string Total
        {
            get { return lblTotal.Text; }
            set { lblTotal.Text = value; }
        }

        public string Fecha
        {
            get { return lblFecha.Text; }
            set { lblFecha.Text = value; }
        }

        public string Descripcion
        {
            get { return lblDescripcion.Text; }
            set { lblDescripcion.Text = value; }
        }

        // Evento para eliminar
        public event EventHandler OnEliminar;

       

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void lblTelefono_Click(object sender, EventArgs e)
        {

        }

        public void btnEliminar_Click_1(object sender, EventArgs e)
        {
            OnEliminar?.Invoke(this, EventArgs.Empty);
        }

        private void lblID_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        


protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        int borderRadius = 20; 
        GraphicsPath path = new GraphicsPath();
        path.StartFigure();
        path.AddArc(0, 0, borderRadius, borderRadius, 180, 90); 
        path.AddArc(this.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90); 
        path.AddArc(this.Width - borderRadius, this.Height - borderRadius, borderRadius, borderRadius, 0, 90); 
        path.AddArc(0, this.Height - borderRadius, borderRadius, borderRadius, 90, 90); 
        path.CloseFigure();

        this.Region = new Region(path); 
    }

        private void lblDescripcion_Click(object sender, EventArgs e)
        {

        }
    }
}
