using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace clase8.formularios
{
    public partial class frmMateria : Form
    {
        public frmMateria()
        {
            InitializeComponent();
        }

        private void frmMateria_Load(object sender, EventArgs e)
        {
            CargarMateria();
            cargarCombos();
            cboProfe.Text = "";
            cboCarrera.Text = "";
            Bloquear();
            //en el load desabilito los botones y los controles
            btnGrabarMateria.Enabled=false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;

        }
        public void CargarMateria()
        {
            try
            {
                conexionBDUTN.abrirConexion();
                string query = "select * from materias";
                SqlCommand cmd = new SqlCommand(query, conexionBDUTN.conn);
                DataTable memoria = new DataTable();

                SqlDataReader lector;

                lector = cmd.ExecuteReader();
                memoria.Load(lector);

                dgvMaterias.DataSource = memoria;


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        
        private void cargarCombos()
        {
            try
            {
                string query1 = "select id_profesor, concat(nombre ,' ', apellido) as nomb from profesores";
                cboProfe.DataSource = conexionBDUTN.leerDatos(query1);
                cboProfe.ValueMember = "id_profesor";
                cboProfe.DisplayMember = "nomb";

                string query2 = "select id_carrera, nombre from carreras";
                cboCarrera.DataSource = conexionBDUTN.leerDatos(query2);
                cboCarrera.ValueMember = "id_carrera";
                cboCarrera.DisplayMember = "nombre";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dgvMaterias_DoubleClick(object sender, EventArgs e)
        {
            txtId.Text = dgvMaterias.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dgvMaterias.CurrentRow.Cells[1].Value.ToString();
            cboProfe.SelectedValue = dgvMaterias.CurrentRow.Cells[2].Value;
            cboCarrera.SelectedValue = dgvMaterias.CurrentRow.Cells[3].Value;
            string estado = dgvMaterias.CurrentRow.Cells[4].Value.ToString();//devuelve texto True
           
            //esto convierte el texto True a un nro 
            if (estado == "True")
            {
                cboEstado.Text = "1";
            }
            else
            {
                cboEstado.Text = "0";
            }
            btnGrabarMateria.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            Bloquear();
        }

        private void btnGrabarMateria_Click(object sender, EventArgs e)
        {
            //evento donde al hacer clic ejecuto accion ok.....

            //validacion
            if (txtNombre.Text == "")//no hay cargado en el control textbox
            {
                MessageBox.Show("no tiene nombre de materia");
                txtNombre.Focus();
                return;
            }
            //fin de validacion
            guardarMateria();//llamo a la funcion
            Limpiar();
            Bloquear();
            btnGrabarMateria.Enabled = false;
        }
        private void guardarMateria()
        {
            try
            {
                //guardar datos de mis controles
                string nombre = txtNombre.Text;
                int id_prof = (int)cboProfe.SelectedValue;
                int id_carr = (int)cboCarrera.SelectedValue;
                int estado = int.Parse(cboEstado.Text);


                string query = "insert into materias (nombre,id_profesor,id_carrera,estado) values ('" + nombre + "'," + id_prof + "," + id_carr + "," + estado + ")";
                //agregue variables desde controles 
                conexionBDUTN.ejecutarSQL(query);
                CargarMateria();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Eliminar", "SE ELIMINARA REGISTRO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    int id = int.Parse(txtId.Text);
                    string query = "delete materias where id_materia = " + id + " ";
                    //delete materias where id_materia = 5
                    conexionBDUTN.ejecutarSQL(query); // me falto esto llamar a la funcion
                    CargarMateria();
                    Limpiar();
                    Bloquear();
                    btnGrabarMateria.Enabled = false;
                    btnEditar.Enabled = false;
                    btnEliminar.Enabled = false;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("MODIFICAR", "Se modificara materia "+txtNombre.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    //guardar datos de mis controles
                    string nombre = txtNombre.Text;
                    int id_prof = (int)cboProfe.SelectedValue;
                    int id_carr = (int)cboCarrera.SelectedValue;
                    int estado = int.Parse(cboEstado.Text);
                    int id_materia = int.Parse(txtId.Text);

                    string query = "update materias set nombre = '" + nombre + "' ,id_profesor = " + id_prof + " ,id_carrera = " + id_carr + ", estado = " + estado + " where id_materia = "+id_materia+"";
                    //agregue variables desde controles 
                    conexionBDUTN.ejecutarSQL(query);
                    CargarMateria();
                    Limpiar();
                    Bloquear();
                    btnGrabarMateria.Enabled = false;
                    btnEditar.Enabled = false;
                    btnEliminar.Enabled = false;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }   
        }
        
        private void pbxExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbxAtras_Click(object sender, EventArgs e)
        {
            Principal formulario = new Principal();
            formulario.Show();
            this.Close();
        }
        private void Bloquear()
        {
            txtNombre.Enabled=false;
            cboProfe.Enabled = false;
            cboCarrera.Enabled = false;
            cboEstado.Enabled = false;
        }
        private void Desbloquear()
        {
            txtNombre.Enabled = true;
            cboProfe.Enabled = true;
            cboCarrera.Enabled = true;
            cboEstado.Enabled = true;
        }

        private void pbxGuardar_Click(object sender, EventArgs e)
        {
            Desbloquear();
            btnGrabarMateria.Enabled = true;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            Limpiar();
        }
        private void Limpiar()
        {
            txtId.Text = "";
            txtNombre.Text = "";
            cboProfe.Text = "";
            cboCarrera.Text = "";
            cboEstado.Text = "";
        }

        private void pbxEditar_Click(object sender, EventArgs e)
        {
            if(txtId.Text=="")
            {
                MessageBox.Show("Debe elegir un registro de la grilla");
                return;
            }
            else
            {
                btnEliminar.Enabled = true;
                btnEditar.Enabled = true;
                Desbloquear();
            }
            
        }
    }
}
