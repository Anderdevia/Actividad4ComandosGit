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

namespace CapaPresentacion
{
    public partial class Frmop : Form
    {
        public Frmop()
        {
            InitializeComponent();
        }
        clsopinterna O = new clsopinterna();
        clsOp vo = new clsOp();
        public IOp contrato { get; set; }
        public IOp contrato1 { get; set; }
        public IOp contrato2 { get; set; }
        public IOp contrato3 { get; set; }
        public IOp contrato4 { get; set; }
        public IOp contrato5 { get; set; }
        public IOp contrato6 { get; set; }
        public IOp contrato7 { get; set; }
        public IOp contrato8 { get; set; }
        public IOp contrato9 { get; set; }
        public IOp contrato10 { get; set; }
        public IOp contrato11 { get; set; }
        public IOp contrato12 { get; set; }
        public IOp contrato13 { get; set; }
        public IOp contrato14 { get; set; }
        public IOp contrato15 { get; set; }
        public IOp contrato16 { get; set; }
        public IOp contrato17 { get; set; }
        public IOp contrato18 { get; set; }

        public IOp contrato19 { get; set; }
        public IOp contrato20 { get; set; }
        public IOp contrato21 { get; set; }
        public IOp contrato22 { get; set; }
        public IOp contrato23 { get; set; }
        public IOp contrato24 { get; set; }
        public IOp contrato25 { get; set; }
        public IOp contrato26 { get; set; }
        public IOp contrato27 { get; set; }
        public IOp contrato28 { get; set; }

        private void Frmop_Load(object sender, EventArgs e)
        {
            listaop();
            Cargarop();
        }
        private void listaop()

        {
            try
            {

                DataTable dt5 = new DataTable();
                dt5 = vo.ListadoOp();
                // if (cn.State == ConnectionState.Closed)
                //  cn.Open();
                //  using (SqlDataAdapter da = new SqlDataAdapter("select * from  prendasmodi ", cn))
                //  O.Actualizadato1.Fill();
                dataGridView8.DataSource = dt5;


                dataGridView8.RowTemplate.Height = 13;



                //  dataGridView2.DataSource = dt8;

                // Verresul4();


                Verresul2();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataGridView8.ClearSelection();
            //Verresul();
        }
        private void Cargarop()

        {
            try
            {
                DataTable dt8 = new DataTable();
                dt8 = vo.ListadoOp();
                // if (cn.State == ConnectionState.Closed)
                //  cn.Open();
                //  using (SqlDataAdapter da = new SqlDataAdapter("select * from  prendasmodi ", cn))
                //  O.Actualizadato1.Fill();
                dataGridView8.DataSource = dt8;

                dataGridView8.DefaultCellStyle.Font = new Font("Bookshelf Symbol", 7);

                dataGridView8.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView8.Font, FontStyle.Bold); // negrita en titulos
                dataGridView8.RowTemplate.Height = 13;
                dataGridView8.Columns[0].HeaderText = "Op";
                dataGridView8.Columns[0].Width = 85;              
                dataGridView8.Columns[1].HeaderText = "Tiempo";
                dataGridView8.Columns[1].Width = 60;
                dataGridView8.Columns[2].HeaderText = "Nombre";
                dataGridView8.Columns[2].Width = 200;
                dataGridView8.Columns[3].HeaderText = "Descripcion";
                dataGridView8.Columns[3].Width = 110;
                dataGridView8.Columns[4].HeaderText = "Categoria";
                dataGridView8.Columns[4].Width = 95;
                dataGridView8.Columns[5].HeaderText = "Cantidad";
                dataGridView8.Columns[5].Width = 85;
                dataGridView8.Columns[6].HeaderText = "Total";
                dataGridView8.Columns[6].Width = 80;
                dataGridView8.Columns[7].HeaderText = "Sobremedida";
                dataGridView8.Columns[7].Width = 82;
                dataGridView8.Columns[8].HeaderText = "XS";
                dataGridView8.Columns[8].Width = 30;
                dataGridView8.Columns[9].HeaderText = "S";
                dataGridView8.Columns[9].Width = 30;
                dataGridView8.Columns[10].HeaderText = "M";
                dataGridView8.Columns[10].Width = 30;
                dataGridView8.Columns[11].HeaderText = "L";
                dataGridView8.Columns[11].Width = 30;
                dataGridView8.Columns[12].HeaderText = "XL";
                dataGridView8.Columns[12].Width = 30;
                dataGridView8.Columns[13].HeaderText = "XXL";
                dataGridView8.Columns[13].Width = 30;
                dataGridView8.Columns[14].HeaderText = "3XL";
                dataGridView8.Columns[14].Width = 30;
                dataGridView8.Columns[15].HeaderText = "4XL";
                dataGridView8.Columns[15].Width = 30;
                dataGridView8.Columns[16].HeaderText = "5XL";
                dataGridView8.Columns[16].Width = 30;
                dataGridView8.Columns[17].HeaderText = "6XL";
                dataGridView8.Columns[17].Width = 30;
                dataGridView8.Columns[18].HeaderText = "Fecha";
                dataGridView8.Columns[18].Width = 80;
                Verresul2();
                //   DataGridViewColumn column1 = dataGridView8.Columns[5];
                // column1.Visible = false;
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


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
      
        private void Verresul2()
        {
            double total = 0;
            foreach (DataGridViewRow row in dataGridView8.Rows)
            {

              //  total += Convert.ToDouble(row.Cells[1].Value) * Convert.ToDouble(row.Cells[5].Value);
                row.Cells[dataGridView8.Columns[6].Index].Value = (Convert.ToDecimal(row.Cells[dataGridView8.Columns[1].Index].Value) * Convert.ToDecimal(row.Cells[dataGridView8.Columns[5].Index].Value));

            }
        //    textBox17.Text = total.ToString("N");
            textBox10.Text = dataGridView8.RowCount.ToString();
            //   Convert.ToString(ded.ToString("00.0"));
           // int sum = 0;
           // for (int i = 0; i < dataGridView8.Rows.Count; ++i)
          //  {
           //     sum += Convert.ToInt32(dataGridView8.Rows[i].Cells[5].Value);
           // }
            // baser = Convert.ToInt32(textBox10.Text);
            // baser1 = Convert.ToInt32(textBox5.Text);
            // resultado = baser + baser1;
            //  txtiddope.Text = Convert.ToString(resultado);
          //  textBox16.Text = sum.ToString("N");
           // Algoritmomodi();
            // color();
            // colorazul();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string f;

            f = Convert.ToString("  SELECT top " + textBox3.Text + " * FROM prendas WHERE op LIKE '" + textBox1.Text + "%'");
            textBox2.Text = Convert.ToString(f);
            DataTable dtm1 = new DataTable("prendas");
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["CnnORDEN"].ConnectionString))
            {
                if (cn.State == ConnectionState.Closed)
                    cn.Open();

                using (SqlDataAdapter da = new SqlDataAdapter(textBox2.Text, cn))

                    da.Fill(dtm1);
                dataGridView8.DataSource = dtm1;
                // DataGridViewColumn column = dataGridView8.Columns[0];
                //  column.Visible = false;
                dataGridView8.DefaultCellStyle.Font = new Font("Bookshelf Symbol", 7);
                dataGridView8.RowTemplate.Height = 13;
                dataGridView8.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView8.Font, FontStyle.Bold); // negrita en titulos
                dataGridView8.Columns[0].HeaderText = "OP";
                Verresul2();              
            }

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
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

        private void textBox3_Validating(object sender, CancelEventArgs e)
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

        private void btnregistraopinterno_Click(object sender, EventArgs e)
        {

            contrato.Valor31(textBoxor.Text);
            contrato1.Valor32(textBoxti.Text);
            contrato2.Valor33(textBoxnom.Text);
            contrato3.Valor34(txtcategoria.Text);
            contrato4.Valor35(rtxtdescr.Text);
            contrato5.Valor36(txtsobre.Text);
            contrato6.Valor37(txtxs.Text);
            contrato7.Valor38(txts.Text);
            contrato8.Valor39(txtm.Text);
            contrato9.Valor40(txtl.Text);
            contrato10.Valor41(txtxl.Text);
            contrato11.Valor42(txtxxl.Text);
            contrato12.Valor43(txt3xl.Text);
            contrato13.Valor44(txt4xl.Text);
            contrato14.Valor45(txt5xl.Text);
            contrato15.Valor46(txt6xl.Text);
            contrato16.Valor47(txtcantidadop.Text);
            contrato17.Valor48(textsobre.Text);
            contrato18.Valor49(textxs.Text);
            contrato19.Valor50(texts.Text);
            contrato20.Valor51(textm.Text);
            contrato21.Valor52(textl.Text);
            contrato22.Valor53(textxl.Text);
            contrato23.Valor54(textxxl.Text);
            contrato24.Valor55(text3xl.Text);
            contrato25.Valor56(text4xl.Text);
            contrato26.Valor57(text5xl.Text);
            contrato27.Valor58(text6xl.Text);
            contrato28.Valor59(textcantidadop.Text);
            this.Hide();

        }

        private void dataGridView8_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (MessageBox.Show(" ¡Por favor, seleccionar unicamente OP!" +
                    " ¿ Desea continuar ? ", "Ingresar datos", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)

                {



                    textBox4.Text = dataGridView8.CurrentCell.Value.ToString();

                   // Busquedaop2();
                   // Busquedaopusu();
                    try
                    {
                        
                        DataTable dt = new DataTable();
                        DataRow row;

                        vo.OP=Convert.ToInt32(textBox4.Text);

                        dt = vo.Buscarnop(vo.OP);

                        // vo.OP = Convert.ToInt32(textBoxor.Text);
                        if (dt.Rows.Count == 1)
                        {
                            row = dt.Rows[0];
                            textBoxor.Text = row[0].ToString();
                            textBoxti.Text = row[1].ToString();

                            textBoxnom.Text = row[2].ToString();
                            rtxtdescr.Text = row[3].ToString();
                            txtcategoria.Text = row[4].ToString();
                            txtcantidadop.Text = row[5].ToString();
                            textBox6.Text = row[7].ToString();
                            textBox5.Text = row[6].ToString();
                            txtsobre.Text = row[7].ToString();
                            txtxs.Text = row[8].ToString();
                            txts.Text = row[9].ToString();
                            txtm.Text = row[10].ToString();
                            txtl.Text = row[11].ToString();
                            txtxl.Text = row[12].ToString();
                            txtxxl.Text = row[13].ToString();
                            txt3xl.Text = row[14].ToString();
                            txt4xl.Text = row[15].ToString();
                            txt5xl.Text = row[16].ToString();
                            txt6xl.Text = row[17].ToString();
                           // MessageBox.Show("Registro Encontrado Ok!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                                O.OP = Convert.ToInt32(textBoxor.Text);
                                O.Tiempomodi = Convert.ToDecimal(textBoxti.Text);
                                O.Nombrep = Convert.ToString(textBoxnom.Text);
                                O.Descripcionmodi = Convert.ToString(rtxtdescr.Text);
                                O.Categoriamodi = Convert.ToString(txtcategoria.Text);
                                
                                O.Cantidad = Convert.ToInt32(txtcantidadop.Text);
                                
                                O.Totalmodi = Convert.ToDecimal(0);
                                O.Sobremedida = Convert.ToInt32(txtsobre.Text);

                                O.Xs = Convert.ToInt32(txtxs.Text);
                                O.S = Convert.ToInt32(txts.Text);
                                O.Mm = Convert.ToInt32(txtm.Text);
                                O.L = Convert.ToInt32(txtl.Text);
                                O.Xl = Convert.ToInt32(txtxl.Text);
                                O.Xxl = Convert.ToInt32(txtxxl.Text);
                                O.T3xl = Convert.ToInt32(txt3xl.Text);
                                O.T4xl = Convert.ToInt32(txt4xl.Text);
                                O.T5xl = Convert.ToInt32(txt5xl.Text);
                                O.T6xl = Convert.ToInt32(txt6xl.Text);
                        O.Registrar_opmodi();
                                // txtcantidadop.Text = O.sumaop().ToString();
                               // MessageBox.Show(, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            DataTable dti = new DataTable();
                            DataRow rowi;
                            O.OP = Convert.ToInt32(textBox4.Text);
                            dti = O.Buscarnopinter(O.OP);
                            if (dti.Rows.Count == 1)
                            {
                                rowi = dti.Rows[0];

                                textcantidadop.Text = rowi[5].ToString();
                                //txtcategoria.Text = row[4].ToString();
                                textsobre.Text = rowi[7].ToString();
                                textxs.Text = rowi[8].ToString();
                                texts.Text = rowi[9].ToString();
                                textm.Text = rowi[10].ToString();
                                textl.Text = rowi[11].ToString();
                                textxl.Text = rowi[12].ToString();
                                textxxl.Text = rowi[13].ToString();
                                text3xl.Text = rowi[14].ToString();
                                text4xl.Text = rowi[15].ToString();
                                text5xl.Text = rowi[16].ToString();
                                text6xl.Text = rowi[17].ToString();

                              //  MessageBox.Show("Registro Encontrado Ok!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }

                             

                       
                        
                    }
                    catch (Exception ex)
                    {
                        // MessageBox.Show(ex.Message);
                      //  MessageBox.Show(" ¡N° de OP No Encontrado! ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }



                }
            }
            catch (Exception ex)
            {
               // MessageBox.Show(" ! Registro no encontrado ¡", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //  MessageBox.Show(ex.Message);
            }
        }
      
    
    private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dataGridView8_VisibleChanged(object sender, EventArgs e)
        {
            int o = Convert.ToInt32(textBox10.Text);
            if (o == 0 && textBox10.Text != null)
            {
                dataGridView8.ColumnHeadersVisible = false;
            }

            else

            {
                dataGridView8.ColumnHeadersVisible = true;
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            int o = Convert.ToInt32(textBox10.Text);
            if (o == 0 && textBox10.Text != null)
            {
                dataGridView8.ColumnHeadersVisible = false;
            }

            else

            {
                dataGridView8.ColumnHeadersVisible = true;
            }
        }
    }
}
