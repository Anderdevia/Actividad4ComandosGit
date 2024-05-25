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
using CapaPresentacion;

namespace WindowsFormsApp1
{
   
    public partial class FrmEmpleados : Form
    {
       
        
            //variables que conectan a otras Capas
            ClsReglasEmpleados Reglas = new ClsReglasEmpleados();
            ClsTBL_EMPLEADOS TblAtri = new ClsTBL_EMPLEADOS();

        public Iopfinal contrato102 { get; set; }
        public Iopfinal contrato103 { get; set; }
        public Iopfinal contrato104 { get; set; }

        public FrmEmpleados()
        {
            InitializeComponent();
        }
        private void listaempleado()

        {
            try
            {
                DataTable dt8 = new DataTable();
                dt8 = Reglas.ListadoEmpleados();

                dataGridView1.DataSource = dt8;


                dataGridView1.RowTemplate.Height = 13;
                dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkGray;
                

                Verresul2();

                    
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataGridView1.ClearSelection();
            //Verresul();

        }
        private void COLOR()

        {

            try
            {
                dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkGray;
                dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;
                try
                {
                    for (int ip = 0; ip < dataGridView1.Rows.Count; ip++)
                    {
                        int val = Int32.Parse(dataGridView1.Rows[ip].Cells[8].Value.ToString());


                        if (val == 1)
                        {
                            dataGridView1.Rows[ip].DefaultCellStyle.BackColor = Color.SkyBlue;
                             dataGridView1.ClearSelection();
                            // Cargarlistafinal();
                        }
                        if (val == 2)
                        {
                            dataGridView1.Rows[ip].DefaultCellStyle.BackColor = Color.SpringGreen;
                             dataGridView1.ClearSelection();
                            // Cargarlistafinal();
                        }
                    }
                }
                catch (Exception ex)
                {
                    // MessageBox.Show("Dar Click unicamente en OP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //  MessageBox.Show(ex.Message);
                }

                Verresul2();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataGridView1.ClearSelection();
            //Verresul();
        }
        private void Listarempleado()
        {

           
            try
            {
               

                    
                        DataTable dt8 = new DataTable();
                        dt8 = Reglas.ListadoEmpleados();
                     
                        dataGridView1.DataSource = dt8;
                       // DataGridViewColumn column = dataGridView7.Columns[0];
                        //  column.Visible = false;
                        dataGridView1.DefaultCellStyle.Font = new Font("Bookshelf Symbol", 7);
                        dataGridView1.RowTemplate.Height = 13;
                        dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold); // negrita en titulos
                        dataGridView1.Columns[0].HeaderText = "Cedula";
                        dataGridView1.Columns[0].Width = 100;
                        dataGridView1.Columns[1].HeaderText = "Nombre";
                        dataGridView1.Columns[1].Width = 150;
                        dataGridView1.Columns[2].HeaderText = "Area";
                        dataGridView1.Columns[2].Width = 60;
                        dataGridView1.Columns[3].HeaderText = "Cargo";
                        dataGridView1.Columns[3].Width = 80;
                        dataGridView1.Columns[4].HeaderText = "Modalidad";
                        dataGridView1.Columns[4].Width = 74;
                        dataGridView1.Columns[5].HeaderText = "Fecha";
                        dataGridView1.Columns[5].Width = 70;
                dataGridView1.Columns[6].HeaderText = "Dias";
                dataGridView1.Columns[6].Width = 50;
                dataGridView1.Columns[7].HeaderText = "Sexo";
                dataGridView1.Columns[7].Width = 50;
                dataGridView1.Columns[8].HeaderText = "Pro";
                dataGridView1.Columns[8].Width = 50;


                DataGridViewColumn column = dataGridView1.Columns[8];
               column.Visible = false;
                COLOR();

                Verresul2();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            dataGridView1.ClearSelection();
        }
        private void validar()
        {


            if (txtidentificacion.Text != string.Empty & txtnombres.Text != string.Empty & txtcargo.Text != string.Empty & txtcategoria.Text != string.Empty )
            { button9.Enabled = true;
                button10.Enabled = true;
            }

            else
            {
                button9.Enabled = false;
                button10.Enabled = false;
            }
        }
        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
            //llenar  grilla
            button9.Enabled = false;
            button10.Enabled = false;
            listaempleado();
           Listarempleado();
            this.Cursor = Cursors.Default;
        }

        private void Btnadicionar_Click(object sender, EventArgs e)
        {
          
        }
        public void Limpiar()
        {
            txtidentificacion.Clear();
            txtnombres.Clear();
            txtcargo.Clear();
            txtcategoria.Clear();
            textBox3.Clear();
            radioButton1.Checked = true;
            dateTimePicker1.Value = DateTime.Now;
            txtidentificacion.Focus();
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
        }

     

      

        private void btnmodificar_Click(object sender, EventArgs e)
        {
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtidentificacion.Clear();
            txtnombres.Clear();
            txtcargo.Clear();
            txtcategoria.Clear();
            radioButton1.Checked = true;
          
            textBox3.Clear();
            txtidentificacion.Focus();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            
        }

        private void btnbuscarem_Click(object sender, EventArgs e)
        {
           
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void gridEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
           
            try
            {
                if (comboBox1.Text == "SI") {   
                    TblAtri.Cedula = Convert.ToInt32(txtidentificacion.Text);
                TblAtri.Nombre = txtnombres.Text;
                TblAtri.Area = txtcargo.Text;

                TblAtri.Cargo = txtcategoria.Text;
                TblAtri.Modalidad = textBox3.Text;
                TblAtri.Dia = Convert.ToInt32(0);
                TblAtri.Fecha_de_ingreso = dateTimePicker1.Value;
                TblAtri.Sexo = radioButton1.Checked == true ? 'M' : 'F';

                TblAtri.Pro = Convert.ToInt32(1);
                MessageBox.Show(Reglas.Registrar_empleados(TblAtri), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                listaempleado();
                Verresul2();
                Limpiar();
                }
                else
                {
                    if (comboBox1.Text == "NO")
                    {
                        TblAtri.Cedula = Convert.ToInt32(txtidentificacion.Text);
                        TblAtri.Nombre = txtnombres.Text;
                        TblAtri.Area = txtcargo.Text;

                        TblAtri.Cargo = txtcategoria.Text;
                        TblAtri.Modalidad = textBox3.Text;
                        TblAtri.Dia = Convert.ToInt32(0);
                        TblAtri.Fecha_de_ingreso = dateTimePicker1.Value;
                        TblAtri.Sexo = radioButton1.Checked == true ? 'M' : 'F';

                        TblAtri.Pro = Convert.ToInt32(2);
                        MessageBox.Show(Reglas.Registrar_empleados(TblAtri), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        listaempleado();
                        Verresul2();
                        Limpiar();
                    }
                }

               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text == "SI")
                {
                    TblAtri.Cedula = Convert.ToInt32(txtidentificacion.Text);
                    TblAtri.Nombre = txtnombres.Text;
                    TblAtri.Area = txtcargo.Text;

                    TblAtri.Cargo = txtcategoria.Text;
                    TblAtri.Modalidad = textBox3.Text;
                    TblAtri.Dia = Convert.ToInt32(0);
                    TblAtri.Fecha_de_ingreso = dateTimePicker1.Value;
                    TblAtri.Sexo = radioButton1.Checked == true ? 'M' : 'F';

                    TblAtri.Pro = Convert.ToInt32(1);
                    MessageBox.Show(Reglas.ActualizarDatos(TblAtri), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    listaempleado();
                    Verresul2();
                    Limpiar();
                }
                else
                {
                    if (comboBox1.Text == "NO")
                    {
                        TblAtri.Cedula = Convert.ToInt32(txtidentificacion.Text);
                        TblAtri.Nombre = txtnombres.Text;
                        TblAtri.Area = txtcargo.Text;

                        TblAtri.Cargo = txtcategoria.Text;
                        TblAtri.Modalidad = textBox3.Text;
                        TblAtri.Dia = Convert.ToInt32(0);
                        TblAtri.Fecha_de_ingreso = dateTimePicker1.Value;
                        TblAtri.Sexo = radioButton1.Checked == true ? 'M' : 'F';

                        TblAtri.Pro = Convert.ToInt32(2);
                        MessageBox.Show(Reglas.ActualizarDatos(TblAtri), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        listaempleado();
                        Verresul2();
                        Limpiar();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                //MessageBox.Show("Registro no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView7_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            textBox8.Text = dataGridView1.CurrentCell.Value.ToString();

            try
            {
                DataTable dt = new DataTable();
                DataRow row;
                TblAtri.Cedula = Convert.ToInt32(textBox8.Text);
                dt = Reglas.BuscarEmpleados(TblAtri.Cedula.ToString());
                if (dt.Rows.Count == 1)
                {
                    row = dt.Rows[0];
                    txtidentificacion.Text = row[0].ToString();
                    txtnombres.Text = row[1].ToString();
                    txtcargo.Text = row[2].ToString();
                    txtcategoria.Text = row[3].ToString();
                    textBox3.Text = row[4].ToString();
                    dateTimePicker1.Value = Convert.ToDateTime(row[5].ToString());
                    if (row[7].ToString() == "M")
                        radioButton1.Checked = true;
                    else
                        radioButton2.Checked = true;

                  //  MessageBox.Show("Registro Encontrado Ok...!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cédula no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Limpiar();
                }
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message);
            }
            // gridViewprendas.ClearSelection();
        }

        private void dataGridView7_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            int a = 0;
            try
            {
                textBox8.Text = dataGridView1.CurrentCell.Value.ToString();
            a = Convert.ToInt32(textBox8.Text);
            if (MessageBox.Show(" ¿ Esta seguro de eliminar CC " + a + "?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                
                
                    TblAtri.Cedula = Convert.ToInt32(textBox8.Text);
                   Reglas.EliminarRegistro(TblAtri);
                    Listarempleado();
                    Limpiar();

            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Verresul2()
        {
          
          
            try
            { 

                textBox2.Text = dataGridView1.RowCount.ToString();
            DateTime fechaUno = dateTimePicker1.Value;
           


                decimal baser = 0;
                decimal baser1 = 0;
                int resultado = 0;

                double total = 0;
                double totalim = 0;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {

                    //total += Convert.ToDouble(row.Cells[8].Value);

                    TimeSpan difFechas =(fechaUno) - Convert.ToDateTime(row.Cells[dataGridView1.Columns[5].Index].Value);
                     int dias = difFechas.Days;
                    row.Cells[dataGridView1.Columns[6].Index].Value = dias;
                         //TimeSpan difFechas = fechaUno - 5;
                }
              //  COLOR();
                //   Convert.ToString(ded.ToString("00.0"));
                // int sum = 0;
                //  for (int i = 0; i < dataopb.Rows.Count; ++i)
                // {
                //     sum += Convert.ToInt32(dataopb.Rows[i].Cells[15].Value);
                // }
                // baser = Convert.ToInt32(textBox3.Text);
                // baser1 = Convert.ToInt32(txtnup1.Text);
                //resultado = baser + baser1;
                // textBox4.Text = Convert.ToString(resultado);
                // textBox22.Text = sum.ToString("00.00");
                // textBox7.Text = sum.ToString();
            }
            catch (Exception ex)
            {
                // MessageBox.Show("Dar Click unicamente en OP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //  MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

           


        }

        private void buscarem()
        {

            DataTable dt = new DataTable();

            try
            {

                TblAtri.Cedula = Convert.ToInt32(txtbuscar.Text);
                dt = Reglas.BuscarEmpleados(TblAtri.Cedula.ToString());
                dataGridView1.Rows.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {

                    dataGridView1.Rows.Add(dt.Rows[i][0]);
                    dataGridView1.Rows[i].Cells[0].Value = dt.Rows[i][0].ToString();
                    dataGridView1.Rows[i].Cells[1].Value = dt.Rows[i][1].ToString();
                    dataGridView1.Rows[i].Cells[2].Value = dt.Rows[i][2].ToString();
                    dataGridView1.Rows[i].Cells[3].Value = dt.Rows[i][3].ToString();
                    dataGridView1.Rows[i].Cells[4].Value = dt.Rows[i][4].ToString();
                    dataGridView1.Rows[i].Cells[5].Value = dt.Rows[i][5].ToString();
                    dataGridView1.DefaultCellStyle.Font = new Font("Bookshelf Symbol", 7);
                    dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);
                    dataGridView1.RowTemplate.Height = 13;
                    Verresul2();
                    
                }
                // if (textBox9.Text == "0")
                //    {
                //     label1.Text = "Registro no encontrado";
                //  }


            
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message);

              
                // txtidentificacion.Enabled = false;
                //  btnttemm2.Focus();

                // MessageBox.Show(ex.Message);
            }
            dataGridView1.ClearSelection();


        }
        private void txtbuscar_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void txtbuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                buscarem();
            }
            else
            {
                Listarempleado();
            }
        }

        private void dataGridView7_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
           
        }

        private void txtidentificacion_TextChanged(object sender, EventArgs e)
        {
            validar();
        }

        private void txtnombres_TextChanged(object sender, EventArgs e)
        {
            validar();
        }

        private void txtcargo_TextChanged(object sender, EventArgs e)
        {
            validar();
        }

        private void txtcategoria_TextChanged(object sender, EventArgs e)
        {
            validar();
        }

        private void radioButton1_Validating(object sender, CancelEventArgs e)
        {
            validar();
        }

        private void radioButton2_Validating(object sender, CancelEventArgs e)
        {
            validar();
        }

        private void txtidentificacion_Enter(object sender, EventArgs e)
        {
            //txtnombres.Focus();
        }

        private void txtnombres_Enter(object sender, EventArgs e)
        {
           // txtcargo.Focus();
        }

        private void txtcargo_Enter(object sender, EventArgs e)
        {
           // txtcategoria.Focus();
        }

        private void txtc(object sender, EventArgs e)
        {

        }

        private void txtcategoria_Enter(object sender, EventArgs e)
        {
           // button10.Focus();
        }

        private void txtidentificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
               txtnombres.Focus();
            }
            else
            {
               
            }
            
        }

        private void txtnombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtcargo.Focus();
            }
            else
            {

            }
        }

        private void txtcargo_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 13)
            {
                txtcategoria.Focus();
            }
            else
            {

            }
        }

        private void txtcategoria_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 13)
            {
                radioButton1.Focus();
            }
            else
            {

            }
        }

        private void radioButton1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                radioButton2.Focus();
            }
            else
            {

            }
        }

        private void radioButton2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                button10.Focus();
            }
            else
            {

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            string f;

            f = Convert.ToString("  SELECT  * FROM empleados WHERE nombre LIKE '" + textBox1.Text + "%'");
            textBox14.Text = Convert.ToString(f);
            DataTable dtm1 = new DataTable("empleados");
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["CnnORDEN"].ConnectionString))
            {
                if (cn.State == ConnectionState.Closed)
                    cn.Open();

                using (SqlDataAdapter da = new SqlDataAdapter(textBox14.Text, cn))

                    da.Fill(dtm1);
                dataGridView1.DataSource = dtm1;
                // DataGridViewColumn column = dataGridView8.Columns[0];
                //  column.Visible = false;
                dataGridView1.DefaultCellStyle.Font = new Font("Bookshelf Symbol", 7);
                dataGridView1.RowTemplate.Height = 13;
                dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold); // negrita en titulos
                //dataGridView1.Columns[0].HeaderText = "OP";
                COLOR();
                Verresul2();
                // dataGridView1.ClearSelection();

                // DataView dv = dtm.DefaultView;
                //dv.RowFilter = string.Format(" nombre_producto like '%{0}%'", textBox1.Text);


                // dataGridView1.DataSource = dv.ToTable();
            }
        }

        private void txtbuscar_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("cedula = '{0}'", txtbuscar.Text);
                //Cargarlistadomodifi();
                Verresul2();
             //   COLOR();
                // if (textBox4.Text != string.Empty)
                //  {
                //     button1.Enabled = true;
                // }
                // else
                // {
                //     button1.Enabled = false;
                // }
            }
            catch (Exception ex)
            {
                listaempleado();//Verresul2();
                // MessageBox.Show(ex.Message);
                //MessageBox.Show("Solo se admiten el valor de la OP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // label2.Text = "REGISTRO NO ENCONTRADO";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            contrato102.Valor49op(txtidentificacion.Text);
            contrato103.Valor50op(txtnombres.Text);
            contrato104.Valor51op(txtcategoria.Text);
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView7_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {


                int a = 0;
                textBox5.Text = dataGridView1.CurrentCell.Value.ToString();
                a = Convert.ToInt32(textBox5.Text);
                try
                {
                    TblAtri.Cedula = Convert.ToInt32(textBox5.Text);
                    if (MessageBox.Show(" ¿ Esta seguro de eliminar el registro " + a + " ?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        TblAtri.Cedula = Convert.ToInt32(txtidentificacion.Text);
                        MessageBox.Show(Reglas.EliminarRegistro(TblAtri), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        listaempleado();
                        Limpiar();

                    }
                  
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void textBox4_KeyUp(object sender, KeyEventArgs e)
        {
            string f;

            f = Convert.ToString("  SELECT  * FROM empleados p WHERE p.nombre LIKE '" + textBox1.Text + "%'  and p.area LIKE '" + textBox4.Text + "%'");
            textBox14.Text = Convert.ToString(f);
            DataTable dtm1 = new DataTable("empleados");
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["CnnORDEN"].ConnectionString))
            {
                if (cn.State == ConnectionState.Closed)
                    cn.Open();

                using (SqlDataAdapter da = new SqlDataAdapter(textBox14.Text, cn))

                    da.Fill(dtm1);
                dataGridView1.DataSource = dtm1;
                // DataGridViewColumn column = dataGridView8.Columns[0];
                //  column.Visible = false;
                dataGridView1.DefaultCellStyle.Font = new Font("Bookshelf Symbol", 7);
                dataGridView1.RowTemplate.Height = 13;
                dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold); // negrita en titulos
                //dataGridView1.Columns[0].HeaderText = "OP";
                COLOR();
                Verresul2();
                // dataGridView1.ClearSelection();

                // DataView dv = dtm.DefaultView;
                //dv.RowFilter = string.Format(" nombre_producto like '%{0}%'", textBox1.Text);


                // dataGridView1.DataSource = dv.ToTable();
            }
        }

       
        private void dataGridView7_VisibleChanged(object sender, EventArgs e)
        {
            int o = Convert.ToInt32(textBox2.Text);
            if (o == 0 && textBox2.Text != null)
            {
                dataGridView1.ColumnHeadersVisible = false;
            }

            else

            {
                dataGridView1.ColumnHeadersVisible = true;
            }

            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkGray;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;
  try
            {
            for (int ip = 0; ip < dataGridView1.Rows.Count; ip++)
            {
                int val = Int32.Parse(dataGridView1.Rows[ip].Cells[8].Value.ToString());


                if (val == 1)
                {
                    dataGridView1.Rows[ip].DefaultCellStyle.BackColor = Color.SkyBlue;
                    // dataGridView7.ClearSelection();
                    // Cargarlistafinal();
                }
                if (val == 2)
                {
                    dataGridView1.Rows[ip].DefaultCellStyle.BackColor = Color.SpringGreen;
                    //  dataGridView7.ClearSelection();
                    // Cargarlistafinal();
                }
            }   }
            catch (Exception ex)
            {
                // MessageBox.Show("Dar Click unicamente en OP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //  MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView7_Leave(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_Validating(object sender, CancelEventArgs e)
        {
           
        }

        private void msrdomsr(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int o = Convert.ToInt32(textBox2.Text);
            if (o == 0 && textBox2.Text != null)
            {
                dataGridView1.ColumnHeadersVisible = false;
            }

            else

            {
                dataGridView1.ColumnHeadersVisible = true;
            }
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            dataGridView1.EnableHeadersVisualStyles = false;
            DataGridViewColumn dataGridViewColumn = dataGridView1.Columns[0];
            dataGridViewColumn.HeaderCell.Style.BackColor = Color.LightGray;
            dataGridViewColumn.HeaderCell.Style.ForeColor = Color.Black;

            DataGridViewColumn dataGridViewColumn1 = dataGridView1.Columns[1];
            dataGridViewColumn1.HeaderCell.Style.BackColor = Color.LightGray;
            dataGridViewColumn1.HeaderCell.Style.ForeColor = Color.Black;

            DataGridViewColumn dataGridViewColumn2 = dataGridView1.Columns[2];
            dataGridViewColumn2.HeaderCell.Style.BackColor = Color.LightGray;
            dataGridViewColumn2.HeaderCell.Style.ForeColor = Color.Black;

            DataGridViewColumn dataGridViewColumn3 = dataGridView1.Columns[3];
            dataGridViewColumn3.HeaderCell.Style.BackColor = Color.LightGray;
            dataGridViewColumn3.HeaderCell.Style.ForeColor = Color.Black;

            DataGridViewColumn dataGridViewColumn4 = dataGridView1.Columns[4];
            dataGridViewColumn4.HeaderCell.Style.BackColor = Color.LightGray;
            dataGridViewColumn4.HeaderCell.Style.ForeColor = Color.Black;

            DataGridViewColumn dataGridViewColumn5 = dataGridView1.Columns[5];
            dataGridViewColumn5.HeaderCell.Style.BackColor = Color.LightGray;
            dataGridViewColumn5.HeaderCell.Style.ForeColor = Color.Black;



            DataGridViewColumn dataGridViewColumn6 = dataGridView1.Columns[6];
            dataGridViewColumn6.HeaderCell.Style.BackColor = Color.LightGray;
            dataGridViewColumn6.HeaderCell.Style.ForeColor = Color.Black;

            DataGridViewColumn dataGridViewColumn7 = dataGridView1.Columns[7];
            dataGridViewColumn7.HeaderCell.Style.BackColor = Color.LightGray;
            dataGridViewColumn7.HeaderCell.Style.ForeColor = Color.Black;

        }
    }    
}
