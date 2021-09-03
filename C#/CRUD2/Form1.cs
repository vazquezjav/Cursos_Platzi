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

namespace CRUD2
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String codigo = txtCodigo.Text;

            MySqlDataReader reader = null;
            string sql = "SELECT id, codigo, nombre, descripcion, precio, existencias FROM productos WHERE codigo LIKE '"+codigo+"' LIMIT 1 ";
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                reader = comando.ExecuteReader();

                //ver5ificar que si se encontraron resultados
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        txtId.Text = reader.GetString(0);
                        txtCodigo.Text = reader.GetString(1);
                        txtNombre.Text = reader.GetString(2);
                        txtDescripcion.Text = reader.GetString(3);
                        txtPrecio.Text = reader.GetString(4);
                        txtExistencias.Text = reader.GetString(5);
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron registros");
                }
            }catch(MySqlException ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
        }
    }
}
