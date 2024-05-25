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
using CrystalDecisions.CrystalReports.Engine;
using ClassLibrary1;
using CrystalDecisions.Shared;

namespace WindowsFormsApp1
{
    public partial class Busempleado : Form
    {
        Clsreporte2 D2 = new Clsreporte2();
        Clsreporte D = new Clsreporte();
        clshorario E = new clshorario();
        Clsfinal F = new Clsfinal();


        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["CnnORDEN"].ConnectionString);

        void buscarcedu()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("buscarcedureport", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@cedula ", SqlDbType.Int).Value = txtcedula.Text;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //lblverno.Text = "Registro no encontrado";
                //MessageBox.Show("Solo se admiten el valor de la OP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        void buscarrepo2()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("buscarfechasrepo2", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@fechaini", SqlDbType.DateTime).Value = dateTimePicker2.Text;
                da.SelectCommand.Parameters.Add("@fechafinal", SqlDbType.DateTime).Value = dateTimePicker3.Text;
                DataTable dt = new DataTable();
                da.Fill(dt);
                this.dataGridView2.DataSource = dt;

                Verresulrepor2();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //lblverno.Text = "Registro no encontrado";
                //MessageBox.Show("Solo se admiten el valor de la OP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void relle2()
        {
            try
            {

                DataView dv = dt2.DefaultView;

                dv.RowFilter = string.Format(" nombreple like '%{0}%'", txtBuscarr.Text);
                dataGridView4.DataSource = dv.ToTable();

                Verresul2();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                // MessageBox.Show("Solo se admiten el valor de la OP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // dataGridView3.ClearSelection();
            }
        }

        private void relle3()
        {


            try
            {
                (dataGridView6.DataSource as DataTable).DefaultView.RowFilter = string.Format("Nombre = '{0}'", textBox6.Text);

                dataGridView6.ClearSelection();
                {
                    button20.Enabled = false;
                }
                if (dataGridView6.Rows.Count > 0)
                {
                    button20.Enabled = true;
                }
                Verresul4();

            }

            catch (Exception ex)
            {
                // lblverno.Text = Convert.ToString("¡Registro de ID no existe!");
            }

            //  DataView dv = dth.DefaultView;
            // dv.RowFilter = string.Format(" nombre like '%{0}%'", txtBuscarr.Text);
            // dv.RowFilter = string.Format(" cargo like '%{0}%'", textBox4.Text);
            // dataGridView6.DataSource = dv.ToTable();
            //  Verresul2();
            //  Verresul4();

            //}
            // catch (Exception ex)
            // {
            //     MessageBox.Show(ex.Message);
            //    // MessageBox.Show("Solo se admiten el valor de la OP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //     // dataGridView3.ClearSelection();
            // }
        }


        private void relle1()
        {
            try
            {

                // dataGridView6.DataSource as DataTable).DefaultView.RowFilter = string.Format("Cedula = '{0}'", textBox6.Text);

                //DataView dv = dt2.DefaultView;
                // dv.RowFilter = string.Format(" nombreple like '%{0}%'", txtBuscarr.Text);
                // dataGridView4.DataSource = dv.ToTable();

                Verresul2();
                Verresul4();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                // MessageBox.Show("Solo se admiten el valor de la OP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // dataGridView3.ClearSelection();
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

                Verresul4();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //lblverno.Text = "Registro no encontrado";
                //MessageBox.Show("Solo se admiten el valor de la OP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        clshorario O = new clshorario();
        Clsfinal fe = new Clsfinal();
        ClsReglasEmpleados Reglas = new ClsReglasEmpleados();
        ClsTBL_EMPLEADOS TblAtri = new ClsTBL_EMPLEADOS();

        int Listado = 0;

        public Busempleado()
        {
            InitializeComponent();
        }

        private void Busempleado_Load(object sender, EventArgs e)
        {
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            button3.Enabled = false;

            button21.Enabled = false;
            button25.Enabled = false;
            button29.Enabled = false;
            button19.Enabled = false;
            button27.Enabled = false;
         //   button28.Enabled = false;
            button1.Enabled = false;

            if (dataGridView5.Rows.Count > 0)
            {
                button22.Enabled = true;
            }
            else { button22.Enabled = false; }

            if (dataGridView4.Rows.Count > 0)
            {
                button23.Enabled = true;
            }
            else { button23.Enabled = false; }
            //  button22.Enabled = false;
            if (dataGridView1.Rows.Count > 0)
            {
                button30.Enabled = true;
            }
            else { button30.Enabled = false; }

            if (dataGridView2.Rows.Count > 0)
            {
                button31.Enabled = true;
            }
            else { button31.Enabled = false; }

            dataGridView6.ClearSelection();
            {
                button20.Enabled = false;
            }
            // Cargarlistadohorario();
            Cargarlistadorepor2();
            Cargarlistaoperafin();
            Cargarlistadorepor();
            listahoracopia();

            listavalida();
            listarepor2();
            lista11();
            lista1();
            lista4();
            //Listarempleado();

            Verresul3();
            Verresul4();
            Verresul2();
            Verresulrepor2();
        }
        decimal mife, q, w, e, eficiu, efici, xC, xO, xim;
        decimal xl, xi, ff, kk, final, nnh1, d;
        decimal minu, hora, im, mire, nnh, horaim, j, l, t, s, k, o;
        private void Operacion()
        {
            try
            {

                //porcentajes
                j = Convert.ToDecimal(.01);
                l = Convert.ToDecimal(.50);
                t = Convert.ToDecimal(.84);
                s = Convert.ToDecimal(.85);
                k = Convert.ToDecimal(.90);
                o = Convert.ToDecimal(.95);




                xC = Convert.ToDecimal(textBox7.Text);                   //compañia
               // xO = Convert.ToDecimal(textBox1.Text);                   //operario
                minu = Convert.ToDecimal(txtminutosproduccion.Text);  /// total minutos en produccion
                lbminuingenieria.Text = minu.ToString("N2");
                hora = Convert.ToDecimal(txttotalminutos.Text);  //  total minutos en horario
                
                lbminupresenciales.Text = hora.ToString("N2");
                horaim = Convert.ToDecimal(textBox1.Text);  //  minutos improducctivos
                lbminutosimproductivos.Text = textBox1.Text;
                mife = Convert.ToDecimal(textBox5.Text);   /// minutos festivos
                lbfestivo.Text = textBox5.Text;
                w = Convert.ToDecimal(textBox5.Text);   /// minutos reuniones
                e = Convert.ToDecimal(textBox12.Text);
                lbminuresuniones.Text = textBox12.Text;
                efici = hora - (xC + horaim)  ;
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
                    q = Convert.ToDecimal(txt1p.Text);

                    xl = Convert.ToDecimal(minu * q);
                    lbvalorminuto.Text = Convert.ToString(q.ToString("$0"));

                    lbprecioingenieria.Text = xl.ToString("N2");
                    lbrendimiento.Text = Convert.ToString(nnh.ToString("0.00%"));
                   // eficiu = minu/eficiu;
                    lbnminutoseficiencia.Text = Convert.ToString(eficiu.ToString("0.00%"));
                    lbnminutoseficiencia.BackColor = Color.Red;
                    lbnminutoseficiencia.ForeColor = Color.Black;

                    xim = Convert.ToDecimal(txtim.Text);
                    xi = Convert.ToDecimal(horaim * xim);

                    lbvalorimproductivo.Text = xi.ToString("N2");
                    d = Convert.ToDecimal(w * xim);
                    lbvalorreuniones.Text = d.ToString("N2");

                    //////////festivos
                    ///        
                    ff = Convert.ToDecimal(txtfes.Text);
                    kk = Convert.ToDecimal(ff * mife);
                    lbvalorfestivo.Text = kk.ToString("N2");
                    final = Convert.ToDecimal(xl + kk + xi);
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
                        lbnminutoseficiencia.Text = Convert.ToString(eficiu.ToString("0.00%"));

                        lbnminutoseficiencia.BackColor = Color.Red;
                        lbnminutoseficiencia.ForeColor = Color.Black;

                        xim = Convert.ToDecimal(txtim.Text);
                        xi = Convert.ToDecimal(horaim * xim);
                        lbvalorimproductivo.Text = xi.ToString("N2");
                        d = Convert.ToDecimal(w * xim);
                        lbvalorreuniones.Text = d.ToString("N2");
                        //////////festivos
                        ///        
                        ff = Convert.ToDecimal(txtfes.Text);
                        kk = Convert.ToDecimal(ff * mife);
                        lbvalorfestivo.Text = kk.ToString("N2");
                        final = Convert.ToDecimal(xl + kk + xi);
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
                            lbnminutoseficiencia.Text = Convert.ToString(eficiu.ToString("0.00%"));
                            lbnminutoseficiencia.BackColor = Color.Red;
                            lbnminutoseficiencia.ForeColor = Color.Black;

                            xim = Convert.ToDecimal(txtim.Text);
                            xi = Convert.ToDecimal(horaim * xim);
                            lbvalorimproductivo.Text = xi.ToString("N2");
                            d = Convert.ToDecimal(w * xim);
                            lbvalorreuniones.Text = d.ToString("N2");
                            //////////festivos
                            ///        
                            ff = Convert.ToDecimal(txtfes.Text);
                            kk = Convert.ToDecimal(ff * mife);
                            lbvalorfestivo.Text = kk.ToString("N2");
                            final = Convert.ToDecimal(xl + kk + xi);
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
                                lbnminutoseficiencia.Text = Convert.ToString(eficiu.ToString("0.00%"));
                                lbnminutoseficiencia.BackColor = Color.Lime;
                                lbnminutoseficiencia.ForeColor = Color.Black;
                                xim = Convert.ToDecimal(txtim.Text);
                                xi = Convert.ToDecimal(horaim * xim);
                                lbvalorimproductivo.Text = xi.ToString("N2");
                                d = Convert.ToDecimal(w * xim);
                                lbvalorreuniones.Text = d.ToString("N2");
                                //////////festivos
                                ///        
                                ff = Convert.ToDecimal(txtfes.Text);
                                kk = Convert.ToDecimal(ff * mife);
                                lbvalorfestivo.Text = kk.ToString("N2");
                                final = Convert.ToDecimal(xl + kk + xi);
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
                                    lbnminutoseficiencia.Text = Convert.ToString(eficiu.ToString("0.00%"));
                                    lbnminutoseficiencia.BackColor = Color.Lime;
                                    lbnminutoseficiencia.ForeColor = Color.Black;

                                    xim = Convert.ToDecimal(txtim.Text);
                                    xi = Convert.ToDecimal(horaim * xim);
                                    lbvalorimproductivo.Text = xi.ToString("N2");
                                    d = Convert.ToDecimal(w * xim);
                                    lbvalorreuniones.Text = d.ToString("N2");
                                    //////////festivos
                                    ///        
                                    ff = Convert.ToDecimal(txtfes.Text);
                                    kk = Convert.ToDecimal(ff * mife);
                                    lbvalorfestivo.Text = kk.ToString("N2");
                                    final = Convert.ToDecimal(xl + kk + xi);
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
                                        lbnminutoseficiencia.Text = Convert.ToString(eficiu.ToString("0.00%"));
                                        lbnminutoseficiencia.BackColor = Color.Lime;
                                        lbnminutoseficiencia.ForeColor = Color.Black;

                                        xim = Convert.ToDecimal(txtim.Text);
                                        xi = Convert.ToDecimal(horaim * xim);
                                        lbvalorimproductivo.Text = xi.ToString("N2");
                                        d = Convert.ToDecimal(w * xim);
                                        lbvalorreuniones.Text = d.ToString("N2");
                                        //////////festivos
                                        ///        
                                        ff = Convert.ToDecimal(txtfes.Text);
                                        kk = Convert.ToDecimal(ff * mife);
                                        lbvalorfestivo.Text = kk.ToString("N2");
                                        final = Convert.ToDecimal(xl + kk + xi);
                                        tstresultadofinal.Text = final.ToString("N2");
                                    }

                                }

                            }
                        }
                    }
                }
                else
                {
                    label59.Text = "";
                }

            }
            catch
            {

                MessageBox.Show("Ingresar valores ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }



        }
        private void Cargarlistadohorario()

        {
            try
            {
                dataGridView6.ClearSelection();
                using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["CnnORDEN"].ConnectionString))
                {
                    if (cn.State == ConnectionState.Closed)
                        cn.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter("select * from tiempoemn", cn))
                        da.Fill(dth);

                    dataGridView6.DataSource = dth;




                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataGridView6.ClearSelection();
            //Verresul();

        }
        private void Cargarlistaoperafin()

        {
            try
            {

                using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["CnnORDEN"].ConnectionString))

                {
                    if (cn.State == ConnectionState.Closed)
                        cn.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter("select * from  operafin", cn))
                    {
                        DataTable dt1 = new DataTable("operafin");

                        da.Fill(dt1);
                        dataGridView4.DataSource = dt1;


                        //DataGridViewColumn column = dataGridView1.Columns[0];
                        // column.Visible = false;



                    }

                    // dataGridView4.ClearSelection();
                    //using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["CnnORDEN"].ConnectionString))
                    // {
                    //     if (cn.State == ConnectionState.Closed)
                    //         cn.Open();
                    //     using (SqlDataAdapter da = new SqlDataAdapter("select * from operafin", cn))
                    //        da.Fill(dt2);

                    //    dataGridView4.DataSource = dt2;




                    // }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataGridView4.ClearSelection();
            //Verresul();

        }
        private void Cargarlistadorepor2()

        {
            try
            {
                using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["CnnORDEN"].ConnectionString))

                {
                    if (cn.State == ConnectionState.Closed)
                        cn.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter("select * from  reporte2", cn))
                    {
                        DataTable dt1 = new DataTable("reporte2");

                        da.Fill(dt1);
                        dataGridView2.DataSource = dt1;

                        // dataGridView2.ClearSelection();
                        //  using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["CnnORDEN"].ConnectionString))
                        //  {
                        //    if (cn.State == ConnectionState.Closed)
                        //     cn.Open();
                        // using (SqlDataAdapter da = new SqlDataAdapter("select * from reporte2", cn))
                        //    da.Fill(dt8);

                        //dataGridView2.DataSource = dt8;


                        //DataGridViewColumn column = dataGridView1.Columns[0];
                        // column.Visible = false;



                    }



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataGridView2.ClearSelection();
            //Verresul();

        }
        private void listarepor2()
        {
            try
            {

                using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["CnnORDEN"].ConnectionString))

                {
                    if (cn.State == ConnectionState.Closed)
                        cn.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter("select * from  reporte2", cn))
                    {
                        // DataTable dt1 = new DataTable("reporte2");

                        da.Fill(dt8);
                        dataGridView2.DataSource = dt8;


                        //DataGridViewColumn column = dataGridView1.Columns[0];
                        // column.Visible = false;

                        dataGridView2.Columns[0].HeaderText = "Id";
                        dataGridView2.Columns[1].HeaderText = "Nombre Empleado";
                        dataGridView2.Columns[2].HeaderText = "Cedula";

                        dataGridView2.Columns[3].HeaderText = "Cargo";
                        dataGridView2.Columns[4].HeaderText = "Eficiencia";
                        dataGridView2.Columns[5].HeaderText = "Valor Minuto";
                        dataGridView2.Columns[6].HeaderText = "Minutos Ingenieria";
                        dataGridView2.Columns[7].HeaderText = "Total Minutos Ingenieria";
                        dataGridView2.Columns[8].HeaderText = "Minutos Presenciales";
                        dataGridView2.Columns[9].HeaderText = "Minutos Improductivos";
                        dataGridView2.Columns[10].HeaderText = "Total Minutos Improductivos";
                        dataGridView2.Columns[11].HeaderText = "Minutos Festivos";
                        dataGridView2.Columns[12].HeaderText = "Total Minutos Festivos";
                        dataGridView2.Columns[13].HeaderText = "Minutos de Reuniones";
                        dataGridView2.Columns[14].HeaderText = "Total Minutos de Reuniones";
                        dataGridView2.Columns[15].HeaderText = "Total ";
                        dataGridView2.Columns[16].HeaderText = "Fecha";


                    }

                    // Verresul();
                    Verresulrepor2();
                    // Verresul3();
                    // Verresul4();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //lblverno.Text = "Registro no encontrado";
                //MessageBox.Show("Solo se admiten el valor de la OP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void Cargarlistadorepor()

        {
            try
            {
                using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["CnnORDEN"].ConnectionString))

                {
                    if (cn.State == ConnectionState.Closed)
                        cn.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter("select * from  reporte", cn))
                    {
                        DataTable dt1 = new DataTable("reporte");

                        da.Fill(dt1);
                        dataGridView1.DataSource = dt1;

                        // dataGridView2.ClearSelection();
                        //  using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["CnnORDEN"].ConnectionString))
                        //  {
                        //    if (cn.State == ConnectionState.Closed)
                        //     cn.Open();
                        // using (SqlDataAdapter da = new SqlDataAdapter("select * from reporte2", cn))
                        //    da.Fill(dt8);

                        //dataGridView2.DataSource = dt8;


                        //DataGridViewColumn column = dataGridView1.Columns[0];
                        // column.Visible = false;



                    }



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataGridView1.ClearSelection();
            //Verresul();

        }
        private void lista1()
        {
            try
            {

                using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["CnnORDEN"].ConnectionString))

                {
                    if (cn.State == ConnectionState.Closed)
                        cn.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter("select * from  reporte", cn))
                    {
                        // DataTable dt1 = new DataTable("reporte");

                        da.Fill(dt5);
                        dataGridView1.DataSource = dt5;


                        //DataGridViewColumn column = dataGridView1.Columns[0];
                        // column.Visible = false;

                        dataGridView1.Columns[0].HeaderText = "Id";
                        dataGridView1.Columns[1].HeaderText = "Nombre Empleado";
                        dataGridView1.Columns[2].HeaderText = "Cedula";

                        dataGridView1.Columns[3].HeaderText = "Cargo";
                        dataGridView1.Columns[4].HeaderText = "Eficiencia";
                        dataGridView1.Columns[5].HeaderText = "Valor Minuto";
                        dataGridView1.Columns[6].HeaderText = "Minutos Ingenieria";
                        dataGridView1.Columns[7].HeaderText = "Total Minutos Ingenieria";
                        dataGridView1.Columns[8].HeaderText = "Minutos Presenciales";
                        dataGridView1.Columns[9].HeaderText = "Minutos Improductivos";
                        dataGridView1.Columns[10].HeaderText = "Total Minutos Improductivos";
                        dataGridView1.Columns[11].HeaderText = "Minutos Festivos";
                        dataGridView1.Columns[12].HeaderText = "Total Minutos Festivos";
                        dataGridView1.Columns[13].HeaderText = "Minutos de Reuniones";
                        dataGridView1.Columns[14].HeaderText = "Total Minutos de Reuniones";
                        dataGridView1.Columns[15].HeaderText = "Total ";
                        dataGridView1.Columns[16].HeaderText = "Fecha";


                    }

                    // Verresul();
                    // Verresul2();
                    Verresul3();
                    // Verresul4();

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

                        //DataGridViewColumn column = dataGridView6.Columns[0];
                        // column.Visible = false;
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

                        dataGridView6.Columns[11].HeaderText = "Estado";


                        //color();
                        colorverd();
                    }
                    Verresul4();

                    //Verresul();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //lblverno.Text = "Registro no encontrado";
                //MessageBox.Show("Solo se admiten el valor de la OP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void listahoracopia()
        {
            try
            {

                using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["CnnORDEN"].ConnectionString))

                {
                    if (cn.State == ConnectionState.Closed)
                        cn.Open();
                    using (SqlDataAdapter da2 = new SqlDataAdapter("select * from   tiempoemncop", cn))

                    {
                        DataTable dt1 = new DataTable("tiempoemncop");

                        da2.Fill(dt1);
                        dataGridView5.DataSource = dt1;

                        //DataGridViewColumn column = dataGridView6.Columns[0];
                        // column.Visible = false;
                        dataGridView5.Columns[0].HeaderText = "Id";
                        dataGridView5.Columns[1].HeaderText = "Cedula";
                        dataGridView5.Columns[2].HeaderText = "Nombre Empleado";
                        dataGridView5.Columns[3].HeaderText = "Horario";
                        dataGridView5.Columns[4].HeaderText = "Dia";
                        dataGridView5.Columns[5].HeaderText = "Fecha";
                        dataGridView5.Columns[6].HeaderText = "Fecha de Entrada";
                        dataGridView5.Columns[7].HeaderText = "Fecha de Salida";
                        dataGridView5.Columns[8].HeaderText = "Minutos Improductivos";
                        dataGridView5.Columns[9].HeaderText = "Minutos Dia";
                        dataGridView5.Columns[10].HeaderText = "Minutos Total";

                        dataGridView5.Columns[11].HeaderText = "Estado";


                        //color();
                        // colorverd();
                    }
                    //Verresul4();

                    //Verresul();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //lblverno.Text = "Registro no encontrado";
                //MessageBox.Show("Solo se admiten el valor de la OP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        DataTable dt5 = new DataTable("reporte");
        DataTable dt8 = new DataTable("reporte2");
        DataTable dth = new DataTable("tiempoemn");
        DataTable dt2 = new DataTable("operafin");
        private void lista11()
        {
            try
            {

                using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["CnnORDEN"].ConnectionString))

                {
                    if (cn.State == ConnectionState.Closed)
                        cn.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter("select * from  operafin", cn))
                    {
                        //DataTable dt1 = new DataTable("operacemple");

                        da.Fill(dt2);
                        dataGridView4.DataSource = dt2;


                        //DataGridViewColumn column = dataGridView1.Columns[0];
                        // column.Visible = false;

                        dataGridView4.Columns[0].HeaderText = "Id";
                        dataGridView4.Columns[1].HeaderText = "Cedula";
                        dataGridView4.Columns[2].HeaderText = "Nombre Empleado";
                        dataGridView4.Columns[3].HeaderText = "Cargo";
                        dataGridView4.Columns[4].HeaderText = "OP";
                        dataGridView4.Columns[5].HeaderText = "Id Prenda";
                        dataGridView4.Columns[6].HeaderText = "Nombre de Prenda";
                        dataGridView4.Columns[7].HeaderText = "Id Operacion";
                        dataGridView4.Columns[8].HeaderText = "Nombre de Operacion";
                        dataGridView4.Columns[9].HeaderText = "Descripcion";
                        dataGridView4.Columns[10].HeaderText = "Tiempo";
                        dataGridView4.Columns[11].HeaderText = "Cantidad";
                        dataGridView4.Columns[12].HeaderText = "Total";
                        dataGridView4.Columns[13].HeaderText = "Tiempo en Horas";
                        dataGridView4.Columns[14].HeaderText = "Fecha de Inicio";
                        dataGridView4.Columns[15].HeaderText = "Fecha de Entrega";
                        dataGridView4.Columns[16].HeaderText = "Sobremedida";
                        dataGridView4.Columns[17].HeaderText = "XS";
                        dataGridView4.Columns[18].HeaderText = "S";
                        dataGridView4.Columns[19].HeaderText = "M";
                        dataGridView4.Columns[20].HeaderText = "L";
                        dataGridView4.Columns[21].HeaderText = "XL";
                        dataGridView4.Columns[22].HeaderText = "XXL";
                        dataGridView4.Columns[23].HeaderText = "3 XL";
                        dataGridView4.Columns[24].HeaderText = "4 XL";
                        dataGridView4.Columns[25].HeaderText = "5 XL";
                        dataGridView4.Columns[26].HeaderText = "6 XL";
                        dataGridView4.Columns[27].HeaderText = "Fecha";
                        dataGridView4.Columns[28].HeaderText = "Estado";








                    }

                    // Verresul();
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
        //  private void Listarempleado()
        // {

        //    DataTable dt = new DataTable();
        //   dt = Reglas.ListadoEmpleados();
        //   try
        //  {
        //    dataGridView5.Rows.Clear();
        //    for (int i = 0; i < dt.Rows.Count; i++)
        //   {
        //       dataGridView5.Rows.Add(dt.Rows[i][0]);
        //      dataGridView5.Rows[i].Cells[0].Value = dt.Rows[i][0].ToString();
        //      dataGridView5.Rows[i].Cells[1].Value = dt.Rows[i][1].ToString();
        //      dataGridView5.Rows[i].Cells[2].Value = dt.Rows[i][2].ToString();
        //      dataGridView5.Rows[i].Cells[3].Value = dt.Rows[i][3].ToString();

        //Verresul();
        //  }
        // }
        // catch (Exception ex)
        //  {
        //      MessageBox.Show(ex.Message);
        //  }
        //  dataGridView5.ClearSelection();
        //}


        // private void Busquedaempleado2()
        // {
        //    try
        //     {
        //        DataTable dt = new DataTable();
        //         DataRow row;
        //        TblAtri.Cedula = Convert.ToInt32(txtbuscar.Text);
        //        dt = Reglas.BuscarEmpleados(TblAtri.Cedula.ToString());
        ///       if (dt.Rows.Count == 1)
        //       {
        //          row = dt.Rows[0];
        //         txtidentificacion.Text = row[0].ToString();
        //        txtnombres.Text = row[1].ToString();
        //        txtcargo.Text = row[2].ToString();
        //       txtcategoria.Text = row[3].ToString();


        //       MessageBox.Show("Registro Encontrado Ok...!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //   }
        //    else
        //     {
        //         MessageBox.Show("Registro de Empleado no Existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //  Limpiar();
        //    }
        // }
        //  catch (Exception ex)
        //  {
        //     MessageBox.Show(ex.Message);
        // }



        //}
        // private void Busquedaempleado()
        //  {
        //  /
        //  DataTable dt = new DataTable();

        //  try
        //  {
        //  TblAtri.Cedula = Convert.ToInt32(txtbuscar.Text);
        //      dt = Reglas.BuscarEmpleados(TblAtri.Cedula.ToString());
        //  dataGridView5.Rows.Clear();
        //      for (int i = 0; i < dt.Rows.Count; i++)
        //      {
        //     dataGridView5.Rows.Add(dt.Rows[i][0]);
        ///     dataGridView5.Rows[i].Cells[0].Value = dt.Rows[i][0].ToString();
        //    dataGridView5.Rows[i].Cells[1].Value = dt.Rows[i][1].ToString();
        //    dataGridView5.Rows[i].Cells[2].Value = dt.Rows[i][2].ToString();
        //   dataGridView5.Rows[i].Cells[3].Value = dt.Rows[i][3].ToString();

        //}
        // }
        // catch (Exception ex)
        // {
        //     MessageBox.Show(ex.Message);
        // }
        // dataGridView5.ClearSelection();

        // }
        private void dataGridView5_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // txtbuscar.Text = dataGridView5.CurrentCell.Value.ToString();
            //Busquedaempleado2();
            // Busquedaempleado();
            //timer1.Stop();

            // if (dataGridView5.Rows.Count > 0)
            //{
            //     dataGridView5.Rows[dataGridView5.CurrentRow.Index].Selected = true;
            //     timer1.Stop();
            // }
        }

        // private void timer1_Tick(object sender, EventArgs e)
        // {

        //     switch (Listado)
        //   {
        //       case 0: Listarempleado(); break;
        //  }
        //  }

        // private void txtbuscar_KeyPress(object sender, KeyPressEventArgs e)
        // {
        //     if (e.KeyChar == 13)
        //    {
        //       Busquedaempleado();
        //       timer1.Stop();
        //   }
        //   else
        //   {
        //Listarempleado();
        //     timer1.Start();
        // }
        // }

        private void dataGridView5_KeyPress(object sender, KeyPressEventArgs e)
        {
            //  if (e.KeyChar == 13)
            // {
            // if (dataGridView5.SelectedRows.Count > 0)
            //      dataGridView5.ClearSelection();
            // }
        }

        private void dataGridView5_Click(object sender, EventArgs e)
        {
            //   if (dataGridView5.Rows.Count > 0)
            //  {
            //      dataGridView5.Rows[dataGridView5.CurrentRow.Index].Selected = true;
            //     timer1.Stop();
            /// }
        }

        private void dataGridView5_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView5_MouseMove(object sender, MouseEventArgs e)
        {
            timer1.Stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //CrystalReport1 reporte = new CrystalReport1();
            // crystalReportViewer1.ReportSource = reporte;


            //Dsrep Ds = new Dsrep();
            //  int filas = dataGridView6.Rows.Count;



            // / for (int i = 0; i <= filas - 1; i++)
            // {

            //     Ds.Tables[0].Rows.Add
            //        (new object[] {  dataGridView6[0,i].Value.ToString(),
            //    dataGridView6[1,i].Value.ToString(),
            //   dataGridView6[2,i].Value.ToString(),
            //   dataGridView6[3,i].Value.ToString(),
            //  dataGridView6[4,i].Value.ToString(),
            // dataGridView6[5,i].Value.ToString(),
            // dataGridView6[6,i].Value.ToString(),
            //dataGridView6[7,i].Value.ToString(),
            // dataGridView6[8,i].Value.ToString(),
            // dataGridView6[9,i].Value.ToString(),
            // dataGridView6[10,i].Value.ToString(),
            //dataGridView6[11,i].Value.ToString(),

            //  }); 

            // Dsrep Dsrepo = new Dsrep();

            // CRepo crp = new CRepo();

            //  crp.Database.Tables["orige"].SetDataSource(Ds.Tables[0]);
            // crp.Database.Tables["origen"].SetDataSource(Dsrepo.Tables[1]);
            // crystalReportViewer1.ReportSource = null;
            //  crystalReportViewer1.ReportSource = Ds;

            //  }

            //   DataSet1 Ds2 = new DataSet1();


            // int filas2 = dataGridView3.Rows.Count;

            //f//or (int i = 0; i <= filas2 - 1; i++)
            //{

            //  Ds2.Tables[0].Rows.Add
            //    (new object[] {  dataGridView3[0,i].Value.ToString(),
            //  dataGridView3[1,i].Value.ToString(),
            //dataGridView3[2,i].Value.ToString(),
            //dataGridView3[3,i].Value.ToString(),
            //dataGridView3[4,i].Value.ToString(),
            //dataGridView3[5,i].Value.ToString(),


            // Dsrep Dsrepo = new Dsrep();

            // CRepo crp = new CRepo();

            // crp.Database.Tables["orige"].SetDataSource(Dsrepo.Tables[0]);
            // crp.Database.Tables["origen"].SetDataSource(Ds2.Tables[1]);
            //  crystalReportViewer1.ReportSource = null;
            //  crystalReportViewer1.ReportSource = Ds2;
            // ReportDocument oRep = new ReportDocument();
            //            oRep.Load("C:/Users/family/Desktop/paginas web/sistematiempos/WindowsFormsApp1/CapaDatos/CrystalReport2.rpt");
            //          oRep.SetDataSource(Ds2);
            //        crystalReportViewer1.ReportSource = oRep;
            //  }









        }

        private void button7_Click(object sender, EventArgs e)
        {




            //cn.Open();
            // SqlDataAdapter sqlda = new SqlDataAdapter("brteceduu", cn);
            // sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
            //sqlda.SelectCommand.Parameters.Add("@Datos ", SqlDbType.Int).Value = txtcedula.Text;
            //  DataSet1 dspro = new DataSet1();
            // ReportDocument oRep = new ReportDocument();
            // sqlda.Fill(dspro);

            // cn.Close();

            // CrystalReport2 crtp = new CrystalReport2();
            //crtp.Database.Tables["origen"].SetDataSource(dspro.Tables[0]);
            //crtp.Database.Tables["origen1"].SetDataSource(dspro.Tables[1]);
            //crystalReportViewer1.ReportSource = null;
            //crystalReportViewer1.ReportSource = crtp;
            // cn.Close();
            // ReportDocument oRep = new ReportDocument();
            //oRep.Load("C:/Users/family/Desktop/paginas web/sistematiempos/WindowsFormsApp1/CapaDatos/CrystalReport2.rpt");
            // oRep.SetDataSource(dspro);
            // crystalReportViewer1.ReportSource = oRep;

        }

        private void button10_Click(object sender, EventArgs e)
        {


        }
        private void reportegeneral()
        {

        

        }

        private void button11_Click(object sender, EventArgs e)
        {
            // CrystalReport2 reporte = new CrystalReport2();
            //crystalReportViewer1.ReportSource = reporte;
        }

        public struct Datos
        {
            public int Identifi;
            public string Nombre;
            public string Cargo;
            public string Categ;
            //public List<string> lista;
        }

        private void dataGridView3_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int a = 0;
            textBox44.Text = dataGridView1.CurrentCell.Value.ToString();

            try
            {
                D.Id = Convert.ToInt32(textBox44.Text);
                a = Convert.ToInt32(textBox44.Text);
                if (MessageBox.Show(" ¿ Esta seguro que quieres eliminar el registro " + a + "?", "Eliminar Registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    D.Elimireport();

                    lista1();
                    Verresul3();
                }

                //  MessageBox.Show(re.Eliminarop1(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Limpiar();
                //  Sumadetiempo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView2_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox47_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {

            }
            else
            {
                //lista4();
                //buscarrepo2();
            }
        }

        private void textBox47_TextChanged(object sender, EventArgs e)
        {

            elimin4();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            buscarrepo2();
        }

        private void button12_Click(object sender, EventArgs e)
        {
         

        }

        private void textBox44_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Datos info;
            // info.Identifi = Convert.ToInt32(txtidentificacion.Text);
            //  info.Nombre = txtnombres.Text;
            //info.Cargo = txtcargo.Text;
            // info.Categ = txtcategoria.Text;
            // info.lista = new List<string>(new string[] { });




        }


        private void dataGridView6_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void listarelle()
        {
            //try
            // {

            //   using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["CnnORDEN"].ConnectionString))

            //  {
            //     if (cn.State == ConnectionState.Closed)
            //        cn.Open();
            //   using (SqlDataAdapter da = new SqlDataAdapter("select * from  reporte", cn))
            //  {
            //     DataTable dt1 = new DataTable("reporte");

            //  da.Fill(dt1);
            //  dataGridView4.DataSource = dt1;


            //DataGridViewColumn column = dataGridView1.Columns[0];
            // column.Visible = false;

            // dataGridView4.Columns[0].HeaderText = "Id";
            // dataGridView4.Columns[1].HeaderText = "Nombre Empleado";
            // dataGridView4.Columns[2].HeaderText = "Cedula";

            // dataGridView4.Columns[3].HeaderText = "Cargo";
            //dataGridView4.Columns[4].HeaderText = "Eficiencia";
            // dataGridView4.Columns[5].HeaderText = "Valor Minuto";
            // dataGridView4.Columns[6].HeaderText = "Minutos Ingenieria";
            // dataGridView4.Columns[7].HeaderText = "Total Minutos Ingenieria";
            // dataGridView4.Columns[8].HeaderText = "Minutos Presenciales";
            // dataGridView4.Columns[9].HeaderText = "Minutos Improductivos";
            //dataGridView4.Columns[10].HeaderText = "Total Minutos Improductivos";
            // dataGridView4.Columns[11].HeaderText = "Minutos Festivos";
            // dataGridView4.Columns[12].HeaderText = "Total Minutos Festivos";
            // dataGridView4.Columns[13].HeaderText = "Minutos de Reuniones";
            //  dataGridView4.Columns[14].HeaderText = "Total Minutos de Reuniones";
            // dataGridView4.Columns[15].HeaderText = "Total ";
            //   dataGridView4.Columns[16].HeaderText = "Fecha";


            //   }

            // Verresul();
            // Verresul2();
            //  Verresul3();
            // Verresul4();

            // }
            // }
            //  catch (Exception ex)
            // {
            //     MessageBox.Show(ex.Message);
            //lblverno.Text = "Registro no encontrado";
            //MessageBox.Show("Solo se admiten el valor de la OP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //  }

        }

        private void txts_TextChanged(object sender, EventArgs e)
        {
            validarr();
        }

        private void rtxtdescr_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            Decimal cant,
                   tiempo, rest2, rest3, res4, rest5, rest6, rest7, rest8, rest9, rest10, rest11;

            try
            {
                fe.IdInicio = Convert.ToInt32(textBox51.Text);
                fe.Cedula = Convert.ToInt32(txtcedula.Text);
                fe.Nombreemplea = txtnombre.Text;

                fe.Cargo = txtcaaarg.Text;
                fe.Opopera = Convert.ToInt32(txtop.Text);
                fe.Idprenda = Convert.ToInt32(textBox51.Text);
                //nombre prenda texbox3
                fe.Nombrepren = txtnombrpren.Text;
                fe.Idoperacion = Convert.ToInt32(txtidperac.Text);
                fe.Nombreoperacion = txtnomoperaci.Text;
                fe.Categoria = rtxtdescr.Text;

                fe.Tiempoperac = Convert.ToDecimal(txttiempo.Text);
                tiempo = Convert.ToDecimal(txttiempo.Text);

                fe.Cantidadoperac = Convert.ToInt32(txtcantidad.Text);
                cant = Convert.ToInt32(txtcantidad.Text);

                fe.Totaoperac = Convert.ToDecimal(tiempo * cant);
                fe.Hora = txthoras.Text;
                fe.Fechaini = datet3.Value;
                fe.Fechafin = datet2.Value;

                fe.Sobremedidao = Convert.ToInt32(txtsobre.Text);
                fe.Xso = Convert.ToInt32(txtxs.Text);
                fe.So = Convert.ToInt32(txts.Text);
                fe.Mmo = Convert.ToInt32(txtm.Text);
                fe.Lo = Convert.ToInt32(txtl.Text);
                fe.Xlo = Convert.ToInt32(txtxl.Text);
                fe.Xxlo = Convert.ToInt32(txtxxl.Text);
                fe.T3xlo = Convert.ToInt32(txt3xl.Text);
                fe.T4xlo = Convert.ToInt32(txt4xl.Text);
                fe.T5xlo = Convert.ToInt32(txt5xl.Text);
                fe.T6xlo = Convert.ToInt32(txt6xl.Text);
                fe.Fecha = dateT1.Value;
                fe.Estado = Convert.ToInt32(txtestado.Text);


                MessageBox.Show(fe.Registrfinal(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //dataGridView4.Hide();
                //dataGridView4.Show();
                //car();
                Cargarlistaoperafin();

                //DataView dv = dt2.DefaultView;
                // dataGridView4.DataSource = dv.ToTable();
                // this.dataGridView4.DataSource = dt2;
                // dataGridView4.Show();
                Verresul2();
                //lista11();
                //dataGridView4.Show();
                //dataGridView4.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Validar datos por favor ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

               // MessageBox.Show(ex.Message);
            }
        }
        CrystalReport22 info = new CrystalReport22();
        ParameterValues param = new ParameterValues();
        ParameterDiscreteValue myDiscreteValue = new ParameterDiscreteValue();

        CrystalReport1 info1 = new CrystalReport1();
        ParameterValues param1 = new ParameterValues();
        ParameterDiscreteValue myDiscreteValue1 = new ParameterDiscreteValue();

        private void button19_Click(object sender, EventArgs e)
        {
            param.Clear();
            myDiscreteValue.Value = textBox47.Text;
            param.Add(myDiscreteValue);
            info.DataDefinition.ParameterFields["@cedula"].ApplyCurrentValues(param);
            param.Clear();
            //  myDiscreteValue.Value = dateTimePicker2.Value;
            //  param.Add(myDiscreteValue);
            // info.DataDefinition.ParameterFields["@fecha"].ApplyCurrentValues(param);
            crystalReportViewer2.ReportSource = info;

            textBox47.Clear();
            textBox47.Focus();
        }

        private void color()
        {

            for (int i = 0; i < dataGridView4.Rows.Count; i++)
            {
                int val = Int32.Parse(dataGridView4.Rows[i].Cells[28].Value.ToString());


                if (val == 1)
                {
                    dataGridView4.Rows[i].DefaultCellStyle.BackColor = Color.Orange;
                }



            }

        }
        private void actualiza1()
        {
            try
            {
                E.Id = Convert.ToInt32(textBox46.Text);

                E.Estado = Convert.ToInt32(textBox48.Text);
                E.Fecha = dateTimePicker4.Value;

                MessageBox.Show(E.Actualiza1(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dataGridView6_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int a = 0;
                textBox46.Text = dataGridView6.CurrentCell.Value.ToString();
                a = Convert.ToInt32(textBox46.Text);
                try
                {
                    //  re.Op = Convert.ToInt32(txtseletop.Text);
                    if (MessageBox.Show("      Por favor selecionar unicamente el numero de registro para su modificacion.                            " +

                         "¿ Desea pagar este producto con numero de registro" + a + " ?", "PRODUCTO PARA PAGO", MessageBoxButtons.YesNo) == DialogResult.Yes)
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

        private void button20_Click(object sender, EventArgs e)
        {
            try
            {
                string maicon = ConfigurationManager.ConnectionStrings["CnnORDEN"].ConnectionString;
                SqlConnection sqlconn = new SqlConnection(maicon);
                foreach (DataGridViewRow dr in dataGridView6.Rows)
                {
                    string sqlquery = " insert into [dbo].[tiempoemncop] values(@ide,@cedula,@nombre,@horario, @dia,@fechaod ,@hora_entrada,@hora_salida, @improd,@total_dia,@total_minutos,@estado)";
                    SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
                    if (dr.IsNewRow) continue;
                    {
                        sqlcomm.Parameters.AddWithValue("@ide", dr.Cells["ide"].Value = Convert.ToInt32(dr.Cells["ide"].Value));
                        sqlcomm.Parameters.AddWithValue("@cedula", dr.Cells["cedula"].Value = Convert.ToInt32(dr.Cells["cedula"].Value));
                        sqlcomm.Parameters.AddWithValue("@nombre", dr.Cells["nombre"].Value ?? DBNull.Value);
                        sqlcomm.Parameters.AddWithValue("@horario", dr.Cells["horario"].Value ?? DBNull.Value);
                        sqlcomm.Parameters.AddWithValue("@dia", dr.Cells["dia"].Value ?? DBNull.Value);
                        sqlcomm.Parameters.AddWithValue("@fechaod", dr.Cells["fechaod"].Value ?? DBNull.Value);
                        sqlcomm.Parameters.AddWithValue("@hora_entrada", dr.Cells["hora_entrada"].Value ?? DBNull.Value);
                        sqlcomm.Parameters.AddWithValue("@hora_salida", dr.Cells["hora_salida"].Value ?? DBNull.Value);
                        sqlcomm.Parameters.AddWithValue("@improd", dr.Cells["improd"].Value = Convert.ToDecimal(dr.Cells["improd"].Value));
                        sqlcomm.Parameters.AddWithValue("@total_dia", dr.Cells["total_dia"].Value = Convert.ToDecimal(dr.Cells["total_dia"].Value));
                        sqlcomm.Parameters.AddWithValue("@total_minutos", dr.Cells["total_minutos"].Value = Convert.ToDecimal(dr.Cells["total_minutos"].Value));
                        sqlcomm.Parameters.AddWithValue("@estado", dr.Cells["estado"].Value = Convert.ToInt32(dr.Cells["estado"].Value));

                    }
                    sqlconn.Open();
                    sqlcomm.ExecuteNonQuery();

                    sqlconn.Close();

                }
                MessageBox.Show("Se registro correctamente Ok!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                listahoracopia();
                dataGridView5.ClearSelection();
                {
                    button22.Enabled = false;
                }
                if (dataGridView5.Rows.Count > 0)
                {
                    button22.Enabled = true;
                }
                // CargarListadoopp3();
                // CargarListadoopp6();
                // verboton();


            }
            catch (Exception ex)
            {
                // MessageBox.Show("Registro de Orden de Produccion no Existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(" El número de id ya existe ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                relle1();
                Verresul4();
            }
            else
            {
                //lista4();
                dataGridView6.ClearSelection();
                {
                    button20.Enabled = false;
                }
                if (dataGridView6.Rows.Count > 0)
                {
                    button20.Enabled = true;
                }
                dataGridView5.ClearSelection();
                {
                    button21.Enabled = false;
                }
                if (dataGridView5.Rows.Count > 0)
                {
                    button21.Enabled = true;
                }
                buscar4();
                Verresul4();
            }
        }
        private void elimin5()
        {
            if (textBox56.Text != string.Empty)
            {
                button27.Enabled = true;
            }
            else
            {
                button27.Enabled = false;
            }


        }
        private void elimin4()
        {
            if (textBox47.Text != string.Empty)
            {
                button19.Enabled = true;
            }
            else
            {
                button19.Enabled = false;
            }


        }
        private void elimin3()
        {
            if (textBox54.Text != string.Empty)
            {
                button29.Enabled = true;
            }
            else
            {
                button29.Enabled = false;
            }
        }
        private void elimin2()
        {
            if (textBox52.Text != string.Empty)
            {
                button25.Enabled = true;
            }
            else
            {
                button25.Enabled = false;
            }


        }
        private void elimini()
        {
            if (textBox49.Text != string.Empty)
            {
                button21.Enabled = true;
            }
            else
            {
                button21.Enabled = false;
            }


        }
        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void textBox49_TextChanged(object sender, EventArgs e)
        {

            dataGridView5.ClearSelection();
            {
                button22.Enabled = false;
            }
            if (dataGridView5.Rows.Count > 0)
            {
                button22.Enabled = true;
            }
            elimini();

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {

            try
            {

                //  re.Op = Convert.ToInt32(txtseletop.Text);
                if (MessageBox.Show("¿ Está seguro que desea eliminar todos los registros?", "ELIMINAR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    MessageBox.Show(E.Eliminarhorariototal2(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listahoracopia();
                    textBox49.Clear();
                    dataGridView5.ClearSelection();
                    {
                        button22.Enabled = false;
                    }
                    if (dataGridView5.Rows.Count > 0)
                    {
                        button22.Enabled = true;
                    }
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

        private void button21_Click(object sender, EventArgs e)
        {
            try
            {
                E.Cedulae = Convert.ToInt32(textBox49.Text);
                //  re.Op = Convert.ToInt32(txtseletop.Text);
                if (MessageBox.Show("¿ Está seguro que desea eliminar todos los registros con este número de cédula ?", "ELIMINAR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    MessageBox.Show(E.Eliminarhorarcedue(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listahoracopia();
                    textBox49.Clear();
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

        private void dataGridView5_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void dataGridView5_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            textBox49.Text = dataGridView5.CurrentCell.Value.ToString();
        }

        private void dataGridView5_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {


                try
                {
                    int a = 0;
                    textBox49.Text = dataGridView5.CurrentCell.Value.ToString();
                    a = Convert.ToInt32(textBox49.Text);



                    E.Ide = Convert.ToInt32(textBox49.Text);
                    //  re.Op = Convert.ToInt32(txtseletop.Text);
                    if (MessageBox.Show(" ¿ Está seguro que desea eliminar el registro " + a + " ?", "ELIMINAR REGISTRO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)

                    {

                        MessageBox.Show(E.Eliminarhorarioid(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        listahoracopia();// dataGridView6.ClearSelection();
                        textBox49.Clear();

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

        private void groupBox13_Enter(object sender, EventArgs e)
        {

        }

        private void label106_Click(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {
            limpiarvalidarr();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {
            try
            {

                //  re.Op = Convert.ToInt32(txtseletop.Text);
                if (MessageBox.Show("¿ Está seguro que desea eliminar todos los registros ?", "ELIMINAR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    MessageBox.Show(fe.Eliminoperafintotal(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lista11();
                    textBox52.Clear();
                    dataGridView4.ClearSelection();
                    {
                        button23.Enabled = false;
                    }
                    if (dataGridView4.Rows.Count > 0)
                    {
                        button23.Enabled = true;
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
        }

        private void dataGridView4_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {


                try
                {
                    int a = 0;
                    textBox52.Text = dataGridView4.CurrentCell.Value.ToString();
                    a = Convert.ToInt32(textBox52.Text);



                    fe.IdInicio = Convert.ToInt32(textBox52.Text);
                    //  re.Op = Convert.ToInt32(txtseletop.Text);
                    if (MessageBox.Show(" ¿ Está seguro que desea eliminar el registro " + a + " ?", "ELIMINAR REGISTRO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {

                        MessageBox.Show(fe.Eliminafinal(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Cargarlistaoperafin();// dataGridView6.ClearSelection();
                        textBox52.Clear();
                        Verresul2();
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

        private void button25_Click(object sender, EventArgs e)
        {
            try
            {
                fe.Cedula = Convert.ToInt32(textBox52.Text);
                //  re.Op = Convert.ToInt32(txtseletop.Text);
                if (MessageBox.Show("¿ Está seguro que desea eliminar todos los registros con este número de cédula ?", "ELIMINAR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    MessageBox.Show(fe.Eliminafinalcedu(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lista11();
                    textBox52.Clear();
                    Verresul2();
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

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox52.Text = dataGridView4.CurrentCell.Value.ToString();
        }

        private void textBox52_TextChanged(object sender, EventArgs e)
        {
            dataGridView4.ClearSelection();
            {
                button23.Enabled = false;
            }
            if (dataGridView4.Rows.Count > 0)
            {
                button23.Enabled = true;
            }
            elimin2();
        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label105_Click(object sender, EventArgs e)
        {

        }

        private void label83_Click(object sender, EventArgs e)
        {

        }

        private void label103_Click(object sender, EventArgs e)
        {

        }

        private void button32_Click(object sender, EventArgs e)
        {
            //reportegeneral();

            param1.Clear();
            myDiscreteValue1.Value = dateTimePicker2.Text;
            param1.Add(myDiscreteValue1);
            info1.DataDefinition.ParameterFields["@fechaini"].ApplyCurrentValues(param1);
            param1.Clear();
            myDiscreteValue1.Value = dateTimePicker3.Value;
            param1.Add(myDiscreteValue1);
            info1.DataDefinition.ParameterFields["@fechafinal"].ApplyCurrentValues(param1);
           // crystalReportViewer1.ReportSource = info1;  // descomentado


            //  SqlDataAdapter da = new SqlDataAdapter("buscarfechasrepo2", cn);
            // da.SelectCommand.CommandType = CommandType.StoredProcedure;
            // da.SelectCommand.Parameters.Add("@fechaini", SqlDbType.DateTime).Value = dateTimePicker2.Text;
            //  da.SelectCommand.Parameters.Add("@fechafinal", SqlDbType.DateTime).Value = dateTimePicker3.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button28_Click(object sender, EventArgs e)
        {
            registrrepor();

        }

        private void color3()
        {


            for (int i = 0; i < dataGridView4.Rows.Count; i++)
            {
                int val = Int32.Parse(dataGridView4.Rows[i].Cells[28].Value.ToString());


                if (val == 1)
                {
                    dataGridView4.Rows[i].DefaultCellStyle.BackColor = Color.Orange;
                }



            }

        }

        private void button30_Click(object sender, EventArgs e)
        {
            try
            {

                //  re.Op = Convert.ToInt32(txtseletop.Text);
                if (MessageBox.Show("¿ Está seguro que desea eliminar todos los registros ?", "ELIMINAR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    MessageBox.Show(D.Elimireporttotal(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lista1();
                    textBox54.Clear();
                    dataGridView1.ClearSelection();
                    {
                        button30.Enabled = false;
                    }
                    if (dataGridView1.Rows.Count > 0)
                    {
                        button30.Enabled = true;
                    }
                    Verresul3();
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

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {


                try
                {
                    int a = 0;
                    textBox54.Text = dataGridView1.CurrentCell.Value.ToString();
                    a = Convert.ToInt32(textBox54.Text);



                    D.Id = Convert.ToInt32(textBox54.Text);
                    //  re.Op = Convert.ToInt32(txtseletop.Text);
                    if (MessageBox.Show(" ¿ Está seguro que desea eliminar el registro " + a + " ?", "ELIMINAR REGISTRO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {

                        MessageBox.Show(D.Elimireport(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Cargarlistadorepor();// dataGridView6.ClearSelection();
                        textBox54.Clear();
                        Verresul3();

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

        private void button29_Click(object sender, EventArgs e)
        {
            try
            {
                D.Cedula = Convert.ToInt32(textBox54.Text);
                //  re.Op = Convert.ToInt32(txtseletop.Text);
                if (MessageBox.Show("¿ Está seguro que desea eliminar todos los registros con este número de cédula ?", "ELIMINAR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    MessageBox.Show(D.Elimireportcedu(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lista1();
                    textBox54.Clear();
                    Verresul3();
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox54.Text = dataGridView1.CurrentCell.Value.ToString();
        }

        private void textBox54_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            {
                button30.Enabled = false;
            }
            if (dataGridView1.Rows.Count > 0)
            {
                button30.Enabled = true;
            }
            elimin3();
        }

        private void textBox58_TextChanged(object sender, EventArgs e)
        {
            // (dataGridView2.DataSource as DataTable).DefaultView.RowFilter = string.Format("Nombre = '{0}'", textBox58.Text);

            Verresulrepor2();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            try
            {

                //  re.Op = Convert.ToInt32(txtseletop.Text);
                if (MessageBox.Show("¿ Está seguro que desea eliminar todos los registros ?", "ELIMINAR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    MessageBox.Show(D2.Elimireporttotal(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listarepor2();
                    textBox56.Clear();
                    dataGridView2.ClearSelection();
                    {
                        button31.Enabled = false;
                    }
                    if (dataGridView2.Rows.Count > 0)
                    {
                        button31.Enabled = true;
                    }
                    Verresulrepor2();
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

        private void button27_Click(object sender, EventArgs e)
        {
            try
            {
                D2.Cedula = Convert.ToInt32(textBox56.Text);
                //  re.Op = Convert.ToInt32(txtseletop.Text);
                if (MessageBox.Show("¿ Está seguro que desea eliminar todos los registros con este número de cédula ?", "ELIMINAR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    MessageBox.Show(D2.Elimireportcedu(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listarepor2();
                    textBox56.Clear();
                    Verresulrepor2();
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

        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {


                try
                {
                    int a = 0;
                    textBox56.Text = dataGridView2.CurrentCell.Value.ToString();
                    a = Convert.ToInt32(textBox56.Text);



                    D2.Id = Convert.ToInt32(textBox56.Text);
                    //  re.Op = Convert.ToInt32(txtseletop.Text);
                    if (MessageBox.Show(" ¿ Está seguro que desea eliminar el registro " + a + " ?", "ELIMINAR REGISTRO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {

                        MessageBox.Show(D2.Elimireport(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Cargarlistadorepor2();// dataGridView6.ClearSelection();
                        textBox56.Clear();
                        // Cargarlistadorepor2();
                        Verresulrepor2();



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

        private void textBox56_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            {
                button31.Enabled = false;
            }
            if (dataGridView1.Rows.Count > 0)
            {
                button31.Enabled = true;
            }
            elimin5();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox56.Text = dataGridView2.CurrentCell.Value.ToString();
        }

        private void textBox58_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Cargarlistadorepor2();
        }
        int Listado1 = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
           
        }

        private void textBox58_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {



                DataView dv = dt8.DefaultView;
                dv.RowFilter = string.Format(" nombre like '%{0}%'", textBox58.Text);


                dataGridView2.DataSource = dv.ToTable();
                // Verresulrepor2();
                //timer2.Stop();
                // Cargarlistadorepor2();


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

        private void textBox27_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {


                DataView dv = dt8.DefaultView;
                dv.RowFilter = string.Format(" nombre like '%{0}%'", textBox27.Text);
                // dv.RowFilter = string.Format(" cargo like '%{0}%'", textBox4.Text);

                // dataGridView4.DataSource = dv.ToTable();
                dataGridView2.DataSource = dv.ToTable();
                //Verresulrepor2();
                //timer2.Stop();
                // Cargarlistadorepor2();


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

        private void textBox59_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {


                DataView dv = dt5.DefaultView;
                dv.RowFilter = string.Format(" nombre like '%{0}%'", textBox59.Text);
                // dv.RowFilter = string.Format(" cargo like '%{0}%'", textBox4.Text);

                // dataGridView4.DataSource = dv.ToTable();
                dataGridView1.DataSource = dv.ToTable();
                //Verresulrepor2();
                //timer2.Stop();
                // Cargarlistadorepor2();


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

        private void txtidprenda_Validating(object sender, CancelEventArgs e)
        {

        }

        private void textBox51_TextChanged(object sender, EventArgs e)
        {
            validarr();

        }

        private void txtcedula_Validating(object sender, CancelEventArgs e)
        {
            if (txtcedula.Text.Trim() == String.Empty)
            {
                errorProvider2.SetError(txtcedula, "Ingrese un valor ");
                button3.Enabled = false;

            }
            else
            {
                // button3.Enabled = true;

                errorProvider2.Clear();
            }
        }

        private void txtnombre_Validating(object sender, CancelEventArgs e)
        {
            if (txtnombre.Text.Trim() == String.Empty)
            {
                errorProvider3.SetError(txtnombre, "Ingrese un valor ");
                button3.Enabled = false;

            }
            else
            {
                // button3.Enabled = true;

                errorProvider3.Clear();
            }
        }

        private void txtcaaarg_Validating(object sender, CancelEventArgs e)
        {
            if (txtcaaarg.Text.Trim() == String.Empty)
            {
                errorProvider4.SetError(txtcaaarg, "Ingrese un valor ");
                button3.Enabled = false;

            }
            else
            {
                // button3.Enabled = true;

                errorProvider4.Clear();
            }
        }

        private void txtop_Validating(object sender, CancelEventArgs e)
        {
            if (txtop.Text.Trim() == String.Empty)
            {
                errorProvider5.SetError(txtop, "Ingrese un valor ");
                button3.Enabled = false;

            }
            else
            {
                //button3.Enabled = true;

                errorProvider5.Clear();
            }
        }

        private void txtnombrpren_Validating(object sender, CancelEventArgs e)
        {
            if (txtnombrpren.Text.Trim() == String.Empty)
            {
                errorProvider6.SetError(txtnombrpren, "Ingrese un valor ");
                button3.Enabled = false;

            }
            else
            {
                // button3.Enabled = true;

                errorProvider6.Clear();
            }
        }

        private void txtidperac_Validating(object sender, CancelEventArgs e)
        {
            if (txtidperac.Text.Trim() == String.Empty)
            {
                errorProvider7.SetError(txtidperac, "Ingrese un valor ");
                button3.Enabled = false;

            }
            else
            {
                //button3.Enabled = true;

                errorProvider7.Clear();
            }
        }

        private void txtnomoperaci_Validating(object sender, CancelEventArgs e)
        {
            if (txtnomoperaci.Text.Trim() == String.Empty)
            {
                errorProvider8.SetError(txtnomoperaci, "Ingrese un valor ");
                button3.Enabled = false;

            }
            else
            {
                //button3.Enabled = true;

                errorProvider8.Clear();
            }
        }

        private void txttiempo_Validating(object sender, CancelEventArgs e)
        {
            if (txttiempo.Text.Trim() == String.Empty)
            {
                errorProvider9.SetError(txttiempo, "Ingrese un valor ");
                button3.Enabled = false;

            }
            else
            {
                //button3.Enabled = true;

                errorProvider9.Clear();
            }
        }

        private void txtcantidad_Validating(object sender, CancelEventArgs e)
        {
            if (txtcantidad.Text.Trim() == String.Empty)
            {
                errorProvider10.SetError(txtcantidad, "Ingrese un valor ");
                button3.Enabled = false;

            }
            else
            {
                // button3.Enabled = true;

                errorProvider10.Clear();
            }
        }

        private void txttotal_Validating(object sender, CancelEventArgs e)
        {
            if (txttotal.Text.Trim() == String.Empty)
            {
                errorProvider11.SetError(txttotal, "Ingrese un valor ");
                button3.Enabled = false;

            }
            else
            {
                //button3.Enabled = true;

                errorProvider11.Clear();
            }
        }

        private void txtestado_Validating(object sender, CancelEventArgs e)
        {
            if (txtestado.Text.Trim() == String.Empty)
            {
                errorProvider12.SetError(txtestado, "Ingrese un valor ");
                button3.Enabled = false;

            }
            else
            {
                // button3.Enabled = true;

                errorProvider12.Clear();
            }
        }

        private void txthoras_Validating(object sender, CancelEventArgs e)
        {
            if (txthoras.Text.Trim() == String.Empty)
            {
                errorProvider13.SetError(txthoras, "Ingrese un valor ");
                button3.Enabled = false;

            }
            else
            {
                //button3.Enabled = true;

                errorProvider13.Clear();
            }
        }

        private void rtxtdescr_Validating(object sender, CancelEventArgs e)
        {
            if (rtxtdescr.Text.Trim() == String.Empty)
            {
                errorProvider14.SetError(rtxtdescr, "Ingrese un valor ");
                button3.Enabled = false;

            }
            else
            {
                // button3.Enabled = true;

                errorProvider14.Clear();
            }
        }

        private void textBox5_Validating(object sender, CancelEventArgs e)
        {
            if (textBox5.Text.Trim() == String.Empty)
            {
                errorProvider15.SetError(textBox5, "Ingrese un valor ");
                button3.Enabled = false;

            }
            else
            {
                // button3.Enabled = true;

                errorProvider15.Clear();
            }
        }

        private void textBox12_Validating(object sender, CancelEventArgs e)
        {
            if (textBox12.Text.Trim() == String.Empty)
            {
                errorProvider16.SetError(textBox12, "Ingrese un valor ");
                button3.Enabled = false;

            }
            else
            {
                //button3.Enabled = true;

                errorProvider16.Clear();
            }
        }

        private void textBox51_Validating(object sender, CancelEventArgs e)
        {
            if (textBox51.Text.Trim() == String.Empty)
            {
                errorProvider17.SetError(textBox51, "Ingrese minimo 3 caracteres ");
                button3.Enabled = false;

            }
            else
            {
                // button3.Enabled = true;

                errorProvider17.Clear();
            }
        }
        private void limpiar()
        {

            txtcedula.Clear();
            textBox5.Clear();

            textBox12.Clear();
            txtnombre.Clear();
            txtcaaarg.Clear();
            lbminuingenieria.Text = "";
            lbminupresenciales.Text = "";
            lbminutosimproductivos.Text = "";
            lbfestivo.Text = "";
            lbminuresuniones.Text = "";
            lbrendimiento.Text = "";
            label58.Text = "";
            label60.Text = "";
            lbvalorminuto.Text = "";
            lbprecioingenieria.Text = "";
            lbvalorimproductivo.Text = "";
            lbvalorreuniones.Text = "";
            lbvalorfestivo.Text = "";
            tstresultadofinal.Text = "";

        }

        private void validar3()
        {
           int o,i;

       
            label22.Text = (textBox53.Text.Length.ToString());
            o = Convert.ToInt32(label22.Text);

            label115.Text = (textBox55.Text.Length.ToString());
            i = Convert.ToInt32(label115.Text);



            if (o >= 3 & i >= 3)

            // textBox51.Text != string.Empty)
            { button28.Enabled = true; }
            else
            {
                button28.Enabled = false;


            }


          

        }
        private void validar5()
        {

            if (
                


            txt1p.Text != string.Empty &
               txt2p.Text != string.Empty &
               txt3p.Text != string.Empty &
                txt4p.Text != string.Empty &
               txt5p.Text != string.Empty &
                txt6p.Text != string.Empty &
               txtim.Text != string.Empty &
                txtfes.Text != string.Empty 
              
               

            )

            // textBox51.Text != string.Empty)
            { button9.Enabled = true; }
            else
            {
                button9.Enabled = false;
                //button.Enabled = false;
            }

        }
        private void validar2()
        {
            
            if (
                txtcedula.Text != string.Empty &
               textBox5.Text != string.Empty &
               textBox12.Text != string.Empty &
               txtnombre.Text != string.Empty &
               txtcaaarg.Text != string.Empty


            )

            // textBox51.Text != string.Empty)
            { button1.Enabled = true; }
            else
            {
               // button1.Enabled = false;
                //button.Enabled = false;
            }

        }
        private void limpiarvalidarr()
        {
            txtcedula.Text = "";
            txtop.Text = "";
                txtcaaarg.Text = "";
             txtnombre.Text = "";
            txtnombrpren.Text = "";
            txtidperac.Text = "";
            txtnomoperaci.Text = "";
            txttiempo.Text = "";
            txtcantidad.Text = "";
            txttotal.Text = "";

            txtestado.Text = "";
            txthoras.Text = "";
            rtxtdescr.Text = "";

            txtsobre.Text = "";

            txtxs.Text = "";
            txts.Text = "";
            txtm.Text = "";
            txtl.Text = "";
            txtxl.Text = "";
            txtxxl.Text = "";
            txt3xl.Text = "";
            txt4xl.Text = "";
            txt5xl.Text = "";
            txt6xl.Text = "";




            // textBox51.Text != string.Empty)


        }
        private void validarr()
        {
            int o;
            label114.Text = (textBox51.Text.Length.ToString());
            o = Convert.ToInt32(label114.Text);
            if (txtcedula.Text != string.Empty &
                txtop.Text != string.Empty & txtcaaarg.Text != string.Empty
                & txtnombre.Text != string.Empty & txtnombrpren.Text != string.Empty &
               txtidperac.Text != string.Empty &
               txtnomoperaci.Text != string.Empty &
               txttiempo.Text != string.Empty & txtcantidad.Text != string.Empty &
               txttotal.Text != string.Empty & txtestado.Text != string.Empty & txthoras.Text != string.Empty &
               rtxtdescr.Text != string.Empty
                 &
                 txtsobre.Text != string.Empty &
              
               txtxs.Text != string.Empty &
               txts.Text != string.Empty &
               txtm.Text != string.Empty &
               txtl.Text != string.Empty &
               txtxl.Text != string.Empty &
               txtxxl.Text != string.Empty &
               txt3xl.Text != string.Empty &
                txt4xl.Text != string.Empty &
                txt5xl.Text != string.Empty &
                txt6xl.Text != string.Empty &


            o >= 3)

            // textBox51.Text != string.Empty)
            { button3.Enabled = true; }
            else
            {
                button3.Enabled = false;
                //button.Enabled = false;
            }

        }

        private void txtidprenda_TextChanged(object sender, EventArgs e)
        {
            //validarr();
        }

        private void txtcedula_TextChanged(object sender, EventArgs e)
        {
            validarr();
            validar2();
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
            validarr();
            validar2();
        }

        private void txtcaaarg_TextChanged(object sender, EventArgs e)
        {
            validarr();
            validar2();
        }

        private void txtop_TextChanged(object sender, EventArgs e)
        {
            validarr();
        }

        private void txtnombrpren_TextChanged(object sender, EventArgs e)
        {
            validarr();
        }

        private void txtidperac_TextChanged(object sender, EventArgs e)
        {
            validarr();
        }

        private void txtnomoperaci_TextChanged(object sender, EventArgs e)
        {
            validarr();
        }

        private void txttiempo_TextChanged(object sender, EventArgs e)
        {
            validarr();
        }

        private void txtcantidad_TextChanged(object sender, EventArgs e)
        {
            validarr();
        }

        private void txttotal_TextChanged(object sender, EventArgs e)
        {
            validarr();
        }

        private void txtestado_TextChanged(object sender, EventArgs e)
        {
            validarr();
        }

        private void rtxtdescr_TextChanged_1(object sender, EventArgs e)
        {
            validarr();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
           
            validar2();
        }

        private void txthoras_TextChanged(object sender, EventArgs e)
        {
            validarr();
        }

        private void txtcedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                txtnombre.Focus();
            }
            else
            {
            }
        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 13)
            {
                txtcaaarg.Focus();
            }
            else
            {
            }
        }

        private void txtcaaarg_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (e.KeyChar == 13)
            {
                txtop.Focus();
            }
            else
            {
            }
        }

        private void txtop_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == 13)
            {
                txtnombrpren.Focus();
            }
            else
            {
            }
        }

        private void txtnombrpren_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtidperac.Focus();
            }
            else
            {
            }
        }

        private void txtnomoperaci_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txttiempo.Focus();
            }
            else
            {
            }
        }

        private void txttiempo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if (e.KeyChar == 13)
            {
                txtcantidad.Focus();
            }
            else
            {

            }
        }

        private void txttotal_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (e.KeyChar == 13)
            {
                txtestado.Focus();
            }
            else
            {

            }
        }

        private void txtestado_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (e.KeyChar == 13)
            {
                txthoras.Focus();
            }
            else
            {

            }
        }

        private void rtxtdescr_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (e.KeyChar == 13)
            {
                textBox5.Focus();
            }
            else
            {

            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (e.KeyChar == 13)
            {
                textBox12.Focus();
            }
            else
            {

            }
        }

        private void txtidperac_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == 13)
            {
                txtnomoperaci.Focus();
            }
            else
            {

            }
        }

        private void txtcantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == 13)
            {
                txttotal.Focus();
            }
            else
            {

            }
        }

        private void txthoras_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (e.KeyChar == 13)
            {
                rtxtdescr.Focus();
            }
            else
            {

            }
        }

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == 13)
            {

                txtsobre.Focus();


            }
            else
            {

            }
        }

        private void textBox12_HideSelectionChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left)
            {


                textBox5.Focus();
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

        private void txtxl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left)
            {


                txtl.Focus();
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

                txt5xl.Focus();


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

                textBox51.Focus();


            }
            else
            {

            }
        }

        private void textBox51_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == 13)
            {

                button3.Focus();


            }
            else
            {

            }
        }

        private void button3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left)
            {


                textBox51.Focus();
            }
        }

        private void textBox51_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left)
            {


                txt6xl.Focus();
            }
        }

        private void txt6xl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left)
            {


                txt5xl.Focus();
            }
        }

        private void txt5xl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left)
            {


                txt4xl.Focus();
            }
        }

        private void txt4xl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left)
            {


                txt3xl.Focus();
            }
        }

        private void txt3xl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left)
            {


                txtxxl.Focus();
            }
        }

        private void txtxxl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left)
            {


                txtxl.Focus();
            }
        }

        private void txtl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left)
            {


                txtm.Focus();
            }
        }

        private void txtm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left)
            {


                txts.Focus();
            }
        }

        private void txts_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left)
            {


                txtxs.Focus();
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

        private void txtxs_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left)
            {


                txtsobre.Focus();
            }
        }

        private void txtsobre_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyData == Keys.Left)
            {


                textBox12.Focus();
            }
        }

        private void txtsobre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
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

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyData == Keys.Left)
            {


                rtxtdescr.Focus();
            }
        }

        private void rtxtdescr_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyData == Keys.Left)
            {


                txthoras.Focus();
            }
        }

        private void txthoras_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyData == Keys.Left)
            {


                txtestado.Focus();
            }
        }

        private void txtestado_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyData == Keys.Left)
            {


                txttotal.Focus();
            }
        }

        private void txttotal_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyData == Keys.Left)
            {


                txtcantidad.Focus();
            }
        }

        private void txtcantidad_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyData == Keys.Left)
            {


                txttiempo.Focus();
            }
        }

        private void txttiempo_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyData == Keys.Left)
            {


                txtnomoperaci.Focus();
            }
        }

        private void txtnomoperaci_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyData == Keys.Left)
            {


                txtidperac.Focus();
            }
        }

        private void txtidperac_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyData == Keys.Left)
            {


                txtnombrpren.Focus();
            }
        }

        private void txtnombrpren_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyData == Keys.Left)
            {


                txtop.Focus();
            }
        }

        private void txtop_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyData == Keys.Left)
            {


                txtcaaarg.Focus();
            }
        }

        private void txtcaaarg_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyData == Keys.Left)
            {


                txtnombre.Focus();
            }
        }

        private void txtnombre_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyData == Keys.Left)
            {


                txtcedula.Focus();
            }
        }

        private void txtsobre_Validating(object sender, CancelEventArgs e)
        {
            if (txtsobre.Text.Trim() == String.Empty)
            {
                errorProvider17.SetError(txtsobre, "Ingrese un valor ");
                button3.Enabled = false;

            }
            else
            {
                // button3.Enabled = true;

                errorProvider17.Clear();
            }
        }

        private void txtxs_Validating(object sender, CancelEventArgs e)
        {
            if (txtxs.Text.Trim() == String.Empty)
            {
                errorProvider18.SetError(txtxs, "Ingrese un valor ");
                button3.Enabled = false;

            }
            else
            {
                // button3.Enabled = true;

                errorProvider18.Clear();
            }
        }

        private void txts_Validating(object sender, CancelEventArgs e)
        {
            if (txts.Text.Trim() == String.Empty)
            {
                errorProvider19.SetError(txts, "Ingrese un valor ");
                button3.Enabled = false;

            }
            else
            {
                // button3.Enabled = true;

                errorProvider19.Clear();
            }
        }

        private void txtm_Validating(object sender, CancelEventArgs e)
        {
            if (txtm.Text.Trim() == String.Empty)
            {
                errorProvider20.SetError(txtm, "Ingrese un valor ");
                button3.Enabled = false;

            }
            else
            {
                // button3.Enabled = true;

                errorProvider20.Clear();
            }
        }

        private void txtl_Validating(object sender, CancelEventArgs e)
        {
            if (txtl.Text.Trim() == String.Empty)
            {
                errorProvider21.SetError(txtl, "Ingrese un valor ");
                button3.Enabled = false;

            }
            else
            {
                // button3.Enabled = true;

                errorProvider21.Clear();
            }
        }

        private void txtxl_Validating(object sender, CancelEventArgs e)
        {
            if (txtxl.Text.Trim() == String.Empty)
            {
                errorProvider21.SetError(txtxl, "Ingrese un valor ");
                button3.Enabled = false;

            }
            else
            {
                // button3.Enabled = true;

                errorProvider21.Clear();
            }
        }

        private void txtxxl_Validating(object sender, CancelEventArgs e)
        {
            if (txtxxl.Text.Trim() == String.Empty)
            {
                errorProvider22.SetError(txtxxl, "Ingrese un valor ");
                button3.Enabled = false;

            }
            else
            {
                // button3.Enabled = true;

                errorProvider22.Clear();
            }
        }

        private void txt3xl_Validating(object sender, CancelEventArgs e)
        {
            if (txt3xl.Text.Trim() == String.Empty)
            {
                errorProvider23.SetError(txt3xl, "Ingrese un valor ");
                button3.Enabled = false;

            }
            else
            {
                // button3.Enabled = true;

                errorProvider23.Clear();
            }
        }

        private void txt4xl_Validating(object sender, CancelEventArgs e)
        {
            if (txt4xl.Text.Trim() == String.Empty)
            {
                errorProvider24.SetError(txt4xl, "Ingrese un valor ");
                button3.Enabled = false;

            }
            else
            {
                // button3.Enabled = true;

                errorProvider24.Clear();
            }
        }

        private void txt5xl_Validating(object sender, CancelEventArgs e)
        {
            if (txt5xl.Text.Trim() == String.Empty)
            {
                errorProvider25.SetError(txt5xl, "Ingrese un valor ");
                button3.Enabled = false;

            }
            else
            {
                // button3.Enabled = true;

                errorProvider25.Clear();
            }
        }

        private void txt6xl_Validating(object sender, CancelEventArgs e)
        {
            if (txt6xl.Text.Trim() == String.Empty)
            {
                errorProvider26.SetError(txt6xl, "Ingrese un valor ");
                button3.Enabled = false;

            }
            else
            {
                // button3.Enabled = true;

                errorProvider26.Clear();
            }
        }

        private void txt6xl_TextChanged(object sender, EventArgs e)
        {
            validarr();
        }

        private void txt5xl_TextChanged(object sender, EventArgs e)
        {
            validarr();
        }

        private void txt4xl_TextChanged(object sender, EventArgs e)
        {
            validarr();
        }

        private void txt3xl_TextChanged(object sender, EventArgs e)
        {
            validarr();
        }

        private void txtxl_TextChanged(object sender, EventArgs e)
        {
            validarr();
        }

        private void txtl_TextChanged(object sender, EventArgs e)
        {
            validarr();
        }

        private void txtm_TextChanged(object sender, EventArgs e)
        {
            validarr();
        }

        private void txtxs_TextChanged(object sender, EventArgs e)
        {
            validarr();
        }

        private void txtsobre_TextChanged(object sender, EventArgs e)
        {
            validarr();
        }

        private void txtxxl_TextChanged(object sender, EventArgs e)
        {
            validarr();
        }

        private void textBox53_TextChanged(object sender, EventArgs e)
        {
            validar3();
        }

        private void textBox53_Validating(object sender, CancelEventArgs e)
        {
            if (textBox53.Text.Trim() == String.Empty)
            {
                errorProvider28.SetError(textBox53, "Ingrese minimo 3 caracteres ");
                button28.Enabled = false;

            }
            else
            {
                // button3.Enabled = true;

                errorProvider28.Clear();
            }
        }

        private void button1_TextChanged(object sender, EventArgs e)
        {
            validarr();
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            validar2();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void textBox55_Validating(object sender, CancelEventArgs e)
        {
            if (textBox55.Text.Trim() == String.Empty)
            {
                errorProvider29.SetError(textBox55, "Ingrese minimo 3 caracteres ");
                button28.Enabled = false;

            }
            else
            {
                // button3.Enabled = true;

                errorProvider28.Clear();
            }
        }

        private void textBox55_TextChanged(object sender, EventArgs e)
        {
            validar3();
        }

        private void textBox53_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == 13)
            {

                textBox55.Focus();


            }
            else
            {

            }
        }

        private void textBox55_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == 13)
            {

                button28.Focus();


            }
            else
            {

            }
        }

        private void textBox55_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left)
            {


                textBox53.Focus();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show(" ¿ Está seguro que desea guardar el precio del minuto ?", "GUARDAR", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {


                F.Valor1 = Convert.ToInt32(textBox60.Text);
                F.Valor2 = Convert.ToInt32(txt1p.Text);
                F.Valor3 = Convert.ToInt32(txt2p.Text);
                F.Valor4 = Convert.ToInt32(txt3p.Text);
                F.Valor5 = Convert.ToInt32(txt4p.Text);
                F.Valor6 = Convert.ToInt32(txt5p.Text);
                F.Valor7 = Convert.ToInt32(txt6p.Text);
                F.Valor8 = Convert.ToInt32(txtim.Text);
                F.Valor9 = Convert.ToInt32(txtfes.Text);

                MessageBox.Show(F.Actualivalidacion(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listavalida();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(" El número de registro ya existe  ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                 MessageBox.Show(ex.Message);
            }
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
                    txt1p.Text = row[1].ToString();
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
        private void limpiarvalida()
        {

           
            txt1p.Text = "";
            txt2p.Text = "";
            txt3p.Text = "";
            txt4p.Text = "";
            txt5p.Text = "";
            txt6p.Text = "";
            txtim.Text = "";
            txtfes.Text = "";
        }

        private void textBox10_Validating(object sender, CancelEventArgs e)
        {
            if (txt1p.Text.Trim() == String.Empty)
            {
                errorProvider30.SetError(txt1p, "Ingrese un valor ");
                button9.Enabled = false;

            }
            else
            {
                // button3.Enabled = true;

                errorProvider30.Clear();
            }
        }

        private void textBox9_Validating(object sender, CancelEventArgs e)
        {
            if (txt2p.Text.Trim() == String.Empty)
            {
                errorProvider31.SetError(txt2p, "Ingrese un valor ");
                button9.Enabled = false;

            }
            else
            {
                // button3.Enabled = true;

                errorProvider31.Clear();
            }
        }

        private void textBox8_Validating(object sender, CancelEventArgs e)
        {
            if (txt3p.Text.Trim() == String.Empty)
            {
                errorProvider36.SetError(txt3p, "Ingrese un valor ");
                button9.Enabled = false;

            }
            else
            {
                // button3.Enabled = true;

                errorProvider36.Clear();
            }
        }

        private void textBox7_Validating(object sender, CancelEventArgs e)
        {
            if (txt4p.Text.Trim() == String.Empty)
            {
                errorProvider32.SetError(txt4p, "Ingrese un valor ");
                button9.Enabled = false;

            }
            else
            {
                // button3.Enabled = true;

                errorProvider32.Clear();
            }
        }

        private void textBox17_Validating(object sender, CancelEventArgs e)
        {
            if (txt5p.Text.Trim() == String.Empty)
            {
                errorProvider33.SetError(txt5p, "Ingrese un valor ");
                button9.Enabled = false;

            }
            else
            {
                // button3.Enabled = true;

                errorProvider33.Clear();
            }
        }

        private void textBox18_Validating(object sender, CancelEventArgs e)
        {
            if (txt6p.Text.Trim() == String.Empty)
            {
                errorProvider34.SetError(txt6p, "Ingrese un valor ");
                button9.Enabled = false;

            }
            else
            {
                // button3.Enabled = true;

                errorProvider34.Clear();
            }
        }

        private void textBox16_Validating(object sender, CancelEventArgs e)
        {
            if (txtim.Text.Trim() == String.Empty)
            {
                errorProvider35.SetError(txtim, "Ingrese un valor ");
                button9.Enabled = false;

            }
            else
            {
                // button3.Enabled = true;

                errorProvider35.Clear();
            }
        }

        private void textBox11_Validating(object sender, CancelEventArgs e)
        {
            if (txtfes.Text.Trim() == String.Empty)
            {
                errorProvider37.SetError(txtfes, "Ingrese un valor ");
                button9.Enabled = false;

            }
            else
            {
                // button3.Enabled = true;

                errorProvider37.Clear();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            limpiarvalida();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            validar5();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            validar5();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            validar5();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            validar5();
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            validar5();
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            validar5();
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            validar5();
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            validar5();
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == 13)
            {

                txt2p.Focus();


            }
            else
            {

            }
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == 13)
            {

                txt3p.Focus();


            }
            else
            {

            }
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == 13)
            {

                txt4p.Focus();


            }
            else
            {

            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == 13)
            {

                txt5p.Focus();


            }
            else
            {

            }
        }

        private void textBox17_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == 13)
            {

                txt6p.Focus();


            }
            else
            {

            }
        }

        private void textBox18_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == 13)
            {

                txtim.Focus();


            }
            else
            {

            }
        }

        private void textBox16_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == 13)
            {

                txtfes.Focus();


            }
            else
            {

            }
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == 13)
            {

                button9.Focus();


            }
            else
            {

            }
        }

        private void button3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == 13)
            {

                txt1p.Focus();


            }
            else
            {

            }
        }

        private void button9_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left)
            {


                txtfes.Focus();
            }
        }

        private void textBox11_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left)
            {


                txtim.Focus();
            }
        }

        private void textBox16_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left)
            {


                txt6p.Focus();
            }
        }

        private void textBox18_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left)
            {


                txt5p.Focus();
            }
        }

        private void textBox17_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left)
            {


                txt4p.Focus();
            }
        }

        private void textBox7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left)
            {


                txt3p.Focus();
            }
        }

        private void textBox8_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left)
            {


                txt2p.Focus();
            }
        }

        private void textBox9_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left)
            {


                txt1p.Focus();
            }
        }

        private void textBox10_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left)
            {


                button10.Focus();
            }
        }

        private void button8_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left)
            {


                txtfes.Focus();
            }
        }

        private void textBox54_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == 13)
            {

                button30.Focus();


            }
            else
            {

            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void colorazul()
        {
            for (int i = 0; i < dataGridView4.Rows.Count; i++)
            {
                int val = Int32.Parse(dataGridView6.Rows[i].Cells[28].Value.ToString());


                if (val == 2)
                {
                    dataGridView4.Rows[i].DefaultCellStyle.BackColor = Color.LimeGreen;
                    dataGridView4.ClearSelection();
                    // Cargarlistafinal();
                }
            }

           

        }
        private void colorazul2()
        {
            for (int i = 0; i < dataGridView4.Rows.Count; i++)
           {
                int val = Int32.Parse(dataGridView4.Rows[i].Cells[28].Value.ToString());


                if (val == 3)
                {
                    dataGridView4.Rows[i].DefaultCellStyle.BackColor = Color.PapayaWhip;
                    dataGridView4.ClearSelection();
                    // Cargarlistafinal();
                }
            }

          

        }
        private void colorverd()
        {
            for (int i = 0; i < dataGridView6.Rows.Count; i++)
            {
                int val = Int32.Parse(dataGridView6.Rows[i].Cells[11].Value.ToString());


                if (val == 1)
                {
                    dataGridView6.Rows[i].DefaultCellStyle.BackColor = Color.MediumSpringGreen;
                    dataGridView6.ClearSelection();
                    // Cargarlistafinal();
                }
            }



        }
        private void Verresulrepor2()
        {
            int baser = 0;
            int baser1 = 0;
            int resultado = 0;

            double total = 0;
            double totalim = 0;
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {

                total += Convert.ToDouble(row.Cells[8].Value);
                totalim += Convert.ToDouble(row.Cells[6].Value);
                row.Cells[dataGridView2.Columns[15].Index].Value = (Convert.ToDecimal(row.Cells[dataGridView2.Columns[15].Index].Value));
            }
            textBox41.Text = totalim.ToString("N");
            textBox40.Text = total.ToString("N");
            textBox39.Text = dataGridView2.RowCount.ToString();
            //   Convert.ToString(ded.ToString("00.0"));
            int sum = 0;
            for (int i = 0; i < dataGridView2.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView2.Rows[i].Cells[15].Value);
            }
            baser = Convert.ToInt32(textBox39.Text);
            baser1 = Convert.ToInt32(textBox43.Text);
            resultado = baser + baser1;
            textBox38.Text = Convert.ToString(resultado);
            textBox42.Text = sum.ToString("N");
            // textBox7.Text = sum.ToString();
        }
        private void Verresul2()
    {
        int baser = 0;
        int baser1 = 0;
        int resultado = 0;

        double total = 0;
        foreach (DataGridViewRow row in dataGridView4.Rows)
        {

            total += Convert.ToDouble(row.Cells[10].Value) * Convert.ToDouble(row.Cells[11].Value);
            row.Cells[dataGridView4.Columns[12].Index].Value = (Convert.ToDecimal(row.Cells[dataGridView4.Columns[10].Index].Value) * Convert.ToDecimal(row.Cells[dataGridView4.Columns[11].Index].Value));

            } 
        txtminutosproduccion.Text = total.ToString("N");
        textBox2.Text = dataGridView4.RowCount.ToString();
        //   Convert.ToString(ded.ToString("00.0"));
        int sum = 0;
        for (int i = 0; i < dataGridView4.Rows.Count; ++i)
        {
            sum += Convert.ToInt32(dataGridView4.Rows[i].Cells[11].Value);
        }
        textBox3.Text = sum.ToString();
            // baser = Convert.ToInt32(textBox9.Text);
            // baser1 = Convert.ToInt32(textBox5.Text);
            // resultado = baser + baser1;
            //txtiddope.Text = Convert.ToString(resultado);
           // color();
          //  colorazul();
            colorazul2();
            colorverd();

        }
    private void Verresul4()
        {
            int baser = 0;
            int baser1 = 0;
            int resultado = 0;

            double total = 0;
            double totalim = 0;
            foreach (DataGridViewRow row in dataGridView6.Rows)
            {

                total += Convert.ToDouble(row.Cells[9].Value);
                totalim += Convert.ToDouble(row.Cells[8].Value);
                row.Cells[dataGridView6.Columns[10].Index].Value = (Convert.ToDecimal(row.Cells[dataGridView6.Columns[10].Index].Value));
            }
            textBox1.Text = totalim.ToString("N");
            textBox15.Text = total.ToString("N");
            txtminutosimproductivos.Text = dataGridView6.RowCount.ToString();
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
            txttotalminutos.Text = sum.ToString("N");
            // textBox7.Text = sum.ToString();
            colorverd();
            dataGridView6.ClearSelection();
            {
                button20.Enabled = false;
            }
            if (dataGridView6.Rows.Count > 0)
            {
                button20.Enabled = true;
            }
          
        }
        private void Verresul3()
        {
            int baser = 0;
            int baser1 = 0;
            int resultado = 0;

            double total = 0;
            double totalim = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                total += Convert.ToDouble(row.Cells[8].Value);
                totalim += Convert.ToDouble(row.Cells[6].Value);
                row.Cells[dataGridView1.Columns[15].Index].Value = (Convert.ToDecimal(row.Cells[dataGridView1.Columns[15].Index].Value));
            }
            textBox21.Text = totalim.ToString("N");
            textBox24.Text = total.ToString("N");
            textBox20.Text = dataGridView1.RowCount.ToString();
            //   Convert.ToString(ded.ToString("00.0"));
            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[15].Value);
            }
            baser = Convert.ToInt32(textBox20.Text);
            baser1 = Convert.ToInt32(textBox23.Text);
            resultado = baser + baser1;
            txtidre.Text = Convert.ToString(resultado);
            textBox22.Text = sum.ToString("N");
            // textBox7.Text = sum.ToString();
        }

        private void colorejemplo()
        {

            for(int i =0; i < dataGridView6.Rows.Count; i++)
            {
                int val = Int32.Parse(dataGridView6.Rows[i].Cells["Cedula"].Value.ToString());
                if (val == 4111)
                {
                    dataGridView6.Rows[i].DefaultCellStyle.BackColor = BackColor = Color.AliceBlue;
                }
            }
            
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            (dataGridView6.DataSource as DataTable).DefaultView.RowFilter = string.Format("Nombre = '{0}'", txtBuscarr.Text);

           

            dataGridView6.ClearSelection();
            {
                button20.Enabled = false;
            }
            if (dataGridView6.Rows.Count > 0)
            {
                button20.Enabled = true;
            }
            


            foreach (DataGridViewRow Row in dataGridView6.Rows)
             {
                String strFila = Row.Index.ToString();
              string Valor = Convert.ToString(Row.Cells[5].Value);

             if (Valor == this.txtBuscarr.Text)
             {
                 dataGridView6.Rows[Convert.ToInt32(strFila)].DefaultCellStyle.BackColor = Color.Green;
            Verresul4();
             }
           }
        }



        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView6.ClearSelection();
            {
                button20.Enabled = false;
            }
            if (dataGridView6.Rows.Count > 0)
            {
                button20.Enabled = true;
            }
            buscar4();
            
        }

        private void txtBuscarr_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscarr_KeyPress_1(object sender, KeyPressEventArgs e)
        {

               if (e.KeyChar == 13)
               {
                


                

                Verresul4();
            }
              else
               {
                //lista4();
                dataGridView6.ClearSelection();
                {
                    button20.Enabled = false;
                }
                if (dataGridView6.Rows.Count > 0)
                {
                    button20.Enabled = true;
                }
                
                buscar4();
                Verresul4();
            }
        }

        private void txtBuscarr_KeyUp(object sender, KeyEventArgs e)
        {


            try
            {



                DataView dv = dt2.DefaultView;
                dv.RowFilter = string.Format(" nombreple like '%{0}%'", txtBuscarr.Text);
                // dv.RowFilter = string.Format(" cargo like '%{0}%'", textBox4.Text);

                dataGridView4.DataSource = dv.ToTable();
                //timer2.Stop();
                // Cargarlistadorepor2();


                // Cargarlistado5();
                //timer4.Start();
                // dataGridView3.Rows[0].Selected = true;

             relle1();
            Verresul4();
           

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                // MessageBox.Show("Solo se admiten el valor de la OP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // dataGridView3.ClearSelection();
            }


          


        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            try
            {
                (dataGridView6.DataSource as DataTable).DefaultView.RowFilter = string.Format("Cedula = '{0}'", textBox6.Text);

                dataGridView6.ClearSelection();
                {
                    button20.Enabled = false;
                }
                if (dataGridView6.Rows.Count > 0)
               {
                    button20.Enabled = true;
                }
                Verresul4();

            }

            catch (Exception ex)
            {
               // lblverno.Text = Convert.ToString("¡Registro de ID no existe!");
            }
        }



private void label43_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            validar2();
            Operacion();
            registrrepor1();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label75_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           // 511; 2661
        }


        private void registrrepor1()
        {
            string s1, s2,s3,s4;

            s1  = Convert.ToString(nnh.ToString("0.00%"));

            textBox25.Text = Convert.ToString(s1);

            s2 = Convert.ToString(q.ToString("0"));

            textBox31.Text = Convert.ToString(s2);
           
            textBox30.Text = Convert.ToString(minu);

            textBox29.Text = Convert.ToString(xl);

            textBox28.Text = Convert.ToString(hora);

            textBox27.Text = Convert.ToString(horaim);

            textBox26.Text = Convert.ToString(xi);

            textBox33.Text = Convert.ToString(mife);

            s4 = kk.ToString("00.00");
            textBox34.Text = Convert.ToString(s4);

            textBox35.Text = Convert.ToString(e);
           s3 = d.ToString("00.00");

            textBox32.Text = Convert.ToString(s3);

            textBox36.Text = Convert.ToString(final);


        }
        private void registrrepor()
        {
            try
            {
                D.Id = Convert.ToInt32(textBox53.Text);
                D.Nombreemplea = txtnombre.Text;
                D.Cedula = Convert.ToInt32(txtcedula.Text);
                
                D.Cargo = txtcaaarg.Text;

              
              //  D.Efici = textBox25.Text;
               

                D.Valorminut = textBox31.Text;
                D.Minuingene = Convert.ToDecimal(textBox30.Text);
                D.Totalminuingene = Convert.ToDecimal(textBox29.Text);
                D.Minupresenc = Convert.ToDecimal(textBox28.Text);
                D.Minuimproduct = Convert.ToDecimal(textBox27.Text);
                D.TotalImpro = Convert.ToDecimal(textBox26.Text);
                D.Fectivo = Convert.ToDecimal(textBox33.Text);
                D.Totalfecti = Convert.ToDecimal(textBox34.Text);
                D.Reunio = Convert.ToDecimal(textBox35.Text);
                D.Totalreunion = Convert.ToDecimal(textBox32.Text);

                D.Totaltodo = Convert.ToDecimal(textBox36.Text);
                D.Fecha = dateT1.Value;
                MessageBox.Show(D.Registrefinal(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cargarlistadorepor();
                Verresul3();


                D2.Id = Convert.ToInt32(textBox55.Text);
                D2.Nombreemplea = txtnombre.Text;
                D2.Cedula = Convert.ToInt32(txtcedula.Text);

                D2.Cargo = txtcaaarg.Text;


                D2.Efici = textBox25.Text;


                D2.Valorminut = Convert.ToDecimal(textBox31.Text);
                D2.Minuingene = Convert.ToDecimal(textBox30.Text);
                D2.Totalminuingene = Convert.ToDecimal(textBox29.Text);
                D2.Minupresenc = Convert.ToDecimal(textBox28.Text);
                D2.Minuimproduct = Convert.ToDecimal(textBox27.Text);
                D2.TotalImpro = Convert.ToDecimal(textBox26.Text);
                D2.Fectivo = Convert.ToDecimal(textBox33.Text);
                D2.Totalfecti = Convert.ToDecimal(textBox34.Text);
                D2.Reunio = Convert.ToDecimal(textBox35.Text);
                D2.Totalreunion = Convert.ToDecimal(textBox32.Text);

                D2.Totaltodo = Convert.ToDecimal(textBox36.Text);
                D2.Fecha = dateT1.Value;
                MessageBox.Show(D2.Registrefinal(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cargarlistadorepor2();
                
                Verresulrepor2();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" No hay resultados de eficiencia o el número de cédula ya está registrado ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                MessageBox.Show(ex.Message);
            }
        }

        private void regisepor1()
        {
            try
            {
                D.Id = Convert.ToInt32(textBox53.Text);
                D.Nombreemplea = txtnombre.Text;
                D.Cedula = Convert.ToInt32(txtcedula.Text);

                D.Cargo = txtcaaarg.Text;


               // D.Efici = textBox25.Text;


                D.Valorminut = textBox31.Text;
                D.Minuingene = Convert.ToDecimal(textBox30.Text);
                D.Totalminuingene = Convert.ToDecimal(textBox29.Text);
                D.Minupresenc = Convert.ToDecimal(textBox28.Text);
                D.Minuimproduct = Convert.ToDecimal(textBox27.Text);
                D.TotalImpro = Convert.ToDecimal(textBox26.Text);
                D.Fectivo = Convert.ToDecimal(textBox33.Text);
                D.Totalfecti = Convert.ToDecimal(textBox34.Text);
                D.Reunio = Convert.ToDecimal(textBox35.Text);
                D.Totalreunion = Convert.ToDecimal(textBox32.Text);

                D.Totaltodo = Convert.ToDecimal(textBox36.Text);
                D.Fecha = dateT1.Value;
                MessageBox.Show(D.Registrefinal(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lista1();
                Verresul3();


            }
            catch (Exception ex)
            {
                MessageBox.Show(" El número de registro ya existe  ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // MessageBox.Show(ex.Message);
            }
        }
        private void txtidre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncopiar_Click(object sender, EventArgs e)
        {
            registrrepor();

        }
    }
}
