using System;
using System.IO;
using System.Windows.Forms;

namespace block_notas
{
    public partial class Form1 : Form
    {
        string rutaArchivo = "";
        bool hayCambios = false;

        public Form1()
        {
            InitializeComponent();
        }

        // Detectar cambios en el texto
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            hayCambios = true;
        }

        // 🔹 NUEVO
        private void button1_Click(object sender, EventArgs e)
        {
            if (hayCambios)
            {
                DialogResult resultado = MessageBox.Show(
                    "¿Quieres guardar los cambios?",
                    "Confirmación",
                    MessageBoxButtons.YesNoCancel
                );

                if (resultado == DialogResult.Yes)
                {
                    GuardarArchivo();
                }
                else if (resultado == DialogResult.Cancel)
                {
                    return;
                }
            }

            textBox1.Clear();
            rutaArchivo = "";
            hayCambios = false;
        }

        // 🔹 ABRIR
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";

            if (abrir.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = File.ReadAllText(abrir.FileName);
                rutaArchivo = abrir.FileName;
                hayCambios = false;
            }
        }

        // 🔹 GUARDAR
        private void button3_Click(object sender, EventArgs e)
        {
            GuardarArchivo();
        }

        // 🔹 FUNCIÓN GUARDAR
        private void GuardarArchivo()
        {
            if (rutaArchivo == "")
            {
                SaveFileDialog guardar = new SaveFileDialog();
                guardar.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";

                if (guardar.ShowDialog() == DialogResult.OK)
                {
                    rutaArchivo = guardar.FileName;
                }
                else
                {
                    return;
                }
            }

            File.WriteAllText(rutaArchivo, textBox1.Text);
            hayCambios = false;

            MessageBox.Show("Archivo guardado correctamente");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

       
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}