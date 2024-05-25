using CapaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace CapaPresentacion
{
    public partial class Frmopera : Form
    {
        public Frmopera()
        {
            InitializeComponent();
        }
        Clsopes S = new Clsopes();
        Adoperacion re = new Adoperacion();
        Clsopusu U = new Clsopusu();
        clsopp O = new clsopp();

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        public Ioperacion contrato { get; set; }
        public Ioperacion contrato1 { get; set; }
        public Ioperacion contrato2 { get; set; }
        public Ioperacion contrato3 { get; set; }
        public Ioperacion contrato4 { get; set; }
        public Ioperacion contrato5 { get; set; }
        public Ioperacion contrato6 { get; set; }
        public Ioperacion contrato7 { get; set; }
        public Ioperacion contrato8 { get; set; }
        public Ioperacion contrato9 { get; set; }
        public Ioperacion contrato10 { get; set; }
        public Ioperacion contrato11 { get; set; }
        public Ioperacion contrato12 { get; set; }
        public Ioperacion contrato13 { get; set; }
        public Ioperacion contrato14 { get; set; }
        public Ioperacion contrato15 { get; set; }
        public Ioperacion contrato16 { get; set; }
        public Ioperacion contrato17 { get; set; }
        public Ioperacion contrato18 { get; set; }

        public Ioperacion contrato19 { get; set; }
        public Ioperacion contrato20 { get; set; }
        public Ioperacion contrato21 { get; set; }
        public Ioperacion contrato22 { get; set; }
        public Ioperacion contrato23 { get; set; }
        public Ioperacion contrato24 { get; set; }
        public Ioperacion contrato25 { get; set; }
        public Ioperacion contrato26 { get; set; }
        public Ioperacion contrato27 { get; set; }
        public Ioperacion contrato28 { get; set; }
        public Ioperacion contrato29 { get; set; }
        public Ioperacion contrato30 { get; set; }
        public Ioperacion contrato31 { get; set; }


        private void listaopera()

        {
            try
            {

                DataTable dt9 = new DataTable();
                dt9 = S.ListadoOppfinal();
                // if (cn.State == ConnectionState.Closed)
                //  cn.Open();
                //  using (SqlDataAdapter da = new SqlDataAdapter("select * from  prendasmodi ", cn))
                //  O.Actualizadato1.Fill();
           // dataGridView1.DataSource = dt9;


           //  dataGridView1.RowTemplate.Height = 13;

            

               // dataGridView2.DataSource = dt9;

            //  Verresul1();



            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message);
            }
           // dataGridView1.ClearSelection();
            //Verresul();
        }
        
        private void Cargarop()

        {
            try
            {
                DataTable dt8 = new DataTable();
                dt8 = re.Listadoopu();
                // if (cn.State == ConnectionState.Closed)
                //  cn.Open();
                //  using (SqlDataAdapter da = new SqlDataAdapter("select * from  prendasmodi ", cn))
                //  O.Actualizadato1.Fill();
                dataGridView2.DataSource = dt8;
                
                dataGridView2.DefaultCellStyle.Font = new Font("Bookshelf Symbol", 7);

                dataGridView2.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView2.Font, FontStyle.Bold); // negrita en titulos
                dataGridView2.RowTemplate.Height = 13;
                dataGridView2.Columns[0].HeaderText = "Op";        
                dataGridView2.Columns[0].Width = 85;
            //    DataGridViewColumn column1 = dataGridView1.Columns[1];
              //    column1.Visible = false;
             //   DataGridViewColumn column2 = dataGridView1.Columns[2];
              //  column2.Visible = false;
               // DataGridViewColumn column3 = dataGridView1.Columns[3];
               // column3.Visible = false;
                //DataGridViewColumn column4 = dataGridView1.Columns[4];
               // column4.Visible = false;
        
                //   FreezeBand(dataGridView8.Columns[1]);
                // FreezeBand1(dataGridView8.Columns[3]);
                //  dataGridView8.Columns[4].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                //  dataGridView8.Columns[5].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                //  dataGridView8.Columns[6].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                //  dataGridView8.Columns[7].DefaultCellStyle.BackColor = Color.WhiteSmoke;


                // color();
                // colorazul();
              Verresul1();

            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message);
                //MessageBox.Show("Solo se admiten el valor de la OP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dataGridView2.ClearSelection();
            //color();

        }
        private void Verresul1()
        {
           // int baser = 0;
           // int baser1 = 0;
            //int resultado = 0;

          //  double total = 0;
          //  foreach (DataGridViewRow row in dataGridView2.Rows)
           // {

               // total += Convert.ToDouble(row.Cells[6].Value) * Convert.ToDouble(row.Cells[7].Value);
               // row.Cells[dataGridView2.Columns[8].Index].Value = (Convert.ToDecimal(row.Cells[dataGridView2.Columns[6].Index].Value) * Convert.ToDecimal(row.Cells[dataGridView1.Columns[7].Index].Value));

          //  }
           // textBox17.Text = total.ToString("N");
            textBox10.Text = dataGridView2.RowCount.ToString();
            //   Convert.ToString(ded.ToString("00.0"));
          //  int sum = 0;
          //  for (int i = 0; i < dataGridView1.Rows.Count; ++i)
          //  {
          //      sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[7].Value);
          //  }
            // baser = Convert.ToInt32(textBox10.Text);
            // baser1 = Convert.ToInt32(textBox5.Text);
            // resultado = baser + baser1;
            //  txtiddope.Text = Convert.ToString(resultado);
            //textBox16.Text = sum.ToString("N");
            listaopera();
            // color();
            // colorazul();
        }
        private void Verresul2()
        {
            // int baser = 0;
            // int baser1 = 0;
            //int resultado = 0;

            //  double total = 0;
            //  foreach (DataGridViewRow row in dataGridView2.Rows)
            // {

            // total += Convert.ToDouble(row.Cells[6].Value) * Convert.ToDouble(row.Cells[7].Value);
            // row.Cells[dataGridView2.Columns[8].Index].Value = (Convert.ToDecimal(row.Cells[dataGridView2.Columns[6].Index].Value) * Convert.ToDecimal(row.Cells[dataGridView1.Columns[7].Index].Value));

            //  }
            // textBox17.Text = total.ToString("N");
            textBox5.Text = dataGridView1.RowCount.ToString();
            //   Convert.ToString(ded.ToString("00.0"));
            //  int sum = 0;
            //  for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            //  {
            //      sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[7].Value);
            //  }
            // baser = Convert.ToInt32(textBox10.Text);
            // baser1 = Convert.ToInt32(textBox5.Text);
            // resultado = baser + baser1;
            //  txtiddope.Text = Convert.ToString(resultado);
            //textBox16.Text = sum.ToString("N");
           
            // color();
            // colorazul();
        }

        private void listaop()

        {
            try
            {

                DataTable dt5 = new DataTable();
                dt5 = re.Listadoopu();
                // if (cn.State == ConnectionState.Closed)
                //  cn.Open();
                //  using (SqlDataAdapter da = new SqlDataAdapter("select * from  prendasmodi ", cn))
                //  O.Actualizadato1.Fill();
               dataGridView2.DataSource = dt5;


             dataGridView2.RowTemplate.Height = 13;



              //  dataGridView2.DataSource = dt8;

                // Verresul4();


                Verresul1();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataGridView2.ClearSelection();
            //Verresul();
        }
        private void Cargarlistaoperacion()

        {

            DataTable dt = new DataTable();
            dt = S.ListadoOppfinal();
            try
            {
                dataGridView1.Rows.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dataGridView1.DefaultCellStyle.Font = new Font("Bookshelf Symbol", 7);

                    dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold); // negrita en titulos
                    dataGridView1.RowTemplate.Height = 13;
                    dataGridView1.Rows.Add(dt.Rows[i][0]);
                    dataGridView1.Rows[i].Cells[0].Value = dt.Rows[i][0].ToString();
                    dataGridView1.Rows[i].Cells[1].Value = dt.Rows[i][1].ToString();
                    dataGridView1.Rows[i].Cells[2].Value = dt.Rows[i][2].ToString();
                    dataGridView1.Rows[i].Cells[3].Value = dt.Rows[i][3].ToString();
                    dataGridView1.Rows[i].Cells[4].Value = dt.Rows[i][4].ToString();
                    dataGridView1.Rows[i].Cells[5].Value = dt.Rows[i][5].ToString();
                    dataGridView1.Rows[i].Cells[6].Value = dt.Rows[i][6].ToString();
                    dataGridView1.Rows[i].Cells[7].Value = dt.Rows[i][7].ToString();
                    dataGridView1.Rows[i].Cells[8].Value = dt.Rows[i][8].ToString();
                    dataGridView1.Rows[i].Cells[9].Value = dt.Rows[i][9].ToString();
                    dataGridView1.Rows[i].Cells[10].Value = dt.Rows[i][10].ToString();
                    dataGridView1.Rows[i].Cells[11].Value = dt.Rows[i][11].ToString();
                    dataGridView1.Rows[i].Cells[12].Value = dt.Rows[i][12].ToString();
                    dataGridView1.Rows[i].Cells[13].Value = dt.Rows[i][13].ToString();
                    dataGridView1.Rows[i].Cells[14].Value = dt.Rows[i][14].ToString();
                    dataGridView1.Rows[i].Cells[15].Value = dt.Rows[i][15].ToString();
                    dataGridView1.Rows[i].Cells[16].Value = dt.Rows[i][16].ToString();
                    dataGridView1.Rows[i].Cells[17].Value = dt.Rows[i][17].ToString();
                    dataGridView1.Rows[i].Cells[18].Value = dt.Rows[i][18].ToString();
                    dataGridView1.Rows[i].Cells[19].Value = dt.Rows[i][19].ToString();
                    dataGridView1.Rows[i].Cells[20].Value = dt.Rows[i][20].ToString();
                    dataGridView1.Rows[i].Cells[21].Value = dt.Rows[i][21].ToString();
                    dataGridView1.Rows[i].Cells[22].Value = dt.Rows[i][22].ToString();
                    //Verresul();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataGridView1.ClearSelection();
            // Verresul();

        }

        private void Frmopera_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            Cargarlistaoperacion();
            Cargarop();
          //  Cargarlistado1();
            listaop();
        }
        private void Busquedaop1()
        {
            DataTable dt = new DataTable();

            try
            {
                S.Opp1 = Convert.ToInt32(txtop.Text);
                dt = S.Buscaropfinal(S.Opp1);
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
                    dataGridView1.Rows[i].Cells[6].Value = dt.Rows[i][6].ToString();
                    dataGridView1.Rows[i].Cells[7].Value = dt.Rows[i][7].ToString();
                    dataGridView1.Rows[i].Cells[8].Value = dt.Rows[i][8].ToString();
                    dataGridView1.Rows[i].Cells[9].Value = dt.Rows[i][9].ToString();
                    dataGridView1.Rows[i].Cells[10].Value = dt.Rows[i][10].ToString();
                    dataGridView1.Rows[i].Cells[11].Value = dt.Rows[i][11].ToString();
                    dataGridView1.Rows[i].Cells[12].Value = dt.Rows[i][12].ToString();
                    dataGridView1.Rows[i].Cells[13].Value = dt.Rows[i][13].ToString();
                    dataGridView1.Rows[i].Cells[14].Value = dt.Rows[i][14].ToString();
                    dataGridView1.Rows[i].Cells[15].Value = dt.Rows[i][15].ToString();
                    dataGridView1.Rows[i].Cells[16].Value = dt.Rows[i][16].ToString();
                    dataGridView1.Rows[i].Cells[17].Value = dt.Rows[i][17].ToString();
                    dataGridView1.Rows[i].Cells[18].Value = dt.Rows[i][18].ToString();
                    dataGridView1.Rows[i].Cells[19].Value = dt.Rows[i][19].ToString();
                    dataGridView1.Rows[i].Cells[20].Value = dt.Rows[i][20].ToString();
                    dataGridView1.Rows[i].Cells[21].Value = dt.Rows[i][21].ToString();
                    dataGridView1.Rows[i].Cells[22].Value = dt.Rows[i][22].ToString();


                }
                Verresul2();
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);
              
                //MessageBox.Show("Solo se admiten el valor de la OP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dataGridView1.ClearSelection();

            // Verresul2();

        }
        private void Busquedaop2()
        {

            try
            {


                DataTable dt = new DataTable();
                DataRow row;

                S.IDopera = Convert.ToInt32(txtidperac.Text);
                dt = S.Buscaridope(S.IDopera);

                if (dt.Rows.Count == 1)
                {
                
                    row = dt.Rows[0];
                    textBox6.Text = row[2].ToString();                                   
                    txtcan.Text = row[6].ToString();
                    txtnombrpren.Text = row[5].ToString();
                    rtxtdescr.Text = row[7].ToString();
                    txtcat.Text = row[8].ToString();
                    txtcantidadop.Text = row[9].ToString();
                    txtsobre.Text = row[11].ToString();
                    txtxs.Text = row[12].ToString();
                    txts.Text = row[13].ToString();
                    txtm.Text = row[14].ToString();
                    txtl.Text = row[15].ToString();
                    txtxl.Text = row[16].ToString();
                    txtxxl.Text = row[17].ToString();
                    txt3xl.Text = row[18].ToString();
                    txt4xl.Text = row[19].ToString();
                    txt5xl.Text = row[20].ToString();
                    txt6xl.Text = row[21].ToString();
                    

                    // Verresul();
                }
             

                else
                {
                  
                    MessageBox.Show("Registro no existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Solo se admiten el valor de la OP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            dataGridView1.ClearSelection();

            //Verresul();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string f ;
           
            f =Convert.ToString("  SELECT top "+ textBox3.Text + " * FROM prendaop WHERE opp1c = " + textBox1.Text );
            textBox2.Text = Convert.ToString(f);
            DataTable dtm1 = new DataTable("prendaop");
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["CnnORDEN"].ConnectionString))
            {
                if (cn.State == ConnectionState.Closed)
                    cn.Open();

                using (SqlDataAdapter da = new SqlDataAdapter(textBox2.Text, cn))

                    da.Fill(dtm1);
                dataGridView2.DataSource = dtm1;
                // DataGridViewColumn column = dataGridView8.Columns[0];
                //  column.Visible = false;
                dataGridView2.DefaultCellStyle.Font = new Font("Bookshelf Symbol", 7);
                dataGridView2.RowTemplate.Height = 13;
                dataGridView2.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView2.Font, FontStyle.Bold); // negrita en titulos
                dataGridView2.Columns[0].HeaderText = "OP";
                    dataGridView2.Columns[0].Width = 95;

                    Verresul1();
               // dataGridView1.ClearSelection();

                // DataView dv = dtm.DefaultView;
                //dv.RowFilter = string.Format(" nombre_producto like '%{0}%'", textBox1.Text);


                // dataGridView1.DataSource = dv.ToTable();
            }
        }
            catch (Exception ex)
            {
                //MessageBox.Show("Solo se admiten el valor de la OP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

}

private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            if (textBox3.Text.Trim() == String.Empty &  textBox1.Text.Trim() == String.Empty)
            {
                errorProvider1.SetError(textBox3, "Ingrese un valor ");
                button1.Enabled = false;
                button1.BackColor = Color.Gray;

            }
            else
            {

               // button1.Enabled = true;
                
                errorProvider1.Clear();
            }
        }

        private void textBox3_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                int l = 0;
                int m = 501;
                l = Convert.ToInt32(textBox3.Text);
                if (l >= m)
                {
                    button1.Enabled = false;
                    button1.BackColor = Color.Gray;
                }
                else
                {
                    button1.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
           
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (textBox3.Text.Trim() == String.Empty & textBox1.Text.Trim() == String.Empty)
            {
                errorProvider1.SetError(textBox3, "Ingrese un valor ");
                button1.Enabled = false;
                button1.BackColor = Color.Gray;

            }
            else
            {

               // button1.Enabled = true;

                errorProvider1.Clear();
            }
        }
      
       
        private void dataGridView2_Click(object sender, EventArgs e)
        {
        }
        int Listado = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (Listado)
            {
                case 0: Cargarlistaoperacion(); break;
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {

                txtop.Text = dataGridView2.CurrentCell.Value.ToString();

                // Cargarlistado2();


                Busquedaop1();
                timer1.Stop();



                DataTable dt = new DataTable();
                DataRow row;
                re.Opu = Convert.ToInt32(txtop.Text);
                dt = re.Buscaropu(re.Opu);
                if (dt.Rows.Count == 1)
                {
                    row = dt.Rows[0];
                    txtop.Text = row[0].ToString();
                    txtidprenda.Text = row[1].ToString();
                    textBox4.Text = row[2].ToString();
                    //txtcantidadop.Text = row[3].ToString();

                    //dateT1.Value = Convert.ToDateTime(row[4].ToString());


                    //   MessageBox.Show("Registro Encontrado Ok...!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                Verresul2();
                //Cargarlistado2();
                // Sumadetiempo();

                //DataTable dt = new DataTable();
                // DataRow row;
                //re.Op = Convert.ToInt32(txtseletop.Text);
                //  dt = re.Listadoop3(re.Op);

                // re.Opint = Convert.ToInt32(txtseletop.Text);

            }
            catch (Exception ex)
            {
                //  lblverno.Text = "Registro no encontrado";
                // MessageBox.Show("Registro de Orden de Produccion no Existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dataGridView2.ClearSelection();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows[dataGridView1.CurrentRow.Index].Selected = true;
                timer1.Stop();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (MessageBox.Show(" ¡ Seleccionar Id de la operación !" +
                    " ¿ Está seguro que desea continuar ? ", "Insertar datos", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)

                {




                    txtidperac.Text = dataGridView1.CurrentCell.Value.ToString();

                    Busquedaop2();
                    U.IDopera = Convert.ToInt32(txtidperac.Text);
                    U.Opp1 = Convert.ToInt32(txtop.Text);
                    U.IDprendadd = Convert.ToInt32(txtidprenda.Text);
                    U.Nombrepren = textBox4.Text;
                    U.Nombreoperpp = txtnombrpren.Text;
                    U.Categoria = txtcan.Text;
                    U.Tiempopp = Convert.ToDecimal(txtcat.Text);
                    U.Totalpp = Convert.ToDecimal("0");
                    U.Categoria = txtcan.Text;
                    U.Descripcionpp = rtxtdescr.Text;
                    U.Sobremedidao = Convert.ToInt32(txtsobre.Text);
                    U.Xso = Convert.ToInt32(txtxs.Text);
                    U.So = Convert.ToInt32(txts.Text);
                    U.Mmo = Convert.ToInt32(txtm.Text);
                    U.Lo = Convert.ToInt32(txtl.Text);
                    U.Xlo = Convert.ToInt32(txtxl.Text);
                    U.Xxlo = Convert.ToInt32(txtxxl.Text);
                    U.T3xlo = Convert.ToInt32(txt3xl.Text);
                    U.T4xlo = Convert.ToInt32(txt4xl.Text);
                    U.T5xlo = Convert.ToInt32(txt5xl.Text);
                    U.T6xlo = Convert.ToInt32(txt6xl.Text);
                    U.Cantidadpp = Convert.ToInt32(txtcantidadop.Text);
                    U.Estado = Convert.ToInt32(4);
                    // txtcantidadop.Text = U.sumaop().ToString();
                    U.Registrarusu();
                  //  MessageBox.Show(U.Registrarusu(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Busquedaopusu();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" ! Registro no encontrado ¡", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //  MessageBox.Show(ex.Message);
            }
        }

        private void btnregistraopinterno_Click(object sender, EventArgs e)
        {
            try
            {
                contrato.Valor(txtcat.Text);
                contrato1.Valor1(txtnombrpren.Text);
                contrato2.Valor2(rtxtdescr.Text);
                contrato3.Valor3(txtsobre.Text);
                contrato4.Valor4(txtxs.Text);
                contrato5.Valor5(txts.Text);
                contrato6.Valor6(txtm.Text);
                contrato7.Valor7(txtl.Text);
                contrato8.Valor8(txtxl.Text);
                contrato9.Valor9(txtxxl.Text);
                contrato10.Valor10(txt3xl.Text);
                contrato11.Valor11(txt4xl.Text);
                contrato12.Valor12(txt5xl.Text);
                contrato13.Valor13(txt6xl.Text);
                contrato14.Valor14(txtcantidadop.Text);
                contrato15.Valor15(txtidperac.Text);
                contrato16.Valor16(txtop.Text);
                contrato17.Valor17(txtidprenda.Text);
                contrato18.Valor18(textBox3.Text);

                contrato19.Valor19(textsobre.Text);
                contrato20.Valor20(textxs.Text);
                contrato21.Valor21(texts.Text);
                contrato22.Valor22(textm.Text);
                contrato23.Valor23(textl.Text);
                contrato24.Valor24(textxl.Text);
                contrato25.Valor25(textxxl.Text);
                contrato26.Valor26(text3xl.Text);
                contrato27.Valor27(text4xl.Text);
                contrato28.Valor28(text5xl.Text);
                contrato29.Valor29(text6xl.Text);
                contrato30.Valor30(textcantidadop.Text);
                contrato31.Valor31(txtcan.Text);

              


                //   MessageBox.Show("Registro Encontrado Ok...!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);



                //dateT1.Value = Convert.ToDateTime(row[4].ToString());
                //   MessageBox.Show("Registro Encontrado Ok...!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Busquedaopusu();
            }
            //txtnupe2.Text = datao
            catch (Exception ex)
            {
               // MessageBox.Show(" ! Registro no encontrado ¡", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //  MessageBox.Show(ex.Message);
                //this.Hide();
            }


            // contrato1.Ejecutar(txtnombrpren.Text);
            // contrato2.Ejecutar(rtxtdescr.Text);
            this.Hide();
        }
        private void Busquedaopusu()
        {

            try
            {


                DataTable dt = new DataTable();
                DataRow row;

                U.IDopera = Convert.ToInt32(txtidperac.Text);
                dt = U.Buscaropusu(U.IDopera);

                if (dt.Rows.Count == 1)
                {
                    row = dt.Rows[0];

                    

                    textsobre.Text = row[10].ToString();
                    textxs.Text = row[11].ToString();
                    texts.Text = row[12].ToString();
                    textm.Text = row[13].ToString();
                    textl.Text = row[14].ToString();
                    textxl.Text = row[15].ToString();
                    textxxl.Text = row[16].ToString();
                    text3xl.Text = row[17].ToString();
                    text4xl.Text = row[18].ToString();
                    text5xl.Text = row[19].ToString();
                    text6xl.Text = row[20].ToString();
                    textcantidadop.Text = row[8].ToString();
                    // Verresul();
                  
                }


                else
                {
                   
                     MessageBox.Show("Registro no existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Solo se admiten el valor de la OP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



            //Verresul();

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
          
        }

        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int a = 0;
               // textBox6.Text = dataGridView1.CurrentCell.Value.ToString();
               

                try
                { a = Convert.ToInt32(txtop.Text);
                    O.Opp22 = Convert.ToInt32(txtop.Text);

                   
                    if (MessageBox.Show("¿ Esta seguro de eliminar la OP " + a + " ?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        re.Op = Convert.ToInt32(txtop.Text);
                        O.Eliminaropp22();
                        re.Eliminaroperacion();
                        listaop();
                        O.Opp = Convert.ToInt32(txtop.Text);
                      
                        O.Estado = Convert.ToInt32(3);
                        //   O.Fecha_de_registro = dateT1;


                        O.Actualiporop();
                        MessageBox.Show("Se registro correctamente Ok!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       // txtcantidadop.Text = O.sumaop().ToString();

                        Cargarlistaoperacion();

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dataGridView2_VisibleChanged(object sender, EventArgs e)
        {
            int o = Convert.ToInt32(textBox10.Text);
            if (o == 0 && textBox10.Text != null)
            {
                dataGridView2.ColumnHeadersVisible = false;
            }

            else

            {
                dataGridView2.ColumnHeadersVisible = true;
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            int o = Convert.ToInt32(textBox10.Text);
            if (o == 0 && textBox10.Text != null)
            {
                dataGridView2.ColumnHeadersVisible = false;
            }

            else

            {
                dataGridView2.ColumnHeadersVisible = true;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            int o = Convert.ToInt32(textBox5.Text);
            if (o == 0 && textBox5.Text != null)
            {
                dataGridView1.ColumnHeadersVisible = false;
            }

            else

            {
                dataGridView1.ColumnHeadersVisible = true;
            }
        }

        private void dataGridView1_VisibleChanged(object sender, EventArgs e)
        {
            int o = Convert.ToInt32(textBox5.Text);
            if (o == 0 && textBox5.Text != null)
            {
                dataGridView1.ColumnHeadersVisible = false;
            }

            else

            {
                dataGridView1.ColumnHeadersVisible = true;
            }
        }
    }
}
