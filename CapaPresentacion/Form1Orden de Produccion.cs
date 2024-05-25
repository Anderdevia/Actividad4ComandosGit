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

namespace WindowsFormsApp1
{
    public partial class Form1Orden_de_Produccion : Form
    {
        //variables que conectan a otras Capas
        clsOp O = new clsOp();



        public Form1Orden_de_Produccion()
        {
            InitializeComponent();
           
        }
        private void Form1Orden_de_Produccion_Load(object sender, EventArgs e)
        {
            //llenar  grilla
           
            Cargarlistado1();
            button10.Enabled = false; button9.Enabled = false;
            this.Cursor = Cursors.Default;

        }
        private void Cargarlistado1()
        {


            DataTable dt = new DataTable();
            dt = O.ListadoOp();
            try
            {
                gridViewprendas.Rows.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)

                {
                    gridViewprendas.DefaultCellStyle.Font = new Font("Nirmala UI", 7);
                    gridViewprendas.RowTemplate.Height = 13;
                    gridViewprendas.ColumnHeadersDefaultCellStyle.Font = new Font(gridViewprendas.Font, FontStyle.Bold);
                    gridViewprendas.Rows.Add(dt.Rows[i][0]);
                    gridViewprendas.Rows[i].Cells[0].Value = dt.Rows[i][0].ToString();
                    gridViewprendas.Rows[i].Cells[1].Value = dt.Rows[i][1].ToString();
                    gridViewprendas.Rows[i].Cells[2].Value = dt.Rows[i][2].ToString();
                    gridViewprendas.Rows[i].Cells[3].Value = dt.Rows[i][3].ToString();
                    gridViewprendas.Rows[i].Cells[4].Value = dt.Rows[i][4].ToString();
                    gridViewprendas.Rows[i].Cells[5].Value = dt.Rows[i][5].ToString();
                    gridViewprendas.Rows[i].Cells[6].Value = dt.Rows[i][6].ToString();
                    gridViewprendas.Rows[i].Cells[7].Value = dt.Rows[i][7].ToString();
                    gridViewprendas.Rows[i].Cells[8].Value = dt.Rows[i][8].ToString();
                    gridViewprendas.Rows[i].Cells[9].Value = dt.Rows[i][9].ToString();
                    gridViewprendas.Rows[i].Cells[10].Value = dt.Rows[i][10].ToString();
                    gridViewprendas.Rows[i].Cells[11].Value = dt.Rows[i][11].ToString();
                    gridViewprendas.Rows[i].Cells[12].Value = dt.Rows[i][12].ToString();
                    gridViewprendas.Rows[i].Cells[13].Value = dt.Rows[i][13].ToString();
                    gridViewprendas.Rows[i].Cells[14].Value = dt.Rows[i][14].ToString();
                    gridViewprendas.Rows[i].Cells[15].Value = dt.Rows[i][15].ToString();
                    gridViewprendas.Rows[i].Cells[16].Value = dt.Rows[i][16].ToString();
                    gridViewprendas.Rows[i].Cells[17].Value = dt.Rows[i][17].ToString();
                    gridViewprendas.Rows[i].Cells[18].Value = dt.Rows[i][18].ToString();
                    FreezeBand1(gridViewprendas.Columns[0]);
                


                    Verresul2();
                    // Verresul();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            gridViewprendas.ClearSelection();
        }
        private void validar()
        {


            if (txtop.Text != string.Empty) { button9.Enabled = true;  }
       
        else
          {
        button9.Enabled = false; 
          }
        }
        private void validarr()
        {

            if (txtop.Text != string.Empty 
                & txttiempouni.Text != string.Empty & 
                txtnombreop.Text != string.Empty & 
                txtcategoriaop.Text != string.Empty &
               txtsobre.Text != string.Empty &
               txtxs.Text != string.Empty & 
               txts.Text != string.Empty & 
               txtm.Text != string.Empty & 
               txtl.Text != string.Empty & 
               txtxl.Text != string.Empty & 
               txtxxl.Text != string.Empty & 
               txt3xl.Text != string.Empty &
                txt4xl.Text != string.Empty & 
                txt5xl.Text != string.Empty  & 
                txt6xl.Text != string.Empty)
            { button10.Enabled = true; button9.Enabled = true; }
            else
            {
                button10.Enabled = false; button9.Enabled = false;
            }

        }
       


        public void Limpiar()
        {
            txtop.Clear();
            txttiempouni.Clear();
            txtnombreop.Clear();
            txtcategoriaop.Clear();
            txtsobre.Text="0";
            txtxs.Text = "0";
            txts.Text = "0";
            txtm.Text = "0";
            txtl.Text = "0";
            txtxl.Text = "0";
            txtxxl.Text = "0";
            txt3xl.Text = "0";
            txt4xl.Text = "0";
            txt5xl.Text = "0";
            txt6xl.Text = "0";
            txtop.Focus();
            rtxtdescr.Clear();
            dateTimePicker1.Value = DateTime.Now;

        }
        private void button4_Click(object sender, EventArgs e)
        {
            txtop.Clear();
            txttiempouni.Clear();
            txtnombreop.Clear();
            txtcategoriaop.Clear();
            txtsobre.Clear();
            txtxs.Clear();
            txts.Clear();
            txtm.Clear();
            txtl.Clear();
            txtxl.Clear();
            txtxxl.Clear();
            txt3xl.Clear();
            txt4xl.Clear();
            txt5xl.Clear();
            txt6xl.Clear();
            txtop.Focus();
            dateTimePicker1.Value = DateTime.Now;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataTable dt = O.ListadoOp();
            gridViewprendas.DataSource = dt;
        }



        private void txtsobre_Validating(object sender, CancelEventArgs e)
        {
            if (txtsobre.Text.Trim() == String.Empty)
            {
                errorProvider1.SetError(txtsobre, "Ingrese un valor ");

            }
            else

            {
                errorProvider1.Clear();
            }
        }


       

        private void button3_Click(object sender, EventArgs e)
        {

        }

     
            private void button6_Click(object sender, EventArgs e)
        {
            
          

            this.Close();
           
        }

        private void txtop_TextChanged(object sender, EventArgs e)
        {
            validarr();
        }

        
           

        private void txtcategoriaop_TextChanged(object sender, EventArgs e)
        {
            validarr();
        }

        private void txttiempouni_TextChanged(object sender, EventArgs e)
        {
            validarr();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtnombreop_TextChanged(object sender, EventArgs e)
        {
            validarr();
        }

        private void txtsobre_TextChanged(object sender, EventArgs e)
        {
            validarr();
        }

        private void txtxs_TextChanged(object sender, EventArgs e)
        {
            validarr();
        }

        private void txts_TextChanged(object sender, EventArgs e)
        {
            validarr();
        }

        private void txtm_TextChanged(object sender, EventArgs e)
        {
            validarr();
        }

        private void txtl_TextChanged(object sender, EventArgs e)
        {
            validarr();
        }

        private void txtxl_TextChanged(object sender, EventArgs e)
        {
            validarr();
        }

        private void txtxxl_TextChanged(object sender, EventArgs e)
        {
            validarr();
        }

        private void txt3xl_TextChanged(object sender, EventArgs e)
        {
            validarr();
        }

        private void txt4xl_TextChanged(object sender, EventArgs e)
        {
            validarr();
        }

        private void txt5xl_TextChanged(object sender, EventArgs e)
        {
            validarr();
        }

        private void txt6xl_TextChanged(object sender, EventArgs e)
        {
            validarr();
        }

        private void button10_Click(object sender, EventArgs e)
        {

            int canti, Xs, S, Mm, L, Xl, Xxl, T3xl, T4xl, T5xl, T6xl, Sobremedida;
 try
            {
            Sobremedida = Convert.ToInt32(txtsobre.Text);
            Xs = Convert.ToInt32(txtxs.Text);
            S = Convert.ToInt32(txts.Text);
            Mm = Convert.ToInt32(txtm.Text);
            L = Convert.ToInt32(txtl.Text);
            Xl = Convert.ToInt32(txtxl.Text);
            Xxl = Convert.ToInt32(txtxxl.Text);
            T3xl = Convert.ToInt32(txt3xl.Text);
            T4xl = Convert.ToInt32(txt4xl.Text);
            T5xl = Convert.ToInt32(txt5xl.Text);
            T6xl = Convert.ToInt32(txt6xl.Text);
            canti = Sobremedida + Xs + S + Mm + L + Xl + Xxl + T3xl + T4xl + T5xl + T6xl;
           
                O.OP = Convert.ToInt32(txtop.Text);
                O.Tiempo = Convert.ToDecimal(txttiempouni.Text);
                O.NombrePrendas = txtnombreop.Text;
                O.Descrpcion = rtxtdescr.Text;
                O.Categoriaop = txtcategoriaop.Text;
                O.Cantidad = Convert.ToInt32(canti);
                O.Total = Convert.ToDecimal(0);
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
                O.Fecha_de_registro = dateTimePicker1.Value;





                MessageBox.Show(O.Registrar_op(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtcantidadop.Text = O.sumaop().ToString();
                Cargarlistado1();
                Verresul2();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gridViewprendas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

          
        }

        private void gridViewprendas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = gridViewprendas.CurrentCell.Value.ToString();

            try
            {
                DataTable dt = new DataTable();
                DataRow row;
                O.OP = Convert.ToInt32(textBox1.Text);
                dt = O.Buscarnop(O.OP);
                if (dt.Rows.Count == 1)
                {
                    row = dt.Rows[0];
                    txtop.Text = row[0].ToString();
                    txttiempouni.Text = row[1].ToString();
                    txtnombreop.Text = row[2].ToString();
                    rtxtdescr.Text = row[3].ToString();
                    txtcantidadop.Text = row[5].ToString();
                    txtcategoriaop.Text = row[4].ToString();
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


                   // MessageBox.Show("Registro Encontrado Ok !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   // Cargarlistado1();
                }
                else
                {
                    MessageBox.Show(" OP no Existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //Limpiar();
                }
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message);
            }
           // gridViewprendas.ClearSelection();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int canti, Xs, S, Mm, L, Xl, Xxl, T3xl, T4xl, T5xl, T6xl, Sobremedida;

            try
            { Sobremedida = Convert.ToInt32(txtsobre.Text);
            Xs = Convert.ToInt32(txtxs.Text);
            S = Convert.ToInt32(txts.Text);
            Mm = Convert.ToInt32(txtm.Text);
            L = Convert.ToInt32(txtl.Text);
            Xl = Convert.ToInt32(txtxl.Text);
            Xxl = Convert.ToInt32(txtxxl.Text);
            T3xl = Convert.ToInt32(txt3xl.Text);
            T4xl = Convert.ToInt32(txt4xl.Text);
            T5xl = Convert.ToInt32(txt5xl.Text);
            T6xl = Convert.ToInt32(txt6xl.Text);
            canti = Sobremedida + Xs + S + Mm + L + Xl + Xxl + T3xl + T4xl + T5xl + T6xl;
           
                O.OP = Convert.ToInt32(txtop.Text);
                O.Tiempo = Convert.ToDecimal(txttiempouni.Text);
                O.NombrePrendas = txtnombreop.Text;
                O.Descrpcion = rtxtdescr.Text;
                O.Categoriaop = txtcategoriaop.Text;
                O.Cantidad = Convert.ToInt32(canti);
                O.Total = Convert.ToDecimal(0);
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
                O.Fecha_de_registro = dateTimePicker1.Value;

                MessageBox.Show(O.Actualizarop(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
                Cargarlistado1();
                Verresul2();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private static void FreezeBand(DataGridViewBand band)
        {
            band.Frozen = true;
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.BackColor = Color.White;
            band.DefaultCellStyle = style;
        }
        private static void FreezeBand1(DataGridViewBand band)
        {
            band.Frozen = true;
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.BackColor = Color.LightGray;
            band.DefaultCellStyle = style;
        }

        private void Verresul2()
        {
            int baser = 0;
            int baser1 = 0;
            int resultado = 0;

            double total = 0;
            foreach (DataGridViewRow row in gridViewprendas.Rows)
            {

                total += Convert.ToDouble(row.Cells["Column2"].Value);
                row.Cells[gridViewprendas.Columns["Column19"].Index].Value = (Convert.ToDecimal(row.Cells[gridViewprendas.Columns["Column6"].Index].Value) * Convert.ToDecimal(row.Cells[gridViewprendas.Columns["Column2"].Index].Value));
            }
            textBox7.Text = total.ToString("N");
            textBox9.Text = gridViewprendas.RowCount.ToString();
            //   Convert.ToString(ded.ToString("00.0"));
            decimal sum = 0;
            for (int i = 0; i < gridViewprendas.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(gridViewprendas.Rows[i].Cells["Column6"].Value);
            }
            textBox8.Text = sum.ToString("N");
            // baser = Convert.ToInt32(textBox9.Text);
            // baser1 = Convert.ToInt32(textBox5.Text);
            // resultado = baser + baser1;
            //txtiddope.Text = Convert.ToString(resultado);

        }
        
        private void buscarop()
        {
            try
            {
                DataTable dt = new DataTable();
             
                O.OP = Convert.ToInt32(txtbuscarop.Text);
                dt = O.Buscarnop(O.OP);
                gridViewprendas.Rows.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    gridViewprendas.Rows.Add(dt.Rows[i][0]);
                    gridViewprendas.Rows[i].Cells[0].Value = dt.Rows[i][0].ToString();
                    gridViewprendas.Rows[i].Cells[1].Value = dt.Rows[i][1].ToString();
                    gridViewprendas.Rows[i].Cells[2].Value = dt.Rows[i][2].ToString();
                    gridViewprendas.Rows[i].Cells[3].Value = dt.Rows[i][3].ToString();
                    gridViewprendas.Rows[i].Cells[4].Value = dt.Rows[i][4].ToString();
                    gridViewprendas.Rows[i].Cells[5].Value = dt.Rows[i][5].ToString();
                    gridViewprendas.Rows[i].Cells[6].Value = dt.Rows[i][6].ToString();
                    gridViewprendas.Rows[i].Cells[7].Value = dt.Rows[i][7].ToString();
                    gridViewprendas.Rows[i].Cells[8].Value = dt.Rows[i][8].ToString();
                    gridViewprendas.Rows[i].Cells[9].Value = dt.Rows[i][9].ToString();
                    gridViewprendas.Rows[i].Cells[10].Value = dt.Rows[i][10].ToString();
                    gridViewprendas.Rows[i].Cells[11].Value = dt.Rows[i][11].ToString();
                    gridViewprendas.Rows[i].Cells[12].Value = dt.Rows[i][12].ToString();
                    gridViewprendas.Rows[i].Cells[13].Value = dt.Rows[i][13].ToString();
                    gridViewprendas.Rows[i].Cells[14].Value = dt.Rows[i][14].ToString();
                    gridViewprendas.Rows[i].Cells[15].Value = dt.Rows[i][15].ToString();
                    gridViewprendas.Rows[i].Cells[16].Value = dt.Rows[i][16].ToString();
                    gridViewprendas.Rows[i].Cells[17].Value = dt.Rows[i][17].ToString();

                    gridViewprendas.Rows[i].Cells[18].Value = dt.Rows[i][18].ToString();

                    FreezeBand1(gridViewprendas.Columns[0]);
                    gridViewprendas.Columns[1].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                    gridViewprendas.Columns[2].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                    gridViewprendas.Columns[3].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                    gridViewprendas.Columns[4].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                    gridViewprendas.Columns[5].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                    gridViewprendas.Columns[6].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                    gridViewprendas.Columns[7].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                    gridViewprendas.Columns[8].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                    gridViewprendas.Columns[9].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                    gridViewprendas.Columns[10].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                    gridViewprendas.Columns[11].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                    gridViewprendas.Columns[12].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                    gridViewprendas.Columns[13].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                    gridViewprendas.Columns[14].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                    gridViewprendas.Columns[15].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                    gridViewprendas.Columns[16].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                    gridViewprendas.Columns[17].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                    gridViewprendas.Columns[18].DefaultCellStyle.BackColor = Color.WhiteSmoke;

                    Verresul2();
                    // Verresul();

                }
            }
            catch (Exception ex)
            { 
                // MessageBox.Show(ex.Message);
            }
            gridViewprendas.ClearSelection();
        }

        private void txtbuscarop_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                buscarop();
            }
            else
            {
               // Cargarlistado1();
            }
        }

        private void txtbuscarop_TextChanged(object sender, EventArgs e)
        {
            try
            {

                // (gridViewprendas.DataSource as DataTable).DefaultView.RowFilter = string.Format("Op = '{0}'", txtbuscarop.Text);
              
                DataTable dt = new DataTable();
                dt = O.ListadoOp();
//
              (dt).DefaultView.RowFilter = string.Format("Column1 = '{0}'", txtbuscarop.Text);



            }
            catch (Exception ex)
            {
               Cargarlistado1();//Verresul2();
                // MessageBox.Show(ex.Message);
                //MessageBox.Show("Solo se admiten el valor de la OP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // label2.Text = "REGISTRO NO ENCONTRADO";
            }

        }

        private void label56_Click(object sender, EventArgs e)
        {

        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void txtbuscarop_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void txtop_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txttiempouni.Focus();
            }
            else
            {
            }
        }

        private void txttiempouni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
               txtcategoriaop .Focus();
            }
            else
            {
            }
        }

        private void txtcategoriaop_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtnombreop.Focus();
            }
            else
            {
            }
        }

        private void txtnombreop_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
               rtxtdescr.Focus();
            }
            else
            {
            }
        }

        private void rtxtdescr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtsobre.Focus();
            }
            else
            {
            }
        }

        private void txtsobre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
            {
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                txtxs.Focus();
            }
            else
            {
            }
        }

        private void txtxs_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == 13)
            {
                txts.Focus();
            }
            else
            {
            }
        }

        private void txts_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                txtm.Focus();
            }
            else
            {
            }
        }

        private void txtm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                txtl.Focus();
            }
            else
            {
            }
        }

        private void txtl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                txtxl.Focus();
            }
            else
            {
            }
        }

        private void txtxl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                txtxxl.Focus();
            }
            else
            {
            }
        }

        private void txtxxl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                txt3xl.Focus();
            }
            else
            {
            }
        }

        private void txt3xl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                txt4xl.Focus();
            }
            else
            {
            }
        }

        private void txt4xl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
               txt5xl .Focus();
            }
            else
            {
            }
        }

        private void txt5xl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                txt6xl.Focus();
            }
            else
            {
            }
        }

        private void txt6xl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
               button10.Focus();
            }
            else
            {
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gridViewprendas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int a = 0;
                try
                {
                    textBox1.Text = gridViewprendas.CurrentCell.Value.ToString();
                    a = Convert.ToInt32(textBox1.Text);
                    if (MessageBox.Show(" ¿ Desea eliminar la OP " + a + "?", "Eliminar ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {


                        O.OP = Convert.ToInt32(textBox1.Text);
                        O.eliminarop();
                        Cargarlistado1();
                        Verresul2();
                        // Limpiar();
                    }
                }

                catch (Exception ex)
                {
                   // MessageBox.Show(ex.Message);
                }
            }
        }

        private void txtbuscarop_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void gridViewprendas_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            gridViewprendas.EnableHeadersVisualStyles = false;
            DataGridViewColumn dataGridViewColumn = gridViewprendas.Columns[0];
            dataGridViewColumn.HeaderCell.Style.BackColor = Color.LightGray;
            dataGridViewColumn.HeaderCell.Style.ForeColor = Color.Black;

            Color cl = dataGridViewColumn.HeaderCell.Style.BackColor;
            //or   
            Color cl2 = gridViewprendas.Columns[0].HeaderCell.Style.BackColor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                //  re.Op = Convert.ToInt32(txtseletop.Text);
                if (MessageBox.Show("¿ Desea eliminar todos los registros ?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    MessageBox.Show(O.Eliminaropimoditotal(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   

                    Cargarlistado1();
                    txtbuscarop.Clear();
                    gridViewprendas.ClearSelection();
                    {
                        button1.Enabled = false;
                    }
                    if (gridViewprendas.Rows.Count > 0)
                    {
                        button1.Enabled = true;
                    }
                    Verresul2();
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

            gridViewprendas.ClearSelection();
        }

        private void gridViewprendas_VisibleChanged(object sender, EventArgs e)
        {
            gridViewprendas.ClearSelection();
            {
                gridViewprendas.Enabled = false;
            }
            if (gridViewprendas.Rows.Count > 0)
            {
                gridViewprendas.Enabled = true;
            }
        }

        private void gridViewprendas_Validating(object sender, CancelEventArgs e)
        {
            gridViewprendas.ClearSelection();
            {
                gridViewprendas.Enabled = false;
            }
            if (gridViewprendas.Rows.Count > 0)
            {
                gridViewprendas.Enabled = true;
            }

        }
    }
}
