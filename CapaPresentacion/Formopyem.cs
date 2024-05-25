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

    public partial class Formopyem : Form,IOp
    {


        //variables que conectan a otras Capas
        clsopinterna O = new clsopinterna();
      

      

        clshorario ho = new clshorario();
        ClsReglasEmpleados Reglas = new ClsReglasEmpleados();
        ClsTBL_EMPLEADOS TblAtri = new ClsTBL_EMPLEADOS();

        clsOp vo = new clsOp();
        public Iopfinal contratoop { get; set; }
        public Iopfinal contrato1op { get; set; }
        public Iopfinal contrato2op { get; set; }
        public Iopfinal contrato3op { get; set; }
        public Iopfinal contrato4op { get; set; }
        public Iopfinal contrato5op { get; set; }
        public Iopfinal contrato6op { get; set; }
        public Iopfinal contrato7op { get; set; }
        public Iopfinal contrato8op { get; set; }
        public Iopfinal contrato9op { get; set; }
        public Iopfinal contrato10op { get; set; }
        public Iopfinal contrato11op { get; set; }
        public Iopfinal contrato12op { get; set; }
        public Iopfinal contrato13op { get; set; }
        public Iopfinal contrato14op { get; set; }
        public Iopfinal contrato15op { get; set; }

        public Iopfinal contrato16op { get; set; }


        public Formopyem()

        {
            InitializeComponent();


        }
        double ser, resu, lo, ter, asu = 0, cant, ded, min, mmk;
        int hou, seg;
        int mini = 0, hho = 0, segg = 0;
        int asui, minutoss, segundoss;
        int minutos, hora, segundos, count, count1, ope, ret, asig;
        int Xs, S, Mm, L, Xl, Xxl, T3xl, T4xl, T5xl, T6xl, Sobremedida;

        DataTable dtm = new DataTable("prendasmodi ");


        private void listamodi()

        {

            try
            {


              //  using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["CnnORDEN"].ConnectionString))
                {
                    DataTable dt8 = new DataTable();
                    dt8 = O.Listardato1();
                    // if (cn.State == ConnectionState.Closed)
                    //  cn.Open();
                    //  using (SqlDataAdapter da = new SqlDataAdapter("select * from  prendasmodi ", cn))
                  //  O.Actualizadato1.Fill();
                    dataGridView1.DataSource = dt8;
                    DataGridViewColumn column = dataGridView1.Columns[0];
                    //  column.Visible = false;
                    dataGridView1.DefaultCellStyle.Font = new Font("Bookshelf Symbol", 7);
                    dataGridView1.RowTemplate.Height = 13;
                    dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold); // negrita en titulos
                    dataGridView1.Columns[0].HeaderText = "OP";
                    dataGridView1.Columns[0].Width = 60;
                    dataGridView1.Columns[1].HeaderText = "Prenda";
                    dataGridView1.Columns[1].Width = 232;
                    dataGridView1.Columns[2].HeaderText = "Descripción";
                    dataGridView1.Columns[2].Width = 110;
                    dataGridView1.Columns[3].HeaderText = "Categoria";
                    dataGridView1.Columns[3].Width = 85;
                    dataGridView1.Columns[4].HeaderText = "Tiempo";
                    dataGridView1.Columns[4].Width = 60;
                    dataGridView1.Columns[5].HeaderText = "Cantidad";
                    dataGridView1.Columns[5].Width = 80;
                    dataGridView1.Columns[6].HeaderText = "Total";
                    dataGridView1.Columns[6].Width = 80;
                    dataGridView1.Columns[7].HeaderText = "Sobremedida";
                    dataGridView1.Columns[7].Width = 82;
                    dataGridView1.Columns[8].HeaderText = "XS";
                    dataGridView1.Columns[8].Width = 30;
                    dataGridView1.Columns[9].HeaderText = "S";
                    dataGridView1.Columns[9].Width = 30;
                    dataGridView1.Columns[10].HeaderText = "M";
                    dataGridView1.Columns[10].Width = 30;
                    dataGridView1.Columns[11].HeaderText = "L";
                    dataGridView1.Columns[11].Width = 30;
                    dataGridView1.Columns[12].HeaderText = "XL";
                    dataGridView1.Columns[12].Width = 30;
                    dataGridView1.Columns[13].HeaderText = "XXL";
                    dataGridView1.Columns[13].Width = 30;
                    dataGridView1.Columns[14].HeaderText = "3XL";
                    dataGridView1.Columns[14].Width = 30;
                    dataGridView1.Columns[15].HeaderText = "4XL";
                    dataGridView1.Columns[15].Width = 30;
                    dataGridView1.Columns[16].HeaderText = "5XL";
                    dataGridView1.Columns[16].Width = 30;
                    dataGridView1.Columns[17].HeaderText = "6XL";
                    dataGridView1.Columns[17].Width = 30;

                    

                    FreezeBand(dataGridView1.Columns[0]);
                    FreezeBand1(dataGridView1.Columns[1]);
                    


                 
                    //  Verresul4();
                    // dataGridView1.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
                    // color();
                    // colorazul();
                    // Verresul2();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataGridView1.ClearSelection();
            //color();

            //Verresul();

        }
        private void Cargarlistadomodifi()

        {
            try
            {


               
                        DataTable dt1 = new DataTable();
                         dt1 = O.Listardato1();
                         
                          dataGridView1.DataSource = dt1;
                        dataGridView1.RowTemplate.Height = 13;

                        
                        dataGridView1.RowTemplate.Height = 13;

                        Verresul2();

                    
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataGridView1.ClearSelection();
            //Verresul();

        }
      
        private void Cargarlistado2()
        {


            DataTable dt = new DataTable();
            dt = O.ListadoOpinter();
            try
            {



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
          
       
        private void Cargarlistafinal7()

        {

            DataTable dt = new DataTable();
            dt = O.Listadopyem();
            try
            {
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          


        }
       
        private void label19_Click(object sender, EventArgs e)
        {

        }

        public void Limpiar1()
        {
            label61.Text = "";
            label64.Text = "";
            textBoxti.Clear();
            textBoxnom.Clear();
            txtcategoria.Clear();
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
            txtcantidadop.Clear();
            rtxtdescr.Clear();
            button9.Focus();
            //dateTimePicker1.Value = DateTime.Now;

        }
        private void button9_Click(object sender, EventArgs e)
        {
            Frmop hijo = new Frmop();
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

            hijo.ShowDialog();

        }
        private void DrawGroupBox4(GroupBox box, Graphics g, Color textColor, Color borderColor)
        {
            if (box != null)
            {
                Brush textBrush = new SolidBrush(textColor);
                Brush borderBrush = new SolidBrush(borderColor);
                Pen borderPen = new Pen(borderBrush);
                SizeF strSize = g.MeasureString(box.Text, box.Font);
                Rectangle rect = new Rectangle(box.ClientRectangle.X,
                                               box.ClientRectangle.Y + (int)(strSize.Height / 2),
                                               box.ClientRectangle.Width - 1,
                                               box.ClientRectangle.Height - (int)(strSize.Height / 2) - 1);

                // Clear text and border
                g.Clear(this.BackColor);

                // Draw text
                g.DrawString(box.Text, box.Font, textBrush, box.Padding.Left, 0);

                // Drawing Border
                //Left
                g.DrawLine(borderPen, rect.Location, new Point(rect.X, rect.Y + rect.Height));
                //Right
                g.DrawLine(borderPen, new Point(rect.X + rect.Width, rect.Y), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                //Bottom
                g.DrawLine(borderPen, new Point(rect.X, rect.Y + rect.Height), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                //Top1
                g.DrawLine(borderPen, new Point(rect.X, rect.Y), new Point(rect.X + box.Padding.Left, rect.Y));
                //Top2
                g.DrawLine(borderPen, new Point(rect.X + box.Padding.Left + (int)(strSize.Width), rect.Y), new Point(rect.X + rect.Width, rect.Y));
            }
        }

        private void groupBox4_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            DrawGroupBox4(box, e.Graphics, Color.SteelBlue, Color.SteelBlue);
        }

        private void groupBox2_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            DrawGroupBox2(box, e.Graphics, Color.SteelBlue, Color.SteelBlue);
        }
        private void DrawGroupBox2(GroupBox box, Graphics g, Color textColor, Color borderColor)
        {
            if (box != null)
            {
                Brush textBrush = new SolidBrush(textColor);
                Brush borderBrush = new SolidBrush(borderColor);
                Pen borderPen = new Pen(borderBrush);
                SizeF strSize = g.MeasureString(box.Text, box.Font);
                Rectangle rect = new Rectangle(box.ClientRectangle.X,
                                               box.ClientRectangle.Y + (int)(strSize.Height / 2),
                                               box.ClientRectangle.Width - 1,
                                               box.ClientRectangle.Height - (int)(strSize.Height / 2) - 1);

                // Clear text and border
                g.Clear(this.BackColor);

                // Draw text
                g.DrawString(box.Text, box.Font, textBrush, box.Padding.Left, 0);

                // Drawing Border
                //Left
                g.DrawLine(borderPen, rect.Location, new Point(rect.X, rect.Y + rect.Height));
                //Right
                g.DrawLine(borderPen, new Point(rect.X + rect.Width, rect.Y), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                //Bottom
                g.DrawLine(borderPen, new Point(rect.X, rect.Y + rect.Height), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                //Top1
                g.DrawLine(borderPen, new Point(rect.X, rect.Y), new Point(rect.X + box.Padding.Left, rect.Y));
                //Top2
                g.DrawLine(borderPen, new Point(rect.X + box.Padding.Left + (int)(strSize.Width), rect.Y), new Point(rect.X + rect.Width, rect.Y));
            }
        }

        private void groupBox5_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            DrawGroupBox5(box, e.Graphics, Color.SteelBlue, Color.SteelBlue);
        }
        private void DrawGroupBox5(GroupBox box, Graphics g, Color textColor, Color borderColor)
        {
            if (box != null)
            {
                Brush textBrush = new SolidBrush(textColor);
                Brush borderBrush = new SolidBrush(borderColor);
                Pen borderPen = new Pen(borderBrush);
                SizeF strSize = g.MeasureString(box.Text, box.Font);
                Rectangle rect = new Rectangle(box.ClientRectangle.X,
                                               box.ClientRectangle.Y + (int)(strSize.Height / 2),
                                               box.ClientRectangle.Width - 1,
                                               box.ClientRectangle.Height - (int)(strSize.Height / 2) - 1);

                // Clear text and border
                g.Clear(this.BackColor);

                // Draw text
                g.DrawString(box.Text, box.Font, textBrush, box.Padding.Left, 0);

                // Drawing Border
                //Left
                g.DrawLine(borderPen, rect.Location, new Point(rect.X, rect.Y + rect.Height));
                //Right
                g.DrawLine(borderPen, new Point(rect.X + rect.Width, rect.Y), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                //Bottom
                g.DrawLine(borderPen, new Point(rect.X, rect.Y + rect.Height), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                //Top1
                g.DrawLine(borderPen, new Point(rect.X, rect.Y), new Point(rect.X + box.Padding.Left, rect.Y));
                //Top2
                g.DrawLine(borderPen, new Point(rect.X + box.Padding.Left + (int)(strSize.Width), rect.Y), new Point(rect.X + rect.Width, rect.Y));
            }
        }
        private void DrawGroupBox7(GroupBox box, Graphics g, Color textColor, Color borderColor)
        {
            if (box != null)
            {
                Brush textBrush = new SolidBrush(textColor);
                Brush borderBrush = new SolidBrush(borderColor);
                Pen borderPen = new Pen(borderBrush);
                SizeF strSize = g.MeasureString(box.Text, box.Font);
                Rectangle rect = new Rectangle(box.ClientRectangle.X,
                                               box.ClientRectangle.Y + (int)(strSize.Height / 2),
                                               box.ClientRectangle.Width - 1,
                                               box.ClientRectangle.Height - (int)(strSize.Height / 2) - 1);

                // Clear text and border
                g.Clear(this.BackColor);

                // Draw text
                g.DrawString(box.Text, box.Font, textBrush, box.Padding.Left, 0);

                // Drawing Border
                //Left
                g.DrawLine(borderPen, rect.Location, new Point(rect.X, rect.Y + rect.Height));
                //Right
                g.DrawLine(borderPen, new Point(rect.X + rect.Width, rect.Y), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                //Bottom
                g.DrawLine(borderPen, new Point(rect.X, rect.Y + rect.Height), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                //Top1
                g.DrawLine(borderPen, new Point(rect.X, rect.Y), new Point(rect.X + box.Padding.Left, rect.Y));
                //Top2
                g.DrawLine(borderPen, new Point(rect.X + box.Padding.Left + (int)(strSize.Width), rect.Y), new Point(rect.X + rect.Width, rect.Y));
            }
        }

        private void groupBox7_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            DrawGroupBox5(box, e.Graphics, Color.DarkSeaGreen, Color.DarkSeaGreen);
        }

        private void groupBox8_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            DrawGroupBox5(box, e.Graphics, Color.DarkSeaGreen, Color.DarkSeaGreen);
        }

        private void button13_Click(object sender, EventArgs e)
        {

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
                k1 = (Math.Round(cant1 / (1 * 60)));
                hh12.Text = Convert.ToString(k1.ToString("N"));
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
                   k1 = (Math.Round(cant1 / (1 * 60) )- 1);
                    hh12.Text = Convert.ToString(k1.ToString("0"));
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
                    hh12.Text = Convert.ToString(k1.ToString("N"));

                }
            }

            else
            {

                mm1.Text = Convert.ToString(cant1);
                hh12.Text = Convert.ToString(0);


            }
        }
        private void Algoritmo212()
        {

            double ser2, resu2, lo2, ter2, cant2, ded2, min2, mmk2, mmk3;
            double asu2 = 0;
            int asui2;

            mmk2 = Convert.ToDouble(textBoxti.Text);
            mmk3 = Convert.ToDouble(teaxtcantidadop.Text);

            min2 = Convert.ToDouble(mmk2 * mmk3);

            label95.Text = Convert.ToString(min2);

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
                textBox19.Text = Convert.ToString("Hh : " + nstrin + "    Mm : " + nstrin1);
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
                textBox19.Text = Convert.ToString(nstrin);






            }
        }
        private void button14_Click(object sender, EventArgs e)
        {
           


        }

        private void button12_Click(object sender, EventArgs e)
        {
            
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

        private void teaxtm_Validated(object sender, EventArgs e)
        {
          
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
                btnregistraopinterno.Enabled = true;
                btnregistraopinterno.BackColor = Color.Gray;
                errorProvider4.Clear();
                Algoritmo2();
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

        private void teaxt6xl_Validating(object sender, CancelEventArgs e)
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

        private void teaxt5xl_Validating(object sender, CancelEventArgs e)
        {
            if (teaxt6xl.Text.Trim() == String.Empty)
            {
                errorProvider11.SetError(teaxt6xl, "Ingrese un valor ");
                btnregistraopinterno.Enabled = false;
                btnregistraopinterno.BackColor = Color.Gray;

            }
            else
            {
                btnregistraopinterno.Enabled = true;
                btnregistraopinterno.BackColor = Color.Gray;
                errorProvider11.Clear();
            }
        }
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
                Algoritmo2();
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message);
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
                T5xl = Convert.ToInt32(teaxt6xl.Text);
                T6xl = Convert.ToInt32(teaxt5xl.Text);

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

        private void teaxt6xl_MouseLeave(object sender, EventArgs e)
        {
            Sumains2();
        }

        private void teaxt5xl_MouseLeave(object sender, EventArgs e)
        {
            Sumains2();
        }

        private void teaxtcantidadop_MouseLeave(object sender, EventArgs e)
        {
            Sumains2();
        }

        int canti, sobre, xxs, ss, mmm, lll, xlll, xxxx, xq, xw, xe, xr;

        

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

      

        private void textBoxor_KeyPress(object sender, KeyPressEventArgs e)
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
               
                label61.Text = "";
                label64.Text = "";
                textBoxti.Clear();
                textBoxnom.Clear();
                txtcategoria.Clear();
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
                txtcantidadop.Clear();
                rtxtdescr.Clear();
                textBoxor.Focus();
                // CargarListado11();
                //lista4();
                // buscar4();
            }
        }

        private void textBoxor_TextChanged(object sender, EventArgs e)
        {
            if (textBoxor.Text != string.Empty)
            {
                button9.Enabled = true;
            }
            else
            {
                button9.Enabled = false;
            }
        }


        private void timer4_Tick(object sender, EventArgs e)
        {
            //Cargarlistado5();

           
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }
        ToolStripMenuItem toolStripItem1 = new ToolStripMenuItem();

        private void AddContextMenu()
        {
           // toolStripItem1.Text = "Redden";
           // toolStripItem1.Click += new EventHandler(toolStripItem1_Click);
           // ContextMenuStrip strip = new ContextMenuStrip();
           // foreach (DataGridViewColumn column in dataGridView3.Columns)
           // {

           //     column.ContextMenuStrip = strip;
           //     column.ContextMenuStrip.Items.Add(toolStripItem1);
           // }


        }
        private DataGridViewCellEventArgs mouseLocation;

        private void toolStripItem1_Click(object sender, EventArgs args)
        {
           // dataGridView3.Rows[mouseLocation.RowIndex]
           //     .Cells[mouseLocation.ColumnIndex].Style.BackColor
              //  = Color.Red;
        }
        string registroSeleccionado;
        string RegistroSeleccionado
        {
            get { return registroSeleccionado; }
            set { registroSeleccionado = value; }
        }
        private void dataGridView3_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }




        private void dataGridView3_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            mouseLocation = e;
        }

    
        

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView7_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
           
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            Sumains();

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

        private void textl_MouseLeave(object sender, EventArgs e)
        {
            Sumains();
        }

        private void textxl_MouseLeave(object sender, EventArgs e)
        {
            Sumains();
        }

        private void textxxl_MouseLeave(object sender, EventArgs e)
        {
            Sumains();
        }

        private void text3xl_MouseLeave(object sender, EventArgs e)
        {
            Sumains();
          
        }

        private void text4xl_MouseLeave(object sender, EventArgs e)
        {
            Sumains();
        }

        private void text5xl_MouseLeave(object sender, EventArgs e)
        {
            Sumains();
        }

        private void text6xl_MouseLeave(object sender, EventArgs e)
        {
            Sumains();
        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void textBox20_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {


                string f;

                f = Convert.ToString("  SELECT  * FROM prendasmodi WHERE nombrepre LIKE '" + textBox20.Text + "%'");
                textBox14.Text = Convert.ToString(f);
                DataTable dtm1 = new DataTable("prendasmodi");
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

                    Verresul2();

                }
            }
            catch (Exception ex)
            {
              
                // MessageBox.Show(ex.Message);
                //MessageBox.Show("Solo se admiten el valor de la OP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // label2.Text = "REGISTRO NO ENCONTRADO";
            }

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {
            Verresul2();
        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {
            try
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("Op = '{0}'", textBox22.Text);
               // Cargarlistadomodifi();
                Verresul2();

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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox21.Text = dataGridView1.CurrentCell.Value.ToString();
        }

        private void groupBox15_Enter(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            try
            {
                O.OP = Convert.ToInt32(textBoxor.Text);
               // O.Opp1 = Convert.ToInt32(txtop.Text);
                O.Tiempomodi = Convert.ToDecimal(textBoxti.Text);
                O.Nombrep = textBoxnom.Text;
              //  O.Nombreoperpp = txtnombrpren.Text;
                O.Descripcionmodi = rtxtdescr.Text;
                O.Categoriamodi = txtcategoria.Text;
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


                //canti=  Sobremedida + Xs + S + Mm + L + Xl + Xxl + T3xl + T4xl + T5xl + T6xl;
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
                    MessageBox.Show("El número asignado excede la cantidad original", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    // txtasignacion.Text = Convert.ToString(fal);
                    // rest = orig - fal;
                    //txtrestante.Text = Convert.ToString(rest);
                    //txtcantidadori.Text = Convert.ToString(rest);

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


                    O.OP = Convert.ToInt32(textBoxor.Text);

                    O.Sobremedida = Convert.ToInt32(rest);

                    O.Xs = Convert.ToInt32(rest1);
                    O.S = Convert.ToInt32(rest2);
                    O.Mm = Convert.ToInt32(rest3);
                    O.L = Convert.ToInt32(res4);
                    O.Xl = Convert.ToInt32(rest5);
                    O.Xxl = Convert.ToInt32(rest6);
                    O.T3xl = Convert.ToInt32(rest7);
                    O.T4xl = Convert.ToInt32(rest8);
                    O.T5xl = Convert.ToInt32(rest9);
                    O.T6xl = Convert.ToInt32(rest10);



                    Algoritmo2();
                    MessageBox.Show(O.Actualizaropinter(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Cargarlistadomodifi();
                   // DataTable dt8 = new DataTable();
                   // dt8 = O.Actualizadato1();
                   
                    //dataGridView1.DataSource = dt8;
                    listamodi();
                    //  teaxtcantidadop.Text = O.sumaop().ToString();
                    canti = Sobremedida + Xs + S + Mm + L + Xl + Xxl + T3xl + T4xl + T5xl + T6xl;
                    teaxtcantidadop.Text = Convert.ToString(canti);

                    DataTable dti = new DataTable();
                    DataRow rowi;
                    O.OP = Convert.ToInt32(textBoxor.Text);
                    dti = O.Buscarnopinter(O.OP);
                    if (dti.Rows.Count == 1)
                    {
                        rowi = dti.Rows[0];
                        // lblinter.Text = rowi[0].ToString();
                        txtcaactu.Text = rowi[5].ToString();


                      //  MessageBox.Show("Registro Encontrado Ok!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                    else
                    {
                      //  MessageBox.Show("Registro de Orden de produccion no Existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //te.Limpiar();
                    }
                    //agregando datos
                    // ListViewItem item = new ListViewItem();
                    // item = Histo.Items.Add(lblinter.Text);
                    // item.SubItems.Add(textBoxnom.Text);
                    //item.SubItems.Add(txtcaactu.Text);///cantida restante
                    //item.SubItems.Add(txtcantidadop.Text);//cantida originaltextcantidadop

                    // item.SubItems.Add(teaxtcantidadop.Text);//cantidan quitada
                    // item.SubItems.Add(label70.Text);
                    //listview
                    contratoop.Valor31op(textBoxor.Text);
                    contrato1op.Valor32op(textBoxti.Text);
                    contrato2op.Valor33op(textBoxnom.Text);
                    contrato3op.Valor34op(txtcategoria.Text);
                    contrato4op.Valor35op(textBox19.Text);
                    contrato5op.Valor36op(teaxtsobre.Text);
                    contrato6op.Valor37op(teaxtxs.Text);
                    contrato7op.Valor38op(teaxts.Text);
                    contrato8op.Valor39op(teaxtm.Text);
                    contrato9op.Valor40op(teaxtl.Text);
                    contrato10op.Valor41op(teaxtxl.Text);
                    contrato11op.Valor42op(teaxtxxl.Text);
                    contrato12op.Valor43op(teaxt3xl.Text);
                    contrato13op.Valor44op(teaxt4xl.Text);
                    contrato14op.Valor45op(teaxt5xl.Text);
                    contrato15op.Valor46op(teaxt6xl.Text);
                    contrato16op.Valor47op(teaxtcantidadop.Text);


                    this.Hide();
                }

                //Limpiar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Campos Vacíos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

               // MessageBox.Show(ex.Message);
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            try
            {
            O.OP = Convert.ToInt32(textBoxor.Text);
            O.Sobremedida = Convert.ToInt32(textsobre.Text);
            O.Xs = Convert.ToInt32(textxs.Text);
            O.S = Convert.ToInt32(texts.Text);
            O.Mm = Convert.ToInt32(textm.Text);
            O.L = Convert.ToInt32(textl.Text);
            O.Xl = Convert.ToInt32(textxl.Text);
            O.Xxl = Convert.ToInt32(textxxl.Text);
            O.T3xl = Convert.ToInt32(text3xl.Text);
            O.T4xl = Convert.ToInt32(text4xl.Text);
            O.T5xl = Convert.ToInt32(text5xl.Text);
            O.T6xl = Convert.ToInt32(text6xl.Text);


            MessageBox.Show(O.Actualizaropinter(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Cargarlistadomodifi();
            //  teaxtcantidadop.Text = O.sumaop().ToString();
            canti = Sobremedida + Xs + S + Mm + L + Xl + Xxl + T3xl + T4xl + T5xl + T6xl;
            textcantidadop.Text = Convert.ToString(O.Sumaop);
            ListViewItem item = new ListViewItem();
            //item = Histo.Items.Add(textBoxor.Text);
           // item.SubItems.Add(textBoxnom.Text);
           // item.SubItems.Add(textcantidadop.Text);///cantida restante
           // item.SubItems.Add(txtcantidadop.Text);//cantida originaltextcantidadop
            
          //  item.SubItems.Add(teaxtcantidadop.Text);//cantidan quitada
           // item.SubItems.Add(label69.Text);
            label86.Visible = false;
            if (label86.Visible == false)
            {
                btnregistraopinterno.Enabled = false;
            }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("  Unicamente seleccionar el número de id  ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

               // MessageBox.Show(ex.Message);
            }

        }
        private void button21_Click(object sender, EventArgs e)
        {
            
            try
            {

                //  re.Op = Convert.ToInt32(txtseletop.Text);
                if (MessageBox.Show("¿ Desea eliminar todos los registros ?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    MessageBox.Show(O.Eliminaropimoditotal(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                    Cargarlistadomodifi();
                    textBox21.Clear();
                    dataGridView1.ClearSelection();
                    {
                        button19.Enabled = false;
                    }
                    if (dataGridView1.Rows.Count > 0)
                    {
                        button19.Enabled = true;
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

            dataGridView1.ClearSelection();
            
        }

    



        

        private void validar1()
        {

            if (

            textBoxor.Text != string.Empty &
           textBoxti.Text != string.Empty &
           textBoxnom.Text != string.Empty &
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
       

        private void groupBox4_Enter(object sender, EventArgs e)
        {

            
        }

      

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
           // dataGridView1.Rows[0].Selected = false;
        }

        private void groupBox15_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void dataGridView1_Leave(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {             
                try
                {
                    int a = 0;
                  // DataGridViewImageCell cell = (DataGridViewImageCell)
                   // dataGridView1.Rows[].Cells[e.ColumnIndex];

                   textBox21.Text = dataGridView1.CurrentCell.Value.ToString();
                    a = Convert.ToInt32(textBox21.Text);

                   // this.dataGridView1.CurrentCell = this.dataGridView1[1,0];
                  
                    O.OP = Convert.ToInt32(textBox21.Text);
                    //  re.Op = Convert.ToInt32(txtseletop.Text);
                    if (MessageBox.Show(" ¿ Está seguro de eliminar el  N° de OP " + a + " ?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {

                        MessageBox.Show(O.Eliminaropmodi(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Cargarlistadomodifi();
                        textBox21.Clear();
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
                    MessageBox.Show("  Unicamente seleccionar el número de   ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                  //  MessageBox.Show(ex.Message);
                }
            }

        }

        private void dataGridView1_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
           
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {


            // if (e.RowIndex == -1)
            //  {
            //      Color c1 = Color.White;
            //     Color c2 = Color.White;
            //     Color c3 = Color.Black;

            //    LinearGradientBrush br = new LinearGradientBrush(e.CellBounds, c1, c3, 90, true);
            //   ColorBlend cb = new ColorBlend();
            //   cb.Positions = new[] { 0, (float)0.5, 1 };
            //   cb.Colors = new[] { c1, c2, c3 };
            //   br.InterpolationColors = cb;


            ///  e.Graphics.FillRectangle(br, e.CellBounds);
            //  e.PaintContent(e.ClipBounds);
            //  e.Handled = true;
            //  }
            
            dataGridView1.EnableHeadersVisualStyles = false;
            DataGridViewColumn dataGridViewColumn = dataGridView1.Columns[1];
            dataGridViewColumn.HeaderCell.Style.BackColor = Color.LightGray;
            dataGridViewColumn.HeaderCell.Style.ForeColor = Color.Black;

            Color cl = dataGridViewColumn.HeaderCell.Style.BackColor;
            //or   
            Color cl2 = dataGridView1.Columns[1].HeaderCell.Style.BackColor;

            
            DataGridViewColumn dataGridViewColumn1 = dataGridView1.Columns[0];
            dataGridViewColumn1.HeaderCell.Style.BackColor = Color.White;
            dataGridViewColumn1.HeaderCell.Style.ForeColor = Color.Black;

            Color cl1 = dataGridViewColumn.HeaderCell.Style.BackColor;
            //or   
            Color cl21 = dataGridView1.Columns[0].HeaderCell.Style.BackColor;
            
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

      

     
        private void Busquedaop3()
        {
           

        }
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
           // e.CellStyle.BackColor = Color.WhiteSmoke;
            
        }

        private void colorazul()
        {
           // for (int i = 0; i < dataGridView6.Rows.Count; i++)
           // {
           /// //    int val = Int32.Parse(dataGridView6.Rows[i].Cells[21].Value.ToString());


            //    if (val == 2)
             //   {
              //      dataGridView6.Rows[i].DefaultCellStyle.BackColor = Color.LimeGreen;
              //      dataGridView6.ClearSelection();
                    // Cargarlistafinal();
              //  }
            //}

         //   for (int i = 0; i < dataGridView3.Rows.Count; i++)
           // {
            //    int val = Int32.Parse(dataGridView3.Rows[i].Cells["Column11"].Value.ToString());


               // if (val == 2)
               // {
               //     dataGridView3.Rows[i].DefaultCellStyle.BackColor = Color.LimeGreen;
                 //   dataGridView3.ClearSelection();
                    // Cargarlistafinal();
               // }
           // }

        }
       

      

      

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void Formopyem_Scroll(object sender, ScrollEventArgs e)
        {

        }

        int rest,
                    rest1, rest2, rest3, res4, rest5, rest6, rest7, rest8, rest9, rest10, rest11;

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

        private void dataGridView1_VisibleChanged(object sender, EventArgs e)
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

        private void teaxtcantidadop_TextChanged(object sender, EventArgs e)
        {

            Algoritmo2();
           
                btnregistraopinterno.Enabled = false;
                btnregistraopinterno.BackColor = Color.Gray;

         
                btnregistraopinterno.Enabled = true;
              
                
            

        }

        private void textBox22_KeyPress(object sender, KeyPressEventArgs e)
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
                    //Cargarlistadomodifi();
                    // Verresul2();
                }
                else
                {

                    Cargarlistadomodifi();
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                // MessageBox.Show("Solo se admiten el valor de la OP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // dataGr
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1Orden_de_Produccion te = new Form1Orden_de_Produccion();

            try
            {
                DataTable dt = new DataTable();
                DataRow row;
                vo.OP = Convert.ToInt32(textBoxor.Text);
                dt = vo.Buscarnop(vo.OP);
                if (dt.Rows.Count == 1)
                {
                    row = dt.Rows[0];
                    textBoxor.Text = row[0].ToString();
                    textBoxti.Text = row[1].ToString();
                    textBoxnom.Text = row[2].ToString();
                    txtcantidadop.Text = row[3].ToString();
                    //txtcategoria.Text = row[4].ToString();
                    txtsobre.Text = row[5].ToString();
                    txtxs.Text = row[6].ToString();
                    txts.Text = row[7].ToString();
                    txtm.Text = row[8].ToString();
                    txtl.Text = row[9].ToString();
                    txtxl.Text = row[10].ToString();
                    txtxxl.Text = row[11].ToString();
                    txt3xl.Text = row[12].ToString();
                    txt4xl.Text = row[13].ToString();
                    txt5xl.Text = row[14].ToString();
                    txt6xl.Text = row[15].ToString();
                    MessageBox.Show("Registro Encontrado Ok...!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    try
                    {
                        O.OP = Convert.ToInt32(textBoxor.Text);
                        O.Nombrep = Convert.ToString(textBoxnom.Text);
                        O.Categoriamodi = Convert.ToString(txtcategoria.Text);
                        O.Tiempomodi = Convert.ToDecimal(textBoxti.Text);
                        O.Cantidad = Convert.ToInt32(txtcantidadop.Text);
                        O.Sobremedida = Convert.ToInt32(txtsobre.Text);
                        O.Tiempomodi = Convert.ToDecimal("00.00");
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

                        MessageBox.Show(O.Registrar_opmodi(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        textcantidadop.Text = O.sumaop().ToString();

                        //Limpiar();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }


                    DataTable dti = new DataTable();
                    DataRow rowi;
                    O.OP = Convert.ToInt32(textBoxor.Text);
                    dti = O.Buscarnopinter(O.OP);
                    if (dt.Rows.Count == 1)
                    {
                        rowi = dti.Rows[0];
                        lblinter.Text = rowi[0].ToString();
                        textcantidadop.Text = rowi[2].ToString();
                        //txtcategoria.Text = row[4].ToString();
                        textsobre.Text = rowi[3].ToString();
                        textxs.Text = rowi[4].ToString();
                        texts.Text = rowi[5].ToString();
                        textm.Text = rowi[6].ToString();
                        textl.Text = rowi[7].ToString();
                        textxl.Text = rowi[8].ToString();
                        textxxl.Text = rowi[9].ToString();
                        text3xl.Text = rowi[10].ToString();
                        text4xl.Text = rowi[11].ToString();
                        text5xl.Text = rowi[12].ToString();
                        text6xl.Text = rowi[13].ToString();


                        MessageBox.Show("Registro Encontrado Ok...!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }

                    else
                    {
                        MessageBox.Show("Registro de Orden de produccion no Existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        te.Limpiar();
                    }
                }
                else
                {
                    MessageBox.Show("Registro de Orden de Produccion no Existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtm_TextChanged(object sender, EventArgs e)
        {

        }


        private void label11_Click(object sender, EventArgs e)
        {

        }

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

      

        private void Formopyem_Load(object sender, EventArgs e)
        {
           
            validar1();
           
           
            //button9.Enabled = false;
           
           
            Cargarlistadomodifi();
            listamodi();
           
           
            label86.Visible = false;
         

          
          
            Verresul2();
            //Cargarlistafinal();
        
            
            button19.Enabled = false;
           

            //llenar  grilla

            //DataTable tm = t.Listadotiempotemp();
            // dtgtiemt.DataSource = tm;

            //DataTable dt = ho.Listadohorario();
            // dataGridhorario.DataSource = dt;

          
        }
       
      

        private void button5_Click(object sender, EventArgs e)
        {

            
        }
       
  
        private void Algoritmo()
        {

            double ser1, resu1, lo1, ter1, cant1, ded1, min1, mmk1;
            double asu1=0;
            int asui1;

            min1 = Convert.ToDouble(teaxtcantidadop.Text);//ingresar valor para efectuar el resultado

            label94.Text = Convert.ToString(min1);

            cant1 = Convert.ToDouble(label94.Text);
            resu1 = cant1 / 60;

            lblmmk111.Text = Convert.ToString(asu1.ToString("0"));


            if (cant1 >= 60)
            {
                lblhh1117.Text = Convert.ToString(Math.Round(cant1 / (1 * 60)));
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



                label37.Text = Convert.ToString(asu1.ToString("0"));
                string t, r;
                //label10.Text = Convert.ToString(lo);
                //label10.Text = Convert.ToString(lo.ToString("{ 0:R}"));
                if (asu1 < 0)//valor positivo
                {
                    //label9.Text = (""); lbltiempounico.Text = ("");
                    lblhh1117.Text = Convert.ToString(Math.Round(cant1 / (1 * 60))-1);
                    lblmmk111.Text = Convert.ToString(ded1.ToString("0"));
                }
                if (asu1 > 0)
                {
                    //  label13.Text = (""); label15.Text = ("");
                    lblmmk111.Text = Convert.ToString(asu1.ToString("0"));
                    lblhh1117.Text = Convert.ToString(Math.Round(cant1 / (1 * 60)));

                    t = lblhh1117.Text;

                    r = lblmmk111.Text;
                    textBox11.Text = Convert.ToString(t + "," + r);

                }
            }

            else
            {

                lblmmk111.Text = Convert.ToString(cant1);
                lblhh1117.Text = Convert.ToString(0);

            }
        }
        private void Algoritmo2()
        {
            try
            {
                double ser2, resu2, lo2, ter2, cant2, ded2, min2, mmk2, mmk3;
                double asu2 = 0;
                int asui2;

                mmk2 = Convert.ToDouble(textBoxti.Text);
                mmk3 = Convert.ToDouble(teaxtcantidadop.Text);

                min2 = Convert.ToDouble(mmk2 * mmk3);

                label95.Text = Convert.ToString(min2);

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


                    textBox19.Text = Convert.ToString(nstrin+" h "   + nstrin1+" min ");
                    //double a = Convert.ToDouble(textBox12.Text);
                    textBox14.Text = nstrin.ToString();

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
                    textBox19.Text = Convert.ToString(" min " + nstrin);


                }
            }
            catch (Exception ex)
            {

            }

        }
            private void Formopyem_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
           
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        //double sum1 = 0;
     
        private void Verresul2()
        {
           

            double total = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                total += Convert.ToDouble(row.Cells[4].Value) * Convert.ToDouble(row.Cells[5].Value);
                row.Cells[dataGridView1.Columns[6].Index].Value = (Convert.ToDecimal(row.Cells[dataGridView1.Columns[4].Index].Value) * Convert.ToDecimal(row.Cells[dataGridView1.Columns[5].Index].Value));

            }
            textBox17.Text = total.ToString("N");
            textBox2.Text = dataGridView1.RowCount.ToString();
            //   Convert.ToString(ded.ToString("00.0"));
            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);
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
        public void Valor31(string _dato31)
        {
            textBoxor.Text = _dato31;
        }

        public void Valor32(string _dato32)
        {
            textBoxti.Text = _dato32;
        }
        public void Valor33(string _dato33)
        {
            textBoxnom.Text = _dato33;
        }
        public void Valor34(string _dato34)
        {
            txtcategoria.Text = _dato34;
        }
        public void Valor35(string _dato35)
        {
            rtxtdescr.Text = _dato35;
        }
        public void Valor36(string _dato36)
        {
            txtsobre.Text = _dato36;
        }
        public void Valor37(string _dato37)
        {
            txtxs.Text = _dato37;
        }
        public void Valor38(string _dato38)
        {
            txts.Text = _dato38;
        }
        public void Valor39(string _dato39)
        {
            txtm.Text = _dato39;
        }
        public void Valor40(string _dato40)
        {
            txtl.Text = _dato40;
        }
        public void Valor41(string _dato41)
        {
            txtxl.Text = _dato41;
        }
        public void Valor42(string _dato42)
        {
            txtxxl.Text = _dato42;
        }
        public void Valor43(string _dato43)
        {
            txt3xl.Text = _dato43;
        }
        public void Valor44(string _dato44)
        {
            txt4xl.Text = _dato44;
        }
        public void Valor45(string _dato45)
        {
            txt5xl.Text = _dato45;
        }
        public void Valor46(string _dato46)
        {
            txt6xl.Text = _dato46;
        }

        public void Valor47(string _dato47)
        {
            txtcantidadop.Text = _dato47;
        }
        public void Valor48(string _dato48)
        {
            textsobre.Text = _dato48;
        }
        public void Valor49(string _dato49)
        {
            textxs.Text = _dato49;
        }

        public void Valor50(string _dato50)
        {
            texts.Text = _dato50;
        }
        public void Valor51(string _dato51)
        {
            textm.Text = _dato51;
        }
        public void Valor52(string _dato52)
        {
            textl.Text = _dato52;
        }
        public void Valor53(string _dato53)
        {
            textxl.Text = _dato53;
        }
        public void Valor54(string _dato54)
        {
            textxxl.Text = _dato54;
        }
        public void Valor55(string _dato55)
        {
            text3xl.Text = _dato55;
        }
        public void Valor56(string _dato56)
        {
            text4xl.Text = _dato56;
        }
        public void Valor57(string _dato57)
        {
            text5xl.Text = _dato57;
        }
        public void Valor58(string _dato58)
        {
            text6xl.Text = _dato58;
        }
        public void Valor59(string _dato59)
        {
            textcantidadop.Text = _dato59;
        }



    }
    
}
