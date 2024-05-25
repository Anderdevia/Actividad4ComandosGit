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
    public partial class Operadm : Form

    {
        int Listado = 0;
        Adoperacion re = new Adoperacion();
        clsopp Te = new clsopp();
        Clsopes RET = new Clsopes();

        public Operadm()
        {
            InitializeComponent();
        }

        private void Operadm_Load(object sender, EventArgs e)
        {

            toolTip1.SetToolTip(this.txtti2, "Separación...");
            button4.Enabled = false; button2.Enabled = false;
            button1.Enabled = false; button3.Enabled = false;
           // timer1.Start();
//timer1.Interval = 2000;
           // CargarListado();
            CargarListado11();
            //dataopb.ClearSelection();
            timer1.Start();
            Verresul1();



            //llenar  grilla
            //   dateT1.Value = DateTime.Now;
            // DataTable dt = re.Listadoop1();
            // dataGridViewop1.DataSource = dt;


            // DataTable dti = re.Listadoop2();
            // dataopb.DataSource = dti;
            // DataTable dt1 = re.Listadoop3();
            //dataGridViewop2.DataSource = dt1;
            this.Cursor = Cursors.Default;
        }

        private void button4_Click(object sender, EventArgs e)
        {
           try
            {
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);

                re.Refe= txtop1.Text;
                re.Nombrep = txtnp1.Text;
                re.Categoria = txtc1.Text;
                re.Descripcion = rtxt1.Text;
                re.Descripcion2 = textBox6.Text;
                re.Imagen =  ms.GetBuffer();
                re.Fecha = Convert.ToDateTime(dateT1.Value);


                MessageBox.Show(re.Registrarope1(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarListado11();
                // txtcantidadop.Text = O.sumaop().ToString();
                Verresul1();
                limpiarid();
                //Limpiar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
          try {

               // RET.Numero = Convert.ToInt32(textBox4.Text);
                
                RET.IDprendadd = Convert.ToInt32(txtop2.Text);
                RET.Referencia = textBox8.Text;
                RET.Nombrepren = txtprendaop.Text;
                RET.Grupo = textBox10.Text;
                RET.Mq = textBox11.Text;
                RET.Nombreopera = txtnoper2.Text;
                RET.Unidad = Convert.ToInt32(textBox9.Text);
                RET.Tiempo = Convert.ToDecimal(textBox13.Text);
                RET.Unidadhora = Convert.ToDecimal(textBox12.Text);
                RET.Categoria = txtcateoperacion.Text;
                RET.Descripcionpp = rtxt2.Text;
                RET.Lugar =textBox7.Text;

                MessageBox.Show(RET.Registrarope2(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarListado();
                buscarnumero();
              
                // txtcantidadop.Text = O.sumaop().ToString();

                // Te.IDopera = Convert.ToInt32(textBox4.Text);
                Te.Numero1 = Convert.ToInt32(txtseletop.Text);
                Te.Opp1 = Convert.ToInt32(0);
                Te.IDprendadd = Convert.ToInt32(txtop2.Text);
                Te.Nombrepren = Convert.ToString(txtprendaop.Text);
                Te.Nombreoperpp = Convert.ToString(txtnoper2.Text);
                Te.Categoria2 = txtcateoperacion.Text;
                Te.Descripcionpp = Convert.ToString(rtxt2.Text);
                Te.Tiempopp = Convert.ToDecimal(txtti2.Text);
                Te.Totalpp = Convert.ToInt32(0);

                Te.Sobremedidao = Convert.ToInt32(0);

                Te.Xso = Convert.ToInt32(0);
                Te.So = Convert.ToInt32(0);
                Te.Mmo = Convert.ToInt32(0);
                Te.Lo = Convert.ToInt32(0);
                Te.Xlo = Convert.ToInt32(0);
                Te.Xxlo = Convert.ToInt32(0);
                Te.T3xlo = Convert.ToInt32(0);
                Te.T4xlo = Convert.ToInt32(0);
                Te.T5xlo = Convert.ToInt32(0);
                Te.T6xlo = Convert.ToInt32(0);
                Te.Estado = Convert.ToInt32(2);

                


                MessageBox.Show(Te.Registrar_opp1(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiarope();
                
                //txtcantidadop.Text = Te.multiop().ToString();

                //Limpiar();
            }
           catch (Exception ex)
           {
                MessageBox.Show(ex.Message);
           }
        }
      
        private void dataGridViewop1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
                try
                {

                    textBox4.Text = dataGridViewop1.CurrentCell.Value.ToString();
              buscaridprenda();


                Busquedaop();
                 



                    DataTable dt = new DataTable();
                    DataRow row;
                    re.Op = Convert.ToInt32(textBox4.Text);
                    dt = re.Buscarop1(re.Op);
                if (dt.Rows.Count == 1)
                {
                    row = dt.Rows[0];
                    txtop1.Text = row[1].ToString();
                    txtop2.Text = row[0].ToString();
                    txtnp1.Text = row[2].ToString();
                    txtprendaop.Text = row[2].ToString();
                    textBox8.Text = row[1].ToString();
                    txtc1.Text = row[3].ToString();
                    txtcateoperacion.Text = row[3].ToString();
                    
                    rtxt1.Text = row[4].ToString();
                   textBox6.Text = row[5].ToString();

                    dateT1.Value = Convert.ToDateTime(row[4].ToString());
                    byte[] img = (byte[])dt.Rows[0][6];

                    System.IO.MemoryStream ms = new System.IO.MemoryStream(img);
                    pictureBox1.Image = Image.FromStream(ms);

                    //   MessageBox.Show("Registro Encontrado Ok...!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);




                    Verresul();

                    //DataTable dt = new DataTable();
                    // DataRow row;
                    //re.Op = Convert.ToInt32(txtseletop.Text);
                    //  dt = re.Listadoop3(re.Op);

                    // re.Opint = Convert.ToInt32(txtseletop.Text);
                }
                   }
                catch (Exception ex)
                {
                    // MessageBox.Show("Registro de Orden de Produccion no Existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
        }

    

    private bool botonenter = false;

        private void limpiarope()
        {
           txtop2.Text="";
            textBox8.Text = "";
            txtprendaop.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            txtnoper2.Text = "";
            textBox9.Text = "";
           txtti2.Text = "";
            textBox13.Text = "";
            textBox12.Text = "";
            txtcateoperacion.Text = "";
            rtxt2.Text = "";
            textBox7.Text = "";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
          //  botonenter = true;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if (e.KeyChar == 13)
            {
                Busquedaop();
               
            }
            else
            {
                CargarListado();
               
            }
        }
        private void buscarnumero()
        {

            try
            {
                DataTable dt = new DataTable();
                DataRow row;
                dt = RET.Listanumero();

                if (dt.Rows.Count == 1)
                {
                    row = dt.Rows[0];
                    txtseletop.Text = row[0].ToString();
               
                }
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);

            }


        }
        private void Busquedaop()
        {
            DataTable dt = new DataTable();

            try
            {
                RET.Opint = Convert.ToInt32(textBox4.Text);
                dt = RET.Buscarop2(RET.Opint);
                dataopb.Rows.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dataopb.DefaultCellStyle.Font = new Font("Nirmala UI", 7);
                    dataopb.RowTemplate.Height = 13;
                    dataopb.ColumnHeadersDefaultCellStyle.Font = new Font(dataopb.Font, FontStyle.Bold);
                    dataopb.Rows.Add(dt.Rows[i][0]);
                    dataopb.Rows[i].Cells[0].Value = dt.Rows[i][0].ToString();
                    dataopb.Rows[i].Cells[1].Value = dt.Rows[i][1].ToString();
                    dataopb.Rows[i].Cells[2].Value = dt.Rows[i][2].ToString();
                    dataopb.Rows[i].Cells[3].Value = dt.Rows[i][3].ToString();
                    dataopb.Rows[i].Cells[4].Value = dt.Rows[i][4].ToString();
                    dataopb.Rows[i].Cells[5].Value = dt.Rows[i][5].ToString();
                    dataopb.Rows[i].Cells[6].Value = dt.Rows[i][6].ToString();
                    dataopb.Rows[i].Cells[7].Value = dt.Rows[i][7].ToString();
                    dataopb.Rows[i].Cells[8].Value = dt.Rows[i][8].ToString();
                    dataopb.Rows[i].Cells[9].Value = dt.Rows[i][9].ToString();
                    dataopb.Rows[i].Cells[10].Value = dt.Rows[i][10].ToString();
                    dataopb.Rows[i].Cells[11].Value = dt.Rows[i][11].ToString();
                    dataopb.Rows[i].Cells[12].Value = dt.Rows[i][12].ToString();
                    FreezeBand1(dataopb.Columns[2]);

                }
                Verresul();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ingresar valor del Id", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dataopb.ClearSelection();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dateT1.Value = DateTime.Now;
        }


        private void CargarListado11()
        {
            DataTable dt = new DataTable();
            dt = re.Listadoop1();
            try
            {
                dataGridViewop1.Rows.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dataGridViewop1.DefaultCellStyle.Font = new Font("Nirmala UI", 7);
                    dataGridViewop1.RowTemplate.Height = 13;
                    dataGridViewop1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridViewop1.Font, FontStyle.Bold);
                    dataGridViewop1.Rows.Add(dt.Rows[i][0]);
                    dataGridViewop1.Rows[i].Cells[0].Value = dt.Rows[i][0].ToString();
                    dataGridViewop1.Rows[i].Cells[1].Value = dt.Rows[i][1].ToString();
                    dataGridViewop1.Rows[i].Cells[2].Value = dt.Rows[i][2].ToString();
                    dataGridViewop1.Rows[i].Cells[3].Value = dt.Rows[i][3].ToString();
                    dataGridViewop1.Rows[i].Cells[4].Value = dt.Rows[i][4].ToString();
                    dataGridViewop1.Rows[i].Cells[5].Value = dt.Rows[i][5].ToString();
                    dataGridViewop1.Rows[i].Cells[7].Value = dt.Rows[i][7].ToString();
                    FreezeBand(dataGridViewop1.Columns[1]);

                }
                Verresul1();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataGridViewop1.ClearSelection();
        }
        private void CargarListado()
        {
            DataTable dt = new DataTable();
            dt = RET.Listadoop2();
            try
            {
                dataopb.Rows.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                dataopb.DefaultCellStyle.Font = new Font("Nirmala UI", 7);
                dataopb.RowTemplate.Height = 13;
                dataopb.ColumnHeadersDefaultCellStyle.Font = new Font(dataopb.Font, FontStyle.Bold);
                dataopb.Rows.Add(dt.Rows[i][0]);
                    dataopb.Rows[i].Cells[0].Value = dt.Rows[i][0].ToString();
                    dataopb.Rows[i].Cells[1].Value = dt.Rows[i][1].ToString();
                    dataopb.Rows[i].Cells[2].Value = dt.Rows[i][2].ToString();
                    dataopb.Rows[i].Cells[3].Value = dt.Rows[i][3].ToString();
                    dataopb.Rows[i].Cells[4].Value = dt.Rows[i][4].ToString();
                    dataopb.Rows[i].Cells[5].Value = dt.Rows[i][5].ToString();
                    dataopb.Rows[i].Cells[6].Value = dt.Rows[i][6].ToString();
                dataopb.Rows[i].Cells[7].Value = dt.Rows[i][7].ToString();
                dataopb.Rows[i].Cells[8].Value = dt.Rows[i][8].ToString();
                dataopb.Rows[i].Cells[9].Value = dt.Rows[i][9].ToString();
                dataopb.Rows[i].Cells[10].Value = dt.Rows[i][10].ToString();
                dataopb.Rows[i].Cells[11].Value = dt.Rows[i][11].ToString();
                dataopb.Rows[i].Cells[12].Value = dt.Rows[i][12].ToString();
                    FreezeBand1(dataopb.Columns[2]);

                }
                Verresul();
            }
            
            catch (Exception ex)
           {
                MessageBox.Show(ex.Message);
            }
            dataopb.ClearSelection();
        }
      

        private void dataopb_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
           

           
                try
                {
 decimal baser = 0;
                    decimal baser1 = 0;
                    int resultado = 0;
                    txtnumero.Text = dataopb.CurrentCell.Value.ToString();



                    DataTable dt = new DataTable();
                    DataRow row;
                    RET.Numero = Convert.ToInt32(txtnumero.Text);
                    dt = RET.Buscarop3(RET.Numero);
                    if (dt.Rows.Count == 1)
                    {
                        row = dt.Rows[0];

                        txtnumero.Text = row[0].ToString();
                        txtop2.Text = row[1].ToString();
                        textBox8.Text = row[2].ToString();
                        txtprendaop.Text = row[3].ToString();
                        textBox10.Text = row[4].ToString();
                        textBox11.Text = row[5].ToString();
                        txtnoper2.Text = row[6].ToString();
                        textBox9.Text = row[7].ToString();
                        textBox13.Text = row[8].ToString();
                        textBox12.Text = row[9].ToString();
                        txtcateoperacion.Text = row[10].ToString();
                        rtxt2.Text = row[11].ToString();
                        textBox7.Text = row[12].ToString();

                   
                        baser = Convert.ToDecimal(textBox13.Text);

                    baser1 = Convert.ToDecimal( baser/2);
                    txtti2.Text = baser1.ToString("N");
                   
                   


                        //   MessageBox.Show("Registro Encontrado Ok...!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }




                    if (dataopb.Rows.Count > 0)
            {
              dataopb.Rows[dataopb.CurrentRow.Index].Selected = true;
             
            }

                //txtnupe2.Text = dataopb.CurrentCell.Value.ToString();                         
                                    
                }

                catch (Exception ex)
                {
               // MessageBox.Show("Dar Click unicamente en OP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }
        private void Buscar225()
        {
            DataTable dt = new DataTable();

            try
            {
                RET.Numero = Convert.ToInt32(txtnumero.Text);
                dt = RET.Buscarop3(RET.Numero);
                dataopb.Rows.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dataopb.DefaultCellStyle.Font = new Font("Nirmala UI", 7);
                    dataopb.RowTemplate.Height = 13;
                    dataopb.ColumnHeadersDefaultCellStyle.Font = new Font(dataopb.Font, FontStyle.Bold);
                    dataopb.Rows.Add(dt.Rows[i][0]);
                    dataopb.Rows[i].Cells[0].Value = dt.Rows[i][0].ToString();
                    dataopb.Rows[i].Cells[1].Value = dt.Rows[i][1].ToString();
                    dataopb.Rows[i].Cells[2].Value = dt.Rows[i][2].ToString();
                    dataopb.Rows[i].Cells[3].Value = dt.Rows[i][3].ToString();
                    dataopb.Rows[i].Cells[4].Value = dt.Rows[i][4].ToString();
                    dataopb.Rows[i].Cells[7].Value = dt.Rows[i][7].ToString();
                    dataopb.Rows[i].Cells[8].Value = dt.Rows[i][8].ToString();
                    dataopb.Rows[i].Cells[9].Value = dt.Rows[i][9].ToString();
                    dataopb.Rows[i].Cells[10].Value = dt.Rows[i][10].ToString();
                    dataopb.Rows[i].Cells[11].Value = dt.Rows[i][11].ToString();
                    dataopb.Rows[i].Cells[12].Value = dt.Rows[i][12].ToString();
                    FreezeBand1(dataopb.Columns[2]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Solo se admiten el valor de la OP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dataopb.ClearSelection();
        }

private void dataopb_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
               
            }
        }

        private void dataGridViewop1_Click(object sender, EventArgs e)
        {
            buscarnumero();
            if (dataopb.Rows.Count > 0)
            {
                dataopb.Rows[dataopb.CurrentRow.Index].Selected = true;
                dataopb.Enabled = true;
            }
        }

       

        private void dataGridViewop1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void dataopb_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

      

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                re.Op = Convert.ToInt32(txtop1.Text);
                re.Nombrep = Convert.ToString(txtnp1.Text);
                re.Categoria = Convert.ToString(txtc1.Text);
                re.Descripcion = Convert.ToString(rtxt1.Text);
                re.Fecha = Convert.ToDateTime(dateT1.Value);


                MessageBox.Show(re.Actualizaropera1(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarListado11();
           
                // txtcantidadop.Text = O.sumaop().ToString();
                Verresul1();
                limpiarid();
                //Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
           // try
           // {
                RET.Numero = Convert.ToInt32(txtnumero.Text);
                RET.IDprendadd = Convert.ToInt32(txtop2.Text);
                RET.Referencia = textBox8.Text;
                RET.Nombreprendaop = txtprendaop.Text;
                RET.Grupo = textBox10.Text;
                RET.Mq = textBox11.Text;
                RET.Nombreopera = txtnoper2.Text;
                RET.Unidad = Convert.ToInt32(textBox9.Text);
                RET.Tiempo = Convert.ToDecimal(textBox13.Text);
                RET.Unidadhora = Convert.ToDecimal(textBox12.Text);
                RET.Categoria = txtcateoperacion.Text;
                RET.Descripcionpp = rtxt2.Text;
                RET.Lugar = textBox7.Text;


                MessageBox.Show(RET.Actualizaropera2(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Verresul();
                CargarListado();
               

                Te.Numero1 = Convert.ToInt32(txtseletop.Text);
                Te.Opp1 = Convert.ToInt32(0);
                Te.IDprendadd = Convert.ToInt32(txtop2.Text);
                Te.Nombrepren = Convert.ToString(txtprendaop.Text);
                Te.Nombreoperpp = Convert.ToString(txtnoper2.Text);
                Te.Categoria2 = txtcateoperacion.Text;
                Te.Descripcionpp = Convert.ToString(rtxt2.Text);
                Te.Tiempopp = Convert.ToDecimal(txtti2.Text);
                Te.Cantidad = Convert.ToInt32(0);
                Te.Totalpp = Convert.ToInt32(0);

                Te.Sobremedidao = Convert.ToInt32(0);

                Te.Xso = Convert.ToInt32(0);
                Te.So = Convert.ToInt32(0);
                Te.Mmo = Convert.ToInt32(0);
                Te.Lo = Convert.ToInt32(0);
                Te.Xlo = Convert.ToInt32(0);
                Te.Xxlo = Convert.ToInt32(0);
                Te.T3xlo = Convert.ToInt32(0);
                Te.T4xlo = Convert.ToInt32(0);
                Te.T5xlo = Convert.ToInt32(0);
                Te.T6xlo = Convert.ToInt32(0);
                Te.Estado = Convert.ToInt32(2);
                  limpiarope();



                MessageBox.Show(Te.Actualizaropp1numero(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // txtcantidadop.Text = O.sumaop().ToString();

                //Limpiar();
          //  }
          //  catch (Exception ex)
          // {
           //     MessageBox.Show(ex.Message);
           // }
        }

        private void Verresul1()
        {

            int baser = 0;
            int baser1 = 0;
            int resultado = 0;

            double total = 0;
            double totalim = 0;
          

          //  textBox2.Text = total.ToString("00.00");
            textBox5.Text = dataGridViewop1.RowCount.ToString();
            //   Convert.ToString(ded.ToString("00.0"));
            // int sum = 0;
            //  for (int i = 0; i < dataopb.Rows.Count; ++i)
            // {
            //     sum += Convert.ToInt32(dataopb.Rows[i].Cells[15].Value);
            // }
            //baser = Convert.ToInt32(textBox3.Text);
           // baser1 = Convert.ToInt32(txtnup1.Text);
            //resultado = baser + baser1;
            //textBox4.Text = Convert.ToString(resultado);
            // textBox22.Text = sum.ToString("00.00");
            // textBox7.Text = sum.ToString();

        }

        private void Verresul()
        {


            try
            {
               
                decimal baser = 0;
            decimal baser1 = 0;
            int resultado = 0;

            double total = 0;
            double totalim = 0;
            foreach (DataGridViewRow row in dataopb.Rows)
            {

                total += Convert.ToDouble(row.Cells[8].Value);
               
               // row.Cells[dataopb.Columns[15].Index].Value = (Convert.ToDecimal(row.Cells[dataopb.Columns[15].Index].Value));

            }
           
            textBox2.Text = total.ToString("00.00");
            textBox3.Text = dataopb.RowCount.ToString();
            baser = Convert.ToDecimal(textBox2.Text);

            baser1 = Convert.ToDecimal(60 / baser);
            textBox14.Text = baser1.ToString("N");
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

        private void button6_Click(object sender, EventArgs e)
        {

            try
            {
              

                DataTable dt = new DataTable();
                DataRow row;
                RET.Numero = Convert.ToInt32(txtnumero.Text);
                dt = RET.Buscarop3(RET.Numero);
                if(dt.Rows.Count == 1)
                {
                    row = dt.Rows[0];
                    txtnumero.Text = row[0].ToString();
                    txtop2.Text = row[1].ToString();
                    txtnoper2.Text = row[2].ToString();
                    txtti2.Text = row[3].ToString();
                    rtxt2.Text = row[4].ToString();

                

                    MessageBox.Show("Registro Encontrado Ok...!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    //  MessageBox.Show("Registro Encontrado Ok...!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                else 
                {
                    MessageBox.Show("Registro no Encontrado Ok...!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                //  Buscar225();


            }
            catch (Exception ex)
            {
                // MessageBox.Show("Dar Click unicamente en OP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(ex.Message);
            }
        }

     

        private void dataopb_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }

     
        private void validarr1()
        {

            if (txtop1.Text != string.Empty || txtnp1.Text != string.Empty & txtc1.Text != string.Empty & rtxt1.Text != string.Empty )
            { button4.Enabled = true; button2.Enabled = true; }
            else
            {
                button4.Enabled = false; button2.Enabled = false;
            }

        }
        private void validarr()
        {
            try {

                int v;
            decimal e, o,t,r;

            t = Convert.ToDecimal(textBox9.Text);
            e = Convert.ToDecimal(txtti2.Text);
            o = Convert.ToDecimal(e*t);
              
                textBox13.Text = o.ToString("N");
              
                 r = Convert.ToDecimal(textBox13.Text);
               
                v = Convert.ToInt32(60/o);
               textBox12.Text = v.ToString();

                if (txtcateoperacion.Text != string.Empty || txtop2.Text != string.Empty || txtprendaop.Text != string.Empty || txtnoper2.Text != string.Empty &
              txtti2.Text != string.Empty & rtxt2.Text != string.Empty)
            { button1.Enabled = true; button3.Enabled = true; }
            else
            {
               button1.Enabled = false; button3.Enabled = false;
            }
        }
            catch (Exception ex)
            {
                // MessageBox.Show("Dar Click unicamente en OP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
               // MessageBox.Show(ex.Message);
            }
}

        private void txtnupe2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            validarr();
        }

        private void txtop2_TextChanged(object sender, EventArgs e)
        {
            validarr();
        }

        private void txtprendaop_TextChanged(object sender, EventArgs e)
        {
            validarr();
        }

        private void txtnoper2_TextChanged(object sender, EventArgs e)
        {
            validarr();
        }

        private void txtti2_TextChanged(object sender, EventArgs e)
        {
            validarr();
        }

        private void rtxt2_TextChanged(object sender, EventArgs e)
        {
            validarr();
        }

        private void txtop1_TextChanged(object sender, EventArgs e)
        {
            validarr1();
        }

        private void txtnp1_TextChanged(object sender, EventArgs e)
        {
            validarr1();
        }

        private void txtc1_TextChanged(object sender, EventArgs e)
        {
            validarr1();
        }

        private void rtxt1_TextChanged(object sender, EventArgs e)
        {
            validarr1();
        }

      

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
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
                CargarListado11();
                //lista4();
               // buscar4();
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
          //  (dataGridViewop1.DataSource as DataTable).DefaultView.RowFilter = string.Format("Nombre= '{0}'", textBox6.Text);

        }

        private void txtop1_KeyPress(object sender, KeyPressEventArgs e)
        {
           

            if (e.KeyChar == 13)
            {
                txtnp1.Focus();
            }
            else
            {
              
            }
        }

        private void txtnp1_KeyPress(object sender, KeyPressEventArgs e)
        {

          

            if (e.KeyChar == 13)
            {
               txtc1.Focus();
            }
            else
            {

            }
        }

        private void txtc1_KeyPress(object sender, KeyPressEventArgs e)
        {
           

            if (e.KeyChar == 13)
            {
               rtxt1.Focus();
            }
            else
            {

            }
        }

        private void rtxt1_KeyPress(object sender, KeyPressEventArgs e)
        {
           

            if (e.KeyChar == 13)
            {
               button4.Focus();
            }
            else
            {

            }
        }

        private void txtop2_KeyPress(object sender, KeyPressEventArgs e)
        {
             if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
            {
                e.Handled = true;
            }

            if (e.KeyChar == 13)
            {
               txtprendaop.Focus();
            }
            else
            {

            }
        }

        private void txtprendaop_KeyPress(object sender, KeyPressEventArgs e)
        {
           

            if (e.KeyChar == 13)
            {
               txtnoper2.Focus();
            }
            else
            {

            }
        }

        private void txtnoper2_KeyPress(object sender, KeyPressEventArgs e)
        {
          

            if (e.KeyChar == 13)
            {
               txtti2.Focus();
            }
            else
            {

            }
        }

        private void txtti2_KeyPress(object sender, KeyPressEventArgs e)
        {
             if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if (e.KeyChar == 13)
            {
               rtxt2.Focus();
            }
            else
            {

            }
        }

        private void rtxt2_KeyPress(object sender, KeyPressEventArgs e)
        {
          

            if (e.KeyChar == 13)
            {
               button1.Focus();
            }
            else
            {

            }
        }

        private void buscaridprenda()
        {
            DataTable dt = new DataTable();

            try
            {
                re.Op = Convert.ToInt32(textBox4.Text);
                dt = re.Buscarop1(re.Op);
             dataGridViewop1.Rows.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dataGridViewop1.DefaultCellStyle.Font = new Font("Nirmala UI", 7);
                    dataGridViewop1.RowTemplate.Height = 13;
                    dataGridViewop1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridViewop1.Font, FontStyle.Bold);
                    dataGridViewop1.Rows.Add(dt.Rows[i][0]);
                    dataGridViewop1.Rows[i].Cells[0].Value = dt.Rows[i][0].ToString();
                    dataGridViewop1.Rows[i].Cells[1].Value = dt.Rows[i][1].ToString();
                    dataGridViewop1.Rows[i].Cells[2].Value = dt.Rows[i][2].ToString();
                    dataGridViewop1.Rows[i].Cells[3].Value = dt.Rows[i][3].ToString();
                    dataGridViewop1.Rows[i].Cells[4].Value = dt.Rows[i][4].ToString();
                    dataGridViewop1.Rows[i].Cells[5].Value = dt.Rows[i][5].ToString();
                    dataGridViewop1.Rows[i].Cells[7].Value = dt.Rows[i][7].ToString();
                    byte[] img =(byte[])dt.Rows[0][6];
                    FreezeBand(dataGridViewop1.Columns[1]);
                    System.IO.MemoryStream ms = new System.IO.MemoryStream(img);
                    pictureBox1.Image = Image.FromStream(ms);
                    // dataGridViewop1.Rows[i].Cells[5].Value = dt.Rows[i][5].ToString();


                }
                Verresul1();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Id incorrecto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            dataGridViewop1.ClearSelection();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                DataRow row;
                re.Op = Convert.ToInt32(txtop2.Text);
                dt = re.Buscarop1(re.Op);
                if (dt.Rows.Count == 1)
                {
                    row = dt.Rows[0];
                  //  txtop2.Text = row[0].ToString();
                   //txtprendaop.Text = row[1].ToString();
                   // txtcateoperacion.Text = row[2].ToString();

                
                    txtprendaop.Text = row[2].ToString();
                    textBox8.Text = row[1].ToString();
                  
                    txtcateoperacion.Text = row[3].ToString();

                   
                    textBox6.Text = row[5].ToString();

                  //  MessageBox.Show("Registro Encontrado Ok...!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarListado();
                }
                else
                {
                    MessageBox.Show("Registro no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CargarListado();
                }
            }
            catch (Exception ex)
            {
              //  MessageBox.Show("Valor del ID incorrecto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void dataGridViewop1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {


                int a = 0;
                textBox4.Text = dataGridViewop1.CurrentCell.Value.ToString();
                a = Convert.ToInt32(textBox4.Text);
                try
                {
                    re.Op = Convert.ToInt32(textBox4.Text);

                    if (MessageBox.Show(" ¿ Esta seguro de eliminar el registro " + a + " ?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        re.Eliminarop1();

                      //  RET.Eliminarop2op2();
                        Verresul();
                        CargarListado();

                        CargarListado11();

                    }
                    //  MessageBox.Show(re.Eliminarop1(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Limpiar();
                    Verresul();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dataopb_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int a = 0;
                txtnupe2.Text = dataopb.CurrentCell.Value.ToString();
                a = Convert.ToInt32(txtnupe2.Text);

                try
                {
                    RET.Numero = Convert.ToInt32(txtnumero.Text);
                    if (MessageBox.Show("¿ Esta seguro de eliminar el registro " + a + " ?", "Eliminar ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Verresul();
                        RET.Eliminarop2();
                        CargarListado();

                    }
                    //  MessageBox.Show(re.Eliminarop1(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Limpiar();
                    Verresul();
                    // Sumadetiempo();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void limpiarid()
        {
            txtop1.Text="";
            txtnp1.Text="";
            txtc1.Text="";
            rtxt1.Text="";
            textBox6.Text="";
        }
        private void button5_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog fo = new OpenFileDialog();
            DialogResult rs = fo.ShowDialog();
            if(rs == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(fo.FileName);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            limpiarid();
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Buscaropera1();
              
            }
            else
            {
                CargarListado11();
           
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox8_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                string f;

                f = Convert.ToString("  SELECT  * FROM solooperacion  WHERE referencia  LIKE '" + textBox8.Text + "%'");
                textBox1.Text = Convert.ToString(f);
                DataTable dtm1 = new DataTable("solooperacion");
                using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["CnnORDEN"].ConnectionString))
                {
                    if (cn.State == ConnectionState.Closed)
                        cn.Open();

                    using (SqlDataAdapter da = new SqlDataAdapter(textBox1.Text, cn))

                        //da.Fill(dtm1);
                       // dataopb.DataSource = da;

                    // DataGridViewColumn column = dataGridView8.Columns[0];
                    //  column.Visible = false;
                    dataopb.DefaultCellStyle.Font = new Font("Nirmala UI", 7);
                    dataopb.RowTemplate.Height = 13;
                    dataopb.ColumnHeadersDefaultCellStyle.Font = new Font(dataopb.Font, FontStyle.Bold); // negrita en titulos

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
               // MessageBox.Show("Sin número de cédula", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Focus();
                // label2.Text = "REGISTRO NO ENCONTRADO";
            }
        }
        private void Buscaropera1()
        {
            DataTable dt = new DataTable();

            try
            {
                RET.Descripcionopera = textBox4.Text;
              
                dt = RET.Buscaropp(RET.Descripcionopera);
                dataGridViewop1.Rows.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dataGridViewop1.DefaultCellStyle.Font = new Font("Nirmala UI", 7);
                    dataGridViewop1.RowTemplate.Height = 13;
                    dataGridViewop1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridViewop1.Font, FontStyle.Bold);
                    dataGridViewop1.Rows.Add(dt.Rows[i][0]);
                    dataGridViewop1.Rows[i].Cells[0].Value = dt.Rows[i][0].ToString();
                    dataGridViewop1.Rows[i].Cells[1].Value = dt.Rows[i][1].ToString();
                    dataGridViewop1.Rows[i].Cells[2].Value = dt.Rows[i][2].ToString();
                    dataGridViewop1.Rows[i].Cells[3].Value = dt.Rows[i][3].ToString();
                    dataGridViewop1.Rows[i].Cells[4].Value = dt.Rows[i][4].ToString();
                    dataGridViewop1.Rows[i].Cells[5].Value = dt.Rows[i][5].ToString();
                    dataGridViewop1.Rows[i].Cells[7].Value = dt.Rows[i][7].ToString();
                    FreezeBand(dataGridViewop1.Columns[1]);


                }
                Verresul1();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Sin datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dataGridViewop1.ClearSelection();
        }
        private void Buscaropera()
        {
            DataTable dt = new DataTable();

            try
            {
                RET.Descripcionopera = textBox7.Text;
                RET.Descripcionpp = textBox8.Text;
                dt = RET.Buscarop5(RET.Descripcionopera,RET.Descripcionpp);
                dataopb.Rows.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dataopb.DefaultCellStyle.Font = new Font("Nirmala UI", 7);
                    dataopb.RowTemplate.Height = 13;
                    dataopb.ColumnHeadersDefaultCellStyle.Font = new Font(dataopb.Font, FontStyle.Bold);
                    dataopb.Rows.Add(dt.Rows[i][0]);
                    dataopb.Rows[i].Cells[0].Value = dt.Rows[i][0].ToString();
                    dataopb.Rows[i].Cells[1].Value = dt.Rows[i][1].ToString();
                    dataopb.Rows[i].Cells[2].Value = dt.Rows[i][2].ToString();
                    dataopb.Rows[i].Cells[3].Value = dt.Rows[i][3].ToString();
                    dataopb.Rows[i].Cells[4].Value = dt.Rows[i][4].ToString();
                    dataopb.Rows[i].Cells[5].Value = dt.Rows[i][5].ToString();
                    dataopb.Rows[i].Cells[6].Value = dt.Rows[i][6].ToString();
                    dataopb.Rows[i].Cells[7].Value = dt.Rows[i][7].ToString();
                    dataopb.Rows[i].Cells[8].Value = dt.Rows[i][8].ToString();
                    dataopb.Rows[i].Cells[9].Value = dt.Rows[i][9].ToString();
                    dataopb.Rows[i].Cells[10].Value = dt.Rows[i][10].ToString();
                    dataopb.Rows[i].Cells[11].Value = dt.Rows[i][11].ToString();
                    dataopb.Rows[i].Cells[12].Value = dt.Rows[i][12].ToString();
                    FreezeBand1(dataopb.Columns[2]);
                    Verresul();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Sin datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dataopb.ClearSelection();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Buscaropera();
        }

        private void txtcateoperacion_TextChanged(object sender, EventArgs e)
        {
            validarr();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            limpiarope();
        }

        private void textBox4_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void dataopb_VisibleChanged(object sender, EventArgs e)
        {
            int o = Convert.ToInt32(textBox3.Text);
            if (o == 0 && textBox3.Text != null)
            {
                dataopb.ColumnHeadersVisible = false;
            }

            else

            {
                dataopb.ColumnHeadersVisible = true;
            }
        }

        private void dataopb_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void dataGridViewop1_VisibleChanged(object sender, EventArgs e)
        {
            int o = Convert.ToInt32(textBox5.Text);
            if (o == 0 && textBox5.Text != null)
            {
                dataGridViewop1.ColumnHeadersVisible = false;
            }

            else

            {
                dataGridViewop1.ColumnHeadersVisible = true;
            }
        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {
          

        }

        private void dataopb_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void dataopb_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            
        }
        private static void FreezeBand(DataGridViewBand band)
        {
           // band.Frozen = true;
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.BackColor = Color.LightGray;
            band.DefaultCellStyle = style;
        }
        private static void FreezeBand1(DataGridViewBand band)
        {
            band.Frozen = true;
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.BackColor = Color.LightGray;
            band.DefaultCellStyle = style;
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            int o = Convert.ToInt32(textBox3.Text);
            if (o == 0 && textBox3.Text != null)
            {
                dataopb.ColumnHeadersVisible = false;
            }

            else
               
            {
                dataopb.ColumnHeadersVisible = true;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            int o = Convert.ToInt32(textBox5.Text);
            if (o == 0 && textBox5.Text != null)
            {
                dataGridViewop1.ColumnHeadersVisible = false;
            }

            else

            {
                dataGridViewop1.ColumnHeadersVisible = true;
            }
        }

        private void dataGridViewop1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            dataGridViewop1.EnableHeadersVisualStyles = false;
            DataGridViewColumn dataGridViewColumn = dataGridViewop1.Columns[1];
            dataGridViewColumn.HeaderCell.Style.BackColor = Color.LightGray;
            dataGridViewColumn.HeaderCell.Style.ForeColor = Color.Black;

            Color cl = dataGridViewColumn.HeaderCell.Style.BackColor;
            //or   
            Color cl2 = dataGridViewop1.Columns[0].HeaderCell.Style.BackColor;
        }

        private void dataopb_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            dataopb.EnableHeadersVisualStyles = false;
            DataGridViewColumn dataGridViewColumn = dataopb.Columns[2];
            dataGridViewColumn.HeaderCell.Style.BackColor = Color.LightGray;
            dataGridViewColumn.HeaderCell.Style.ForeColor = Color.Black;

            Color cl = dataGridViewColumn.HeaderCell.Style.BackColor;
            //or   
            Color cl2 = dataopb.Columns[0].HeaderCell.Style.BackColor;
        }
    }
}
