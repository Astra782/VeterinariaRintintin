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

namespace VeterinariaRintintin
{
    public partial class Form1 : Form

    {

        private SqlConnection conexion;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frm = new consulta();
            frm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_registro_Click(object sender, EventArgs e)
        {
            var frmCliente = new cliente(conexion);
            frmCliente.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Crear una instancia del formulario logincs
            logincs frm = new logincs();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();

            // Validar si la conexión fue exitosa
            if (!frm.IsConectado)
            {
                // Cerrar el formulario principal si no hay conexión
                Close();
            }
            else
            {
                // Reutilizar la conexión establecida en logincs
                SqlConnection miConexion = frm.Conexion;

                // Aquí puedes usar miConexion para otras operaciones
            }
        }
    }
}
