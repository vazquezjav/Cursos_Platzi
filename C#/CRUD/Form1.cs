using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            String codigo = txtCodigo.Text;
            String nombre = txtNombre.Text;
            String descripcion = txtDescripcion.Text;
            double precio = double.Parse(txtPrecio.Text);
            int existencias = int.Parse(txtExistencias.Text);

            string sql = "INSERT INTO productos(codigo, nombre, descripcion, precio, existencias) values ('" + codigo + "','" + nombre + "','" + descripcion + "','" + precio + "','" + existencias + "')";

            MySqlConnection conexionBD = Conexion.conexion();

            conexionBD.Open(); // abrir la conexion con el objeto 

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);

                comando.ExecuteNonQuery();
                MessageBox.Show("Registro Guardado");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
        }
    }
}
