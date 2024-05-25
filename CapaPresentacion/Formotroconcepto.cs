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
using System.Data.SqlClient;
using System.Configuration;


namespace WindowsFormsApp1
{
    public partial class Formotroconcepto : Form
    {
        int Listado = 0;
        int Listado1 = 0;

        Clsopcion O = new Clsopcion();
        ClsReglasEmpleados Reglas = new ClsReglasEmpleados();
        ClsTBL_EMPLEADOS TblAtri = new ClsTBL_EMPLEADOS();


        public Formotroconcepto()
        {
            InitializeComponent();
        }
        private void Cargarlistado1()

        {

            DataTable dt = new DataTable();
            dt = O.Listado1();
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
                   // dataGridView3.Rows[i].Cells[10].Value = dt.Rows[i][10].ToString();

                    //Verresul();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataGridView3.ClearSelection();
            Verresul();

        }
        private void label69_Click(object sender, EventArgs e)
        {

        }
        private void Busquedaempleado2()
        {

            try
            {
                DataTable dt = new DataTable();
                DataRow row;
                TblAtri.Cedula = Convert.ToInt32(textcedula.Text);
                dt = Reglas.BuscarEmpleados(TblAtri.Cedula.ToString());
                if (dt.Rows.Count == 1)
                {

                    row = dt.Rows[0];
                    textcedula.Text = row[0].ToString();
                    textnombre.Text = row[1].ToString();
                    label58.Text = row[1].ToString();
                    txtcargo.Text = row[2].ToString();
                    txtcategoria.Text = row[3].ToString();


                    // MessageBox.Show("Registro Encontrado Ok...!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    groupBox1.Enabled = true;
                    button25.Enabled = true;
                    button2.Enabled = true;
                   // button4.Enabled = true;
                }
                else
                {
                    label66.Text = "Registro no encontrado";

                    // MessageBox.Show("Registro de Empleado no Existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    //Limpiarempleados();
                    dataGridView7.Enabled = false;
                    btnbuscar.Enabled = false;
                    textcedula.Enabled = false;
                    btnttemm.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Busquedaempleado()
        {

            DataTable dt = new DataTable();

            try
            {

                TblAtri.Cedula = Convert.ToInt32(textcedula.Text);
                dt = Reglas.BuscarEmpleados(TblAtri.Cedula.ToString());
                dataGridView7.Rows.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dataGridView7.Rows.Add(dt.Rows[i][0]);
                    dataGridView7.Rows[i].Cells[0].Value = dt.Rows[i][0].ToString();
                    dataGridView7.Rows[i].Cells[1].Value = dt.Rows[i][1].ToString();
                    dataGridView7.Rows[i].Cells[2].Value = dt.Rows[i][2].ToString();
                    dataGridView7.Rows[i].Cells[3].Value = dt.Rows[i][3].ToString();

                }
            }
            catch (Exception ex)
            {


                label66.Text = "Registro no Encontrado";
                textcedula.Enabled = false;
                btnttemm.Focus();

                // MessageBox.Show(ex.Message);
            }
            dataGridView7.ClearSelection();


        }
        private void Busquedacedul()
        {
            DataTable dt = new DataTable();

            try
            {
                O.Cedula = Convert.ToInt32(textBox11.Text);
                dt = O.Buscacedu(O.Cedula);
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
                   

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Solo se admiten el valor de la OP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                label3.Text = "Registro no encontrado";
            }
            label3.Text = "Registro no encontrado";
            dataGridView3.ClearSelection();
            // Verresul2();

        }
        private void Listarempleado()
        {

            DataTable dt = new DataTable();
            dt = Reglas.ListadoEmpleados();
            try
            {
                dataGridView7.Rows.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dataGridView7.Rows.Add(dt.Rows[i][0]);
                    dataGridView7.Rows[i].Cells[0].Value = dt.Rows[i][0].ToString();
                    dataGridView7.Rows[i].Cells[1].Value = dt.Rows[i][1].ToString();
                    dataGridView7.Rows[i].Cells[2].Value = dt.Rows[i][2].ToString();
                    dataGridView7.Rows[i].Cells[3].Value = dt.Rows[i][3].ToString();

                    //Verresul();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            dataGridView7.ClearSelection();
        }
        private void Limpiarempleados()
        {
            label66.Text = "";
            label58.Text = "";
            textcedula.Text = "";
            textnombre.Text = "";
            label58.Text = "";
            txtcargo.Text = "";
            txtcategoria.Text = "";
            //label58.Focus();
        }
        private void btnbuscar_Click(object sender, EventArgs e)
        {
            Busquedaempleado2();
            Busquedaempleado();
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (Listado)
            {
                case 0: Listarempleado(); break;
            }
        }

        private void btnttemm_Click(object sender, EventArgs e)
        {

            Limpiarempleados();
            Listarempleado();
            dataGridView7.Enabled = true;
            textcedula.Enabled = true;
        }

        private void textcedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Busquedaempleado();
                timer1.Stop();
            }
            else
            {

                // Listarempleado();
                timer1.Start();
                textnombre.Text = "";
                label58.Text = "";
                txtcargo.Text = "";
                txtcategoria.Text = "";
            }
        }
        private void Validar()
        {
            if (textcedula.Text != string.Empty)
            {
                btnbuscar.Enabled = true;
            }
            else
            {
                btnbuscar.Enabled = false;
                btnttemm.Enabled = true;
            }
        }
        private void textcedula_TextChanged(object sender, EventArgs e)
        {

            Validar();
        }

        private void dataGridView7_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            textcedula.Text = dataGridView7.CurrentCell.Value.ToString();
            Busquedaempleado2();
            Busquedaempleado();

            timer1.Stop();

            if (dataGridView7.Rows.Count > 0)
            {
                dataGridView7.Rows[dataGridView7.CurrentRow.Index].Selected = true;
                timer1.Stop();
            }
        }

        private void dataGridView7_Click(object sender, EventArgs e)
        {

            if (dataGridView7.Rows.Count > 0)
            {
                dataGridView7.Rows[dataGridView7.CurrentRow.Index].Selected = true;

                timer1.Stop();
            }
        }

        private void dataGridView7_MouseMove(object sender, MouseEventArgs e)
        {
            timer1.Stop();
        }
        DataTable dt = new DataTable("opcion");

        private void Formotroconcepto_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["CnnORDEN"].ConnectionString))
                {
                    if (cn.State == ConnectionState.Closed)
                        cn.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter("select * from opcion", cn))
                    {
                        // DataTable dt = new DataTable("operacemple");

                        da.Fill(dt);
                        dataGridView6.DataSource = dt;
                        DataGridViewColumn column = dataGridView6.Columns[0];
                        column.Visible = false;
                        dataGridView6.Columns[0].HeaderText = "Id";
                        dataGridView6.Columns[1].HeaderText = "Cedula";
                        dataGridView6.Columns[2].HeaderText = "Nombre Empleado";
                        dataGridView6.Columns[3].HeaderText = "Nombre Operacion";
                        dataGridView6.Columns[4].HeaderText = "Categoria";
                        dataGridView6.Columns[5].HeaderText = "Cantidad";
                        dataGridView6.Columns[6].HeaderText = "Fecha ";
                        dataGridView6.Columns[7].HeaderText = "Hora de Inicio";
                        dataGridView6.Columns[8].HeaderText = "Hora De Fin";
                        dataGridView6.Columns[9].HeaderText = "Minutos Total";
                      

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //lblverno.Text = "Registro no encontrado";
                //MessageBox.Show("Solo se admiten el valor de la OP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            groupBox1.Enabled = false;
            button25.Enabled = false;
            button2.Enabled = false;
            //button4.Enabled = false;
            Verresul();
            Cargarlistado1();
            Listarempleado();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TimeSpan difFechas = dateTimePicker3.Value - datehorluneentra.Value;
            Double minutos = difFechas.TotalMinutes;


            textBox3.Text = Convert.ToString(minutos);
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                O.Id = Convert.ToInt32(textBox11.Text);
                O.Cedula = Convert.ToInt32(textcedula.Text);
                O.Nombre = textnombre.Text;
                O.Nombreopera = textBox1.Text;
                O.Categoria = comboBox1.SelectedItem.ToString();
                O.Cantidad = Convert.ToInt32(textBox2.Text);
                O.Fecha = datelune.Value;
                O.Fechaini = datehorluneentra.Value;
                O.Fechafin = dateTimePicker3.Value;

               
                O.Minutotal = Convert.ToDecimal(textBox3.Text);



                MessageBox.Show(O.Registrarope(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Verresul();
                Cargarlistado1();



            }
            catch (Exception ex)
            {
                //MessageBox.Show("Campos Vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                MessageBox.Show(ex.Message);
            }
        }
        private void Verresul()
        {
            int baser = 0;
            int baser1 = 0;
            int resultado = 0;

            double total = 0;
            foreach (DataGridViewRow row in dataGridView3.Rows)
            {

                total += Convert.ToDouble(row.Cells["dataGridViewTextBoxColumn9"].Value);
                row.Cells[dataGridView3.Columns["dataGridViewTextBoxColumn36"].Index].Value = (Convert.ToDecimal(row.Cells[dataGridView3.Columns["dataGridViewTextBoxColumn36"].Index].Value));
            }
            textBox8.Text = total.ToString();
            textBox9.Text = dataGridView3.RowCount.ToString();
            //   Convert.ToString(ded.ToString("00.0"));
            int sum = 0;
            for (int i = 0; i < dataGridView3.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView3.Rows[i].Cells[9].Value);
            }
            baser = Convert.ToInt32(textBox9.Text);
            baser1 = Convert.ToInt32(textBox5.Text);
            resultado = baser + baser1;
            textBox11.Text = Convert.ToString(resultado);
            textBox7.Text = sum.ToString("N");
            // textBox7.Text = sum.ToString();
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {

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

                   

                    dv.RowFilter = string.Format(" nombre like '%{0}%'", textBox52.Text);
                    // dv.RowFilter = string.Format(" cargo like '%{0}%'", textBox4.Text);

                    dataGridView6.DataSource = dv.ToTable();
                    timer4.Stop();

                }
                else
                {
                    label3.Text = "";
                    Cargarlistado1();
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

        private void textBox4_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {

                DataView dv = dt.DefaultView;



                dv.RowFilter = string.Format(" nombre like '%{0}%'", textBox52.Text);
                dataGridView6.DataSource = dv.ToTable();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                // MessageBox.Show("Solo se admiten el valor de la OP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // dataGridView3.ClearSelection();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            //Cargarlistado5();

            switch (Listado1)
            {
                case 0: Cargarlistado1(); break;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                Busquedacedul();
                timer4.Stop();
                dataGridView3.ClearSelection();
                dataGridView3.Focus();

            }
            catch (Exception ex)
            {
                label3.Text = "Registro no encontrado";
                // MessageBox.Show("Registro de Orden de Produccion no Existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dataGridView3.ClearSelection();
            dataGridView3.Focus();
        }

        private void label73_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                O.Id = Convert.ToInt32(textBox11.Text);
                O.Cedula = Convert.ToInt32(textcedula.Text);
                O.Nombre = textnombre.Text;
                O.Nombreopera = textBox1.Text;
                O.Categoria = comboBox1.SelectedItem.ToString();
                O.Cantidad = Convert.ToInt32(textBox2.Text);
                O.Fecha = datelune.Value;
                O.Fechaini = datehorluneentra.Value;
                O.Fechafin = dateTimePicker3.Value;


                O.Minutotal = Convert.ToDecimal(textBox3.Text);



                MessageBox.Show(O.Registrarope(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Verresul();
                Cargarlistado1();



            }
            catch (Exception ex)
            {
                //MessageBox.Show("Campos Vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                MessageBox.Show(ex.Message);
            }
        }
    }
}
