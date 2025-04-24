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
    
    public partial class cliente : Form
    {

        private SqlConnection cnx;
        private SqlDataAdapter adp;
        private DataTable tabCliente;

        public cliente(SqlConnection conexion)
        {
            InitializeComponent();

            cnx = conexion;

            adp = new SqlDataAdapter();

            // Configurar el comando SELECT
            adp.SelectCommand = new SqlCommand("spClienteSelect", cnx);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;

            // Configurar el comando INSERT
            adp.InsertCommand = new SqlCommand("sp_InsertarCliente", cnx);
            adp.InsertCommand.CommandType = CommandType.StoredProcedure;
            adp.InsertCommand.Parameters.Add("@Nombre", SqlDbType.VarChar, 100, "Nombre");
            adp.InsertCommand.Parameters.Add("@Telefono", SqlDbType.VarChar, 15, "Telefono");
            adp.InsertCommand.Parameters.Add("@Correo", SqlDbType.VarChar, 100, "Correo");
            adp.InsertCommand.Parameters.Add("@Direccion", SqlDbType.VarChar, 200, "Direccion");

            // Configurar el comando UPDATE
            adp.UpdateCommand = new SqlCommand("spClienteUpdate", cnx);
            adp.UpdateCommand.CommandType = CommandType.StoredProcedure;
            adp.UpdateCommand.Parameters.Add("@cli", SqlDbType.Int, 4, "ClienteID");
            adp.UpdateCommand.Parameters.Add("@nom", SqlDbType.VarChar, 100, "Nombre");
            adp.UpdateCommand.Parameters.Add("@tel", SqlDbType.VarChar, 15, "Telefono");

            // Configurar el comando DELETE
            adp.DeleteCommand = new SqlCommand("spClienteDelete", cnx);
            adp.DeleteCommand.CommandType = CommandType.StoredProcedure;
            adp.DeleteCommand.Parameters.Add("@cli", SqlDbType.Int, 4, "ClienteID");
        }

        private void cliente_Load(object sender, EventArgs e)
        {
            try
            {
                tabCliente = new DataTable();
                adp.Fill(tabCliente);
                dataGridView1.DataSource = tabCliente;

                // Configurar columnas del DataGridView
                dataGridView1.Columns["ClienteID"].ReadOnly = true;
                dataGridView1.Columns["ClienteID"].HeaderText = "ID Cliente";
                dataGridView1.Columns["Nombre"].HeaderText = "Nombre";
                dataGridView1.Columns["Telefono"].HeaderText = "Teléfono";
                dataGridView1.Columns["Correo"].HeaderText = "Correo";
                dataGridView1.Columns["Direccion"].HeaderText = "Dirección";
                dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Silver;
                dataGridView1.Columns["ClienteID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                adp.Update(tabCliente);
                MessageBox.Show("Información guardada satisfactoriamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    MessageBox.Show(ex.Errors[i].Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
