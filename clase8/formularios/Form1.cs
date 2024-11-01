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

namespace clase8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TraerAlumnos();
            btnModificar.Enabled = false;
        }
        //funcion 
        private void TraerAlumnos()
        {
            //buscar proveedor y la BD
            string proveedor = "Data Source=.\\SQLEXPRESS;Initial Catalog=BDUTN;Integrated Security=True";
            //
            SqlConnection conexion = new SqlConnection(proveedor);
            string query = "select * from alumnos";

            SqlCommand comando = new SqlCommand(query, conexion);

            //generico objeto de memoria 
            DataTable tabla = new DataTable();

            SqlDataReader lector;


            try
            {
                conexion.Open();
                //MessageBox.Show("conectado");
                //trajo datos de bD
                lector = comando.ExecuteReader();
                tabla.Load(lector);

                dgvAlumnos.DataSource = tabla;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
            finally
            {
                conexion.Close();
            }
        }

        private void dgvAlumnos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            //MessageBox.Show("hola");
            btnGrabarAlumno.Enabled = false;
            btnEliminarFisico.Enabled = true;
            btnModificar.Enabled = true;
            txtId.Text = Convert.ToString(dgvAlumnos.CurrentRow.Cells[0].Value);
            txtApellido.Text= Convert.ToString(dgvAlumnos.CurrentRow.Cells[1].Value);
            txtNombre.Text=Convert.ToString(dgvAlumnos.CurrentRow.Cells[2].Value);
        }

        private void btnGrabarAlumno_Click(object sender, EventArgs e)
        {
            grabarAlumno();
        }
        private void grabarAlumno()
        {
            //validacion de vacios
            if (txtApellido.Text == "" || txtNombre.Text == "")
            {
                txtApellido.Focus();
                MessageBox.Show("hay textos vacios");
                return;//corta la funcion
                
            }
            //variables para grabar datos
            string apellido = txtApellido.Text;
            string nombre = txtNombre.Text;

            //buscar proveedor y la BD
            string proveedor = "Data Source=.\\SQLEXPRESS;Initial Catalog=BDUTN;Integrated Security=True";
            //
            SqlConnection conexion = new SqlConnection(proveedor);

            //meter la variables a nuestra query metodo1 
            string query = "insert into alumnos values('"+apellido+"','"+nombre+"',1)";

            SqlCommand comando = new SqlCommand(query, conexion);
            try
            {
                conexion.Open();
                //libro pagina 251
                comando.CommandType = CommandType.Text;
                comando.CommandText = query;
                comando.ExecuteNonQuery();

                TraerAlumnos();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            finally { conexion.Close(); }

            txtApellido.Text = "";
            txtNombre.Text = "";
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            modificarAlumno();
        }
        private void modificarAlumno()
        {
            //validacion de vacios
            if (txtApellido.Text == "" || txtNombre.Text == "")
            {
                MessageBox.Show("Cajas de texto Vacias");
                txtApellido.Focus();
                //cortamos la funcion
                return;

            }
            //variables para grabar datos
            string apellido = txtApellido.Text;
            string nombre = txtNombre.Text;
            int id =Int32.Parse(txtId.Text);

            //buscar proveedor y la BD
            string proveedor = "Data Source=.\\SQLEXPRESS;Initial Catalog=BDUTN;Integrated Security=True";
            //
            SqlConnection conexion = new SqlConnection(proveedor);

            //meter la variables a nuestra query metodo1 
            string query = "update alumnos set apellido='" + apellido + "', nombre='" + nombre + "' where id_alumno = "+id+"";

            SqlCommand comando = new SqlCommand(query, conexion);
            try
            {
                conexion.Open();
                //libro pagina 251
                comando.CommandType = CommandType.Text;
                comando.CommandText = query;
                comando.ExecuteNonQuery();

                MessageBox.Show("se modifica alumn@ con ID:"+ id);

                TraerAlumnos();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            finally { conexion.Close(); }

            txtApellido.Text = "";
            txtNombre.Text = "";
            txtId.Text = "";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnEliminarFisico.Enabled = false;
            btnGrabarAlumno.Enabled = true;
            btnModificar.Enabled = false;
            txtApellido.Text = "";
            txtNombre.Text = "";
            txtId.Text = "";
        }
        private void borrarAlumnoFisico()
        {
            //variables para grabar datos
            string apellido = txtApellido.Text;
            string nombre = txtNombre.Text;
            int id = Int32.Parse(txtId.Text);

            //buscar proveedor y la BD
            string proveedor = "Data Source=.\\SQLEXPRESS;Initial Catalog=BDUTN;Integrated Security=True";
            //
            SqlConnection conexion = new SqlConnection(proveedor);

            //meter la variables a nuestra query metodo1 
            string query = "delete  alumnos  where id_alumno = " + id + "";

            SqlCommand comando = new SqlCommand(query, conexion);
            try
            {
                conexion.Open();
                //libro pagina 251
                comando.CommandType = CommandType.Text;
                comando.CommandText = query;
                comando.ExecuteNonQuery();

                MessageBox.Show("se borro en registro de;  "+ apellido+ " "+nombre);

                TraerAlumnos();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            finally { conexion.Close(); }

            txtApellido.Text = "";
            txtNombre.Text = "";
            txtId.Text = "";
        }

       
        private void btnEliminarFisico_Click_1(object sender, EventArgs e)
        {
            borrarAlumnoFisico();
        }

        private void dgvAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lklAbrirConexion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                conexionBDUTN.abrirConexion();
                MessageBox.Show("se conecto");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexionBDUTN.cerrarConexion();
            }
        }
    }
}
 