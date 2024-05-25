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
using System.Globalization;

namespace WindowsFormsApp1
{
    public partial class Formhorario : Form
    {
        int Listado = 0;
        int Listado1 = 0;

        clshorario O = new clshorario();

        ClsReglasEmpleados Reglas = new ClsReglasEmpleados();
        ClsTBL_EMPLEADOS TblAtri = new ClsTBL_EMPLEADOS();
        clsOp vo = new clsOp();
        public Formhorario()
        {
            InitializeComponent();
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
        private void Cargarlistado5()

        {

            DataTable dt = new DataTable();
            dt = O.Listadohorario();
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
        private void Busquedahorario()
        {
            DataTable dt = new DataTable();

            try
            {
                O.Cedulaem = Convert.ToInt32(textBox4.Text);
                dt = O.Buscarhorariocedu(O.Cedulaem);
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
        private void Verresul()
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
            textBox8.Text = total.ToString("N");
            textBox9.Text = dataGridView6.RowCount.ToString();
            //   Convert.ToString(ded.ToString("00.0"));
            int sum = 0;
            for (int i = 0; i < dataGridView6.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView6.Rows[i].Cells[10].Value);
            }
           // baser = Convert.ToInt32(textBox9.Text);
            //baser1 = Convert.ToInt32(textBox5.Text);
           // resultado = baser + baser1;
           // txtiddope.Text = Convert.ToString(resultado);
            textBox7.Text = sum.ToString("N");
           // textBox7.Text = sum.ToString();
        }

        private void dateTimePicker8_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker15_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        DataTable dt = new DataTable("tiempoemn");
        private void Formhorario_Load(object sender, EventArgs e)
        {
           
            validar3();
            listahorario();
            tabControl1.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button23.Enabled = false;
            button25.Enabled = false;
            //button4.Enabled = false;
            Verresul();
          
            Listarempleado();
            Cargarlistadohora();

        }
        private void listahorario()
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["CnnORDEN"].ConnectionString))
                {
                    if (cn.State == ConnectionState.Closed)
                        cn.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter("select * from tiempoemn", cn))
                    {
                        // DataTable dt = new DataTable("operacemple");

                        da.Fill(dt);
                        dataGridView6.DataSource = dt;
                        DataGridViewColumn column = dataGridView6.Columns[0];
                        //column.Visible = false;
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
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //lblverno.Text = "Registro no encontrado";
                //MessageBox.Show("Solo se admiten el valor de la OP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Cargarlistadohora()

        {
            try
            {


                using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["CnnORDEN"].ConnectionString))
                {
                    if (cn.State == ConnectionState.Closed)
                        cn.Open();

                    using (SqlDataAdapter da = new SqlDataAdapter("select * from tiempoemn", cn))
                    {
                        DataTable dt1 = new DataTable("tiempoemn");



                        da.Fill(dt1);

                        dataGridView6.DataSource = dt1;

                        Verresul();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataGridView6.ClearSelection();
            //Verresul();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               
                O.Cedulaem = Convert.ToInt32(textcedula.Text);
                O.Nombre = textnombre.Text;
                O.Horario = comboBox1.SelectedItem.ToString();
                O.Dia = comboBox2.SelectedItem.ToString();
                O.Fecha = datelune.Value;
                O.Id = Convert.ToInt32(txtiddope.Text);
               





                O.Horaentrada = datehorluneentra.Value;
                O.Horasalida = dateTimePicker3.Value;
                O.Improd = Convert.ToDecimal(textBox1.Text);
                O.Mdia = Convert.ToDecimal(textnumdilun.Text);
                O.Totalminutos = Convert.ToDecimal(textBox3.Text);
               
                O.Estado = Convert.ToInt32(textBox11.Text);



                MessageBox.Show(O.Registrarhorario(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Verresul();
               Cargarlistadohora();



            }
            catch (Exception ex)
            {
                 MessageBox.Show("Campos Vacíos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

               // MessageBox.Show(ex.Message);
            }
        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {


        }

        private void button4_Click_1(object sender, EventArgs e)
        {
        }

        private void textnumdilun_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int r = 0;
            int m = 0;
           // int mm = 2;





            if (dateentrsalida.Value >= dateTimePicker3.Value)
            {
                textBox1.Text = "20";

                //minutos = 248879.75
                TimeSpan difFechas = dateTimePicker3.Value - datehorluneentra.Value;
                Double minutos = difFechas.TotalMinutes;


                textnumdilun.Text = Convert.ToString(minutos);
                r = Convert.ToInt32(textBox1.Text);
                textBox2.Text = Convert.ToString(r * 2);
                m = Convert.ToInt32(textBox2.Text);
                textBox3.Text = Convert.ToString(minutos - m);

                if (dateTimePicker3.Value <= dateTimePicker1.Value)
                {
                    //textBox3.Text = Convert.ToString(minutos+minutos);
                    
                    textBox1.Text = "10";
                   
                }

            }
           
            if (dateentrsalida.Value < dateTimePicker3.Value)
            {
                textBox1.Text = "30";





                //minutos = 248879.75
                TimeSpan difFechas = dateTimePicker3.Value - datehorluneentra.Value;
                Double minutos = difFechas.TotalMinutes;


                textnumdilun.Text = Convert.ToString(minutos);
                r = Convert.ToInt32(textBox1.Text);
                textBox2.Text = Convert.ToString(r * 2);
                m = Convert.ToInt32(textBox2.Text);
                textBox3.Text = Convert.ToString(minutos - m);
            }
                

          if (dateTimePicker3.Value <= dateTimePicker1.Value)
                {
                TimeSpan difFechas = dateTimePicker3.Value - datehorluneentra.Value;
                Double minutos = difFechas.TotalMinutes;


                textnumdilun.Text = Convert.ToString(minutos);
                r = Convert.ToInt32(textBox1.Text);
                textBox2.Text = Convert.ToString(r * 2);
                m = Convert.ToInt32(textBox2.Text);
                textBox3.Text = Convert.ToString(minutos - m);
            }



        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
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
                    label66.Text = "";
                    row = dt.Rows[0];
                    textcedula.Text = row[0].ToString();
                    textnombre.Text = row[1].ToString();
                    label58.Text = row[1].ToString();
                    txtcargo.Text = row[2].ToString();
                    txtcategoria.Text = row[3].ToString();


                    // MessageBox.Show("Registro Encontrado Ok...!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tabControl1.Enabled = true;
                   // button1.Enabled = true;
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
                label66.Text = "Registro no encontrado";
               // MessageBox.Show(ex.Message);
            }
        }
        private void Busquedaempleado()
        {

            DataTable dt = new DataTable();

            try
            {

                TblAtri.Cedula = Convert.ToInt32(textcedula.Text);
                dt = Reglas.BuscarEmpleados(TblAtri.Cedula.ToString());
                label66.Text = "";
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

        private void dataGridView7_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 13)
            {
                if (dataGridView7.SelectedRows.Count > 0)
                    dataGridView7.ClearSelection();

            }
        }

        private void dataGridView7_MouseMove(object sender, MouseEventArgs e)
        {

            timer1.Stop();
        }

        private void textcedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
               // Busquedaempleado();
                timer1.Stop();
            }
            else
            {

                // Listarempleado();
               // timer1.Start();
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

        private void textBox4_KeyUp(object sender, KeyEventArgs e)
        {
          
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == 13)
            {

                button25.Focus();


            }
            else
            {

            }

        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            //Cargarlistado5();

            switch (Listado1)
            {
                case 0: Cargarlistado5(); break;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                Busquedahorario();
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

        private void textBox4_MouseLeave(object sender, EventArgs e)
        {
            label3.Text = "";
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox11_Enter(object sender, EventArgs e)
        {

        }

        private void txtiddope_Validating(object sender, CancelEventArgs e)
        {
            if (txtiddope.Text.Trim() == String.Empty)
            {
                errorProvider12.SetError(txtiddope, "Ingrese minimo 3 caracteres ");
                button1.Enabled = false;

            }
            else
            {
                // button3.Enabled = true;

                errorProvider12.Clear();
            }
        }

        private void txtiddope_TextChanged(object sender, EventArgs e)
        {
            validar3();
            
        }
        private void validar3()
        {
            int o, i;


            label92.Text = (txtiddope.Text.Length.ToString());
            o = Convert.ToInt32(label92.Text);


            label40.Text = (txtiddope.Text.Length.ToString());
            i = Convert.ToInt32(label40.Text);
            if (

           textBox1.Text != string.Empty &
           textnumdilun.Text != string.Empty &
           textBox3.Text != string.Empty &
           //rtxtdescr.Text != string.Empty &

                o >= 3 & i >= 3
           )

            // textBox51.Text != string.Empty)
            {
               // button7.Enabled = true;
                button1.Enabled = true;
            }
            else
            {
               // button7.Enabled = false;
                button1.Enabled = false;
                //button.Enabled = false;
            }

        }

        private void txtiddope_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == 13)
            {

                button1.Focus();


            }
            else
            {

            }
        }

        private void textBox52_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {



                DataView dv = dt.DefaultView;
                dv.RowFilter = string.Format(" nombre like '%{0}%'", textBox52.Text);


                dataGridView6.DataSource = dv.ToTable();
               
                Verresul();
               
             


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                // MessageBox.Show("Solo se admiten el valor de la OP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // dataGridView3.ClearSelection();
            }
        }

        private void dataGridView6_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox4.Text = dataGridView6.CurrentCell.Value.ToString();

        }

        private void dataGridView6_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {


                try
                {
                    int a = 0;
                    textBox4.Text = dataGridView6.CurrentCell.Value.ToString();
                    a = Convert.ToInt32(textBox4.Text);



                    O.Id = Convert.ToInt32(textBox4.Text);
                    //  re.Op = Convert.ToInt32(txtseletop.Text);
                    if (MessageBox.Show(" ¿ Está seguro que desea eliminar el registro " + a + " ?", "ELIMINAR REGISTRO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)

                    {

                        MessageBox.Show(O.Eliminarhorario(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Cargarlistadohora();// dataGridView6.ClearSelection();
                        textBox4.Clear();

                    }
                    //  MessageBox.Show(re.Eliminarop1(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Limpiar();
                    // Cargarlistado5();
                    // Cargarlistado7();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("  Unicamente seleccionar el número de id  ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    //MessageBox.Show(ex.Message);
                }
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            try
            {
                O.Cedulaem = Convert.ToInt32(textBox4.Text);
                //  re.Op = Convert.ToInt32(txtseletop.Text);
                if (MessageBox.Show("¿ Está seguro que desea eliminar todos los registros con este número de cédula ?", "ELIMINAR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    MessageBox.Show(O.Eliminarhorariocedu(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Cargarlistadohora();
                    textBox4.Clear();
                    Verresul();
                   // Cargarlistadohora();
                    // dataGridView6.ClearSelection();

                }
                //  MessageBox.Show(re.Eliminarop1(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Limpiar();
                // Cargarlistado5();
                // Cargarlistado7();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sólo introducir números en este campo ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //MessageBox.Show(ex.Message);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            dataGridView6.ClearSelection();
            {
                button23.Enabled = false;
            }
            if (dataGridView6.Rows.Count > 0)
            {
                button23.Enabled = true;
            }
            elimin3();
        }
        private void elimin3()
        {
            if (textBox4.Text != string.Empty)
            {
                button25.Enabled = true;
            }
            else
            {
                button25.Enabled = false;
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            try
            {

                //  re.Op = Convert.ToInt32(txtseletop.Text);
                if (MessageBox.Show("¿ Está seguro que desea eliminar todos los registros ?", "ELIMINAR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    MessageBox.Show(O.Elimireporttotal(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Cargarlistadohora();
                    textBox4.Clear();
                    dataGridView6.ClearSelection();
                    {
                        button23.Enabled = false;
                    }
                    if (dataGridView6.Rows.Count > 0)
                    {
                        button23.Enabled = true;
                    }
                    Verresul();
                    // E.Eliminarhorariototal2();
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

        private void button2_MouseLeave(object sender, EventArgs e)
        {
           // textBox1.Text = "20";
        }

        private void datelune_ValueChanged(object sender, EventArgs e)
        {
           DateTime t = Convert.ToDateTime( datelune.Value);
           byte  o = ( (Byte)t.DayOfWeek);
            textBox12.Text = Convert.ToString(o);
            if (o==0)
            {
                textBox12.Text = "Domingo";
            }
            else
            {
                if (o == 1)
                {
                    textBox12.Text = "Lunes";
                }
                else
                {
                    if (o == 2)
                    {
                        textBox12.Text = "Martes";
                    }
                    else
                    {
                        if (o == 3)
                        {
                            textBox12.Text = "Miercoles";
                        }
                        else
                        {
                            if (o == 4)
                            {
                                textBox12.Text = "Jueves";
                            }
                            else
                            {
                                if(o == 5)
                            {
                                    textBox12.Text = "Viernes";
                                }
                                else
                                {
                                    if (o == 6)
                                    {
                                        textBox12.Text = "Sabado";
                                    }
                                }
                            }
                        }
                    }
                }
            }

        }
    }
}
