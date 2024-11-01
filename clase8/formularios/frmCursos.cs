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

namespace clase8.formularios
{
    public partial class frmCursos : Form
    {
        public frmCursos()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            principal.Show();
            this.Close();
        }

        private void frmCursos_Load(object sender, EventArgs e)
        {
            cargarGrillaCurso();
            cargarComboAlumno();
            cargarComboMateria();

        }
        public void cargarGrillaCurso()
        {
            try
            {
                conexionBDUTN.abrirConexion();
                string query = "select ac.id_orden," +
                    " al.apellido as 'Apellido Alumno', " +
                    "al.dni as DNI," +
                    " mt.nombre Materia, carr.nombre as Carrera, " +
                    "concat(pf.apellido, ' ', pf.nombre) as Profesor " +
                    "from alumno_curso as ac " +
                    "inner join alumnos as al on ac.id_alumno = al.id_alumno" +
                    " inner join materias as mt on ac.id_materia = mt.id_materia" +
                    " inner join carreras as carr on mt.id_carrera = carr.id_carrera" +
                    " inner join profesores as pf on mt.id_profesor = pf.id_profesor";

                SqlCommand cmd = new SqlCommand(query, conexionBDUTN.conn);
                DataTable mem = new DataTable();

                SqlDataReader lector;

                lector = cmd.ExecuteReader();
                mem.Load(lector);

                dgvCursos.DataSource = mem;


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally { conexionBDUTN.cerrarConexion(); }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public void cargarComboAlumno()
        {
            try
            {
                conexionBDUTN.abrirConexion();
                string query = "select id_alumno, concat (apellido,' ',nombre,' ',dni) as ALUMNO  from alumnos";

                SqlCommand cmd = new SqlCommand(query, conexionBDUTN.conn);
                DataTable mem = new DataTable();

                SqlDataReader lector;

                lector = cmd.ExecuteReader();
                mem.Load(lector);

                cboAlumno.DataSource = mem;
                cboAlumno.ValueMember = "id_alumno";
                cboAlumno.DisplayMember = "ALUMNO";


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally { conexionBDUTN.cerrarConexion(); }
        }
        public void cargarComboMateria()
        {
            try
            {
                conexionBDUTN.abrirConexion();
                string query = "select m.id_materia, concat (m.nombre,' ',c.nombre) as MATERIA from materias as m inner join carreras as c on m.id_carrera = c.id_carrera";

                SqlCommand cmd = new SqlCommand(query, conexionBDUTN.conn);
                DataTable mem = new DataTable();

                SqlDataReader lector;

                lector = cmd.ExecuteReader();
                mem.Load(lector);

                cboMateria.DataSource = mem;
                cboMateria.ValueMember = "id_materia";
                cboMateria.DisplayMember = "MATERIA";


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally { conexionBDUTN.cerrarConexion(); }
        }
        public void grabarCurso()
        {

            //MessageBox.Show(cboAlumno.SelectedValue.ToString());
            int alunmo = (int)cboAlumno.SelectedValue;
            int curso = (int)cboMateria.SelectedValue;

            conexionBDUTN.abrirConexion();
            string query = "insert into alumno_curso (id_alumno, id_materia) values (" + alunmo + "," + curso + ")";

            SqlCommand cmd = new SqlCommand(query, conexionBDUTN.conn);

            //libro pagina 251
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

            cargarGrillaCurso();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            grabarCurso();
        }

        private void gbxBuscar_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (rbtAlumno.Checked)
            {
                grillaFiltradaAlumno();
            }
            else
            {
                if (rbtMateria.Checked)
                {
                    grillaFiltradaMateria();
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
        public void grillaFiltradaAlumno()
        {
            try
            {
                string filtro =txtFiltrar.Text;
                conexionBDUTN.abrirConexion();
                string query = "select ac.id_orden, al.apellido as 'Apellido Alumno', " +
                    "al.dni as DNI, mt.nombre Materia, carr.nombre as Carrera, " +
                    "concat(pf.apellido, ' ', pf.nombre) as Profesor " +
                    "from alumno_curso as ac " +
                    "inner join alumnos as al on ac.id_alumno = al.id_alumno" +
                    " inner join materias as mt on ac.id_materia = mt.id_materia" +
                    " inner join carreras as carr on mt.id_carrera = carr.id_carrera" +
                    " inner join profesores as pf on mt.id_profesor = pf.id_profesor" +
                    " where al.apellido like '%"+filtro+"%'";

                SqlCommand cmd = new SqlCommand(query, conexionBDUTN.conn);
                DataTable mem = new DataTable();

                SqlDataReader lector;

                lector = cmd.ExecuteReader();
                mem.Load(lector);

                dgvCursos.DataSource = mem;


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally { conexionBDUTN.cerrarConexion(); }
        }
        public void grillaFiltradaMateria()
        {
            try
            {
                string filtro = txtFiltrar.Text;
                conexionBDUTN.abrirConexion();
                string query = "select ac.id_orden, al.apellido as 'Apellido Alumno', " +
                    "al.dni as DNI, mt.nombre Materia, carr.nombre as Carrera, " +
                    "concat(pf.apellido, ' ', pf.nombre) as Profesor " +
                    "from alumno_curso as ac " +
                    "inner join alumnos as al on ac.id_alumno = al.id_alumno" +
                    " inner join materias as mt on ac.id_materia = mt.id_materia" +
                    " inner join carreras as carr on mt.id_carrera = carr.id_carrera" +
                    " inner join profesores as pf on mt.id_profesor = pf.id_profesor" +
                    " where mt.nombre like '%" + filtro + "%'";

                SqlCommand cmd = new SqlCommand(query, conexionBDUTN.conn);
                DataTable mem = new DataTable();

                SqlDataReader lector;

                lector = cmd.ExecuteReader();
                mem.Load(lector);

                dgvCursos.DataSource = mem;


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally { conexionBDUTN.cerrarConexion(); }
        }

    }
}
