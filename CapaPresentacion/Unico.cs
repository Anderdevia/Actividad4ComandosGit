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
using WindowsFormsApp1;

namespace CapaPresentacion
{
    public partial class Unico : Form,Iopfinal,Ioperafin
    {
        public Unico()
        {
            InitializeComponent();
        }
        ClsReglasEmpleados Reglas = new ClsReglasEmpleados();
        ClsTBL_EMPLEADOS TblAtri = new ClsTBL_EMPLEADOS();
        Clsunico uni = new Clsunico();
        clshorario h = new clshorario();
        Clsfinal F = new Clsfinal();
        Clsreporte D = new Clsreporte();
        clshorario O = new clshorario();
        DataTable dt1 = new DataTable("t_abierta");
        // DataTable dt2 = new DataTable("t_cerrada");
        DataTable dt3 = new DataTable("operafin");
        private Button reportButton = new Button();
        public Iopfinal contrato102 { get; set; }
        private void Unico_Load(object sender, EventArgs e)
        {
           
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial Rounded MT", 6);  //tamaño en titulos
          
            dateTimePicker6.Value = DateTime.Today;
            button6.Enabled = false;
            button7.Enabled = false;
            button1.Enabled = false;
            tabControl1.Enabled = false;
         //   lista1();
           lista110();
          //  cargalistahorario();
         //  Cargarlista4();
            // Listar4();
            timer1.Start();
           
  
         //   Cargarlistado2();
          //  hide();
           
          // listatproceso();
          //  listahorario();
            listavalida();
           
            botongrid();
            botongrid1();
            botongrid2();
            //dataGridView4.AutoSizeColumnsMode =
            //DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView4.ColumnHeadersDefaultCellStyle.Font = new Font("Arial Rounded MT", 6);  //tamaño en titulos
            dataGridView4.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView4.Font, FontStyle.Bold); // negrita en titulos
            dataGridView4.RowTemplate.Height = 13;

            dataGridView5.ColumnHeadersDefaultCellStyle.Font = new Font("Arial Rounded MT", 6);  //tamaño en titulos
            dataGridView5.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView4.Font, FontStyle.Bold); // negrita en titulos
            dataGridView7.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView7.Font, FontStyle.Bold); // negrita en titulos
            dataGridView5.RowTemplate.Height = 13;
            dataGridView7.RowTemplate.Height = 13;
            DataTable dt = CategoryAll();
            comboBox2.DataSource = dt;
            comboBox2.ValueMember = "id";
            comboBox2.DisplayMember = "proceso";
            hide7();

            //  string Mensaje = "Entrar";
            // MessageBox.Show(Mensaje, "Producción.", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

            this.Cursor = Cursors.Default;
        }
        private void listavalida()
        {

            try
            {
                DataTable dt = new DataTable();
                DataRow row;
                F.Valor1 = Convert.ToInt32(textBox60.Text);
                dt = F.Buscarvalida(F.Valor1);
                if (dt.Rows.Count == 1)
                {
                    row = dt.Rows[0];
                    textBox60.Text = row[0].ToString();
                   // txt2p.Text = row[1].ToString();
                    txt2p.Text = row[2].ToString();
                    txt3p.Text = row[3].ToString();
                    txt4p.Text = row[4].ToString();
                    txt5p.Text = row[5].ToString();
                    txt6p.Text = row[6].ToString();
                    txtim.Text = row[7].ToString();
                    txtfes.Text = row[8].ToString();



                    // MessageBox.Show("Registro Encontrado Ok !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Cargarlistado1();
                }
                else
                {
                    MessageBox.Show("Registro de OP no Existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //Limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void Listar4()
        {

            DataTable dt = new DataTable();
            dt = F.Listadopfin();
            try
            {
                dataGridView4.Rows.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dataGridView4.Rows.Add(dt.Rows[i][0]);
                    dataGridView4.Rows[i].Cells[0].Value = dt.Rows[i][0].ToString();
                    dataGridView4.Rows[i].Cells[1].Value = dt.Rows[i][1].ToString();
                    dataGridView4.Rows[i].Cells[2].Value = dt.Rows[i][2].ToString();
                    dataGridView4.Rows[i].Cells[3].Value = dt.Rows[i][3].ToString();
                    dataGridView4.Rows[i].Cells[4].Value = dt.Rows[i][4].ToString();

                    dataGridView4.Rows[i].Cells[5].Value = dt.Rows[i][4].ToString();
                    dataGridView4.Rows[i].Cells[6].Value = dt.Rows[i][5].ToString();
                    dataGridView4.Rows[i].Cells[7].Value = dt.Rows[i][6].ToString();
                    dataGridView4.Rows[i].Cells[8].Value = dt.Rows[i][7].ToString();
                    dataGridView4.Rows[i].Cells[9].Value = dt.Rows[i][8].ToString();
                    dataGridView4.Rows[i].Cells[10].Value = dt.Rows[i][9].ToString();
                    dataGridView4.Rows[i].Cells[11].Value = dt.Rows[i][10].ToString();
                    dataGridView4.Rows[i].Cells[12].Value = dt.Rows[i][11].ToString();
                    dataGridView4.Rows[i].Cells[13].Value = dt.Rows[i][12].ToString();
                    dataGridView4.Rows[i].Cells[14].Value = dt.Rows[i][13].ToString();
                    dataGridView4.Rows[i].Cells[15].Value = dt.Rows[i][14].ToString();
                    dataGridView4.Rows[i].Cells[16].Value = dt.Rows[i][15].ToString();
                    dataGridView4.Rows[i].Cells[17].Value = dt.Rows[i][16].ToString();
                    dataGridView4.Rows[i].Cells[18].Value = dt.Rows[i][17].ToString();
                    dataGridView4.Rows[i].Cells[19].Value = dt.Rows[i][18].ToString();
                    dataGridView4.Rows[i].Cells[20].Value = dt.Rows[i][19].ToString();
                    dataGridView4.Rows[i].Cells[21].Value = dt.Rows[i][20].ToString();
                    dataGridView4.Rows[i].Cells[22].Value = dt.Rows[i][21].ToString();
                    dataGridView4.Rows[i].Cells[23].Value = dt.Rows[i][22].ToString();
                    dataGridView4.Rows[i].Cells[24].Value = dt.Rows[i][23].ToString();


                    //  Verresul2();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            dataGridView4.ClearSelection();
        }
        private void Cargarlistado1()

        {
            try { 
            DataTable dt1 = new DataTable();
            dt1 = F.Listanumero();
            dataGridView1.DataSource = dt1;
                        // Verresul2();
                        //color();
                        //color3();
                  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataGridView1.ClearSelection();
            //Verresul();
        }
      
        private void Cargarlistado()

        {
            try
            {
                DataTable dt5 = new DataTable();
                dt5 = F.Listadopfin();

                dataGridView6.DataSource = dt5;

              
                        // Verresul2();
                        //color();
                        //color3();
                   
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message);
            }
            dataGridView4.ClearSelection();
            //Verresul();
        }
        private void lista110()
        {
            try
            {

                DataTable dt5 = new DataTable();
                dt5 = F.Listadopfin();

                        dataGridView7.DataSource = dt5;
                        dataGridView7.ColumnHeadersDefaultCellStyle.Font = new Font("Nirmala UI", 6);  //tamaño en titulos
                        dataGridView7.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView7.Font, FontStyle.Bold); // negrita en titulos
                        dataGridView7.RowTemplate.Height = 13;
                        dataGridView7.Columns[0].HeaderText = "Id";
                        dataGridView7.Columns[0].Width = 40;
                        dataGridView7.Columns[1].HeaderText = "Cedula";
                        dataGridView7.Columns[2].HeaderText = "Empleado";
                dataGridView7.Columns[2].Width = 150;
                dataGridView7.Columns[3].HeaderText = "Cargo";
                        dataGridView7.Columns[4].HeaderText = "OP";
                        dataGridView7.Columns[4].Width = 50;
                        dataGridView7.Columns[5].HeaderText = "Id Prenda";
                        dataGridView7.Columns[6].HeaderText = "Prenda";
                        dataGridView7.Columns[6].Width = 100;
                        dataGridView7.Columns[7].HeaderText = "Id Operacion";
                        dataGridView7.Columns[8].HeaderText = "Operacion";
                        dataGridView7.Columns[8].Width = 200;
                        dataGridView7.Columns[9].HeaderText = "Categoria";
                        dataGridView7.Columns[9].Width = 105;
                        dataGridView7.Columns[10].HeaderText = "Tiempo";
                        dataGridView7.Columns[10].Width = 50;
                        dataGridView7.Columns[11].HeaderText = "Cantidad";
                        dataGridView7.Columns[11].Width = 70;
                        dataGridView7.Columns[12].HeaderText = "Total";
                        dataGridView7.Columns[12].Width = 80;
                        dataGridView7.Columns[13].HeaderText = "Horas";
                        dataGridView7.Columns[13].Width = 100;
                        dataGridView7.Columns[14].HeaderText = "F.Inicio";
                        dataGridView7.Columns[14].Width = 65;
                        dataGridView7.Columns[15].HeaderText = "F.Entrega";
                        dataGridView7.Columns[15].Width = 65;
                        dataGridView7.Columns[16].HeaderText = "Sobremedida";
                        dataGridView7.Columns[16].Width = 82;
                        dataGridView7.Columns[17].HeaderText = "XS";
                        dataGridView7.Columns[17].Width = 30;
                        dataGridView7.Columns[18].HeaderText = "S";
                        dataGridView7.Columns[18].Width = 30;
                        dataGridView7.Columns[19].HeaderText = "M";
                        dataGridView7.Columns[19].Width = 30;
                        dataGridView7.Columns[20].HeaderText = "L";
                        dataGridView7.Columns[20].Width = 30;
                        dataGridView7.Columns[21].HeaderText = "XL";
                        dataGridView7.Columns[21].Width = 30;
                        dataGridView7.Columns[22].HeaderText = "XXL";
                        dataGridView7.Columns[22].Width = 30;
                        dataGridView7.Columns[23].HeaderText = "3XL";
                        dataGridView7.Columns[23].Width = 30;
                        dataGridView7.Columns[24].HeaderText = "4XL";
                        dataGridView7.Columns[24].Width = 30;
                        dataGridView7.Columns[25].HeaderText = "5XL";
                        dataGridView7.Columns[25].Width = 30;
                        dataGridView7.Columns[26].HeaderText = "6XL";
                        dataGridView7.Columns[26].Width = 30;
                        dataGridView7.Columns[27].HeaderText = "Fecha";
                        dataGridView7.Columns[28].HeaderText = "Estado";
                        dataGridView7.RowTemplate.Height = 13;
                dataGridView7.Columns[29].HeaderText = "Numero";
                dataGridView7.RowTemplate.Height = 13;

                hide7();
                // Verresul();
                //Verresul2();
                //Verresul3();
                //Verresul4();
               

            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message);
                //lblverno.Text = "Registro no encontrado";
                //MessageBox.Show("Solo se admiten el valor de la OP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void lista()
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["CnnORDEN"].ConnectionString))

                {
                    if (cn.State == ConnectionState.Closed)
                        cn.Open();
                    using (SqlDataAdapter da2 = new SqlDataAdapter("select * from  nuevoregistro", cn))
                    {


                        da2.Fill(dt1);
                        dataGridView1.DefaultCellStyle.Font = new Font("Bookshelf Symbol", 6);
                        dataGridView1.DataSource = dt1;
                        dataGridView1.RowTemplate.Height = 10;
                        dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold); // negrita en titulos
                        dataGridView1.Columns[0].HeaderText = "";
                        dataGridView1.Columns[0].Width = 13;
                        dataGridView1.Columns[1].HeaderText = "Datos";
                        dataGridView1.Columns[2].HeaderText = "Datos";
                        dataGridView1.Columns[3].HeaderText = "";
                        //dataGridView1.Columns[4].HeaderText = "";
                        //dataGridView1.Columns[1].Width = 58;
                        dataGridView1.Columns[2].Width = 70;



                        // dataGridView1.ColumnHeadersVisible = false;
                     //   dataGridView1.RowTemplate.Height = 5;
                     //   DataGridViewColumn column = dataGridView1.Columns[1];
                     //   column.Visible = false;
                        // DataGridViewColumn column1 = dataGridView1.Columns[4];
                        //column1.Visible = false;
                     //   DataGridViewColumn column2 = dataGridView1.Columns[3];
                     //   column2.Visible = false;


                    }

                    //Verresul();
                    //Verresul2();
                    //Verresul3();
                    //Verresul4();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //lblverno.Text = "Registro no encontrado";
                //MessageBox.Show("Solo se admiten el valor de la OP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

       
        private void listatproceso()
        {
            try
            {

                DataTable dt5 = new DataTable();
                dt5 = uni.Listadoprocesoempleado();
                // if (cn.State == ConnectionState.Closed)
                //  cn.Open();
                //  using (SqlDataAdapter da = new SqlDataAdapter("select * from  prendasmodi ", cn))
                //  O.Actualizadato1.Fill();
                dataGridView3.DataSource = dt5;

                

                // dataGridView4.ColumnHeadersVisible = false;  // encabezado
                //DataGridViewColumn column = dataGridView1.Columns[0];
                // column.Visible = false;
                dataGridView3.ColumnHeadersDefaultCellStyle.Font = new Font("Arial Rounded MT", 6);  //tamaño en titulos
                dataGridView3.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView3.Font, FontStyle.Bold); // negrita en titulos
                dataGridView3.RowTemplate.Height = 13;
                dataGridView3.Columns[0].HeaderText = "Id";
                dataGridView3.Columns[0].Width = 50;
                dataGridView3.Columns[1].HeaderText = "Nombre";
                dataGridView3.Columns[1].Width = 110;
                dataGridView3.Columns[2].HeaderText = "Cedula";
                dataGridView3.Columns[2].Width = 70;
                dataGridView3.Columns[3].HeaderText = "Compañia";
                dataGridView3.Columns[3].Width = 60;
                dataGridView3.Columns[4].HeaderText = "Operario";
                dataGridView3.Columns[4].Width = 60;
                dataGridView3.Columns[5].HeaderText = "Observación";
                dataGridView3.Columns[5].Width = 75;
                dataGridView3.Columns[6].HeaderText = "ProcesoA.";
                dataGridView3.Columns[6].Width = 50;
                dataGridView3.Columns[7].HeaderText = "Estado";
                dataGridView3.Columns[7].Width = 70;
                dataGridView3.Columns[8].HeaderText = "Fecha";
                dataGridView3.Columns[8].Width = 70;
                dataGridView3.Columns[9].HeaderText = "Nombre";
                dataGridView3.Columns[9].Width = 70;
                // dataGridView3.ColumnHeadersVisible = false;  // encabezado//
                // DataGridViewColumn column = dataGridView.Columns[0];
                DataGridViewColumn column = dataGridView3.Columns[6];
                 column.Visible = false;
                DataGridViewColumn column1 = dataGridView3.Columns[7];
                column1.Visible = false;

                Verresulprocesos();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //lblverno.Text = "Registro no encontrado";
                //MessageBox.Show("Solo se admiten el valor de la OP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void cargalistahorario()
        {
            try
            { 
            DataTable dt5 = new DataTable();
            dt5 = h.Listadohorario();
       
            dataGridView6.DataSource = dt5;

            dataGridView6.ColumnHeadersDefaultCellStyle.Font = new Font("Arial Rounded MT", 6);  //tamaño en titulos
            dataGridView6.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView6.Font, FontStyle.Bold); // negrita en titulos
            dataGridView6.RowTemplate.Height = 13;
         
                dataGridView6.Columns[0].HeaderText = "Id";
                dataGridView6.Columns[0].Width = 50;
                dataGridView6.Columns[1].HeaderText = "Cedula";
                dataGridView6.Columns[1].Width = 70;
                dataGridView6.Columns[2].HeaderText = "Empleado";
                dataGridView6.Columns[2].Width = 110;
                dataGridView6.Columns[3].HeaderText = "Horario";
                dataGridView6.Columns[3].Width = 50;
                dataGridView6.Columns[4].HeaderText = "Dia";
                dataGridView6.Columns[4].Width = 50;
                dataGridView6.Columns[5].HeaderText = "Fecha";
                dataGridView6.Columns[5].Width = 80;
                dataGridView6.Columns[6].HeaderText = "Entrada";
                dataGridView6.Columns[6].Width = 50;
                dataGridView6.Columns[7].HeaderText = "Salida";
                dataGridView6.Columns[7].Width = 50;
                dataGridView6.Columns[8].HeaderText = "Improductivos";
                dataGridView6.Columns[8].Width = 85;
                dataGridView6.Columns[9].HeaderText = "Dia";
                dataGridView6.Columns[9].Width = 50;
                dataGridView6.Columns[10].HeaderText = "Total";
                dataGridView6.Columns[10].Width = 50;
                dataGridView6.Columns[11].HeaderText = "Estado";
                dataGridView6.Columns[11].Width = 50;
                DataGridViewColumn column = dataGridView6.Columns[11];
                  column.Visible = false;

                Verresulhorario();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //lblverno.Text = "Registro no encontrado";
                //MessageBox.Show("Solo se admiten el valor de la OP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Verresulop()
        {
            int baser = 0;
            int baser1 = 0;
            int resultado = 0;

            double total = 0;
            foreach (DataGridViewRow row in dataGridView7.Rows)
             {

                total += Convert.ToDouble(row.Cells[10].Value) * Convert.ToDouble(row.Cells[11].Value);
                row.Cells[dataGridView7.Columns[12].Index].Value = (Convert.ToDecimal(row.Cells[dataGridView7.Columns[11].Index].Value) * Convert.ToDecimal(row.Cells[dataGridView7.Columns[10].Index].Value));

            }
            txtminutosproduccion.Text = total.ToString("N");
            textBox10.Text = dataGridView7.RowCount.ToString();
            //   Convert.ToString(ded.ToString("00.0"));
         //   decimal sum = 0;
         //   for (int i = 0; i < dataGridView7.Rows.Count; ++i)
           // {
          //      sum += Convert.ToDecimal(dataGridView7.Rows[i].Cells[12].Value);
          //  }
         //   textBox13.Text = sum.ToString("N");
          //  int sum1 = 0;
           // for (int i = 0; i < dataGridView6.Rows.Count; ++i)
           // {
           //     sum1 += Convert.ToInt32(dataGridView6.Rows[i].Cells[10].Value);
           // }
           // txttotalminutos.Text = sum1.ToString("N");
            // baser = Convert.ToInt32(textBox9.Text);
            //baser1 = Convert.ToInt32(textBox5.Text);
            // resultado = baser + baser1;
            // txtiddope.Text = Convert.ToString(resultado);

            // textBox7.Text = sum.ToString();
        }
        private void Verresulhorario()
        {
            int baser = 0;
            int baser1 = 0;
            int resultado = 0;

            double total = 0;
          //  foreach (DataGridViewRow row in dataGridView6.Rows)
           // {

            //    total += Convert.ToDouble(row.Cells[9].Value);
            //    row.Cells[dataGridView6.Columns[10].Index].Value = (Convert.ToDecimal(row.Cells[dataGridView6.Columns[10].Index].Value));
           // }
           // textBox8.Text = total.ToString("N");
            textBox9.Text = dataGridView6.RowCount.ToString();
            //   Convert.ToString(ded.ToString("00.0"));
            int sum = 0;
            for (int i = 0; i < dataGridView6.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView6.Rows[i].Cells[8].Value);
            } 
            txtminutosimproductivos.Text = sum.ToString("N");
            int sum1 = 0;
            for (int i = 0; i < dataGridView6.Rows.Count; ++i)
            {
                sum1 += Convert.ToInt32(dataGridView6.Rows[i].Cells[10].Value);
            }
            txttotalminutos.Text = sum1.ToString("N");
            // baser = Convert.ToInt32(textBox9.Text);
            //baser1 = Convert.ToInt32(textBox5.Text);
            // resultado = baser + baser1;
            // txtiddope.Text = Convert.ToString(resultado);

            // textBox7.Text = sum.ToString();
        }

        private void Verresulprocesos()
        {
            // int baser = 0;
            // int baser1 = 0;
            //int resultado = 0;

            //  double total = 0;
             // foreach (DataGridViewRow row in dataGridView2.Rows)
            // {

            // total += Convert.ToDouble(row.Cells[6].Value) * Convert.ToDouble(row.Cells[7].Value);
            // row.Cells[dataGridView3.Columns[8].Index].Value = (Convert.ToDecimal(row.Cells[dataGridView2.Columns[6].Index].Value) * Convert.ToDecimal(row.Cells[dataGridView1.Columns[7].Index].Value));

            //  }
            // textBox17.Text = total.ToString("N");
           textBox15.Text = dataGridView3.RowCount.ToString();
            //   Convert.ToString(ded.ToString("00.0"));
            decimal sum = 0;
            decimal sum1 = 0;
            for (int i = 0; i < dataGridView3.Rows.Count; ++i)
            {
                sum += Convert.ToDecimal(dataGridView3.Rows[i].Cells[3].Value);
            }
            textBox26.Text = sum.ToString();
            for (int i = 0; i < dataGridView3.Rows.Count; ++i)
            {
                sum1 += Convert.ToDecimal(dataGridView3.Rows[i].Cells[4].Value);
            }
            textBox25.Text = sum1.ToString();
            // baser = Convert.ToInt32(textBox10.Text);
            // baser1 = Convert.ToInt32(textBox5.Text);
            // resultado = baser + baser1;
            //  txtiddope.Text = Convert.ToString(resultado);
            // textBox26.Text = sum.ToString("N");
            //  listaopera();
            // color();
            // colorazul();
        }
        private void listahorario()

        {
            try
            {

                DataTable dt5 = new DataTable();
                dt5 = h.Listadohorario();

                dataGridView6.DataSource = dt5;             
                dataGridView6.ColumnHeadersDefaultCellStyle.Font = new Font("Arial Rounded MT", 6);  //tamaño en titulos
                dataGridView6.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView6.Font, FontStyle.Bold); // negrita en titulos
                dataGridView6.RowTemplate.Height = 13;
                dataGridView6.DataSource = dt5;
                Verresulhorario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataGridView6.ClearSelection();
            //Verresul();
        }
        private void botongrid()
        {

            DataGridViewButtonColumn btna = new DataGridViewButtonColumn();

            
            btna.Name = "nota1";
            btna.HeaderText = "";
            btna.DefaultCellStyle.BackColor = Color.White;
            btna.FlatStyle = FlatStyle.Flat;
            btna.UseColumnTextForButtonValue = false;

            // dataGridView1.BorderStyleChanged(0, );
            //dataGridView1.Columns.Add(btna);
            dataGridView1.RowTemplate.Height = 11;
            dataGridView1.Columns.Insert(0, btna);
        }
      
        private void botongrid1()
        {
            //DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            // buttonColumn.HeaderText = "";
            // buttonColumn.Name = "Status Request";
            // buttonColumn.Text = "Request Status";
            // dataGridView4.Columns.Insert(4, buttonColumn);
            //buttonColumn.UseColumnTextForButtonValue = true;///boton anexo



            // dataGridView4.Columns.Add(buttonColumn);


            DataGridViewButtonColumn btna = new DataGridViewButtonColumn();
            btna.Name = "op";
            btna.HeaderText = "";
            // dataGridView4.Columns.Add(btna);
            dataGridView4.RowTemplate.Height = 12;
            dataGridView4.Columns.Insert(0, btna);
            btna.DefaultCellStyle.BackColor = Color.White;
            btna.FlatStyle = FlatStyle.Flat;
            btna.UseColumnTextForButtonValue = false;
            // btna.bo = new BorderStyle(dataGridView4.Font, BorderStyle.None);
        }
        private void botongrid2()
        {
            //DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            // buttonColumn.HeaderText = "";
            // buttonColumn.Name = "Status Request";
            // buttonColumn.Text = "Request Status";
            // dataGridView4.Columns.Insert(4, buttonColumn);
            //buttonColumn.UseColumnTextForButtonValue = true;///boton anexo



            // dataGridView4.Columns.Add(buttonColumn);


            DataGridViewButtonColumn btna = new DataGridViewButtonColumn();
            btna.Name = "op1";
            btna.HeaderText = "";
            // dataGridView4.Columns.Add(btna);
            dataGridView5.RowTemplate.Height = 12;
            dataGridView5.Columns.Insert(0, btna);
            btna.DefaultCellStyle.BackColor = Color.White;
            btna.FlatStyle = FlatStyle.Flat;
            btna.UseColumnTextForButtonValue = false;
            // btna.bo = new BorderStyle(dataGridView4.Font, BorderStyle.None);
        }
        private void hide()
        {
            try
            {



                dataGridView4.DefaultCellStyle.Font = new Font("Bookshelf Symbol", 7);
              //   DataGridViewColumn column = dataGridView4.Columns[0];
              //  column.Visible = false;
                DataGridViewColumn column22 = dataGridView4.Columns[0];
                column22.Visible = false;
                DataGridViewColumn column8 = dataGridView4.Columns[1];
                 column8.Visible = false;
                DataGridViewColumn column1 = dataGridView4.Columns[2];
                column1.Visible = false;
                DataGridViewColumn column2 = dataGridView4.Columns[3];
                column2.Visible = false;
               // DataGridViewColumn column6 = dataGridView4.Columns[4];
               // column6.Visible = false;
                DataGridViewColumn column3 = dataGridView4.Columns[5];
                column3.Visible = false;
               // DataGridViewColumn column4 = dataGridView4.Columns[6];
               // column4.Visible = false;
                DataGridViewColumn column9 = dataGridView4.Columns[7];
                column9.Visible = false;
                DataGridViewColumn column10 = dataGridView4.Columns[8];
                column10.Visible = false;

             DataGridViewColumn column11 = dataGridView4.Columns[12];
                 column11.Visible = false;
                 DataGridViewColumn column5 = dataGridView4.Columns[14];
                column5.Visible = false;
                DataGridViewColumn column6 = dataGridView4.Columns[15];
                  column6.Visible = false;
                DataGridViewColumn column20 = dataGridView4.Columns[28];
                column20.Visible = false;



                dataGridView5.DefaultCellStyle.Font = new Font("Bookshelf Symbol", 7);
                //   DataGridViewColumn column = dataGridView4.Columns[0];
                //  column.Visible = false;
                DataGridViewColumn column50 = dataGridView5.Columns[0];
                column50.Visible = false;
                DataGridViewColumn column51 = dataGridView5.Columns[1];
                column51.Visible = false;
                DataGridViewColumn column52 = dataGridView5.Columns[2];
                column52.Visible = false;
                DataGridViewColumn column53 = dataGridView5.Columns[3];
                column53.Visible = false;
                DataGridViewColumn column54 = dataGridView5.Columns[5];
                column54.Visible = false;
                DataGridViewColumn column55 = dataGridView5.Columns[7];
                column55.Visible = false;
                DataGridViewColumn column56 = dataGridView5.Columns[12];
                column56.Visible = false;
                DataGridViewColumn column57 = dataGridView5.Columns[14];
                column57.Visible = false;
                DataGridViewColumn column58 = dataGridView5.Columns[15];
                column58.Visible = false;

                DataGridViewColumn column59 = dataGridView5.Columns[28];
                column59.Visible = false;
               // DataGridViewColumn column60 = dataGridView5.Columns[14];
               // column60.Visible = false;
               // DataGridViewColumn column61 = dataGridView5.Columns[15];
              //  column61.Visible = false;
              //  DataGridViewColumn column62 = dataGridView5.Columns[28];
              //  column62.Visible = false;







            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                //lblverno.Text = "Registro no encontrado";
              //  MessageBox.Show("No se puede organizar una tabla con menos de 10 de columnas", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void hide7()
        {
            try
            {



                dataGridView7.DefaultCellStyle.Font = new Font("Nirmala UI", 7);
                //   DataGridViewColumn column = dataGridView4.Columns[0];
                //  column.Visible = false;
              //  DataGridViewColumn column22 = dataGridView7.Columns[0];
               // column22.Visible = false;
                DataGridViewColumn column8 = dataGridView7.Columns[1];
                column8.Visible = false;
               // DataGridViewColumn column1 = dataGridView7.Columns[2];
               // column1.Visible = false;
                DataGridViewColumn column2 = dataGridView7.Columns[3];
                column2.Visible = false;
                 DataGridViewColumn column4 = dataGridView7.Columns[5];
               column4.Visible = false;
                DataGridViewColumn column9 = dataGridView7.Columns[7];
                column9.Visible = false;
                DataGridViewColumn column6 = dataGridView7.Columns[28];
                 column6.Visible = false;
                DataGridViewColumn column3 = dataGridView7.Columns[29];
                column3.Visible = false;

                Verresulop();
                //
                //DataGridViewColumn column10 = dataGridView4.Columns[8];
                // column10.Visible = false;

                // DataGridViewColumn column11 = dataGridView4.Columns[12];
                //  column11.Visible = false;
                // DataGridViewColumn column5 = dataGridView4.Columns[14];
                // column5.Visible = false;
                // DataGridViewColumn column6 = dataGridView4.Columns[15];
                // column6.Visible = false;
                //  DataGridViewColumn column20 = dataGridView4.Columns[28];
                // column20.Visible = false;



                //  dataGridView5.DefaultCellStyle.Font = new Font("Bookshelf Symbol", 7);
                //   DataGridViewColumn column = dataGridView4.Columns[0];
                //  column.Visible = false;
                // DataGridViewColumn column50 = dataGridView5.Columns[0];
                // column50.Visible = false;
                //  DataGridViewColumn column51 = dataGridView5.Columns[1];
                //  column51.Visible = false;
                //  DataGridViewColumn column52 = dataGridView5.Columns[2];
                //  column52.Visible = false;
                //  DataGridViewColumn column53 = dataGridView5.Columns[3];
                //  column53.Visible = false;
                //  DataGridViewColumn column54 = dataGridView5.Columns[5];
                //  column54.Visible = false;
                // DataGridViewColumn column55 = dataGridView5.Columns[7];
                // column55.Visible = false;
                // DataGridViewColumn column56 = dataGridView5.Columns[12];
                // column56.Visible = false;
                //  DataGridViewColumn column57 = dataGridView5.Columns[14];
                // column57.Visible = false;
                // DataGridViewColumn column58 = dataGridView5.Columns[15];
                // column58.Visible = false;

                //  DataGridViewColumn column59 = dataGridView5.Columns[28];
                //  column59.Visible = false;
                // DataGridViewColumn column60 = dataGridView5.Columns[14];
                // column60.Visible = false;
                // DataGridViewColumn column61 = dataGridView5.Columns[15];
                //  column61.Visible = false;
                //  DataGridViewColumn column62 = dataGridView5.Columns[28];
                //  column62.Visible = false;







            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                //lblverno.Text = "Registro no encontrado";
                //  MessageBox.Show("No se puede organizar una tabla con menos de 10 de columnas", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox11_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dataGridView1.Columns[e.ColumnIndex].Name == "nota1" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                DataGridViewButtonCell celboton = this.dataGridView1.Rows[e.RowIndex].Cells["nota1"] as DataGridViewButtonCell;
                Icon icoto = new Icon(Environment.CurrentDirectory + @" \\a.ico");
                e.Graphics.DrawIcon(icoto, e.CellBounds.Left - 0, e.CellBounds.Top - 0);

                this.dataGridView1.Rows[e.RowIndex].Height = icoto.Height + 1;
                this.dataGridView1.Columns[e.ColumnIndex].Width = icoto.Width + 1;
                e.Handled = true;

                dataGridView1.RowTemplate.Height = 12;
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView4_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dataGridView4.Columns[e.ColumnIndex].Name == "op" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                DataGridViewButtonCell celboton = this.dataGridView4.Rows[e.RowIndex].Cells["op"] as DataGridViewButtonCell;
                Icon icoto = new Icon(Environment.CurrentDirectory + @" \\in1.ico");
                e.Graphics.DrawIcon(icoto, e.CellBounds.Left - 1, e.CellBounds.Top + 0);
                this.dataGridView4.Rows[e.RowIndex].Height = icoto.Height + 1;
                this.dataGridView4.Columns[e.ColumnIndex].Width = icoto.Width + 1;
                e.Handled = true;
            }
        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (this.dataGridView4.Columns[e.ColumnIndex].Name.Equals("op"))
            {
                Formopyem hijo = new Formopyem();
                hijo.contratoop = this;
                hijo.contrato1op = this;
                hijo.contrato2op = this;
                hijo.contrato3op = this;
                hijo.contrato4op = this;
                hijo.contrato5op = this;
                hijo.contrato6op = this;
                hijo.contrato7op = this;
                hijo.contrato8op = this;
                hijo.contrato9op = this;
                hijo.contrato10op = this;
                hijo.contrato11op = this;
                hijo.contrato12op = this;
                hijo.contrato13op = this;
                hijo.contrato14op = this;
                hijo.contrato15op = this;
                hijo.contrato16op = this;


                hijo.ShowDialog();


            }
        }
        private DataTable CategoryAll()
        {
            using (var cn = new SqlConnection(ConfigurationManager.ConnectionStrings["CnnORDEN"].ToString()))
            {
                using (var da = new SqlDataAdapter())
                {
                    using (var cmd = cn.CreateCommand())
                    {
                        cmd.CommandText = "SELECT id, proceso FROM tproceso";
                        da.SelectCommand = cmd;
                        var dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int o;
            string u;
            u = (textBox8.Text.Length.ToString());
            o = Convert.ToInt32(u);

            int w;
                try
                {
                    
                    
                    if (o > 0 )
                    {
                        if (comboBox3.Text == "Compañia")
                        {
                            w = 1;
                            uni.Proceso = textBox8.Text;
                            uni.Proce = Convert.ToInt32(w);
                            MessageBox.Show(uni.Registrar_proceso(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DataTable dt = CategoryAll();
                            comboBox2.DataSource = dt;
                            comboBox2.ValueMember = "id";
                            comboBox2.DisplayMember = "proceso";
                        }
                        else
                        {
                            if (comboBox3.Text == "Empleado")
                            {
                                w = 2;
                                uni.Proceso = textBox8.Text;
                                uni.Proce = Convert.ToInt32(w);


                                MessageBox.Show(uni.Registrar_proceso(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                DataTable dt = CategoryAll();
                                comboBox2.DataSource = dt;
                                comboBox2.ValueMember = "id";
                                comboBox2.DisplayMember = "proceso";
                            }
                            else
                            {
                                w = 3;
                                uni.Proceso = textBox8.Text;
                                uni.Proce = Convert.ToInt32(w);

                                MessageBox.Show(uni.Registrar_proceso(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                DataTable dt = CategoryAll();
                                comboBox2.DataSource = dt;
                                comboBox2.ValueMember = "id";
                                comboBox2.DisplayMember = "proceso";

                            }
                        }
                        //Limpiar();
                    }
                    else
                {
                    MessageBox.Show("Campos Vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                }
            
            catch (Exception ex)
            {
                //   MessageBox.Show(ex.Message);
                // MessageBox.Show("Campos Vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            decimal ter;
            try
            {
                textBox14.Text = "";
                DataTable dt101 = new DataTable();
                DataRow row;
                uni.Proceso = comboBox2.Text;
                textBox17.Text = comboBox2.Text;
                

                dt101 = uni.Buscarproceso(uni.Proceso);

                if (dt101.Rows.Count == 1)
                {

                    row = dt101.Rows[0];

                    textBox14.Text = row[0].ToString();
                    ter = Convert.ToDecimal(textBox14.Text);



                    if (ter == 1)
                    {
                        uni.Nombre = comboBox2.Text;
                        uni.Cedula = Convert.ToInt32(textBox1.Text);
                        uni.Minutos = Convert.ToDecimal(textBox16.Text);
                        uni.Minutos2 = Convert.ToDecimal(0);
                        uni.Observacion = textBox20.Text;
                        uni.Procesoi = Convert.ToInt32(textBox14.Text);
                        uni.Estado = Convert.ToInt32(textBox32.Text);
                        uni.Fecha = dateTimePicker6.Value;
                        uni.Nombree = textBox2.Text;

                        MessageBox.Show(uni.Registrar_procesoempleado(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox16.Text = "";
                        // textBox20.Text = "";
                        textBox14.Text = "";
                        string f1;

                        f1 = Convert.ToString(" select top 500 * from tproceso_empleado  where estado =" + textBox32.Text);
                        textBox34.Text = Convert.ToString(f1);
                        DataTable dtm11 = new DataTable("tproceso_empleado");
                        using (SqlConnection cn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["CnnORDEN"].ConnectionString))
                        {
                            if (cn1.State == ConnectionState.Closed)
                                cn1.Open();

                            using (SqlDataAdapter da = new SqlDataAdapter(textBox34.Text, cn1))

                                da.Fill(dtm11);

                            dataGridView3.DataSource = dtm11;

                            //   DataGridViewColumn column = dataGridView1.Columns[1];
                            //   column.Visible = false;

                            dataGridView3.ColumnHeadersDefaultCellStyle.Font = new Font("Arial Rounded MT", 6);  //tamaño en titulos
                            dataGridView3.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView3.Font, FontStyle.Bold); // negrita en titulos

                            dataGridView3.RowTemplate.Height = 13;
                            dataGridView3.Columns[0].HeaderText = "Id";
                            dataGridView3.Columns[0].Width = 50;
                            dataGridView3.Columns[1].HeaderText = "Nombre";
                            dataGridView3.Columns[1].Width = 110;
                            dataGridView3.Columns[2].HeaderText = "Cedula";
                            dataGridView3.Columns[2].Width = 70;
                            dataGridView3.Columns[3].HeaderText = "Compañia";
                            dataGridView3.Columns[3].Width = 60;
                            dataGridView3.Columns[4].HeaderText = "Operario";
                            dataGridView3.Columns[4].Width = 60;
                            dataGridView3.Columns[5].HeaderText = "Observación";
                            dataGridView3.Columns[5].Width = 75;
                            dataGridView3.Columns[6].HeaderText = "ProcesoA.";
                            dataGridView3.Columns[6].Width = 50;
                            dataGridView3.Columns[7].HeaderText = "Estado";
                            dataGridView3.Columns[7].Width = 70;
                            dataGridView3.Columns[8].HeaderText = "Fecha";
                            dataGridView3.Columns[8].Width = 70;
                            dataGridView3.Columns[9].HeaderText = "Nombre";
                            dataGridView3.Columns[9].Width = 70;
                            // dataGridView3.ColumnHeadersVisible = false;  // encabezado//
                            // DataGridViewColumn column = dataGridView.Columns[0];
                            DataGridViewColumn column = dataGridView3.Columns[6];
                            column.Visible = false;
                            DataGridViewColumn column1 = dataGridView3.Columns[7];
                            column1.Visible = false;


                            Verresulprocesos();
                        }
                    }
                    else
                    {
                        if (ter == 2)
                        {
                            string f2;
                            uni.Nombre = comboBox2.Text;
                            uni.Cedula = Convert.ToInt32(textBox1.Text);
                            uni.Minutos = Convert.ToDecimal(0);
                            uni.Minutos2 = Convert.ToDecimal(textBox16.Text);
                            uni.Observacion = textBox20.Text;
                            uni.Procesoi = Convert.ToInt32(textBox14.Text);
                            uni.Estado = Convert.ToInt32(textBox32.Text);
                            uni.Fecha = dateTimePicker6.Value;
                            uni.Nombree = textBox2.Text;
                            MessageBox.Show(uni.Registrar_procesoempleado(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            textBox16.Text = "";
                            // textBox20.Text = "";
                            textBox14.Text = "";
                            f2 = Convert.ToString(" select top 500 * from tproceso_empleado  where estado =" + textBox32.Text);
                            textBox34.Text = Convert.ToString(f2);
                            DataTable dtm11 = new DataTable("tproceso_empleado");
                            using (SqlConnection cn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["CnnORDEN"].ConnectionString))
                            {
                                if (cn1.State == ConnectionState.Closed)
                                    cn1.Open();

                                using (SqlDataAdapter da = new SqlDataAdapter(textBox34.Text, cn1))

                                    da.Fill(dtm11);

                                dataGridView3.DataSource = dtm11;

                                //   DataGridViewColumn column = dataGridView1.Columns[1];
                                //   column.Visible = false;

                                dataGridView3.ColumnHeadersDefaultCellStyle.Font = new Font("Arial Rounded MT", 6);  //tamaño en titulos
                                dataGridView3.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView3.Font, FontStyle.Bold); // negrita en titulos

                                dataGridView3.RowTemplate.Height = 13;
                                dataGridView3.Columns[0].HeaderText = "Id";
                                dataGridView3.Columns[0].Width = 50;
                                dataGridView3.Columns[1].HeaderText = "Nombre";
                                dataGridView3.Columns[1].Width = 110;
                                dataGridView3.Columns[2].HeaderText = "Cedula";
                                dataGridView3.Columns[2].Width = 70;
                                dataGridView3.Columns[3].HeaderText = "Compañia";
                                dataGridView3.Columns[3].Width = 60;
                                dataGridView3.Columns[4].HeaderText = "Operario";
                                dataGridView3.Columns[4].Width = 60;
                                dataGridView3.Columns[5].HeaderText = "Observación";
                                dataGridView3.Columns[5].Width = 75;
                                dataGridView3.Columns[6].HeaderText = "ProcesoA.";
                                dataGridView3.Columns[6].Width = 50;
                                dataGridView3.Columns[7].HeaderText = "Estado";
                                dataGridView3.Columns[7].Width = 70;
                                dataGridView3.Columns[8].HeaderText = "Fecha";
                                dataGridView3.Columns[8].Width = 70;
                                dataGridView3.Columns[9].HeaderText = "Nombre";
                                dataGridView3.Columns[9].Width = 70;
                                // dataGridView3.ColumnHeadersVisible = false;  // encabezado//
                                // DataGridViewColumn column = dataGridView.Columns[0];
                                DataGridViewColumn column = dataGridView3.Columns[6];
                                column.Visible = false;
                                DataGridViewColumn column1 = dataGridView3.Columns[7];
                                column1.Visible = false;


                                Verresulprocesos();
                            }
                        }
                        else
                        {
                            if (ter == 3)
                            {
                                textBox16.Enabled = false;
                                string f2;
                                uni.Nombre = comboBox2.Text;
                                uni.Cedula = Convert.ToInt32(textBox1.Text);
                                uni.Minutos = Convert.ToDecimal(0);
                                uni.Minutos2 = Convert.ToDecimal(0);
                                uni.Observacion = textBox20.Text;
                                uni.Procesoi = Convert.ToInt32(textBox14.Text);
                                uni.Estado = Convert.ToInt32(textBox32.Text);
                                uni.Fecha = dateTimePicker6.Value;

                                MessageBox.Show(uni.Registrar_procesoempleado(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                textBox16.Text = "";
                                // textBox20.Text = "";
                                textBox14.Text = "";
                                f2 = Convert.ToString(" select top 500 * from tproceso_empleado  where estado =" + textBox32.Text);
                                textBox34.Text = Convert.ToString(f2);
                                DataTable dtm11 = new DataTable("tproceso_empleado");
                                using (SqlConnection cn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["CnnORDEN"].ConnectionString))
                                {
                                    if (cn1.State == ConnectionState.Closed)
                                        cn1.Open();

                                    using (SqlDataAdapter da = new SqlDataAdapter(textBox34.Text, cn1))

                                        da.Fill(dtm11);

                                    dataGridView3.DataSource = dtm11;

                                    //   DataGridViewColumn column = dataGridView1.Columns[1];
                                    //   column.Visible = false;

                                    dataGridView3.ColumnHeadersDefaultCellStyle.Font = new Font("Arial Rounded MT", 6);  //tamaño en titulos
                                    dataGridView3.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView3.Font, FontStyle.Bold); // negrita en titulos

                                    dataGridView3.RowTemplate.Height = 13;
                                    dataGridView3.RowTemplate.Height = 13;
                                    dataGridView3.Columns[0].HeaderText = "Id";
                                    dataGridView3.Columns[0].Width = 50;
                                    dataGridView3.Columns[1].HeaderText = "Nombre";
                                    dataGridView3.Columns[1].Width = 110;
                                    dataGridView3.Columns[2].HeaderText = "Cedula";
                                    dataGridView3.Columns[2].Width = 70;
                                    dataGridView3.Columns[3].HeaderText = "Compañia";
                                    dataGridView3.Columns[3].Width = 60;
                                    dataGridView3.Columns[4].HeaderText = "Operario";
                                    dataGridView3.Columns[4].Width = 60;
                                    dataGridView3.Columns[5].HeaderText = "Observación";
                                    dataGridView3.Columns[5].Width = 75;
                                    dataGridView3.Columns[6].HeaderText = "ProcesoA.";
                                    dataGridView3.Columns[6].Width = 50;
                                    dataGridView3.Columns[7].HeaderText = "Estado";
                                    dataGridView3.Columns[7].Width = 70;
                                    dataGridView3.Columns[8].HeaderText = "Fecha";
                                    dataGridView3.Columns[8].Width = 70;
                                    dataGridView3.Columns[9].HeaderText = "Nombre";
                                    dataGridView3.Columns[9].Width = 70;
                                    // dataGridView3.ColumnHeadersVisible = false;  // encabezado//
                                    // DataGridViewColumn column = dataGridView.Columns[0];
                                    DataGridViewColumn column = dataGridView3.Columns[6];
                                    column.Visible = false;
                                    DataGridViewColumn column1 = dataGridView3.Columns[7];
                                    column1.Visible = false;
                                    textBox16.Enabled = true;
                                   
                                    Verresulprocesos();
                                }
                            }
                        }
                    }
                }

              
            } //Limpiar();

            catch (Exception ex)
            {
                  //MessageBox.Show(ex.Message);
                 MessageBox.Show("Campos Vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        decimal re, me;

        private void Operacion()
        {
            decimal mife, q, w, e, eficiu, efici,f1, efici1, xC, x2, xim;
            decimal xl, xi, ff, kk, final, nnh1, d;
            decimal minu, hora, im, mire, nnh, horaim, j, l, t, s, k, o;


            try
            {
                //porcentajes
                j = Convert.ToDecimal(.01);
                l = Convert.ToDecimal(.50);
                t = Convert.ToDecimal(.84);
                s = Convert.ToDecimal(.85);
                k = Convert.ToDecimal(.90);
                o = Convert.ToDecimal(.95);




                xC = Convert.ToDecimal(textBox26.Text);                   //compañia
                                                                          // xO = Convert.ToDecimal(textBox1.Text);                   //operario
                minu = Convert.ToDecimal(txtminutosproduccion.Text);  /// total minutos en produccion
                lbminuingenieria.Text = minu.ToString("N2");
                hora = Convert.ToDecimal(txttotalminutos.Text);  //  total minutos en horario
                e = Convert.ToDecimal(txtminutosimproductivos.Text);//  total minutos improductivos


                lbminupresenciales.Text = hora.ToString("N2");
                horaim = Convert.ToDecimal(textBox25.Text);  //  minutos operario
                lbminutosimproductivos.Text = textBox25.Text;
                lbminutoscompañia.Text = textBox26.Text;

                mife = Convert.ToDecimal(textBox27.Text);   /// minutos festivos
                lbfestivo.Text = textBox27.Text;
                w = Convert.ToDecimal(xC + (horaim+e));   /// minutos totales
               // e = Convert.ToDecimal(textBox12.Text);
                lbminuresuniones.Text = Convert.ToString(w);
                efici = hora - (xC + horaim);
                f1 = (xC + horaim + e);
                efici1 =  minu/(hora-f1);
                //lbnminutoseficiencia.Text = efici.ToString("N2");




                mire = Convert.ToDecimal(Math.Round(minu / hora));
                im = minu / hora;
                lbrendimiento.Text = Convert.ToString(mire);
                eficiu = minu / efici;
                label58.Text = Convert.ToString(im);


                nnh = Convert.ToDecimal(minu / hora);
                nnh1 = Convert.ToDecimal(minu / efici);
                if (nnh1 >= j)
                {
                    // Convert.ToDecimal(hora/minu);
                    label60.Text = txt2p.Text;//"58";
                    q = Convert.ToDecimal(txt2p.Text);

                    xl = Convert.ToDecimal(minu * q);
                    lbvalorminuto.Text = Convert.ToString(q.ToString("$0"));

                    lbprecioingenieria.Text = xl.ToString("N2");
                    lbrendimiento.Text = Convert.ToString(nnh.ToString("0.00%"));
                    // eficiu = minu/eficiu;
                    lbnminutoseficiencia.Text = Convert.ToString(efici1.ToString("0.00%"));
                    lbnminutoseficiencia.BackColor = Color.Red;
                    lbnminutoseficiencia.ForeColor = Color.Black;

                    xim = Convert.ToDecimal(txtim.Text);
                    xi = Convert.ToDecimal(horaim * xim);
                    lbvalorimproductivo.Text = xi.ToString("N2");

                    x2 = Convert.ToDecimal( xC*xim);
                    label61.Text = x2.ToString("N2");

                    d = Convert.ToDecimal(w * xim);
                    lbvalorreuniones.Text = d.ToString("N2");

                    //////////festivos
                    ///        
                    ff = Convert.ToDecimal(txtfes.Text);
                    kk = Convert.ToDecimal(ff * mife);
                    lbvalorfestivo.Text = kk.ToString("N2");
                    final = Convert.ToDecimal(xl + kk + xi+d);
                    tstresultadofinal.Text = final.ToString("N2");



                    if (nnh1 >= l)
                    {
                        label60.Text = txt2p.Text;//"58";
                        q = Convert.ToDecimal(txt2p.Text);
                        xl = Convert.ToDecimal(minu * q);



                        lbprecioingenieria.Text = Convert.ToString(xl);
                        lbvalorminuto.Text = Convert.ToString(q.ToString("$0"));
                        lbprecioingenieria.Text = xl.ToString("N2");
                        lbrendimiento.Text = Convert.ToString(nnh.ToString("0.00%"));
                        //  eficiu = minu / eficiu;
                        lbnminutoseficiencia.Text = Convert.ToString(efici1.ToString("0.00%"));

                        lbnminutoseficiencia.BackColor = Color.Red;
                        lbnminutoseficiencia.ForeColor = Color.Black;

                        xim = Convert.ToDecimal(txtim.Text);
                        xi = Convert.ToDecimal(horaim * xim);
                        lbvalorimproductivo.Text = xi.ToString("N2");
                        x2 = Convert.ToDecimal(xC * xim);
                        label61.Text = x2.ToString("N2");

                        d = Convert.ToDecimal(w * xim);
                        lbvalorreuniones.Text = d.ToString("N2");
                        //////////festivos
                        ///        
                        ff = Convert.ToDecimal(txtfes.Text);
                        kk = Convert.ToDecimal(ff * mife);
                        lbvalorfestivo.Text = kk.ToString("N2");
                        final = Convert.ToDecimal(xl + kk + xi+d);
                        tstresultadofinal.Text = final.ToString("N2");

                        if (nnh1 >= t)
                        {                // nnh = Convert.ToDecimal(hora/minu);
                            label60.Text = txt3p.Text;//"63";
                            q = Convert.ToDecimal(txt3p.Text);
                            xl = Convert.ToDecimal(minu * q);

                            lbprecioingenieria.Text = Convert.ToString(xl);
                            lbvalorminuto.Text = Convert.ToString(q.ToString("$0"));
                            lbprecioingenieria.Text = xl.ToString("N2");
                            lbrendimiento.Text = Convert.ToString(nnh.ToString("0.00%"));
                            // eficiu = minu / eficiu;
                            lbnminutoseficiencia.Text = Convert.ToString(efici1.ToString("0.00%"));
                            lbnminutoseficiencia.BackColor = Color.Red;
                            lbnminutoseficiencia.ForeColor = Color.Black;

                            xim = Convert.ToDecimal(txtim.Text);
                            xi = Convert.ToDecimal(horaim * xim);
                            lbvalorimproductivo.Text = xi.ToString("N2");
                            x2 = Convert.ToDecimal(xC * xim);
                            label61.Text = x2.ToString("N2");

                            d = Convert.ToDecimal(w * xim);
                            lbvalorreuniones.Text = d.ToString("N2");
                            //////////festivos
                            ///        
                            ff = Convert.ToDecimal(txtfes.Text);
                            kk = Convert.ToDecimal(ff * mife);
                            lbvalorfestivo.Text = kk.ToString("N2");
                            final = Convert.ToDecimal(xl + kk + xi+d);
                            tstresultadofinal.Text = final.ToString("N2");
                            if (nnh1 >= s)
                            {
                                label60.Text = txt4p.Text;//"89";
                                q = Convert.ToDecimal(txt4p.Text);

                                xl = Convert.ToDecimal(minu * q);
                                lbprecioingenieria.Text = Convert.ToString(xl);
                                lbvalorminuto.Text = Convert.ToString(q.ToString("$0"));
                                lbprecioingenieria.Text = xl.ToString("N2");
                                lbrendimiento.Text = Convert.ToString(nnh.ToString("0.00%"));
                                //  eficiu = minu / eficiu;
                                lbnminutoseficiencia.Text = Convert.ToString(efici1.ToString("0.00%"));
                                lbnminutoseficiencia.BackColor = Color.Lime;
                                lbnminutoseficiencia.ForeColor = Color.Black;
                                xim = Convert.ToDecimal(txtim.Text);
                                xi = Convert.ToDecimal(horaim * xim);
                                lbvalorimproductivo.Text = xi.ToString("N2");
                                x2 = Convert.ToDecimal(xC * xim);
                                label61.Text = x2.ToString("N2");

                                d = Convert.ToDecimal(w * xim);
                                lbvalorreuniones.Text = d.ToString("N2");
                                //////////festivos
                                ///        
                                ff = Convert.ToDecimal(txtfes.Text);
                                kk = Convert.ToDecimal(ff * mife);
                                lbvalorfestivo.Text = kk.ToString("N2");
                                final = Convert.ToDecimal(xl + kk + xi+d);
                                tstresultadofinal.Text = final.ToString("N2");
                                if (nnh1 >= k)
                                {
                                    label60.Text = txt5p.Text;//"99";
                                    q = Convert.ToDecimal(txt5p.Text);

                                    xl = Convert.ToDecimal(minu * q);
                                    lbprecioingenieria.Text = Convert.ToString(xl);
                                    lbvalorminuto.Text = Convert.ToString(q.ToString("$0"));
                                    lbprecioingenieria.Text = xl.ToString("N2");
                                    lbrendimiento.Text = Convert.ToString(nnh.ToString("0.00%"));
                                    //  eficiu = minu / eficiu;
                                    lbnminutoseficiencia.Text = Convert.ToString(efici1.ToString("0.00%"));
                                    lbnminutoseficiencia.BackColor = Color.Lime;
                                    lbnminutoseficiencia.ForeColor = Color.Black;

                                    xim = Convert.ToDecimal(txtim.Text);
                                    xi = Convert.ToDecimal(horaim * xim);
                                    lbvalorimproductivo.Text = xi.ToString("N2");
                                    x2 = Convert.ToDecimal(xC * xim);
                                    label61.Text = x2.ToString("N2");

                                    d = Convert.ToDecimal(w * xim);
                                    lbvalorreuniones.Text = d.ToString("N2");
                                    //////////festivos
                                    ///        
                                    ff = Convert.ToDecimal(txtfes.Text);
                                    kk = Convert.ToDecimal(ff * mife);
                                    lbvalorfestivo.Text = kk.ToString("N2");
                                    final = Convert.ToDecimal(xl + kk + xi+d);
                                    tstresultadofinal.Text = final.ToString("N2");

                                    if (nnh1 >= o)
                                    {
                                        label60.Text = txt6p.Text;// "109";
                                        q = Convert.ToDecimal(txt6p.Text);
                                        xl = Convert.ToDecimal(minu * q);
                                        lbprecioingenieria.Text = Convert.ToString(xl);
                                        lbvalorminuto.Text = Convert.ToString(q.ToString("$0"));
                                        lbprecioingenieria.Text = xl.ToString("N2");

                                        lbrendimiento.Text = Convert.ToString(nnh.ToString("0.00%"));
                                        // eficiu = minu / eficiu;
                                        lbnminutoseficiencia.Text = Convert.ToString(efici1.ToString("0.00%"));
                                        lbnminutoseficiencia.BackColor = Color.Lime;
                                        lbnminutoseficiencia.ForeColor = Color.Black;

                                        xim = Convert.ToDecimal(txtim.Text);
                                        xi = Convert.ToDecimal(horaim * xim);
                                        lbvalorimproductivo.Text = xi.ToString("N2");
                                        x2 = Convert.ToDecimal(xC * xim);
                                        label61.Text = x2.ToString("N2");

                                        d = Convert.ToDecimal(w * xim);
                                        lbvalorreuniones.Text = d.ToString("N2");
                                        //////////festivos
                                        ///        
                                        ff = Convert.ToDecimal(txtfes.Text);
                                        kk = Convert.ToDecimal(ff * mife);
                                        lbvalorfestivo.Text = kk.ToString("N2");
                                        final = Convert.ToDecimal(xl + kk + xi+d);
                                        tstresultadofinal.Text = final.ToString("N2");
                                    }

                                }

                            }
                        }
                    }
                }
                else
                {
                    //label59.Text = "";
                }
            }
            catch (Exception ex)
            {
              //  MessageBox.Show(ex.Message);
                MessageBox.Show("Campos Vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
          
        }
        private void Cargarlista4()

        {
            try
            {



                DataTable dt1 = new DataTable();
                dt1 = F.Listadopfin();

                dataGridView7.DataSource = dt1;
                dataGridView7.RowTemplate.Height = 13;
                dataGridView7.ColumnHeadersDefaultCellStyle.Font = new Font(" Nirmala UI", 7);
               



               // Verresul2();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataGridView7.ClearSelection();
            //Verresul();

        }
        private void limpiarvalorminuto()
        {


          
            txt2p.Text = "";
            txt3p.Text = "";
            txt4p.Text = "";
            txt5p.Text = "";
            txt6p.Text = "";
            txtim.Text = "";
            txtfes.Text = "";
        }
        private void button11_Click(object sender, EventArgs e)
        {
           // tabControl1.Enabled = true;
            Operacion();
           // tabControl1.Enabled = false;
        }

        private void dateTimePicker6_ValueChanged(object sender, EventArgs e)
        {
            DateTime t = Convert.ToDateTime(dateTimePicker6.Value);
            byte o = ((Byte)t.DayOfWeek);
            textBox4.Text = Convert.ToString(o);
            if (o == 0)
            {
                textBox4.Text = "Domingo";
            }
            else
            {
                if (o == 1)
                {
                    textBox4.Text = "Lunes";
                }
                else
                {
                    if (o == 2)
                    {
                        textBox4.Text = "Martes";
                    }
                    else
                    {
                        if (o == 3)
                        {
                            textBox4.Text = "Miercoles";
                        }
                        else
                        {
                            if (o == 4)
                            {
                                textBox4.Text = "Jueves";
                            }
                            else
                            {
                                if (o == 5)
                                {
                                    textBox4.Text = "Viernes";
                                }
                                else
                                {
                                    if (o == 6)
                                    {
                                        textBox4.Text = "Sabado";
                                    }
                                }
                            }
                        }
                    }
                }
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            int r = 0;
            int m = 0;
            // int mm = 2;

            try
            {
                if (dateentrsalida.Value >= dateTimePicker3.Value)
                {
                    textBox7.Text = "20";

                    //minutos = 248879.75
                    TimeSpan difFechas = dateTimePicker3.Value - datehorluneentra.Value;
                    Double minutos = difFechas.TotalMinutes;

                    textnumdilun.Text = Convert.ToString(minutos);
                    r = Convert.ToInt32(textBox7.Text);
                    textBox18.Text = Convert.ToString(r * 2);
                    m = Convert.ToInt32(textBox18.Text);
                    textBox5.Text = Convert.ToString(minutos - m);

                    if (dateTimePicker3.Value <= dateTimePicker1.Value)
                    {
                        //textBox3.Text = Convert.ToString(minutos+minutos);

                        textBox7.Text = "10";

                    }
                }

                if (dateentrsalida.Value < dateTimePicker3.Value)
                {
                    textBox7.Text = "30";

                    //minutos = 248879.75
                    TimeSpan difFechas = dateTimePicker3.Value - datehorluneentra.Value;
                    Double minutos = difFechas.TotalMinutes;


                    textnumdilun.Text = Convert.ToString(minutos);
                    r = Convert.ToInt32(textBox7.Text);
                    textBox18.Text = Convert.ToString(r * 2);
                    m = Convert.ToInt32(textBox18.Text);
                    textBox5.Text = Convert.ToString(minutos - m);
                }
                if (dateTimePicker3.Value <= dateTimePicker1.Value)
                {
                    TimeSpan difFechas = dateTimePicker3.Value - datehorluneentra.Value;
                    Double minutos = difFechas.TotalMinutes;


                    textnumdilun.Text = Convert.ToString(minutos);
                    r = Convert.ToInt32(textBox7.Text);
                    textBox18.Text = Convert.ToString(r * 2);
                    m = Convert.ToInt32(textBox18.Text);
                    textBox5.Text = Convert.ToString(minutos - m);
                }
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);
                MessageBox.Show("Campos Vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void validartproceso()
        {


            if (comboBox2.Text != string.Empty )
            {
                button9.Enabled = true;
              
            }

            else
            {
                button9.Enabled = false;
               
            }
        }
        private void validarhorario()
        {


            if (comboBox1.Text != string.Empty)
            {
                button4.Enabled = true;
                button14.Enabled = true;
            }

            else
            {
                button4.Enabled = false;
                button14.Enabled = false;
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                h.Cedulaem = Convert.ToInt32(textBox1.Text);
                h.Nombre = textBox2.Text;
                h.Horario = comboBox1.SelectedItem.ToString();
                h.Dia = textBox4.Text;
                h.Fecha = dateTimePicker6.Value;

                h.Horaentrada = datehorluneentra.Value;
                h.Horasalida = dateTimePicker3.Value;
                h.Improd = Convert.ToDecimal(textBox7.Text);
                h.Mdia = Convert.ToDecimal(textnumdilun.Text);
                h.Totalminutos = Convert.ToDecimal(textBox5.Text);

                h.Estado = Convert.ToInt32(textBox32.Text);
                h.Sin = Convert.ToInt32(0);



                MessageBox.Show(h.Registrarhorario(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string f4;

                f4 = Convert.ToString(" select top 500 * from tiempoemn  where estado =" + textBox32.Text);
                textBox34.Text = Convert.ToString(f4);
                DataTable dtm14 = new DataTable("tiempoemn ");
                using (SqlConnection cn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["CnnORDEN"].ConnectionString))
                {
                    if (cn1.State == ConnectionState.Closed)
                        cn1.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter(textBox34.Text, cn1))
                        da.Fill(dtm14);
                    dataGridView6.DataSource = dtm14;                   
                    dataGridView6.ColumnHeadersDefaultCellStyle.Font = new Font("Arial Rounded MT", 6);  //tamaño en titulos
                    dataGridView6.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView6.Font, FontStyle.Bold); // negrita en titulos
                    dataGridView6.RowTemplate.Height = 13;
                    dataGridView6.DataSource = dtm14;
                    dataGridView6.Columns[0].HeaderText = "Id";
                    dataGridView6.Columns[0].Width = 50;
                    dataGridView6.Columns[1].HeaderText = "Cedula";
                    dataGridView6.Columns[1].Width = 70;
                    dataGridView6.Columns[2].HeaderText = "Empleado";
                    dataGridView6.Columns[2].Width = 110;
                    dataGridView6.Columns[3].HeaderText = "Horario";
                    dataGridView6.Columns[3].Width = 50;
                    dataGridView6.Columns[4].HeaderText = "Dia";
                    dataGridView6.Columns[4].Width = 50;
                    dataGridView6.Columns[5].HeaderText = "Fecha";
                    dataGridView6.Columns[5].Width = 80;
                    dataGridView6.Columns[6].HeaderText = "Entrada";
                    dataGridView6.Columns[6].Width = 50;
                    dataGridView6.Columns[7].HeaderText = "Salida";
                    dataGridView6.Columns[7].Width = 50;
                    dataGridView6.Columns[8].HeaderText = "Improductivos";
                    dataGridView6.Columns[8].Width = 85;
                    dataGridView6.Columns[9].HeaderText = "Dia";
                    dataGridView6.Columns[9].Width = 50;
                    dataGridView6.Columns[10].HeaderText = "Total";
                    dataGridView6.Columns[10].Width = 50;
                    dataGridView6.Columns[11].HeaderText = "Estado";
                    dataGridView6.Columns[11].Width = 50;
                    dataGridView6.Columns[12].HeaderText = "Ausente";
                    dataGridView6.Columns[12].Width = 50;
                    DataGridViewColumn column = dataGridView6.Columns[11];
                    column.Visible = false;
                    Verresulhorario();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Campos Vacíos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //  MessageBox.Show(ex.Message);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            limpiarvalorminuto();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show(" ¿ Está seguro que desea guardar este valor ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {


                    F.Valor1 = Convert.ToInt32(textBox60.Text);
                    F.Valor2 = Convert.ToInt32(txt2p.Text);
                    F.Valor3 = Convert.ToInt32(txt2p.Text);
                    F.Valor4 = Convert.ToInt32(txt3p.Text);
                    F.Valor5 = Convert.ToInt32(txt4p.Text);
                    F.Valor6 = Convert.ToInt32(txt5p.Text);
                    F.Valor7 = Convert.ToInt32(txt6p.Text);
                    F.Valor8 = Convert.ToInt32(txtim.Text);
                    F.Valor9 = Convert.ToInt32(txtfes.Text);

                    MessageBox.Show(F.Actualivalidacion(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listavalida();
                   // MessageBox.Show(" Datos Actualizados  ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" ¡Campos Vacios! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

               // MessageBox.Show(ex.Message);
            }
        }
        public void Valor31op(string _dato31)
        {
            DataGridViewRow row = dataGridView4.CurrentRow;
            if (row != null)
            {

                row.Cells[5].Value = _dato31;//op


                // Verresul();
                // fe.ShowDialog();
            }


        }

        public void Valor32op(string _dato32)
        {
            DataGridViewRow row = dataGridView4.CurrentRow;
            if (row != null)
            {

                row.Cells[11].Value = _dato32;//tiempo


                // Verresul();
                // fe.ShowDialog();
            }

        }
        public void Valor33op(string _dato33)
        {
            DataGridViewRow row = dataGridView4.CurrentRow;
            if (row != null)
            {

                row.Cells[7].Value = _dato33;//nombre


                // Verresul();
                // fe.ShowDialog();
            }
        }
        public void Valor34op(string _dato34)
        {
            DataGridViewRow row = dataGridView4.CurrentRow;
            if (row != null)
            {

                row.Cells[10].Value = _dato34;//categoria


                // Verresul();
                // fe.ShowDialog();
            }
        }
        public void Valor35op(string _dato35)
        {
            DataGridViewRow row = dataGridView4.CurrentRow;
            if (row != null)
            {

                row.Cells[14].Value = _dato35;//minutos


                // Verresul();
                // fe.ShowDialog();
            }
        }
        public void Valor36op(string _dato36)
        {
            DataGridViewRow row = dataGridView4.CurrentRow;
            if (row != null)
            {

                row.Cells[17].Value = _dato36;


                // Verresul();
                // fe.ShowDialog();
            }
        }
        public void Valor37op(string _dato37)
        {
            DataGridViewRow row = dataGridView4.CurrentRow;
            if (row != null)
            {

                row.Cells[18].Value = _dato37;


                // Verresul();
                // fe.ShowDialog();
            }
        }
        public void Valor38op(string _dato38)
        {
            DataGridViewRow row = dataGridView4.CurrentRow;
            if (row != null)
            {

                row.Cells[19].Value = _dato38;


                // Verresul();
                // fe.ShowDialog();
            }
        }
        public void Valor39op(string _dato39)
        {
            DataGridViewRow row = dataGridView4.CurrentRow;
            if (row != null)
            {

                row.Cells[20].Value = _dato39;


                // Verresul();
                // fe.ShowDialog();
            }
        }
        public void Valor40op(string _dato40)
        {
            DataGridViewRow row = dataGridView4.CurrentRow;
            if (row != null)
            {

                row.Cells[21].Value = _dato40;


                // Verresul();
                // fe.ShowDialog();
            }
        }
        public void Valor41op(string _dato41)
        {
            DataGridViewRow row = dataGridView4.CurrentRow;
            if (row != null)
            {

                row.Cells[22].Value = _dato41;


                // Verresul();
                // fe.ShowDialog();
            }
        }
        public void Valor42op(string _dato42)
        {
            DataGridViewRow row = dataGridView4.CurrentRow;
            if (row != null)
            {

                row.Cells[23].Value = _dato42;


                // Verresul();
                // fe.ShowDialog();
            }
        }
        public void Valor43op(string _dato43)
        {
            DataGridViewRow row = dataGridView4.CurrentRow;
            if (row != null)
            {

                row.Cells[24].Value = _dato43;


                // Verresul();
                // fe.ShowDialog();
            }
        }
        public void Valor44op(string _dato44)
        {
            DataGridViewRow row = dataGridView4.CurrentRow;
            if (row != null)
            {

                row.Cells[25].Value = _dato44;


                // Verresul();
                // fe.ShowDialog();
            }
        }
        public void Valor45op(string _dato45)
        {
            DataGridViewRow row = dataGridView4.CurrentRow;
            if (row != null)
            {

                row.Cells[26].Value = _dato45;


                // Verresul();
                // fe.ShowDialog();
            }
        }
        public void Valor46op(string _dato46)
        {
            DataGridViewRow row = dataGridView4.CurrentRow;
            if (row != null)
            {

                row.Cells[27].Value = _dato46;


                // Verresul();
                // fe.ShowDialog();
            }
        }
        public void Valor47op(string _dato47)
        {
            DataGridViewRow row = dataGridView4.CurrentRow;
            if (row != null)
            {

                row.Cells[12].Value = _dato47;//cantidad


                // Verresul();
                // fe.ShowDialog();
            }
        }
      

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow dr in dataGridView5.Rows)
                {
                    decimal c, t;

                    F.Cedula = Convert.ToInt32(textBox1.Text);
                    F.Nombreemplea = Convert.ToString(textBox2.Text);
                    F.Cargo = Convert.ToString(textBox3.Text);
                    F.Opopera = Convert.ToInt32(dr.Cells[5].Value);
                    F.Idprenda = Convert.ToInt32(dr.Cells[6].Value); ;
                    F.Nombrepren = Convert.ToString(dr.Cells[7].Value);
                    F.Idoperacion = Convert.ToInt32(dr.Cells[8].Value);
                    F.Nombreoperacion = Convert.ToString(dr.Cells[9].Value);

                    F.Categoria = Convert.ToString(dr.Cells[10].Value);
                    F.Tiempoperac = Convert.ToDecimal(dr.Cells[11].Value);
                   t= Convert.ToDecimal(dr.Cells[11].Value);
                    F.Cantidadoperac = Convert.ToInt32(dr.Cells[12].Value);
                   c= Convert.ToDecimal(dr.Cells[12].Value);
                  double  r = Convert.ToDouble(t*c);
                    F.Totaoperac = Convert.ToDecimal(textBox28.Text);
                    F.Hora = Convert.ToString(dr.Cells[14].Value);
                    F.Fechaini = dateTimePicker4.Value;
                    DateTime fecha = dateTimePicker4.Value;
                    F.Fechafin = fecha.AddMinutes(r);
                  
                    F.Sobremedidao = Convert.ToInt32(dr.Cells[17].Value);
                    F.Xso = Convert.ToInt32(dr.Cells[18].Value);
                    F.So = Convert.ToInt32(dr.Cells[19].Value);
                    F.Mmo = Convert.ToInt32(dr.Cells[20].Value);
                    F.Lo = Convert.ToInt32(dr.Cells[21].Value);
                    F.Xlo = Convert.ToInt32(dr.Cells[22].Value);
                    F.Xxlo = Convert.ToInt32(dr.Cells[23].Value);
                    F.T3xlo = Convert.ToInt32(dr.Cells[24].Value);
                    F.T4xlo = Convert.ToInt32(dr.Cells[25].Value);
                    F.T5xlo = Convert.ToInt32(dr.Cells[26].Value);
                    F.T6xlo = Convert.ToInt32(dr.Cells[27].Value);
                    
                    F.Fecha = dateTimePicker6.Value;

                    F.Estado = Convert.ToInt32(textBox30.Text);
                    F.Numero = Convert.ToInt32(textBox32.Text);

                    MessageBox.Show(F.Registrfinal(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView5.Rows.Clear();
                    
                }
                string f1;

                f1 = Convert.ToString(" select top 500 * from operafin1 where numero =" + textBox32.Text);
                textBox34.Text = Convert.ToString(f1);
                DataTable dtm11 = new DataTable("operafin1");
                using (SqlConnection cn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["CnnORDEN"].ConnectionString))
                {
                    if (cn1.State == ConnectionState.Closed)
                        cn1.Open();

                    using (SqlDataAdapter da = new SqlDataAdapter(textBox34.Text, cn1))

                        da.Fill(dtm11);

                    dataGridView7.DataSource = dtm11;

                    //   DataGridViewColumn column = dataGridView1.Columns[1];
                    //   column.Visible = false;
                    dataGridView7.DefaultCellStyle.Font = new Font("Bookshelf Symbol", 7);
                    dataGridView7.RowTemplate.Height = 13;


                    dataGridView7.DataSource = dtm11;

                    hide7();

                }

                dataGridView7.ClearSelection();
                //  Verresul2();
                //Limpiar();
          
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);
                MessageBox.Show("Campos Vacios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
           
           try
          {
                             
                foreach (DataGridViewRow dr in dataGridView4.Rows)
                {
                    decimal c, t;

                    F.Cedula = Convert.ToInt32(textBox1.Text);
                    F.Nombreemplea = Convert.ToString(textBox2.Text);
                    F.Cargo = Convert.ToString(textBox3.Text);
                    F.Opopera = Convert.ToInt32(dr.Cells[5].Value);
                    F.Idprenda = Convert.ToInt32(textBox28.Text);
                    F.Nombrepren = Convert.ToString(dr.Cells[7].Value);
                    F.Idoperacion = Convert.ToInt32(textBox28.Text);
                    F.Nombreoperacion = Convert.ToString(textBox29.Text);
                    F.Categoria = Convert.ToString(dr.Cells[10].Value);
                    F.Tiempoperac = Convert.ToDecimal(dr.Cells[11].Value);
                    t = Convert.ToDecimal(dr.Cells[11].Value);
                    F.Cantidadoperac = Convert.ToInt32(dr.Cells[12].Value);
                    c = Convert.ToDecimal(dr.Cells[12].Value);
                    double r = Convert.ToDouble(t * c);
                    F.Totaoperac = Convert.ToDecimal(textBox28.Text);
                    F.Hora = Convert.ToString(dr.Cells[14].Value);
                    F.Fechaini = dateTimePicker4.Value;
                    DateTime fecha = dateTimePicker4.Value;
                    F.Fechafin = fecha.AddMinutes(r);
                    F.Sobremedidao = Convert.ToInt32(dr.Cells[17].Value);
                    F.Xso = Convert.ToInt32(dr.Cells[18].Value);
                    F.So = Convert.ToInt32(dr.Cells[19].Value);
                    F.Mmo = Convert.ToInt32(dr.Cells[20].Value);
                    F.Lo = Convert.ToInt32(dr.Cells[21].Value);
                    F.Xlo = Convert.ToInt32(dr.Cells[22].Value);
                    F.Xxlo = Convert.ToInt32(dr.Cells[23].Value);
                    F.T3xlo = Convert.ToInt32(dr.Cells[24].Value);
                    F.T4xlo = Convert.ToInt32(dr.Cells[25].Value);
                    F.T5xlo = Convert.ToInt32(dr.Cells[26].Value);
                    F.T6xlo = Convert.ToInt32(dr.Cells[27].Value);
                   
                    F.Fecha = dateTimePicker6.Value;
                    F.Estado = Convert.ToInt32(textBox30.Text);
                    F.Numero = Convert.ToInt32(textBox32.Text);

                    MessageBox.Show(F.Registrfinal(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView4.Rows.Clear();
                }
                string f1;

                f1 = Convert.ToString(" select top 500 * from operafin1 where numero =" + textBox32.Text);
                textBox34.Text = Convert.ToString(f1);
                DataTable dtm11 = new DataTable("operafin1");
                using (SqlConnection cn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["CnnORDEN"].ConnectionString))
                {
                    if (cn1.State == ConnectionState.Closed)
                        cn1.Open();

                    using (SqlDataAdapter da = new SqlDataAdapter(textBox34.Text, cn1))

                        da.Fill(dtm11);

                    dataGridView7.DataSource = dtm11;

                    //   DataGridViewColumn column = dataGridView1.Columns[1];
                    //   column.Visible = false;
                    dataGridView7.DefaultCellStyle.Font = new Font("Bookshelf Symbol", 7);
                    dataGridView7.RowTemplate.Height = 13;


                    dataGridView7.DataSource = dtm11;
                    hide7();


                }

                dataGridView4.ClearSelection();
                //  Verresul2();
                //Limpiar();
               
            }
         catch (Exception ex)
          {
                //MessageBox.Show(ex.Message);
                MessageBox.Show("Campos Vacios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView5_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dataGridView5.Columns[e.ColumnIndex].Name == "op1" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                DataGridViewButtonCell celboton = this.dataGridView5.Rows[e.RowIndex].Cells["op1"] as DataGridViewButtonCell;
                Icon icoto = new Icon(Environment.CurrentDirectory + @" \\in1.ico");
                e.Graphics.DrawIcon(icoto, e.CellBounds.Left - 1, e.CellBounds.Top + 0);
                this.dataGridView5.Rows[e.RowIndex].Height = icoto.Height + 1;
                this.dataGridView5.Columns[e.ColumnIndex].Width = icoto.Width + 1;
                e.Handled = true;
            }
        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (this.dataGridView4.Columns[e.ColumnIndex].Name.Equals("op"))
            {
                Empleoperacion hijo = new Empleoperacion();
                hijo.contratoopa = this;
                hijo.contrato1opa = this;
                hijo.contrato2opa = this;
                hijo.contrato3opa = this;
                hijo.contrato4opa = this;
                hijo.contrato5opa = this;
                hijo.contrato6opa = this;
                hijo.contrato7opa = this;
                hijo.contrato8opa = this;
                hijo.contrato9opa = this;
                hijo.contrato10opa = this;
                hijo.contrato11opa = this;
                hijo.contrato12opa = this;
                hijo.contrato13opa = this;
                hijo.contrato14opa = this;
                hijo.contrato15opa = this;
                hijo.contrato16opa = this;
                hijo.contrato17opa = this;
                hijo.contrato18opa = this;
                hijo.contrato19opa = this;

                hijo.ShowDialog();
            }
        }

        public void Valor31opa(string _dato31)
        {
            DataGridViewRow row = dataGridView5.CurrentRow;
            if (row != null)
            {
                row.Cells[5].Value = _dato31;//op
            }
        }

        public void Valor32opa(string _dato32)
        {
            DataGridViewRow row = dataGridView5.CurrentRow;
            if (row != null)
            {
                row.Cells[6].Value = _dato32;//idprenda
            }
        }

        public void Valor33opa(string _dato33)
        {
            DataGridViewRow row = dataGridView5.CurrentRow;
            if (row != null)
            {
                row.Cells[7].Value = _dato33;//nombreprenda
            }
        }

        public void Valor34opa(string _dato34)
        {
            DataGridViewRow row = dataGridView5.CurrentRow;
            if (row != null)
            {
                row.Cells[8].Value = _dato34;//idopera
            }
        }

        public void Valor35opa(string _dato35)
        {
            DataGridViewRow row = dataGridView5.CurrentRow;
            if (row != null)
            {
                row.Cells[9].Value = _dato35;//nombreprenda
            }
        }

        public void Valor36opa(string _dato36)
        {
            DataGridViewRow row = dataGridView5.CurrentRow;
            if (row != null)
            {
                row.Cells[11].Value = _dato36;//tiempo
            }
        }

        public void Valor37opa(string _dato37)
        {
            DataGridViewRow row = dataGridView5.CurrentRow;
            if (row != null)
            {
                row.Cells[18].Value = _dato37;//xs
            }
        }

        public void Valor38opa(string _dato38)
        {
            DataGridViewRow row = dataGridView5.CurrentRow;
            if (row != null)
            {
                row.Cells[19].Value = _dato38;
            }
        }

        public void Valor39opa(string _dato39)
        {
            DataGridViewRow row = dataGridView5.CurrentRow;
            if (row != null)
            {
                row.Cells[20].Value = _dato39;//op
            }
        }

        public void Valor40opa(string _dato40)
        {
            DataGridViewRow row = dataGridView5.CurrentRow;
            if (row != null)
            {
                row.Cells[21].Value = _dato40;//op
            }
        }

        public void Valor41opa(string _dato41)
        {
            DataGridViewRow row = dataGridView5.CurrentRow;
            if (row != null)
            {
                row.Cells[22].Value = _dato41;//op
            }
        }

        public void Valor42opa(string _dato42)
        {
            DataGridViewRow row = dataGridView5.CurrentRow;
            if (row != null)
            {
                row.Cells[23].Value = _dato42;//op
            }
        }

        public void Valor43opa(string _dato43)
        {
            DataGridViewRow row = dataGridView5.CurrentRow;
            if (row != null)
            {
                row.Cells[24].Value = _dato43;//op
            }
        }

        public void Valor44opa(string _dato44)
        {
            DataGridViewRow row = dataGridView5.CurrentRow;
            if (row != null)
            {
                row.Cells[25].Value = _dato44;//op
            }
        }

        public void Valor45opa(string _dato45)
        {
            DataGridViewRow row = dataGridView5.CurrentRow;
            if (row != null)
            {
                row.Cells[26].Value = _dato45;//op
            }
        }

        public void Valor46opa(string _dato46)
        {
            DataGridViewRow row = dataGridView5.CurrentRow;
            if (row != null)
            {
                row.Cells[27].Value = _dato46;
            }
        }

        public void Valor47opa(string _dato47)
        {
            DataGridViewRow row = dataGridView5.CurrentRow;
            if (row != null)
            {
                row.Cells[12].Value = _dato47;//cantidad
            }
        }
        public void Valor48opa(string _dato48)
        {
            DataGridViewRow row = dataGridView5.CurrentRow;
            if (row != null)
            {
                row.Cells[10].Value = _dato48;//op
            }
        }
        public void Valor49opa(string _dato49)
        {
            DataGridViewRow row = dataGridView5.CurrentRow;
            if (row != null)
            {
                row.Cells[14].Value = _dato49;//op
            }
        }
        public void Valor50opa(string _dato50)
        {
            DataGridViewRow row = dataGridView5.CurrentRow;
            if (row != null)
            {
                row.Cells[17].Value = _dato50;//sobremedida
            }
        }

        private void textBox30_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
   
           
            Formnuevo nuevo = new Formnuevo();
            nuevo.contrato101 = this;
            nuevo.textBox31.Text = textBox1.Text;
            nuevo.ShowDialog();

        }

        public void Valor48op(string _dato48)
        {
            textBox32.Text = _dato48;//codigonuevo
        }

        private void textBox28_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
          
            try
            {


                DataTable dt1 = new DataTable();
                DataRow row1;
                F.IdInicio = Convert.ToInt32(textBox32.Text);
                dt1 = F.Buscarnuevo(F.IdInicio);
                if (dt1.Rows.Count == 1)
                {
                    row1 = dt1.Rows[0];
                    textBox32.Text = row1[0].ToString();
                    textBox1.Text = row1[1].ToString();
                }
                else
                {
                    MessageBox.Show("  Código no encontrado  ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    button6.Enabled = false;
                    button7.Enabled = false;
                    tabControl1.Enabled = false;
                    textBox1.Text = "";
                }

                    DataTable dt = new DataTable();
              DataRow row;
               TblAtri.Cedula = Convert.ToInt32(textBox1.Text);
                dt = Reglas.BuscarEmpleados(TblAtri.Cedula.ToString());
                if (dt.Rows.Count == 1)
                {
                    row = dt.Rows[0];
                    textBox1.Text = row[0].ToString();
                    textBox2.Text = row[1].ToString();
                    textBox3.Text = row[3].ToString();
                    // txtcategoria.Text = row[3].ToString();

                    F.IdInicio = Convert.ToInt32(textBox32.Text);
                    F.Cedula = Convert.ToInt32(textBox1.Text);


                    MessageBox.Show(F.Aceptado(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // }




                    string f;

                    f = Convert.ToString("  SELECT * from nuevoregistro where cedula=" + textBox32.Text + " or id= " + textBox1.Text);
                    textBox33.Text = Convert.ToString(f);
                    DataTable dtm1 = new DataTable("nuevoregistro");
                    using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["CnnORDEN"].ConnectionString))
                    {
                        if (cn.State == ConnectionState.Closed)
                            cn.Open();

                        using (SqlDataAdapter da = new SqlDataAdapter(textBox33.Text, cn))

                            da.Fill(dtm1);

                        dataGridView1.DataSource = dtm1;
                        dataGridView1.Columns.RemoveAt(0);
                        DataGridViewColumn column = dataGridView1.Columns[1];
                        column.Visible = false;
                        dataGridView1.DefaultCellStyle.Font = new Font("Bookshelf Symbol", 6);
                        dataGridView1.RowTemplate.Height = 12;
                        dataGridView1.Columns[0].HeaderText = "";
                        dataGridView1.Columns[0].Width = 33;
                        dataGridView1.Columns[2].HeaderText = "";
                        dataGridView1.Columns[2].Width = 80;

                        dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold); // negrita en titulos
                                                                                                                         // dataGridView1.Columns[0].HeaderText = "";


                        dataGridView1.DataSource = dtm1;
                        botongrid();


                    }
                    string f1;

                    f1 = Convert.ToString(" select top 500 * from operafin1 where numero =" + textBox32.Text);
                    textBox34.Text = Convert.ToString(f1);
                    DataTable dtm11 = new DataTable("operafin1");
                    using (SqlConnection cn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["CnnORDEN"].ConnectionString))
                    {
                        if (cn1.State == ConnectionState.Closed)
                            cn1.Open();

                        using (SqlDataAdapter da = new SqlDataAdapter(textBox34.Text, cn1))

                            da.Fill(dtm11);

                        dataGridView7.DataSource = dtm11;

                        //   DataGridViewColumn column = dataGridView1.Columns[1];
                        //   column.Visible = false;

                        dataGridView7.ColumnHeadersDefaultCellStyle.Font = new Font("Arial Rounded MT", 7);  //tamaño en titulos
                        dataGridView7.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView7.Font, FontStyle.Bold); // negrita en titulos
                        dataGridView7.Columns[0].HeaderText = "Id";
                        dataGridView7.Columns[0].Width = 40;
                        dataGridView7.Columns[1].HeaderText = "Cedula";
                        dataGridView7.Columns[2].HeaderText = "Empleado";
                        dataGridView7.Columns[2].Width = 150;
                        dataGridView7.Columns[3].HeaderText = "Cargo";
                        dataGridView7.Columns[4].HeaderText = "OP";
                        dataGridView7.Columns[4].Width = 50;
                        dataGridView7.Columns[5].HeaderText = "Id Prenda";
                        dataGridView7.Columns[6].HeaderText = "Prenda";
                        dataGridView7.Columns[6].Width = 100;
                        dataGridView7.Columns[7].HeaderText = "Id Operacion";
                        dataGridView7.Columns[8].HeaderText = "Operacion";
                        dataGridView7.Columns[8].Width = 200;
                        dataGridView7.Columns[9].HeaderText = "Categoria";
                        dataGridView7.Columns[9].Width = 105;
                        dataGridView7.Columns[10].HeaderText = "Tiempo";
                        dataGridView7.Columns[10].Width = 50;
                        dataGridView7.Columns[11].HeaderText = "Cantidad";
                        dataGridView7.Columns[11].Width = 70;
                        dataGridView7.Columns[12].HeaderText = "Total";
                        dataGridView7.Columns[12].Width = 80;
                        dataGridView7.Columns[13].HeaderText = "Horas";
                        dataGridView7.Columns[13].Width = 100;
                        dataGridView7.Columns[14].HeaderText = "F.Inicio";
                        dataGridView7.Columns[14].Width = 65;
                        dataGridView7.Columns[15].HeaderText = "F.Entrega";
                        dataGridView7.Columns[15].Width = 65;
                        dataGridView7.Columns[16].HeaderText = "Sobremedida";
                        dataGridView7.Columns[16].Width = 82;
                        dataGridView7.Columns[17].HeaderText = "XS";
                        dataGridView7.Columns[17].Width = 30;
                        dataGridView7.Columns[18].HeaderText = "S";
                        dataGridView7.Columns[18].Width = 30;
                        dataGridView7.Columns[19].HeaderText = "M";
                        dataGridView7.Columns[19].Width = 30;
                        dataGridView7.Columns[20].HeaderText = "L";
                        dataGridView7.Columns[20].Width = 30;
                        dataGridView7.Columns[21].HeaderText = "XL";
                        dataGridView7.Columns[21].Width = 30;
                        dataGridView7.Columns[22].HeaderText = "XXL";
                        dataGridView7.Columns[22].Width = 30;
                        dataGridView7.Columns[23].HeaderText = "3XL";
                        dataGridView7.Columns[23].Width = 30;
                        dataGridView7.Columns[24].HeaderText = "4XL";
                        dataGridView7.Columns[24].Width = 30;
                        dataGridView7.Columns[25].HeaderText = "5XL";
                        dataGridView7.Columns[25].Width = 30;
                        dataGridView7.Columns[26].HeaderText = "6XL";
                        dataGridView7.Columns[26].Width = 30;
                        dataGridView7.Columns[27].HeaderText = "Fecha";
                        dataGridView7.Columns[28].HeaderText = "Estado";
                        dataGridView7.RowTemplate.Height = 13;
                        dataGridView7.Columns[29].HeaderText = "Numero";
                        dataGridView7.RowTemplate.Height = 13;

                        hide7();
                  


                       // dataGridView7.DataSource = dtm11;

                        Verresulop();

                    }
                    string f3;

                    f3 = Convert.ToString(" select top 500 * from tproceso_empleado  where estado =" + textBox32.Text);
                    textBox34.Text = Convert.ToString(f3);
                    DataTable dtm13 = new DataTable("tproceso_empleado");
                    using (SqlConnection cn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["CnnORDEN"].ConnectionString))
                    {
                        if (cn1.State == ConnectionState.Closed)
                            cn1.Open();

                        using (SqlDataAdapter da = new SqlDataAdapter(textBox34.Text, cn1))

                            da.Fill(dtm13);

                        dataGridView3.DataSource = dtm13;

                        //   DataGridViewColumn column = dataGridView1.Columns[1];
                        //   column.Visible = false;

                        dataGridView3.ColumnHeadersDefaultCellStyle.Font = new Font("Arial Rounded MT", 6);  //tamaño en titulos
                        dataGridView3.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView3.Font, FontStyle.Bold); // negrita en titulos

                        dataGridView3.RowTemplate.Height = 13;


                        dataGridView3.DataSource = dtm13;
                        dataGridView3.Columns[0].HeaderText = "Id";
                        dataGridView3.Columns[0].Width = 50;
                        dataGridView3.Columns[1].HeaderText = "Nombre";
                        dataGridView3.Columns[1].Width = 110;
                        dataGridView3.Columns[2].HeaderText = "Cedula";
                        dataGridView3.Columns[2].Width = 70;
                        dataGridView3.Columns[3].HeaderText = "Compañia";
                        dataGridView3.Columns[3].Width = 60;
                        dataGridView3.Columns[4].HeaderText = "Operario";
                        dataGridView3.Columns[4].Width = 60;
                        dataGridView3.Columns[5].HeaderText = "Observación";
                        dataGridView3.Columns[5].Width = 75;
                        dataGridView3.Columns[6].HeaderText = "ProcesoA.";
                        dataGridView3.Columns[6].Width = 50;
                        dataGridView3.Columns[7].HeaderText = "Estado";
                        dataGridView3.Columns[7].Width = 70;
                        dataGridView3.Columns[8].HeaderText = "Fecha";
                        dataGridView3.Columns[8].Width = 70;
                        dataGridView3.Columns[9].HeaderText = "Nombre";
                        dataGridView3.Columns[9].Width = 70;
                        // dataGridView3.ColumnHeadersVisible = false;  // encabezado//
                        // DataGridViewColumn column = dataGridView.Columns[0];
                        DataGridViewColumn column = dataGridView3.Columns[6];
                        column.Visible = false;
                        DataGridViewColumn column1 = dataGridView3.Columns[7];
                        column1.Visible = false;

                        Verresulprocesos();

                    }
                    string f4;

                    f4 = Convert.ToString(" select top 500 * from tiempoemn  where estado =" + textBox32.Text);
                    textBox34.Text = Convert.ToString(f4);
                    DataTable dtm14 = new DataTable("tiempoemn ");
                    using (SqlConnection cn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["CnnORDEN"].ConnectionString))
                    {
                        if (cn1.State == ConnectionState.Closed)
                            cn1.Open();

                        using (SqlDataAdapter da = new SqlDataAdapter(textBox34.Text, cn1))

                            da.Fill(dtm14);

                        dataGridView6.DataSource = dtm14;

                        //   DataGridViewColumn column = dataGridView1.Columns[1];
                        //   column.Visible = false;

                        dataGridView6.ColumnHeadersDefaultCellStyle.Font = new Font("Arial Rounded MT", 6);  //tamaño en titulos
                        dataGridView6.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView6.Font, FontStyle.Bold); // negrita en titulos

                        dataGridView6.RowTemplate.Height = 13;


                        dataGridView6.DataSource = dtm14;
                        dataGridView6.Columns[0].HeaderText = "Id";
                        dataGridView6.Columns[0].Width = 50;
                        dataGridView6.Columns[1].HeaderText = "Cedula";
                        dataGridView6.Columns[1].Width = 70;
                        dataGridView6.Columns[2].HeaderText = "Empleado";
                        dataGridView6.Columns[2].Width = 110;
                        dataGridView6.Columns[3].HeaderText = "Horario";
                        dataGridView6.Columns[3].Width = 50;
                        dataGridView6.Columns[4].HeaderText = "Dia";
                        dataGridView6.Columns[4].Width = 50;
                        dataGridView6.Columns[5].HeaderText = "Fecha";
                        dataGridView6.Columns[5].Width = 80;
                        dataGridView6.Columns[6].HeaderText = "Entrada";
                        dataGridView6.Columns[6].Width = 50;
                        dataGridView6.Columns[7].HeaderText = "Salida";
                        dataGridView6.Columns[7].Width = 50;
                        dataGridView6.Columns[8].HeaderText = "Improductivos";
                        dataGridView6.Columns[8].Width = 85;
                        dataGridView6.Columns[9].HeaderText = "Dia";
                        dataGridView6.Columns[9].Width = 50;
                        dataGridView6.Columns[10].HeaderText = "Total";
                        dataGridView6.Columns[10].Width = 50;
                        dataGridView6.Columns[11].HeaderText = "Estado";
                        dataGridView6.Columns[11].Width = 50;
                        dataGridView6.Columns[12].HeaderText = "Ausente";
                        dataGridView6.Columns[12].Width = 50;
                        DataGridViewColumn column = dataGridView6.Columns[11];
                        column.Visible = false;

                        Verresulhorario();

                    }

                    button6.Enabled = true;
                    button7.Enabled = true;
                    tabControl1.Enabled = true;
                    textBox13.Enabled = false;
                    textBox35.Enabled = false;
                }
               
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message);
               // MessageBox.Show("Código no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox32.Text = "";
            textBox1.Text = "";
            FrmEmpleados nuevo = new FrmEmpleados();
            nuevo.contrato102 = this;
            nuevo.contrato103 = this;
            nuevo.contrato104 = this;

            nuevo.ShowDialog();
        }

        public void Valor49op(string _dato49)
        {
            textBox1.Text = _dato49;//cedula
        }

        public void Valor50op(string _dato50)
        {
            textBox2.Text = _dato50;//cedula
        }

        public void Valor51op(string _dato51)
        {
            textBox3.Text = _dato51;//cedula
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                string f;


                f = Convert.ToString(" select top 500 * from operafin1 where cedula =" + textBox1.Text);
                textBox34.Text = Convert.ToString(f);
                DataTable dtm1 = new DataTable("operafin1");
                using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["CnnORDEN"].ConnectionString))
                {
                    if (cn.State == ConnectionState.Closed)
                        cn.Open();

                    using (SqlDataAdapter da = new SqlDataAdapter(textBox34.Text, cn))

                        da.Fill(dtm1);

                    dataGridView7.DataSource = dtm1;

                    dataGridView7.DefaultCellStyle.Font = new Font("Bookshelf Symbol", 7);


                    dataGridView7.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold); // negrita en titulos
                    hide7();

                }

                string f1;

                f1 = Convert.ToString("  SELECT * from nuevoregistro where cedula=" + textBox1.Text);
                textBox33.Text = Convert.ToString(f1);
                DataTable dtm = new DataTable("nuevoregistro");
                using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["CnnORDEN"].ConnectionString))
                {
                    if (cn.State == ConnectionState.Closed)
                        cn.Open();

                    using (SqlDataAdapter da = new SqlDataAdapter(textBox33.Text, cn))

                        da.Fill(dtm);

                    dataGridView1.DataSource = dtm;
                    dataGridView1.Columns.RemoveAt(0);
                    DataGridViewColumn column = dataGridView1.Columns[1];
                    column.Visible = false;
                    dataGridView1.DefaultCellStyle.Font = new Font("Bookshelf Symbol", 6);
                    dataGridView1.RowTemplate.Height = 12;
                    dataGridView1.Columns[0].HeaderText = "";
                    dataGridView1.Columns[0].Width = 33;
                    dataGridView1.Columns[2].HeaderText = "";
                    dataGridView1.Columns[2].Width = 80;

                    dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold); // negrita en titulos
                    dataGridView1.DataSource = dtm;
                    botongrid();


                }

                textBox32.Text = "";
                button6.Enabled = false;
                button7.Enabled = false;
                tabControl1.Enabled = false;
                textBox13.Enabled = true;
                textBox35.Enabled = true;
                
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);
              //  MessageBox.Show("Código no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            int o = Convert.ToInt32(textBox10.Text);
            if (o == 0 && textBox10.Text != null)
            {
                dataGridView7.ColumnHeadersVisible = false;
            }

            else

            {
                dataGridView7.ColumnHeadersVisible = true;
            }
        }

        private void textBox35_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                string f;

                f = Convert.ToString("  SELECT  * FROM operafin1  WHERE cedula = " + textBox1.Text + "  and nomprendac LIKE '" + textBox35.Text + "%'");
                textBox34.Text = Convert.ToString(f);
                DataTable dtm1 = new DataTable("operafin1 ");
                using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["CnnORDEN"].ConnectionString))
                {
                    if (cn.State == ConnectionState.Closed)
                        cn.Open();

                    using (SqlDataAdapter da = new SqlDataAdapter(textBox34.Text, cn))

                        da.Fill(dtm1);
                    dataGridView7.DataSource = dtm1;
                    // DataGridViewColumn column = dataGridView8.Columns[0];
                    //  column.Visible = false;
                    dataGridView7.DefaultCellStyle.Font = new Font("Nirmala UI", 7);
                    dataGridView7.RowTemplate.Height = 13;
                    dataGridView7.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView7.Font, FontStyle.Bold); // negrita en titulos
                                                                                                                     //dataGridView1.Columns[0].HeaderText = "OP";

                    Verresulop();

                }
            }
            catch (Exception ex)
            {

                // MessageBox.Show(ex.Message);
               MessageBox.Show("Sin número de cédula", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Focus();
                // label2.Text = "REGISTRO NO ENCONTRADO";
            }
        }

        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
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

                    Verresulop();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                // MessageBox.Show("Solo se admiten el valor de la OP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // dataGridView3.ClearSelection();
            }
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            try
            {
                (dataGridView7.DataSource as DataTable).DefaultView.RowFilter = string.Format("opp1c = '{0}'", textBox13.Text);
                //Cargarlistadomodifi();
                Verresulop();

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
                lista110();//Verresul2();
                // MessageBox.Show(ex.Message);
                //MessageBox.Show("Solo se admiten el valor de la OP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // label2.Text = "REGISTRO NO ENCONTRADO";
            }
        }

        private void Datos_Enter(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {

                h.Cedulaem = Convert.ToInt32(textBox1.Text);
                h.Nombre = textBox2.Text;
                h.Horario = comboBox1.SelectedItem.ToString();
                h.Dia = textBox4.Text;
                h.Fecha = dateTimePicker6.Value;

                h.Horaentrada = datehorluneentra.Value;
                h.Horasalida = dateTimePicker3.Value;
                h.Improd = Convert.ToDecimal(0);
                h.Mdia = Convert.ToDecimal(0);
                h.Totalminutos = Convert.ToDecimal(0);

                h.Estado = Convert.ToInt32(textBox32.Text);
                h.Sin = Convert.ToDecimal(textBox5.Text);



                MessageBox.Show(h.Registrarhorario(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string f4;

                f4 = Convert.ToString(" select top 500 * from tiempoemn  where estado =" + textBox32.Text);
                textBox34.Text = Convert.ToString(f4);
                DataTable dtm14 = new DataTable("tiempoemn ");
                using (SqlConnection cn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["CnnORDEN"].ConnectionString))
                {
                    if (cn1.State == ConnectionState.Closed)
                        cn1.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter(textBox34.Text, cn1))
                        da.Fill(dtm14);
                    dataGridView6.DataSource = dtm14;
                    dataGridView6.ColumnHeadersDefaultCellStyle.Font = new Font("Arial Rounded MT", 6);  //tamaño en titulos
                    dataGridView6.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView6.Font, FontStyle.Bold); // negrita en titulos
                    dataGridView6.RowTemplate.Height = 13;
                    dataGridView6.DataSource = dtm14;
                    dataGridView6.Columns[0].HeaderText = "Id";
                    dataGridView6.Columns[0].Width = 50;
                    dataGridView6.Columns[1].HeaderText = "Cedula";
                    dataGridView6.Columns[1].Width = 70;
                    dataGridView6.Columns[2].HeaderText = "Empleado";
                    dataGridView6.Columns[2].Width = 110;
                    dataGridView6.Columns[3].HeaderText = "Horario";
                    dataGridView6.Columns[3].Width = 50;
                    dataGridView6.Columns[4].HeaderText = "Dia";
                    dataGridView6.Columns[4].Width = 50;
                    dataGridView6.Columns[5].HeaderText = "Fecha";
                    dataGridView6.Columns[5].Width = 80;
                    dataGridView6.Columns[6].HeaderText = "Entrada";
                    dataGridView6.Columns[6].Width = 50;
                    dataGridView6.Columns[7].HeaderText = "Salida";
                    dataGridView6.Columns[7].Width = 50;
                    dataGridView6.Columns[8].HeaderText = "Improductivos";
                    dataGridView6.Columns[8].Width = 85;
                    dataGridView6.Columns[9].HeaderText = "Dia";
                    dataGridView6.Columns[9].Width = 50;
                    dataGridView6.Columns[10].HeaderText = "Total";
                    dataGridView6.Columns[10].Width = 50;
                    dataGridView6.Columns[11].HeaderText = "Estado";
                    dataGridView6.Columns[11].Width = 50;
                    dataGridView6.Columns[12].HeaderText = "Ausente";
                    dataGridView6.Columns[12].Width = 50;
                    DataGridViewColumn column = dataGridView6.Columns[11];
                    column.Visible = false;
                    Verresulhorario();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Campos Vacíos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //  MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
             try
           {
                    D.Id = Convert.ToInt32(textBox32.Text);
                    D.Nombreemplea = textBox2.Text;
                  D.Cedula = Convert.ToInt32(textBox1.Text);

                    D.Cargo = textBox3.Text;

                D.Rendi = lbnminutoseficiencia.Text;
                D.Efici = lbrendimiento.Text;


                    D.Valorminut = lbvalorminuto.Text;
                    D.Minuingene = Convert.ToDecimal(txtminutosproduccion.Text);
                    D.Totalminuingene = Convert.ToDecimal(lbprecioingenieria.Text);
                    D.Minupresenc = Convert.ToDecimal(txttotalminutos.Text);
                    D.Minuimproduct = Convert.ToDecimal(lbminutoscompañia.Text);//compañia
                    D.TotalImpro = Convert.ToDecimal(label61.Text);//compañia
                D.A = Convert.ToDecimal(txtminutosimproductivos.Text);//improductivos de horario
                D.B = Convert.ToDecimal(lbminuresuniones.Text);//totalminutos improductivos
                D.C = Convert.ToDecimal(lbvalorreuniones.Text);//preciominutosimproductivos
                D.Fectivo = Convert.ToDecimal(lbfestivo.Text);
                    D.Totalfecti = Convert.ToDecimal(lbvalorfestivo.Text);
                    D.Reunio = Convert.ToDecimal(lbminutosimproductivos.Text);//operario
                    D.Totalreunion = Convert.ToDecimal(lbvalorimproductivo.Text);//operario

                   D.Totaltodo = Convert.ToDecimal(tstresultadofinal.Text);
                    D.Fecha = dateTimePicker6.Value;
                    MessageBox.Show(D.Registrefinal(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  //  Cargarlistadorepor();
                  //  Verresul3();


                
               }
              catch (Exception ex)
                {
                   MessageBox.Show(" Capacidad no generada ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                   MessageBox.Show(ex.Message);
                }
            
        }

        public void Valor52op(string _dato52)
        {
            throw new NotImplementedException();
        }

        private void button15_Click(object sender, EventArgs e)
        {
           
            Formreporte1 nuevo = new Formreporte1();
            nuevo.textBox1.Text = textBox32.Text;
            nuevo.ShowDialog();
           
        }

        private void button18_Click(object sender, EventArgs e)
        {
            crystal nuevo = new crystal();
        
            nuevo.ShowDialog();
        }

        private void textBox8_Validating(object sender, CancelEventArgs e)
        {
            if (textBox8.Text.Trim() == String.Empty & comboBox3.Text.Trim() == String.Empty)
            {
                errorProvider1.SetError(textBox8, "Ingrese un valor ");
                button1.Enabled = false;
                button1.BackColor = Color.Gray;

            }
            else
            {

               button1.Enabled = true;

                errorProvider1.Clear();
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (textBox8.Text.Trim() == String.Empty & comboBox3.Text.Trim() == String.Empty)
            {
                errorProvider1.SetError(textBox8, "Ingrese un valor ");
                button1.Enabled = false;
                button1.BackColor = Color.Gray;

            }
            else
            {

                button1.Enabled = true;

                errorProvider1.Clear();
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            FormTPROCESO nuevo = new FormTPROCESO();

            nuevo.ShowDialog();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                int a = 0;
                // DataGridViewImageCell cell = (DataGridViewImageCell)
                // dataGridView1.Rows[].Cells[e.ColumnIndex];

               
                a = Convert.ToInt32(textBox32.Text);

                // this.dataGridView1.CurrentCell = this.dataGridView1[1,0];

               F.IdInicio = Convert.ToInt32(textBox32.Text);
                //  re.Op = Convert.ToInt32(txtseletop.Text);
                if (MessageBox.Show(" ¿ Está seguro que desea eliminar el  N° " + a + " ?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    MessageBox.Show(F.Eliminanuevo(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  //  Cargarlistadomodifi();
                   // textBox21.Clear();
                  //  Verresul2();
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
                MessageBox.Show("  Número incorrecto.  ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView7_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
           {
                int a ;
                textBox18.Text = dataGridView7.CurrentCell.Value.ToString();


                try
              {
                    a = Convert.ToInt32(textBox18.Text);
                    F.IdInicio = Convert.ToInt32(textBox18.Text);


                    if (MessageBox.Show("¿ Esta seguro de eliminar el Id " + a + " ?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        F.IdInicio = Convert.ToInt32(textBox18.Text);
                       F.Eliminafinal();                     
                        MessageBox.Show("Registro eliminado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        string f1;

                        f1 = Convert.ToString(" select top 500 * from operafin1 where numero = " + textBox32.Text);
                        textBox34.Text = Convert.ToString(f1);
                        DataTable dtm11 = new DataTable("operafin1");
                        using (SqlConnection cn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["CnnORDEN"].ConnectionString))
                        {
                            if (cn1.State == ConnectionState.Closed)
                                cn1.Open();

                            using (SqlDataAdapter da = new SqlDataAdapter(textBox34.Text, cn1))

                                da.Fill(dtm11);

                            dataGridView7.DataSource = dtm11;

                            //   DataGridViewColumn column = dataGridView1.Columns[1];
                            //   column.Visible = false;
                            dataGridView7.DefaultCellStyle.Font = new Font("Bookshelf Symbol", 7);
                            dataGridView7.RowTemplate.Height = 13;


                           // dataGridView7.DataSource = dtm11;

                            hide7();

                        }

                        dataGridView7.ClearSelection();



                    }

             }
                catch (Exception ex)
                {
                  //  MessageBox.Show(ex.Message);
                }
            }
        }

        private void dataGridView6_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {


                try
                {
                    int a = 0;
                    textBox18.Text = dataGridView6.CurrentCell.Value.ToString();
                    a = Convert.ToInt32(textBox18.Text);



                    O.Id = Convert.ToInt32(textBox18.Text);

                    if (MessageBox.Show(" ¿ Está seguro que desea eliminar el registro " + a + " ?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)

                    {

                        MessageBox.Show(O.Eliminarhorario(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox18.Clear();
                        string f4;

                        f4 = Convert.ToString(" select top 500 * from tiempoemn  where estado =" + textBox32.Text);
                        textBox34.Text = Convert.ToString(f4);
                        DataTable dtm14 = new DataTable("tiempoemn ");
                        using (SqlConnection cn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["CnnORDEN"].ConnectionString))
                        {
                            if (cn1.State == ConnectionState.Closed)
                                cn1.Open();

                            using (SqlDataAdapter da = new SqlDataAdapter(textBox34.Text, cn1))

                                da.Fill(dtm14);

                            dataGridView6.DataSource = dtm14;

                            //   DataGridViewColumn column = dataGridView1.Columns[1];
                            //   column.Visible = false;

                            dataGridView6.ColumnHeadersDefaultCellStyle.Font = new Font("Arial Rounded MT", 6);  //tamaño en titulos
                            dataGridView6.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView6.Font, FontStyle.Bold); // negrita en titulos

                            dataGridView6.RowTemplate.Height = 13;


                            dataGridView6.DataSource = dtm14;
                            dataGridView6.Columns[0].HeaderText = "Id";
                            dataGridView6.Columns[0].Width = 50;
                            dataGridView6.Columns[1].HeaderText = "Cedula";
                            dataGridView6.Columns[1].Width = 70;
                            dataGridView6.Columns[2].HeaderText = "Empleado";
                            dataGridView6.Columns[2].Width = 110;
                            dataGridView6.Columns[3].HeaderText = "Horario";
                            dataGridView6.Columns[3].Width = 50;
                            dataGridView6.Columns[4].HeaderText = "Dia";
                            dataGridView6.Columns[4].Width = 50;
                            dataGridView6.Columns[5].HeaderText = "Fecha";
                            dataGridView6.Columns[5].Width = 80;
                            dataGridView6.Columns[6].HeaderText = "Entrada";
                            dataGridView6.Columns[6].Width = 50;
                            dataGridView6.Columns[7].HeaderText = "Salida";
                            dataGridView6.Columns[7].Width = 50;
                            dataGridView6.Columns[8].HeaderText = "Improductivos";
                            dataGridView6.Columns[8].Width = 85;
                            dataGridView6.Columns[9].HeaderText = "Dia";
                            dataGridView6.Columns[9].Width = 50;
                            dataGridView6.Columns[10].HeaderText = "Total";
                            dataGridView6.Columns[10].Width = 50;
                            dataGridView6.Columns[11].HeaderText = "Estado";
                            dataGridView6.Columns[11].Width = 50;
                            dataGridView6.Columns[12].HeaderText = "Ausente";
                            dataGridView6.Columns[12].Width = 50;
                            DataGridViewColumn column = dataGridView6.Columns[11];
                            column.Visible = false;
                            Verresulhorario();

                        }
                        //  MessageBox.Show(re.Eliminarop1(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Limpiar();
                        // Cargarlistado5();
                        // Cargarlistado7();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" seleccionar el número de id  ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    //MessageBox.Show(ex.Message);
                }
            }
        }

        private void dataGridView3_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                try
                {
                    int a = 0;
                    textBox18.Text = dataGridView3.CurrentCell.Value.ToString();
                    a = Convert.ToInt32(textBox18.Text);



                    uni.Id = Convert.ToInt32(textBox18.Text);
                    //  re.Op = Convert.ToInt32(txtseletop.Text);
                    if (MessageBox.Show(" ¿ Está seguro de eliminar el registro " + a + " ?", "ELIMINAR REGISTRO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)

                    {

                        MessageBox.Show(uni.Eliminartproceso(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        string f1;

                        f1 = Convert.ToString(" select top 500 * from tproceso_empleado  where estado =" + textBox32.Text);
                        textBox34.Text = Convert.ToString(f1);
                        DataTable dtm11 = new DataTable("tproceso_empleado");
                        using (SqlConnection cn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["CnnORDEN"].ConnectionString))
                        {
                            if (cn1.State == ConnectionState.Closed)
                                cn1.Open();

                            using (SqlDataAdapter da = new SqlDataAdapter(textBox34.Text, cn1))

                                da.Fill(dtm11);

                            dataGridView3.DataSource = dtm11;

                            //   DataGridViewColumn column = dataGridView1.Columns[1];
                            //   column.Visible = false;

                            dataGridView3.ColumnHeadersDefaultCellStyle.Font = new Font("Arial Rounded MT", 6);  //tamaño en titulos
                            dataGridView3.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView3.Font, FontStyle.Bold); // negrita en titulos

                            dataGridView3.RowTemplate.Height = 13;
                            dataGridView3.Columns[0].HeaderText = "Id";
                            dataGridView3.Columns[0].Width = 50;
                            dataGridView3.Columns[1].HeaderText = "Nombre";
                            dataGridView3.Columns[1].Width = 110;
                            dataGridView3.Columns[2].HeaderText = "Cedula";
                            dataGridView3.Columns[2].Width = 70;
                            dataGridView3.Columns[3].HeaderText = "Compañia";
                            dataGridView3.Columns[3].Width = 60;
                            dataGridView3.Columns[4].HeaderText = "Operario";
                            dataGridView3.Columns[4].Width = 60;
                            dataGridView3.Columns[5].HeaderText = "Observación";
                            dataGridView3.Columns[5].Width = 75;
                            dataGridView3.Columns[6].HeaderText = "ProcesoA.";
                            dataGridView3.Columns[6].Width = 50;
                            dataGridView3.Columns[7].HeaderText = "Estado";
                            dataGridView3.Columns[7].Width = 70;
                            dataGridView3.Columns[8].HeaderText = "Fecha";
                            dataGridView3.Columns[8].Width = 70;
                            dataGridView3.Columns[9].HeaderText = "Nombre";
                            dataGridView3.Columns[9].Width = 70;
                            // dataGridView3.ColumnHeadersVisible = false;  // encabezado//
                            // DataGridViewColumn column = dataGridView.Columns[0];
                            DataGridViewColumn column = dataGridView3.Columns[6];
                            column.Visible = false;
                            DataGridViewColumn column1 = dataGridView3.Columns[7];
                            column1.Visible = false;

                       //  dataGridView3.DataSource = dtm11;
                            Verresulprocesos();

                            textBox18.Clear();

                        }
                    }
                    //  MessageBox.Show(re.Eliminarop1(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Limpiar();
                    // Cargarlistado5();
                    // Cargarlistado7();
                }
                catch (Exception ex)
                {
                   // MessageBox.Show("  Unicamente seleccionar el número de id  ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    //MessageBox.Show(ex.Message);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dateTimePicker4.Value = DateTime.Now;
        }

        private void Unico_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void dataGridView7_VisibleChanged(object sender, EventArgs e)
        {
            int o = Convert.ToInt32(textBox10.Text);
            if (o == 0 && textBox10.Text != null)
            {
                dataGridView7.ColumnHeadersVisible = false;
            }

            else
        
            {
                dataGridView7.ColumnHeadersVisible = true;
            }
        }

        private void dataGridView7_Validating(object sender, CancelEventArgs e)
        {
           
        }

        private void dataGridView6_VisibleChanged(object sender, EventArgs e)
        {
         
            validarhorario();


            int o = Convert.ToInt32(textBox9.Text);
            if (o == 0 && textBox9.Text != null)
            {
                dataGridView6.ColumnHeadersVisible = false;
            }

            else

            {
                dataGridView6.ColumnHeadersVisible = true;
            }
        }

        private void dataGridView6_Validating(object sender, CancelEventArgs e)
        {
           
        }

        private void dataGridView3_VisibleChanged(object sender, EventArgs e)
        {
            validartproceso();
      
            int o = Convert.ToInt32(textBox15.Text);
            if (o == 0 && textBox15.Text != null)
            {
                dataGridView3.ColumnHeadersVisible = false;
            }

            else

            {
                dataGridView3.ColumnHeadersVisible = true;
            }
        }

        private void dataGridView3_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            int o = Convert.ToInt32(textBox9.Text);
            if (o == 0 && textBox9.Text != null)
            {
                dataGridView6.ColumnHeadersVisible = false;
            }

            else

            {
                dataGridView6.ColumnHeadersVisible = true;
            }
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            int o = Convert.ToInt32(textBox15.Text);
            if (o == 0 && textBox15.Text != null)
            {
                dataGridView3.ColumnHeadersVisible = false;
            }

            else

            {
                dataGridView3.ColumnHeadersVisible = true;
            }
        }

        private void tabControl1_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
         
            validarhorario();
        }

        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
            validartproceso();
   
        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                D.Id = Convert.ToInt32(textBox32.Text);
                D.Nombreemplea = textBox2.Text;
                D.Cedula = Convert.ToInt32(textBox1.Text);

                D.Cargo = textBox3.Text;

                D.Rendi = lbnminutoseficiencia.Text;
                D.Efici = lbrendimiento.Text;


                D.Valorminut = lbvalorminuto.Text;
                D.Minuingene = Convert.ToDecimal(txtminutosproduccion.Text);
                D.Totalminuingene = Convert.ToDecimal(lbprecioingenieria.Text);
                D.Minupresenc = Convert.ToDecimal(txttotalminutos.Text);
                D.Minuimproduct = Convert.ToDecimal(lbminutoscompañia.Text);//compañia
                D.TotalImpro = Convert.ToDecimal(label61.Text);//compañia
                D.A = Convert.ToDecimal(txtminutosimproductivos.Text);//improductivos de horario
                D.B = Convert.ToDecimal(lbminuresuniones.Text);//totalminutos improductivos
                D.C = Convert.ToDecimal(lbvalorreuniones.Text);//preciominutosimproductivos
                D.Fectivo = Convert.ToDecimal(lbfestivo.Text);
                D.Totalfecti = Convert.ToDecimal(lbvalorfestivo.Text);
                D.Reunio = Convert.ToDecimal(lbminutosimproductivos.Text);//operario
                D.Totalreunion = Convert.ToDecimal(lbvalorimproductivo.Text);//operario

                D.Totaltodo = Convert.ToDecimal(tstresultadofinal.Text);
                D.Fecha = dateTimePicker6.Value;
                MessageBox.Show(D.Actuareport(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //  Cargarlistadorepor();
                //  Verresul3();



            }
            catch (Exception ex)
            {
                MessageBox.Show(" Sin datos ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

               // MessageBox.Show(ex.Message);
            }

        }
    }
    
}
