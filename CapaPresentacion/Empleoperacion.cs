using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocios;
using CapaEntidades;
using System.Data.SqlClient;
using System.Configuration;
using System.Globalization;
using System.Drawing.Drawing2D;
using CapaPresentacion;
using WindowsFormsApp1;

namespace WindowsFormsApp1
{
    public partial class Empleoperacion : Form, Ioperacion
    {

        
        public Empleoperacion()
        {
            InitializeComponent();




        }
      

        ClsReglasEmpleados Reglas = new ClsReglasEmpleados();
        ClsTBL_EMPLEADOS TblAtri = new ClsTBL_EMPLEADOS();

        int Listado = 0;
        int Listado1 = 0;
        Adoperacion re = new Adoperacion();
        clsopp O = new clsopp();
        Clsopes S = new Clsopes();
        Clsopusu U = new Clsopusu();
        Clsopemple E = new Clsopemple();

        public Ioperafin contratoopa { get; set; }
        public Ioperafin contrato1opa { get; set; }
        public Ioperafin contrato2opa { get; set; }
        public Ioperafin contrato3opa { get; set; }
        public Ioperafin contrato4opa { get; set; }
        public Ioperafin contrato5opa { get; set; }
        public Ioperafin contrato6opa { get; set; }
        public Ioperafin contrato7opa { get; set; }
        public Ioperafin contrato8opa { get; set; }
        public Ioperafin contrato9opa { get; set; }
        public Ioperafin contrato10opa { get; set; }
        public Ioperafin contrato11opa { get; set; }
        public Ioperafin contrato12opa { get; set; }
        public Ioperafin contrato13opa { get; set; }
        public Ioperafin contrato14opa { get; set; }
        public Ioperafin contrato15opa { get; set; }
        public Ioperafin contrato16opa { get; set; }
        public Ioperafin contrato17opa { get; set; }
        public Ioperafin contrato18opa { get; set; }
        public Ioperafin contrato19opa { get; set; }
        private void Cargarlistadomodifi()

        {
            try
            {


                using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["CnnORDEN"].ConnectionString))
                {
                    if (cn.State == ConnectionState.Closed)
                        cn.Open();

                    using (SqlDataAdapter da = new SqlDataAdapter("select * from operacionausuario", cn))
                    {
                        DataTable dt1 = new DataTable("operacionausuario");

                        
                        dataGridView8.RowTemplate.Height = 13;

                        da.Fill(dt1);

                        dataGridView8.DataSource = dt1;

                        Verresul4();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataGridView8.ClearSelection();
            //Verresul();

        }
        private void listamodi()

        {

            try
            {


                using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["CnnORDEN"].ConnectionString))
                {
                    if (cn.State == ConnectionState.Closed)
                        cn.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter("select * from operacionausuario", cn))
                        da.Fill(dtm);
                    dataGridView8.DataSource = dtm;
                   // DataGridViewColumn column = dataGridView8.Columns[0];
                    //  column.Visible = false;
                    dataGridView8.DefaultCellStyle.Font = new Font("Bookshelf Symbol", 7);
                    dataGridView8.RowTemplate.Height = 13;
                    dataGridView8.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView8.Font, FontStyle.Bold); // negrita en titulos
                    dataGridView8.Columns[0].HeaderText = "Id";
                    //DataGridViewColumn column1 = dataGridView8.Columns[0];
                  //  column1.Visible = false;
                    dataGridView8.Columns[0].Width = 68;
                    dataGridView8.Columns[1].HeaderText = "OP";
                    dataGridView8.Columns[1].Width = 70;
                    dataGridView8.Columns[2].HeaderText = "Id Prenda";
                    dataGridView8.Columns[2].Width = 100;
                    DataGridViewColumn column = dataGridView8.Columns[2];
                    column.Visible = false;
                    dataGridView8.Columns[3].HeaderText = "Prenda";
                    dataGridView8.Columns[3].Width = 152;
                    dataGridView8.Columns[4].HeaderText = "Operación";
                    dataGridView8.Columns[4].Width = 150;
                    dataGridView8.Columns[5].HeaderText = "Categoria";
                    dataGridView8.Columns[5].Width = 110;
                    dataGridView8.Columns[6].HeaderText = "Descripción";
                    dataGridView8.Columns[6].Width = 110;
                    dataGridView8.Columns[7].HeaderText = "Tiempo";
                    dataGridView8.Columns[7].Width = 80;
                    dataGridView8.Columns[8].HeaderText = "Cantidad";
                    dataGridView8.Columns[8].Width = 80;
                    dataGridView8.Columns[9].HeaderText = "Total";
                    dataGridView8.Columns[9].Width = 80;
                    dataGridView8.Columns[10].HeaderText = "Sobremedida";
                    dataGridView8.Columns[10].Width = 82;
                    dataGridView8.Columns[11].HeaderText = "XS";
                    dataGridView8.Columns[11].Width = 30;
                    dataGridView8.Columns[12].HeaderText = "S";
                    dataGridView8.Columns[12].Width = 30;
                    dataGridView8.Columns[13].HeaderText = "M";
                    dataGridView8.Columns[13].Width = 30;
                    dataGridView8.Columns[14].HeaderText = "L";
                    dataGridView8.Columns[14].Width = 30;
                    dataGridView8.Columns[15].HeaderText = "XL";
                    dataGridView8.Columns[15].Width = 30;
                    dataGridView8.Columns[16].HeaderText = "XXL";
                    dataGridView8.Columns[16].Width = 30;
                    dataGridView8.Columns[17].HeaderText = "3XL";
                    dataGridView8.Columns[17].Width = 30;
                    dataGridView8.Columns[18].HeaderText = "4XL";
                    dataGridView8.Columns[18].Width = 30;
                    dataGridView8.Columns[19].HeaderText = "5XL";
                    dataGridView8.Columns[19].Width = 30;
                    dataGridView8.Columns[20].HeaderText = "6XL";
                    dataGridView8.Columns[20].Width = 30;
                    dataGridView8.Columns[21].HeaderText = "6XL";
                    dataGridView8.Columns[21].Width = 30;

                    FreezeBand(dataGridView8.Columns[1]);
                    FreezeBand1(dataGridView8.Columns[3]);



               
                  
                    Verresul4();

                    // color();
                    // colorazul();
                    // Verresul2();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataGridView8.ClearSelection();
            //color();

            //Verresul();

        }
   
        private void Verresul4()
        {
            int baser = 0;
            int baser1 = 0;
            int resultado = 0;

            double total = 0;
            foreach (DataGridViewRow row in dataGridView8.Rows)
            {

                total += Convert.ToDouble(row.Cells[7].Value) * Convert.ToDouble(row.Cells[8].Value);
                row.Cells[dataGridView8.Columns[9].Index].Value = (Convert.ToDecimal(row.Cells[dataGridView8.Columns[7].Index].Value) * Convert.ToDecimal(row.Cells[dataGridView8.Columns[8].Index].Value));

            }
            textBox17.Text = total.ToString("N");
            textBox10.Text = dataGridView8.RowCount.ToString();
            //   Convert.ToString(ded.ToString("00.0"));
            decimal sum = 0;
            for (int i = 0; i < dataGridView8.Rows.Count; ++i)
            {
                sum += Convert.ToDecimal(dataGridView8.Rows[i].Cells[8].Value);
            }
           // baser = Convert.ToInt32(textBox10.Text);
           // baser1 = Convert.ToInt32(textBox5.Text);
           // resultado = baser + baser1;
          //  txtiddope.Text = Convert.ToString(resultado);
            textBox16.Text = sum.ToString("N");
            Algoritmomodi();
           // color();
           // colorazul();
        }
       
        private void label3_Click(object sender, EventArgs e)
        {

        }
       
        DataTable dt = new DataTable("operacemple");
        DataTable dtm = new DataTable(" operacionausuario");

        private void Empleoperacion_Load(object sender, EventArgs e)
        {
            
            Cargarlistadomodifi();
            listamodi();
           
            
        
            validar1();
           
            Verresul4();
       
            button3.Enabled = false;
            button9.Enabled = false;
           
           

           


        }

        private void button3_Click(object sender, EventArgs e)
        {
            U.IDopera = Convert.ToInt32(lblregi2.Text);
            U.Sobremedidao = Convert.ToInt32(textsobre.Text);
            U.Xso = Convert.ToInt32(textxs.Text);
            U.So = Convert.ToInt32(texts.Text);
            U.Mmo = Convert.ToInt32(textm.Text);
            U.Lo = Convert.ToInt32(textl.Text);
            U.Xlo = Convert.ToInt32(textxl.Text);
            U.Xxlo = Convert.ToInt32(textxxl.Text);
            U.T3xlo = Convert.ToInt32(text3xl.Text);
            U.T4xlo = Convert.ToInt32(text4xl.Text);
            U.T5xlo = Convert.ToInt32(text5xl.Text);
            U.T6xlo = Convert.ToInt32(text6xl.Text);
            U.Cantidadpp = Convert.ToInt32(textcantidadop.Text);



            Algoritmomodi();
            U.Actualizaropusu();
            btnregistraopinterno.Enabled = false;
            btnregistraopinterno.Enabled = false;
          

            Cargarlistadomodifi();
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
                    label86.Text = "";
                    row = dt.Rows[0];
                    label59.Text = row[1].ToString();
                    txtcat.Text = row[6].ToString();
                    txtnombrpren.Text = row[4].ToString();
                    rtxtdescr.Text = row[5].ToString();
                    txtsobre.Text = row[9].ToString();
                    txtxs.Text = row[10].ToString();
                    txts.Text = row[11].ToString();
                    txtm.Text = row[12].ToString();
                    txtl.Text = row[13].ToString();
                    txtxl.Text = row[14].ToString();
                    txtxxl.Text = row[15].ToString();
                    txt3xl.Text = row[16].ToString();
                    txt4xl.Text = row[17].ToString();
                    txt5xl.Text = row[18].ToString();
                    txt6xl.Text = row[19].ToString();
                    txtcantidadop.Text = row[7].ToString();
                   
                    // Verresul();
                }
                string y, l;
                y = label59.Text;
                l = label86.Text;

                label86.Text = String.Format(l + "OP : " + y);
                if (label86.Visible == false)
                {
                    btnregistraopinterno.Enabled = false;
                }


                else
                {
                    lblverno.Text = Convert.ToString("¡Registro de ID no existe!");
                    // MessageBox.Show("Registro de Orden de Produccion no Existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Solo se admiten el valor de la OP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

          

            //Verresul();

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

                    lblregi2.Text = row[0].ToString();

                    label49.Text = row[4].ToString();

                    textsobre.Text = row[9].ToString();
                    textxs.Text = row[10].ToString();
                    texts.Text = row[11].ToString();
                    textm.Text = row[12].ToString();
                    textl.Text = row[13].ToString();
                    textxl.Text = row[14].ToString();
                    textxxl.Text = row[15].ToString();
                    text3xl.Text = row[16].ToString();
                    text4xl.Text = row[17].ToString();
                    text5xl.Text = row[18].ToString();
                    text6xl.Text = row[19].ToString();
                    textcantidadop.Text = row[7].ToString();
                    // Verresul();
                    lblverno.Text = "";
                }


                else
                {
                    label49.Text = Convert.ToString("¡Registro de ID no existe!");
                    // MessageBox.Show("Registro de Orden de Produccion no Existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Solo se admiten el valor de la OP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

           

            //Verresul();

        }
       
        private void txtop_KeyPress(object sender, KeyPressEventArgs e)
        {
            //  botonenter = true;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;

            }

            if (e.KeyChar == 13)
            {
                txtop.Focus();

              

            }
            else
            {
                lblverno.Text = Convert.ToString("");
               
                //  lblverno.Text = Convert.ToString("");

               
                // timer2.Start();

            }
        }
       
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (MessageBox.Show(" ¡ Por favor, tenga en cuenta seleccionar unicamente el Id de la operación !" +
                    " ¿ Está seguro que desea continuar ? ", "AGREGAR OPERACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)

                {

                   




                 //   txtidperac.Text = dataGridView1.CurrentCell.Value.ToString();
                    label86.Text = "";
                    Busquedaop2();



                    //   MessageBox.Show("Registro Encontrado Ok...!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    U.Opp1 = Convert.ToInt32(txtop.Text);
                    U.IDprendadd = Convert.ToInt32(txtidprenda.Text);
                    U.Nombrepren = txtnombrepren.Text;
                    //  O.Totalpp = Convert.ToInt32(0);
                    U.IDopera = Convert.ToInt32(txtidperac.Text);
                    U.Nombreoperpp = txtnombrpren.Text;
                    U.Tiempopp = Convert.ToDecimal(txtcat.Text);
                    U.Totalpp = Convert.ToDecimal("00.00");

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
                    // txtcantidadop.Text = U.sumaop().ToString();
                    MessageBox.Show(U.Registrarusu(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    label86.Visible = true;
                    lblinter.Visible = true;
                    //dateT1.Value = Convert.ToDateTime(row[4].ToString());
                    //   MessageBox.Show("Registro Encontrado Ok...!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Busquedaopusu();
                 
                    //txtnupe2.Text = dataopb.CurrentCell.Value.ToString();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(" ! Registro no encontrado ¡", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
              //  MessageBox.Show(ex.Message);
            }
        }

      

      //  private void dataGridView1_Click(object sender, EventArgs e)
       // {
        //    if (dataGridView1.Rows.Count > 0)
        //    {
        //        dataGridView1.Rows[dataGridView1.CurrentRow.Index].Selected = true;
               
       //     }
       // }
       

        private void Sumains()
        {
            try
            {
                int Sobremedida, Xs, S, Mm, L, Xl, Xxl, T3xl, T4xl, T5xl, T6xl;

                Sobremedida = Convert.ToInt32(textsobre.Text);
                Xs = Convert.ToInt32(textxs.Text);
                S = Convert.ToInt32(texts.Text);
                Mm = Convert.ToInt32(textm.Text);
                L = Convert.ToInt32(textl.Text);
                Xl = Convert.ToInt32(textxl.Text);
                Xxl = Convert.ToInt32(textxxl.Text);
                T3xl = Convert.ToInt32(text3xl.Text);
                T4xl = Convert.ToInt32(text4xl.Text);
                T5xl = Convert.ToInt32(text5xl.Text);
                T6xl = Convert.ToInt32(text6xl.Text);

                int resultado1;
                resultado1 = Sobremedida + Xs + S + Mm + L + Xl + Xxl + T3xl + T4xl + T5xl + T6xl;
                textcantidadop.Text = Convert.ToString(resultado1);
                // Cargarlistado3();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Sumains2()
        {
            try
            {
                int Sobremedida, Xs, S, Mm, L, Xl, Xxl, T3xl, T4xl, T5xl, T6xl;

                Sobremedida = Convert.ToInt32(teaxtsobre.Text);
                Xs = Convert.ToInt32(teaxtxs.Text);
                S = Convert.ToInt32(teaxts.Text);
                Mm = Convert.ToInt32(teaxtm.Text);
                L = Convert.ToInt32(teaxtl.Text);
                Xl = Convert.ToInt32(teaxtxl.Text);
                Xxl = Convert.ToInt32(teaxtxxl.Text);
                T3xl = Convert.ToInt32(teaxt3xl.Text);
                T4xl = Convert.ToInt32(teaxt4xl.Text);
                T5xl = Convert.ToInt32(teaxt5xl.Text);
                T6xl = Convert.ToInt32(teaxt6xl.Text);

                int resultado2;
                resultado2 = Sobremedida + Xs + S + Mm + L + Xl + Xxl + T3xl + T4xl + T5xl + T6xl;
                teaxtcantidadop.Text = Convert.ToString(resultado2);
                // Cargarlistado3();
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            Sumains();
            Sumains2();
        }

        private void teaxtsobre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //  botonenter = true;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;

            }

            if (e.KeyChar == 13)
            {
                txtop.Focus();
                timer2.Stop();


            }
            else
            {
                // Cargarlistado1();
                //  lblverno.Text = Convert.ToString("");

                timer2.Start();
                // timer2.Start();
                // lblverno.Text = Convert.ToString("");
            }
        }

        private void teaxtxs_KeyPress(object sender, KeyPressEventArgs e)
        {
            //  botonenter = true;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;

            }

            if (e.KeyChar == 13)
            {
                teaxtxs.Focus();
                timer2.Stop();


            }
            else
            {
                // Cargarlistado1();
                //  lblverno.Text = Convert.ToString("");

                timer2.Start();
                // timer2.Start();
                // lblverno.Text = Convert.ToString("");
            }
        }

        private void teaxts_KeyPress(object sender, KeyPressEventArgs e)
        {
            //  botonenter = true;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;

            }

            if (e.KeyChar == 13)
            {
                teaxts.Focus();
                timer2.Stop();


            }
            else
            {
                // Cargarlistado1();
                //  lblverno.Text = Convert.ToString("");

                timer2.Start();
                // timer2.Start();
                // lblverno.Text = Convert.ToString("");
            }
        }

        private void textsobre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;

            }

            if (e.KeyChar == 13)
            {
                textxs.Focus();
                // timer2.Stop();
                timer2.Start();


            }
            else
            {
                // Cargarlistado1();
                //  lblverno.Text = Convert.ToString("");
                timer2.Stop();
                // timer2.Start();
                // timer2.Start();
                // lblverno.Text = Convert.ToString("");
            }
        }

        private void textxs_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;

            }

            if (e.KeyChar == 13)
            {
                texts.Focus();
                // timer2.Stop();
                timer2.Start();

            }
            else
            {
                // Cargarlistado1();
                //  lblverno.Text = Convert.ToString("");
                timer2.Stop();
                //timer2.Start();
                // timer2.Start();
                // lblverno.Text = Convert.ToString("");
            }
        }

        private void texts_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;

            }

            if (e.KeyChar == 13)
            {
                textm.Focus();
                //   timer2.Stop();
                timer2.Start();

            }
            else
            {
                // Cargarlistado1();
                //  lblverno.Text = Convert.ToString("");
                timer2.Stop();

                // timer2.Start();
                // lblverno.Text = Convert.ToString("");
            }
        }

        private void textsobre_MouseLeave(object sender, EventArgs e)
        {
            Sumains();
        }

        private void textxs_MouseLeave(object sender, EventArgs e)
        {
            Sumains();
        }

        private void texts_MouseLeave(object sender, EventArgs e)
        {
            Sumains();
        }

        private void textm_MouseLeave(object sender, EventArgs e)
        {
            Sumains();
        }

        private void txtcat_TextChanged(object sender, EventArgs e)
        {
            validar1();
        }

       
        private void Algoritmomodi()
        {

            double ser1, resu1, lo1, ter1, cant1, ded1, min1, k1;
            double asu1 = 0;
            int asui1;

            min1 = Convert.ToDouble(textBox17.Text);

            label81.Text = Convert.ToString(min1);

            cant1 = Convert.ToDouble(label81.Text);
            resu1 = cant1 / 60;

            mm1.Text = Convert.ToString(asu1.ToString("0"));


            if (cant1 >= 60)
            {
                hh1.Text = Convert.ToString(Math.Round(cant1 / (1 * 60)));
                //label9.Text = Convert.ToString(cant);
                ter1 = Convert.ToDouble(Math.Round(cant1 / (1 * 60)));
                asui1 = Convert.ToInt32(ter1);
                // ret = ret += asu;

                //double d = 0.00e0;
                // label4.Text = Convert.ToString(ter.ToString("0"));
                ser1 = Convert.ToDouble(Math.Round(cant1 - ter1));

                //char primeraLetra = ter[3];
                //int codigo = (int)primeraLetra;





                lo1 = 60 * asui1;  //2,5  =  2
                asu1 = cant1 - lo1;
                ded1 = 60 + (cant1 - lo1);



                label84.Text = Convert.ToString(asu1.ToString("0"));
                string t, r;
                //label10.Text = Convert.ToString(lo);
                //label10.Text = Convert.ToString(lo.ToString("{ 0:R}"));
                if (asu1 < 0)//valor positivo
                {
                    //label9.Text = (""); lbltiempounico.Text = ("");
                    k1 = (Math.Round(cant1 / (1 * 60) )-1);
                    hh1.Text = Convert.ToString(k1.ToString("0"));
                    mm1.Text = Convert.ToString(ded1.ToString("0"));
                }
                if (asu1 > 0)
                {
                    //  label13.Text = (""); label15.Text = ("");
                    mm1.Text = Convert.ToString(asu1.ToString("0"));
                   k1 = (Math.Round(cant1 / (1 * 60)));

                    t = Convert.ToString(k1.ToString("N"));

                    r = mm1.Text;
                    textBox18.Text = Convert.ToString(t + "," + r);
                    hh1.Text = Convert.ToString(k1.ToString("N"));

                }
            }

            else
            {

                mm1.Text = Convert.ToString(cant1);
                hh1.Text = Convert.ToString(0);


            }
        }
      
        private void Algoritmo2()
        {
            try
            {
                double ser2, resu2, lo2, ter2, cant2, ded2, k1, mmk2, mmk3;
                double asu2 = 0;
                int asui2;

                mmk2 = Convert.ToDouble(txtcat.Text);
                mmk3 = Convert.ToDouble(teaxtcantidadop.Text);

                textBox22.Text = Convert.ToString(mmk2 * mmk3);

                label95.Text = Convert.ToString(textBox22.Text);

                cant2 = Convert.ToDouble(label95.Text);
                resu2 = cant2 / 60;

                lblmmk2.Text = Convert.ToString(asu2.ToString("0"));
                //string t, r;
                string m, n;
                if (cant2 >= 60)
                {
                    lblhh2.Text = Convert.ToString(Math.Round(cant2 / (1 * 60)));
                    //label9.Text = Convert.ToString(cant);
                    ter2 = Convert.ToDouble(Math.Round(cant2 / (1 * 60)));
                    asui2 = Convert.ToInt32(ter2);
                    // ret = ret += asu;

                    //double d = 0.00e0;
                    // label4.Text = Convert.ToString(ter.ToString("0"));
                    ser2 = Convert.ToDouble(Math.Round(cant2 - ter2));

                    //char primeraLetra = ter[3];
                    //int codigo = (int)primeraLetra;





                    lo2 = 60 * asui2;  //2,5  =  2
                    asu2 = cant2 - lo2;
                    ded2 = 60 + (cant2 - lo2);



                    lblll92.Text = Convert.ToString(asu2.ToString("0"));
                    string t, r;

                    //label10.Text = Convert.ToString(lo);
                    //label10.Text = Convert.ToString(lo.ToString("{ 0:R}"));
                    if (asu2 < 0)//valor positivo
                    {
                        //label9.Text = (""); lbltiempounico.Text = ("");
                        lblhh2.Text = Convert.ToString(Math.Round(cant2 / (1 * 60)) - 1);
                        lblmmk2.Text = Convert.ToString(ded2.ToString("00"));


                    }
                    if (asu2 > 0)
                    {

                        //  label13.Text = (""); label15.Text = ("");
                        lblmmk2.Text = Convert.ToString(asu2.ToString("0"));
                        lblhh2.Text = Convert.ToString(Math.Round(cant2 / (1 * 60)));





                        //j = Convert.ToString(lblhh2.Text);
                        // k = Convert.ToString(lblmmk2.Text);
                        // textBox12.Text = Convert.ToString(nstrin + "," + nstrin1);
                        //l = Convert.ToString(t+r);
                        //textBox12.Text = Convert.ToString(l);



                        // int n1;
                        // if (int.TryParse(lblmmk2.Text, out n1))
                        // {
                        //     int nstrin1 = n1;
                        //     textBox12.Text = Convert.ToString(nstrin1);
                        // }



                    }

                    t = lblhh2.Text;

                    r = lblmmk2.Text;
                    decimal nn;
                    decimal.TryParse(t, out nn);

                    decimal nstrin = nn;
                    //textBox12.Text = Convert.ToString(nstrin.ToString());

                    decimal nn1;
                    decimal.TryParse(r, out nn1);

                    decimal nstrin1 = nn1;
                    textBox12.Text = Convert.ToString(nstrin + " h " + nstrin1 + " min ");
                    //double a = Convert.ToDouble(textBox12.Text);
                    textBox14.Text = nstrin.ToString();
                    // textBox14.Text = String.Format("00.00", a);
                }

                else
                {
                    string t, r;
                    lblmmk2.Text = Convert.ToString(cant2);
                    lblhh2.Text = Convert.ToString(0);
                    t = lblhh2.Text;

                    r = lblmmk2.Text;
                    int nn;
                    int.TryParse(t + r, out nn);

                    int nstrin = nn;
                    textBox12.Text = Convert.ToString(" min " + nstrin);

                }
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);
            }
        }
       
       

        private void teaxtsobre_MouseLeave(object sender, EventArgs e)
        {
            Sumains2();
        }

        private void teaxtxs_MouseLeave(object sender, EventArgs e)
        {
            Sumains2();
        }

        private void teaxts_MouseLeave(object sender, EventArgs e)
        {
            Sumains2();
        }

        private void teaxtm_MouseLeave(object sender, EventArgs e)
        {
            Sumains2();
        }

        private void teaxtl_MouseLeave(object sender, EventArgs e)
        {
            Sumains2();
        }

        private void teaxtxl_MouseLeave(object sender, EventArgs e)
        {
            Sumains2();
        }

        private void teaxtxxl_MouseLeave(object sender, EventArgs e)
        {
            Sumains2();
        }

        private void teaxt3xl_MouseLeave(object sender, EventArgs e)
        {
            Sumains2();
        }

        private void teaxt4xl_MouseLeave(object sender, EventArgs e)
        {
            Sumains2();
        }

        private void teaxt5xl_MouseLeave(object sender, EventArgs e)
        {
            Sumains2();
        }

        private void teaxt6xl_MouseLeave(object sender, EventArgs e)
        {
            Sumains2();
        }

        private void teaxtsobre_Validating(object sender, CancelEventArgs e)
        {
            if (teaxtsobre.Text.Trim() == String.Empty)
            {
                errorProvider1.SetError(teaxtsobre, "Ingrese un valor ");
                btnregistraopinterno.Enabled = false;
                btnregistraopinterno.BackColor = Color.Gray;

            }
            else
            {
                Algoritmo2();
                btnregistraopinterno.Enabled = true;
                btnregistraopinterno.BackColor = Color.Gray;
                errorProvider1.Clear();
            }

        }

        private void teaxtxs_Validating(object sender, CancelEventArgs e)
        {

            if (teaxtxs.Text.Trim() == String.Empty)
            {
                errorProvider2.SetError(teaxtxs, "Ingrese un valor ");
                btnregistraopinterno.Enabled = false;
                btnregistraopinterno.BackColor = Color.Gray;
            }
            else
            {
                Algoritmo2();
                btnregistraopinterno.Enabled = true;
                btnregistraopinterno.BackColor = Color.Gray;
                errorProvider2.Clear();
            }

        }

        private void teaxts_Validating(object sender, CancelEventArgs e)
        {
            if (teaxts.Text.Trim() == String.Empty)
            {
                errorProvider3.SetError(teaxts, "Ingrese un valor ");
                btnregistraopinterno.Enabled = false;
                btnregistraopinterno.BackColor = Color.Gray;
            }
            else
            {
                Algoritmo2();
                btnregistraopinterno.Enabled = true;
                btnregistraopinterno.BackColor = Color.Gray;
                errorProvider3.Clear();
            }
        }

        private void teaxtm_Validating(object sender, CancelEventArgs e)
        {
            if (teaxtm.Text.Trim() == String.Empty)
            {
                errorProvider4.SetError(teaxtm, "Ingrese un valor ");
                btnregistraopinterno.Enabled = false;
                btnregistraopinterno.BackColor = Color.Gray;
            }
            else
            {
                Algoritmo2();
                btnregistraopinterno.Enabled = true;
                btnregistraopinterno.BackColor = Color.Gray;
                errorProvider4.Clear();
            }
        }

        private void teaxtl_Validating(object sender, CancelEventArgs e)
        {
            if (teaxtl.Text.Trim() == String.Empty)
            {
                errorProvider5.SetError(teaxtl, "Ingrese un valor ");
                btnregistraopinterno.Enabled = false;
                btnregistraopinterno.BackColor = Color.Gray;
            }
            else
            {
                Algoritmo2();
                btnregistraopinterno.Enabled = true;
                btnregistraopinterno.BackColor = Color.Gray;
                errorProvider5.Clear();
            }
        }

        private void teaxtxl_Validating(object sender, CancelEventArgs e)
        {
            if (teaxtxl.Text.Trim() == String.Empty)
            {
                errorProvider6.SetError(teaxtxl, "Ingrese un valor ");
                btnregistraopinterno.Enabled = false;
                btnregistraopinterno.BackColor = Color.Gray;
            }
            else
            {
                Algoritmo2();
                btnregistraopinterno.Enabled = true;
                btnregistraopinterno.BackColor = Color.Gray;
                errorProvider6.Clear();
            }
        }

        private void teaxtxxl_Validating(object sender, CancelEventArgs e)
        {
            if (teaxtxxl.Text.Trim() == String.Empty)
            {
                errorProvider7.SetError(teaxtxxl, "Ingrese un valor ");
                btnregistraopinterno.Enabled = false;
                btnregistraopinterno.BackColor = Color.Gray;
            }
            else
            {
                Algoritmo2();
                btnregistraopinterno.Enabled = true;
                btnregistraopinterno.BackColor = Color.Gray;
                errorProvider7.Clear();
            }
        }

        private void teaxt3xl_Validating(object sender, CancelEventArgs e)
        {
            if (teaxt3xl.Text.Trim() == String.Empty)
            {
                errorProvider8.SetError(teaxt3xl, "Ingrese un valor ");
                btnregistraopinterno.Enabled = false;
                btnregistraopinterno.BackColor = Color.Gray;
            }
            else
            {
                Algoritmo2();
                btnregistraopinterno.Enabled = true;
                btnregistraopinterno.BackColor = Color.Gray;
                errorProvider8.Clear();
            }
        }

        private void teaxt4xl_Validating(object sender, CancelEventArgs e)
        {
            if (teaxt4xl.Text.Trim() == String.Empty)
            {
                errorProvider9.SetError(teaxt4xl, "Ingrese un valor ");
                btnregistraopinterno.Enabled = false;
                btnregistraopinterno.BackColor = Color.Gray;
            }
            else
            {
                Algoritmo2();
                btnregistraopinterno.Enabled = true;
                btnregistraopinterno.BackColor = Color.Gray;
                errorProvider9.Clear();
            }
        }

        private void teaxt5xl_Validating(object sender, CancelEventArgs e)
        {
            if (teaxt5xl.Text.Trim() == String.Empty)
            {
                errorProvider10.SetError(teaxt5xl, "Ingrese un valor ");
                btnregistraopinterno.Enabled = false;
                btnregistraopinterno.BackColor = Color.Gray;
            }
            else
            {
                Algoritmo2();
                btnregistraopinterno.Enabled = true;
                btnregistraopinterno.BackColor = Color.Gray;
                errorProvider10.Clear();
            }
        }

        private void teaxt6xl_Validating(object sender, CancelEventArgs e)
        {
            if (teaxt6xl.Text.Trim() == String.Empty)
            {
                errorProvider11.SetError(teaxt6xl, "Ingrese un valor ");
                btnregistraopinterno.Enabled = false;
                btnregistraopinterno.BackColor = Color.Gray;
            }
            else
            {
                Algoritmo2();
                btnregistraopinterno.Enabled = true;
                btnregistraopinterno.BackColor = Color.Gray;
                errorProvider11.Clear();
            }
        }

        private void label51_Click(object sender, EventArgs e)
        {

        }


       

        private void button5_Click(object sender, EventArgs e)
        {
            Frmopera hijo = new Frmopera();
            hijo.contrato = this;
            hijo.contrato1 = this;
            hijo.contrato2 = this;
            hijo.contrato3 = this;
            hijo.contrato4 = this;
            hijo.contrato5 = this;
            hijo.contrato6 = this;
            hijo.contrato7 = this;
            hijo.contrato8 = this;
            hijo.contrato9 = this;
            hijo.contrato10 = this;
            hijo.contrato11 = this;
            hijo.contrato12 = this;
            hijo.contrato13 = this;
            hijo.contrato14 = this;
            hijo.contrato15 = this;
            hijo.contrato16 = this;
            hijo.contrato17 = this;
            hijo.contrato18 = this;

            hijo.contrato19 = this;
            hijo.contrato20 = this;
            hijo.contrato21 = this;
            hijo.contrato22 = this;
            hijo.contrato23 = this;
            hijo.contrato24 = this;
            hijo.contrato25 = this;
            hijo.contrato26 = this;
            hijo.contrato27 = this;
            hijo.contrato28 = this;
            hijo.contrato29 = this;
            hijo.contrato30 = this;
            hijo.contrato31 = this;
            hijo.ShowDialog();
            //
           



            try
            {
                DataTable dt = new DataTable();
                DataRow row;
                re.Opu = Convert.ToInt32(txtop.Text);
                dt = re.Buscaropu(re.Opu);
                if (dt.Rows.Count == 1)
                {
                    row = dt.Rows[0];
                    txtop.Text = row[0].ToString();
                    txtidprenda.Text = row[1].ToString();
                    txtnombrepren.Text = row[2].ToString();
                    //txtcantidadop.Text = row[3].ToString();

                    //dateT1.Value = Convert.ToDateTime(row[4].ToString());


                    //   MessageBox.Show("Registro Encontrado Ok...!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                   // lblverno.Text = "Registro no encontrado";
                   
                }


                // Busquedaop1();
               

            }
            catch (Exception ex)
            {
               
                // MessageBox.Show("Registro de Orden de Produccion no Existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          

        }


        private void textBox4_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
               // (dataGridView6.DataSource as DataTable).DefaultView.RowFilter = string.Format("opp1c = '{0}'", textBox4.Text);
                //Verresul2();
            }
            catch (Exception ex)
            {
               // Verresul2();
                 MessageBox.Show(ex.Message);
                // MessageBox.Show("Solo se admiten el valor de la OP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // dataGridView3.ClearSelection();
            }
           
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {

            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (e.KeyChar == 13)
                {

                    //button1.Focus();

                  
                }
                else
                {
                   
                  
                }
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

           // switch (Listado1)
           // {
           //     case 0: Cargarlistado5(); break;
           // }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

       
       
        private void validar1()
        {

            if (

            txtidperac.Text != string.Empty &
            txtnombrpren.Text!= string.Empty &
            txtcat.Text != string.Empty &
            rtxtdescr.Text != string.Empty 


            )

            // textBox51.Text != string.Empty)
            {
                btnregistraopinterno.Enabled = true;
               
            }
            else
            {
                btnregistraopinterno.Enabled = false;
               
                //button.Enabled = false;
            }

        }

        private void groupdos_Enter(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label72_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
              
                
            }
            catch (Exception ex)
            {
          
                // MessageBox.Show(ex.Message);
                //MessageBox.Show("Solo se admiten el valor de la OP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // label2.Text = "REGISTRO NO ENCONTRADO";
            }
        }
       
     

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Histo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                (dataGridView8.DataSource as DataTable).DefaultView.RowFilter = string.Format("opp1c = '{0}'", textBox2.Text);
                //Cargarlistadomodifi();
                Verresul4();

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
                Cargarlistadomodifi();//Verresul2();
                // MessageBox.Show(ex.Message);
                //MessageBox.Show("Solo se admiten el valor de la OP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // label2.Text = "REGISTRO NO ENCONTRADO";
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (e.KeyChar == 13)
                {

                    
                }
                else
                {

                    Cargarlistadomodifi();
                    Verresul4();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                // MessageBox.Show("Solo se admiten el valor de la OP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // dataGridView3.ClearSelection();
            }
        }

        private void dataGridView8_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {


                try
                {
                    int a = 0;
                    textBox21.Text = dataGridView8.CurrentCell.Value.ToString();
                    a = Convert.ToInt32(textBox21.Text);



                    U.IDopera = Convert.ToInt32(textBox21.Text);
                    //  re.Op = Convert.ToInt32(txtseletop.Text);
                    if (MessageBox.Show(" ¿ Está seguro que desea eliminar el registro " + a + " ?", "ELIMINAR REGISTRO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {

                        MessageBox.Show(U.Eliminaropusu(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Cargarlistadomodifi();// dataGridView6.ClearSelection();
                        textBox21.Clear();
                        Verresul4();
                        // MessageBox.Show("  Está ventana se cerrará para su correcta actualización  ", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //this.Close();

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

        private void textBox20_TextChanged(object sender, EventArgs e)
        {
           
                Verresul4();

            
            // nomprendac
        }
     
     
        private void textBox20_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox20_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                DataView dv = dtm.DefaultView;
                dv.RowFilter = string.Format(" nomprendac like '%{0}%'", textBox20.Text);


                dataGridView8.DataSource = dv.ToTable();
                // Verresulrepor2();
                //timer2.Stop();
                // Cargarlistadorepor2();
                Verresul4();
                // color();
                // colorazul();
                // Cargarlistado5();
                //timer4.Start();
                // dataGridView3.Rows[0].Selected = true;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                // MessageBox.Show("Solo se admiten el valor de la OP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // dataGridView3.ClearSelection();
            }
        }

        private void dataGridView8_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox21.Text = dataGridView8.CurrentCell.Value.ToString();
        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {
            dataGridView8.ClearSelection();
            {
                button9.Enabled = false;
            }
            if (dataGridView8.Rows.Count > 0)
            {
                button9.Enabled = true;
            }
           
        }

       
        private void button9_Click(object sender, EventArgs e)
        {
          
        }


       


        private void button9_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtidperac_TextChanged(object sender, EventArgs e)
        {
            validar1();
        }

        private void txtnombrpren_TextChanged(object sender, EventArgs e)
        {
            validar1();
        }

        private void rtxtdescr_TextChanged(object sender, EventArgs e)
        {
            validar1();
        }

      
      
       

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView8_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                try
                {
                    int a = 0;
                    // DataGridViewImageCell cell = (DataGridViewImageCell)
                    // dataGridView1.Rows[].Cells[e.ColumnIndex];

                    textBox21.Text = dataGridView8.CurrentCell.Value.ToString();
                    a = Convert.ToInt32(textBox21.Text);

                    // this.dataGridView1.CurrentCell = this.dataGridView1[1,0];

                    U.Opp1 = Convert.ToInt32(textBox21.Text);
                    //  re.Op = Convert.ToInt32(txtseletop.Text);
                    if (MessageBox.Show(" ¿ Está seguro que desea eliminar el  N° de OP " + a + " ?", "ELIMINAR REGISTRO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {

                        MessageBox.Show(U.Eliminaropusuop(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Cargarlistadomodifi();
                        textBox21.Clear();
                        Verresul4();
                        // MessageBox.Show("  Está ventana se cerrará para su correcta actualización  ", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //this.Close();

                    }
                    //  MessageBox.Show(re.Eliminarop1(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Limpiar();
                    // Cargarlistado5();
                    // Cargarlistado7();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("  Unicamente seleccionar el número de   ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnregistraopinterno_Click(object sender, EventArgs e)
        {
            int canti = 0;
            int rest,
                  rest1, rest2, rest3, res4, rest5, rest6, rest7, rest8, rest9, rest10, rest11;
            int sobre, xxs, ss, mmm, lll, xlll, xxxx, xq, xw, xe, xr;
            int Xs, S, Mm, L, Xl, Xxl, T3xl, T4xl, T5xl, T6xl, Sobremedida;



             try
             {

            U.IDopera = Convert.ToInt32(txtidperac.Text);
            U.Opp1 = Convert.ToInt32(txtop.Text);
            U.Tiempopp = Convert.ToDecimal(txtcat.Text);
            U.Nombrepren = txtnombrepren.Text;
            U.Nombreoperpp = txtnombrpren.Text;
            U.Categoria = textBox3.Text;
            U.Descripcionpp = rtxtdescr.Text;
            Sobremedida = Convert.ToInt32(teaxtsobre.Text);

            Xs = Convert.ToInt32(teaxtxs.Text);
            S = Convert.ToInt32(teaxts.Text);
            Mm = Convert.ToInt32(teaxtm.Text);
            L = Convert.ToInt32(teaxtl.Text);
            Xl = Convert.ToInt32(teaxtxl.Text);
            Xxl = Convert.ToInt32(teaxtxxl.Text);
            T3xl = Convert.ToInt32(teaxt3xl.Text);
            T4xl = Convert.ToInt32(teaxt4xl.Text);
            T5xl = Convert.ToInt32(teaxt5xl.Text);
            T6xl = Convert.ToInt32(teaxt6xl.Text);

            //canti = Convert.ToInt32(textcantidadop.Text);


            // canti=  Sobremedida + Xs + S + Mm + L + Xl + Xxl + T3xl + T4xl + T5xl + T6xl;
            //teaxtcantidadop.Text = Convert.ToString(canti);
            //txtcategoria.Text) 

            sobre = Convert.ToInt32(textsobre.Text);
            xxs = Convert.ToInt32(textxs.Text);
            ss = Convert.ToInt32(texts.Text);
            mmm = Convert.ToInt32(textm.Text);
            lll = Convert.ToInt32(textl.Text);
            xlll = Convert.ToInt32(textxl.Text);
            xxxx = Convert.ToInt32(textxxl.Text);
            xq = Convert.ToInt32(text3xl.Text);
            xw = Convert.ToInt32(text4xl.Text);
            xe = Convert.ToInt32(text5xl.Text);
            xr = Convert.ToInt32(text6xl.Text);
            if (sobre < Sobremedida || xxs < Xs || ss < S || mmm < Mm || lll < L || xlll < Xl || xxxx < Xxl || xq < T3xl || xw < T4xl || xe < T5xl || xr < T6xl)
            {
                MessageBox.Show("El numero excede la cantidad original", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                // txtasignacion.Text = Convert.ToString(fal);
                // rest = orig - fal;
                //txtrestante.Text = Convert.ToString(rest);
                //txtcantidadori.Text = Convert.ToString(rest);
                //int resultado1 = 0;
                rest = sobre - Sobremedida;
                rest1 = xxs - Xs;
                rest2 = ss - S;
                rest3 = mmm - Mm;
                res4 = lll - L;
                rest5 = xlll - Xl;
                rest6 = xxxx - Xxl;
                rest7 = xq - T3xl;
                rest8 = xw - T4xl;
                rest9 = xe - T5xl;
                rest10 = xr - T6xl;
                rest11 = canti;
                //textcantidadop.Text = Convert.ToString(resultado1);
                //  O.OP = Convert.ToInt32(lblopinterno.Text);

                U.Sobremedidao = Convert.ToInt32(rest);

                U.Xso = Convert.ToInt32(rest1);
                U.So = Convert.ToInt32(rest2);
                U.Mmo = Convert.ToInt32(rest3);
                U.Lo = Convert.ToInt32(res4);
                U.Xlo = Convert.ToInt32(rest5);
                U.Xxlo = Convert.ToInt32(rest6);
                U.T3xlo = Convert.ToInt32(rest7);
                U.T4xlo = Convert.ToInt32(rest8);
                U.T5xlo = Convert.ToInt32(rest9);
                U.T6xlo = Convert.ToInt32(rest10);
                U.Estado = Convert.ToInt32(4);
                //   U.Cantidadpp = Convert.ToInt32(txtcantidadop.Text);
                // U.Cantidadpp = Convert.ToInt32(teaxtcantidadop.Text);

                Algoritmo2();
                MessageBox.Show(U.Actualizaropusu(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //teaxtcantidadop.Text = U.sumaop().ToString();
                canti = Sobremedida + Xs + S + Mm + L + Xl + Xxl + T3xl + T4xl + T5xl + T6xl;
                teaxtcantidadop.Text = Convert.ToString(canti);
                DataTable dti = new DataTable();
                DataRow rowi;
                U.IDopera = Convert.ToInt32(txtidperac.Text);
                dti = U.Buscaropusu(U.IDopera);
                if (dti.Rows.Count == 1)
                {
                    rowi = dti.Rows[0];
                    // lblinter.Text = rowi[0].ToString();
                    txtcaactu.Text = rowi[8].ToString();

                   // MessageBox.Show("Registro Encontrado Ok!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Cargarlistadomodifi();
                    }

                else
                {
                    MessageBox.Show("Registro no Existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //te.Limpiar();
                }
                    contratoopa.Valor31opa(txtop.Text);//5
                    contrato1opa.Valor32opa(txtidprenda.Text);//6
                    contrato2opa.Valor33opa(txtnombrepren.Text);//3
                    contrato3opa.Valor34opa(txtidperac.Text);//8
                    contrato4opa.Valor35opa(txtnombrpren.Text);//9
                    contrato5opa.Valor36opa(txtcat.Text);//tiempo operacion 11
                    contrato6opa.Valor37opa(teaxtxs.Text);//
                    contrato19opa.Valor50opa(teaxtsobre.Text);//17

                    contrato7opa.Valor38opa(teaxts.Text);
                    contrato8opa.Valor39opa(teaxtm.Text);
                    contrato9opa.Valor40opa(teaxtl.Text);
                    contrato10opa.Valor41opa(teaxtxl.Text);
                    contrato11opa.Valor42opa(teaxtxxl.Text);
                    contrato12opa.Valor43opa(teaxt3xl.Text);
                    contrato13opa.Valor44opa(teaxt4xl.Text);
                    contrato14opa.Valor45opa(teaxt5xl.Text);
                    contrato15opa.Valor46opa(teaxt6xl.Text);
                    contrato16opa.Valor47opa(teaxtcantidadop.Text);//12
                    contrato17opa.Valor48opa(textBox3.Text);//10
                    contrato18opa.Valor49opa(textBox12.Text);//14
                    this.Hide();

                }

            //Limpiar();
             }
               catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);
                MessageBox.Show("Campos Vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

          }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {

                //  re.Op = Convert.ToInt32(txtseletop.Text);
                if (MessageBox.Show("¿ Está seguro que desea eliminar todos los registros ?", "ELIMINAR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    MessageBox.Show(U.Eliminaropusutotal(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                    Cargarlistadomodifi();
                    textBox21.Clear();
                    dataGridView8.ClearSelection();
                    {
                        button9.Enabled = false;
                    }
                    if (dataGridView8.Rows.Count > 0)
                    {
                        button9.Enabled = true;
                    }
                    Verresul4();
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
        private void dataGridView8_Leave(object sender, EventArgs e)
        {
            dataGridView8.ClearSelection();
        }

        private void dataGridView8_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            textBox21.Text = dataGridView8.CurrentCell.Value.ToString();
        }

        private void dataGridView8_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {

        }

     

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void hh1_TextChanged(object sender, EventArgs e)
        {

        }

        private void mm1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel70_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel72_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView8_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            dataGridView8.EnableHeadersVisualStyles = false;
            DataGridViewColumn dataGridViewColumn = dataGridView8.Columns[3];
            dataGridViewColumn.HeaderCell.Style.BackColor = Color.LightGray;
            dataGridViewColumn.HeaderCell.Style.ForeColor = Color.Black;

            Color cl = dataGridViewColumn.HeaderCell.Style.BackColor;
            //or   
            Color cl2 = dataGridView8.Columns[3].HeaderCell.Style.BackColor;


            DataGridViewColumn dataGridViewColumn1 = dataGridView8.Columns[0];
            dataGridViewColumn1.HeaderCell.Style.BackColor = Color.White;
            dataGridViewColumn1.HeaderCell.Style.ForeColor = Color.Black;

            DataGridViewColumn dataGridViewColumn2 = dataGridView8.Columns[1];
            dataGridViewColumn2.HeaderCell.Style.BackColor = Color.White;
            dataGridViewColumn2.HeaderCell.Style.ForeColor = Color.Black;

            


        }
   
        public void Valor(string _dato)
        {
            txtcat.Text = _dato;
        }

        public void Valor1(string _dato1)
        {
            txtnombrpren.Text = _dato1;
        }
        public void Valor2(string _dato2)
        {
            rtxtdescr.Text = _dato2;
        }
        public void Valor3(string _dato3)
        {
            txtsobre.Text = _dato3;
        }
        public void Valor4(string _dato4)
        {
            txtxs.Text = _dato4;
        }
        public void Valor5(string _dato5)
        {
            txts.Text = _dato5;
        }
        public void Valor6(string _dato6)
        {
            txtm.Text = _dato6;
        }
        public void Valor7(string _dato7)
        {
            txtl.Text = _dato7;
        }
        public void Valor8(string _dato8)
        {
            txtxl.Text = _dato8;
        }
        public void Valor9(string _dato9)
        {
            txtxxl.Text = _dato9;
        }
        public void Valor10(string _dato10)
        {
            txt3xl.Text = _dato10;
        }
        public void Valor11(string _dato11)
        {
            txt4xl.Text = _dato11;
        }
        public void Valor12(string _dato12)
        {
            txt5xl.Text = _dato12;
        }
        public void Valor13(string _dato13)
        {
            txt6xl.Text = _dato13;
        }
        public void Valor14(string _dato14)
        {
            txtcantidadop.Text = _dato14;
        }
        public void Valor15(string _dato15)
        {
            txtidperac.Text = _dato15;
        }
        public void Valor16(string _dato16)
        {
            txtop.Text = _dato16;
        }
        public void Valor17(string _dato17)
        {
            txtidprenda.Text = _dato17;
        }
        public void Valor18(string _dato18)
        {
            txtnombrepren.Text = _dato18;
        }
     
        public void Valor19(string _dato19)
        {
            textsobre.Text = _dato19;
        }
        public void Valor20(string _dato20)
        {
            textxs.Text = _dato20;
        }
        public void Valor21(string _dato21)
        {
            texts.Text = _dato21;
        }
        public void Valor22(string _dato22)
        {
            textm.Text = _dato22;
        }
        public void Valor23(string _dato23)
        {
            textl.Text = _dato23;
        }
        public void Valor24(string _dato24)
        {
            textxl.Text = _dato24;
        }
        public void Valor25(string _dato25)
        {
            textxxl.Text = _dato25;
        }
        public void Valor26(string _dato26)
        {
            text3xl.Text = _dato26;
        }
        public void Valor27(string _dato27)
        {
            text4xl.Text = _dato27;
        }
        public void Valor28(string _dato28)
        {
            text5xl.Text = _dato28;
        }
        public void Valor29(string _dato29)
        {
            text6xl.Text = _dato29;
        }
        public void Valor30(string _dato30)
        {
            textcantidadop.Text = _dato30;
        }
        public void Valor31(string _dato31)
        {
            textBox3.Text = _dato31;
        }

        private void txtop_TextChanged(object sender, EventArgs e)
        {

        }

        private void teaxtcantidadop_TextChanged(object sender, EventArgs e)
        {
            Algoritmo2();
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

        private void dataGridView8_Validating(object sender, CancelEventArgs e)
        {

        }

        private void textBox10_TextChanged_1(object sender, EventArgs e)
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
