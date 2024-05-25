using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocios;
using CapaDatos;
using System.Data.SqlClient;
using System.Configuration;

namespace WindowsFormsApp1
{
    public partial class Formtodas : Form
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["CnnORDEN"].ConnectionString);


        //public SqlConnection cn = new SqlConnection("CnnORDEN");
        Clsopcion Op = new Clsopcion();
        clsopinterna O = new clsopinterna();
        clsOp vo = new clsOp();

        ClsReglasEmpleados Reglas = new ClsReglasEmpleados();
        ClsTBL_EMPLEADOS TblAtri = new ClsTBL_EMPLEADOS();


        Clsopemple E = new Clsopemple();
        int Listado = 0;
        int Listado1 = 0;
        public Formtodas()
        {
            InitializeComponent();
        }

        private void Listarempleado()
        {

            DataTable dt = new DataTable();
            dt = Reglas.ListadoEmpleados();
            try
            {
                dataGridView9.Rows.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dataGridView9.Rows.Add(dt.Rows[i][0]);
                    dataGridView9.Rows[i].Cells[0].Value = dt.Rows[i][0].ToString();
                    dataGridView9.Rows[i].Cells[1].Value = dt.Rows[i][1].ToString();
                    dataGridView9.Rows[i].Cells[2].Value = dt.Rows[i][2].ToString();
                    dataGridView9.Rows[i].Cells[3].Value = dt.Rows[i][3].ToString();

                    //Verresul();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            dataGridView9.ClearSelection();
        }
        private void Cargarlistaop()

        {

            DataTable dt = new DataTable();
            dt = O.Listadopyem();
            try
            {
                dataGridView2.Rows.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dataGridView2.Rows.Add(dt.Rows[i][0]);
                    dataGridView2.Rows[i].Cells[0].Value = dt.Rows[i][0].ToString();
                    dataGridView2.Rows[i].Cells[1].Value = dt.Rows[i][1].ToString();
                    dataGridView2.Rows[i].Cells[2].Value = dt.Rows[i][2].ToString();
                    dataGridView2.Rows[i].Cells[3].Value = dt.Rows[i][3].ToString();
                    dataGridView2.Rows[i].Cells[4].Value = dt.Rows[i][4].ToString();
                    dataGridView2.Rows[i].Cells[5].Value = dt.Rows[i][5].ToString();
                    dataGridView2.Rows[i].Cells[6].Value = dt.Rows[i][6].ToString();
                    dataGridView2.Rows[i].Cells[7].Value = dt.Rows[i][7].ToString();
                    dataGridView2.Rows[i].Cells[8].Value = dt.Rows[i][8].ToString();
                    dataGridView2.Rows[i].Cells[9].Value = dt.Rows[i][9].ToString();
                    dataGridView2.Rows[i].Cells[10].Value = dt.Rows[i][10].ToString();
                    dataGridView2.Rows[i].Cells[11].Value = dt.Rows[i][11].ToString();
                    dataGridView2.Rows[i].Cells[12].Value = dt.Rows[i][12].ToString();
                    dataGridView2.Rows[i].Cells[13].Value = dt.Rows[i][13].ToString();
                    dataGridView2.Rows[i].Cells[14].Value = dt.Rows[i][14].ToString();
                    dataGridView2.Rows[i].Cells[15].Value = dt.Rows[i][15].ToString();
                    dataGridView2.Rows[i].Cells[16].Value = dt.Rows[i][16].ToString();
                    dataGridView2.Rows[i].Cells[17].Value = dt.Rows[i][17].ToString();
                    dataGridView2.Rows[i].Cells[18].Value = dt.Rows[i][18].ToString();
                    dataGridView2.Rows[i].Cells[19].Value = dt.Rows[i][19].ToString();
                    dataGridView2.Rows[i].Cells[20].Value = dt.Rows[i][20].ToString();
                    dataGridView2.Rows[i].Cells[21].Value = dt.Rows[i][21].ToString();
                    dataGridView2.Rows[i].Cells[22].Value = dt.Rows[i][22].ToString();
                    dataGridView2.Rows[i].Cells[23].Value = dt.Rows[i][23].ToString();

                    //  Verresul();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataGridView2.ClearSelection();
            //Verresul();

        }
        private void Busquedaopyemop()
        {
            DataTable dt = new DataTable();

            try
            {
                O.Opopera = Convert.ToInt32(textBox4.Text);
                dt = O.Buscareopyem(O.Opopera);
                dataGridView2.Rows.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dataGridView2.Rows.Add(dt.Rows[i][0]);
                    dataGridView2.Rows[i].Cells[0].Value = dt.Rows[i][0].ToString();
                    dataGridView2.Rows[i].Cells[1].Value = dt.Rows[i][1].ToString();
                    dataGridView2.Rows[i].Cells[2].Value = dt.Rows[i][2].ToString();
                    dataGridView2.Rows[i].Cells[3].Value = dt.Rows[i][3].ToString();
                    dataGridView2.Rows[i].Cells[4].Value = dt.Rows[i][4].ToString();
                    dataGridView2.Rows[i].Cells[5].Value = dt.Rows[i][5].ToString();
                    dataGridView2.Rows[i].Cells[6].Value = dt.Rows[i][6].ToString();
                    dataGridView2.Rows[i].Cells[7].Value = dt.Rows[i][7].ToString();
                    dataGridView2.Rows[i].Cells[8].Value = dt.Rows[i][8].ToString();
                    dataGridView2.Rows[i].Cells[9].Value = dt.Rows[i][9].ToString();
                    dataGridView2.Rows[i].Cells[10].Value = dt.Rows[i][10].ToString();
                    dataGridView2.Rows[i].Cells[11].Value = dt.Rows[i][11].ToString();
                    dataGridView2.Rows[i].Cells[12].Value = dt.Rows[i][12].ToString();
                    dataGridView2.Rows[i].Cells[13].Value = dt.Rows[i][13].ToString();
                    dataGridView2.Rows[i].Cells[14].Value = dt.Rows[i][14].ToString();
                    dataGridView2.Rows[i].Cells[15].Value = dt.Rows[i][15].ToString();
                    dataGridView2.Rows[i].Cells[16].Value = dt.Rows[i][16].ToString();
                    dataGridView2.Rows[i].Cells[17].Value = dt.Rows[i][17].ToString();
                    dataGridView2.Rows[i].Cells[18].Value = dt.Rows[i][18].ToString();
                    dataGridView2.Rows[i].Cells[19].Value = dt.Rows[i][19].ToString();
                    dataGridView2.Rows[i].Cells[20].Value = dt.Rows[i][20].ToString();
                    dataGridView2.Rows[i].Cells[21].Value = dt.Rows[i][21].ToString();
                    dataGridView2.Rows[i].Cells[22].Value = dt.Rows[i][22].ToString();
                    dataGridView2.Rows[i].Cells[23].Value = dt.Rows[i][23].ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Solo se admiten el valor de la OP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // label2.Text = "REGISTRO NO ENCONTRADO";
            dataGridView2.ClearSelection();
            // Verresul2();

        }
        private void Cargarlistado5()

        {

            DataTable dt = new DataTable();
            dt = E.Listadooperaemple();
            try
            {
                dataGridView3.Rows.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dataGridView3.Rows.Add(dt.Rows[i][0]);
                    dataGridView3.Rows[i].Cells[0].Value = dt.Rows[i][0].ToString();
                    dataGridView3.Rows[i].Cells[1].Value = dt.Rows[i][1].ToString();
                    dataGridView3.Rows[i].Cells[2].Value = dt.Rows[i][2].ToString();
                    dataGridView3.Rows[i].Cells[3].Value = dt.Rows[i][3].ToString();
                    dataGridView3.Rows[i].Cells[4].Value = dt.Rows[i][4].ToString();
                    dataGridView3.Rows[i].Cells[5].Value = dt.Rows[i][5].ToString();
                    dataGridView3.Rows[i].Cells[6].Value = dt.Rows[i][6].ToString();
                    dataGridView3.Rows[i].Cells[7].Value = dt.Rows[i][7].ToString();
                    dataGridView3.Rows[i].Cells[8].Value = dt.Rows[i][8].ToString();
                    dataGridView3.Rows[i].Cells[9].Value = dt.Rows[i][9].ToString();
                    dataGridView3.Rows[i].Cells[10].Value = dt.Rows[i][10].ToString();
                    dataGridView3.Rows[i].Cells[11].Value = dt.Rows[i][11].ToString();
                    dataGridView3.Rows[i].Cells[12].Value = dt.Rows[i][12].ToString();
                    dataGridView3.Rows[i].Cells[13].Value = dt.Rows[i][13].ToString();
                    dataGridView3.Rows[i].Cells[14].Value = dt.Rows[i][14].ToString();
                    dataGridView3.Rows[i].Cells[15].Value = dt.Rows[i][15].ToString();
                    dataGridView3.Rows[i].Cells[16].Value = dt.Rows[i][16].ToString();
                    dataGridView3.Rows[i].Cells[17].Value = dt.Rows[i][17].ToString();
                    dataGridView3.Rows[i].Cells[18].Value = dt.Rows[i][18].ToString();
                    dataGridView3.Rows[i].Cells[19].Value = dt.Rows[i][19].ToString();
                    dataGridView3.Rows[i].Cells[20].Value = dt.Rows[i][20].ToString();
                    dataGridView3.Rows[i].Cells[21].Value = dt.Rows[i][21].ToString();
                    dataGridView3.Rows[i].Cells[22].Value = dt.Rows[i][22].ToString();
                    dataGridView3.Rows[i].Cells[23].Value = dt.Rows[i][23].ToString();
                    dataGridView3.Rows[i].Cells[24].Value = dt.Rows[i][24].ToString();
                    dataGridView3.Rows[i].Cells[25].Value = dt.Rows[i][25].ToString();
                    dataGridView3.Rows[i].Cells[26].Value = dt.Rows[i][26].ToString();
                    //Verresul();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataGridView3.ClearSelection();
            // Verresul();

        }
        private void Busquedaopemple()
        {
            DataTable dt = new DataTable();

            try
            {
                E.Opopera = Convert.ToInt32(textBox4.Text);
                dt = E.Buscareop(E.Opopera);
                dataGridView3.Rows.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dataGridView3.Rows.Add(dt.Rows[i][0]);
                    dataGridView3.Rows[i].Cells[0].Value = dt.Rows[i][0].ToString();
                    dataGridView3.Rows[i].Cells[1].Value = dt.Rows[i][1].ToString();
                    dataGridView3.Rows[i].Cells[2].Value = dt.Rows[i][2].ToString();
                    dataGridView3.Rows[i].Cells[3].Value = dt.Rows[i][3].ToString();
                    dataGridView3.Rows[i].Cells[4].Value = dt.Rows[i][4].ToString();
                    dataGridView3.Rows[i].Cells[5].Value = dt.Rows[i][5].ToString();
                    dataGridView3.Rows[i].Cells[6].Value = dt.Rows[i][6].ToString();
                    dataGridView3.Rows[i].Cells[7].Value = dt.Rows[i][7].ToString();
                    dataGridView3.Rows[i].Cells[8].Value = dt.Rows[i][8].ToString();
                    dataGridView3.Rows[i].Cells[9].Value = dt.Rows[i][9].ToString();
                    dataGridView3.Rows[i].Cells[10].Value = dt.Rows[i][10].ToString();
                    dataGridView3.Rows[i].Cells[11].Value = dt.Rows[i][11].ToString();
                    dataGridView3.Rows[i].Cells[12].Value = dt.Rows[i][12].ToString();
                    dataGridView3.Rows[i].Cells[13].Value = dt.Rows[i][13].ToString();
                    dataGridView3.Rows[i].Cells[14].Value = dt.Rows[i][14].ToString();
                    dataGridView3.Rows[i].Cells[15].Value = dt.Rows[i][15].ToString();
                    dataGridView3.Rows[i].Cells[16].Value = dt.Rows[i][16].ToString();
                    dataGridView3.Rows[i].Cells[17].Value = dt.Rows[i][17].ToString();
                    dataGridView3.Rows[i].Cells[18].Value = dt.Rows[i][18].ToString();
                    dataGridView3.Rows[i].Cells[19].Value = dt.Rows[i][19].ToString();
                    dataGridView3.Rows[i].Cells[20].Value = dt.Rows[i][20].ToString();
                    dataGridView3.Rows[i].Cells[21].Value = dt.Rows[i][21].ToString();
                    dataGridView3.Rows[i].Cells[22].Value = dt.Rows[i][22].ToString();
                    dataGridView3.Rows[i].Cells[23].Value = dt.Rows[i][23].ToString();
                    dataGridView3.Rows[i].Cells[24].Value = dt.Rows[i][24].ToString();
                    dataGridView3.Rows[i].Cells[25].Value = dt.Rows[i][25].ToString();
                    dataGridView3.Rows[i].Cells[26].Value = dt.Rows[i][26].ToString();



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Solo se admiten el valor de la OP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dataGridView3.ClearSelection();
            // Verresul2();

        }
        private void Busquedaemplcedula()
        {
            DataTable dt = new DataTable();

            try
            {
                E.Cedula = Convert.ToInt32(textBox4.Text);
                dt = E.Buscacedu(E.Cedula);
                dataGridView3.Rows.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dataGridView3.Rows.Add(dt.Rows[i][0]);
                    dataGridView3.Rows[i].Cells[0].Value = dt.Rows[i][0].ToString();
                    dataGridView3.Rows[i].Cells[1].Value = dt.Rows[i][1].ToString();
                    dataGridView3.Rows[i].Cells[2].Value = dt.Rows[i][2].ToString();
                    dataGridView3.Rows[i].Cells[3].Value = dt.Rows[i][3].ToString();
                    dataGridView3.Rows[i].Cells[4].Value = dt.Rows[i][4].ToString();
                    dataGridView3.Rows[i].Cells[5].Value = dt.Rows[i][5].ToString();
                    dataGridView3.Rows[i].Cells[6].Value = dt.Rows[i][6].ToString();
                    dataGridView3.Rows[i].Cells[7].Value = dt.Rows[i][7].ToString();
                    dataGridView3.Rows[i].Cells[8].Value = dt.Rows[i][8].ToString();
                    dataGridView3.Rows[i].Cells[9].Value = dt.Rows[i][9].ToString();
                    dataGridView3.Rows[i].Cells[10].Value = dt.Rows[i][10].ToString();
                    dataGridView3.Rows[i].Cells[11].Value = dt.Rows[i][11].ToString();
                    dataGridView3.Rows[i].Cells[12].Value = dt.Rows[i][12].ToString();
                    dataGridView3.Rows[i].Cells[13].Value = dt.Rows[i][13].ToString();
                    dataGridView3.Rows[i].Cells[14].Value = dt.Rows[i][14].ToString();
                    dataGridView3.Rows[i].Cells[15].Value = dt.Rows[i][15].ToString();
                    dataGridView3.Rows[i].Cells[16].Value = dt.Rows[i][16].ToString();
                    dataGridView3.Rows[i].Cells[17].Value = dt.Rows[i][17].ToString();
                    dataGridView3.Rows[i].Cells[18].Value = dt.Rows[i][18].ToString();
                    dataGridView3.Rows[i].Cells[19].Value = dt.Rows[i][19].ToString();
                    dataGridView3.Rows[i].Cells[20].Value = dt.Rows[i][20].ToString();
                    dataGridView3.Rows[i].Cells[21].Value = dt.Rows[i][21].ToString();
                    dataGridView3.Rows[i].Cells[22].Value = dt.Rows[i][22].ToString();
                    dataGridView3.Rows[i].Cells[23].Value = dt.Rows[i][23].ToString();
                    dataGridView3.Rows[i].Cells[24].Value = dt.Rows[i][24].ToString();
                    dataGridView3.Rows[i].Cells[25].Value = dt.Rows[i][25].ToString();
                    dataGridView3.Rows[i].Cells[26].Value = dt.Rows[i][26].ToString();



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Solo se admiten el valor de la OP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dataGridView3.ClearSelection();
            // Verresul2();

        }
        private void Busquedaopemple2()
        {
            DataTable dt = new DataTable();

            try
            {
                O.Cedula = Convert.ToInt32(textBox4.Text);
                dt = O.Buscareopyemcedu(O.Cedula);
                dataGridView2.Rows.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dataGridView2.Rows.Add(dt.Rows[i][0]);
                    dataGridView2.Rows[i].Cells[0].Value = dt.Rows[i][0].ToString();
                    dataGridView2.Rows[i].Cells[1].Value = dt.Rows[i][1].ToString();
                    dataGridView2.Rows[i].Cells[2].Value = dt.Rows[i][2].ToString();
                    dataGridView2.Rows[i].Cells[3].Value = dt.Rows[i][3].ToString();
                    dataGridView2.Rows[i].Cells[4].Value = dt.Rows[i][4].ToString();
                    dataGridView2.Rows[i].Cells[5].Value = dt.Rows[i][5].ToString();
                    dataGridView2.Rows[i].Cells[6].Value = dt.Rows[i][6].ToString();
                    dataGridView2.Rows[i].Cells[7].Value = dt.Rows[i][7].ToString();
                    dataGridView2.Rows[i].Cells[8].Value = dt.Rows[i][8].ToString();
                    dataGridView2.Rows[i].Cells[9].Value = dt.Rows[i][9].ToString();
                    dataGridView2.Rows[i].Cells[10].Value = dt.Rows[i][10].ToString();
                    dataGridView2.Rows[i].Cells[11].Value = dt.Rows[i][11].ToString();
                    dataGridView2.Rows[i].Cells[12].Value = dt.Rows[i][12].ToString();
                    dataGridView2.Rows[i].Cells[13].Value = dt.Rows[i][13].ToString();
                    dataGridView2.Rows[i].Cells[14].Value = dt.Rows[i][14].ToString();
                    dataGridView2.Rows[i].Cells[15].Value = dt.Rows[i][15].ToString();
                    dataGridView2.Rows[i].Cells[16].Value = dt.Rows[i][16].ToString();
                    dataGridView2.Rows[i].Cells[17].Value = dt.Rows[i][17].ToString();
                    dataGridView2.Rows[i].Cells[18].Value = dt.Rows[i][18].ToString();
                    dataGridView2.Rows[i].Cells[19].Value = dt.Rows[i][19].ToString();
                    dataGridView2.Rows[i].Cells[20].Value = dt.Rows[i][20].ToString();
                    dataGridView2.Rows[i].Cells[21].Value = dt.Rows[i][21].ToString();
                    dataGridView2.Rows[i].Cells[22].Value = dt.Rows[i][22].ToString();
                    dataGridView2.Rows[i].Cells[23].Value = dt.Rows[i][23].ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Solo se admiten el valor de la OP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //label2.Text = "REGISTRO NO ENCONTRADO";
            dataGridView2.ClearSelection();
            // Verresul2();

        }
        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                buscarop1cedu4();
                buscarop1cedu3();
                buscarop1cedu2();
                buscarop1cedu();
                buscarop1();
                buscarop2();
                Busquedaopyemop();
                Busquedaemplcedula();
                Busquedaopemple();
                timer1.Stop();
                dataGridView3.ClearSelection();
                dataGridView3.Focus();
                Verresul();
                Verresul2();
                Verresul3();
                Verresul4();


            }
            catch (Exception ex)
            {
                //lblverno.Text = "Registro no encontrado";
                MessageBox.Show("Registro de Orden de Produccion no Existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dataGridView3.ClearSelection();
            dataGridView3.Focus();
        }
        void buscarop1()
        {
            try
            {

                SqlDataAdapter da = new SqlDataAdapter("buscarope", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@Datos", SqlDbType.Int).Value = textBox4.Text;
                //da.SelectCommand.Parameters.Add("@fechafinal", SqlDbType.DateTime).Value = datelune.Text;
                DataTable dt = new DataTable();
                da.Fill(dt);
                this.dataGridView1.DataSource = dt;
                Verresul();
                Verresul2();
                Verresul3();
                Verresul4();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //lblverno.Text = "Registro no encontrado";
                MessageBox.Show("Solo se admiten el valor de la OP  1", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        void buscarop2()
        {
            try
            {

                SqlDataAdapter da = new SqlDataAdapter("buscaropyemple", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@Datos", SqlDbType.Int).Value = textBox4.Text;
                //da.SelectCommand.Parameters.Add("@fechafinal", SqlDbType.DateTime).Value = datelune.Text;
                DataTable dt = new DataTable();
                da.Fill(dt);
                this.dataGridView4.DataSource = dt;
                Verresul();
                Verresul2();
                Verresul3();
                Verresul4();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //lblverno.Text = "Registro no encontrado";
                MessageBox.Show("Solo se admiten el valor de la OP  2", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        void buscarop1cedu3()
        {
            try
            {

                SqlDataAdapter da = new SqlDataAdapter("buscaopcedu", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@Datos", SqlDbType.Int).Value = textBox4.Text;
                //da.SelectCommand.Parameters.Add("@fechafinal", SqlDbType.DateTime).Value = datelune.Text;
                DataTable dt = new DataTable();
                da.Fill(dt);
                this.dataGridView7.DataSource = dt;
                Verresul();
                Verresul2();
                Verresul3();
                Verresul4();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //lblverno.Text = "Registro no encontrado";
                MessageBox.Show("Solo se admiten el valor de la OP 3", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        void buscarop1cedu4()
        {
            try
            {

                SqlDataAdapter da = new SqlDataAdapter("buscarhorarioce", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@Datos", SqlDbType.Int).Value = textBox4.Text;
                //da.SelectCommand.Parameters.Add("@fechafinal", SqlDbType.DateTime).Value = datelune.Text;
                DataTable dt = new DataTable();
                da.Fill(dt);
                this.dataGridView6.DataSource = dt;
                Verresul();
                Verresul2();
                Verresul3();
                Verresul4();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //lblverno.Text = "Registro no encontrado";
                MessageBox.Show("Solo se admiten el valor de la OP 4", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        void buscarop1cedu()
        {
            try
            {

                SqlDataAdapter da = new SqlDataAdapter("buscaropcedu", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@Datos", SqlDbType.Int).Value = textBox4.Text;
                //da.SelectCommand.Parameters.Add("@fechafinal", SqlDbType.DateTime).Value = datelune.Text;
                DataTable dt = new DataTable();
                da.Fill(dt);
                this.dataGridView1.DataSource = dt;
                Verresul();
                Verresul2();
                Verresul3();
                Verresul4();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //lblverno.Text = "Registro no encontrado";
                MessageBox.Show("Solo se admiten el valor de la OP 5", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        void buscarop1cedu2()
        {
            try
            {

                SqlDataAdapter da = new SqlDataAdapter("buscaropyemple2", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@Datos", SqlDbType.Int).Value = textBox4.Text;
                //da.SelectCommand.Parameters.Add("@fechafinal", SqlDbType.DateTime).Value = datelune.Text;
                DataTable dt = new DataTable();
                da.Fill(dt);
                this.dataGridView4.DataSource = dt;
                Verresul();
                Verresul2();
                Verresul3();
                Verresul4();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //lblverno.Text = "Registro no encontrado";
                MessageBox.Show("Solo se admiten el valor de la OP 6", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        void buscar2()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("buscarfechas2", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@fechaini", SqlDbType.DateTime).Value = dateTimePicker1.Text;
                da.SelectCommand.Parameters.Add("@fechafinal", SqlDbType.DateTime).Value = datelune.Text;
                DataTable dt = new DataTable();
                da.Fill(dt);

                this.dataGridView4.DataSource = dt;
                Verresul();
                Verresul2();
                Verresul3();
                Verresul4();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //lblverno.Text = "Registro no encontrado";
                MessageBox.Show("Solo se admiten el valor de la OP 7", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        void buscar()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("buscarfechas", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@fechaini", SqlDbType.DateTime).Value = dateTimePicker1.Text;
                da.SelectCommand.Parameters.Add("@fechafinal", SqlDbType.DateTime).Value = datelune.Text;
                DataTable dt = new DataTable();
                da.Fill(dt);
                this.dataGridView1.DataSource = dt;

                Verresul();
                Verresul2();
                Verresul3();
                Verresul4();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //lblverno.Text = "Registro no encontrado";
                //MessageBox.Show("Solo se admiten el valor de la OP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        void buscar3()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("buscarfechas3", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@fechaini", SqlDbType.DateTime).Value = dateTimePicker1.Text;
                da.SelectCommand.Parameters.Add("@fechafinal", SqlDbType.DateTime).Value = datelune.Text;
                DataTable dt = new DataTable();
                da.Fill(dt);
                this.dataGridView7.DataSource = dt;

                Verresul();
                Verresul2();
                Verresul3();
                Verresul4();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //lblverno.Text = "Registro no encontrado";
                //MessageBox.Show("Solo se admiten el valor de la OP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        void buscar4()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("buscarfechas4", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@fechaini", SqlDbType.DateTime).Value = dateTimePicker1.Text;
                da.SelectCommand.Parameters.Add("@fechafinal", SqlDbType.DateTime).Value = datelune.Text;
                DataTable dt = new DataTable();
                da.Fill(dt);
                this.dataGridView6.DataSource = dt;

                Verresul();
                Verresul2();
                Verresul3();
                Verresul4();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //lblverno.Text = "Registro no encontrado";
                //MessageBox.Show("Solo se admiten el valor de la OP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        DataTable dt = new DataTable("empleados");
        DataTable dt11 = new DataTable("opemple");
        DataTable dt2 = new DataTable("operacemple");

        private void Formtodas_Load(object sender, EventArgs e)
        {
           
            try
            {
                using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["CnnORDEN"].ConnectionString))

                {
                    if (cn.State == ConnectionState.Closed)
                        cn.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter("select * from  empleados", cn))
                    {
                        // DataTable dt = new DataTable("operacemple");

                        da.Fill(dt);
                        dataGridView9.DataSource = dt;

                        // DataGridViewColumn column = dataGridView9.Columns[0];
                        // column.Visible = false;
                        dataGridView9.Columns[0].HeaderText = "Cedula";
                        dataGridView9.Columns[1].HeaderText = "Nombre       Empleado";
                        dataGridView9.Columns[2].HeaderText = "Cargo";
                        dataGridView9.Columns[3].HeaderText = "Categoria";
                        dataGridView9.Columns[4].HeaderText = "Fecha de Ingreso";
                        dataGridView9.Columns[5].HeaderText = "Sexo";

                    }

                    color();
                    colorazul();
                    colorazul2();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //lblverno.Text = "Registro no encontrado";
                //MessageBox.Show("Solo se admiten el valor de la OP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            Cargarlistaop();
            Cargarlistado5();
            lista1();
            lista2();
            lista3();
            lista4();
            Verresul();
            Verresul2();
            Verresul3();
            Verresul4();
        }
        private void color()
        {

            




            for (int i = 0; i < dataGridView4.Rows.Count; i++)
            {
                int val = Int32.Parse(dataGridView4.Rows[i].Cells[21].Value.ToString());


                if (val == 1)
                {
                    dataGridView4.Rows[i].DefaultCellStyle.BackColor = Color.Orange;
                }



            }

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                int val = Int32.Parse(dataGridView1.Rows[i].Cells[25].Value.ToString());


                if (val == 1)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Orange;
                }



            }

        }
        
        private void colorazul()
        {
            for (int i = 0; i < dataGridView4.Rows.Count; i++)
            {
                int val = Int32.Parse(dataGridView4.Rows[i].Cells[21].Value.ToString());


                if (val == 2)
                {
                    dataGridView4.Rows[i].DefaultCellStyle.BackColor = Color.LimeGreen;
                    dataGridView4.ClearSelection();
                    // Cargarlistafinal();
                }
            }

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                int val = Int32.Parse(dataGridView1.Rows[i].Cells[25].Value.ToString());


                if (val == 2)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.LimeGreen;
                    dataGridView1.ClearSelection();
                    // Cargarlistafinal();
                }
            }

        }
        private void colorazul2()
        {
            for (int i = 0; i < dataGridView4.Rows.Count; i++)
            {
                int val = Int32.Parse(dataGridView4.Rows[i].Cells[21].Value.ToString());


                if (val == 3)
                {
                    dataGridView4.Rows[i].DefaultCellStyle.BackColor = Color.LightSkyBlue;
                    dataGridView4.ClearSelection();
                    // Cargarlistafinal();
                }
            }

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                int val = Int32.Parse(dataGridView1.Rows[i].Cells[25].Value.ToString());


                if (val == 3)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.LightSkyBlue;
                    dataGridView1.ClearSelection();
                    // Cargarlistafinal();
                }
            }

        }
        private void lista1()
        {
            try
            {

                using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["CnnORDEN"].ConnectionString))

                {
                    if (cn.State == ConnectionState.Closed)
                        cn.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter("select * from  operacemple", cn))
                    {
                        //DataTable dt1 = new DataTable("operacemple");

                        da.Fill(dt2);
                        dataGridView1.DataSource = dt2;
                       

                             //DataGridViewColumn column = dataGridView1.Columns[0];
                            // column.Visible = false;
                          
                            dataGridView1.Columns[0].HeaderText = "Id";
                            dataGridView1.Columns[1].HeaderText = "Cedula";
                            dataGridView1.Columns[2].HeaderText = "Nombre Empleado";
                            dataGridView1.Columns[3].HeaderText = "Cargo";
                            dataGridView1.Columns[4].HeaderText = "OP";
                            dataGridView1.Columns[5].HeaderText = "Id Prenda";
                            dataGridView1.Columns[6].HeaderText = "Nombre de Prenda";
                            dataGridView1.Columns[7].HeaderText = "Id Operacion";
                            dataGridView1.Columns[8].HeaderText = "Nombre de Operacion";
                            dataGridView1.Columns[9].HeaderText = "Descripcion";
                            dataGridView1.Columns[10].HeaderText = "Tiempo";
                            dataGridView1.Columns[11].HeaderText = "Cantidad";
                            dataGridView1.Columns[12].HeaderText = "Total";
                            dataGridView1.Columns[13].HeaderText = "Tiempo en Horas";
                            dataGridView1.Columns[14].HeaderText = "Sobremedida";
                            dataGridView1.Columns[15].HeaderText = "XS";
                            dataGridView1.Columns[16].HeaderText = "S";
                            dataGridView1.Columns[17].HeaderText = "M";
                            dataGridView1.Columns[18].HeaderText = "L";
                            dataGridView1.Columns[19].HeaderText = "XL";
                            dataGridView1.Columns[20].HeaderText = "XXL";
                            dataGridView1.Columns[21].HeaderText = "3 XL";
                            dataGridView1.Columns[22].HeaderText = "4 XL";
                            dataGridView1.Columns[23].HeaderText = "5 XL";
                            dataGridView1.Columns[24].HeaderText = "6 XL";
                             dataGridView1.Columns[25].HeaderText = "Estado";
                            dataGridView1.Columns[26].HeaderText = "Fecha de Inicio";
                        dataGridView1.Columns[27].HeaderText = "Fecha de Entrega";


                        color();
                        colorazul();



                    }

                    Verresul();
                    Verresul2();
                    Verresul3();
                    Verresul4();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //lblverno.Text = "Registro no encontrado";
                //MessageBox.Show("Solo se admiten el valor de la OP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
       // DataTable dt1 = new DataTable("opemple");
        private void lista2()
        {
            try
            {

                using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["CnnORDEN"].ConnectionString))

                {
                    if (cn.State == ConnectionState.Closed)
                        cn.Open();
                    using (SqlDataAdapter da2 = new SqlDataAdapter("select * from  opemple", cn))
                    {
                       

                        da2.Fill(dt11);
                        dataGridView4.DataSource = dt11;
                        // DataGridViewColumn column = dataGridView4.Columns[0];
                        // column.Visible = false;
                        dataGridView4.Columns[0].HeaderText = "Id";
                        dataGridView4.Columns[1].HeaderText = "Cedula";
                        dataGridView4.Columns[2].HeaderText = "Nombre Empleado";
                        dataGridView4.Columns[3].HeaderText = "Cargo";
                        dataGridView4.Columns[4].HeaderText = "OP";

                        dataGridView4.Columns[5].HeaderText = "Nombre de Prenda";

                        dataGridView4.Columns[6].HeaderText = "Tiempo";
                        dataGridView4.Columns[7].HeaderText = "Cantidad";
                        dataGridView4.Columns[8].HeaderText = "Total";
                        dataGridView4.Columns[9].HeaderText = "Tiempo en Horas";
                        dataGridView4.Columns[10].HeaderText = "Sobremedida";
                        dataGridView4.Columns[11].HeaderText = "XS";
                        dataGridView4.Columns[12].HeaderText = "S";
                        dataGridView4.Columns[13].HeaderText = "M";
                        dataGridView4.Columns[14].HeaderText = "L";
                        dataGridView4.Columns[15].HeaderText = "XL";
                        dataGridView4.Columns[16].HeaderText = "XXL";
                        dataGridView4.Columns[17].HeaderText = "3 XL";
                        dataGridView4.Columns[18].HeaderText = "4 XL";
                        dataGridView4.Columns[19].HeaderText = "5 XL";
                        dataGridView4.Columns[20].HeaderText = "6 XL";
                        dataGridView4.Columns[21].HeaderText = "Estado";
                        dataGridView4.Columns[22].HeaderText = "Fecha de Inicio";
                        dataGridView4.Columns[23].HeaderText = "Fecha de Entrega";
                        color();
                        colorazul();
                    }

                    Verresul();
                    Verresul2();
                    Verresul3();
                    Verresul4();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //lblverno.Text = "Registro no encontrado";
                //MessageBox.Show("Solo se admiten el valor de la OP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void lista3()
        {
            try
            {

                using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["CnnORDEN"].ConnectionString))

                {
                    if (cn.State == ConnectionState.Closed)
                        cn.Open();
                    using (SqlDataAdapter da2 = new SqlDataAdapter("select * from   opcion", cn))
                    {
                        DataTable dt1 = new DataTable(" opcion");

                        da2.Fill(dt1);
                        dataGridView7.DataSource = dt1;
                       // DataGridViewColumn column = dataGridView7.Columns[0];
                       // column.Visible = false;
                        dataGridView7.Columns[0].HeaderText = "Id";
                        dataGridView7.Columns[1].HeaderText = "Cedula";
                        dataGridView7.Columns[2].HeaderText = "Nombre Empleado";
                        dataGridView7.Columns[3].HeaderText = "Nombre Operacion";
                        dataGridView7.Columns[4].HeaderText = "Categoria";
                        dataGridView7.Columns[5].HeaderText = "Cantidad";
                        dataGridView7.Columns[6].HeaderText = "Fecha ";
                        dataGridView7.Columns[7].HeaderText = "Hora de Inicio";
                        dataGridView7.Columns[8].HeaderText = "Hora De Fin";
                        dataGridView7.Columns[9].HeaderText = "Minutos Total";



                    }

                    Verresul();
                    Verresul2();
                    Verresul3();
                    Verresul4();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //lblverno.Text = "Registro no encontrado";
                //MessageBox.Show("Solo se admiten el valor de la OP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void lista4()
        {
            try
            {

                using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["CnnORDEN"].ConnectionString))

                {
                    if (cn.State == ConnectionState.Closed)
                        cn.Open();
                    using (SqlDataAdapter da2 = new SqlDataAdapter("select * from   tiempoemn", cn))
                    {
                        DataTable dt1 = new DataTable("tiempoemn");

                        da2.Fill(dt1);
                        dataGridView6.DataSource = dt1;

                        DataGridViewColumn column = dataGridView6.Columns[0];
                        column.Visible = false;
                        dataGridView6.Columns[0].HeaderText = "Id";
                        dataGridView6.Columns[1].HeaderText = "Cedula";
                        dataGridView6.Columns[2].HeaderText = "Nombre Empleado";
                        dataGridView6.Columns[3].HeaderText = "Horario";
                        dataGridView6.Columns[4].HeaderText = "Dia";
                        dataGridView6.Columns[5].HeaderText = "Fecha";
                        dataGridView6.Columns[6].HeaderText = "Fecha de Entrada";
                        dataGridView6.Columns[7].HeaderText = "Fecha de Salida";
                        dataGridView6.Columns[8].HeaderText = "Minutos Improductivos";
                        dataGridView6.Columns[9].HeaderText = "Minutos Dia";
                        dataGridView6.Columns[10].HeaderText = "Minutos Total";



                    }

                    Verresul();
                    Verresul2();
                    Verresul3();
                    Verresul4();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //lblverno.Text = "Registro no encontrado";
                //MessageBox.Show("Solo se admiten el valor de la OP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Cargarlistado5();

            switch (Listado1)
            {
                case 0: Cargarlistado5(); break;
            }
        }
        private void relle2()
        {
            try
            {

                DataView dv = dt2.DefaultView;

                dv.RowFilter = string.Format(" nombreple like '%{0}%'", textBox4.Text);
                dataGridView1.DataSource = dv.ToTable();
                color();
                colorazul();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                // MessageBox.Show("Solo se admiten el valor de la OP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // dataGridView3.ClearSelection();
            }
        }
        private void relle1()
        {
            try
            {

                DataView dv = dt11.DefaultView;

                dv.RowFilter = string.Format(" nombreple like '%{0}%'", textBox4.Text);
                dataGridView4.DataSource = dv.ToTable();
                color();
                colorazul();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                // MessageBox.Show("Solo se admiten el valor de la OP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // dataGridView3.ClearSelection();
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {


                if (e.KeyChar == (char)13)
                {
                    {
                        e.Handled = true;
                    }




                    DataView dv = dt.DefaultView;

                    dv.RowFilter = string.Format(" nombre like '%{0}%'", textBox4.Text);
                    // dv.RowFilter = string.Format(" cargo like '%{0}%'", textBox4.Text);
                    dataGridView9.DataSource = dv.ToTable();

                    relle1();
                    relle2();

                    buscarop1cedu4();
                    buscarop1cedu3();
                    buscarop1cedu2();
                    Busquedaopemple2();
                    Busquedaemplcedula();
                    buscarop1cedu();
                    Verresul();
                    Verresul();
                    Verresul2();
                    Verresul3();
                    Verresul4();

                    timer1.Stop();

                }
                else
                {
                    //rlista1();
                   // lista2();
                    lista3();
                    lista4();
                    // label2.Text = "";
                    //lista1();
                    Cargarlistaop();


                    Cargarlistado5();
                    //timer4.Start();
                    dataGridView3.Rows[0].Selected = true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                // MessageBox.Show("Solo se admiten el valor de la OP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // dataGridView3.ClearSelection();
            }
        }
        private void Verresul()
        {
            int baser = 0;
            int baser1 = 0;
            int resultado = 0;

            double total = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                total += Convert.ToDouble(row.Cells[10].Value) * Convert.ToDouble(row.Cells[11].Value);
                row.Cells[dataGridView1.Columns[12].Index].Value = (Convert.ToDecimal(row.Cells[dataGridView1.Columns[10].Index].Value) * Convert.ToDecimal(row.Cells[dataGridView1.Columns[11].Index].Value));
            }
            textBox8.Text = total.ToString("00.00");
            textBox9.Text = dataGridView1.RowCount.ToString();
            //   Convert.ToString(ded.ToString("00.0"));
            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[11].Value);
            }
            textBox7.Text = sum.ToString();
            color();
            colorazul();
            colorazul2();
            // baser = Convert.ToInt32(textBox9.Text);
            // baser1 = Convert.ToInt32(textBox5.Text);
            // resultado = baser + baser1;
            //txtiddope.Text = Convert.ToString(resultado);

        }
        private void Verresul2()
        {
            int baser = 0;
            int baser1 = 0;
            int resultado = 0;

            double total = 0;
            foreach (DataGridViewRow row in dataGridView4.Rows)
            {

                total += Convert.ToDouble(row.Cells[6].Value) * Convert.ToDouble(row.Cells[7].Value);
                row.Cells[dataGridView4.Columns[8].Index].Value = (Convert.ToDecimal(row.Cells[dataGridView4.Columns[6].Index].Value) * Convert.ToDecimal(row.Cells[dataGridView4.Columns[7].Index].Value));
            }
            textBox3.Text = total.ToString("00.00");
            textBox1.Text = dataGridView4.RowCount.ToString();
            //   Convert.ToString(ded.ToString("00.0"));
            int sum = 0;
            for (int i = 0; i < dataGridView4.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView4.Rows[i].Cells[7].Value);
            }
            textBox2.Text = sum.ToString();
            // baser = Convert.ToInt32(textBox9.Text);
            // baser1 = Convert.ToInt32(textBox5.Text);
            // resultado = baser + baser1;
            //txtiddope.Text = Convert.ToString(resultado);

        }
        private void Verresul3()
        {
            int baser = 0;
            int baser1 = 0;
            int resultado = 0;

            double total = 0;
            foreach (DataGridViewRow row in dataGridView7.Rows)
            {

                total += Convert.ToDouble(row.Cells[5].Value);
                row.Cells[dataGridView7.Columns[9].Index].Value = (Convert.ToDecimal(row.Cells[dataGridView7.Columns[9].Index].Value));
            }
            textBox11.Text = total.ToString();
            textBox5.Text = dataGridView7.RowCount.ToString();
            //   Convert.ToString(ded.ToString("00.0"));
            int sum = 0;
            for (int i = 0; i < dataGridView7.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView7.Rows[i].Cells[9].Value);
            }
            textBox6.Text = sum.ToString("00.00");
            // baser = Convert.ToInt32(textBox9.Text);
            // baser1 = Convert.ToInt32(textBox5.Text);
            // resultado = baser + baser1;
            //txtiddope.Text = Convert.ToString(resultado);

        }
        private void Verresul4()
        {
            int baser = 0;
            int baser1 = 0;
            int resultado = 0;

            double total = 0;
            foreach (DataGridViewRow row in dataGridView6.Rows)
            {

                total += Convert.ToDouble(row.Cells[9].Value);
                row.Cells[dataGridView6.Columns[10].Index].Value = (Convert.ToDecimal(row.Cells[dataGridView6.Columns[10].Index].Value));
            }
            textBox15.Text = total.ToString("00.00");
            textBox13.Text = dataGridView6.RowCount.ToString();
            //   Convert.ToString(ded.ToString("00.0"));
            int sum = 0;
            for (int i = 0; i < dataGridView6.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView6.Rows[i].Cells[10].Value);
            }
            //baser = Convert.ToInt32(textBox9.Text);
            //baser1 = Convert.ToInt32(textBox5.Text);
            //resultado = baser + baser1;
            // txtiddope.Text = Convert.ToString(resultado);
            textBox14.Text = sum.ToString("00.00");
            // textBox7.Text = sum.ToString();
        }
        private void textBox4_KeyUp(object sender, KeyEventArgs e)
        {

            try
            {
                

                DataView dv = dt.DefaultView;

                dv.RowFilter = string.Format(" nombre like '%{0}%'", textBox4.Text);
                dataGridView9.DataSource = dv.ToTable();

                relle1();
                relle2();
                Verresul();
                Verresul();
                Verresul2();
                Verresul3();
                Verresul4();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                // MessageBox.Show("Solo se admiten el valor de la OP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // dataGridView3.ClearSelection();
            }
        }

        private void dataGridView9_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox4.Text = dataGridView9.CurrentCell.Value.ToString();
            textBox4.Focus();

        }

        private void textBox4_MouseClick(object sender, MouseEventArgs e)
        {
            //  textBox4.Select(Length);
            // textBox4.Select(textBox4.Text.Length - 1, textBox4.Text.Length - 1);
            //textBox4.SelectionStart = textBox4.Text.Length;
            if (!String.IsNullOrEmpty(textBox4.Text))
            {
                textBox4.SelectionStart = 0;
                textBox4.SelectionLength = textBox4.Text.Length;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            buscar3();
            buscar2();
            //buscarop2();
            // buscarop1cedu2()
            buscar();
            buscar4();

        }

        private void btncopiar_Click(object sender, EventArgs e)
        {
          
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        private void Busquedaop2()
        {
            Busempleado fe = new Busempleado();

            try
            {
                


                DataTable dt = new DataTable();
                DataRow row;

                E.IdInicio = Convert.ToInt32(textBox17.Text);
                dt = E.Buscaroperaemple(E.IdInicio);

                if (dt.Rows.Count == 1)
                {
                    row = dt.Rows[0];
                    fe.textBox51.Text = row[0].ToString();
                    fe.txtcedula.Text = row[1].ToString();
                    fe.txtnombre.Text = row[2].ToString();
                    fe.txtcaaarg.Text = row[3].ToString();
                    fe.txtop.Text = row[4].ToString();
                    fe.txtidperac.Text = row[5].ToString();

                    fe.txtnombrpren.Text = row[6].ToString();
                    fe.txtnomoperaci.Text = row[8].ToString();
                    fe.rtxtdescr.Text = row[9].ToString();
                    fe.txttiempo.Text = row[10].ToString();
                    fe.txtcantidad.Text = row[11].ToString();
                   
                    fe.txttotal.Text = row[12].ToString();
                    fe.txthoras.Text = row[13].ToString();


                    fe.txtsobre.Text = row[14].ToString();
                    fe.txtxs.Text = row[15].ToString();
                    fe.txts.Text = row[16].ToString();
                    fe.txtm.Text = row[17].ToString();
                    fe.txtl.Text = row[18].ToString();
                    fe.txtxl.Text = row[19].ToString();
                    fe.txtxxl.Text = row[20].ToString();
                    fe.txt3xl.Text = row[21].ToString();
                    fe.txt4xl.Text = row[22].ToString();
                    fe.txt5xl.Text = row[23].ToString();
                    fe.txt6xl.Text = row[24].ToString();
                    fe.txtestado.Text = row[25].ToString();

                    // Verresul();
                    fe.ShowDialog();
                }


                else
                {
                    //lblverno.Text = Convert.ToString("¡Registro de ID no existe!");
                    // MessageBox.Show("Registro de Orden de Produccion no Existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Solo se admiten el valor de la OP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

           // dataGridView1.ClearSelection();

            //Verresul();

        }
        private void Busquedaop3()
        {
            Busempleado fe = new Busempleado();

            try
            {


                textBox12.Text = dataGridView4.CurrentCell.Value.ToString();
                DataTable dt = new DataTable();
                DataRow row;

                O.IdInicio = Convert.ToInt32(textBox12.Text);
                dt = O.Buscareopyid(O.IdInicio);

                if (dt.Rows.Count == 1)
                {
                    row = dt.Rows[0];
                    fe.textBox51.Text = row[0].ToString();
                    fe.txtcedula.Text = row[1].ToString();
                    fe.txtnombre.Text = row[2].ToString();
                    fe.txtcaaarg.Text = row[3].ToString();
                    fe.txtop.Text = row[4].ToString();
                    fe.txtnombrpren.Text = row[5].ToString();
                    fe.txtnomoperaci.Text = row[8].ToString();
                    fe.txttiempo.Text = row[6].ToString();
                    fe.txtcantidad.Text = row[7].ToString();

                    fe.txttotal.Text = row[8].ToString();
                    fe.txthoras.Text =row[9].ToString();


                    fe.txtsobre.Text = row[10].ToString();
                    fe.txtxs.Text = row[11].ToString();
                    fe.txts.Text = row[12].ToString();
                    fe.txtm.Text = row[13].ToString();
                    fe.txtl.Text = row[14].ToString();
                    fe.txtxl.Text = row[15].ToString();
                    fe.txtxxl.Text = row[16].ToString();
                    fe.txt3xl.Text = row[17].ToString();
                    fe.txt4xl.Text = row[18].ToString();
                    fe.txt5xl.Text = row[19].ToString();
                    fe.txt6xl.Text = row[20].ToString();
                    fe.txtestado.Text = row[21].ToString();

                    // Verresul();
                    fe.ShowDialog();
                }


                else
                {
                    //lblverno.Text = Convert.ToString("¡Registro de ID no existe!");
                    // MessageBox.Show("Registro de Orden de Produccion no Existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Solo se admiten el valor de la OP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // dataGridView1.ClearSelection();

            //Verresul();

        }
        private void Busquedaop4()
        {
            Busempleado fe = new Busempleado();

            try
            {


                textBox12.Text = dataGridView4.CurrentCell.Value.ToString();
                DataTable dt = new DataTable();
                DataRow row;

                Op.Id = Convert.ToInt32(textBox16.Text);
                dt = Op.Buscaid(Op.Id);

                if (dt.Rows.Count == 1)
                {
                    row = dt.Rows[0];
                    fe.textBox51.Text = row[0].ToString();
                    fe.txtcedula.Text = row[1].ToString();
                    fe.txtnombre.Text = row[2].ToString();
                   // fe.txtcaaarg.Text = row[3].ToString();
                  //  fe.txtop.Text = row[4].ToString();
                    fe.txtnombrpren.Text = row[3].ToString();
                   // fe.txtnomoperaci.Text = row[8].ToString();
                    //fe.txttiempo.Text = row[6].ToString();
                    fe.txtcantidad.Text = row[5].ToString();

                    fe.txttotal.Text = row[9].ToString();


                    fe.datet3.Text = row[7].ToString();
                    fe.datet2.Text = row[8].ToString();
                    //  fe.txts.Text = row[12].ToString();
                    // fe.txtm.Text = row[13].ToString();
                    // fe.txtl.Text = row[14].ToString();
                    // fe.txtxl.Text = row[15].ToString();
                    // fe.txtxxl.Text = row[16].ToString();
                    //  fe.txt3xl.Text = row[17].ToString();
                    //  fe.txt4xl.Text = row[18].ToString();
                    // fe.txt5xl.Text = row[19].ToString();
                    // fe.txt6xl.Text = row[20].ToString();
                    //  fe.txtestado.Text = row[21].ToString();

                    // Verresul();
                    fe.ShowDialog();
                }


                else
                {
                    //lblverno.Text = Convert.ToString("¡Registro de ID no existe!");
                    // MessageBox.Show("Registro de Orden de Produccion no Existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Solo se admiten el valor de la OP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // dataGridView1.ClearSelection();

            //Verresul();

        }
        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox10.Text = dataGridView1.CurrentCell.Value.ToString();
            Busquedaop2();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox10.Text = dataGridView1.CurrentCell.Value.ToString();
            Busquedaop2();
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox12.Text = dataGridView4.CurrentCell.Value.ToString();
            //Busquedaop3();
        }

        private void dataGridView4_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox12.Text = dataGridView4.CurrentCell.Value.ToString();
            Busquedaop3();
        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox12.Text = dataGridView4.CurrentCell.Value.ToString();
            //Busquedaop3();
        }

        private void dataGridView4_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Busquedaop3();
        }

        private void dataGridView7_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox16.Text = dataGridView7.CurrentCell.Value.ToString();
            Busquedaop4();
        }

        private void dataGridView7_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox16.Text = dataGridView7.CurrentCell.Value.ToString();
            Busquedaop4();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox4.Text != string.Empty)
                {
                    button1.Enabled = true;
                }
                else
                {
                    button1.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);
                //MessageBox.Show("Solo se admiten el valor de la OP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // label2.Text = "REGISTRO NO ENCONTRADO";
            }
        }
        private void actualiza1()
        {
            try
            {
                E.IdInicio = Convert.ToInt32(textBox17.Text);

                E.Estado = Convert.ToInt32(textBox18.Text);
                E.Fechafin = dateT1.Value;

                MessageBox.Show(E.Actualiza1(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Busquedaop2();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int a = 0;
                textBox17.Text = dataGridView1.CurrentCell.Value.ToString();
                a = Convert.ToInt32(textBox17.Text);
                try
                {
                    //  re.Op = Convert.ToInt32(txtseletop.Text);
                    if (MessageBox.Show("      Por favor selecionar unicamente el numero de registro para su modificacion.                            " +

                         "¿ Desea cancelar este producto con numero de registro" + a + " ?", "PRODUCTO CANCELADO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {

                        actualiza1();
                       // dataGridView6.ClearSelection();

                    }
                    //  MessageBox.Show(re.Eliminarop1(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Limpiar();
                   // Cargarlistado5();
                    // Cargarlistado7();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }

}
