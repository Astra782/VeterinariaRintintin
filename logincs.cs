using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VeterinariaRintintin
{
    public partial class logincs : Form
    {
        private SqlConnection cnx;
        private bool conectado;

        public SqlConnection Conexion
        {
            get
            {
                return cnx;
            }
        }

        public bool IsConectado
        {
            get
            {
                return conectado;
            }
        }

        public logincs()
        {
            InitializeComponent();
        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                // Construir la cadena de conexión
                string url = "Server=" + txtServidor.Text + "; DataBase=" +
                             txtBase.Text + "; UID=" + txtUsuario.Text + "; PWD=" +
                             txtPassword.Text;

                // Crear y abrir la conexión
                cnx = new SqlConnection(url);
                cnx.Open();
                conectado = true;

                // Cerrar el formulario si la conexión es exitosa
                Close();


            }
            catch (Exception ex)
            {
                // Mostrar mensaje de error
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
