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
    public partial class Cantiopera : Form
    {
        int Listado = 0;
        Adoperacion re = new Adoperacion();
        clsopp O = new clsopp();
        Clsopes S = new Clsopes();

        public Cantiopera()
        {
            InitializeComponent();
        }




        private void DrawGroupBox(GroupBox box, Graphics g, Color textColor, Color borderColor)
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

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            DrawGroupBox(box, e.Graphics, Color.PaleTurquoise, Color.PaleTurquoise);
        }

        private void groupBox2_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            DrawGroupBox(box, e.Graphics, Color.PaleTurquoise, Color.PaleTurquoise);
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

        private void Cantiopera_Load_1(object sender, EventArgs e)
        {
          
            btnfinal.Enabled = false;
            groupBox2.Visible = false;
            CargarListadoidprenda();         
          // CargarListadooperacion2();
          //  Cargarlistadomodifi();

          
          
            dataGridView1.DefaultCellStyle.Font = new Font("Nirmala UI", 7);
            dataGridView1.RowTemplate.Height = 13;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);

            this.Cursor = Cursors.Default;
        }
     
        private void CargarListadooperacion2()
        {
           
            try
            {
                DataTable dt = new DataTable();
                dt = O.ListadoOpp1();

                dataGridView2.Rows.Clear();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                       
                        dataGridView2.DefaultCellStyle.Font = new Font("Nirmala UI", 7);
                        dataGridView2.RowTemplate.Height = 13;
                        dataGridView2.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView2.Font, FontStyle.Bold);
                        dataGridView2.Rows.Add(dt.Rows[i][0]);
                        dataGridView2.Rows[i].Cells[0].Value = dt.Rows[i][0].ToString();
                        dataGridView2.Rows[i].Cells[1].Value = dt.Rows[i][1].ToString();
                        dataGridView2.Rows[i].Cells[2].Value = dt.Rows[i][2].ToString();
                        dataGridView2.Rows[i].Cells[3].Value = dt.Rows[i][3].ToString();
                        dataGridView2.Rows[i].Cells[4].Value = dt.Rows[i][4].ToString();
                        dataGridView2.Rows[i].Cells[5].Value = dt.Rows[i][5].ToString();
                        dataGridView2.Rows[i].Cells[6].Value = dt.Rows[i][6].ToString();
                        dataGridView2.Rows[i].Cells[7].Value = dt.Rows[i][7].ToString();
                        dataGridView2.Rows[i].Cells[8].Value = dt.Rows[i][8].ToString();
                        dataGridView2.Rows[i].Cells[9].Value = dt.Rows[i][9].ToString();
                        dataGridView2.Rows[i].Cells[10].Value = dt.Rows[i][10].ToString();
                        dataGridView2.Rows[i].Cells[11].Value = dt.Rows[i][11].ToString();
                        dataGridView2.Rows[i].Cells[12].Value = dt.Rows[i][12].ToString();
                        dataGridView2.Rows[i].Cells[13].Value = dt.Rows[i][13].ToString();
                        dataGridView2.Rows[i].Cells[14].Value = dt.Rows[i][14].ToString();
                        dataGridView2.Rows[i].Cells[15].Value = dt.Rows[i][15].ToString();
                        dataGridView2.Rows[i].Cells[16].Value = dt.Rows[i][16].ToString();
                        dataGridView2.Rows[i].Cells[17].Value = dt.Rows[i][17].ToString();
                        dataGridView2.Rows[i].Cells[18].Value = dt.Rows[i][18].ToString();
                        dataGridView2.Rows[i].Cells[19].Value = dt.Rows[i][19].ToString();
                        dataGridView2.Rows[i].Cells[20].Value = dt.Rows[i][20].ToString();
                        dataGridView2.Rows[i].Cells[21].Value = dt.Rows[i][21].ToString();
                    FreezeBand1(dataGridView2.Columns[1]);
                }
                    for (int ip = 0; ip < dataGridView2.Rows.Count; ip++)
                        {
                            int val = Int32.Parse(dataGridView2.Rows[ip].Cells[21].Value.ToString());


                            if (val == 3)
                            {
                                dataGridView2.Rows[ip].DefaultCellStyle.BackColor = Color.Tomato;
                                dataGridView2.ClearSelection();
                                // Cargarlistafinal();
                            }
                        }



                    

                    Verresul();

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataGridView2.ClearSelection();
            Verresul();
        }

        private void CargarListadoidprenda()
        {
            DataTable dt = new DataTable();
            dt = re.Listadoop1();
            try
            {
                dataGridView1.Rows.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dataGridView1.DefaultCellStyle.Font = new Font("Nirmala UI", 7);
                    dataGridView1.RowTemplate.Height = 13;
                    dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);
                    dataGridView1.Rows.Add(dt.Rows[i][0]);
                    dataGridView1.Rows[i].Cells[0].Value = dt.Rows[i][0].ToString();

                    FreezeBand1(dataGridView1.Columns[0]);






                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataGridView1.ClearSelection();
        }

     
        private void Busquedaopp()
        {
            DataTable dt = new DataTable();

            try
            {
                re.Op = Convert.ToInt32(txtidprenda.Text);
                dt = re.Buscarop1(re.Op);
                dataGridView1.Rows.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dataGridView1.DefaultCellStyle.Font = new Font("Nirmala UI", 7);
                    dataGridView1.RowTemplate.Height = 13;
                    dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);
                    dataGridView1.Rows.Add(dt.Rows[i][0]);
                    dataGridView1.Rows[i].Cells[0].Value = dt.Rows[i][0].ToString();

                    FreezeBand1(dataGridView1.Columns[0]);
                    Verresul();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Solo se admiten el valor de la OP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            dataGridView1.ClearSelection();

            Verresul();
        }

      

        private void btnasignar_Click(object sender, EventArgs e)
        {

            try
            {

                //  textBox1.Text = dataGridViewop1.CurrentCell.Value.ToString();

                Busquedaopp();
              
                Aceptarbusqueda();
                Verresul();



            }
            catch (Exception ex)
            {
                MessageBox.Show(" ID no Existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void Busquedaopconoperaciones()
        {
            DataTable dt = new DataTable();

            try
            {
                S.Opint = Convert.ToInt32(txtidprenda.Text);
                dt = S.Buscarop2(S.Opint);
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
                    FreezeBand1(dataopb.Columns[2]);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Solo se admiten el valor de la OP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dataopb.ClearSelection();

        }
        private void txtidprenda_KeyPress(object sender, KeyPressEventArgs e)
        {




            //  botonenter = true;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;

            }

            if (e.KeyChar == 13)
            {
                txtop.Focus();

                Busquedaopconoperaciones();
                

            }
            else
            {
                CargarListado();
               CargarListadoidprenda();
               // CargarListadooperacion2();
           
            }


        }
        private bool botonenter = false;

        private void Aceptarbusqueda()
        {

            try
            {
                botonenter = true;
                DataTable dt = new DataTable();
                DataRow row;
                re.Op = Convert.ToInt32(txtidprenda.Text);
                dt = re.Buscarop1(re.Op);
                if (dt.Rows.Count == 1)
                {
                    row = dt.Rows[0];
                    txtidprenda.Text = row[0].ToString();
                    //    txtop.Text = row[1].ToString();
                    txtnombrpren.Text = row[2].ToString();
                    txtcat.Text = row[3].ToString();
                    rtxtdescr.Text = row[4].ToString();

                    //  dateT1.Value = Convert.ToDateTime(row[4].ToString());


                    //   MessageBox.Show("Registro Encontrado Ok...!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                  //  lblverno.Text = Convert.ToString("¡Registro de ID no existe!");
                     MessageBox.Show("Registro no encontrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ingrese el número de ID ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtidprenda_Enter(object sender, EventArgs e)
        {



        }



        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                Busquedaopp();
              
                Aceptarbusqueda();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Registro no encontrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void Busquedaooid()
        {
   
            try
            {


                    textBox30.Text = dataGridView2.CurrentCell.Value.ToString();
                    DataTable dt = new DataTable();
                    DataRow row;

                    O.IDopera = Convert.ToInt32(textBox30.Text);
                    dt = O.Buscarid(O.IDopera);



                if (dt.Rows.Count == 1)
                {
                    row = dt.Rows[0];

                textBox30.Text = row[0].ToString();
                textBox31.Text = row[1].ToString();

                    textBox14.Text = row[2].ToString();
                    textBox11.Text = row[3].ToString();
                    textBox13.Text = row[4].ToString();
                    textBox12.Text = row[5].ToString();
                    richTextBox1.Text = row[6].ToString();

                    textBox26.Text = row[7].ToString();//tiempo
                    textBox27.Text = row[8].ToString();//cantidad
                    textBox28.Text = row[9].ToString();//total


                    textBox25.Text = row[10].ToString();
                    textBox24.Text = row[11].ToString();
                    textBox23.Text = row[12].ToString();
                    textBox22.Text = row[13].ToString();
                    textBox21.Text = row[14].ToString();
                    textBox20.Text = row[15].ToString();

                    textBox15.Text = row[16].ToString();
                    textBox19.Text = row[17].ToString();
                    textBox18.Text = row[18].ToString();
                    textBox17.Text = row[19].ToString();
                    textBox16.Text = row[20].ToString();
                    textBox29.Text = row[21].ToString();


                    //lblverno.Text = Convert.ToString("¡Registro de ID no existe!");
                    // MessageBox.Show("Registro de Orden de Produccion no Existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                
          }
          catch (Exception ex)
            {
               //MessageBox.Show(ex.Message);
                MessageBox.Show("Sin datos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }

            dataGridView1.ClearSelection();

           Verresul();

        }
        private void Busquedaop()
        {

            try
            {
                int i,m = 0;
                DataTable dt = new DataTable();
                DataRow row;

                re.Op = Convert.ToInt32(txtop.Text);
                m = Convert.ToInt32(txtop.Text);
                dt = re.Buscaropu(re.Op);

                if (dt.Rows.Count == 1)
                {
                    row = dt.Rows[0];

                   i= Convert.ToInt32( textBox4.Text = row[0].ToString());
                    
                    if ( i == m)
                    {



                        MessageBox.Show("Ya existe está OP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                  
                   
                }
                else
                {
                   textBox3.Text= Convert.ToString(txtop.Text);
                    O.Opp1 = Convert.ToInt32(txtop.Text);
                    O.IDprendadd = Convert.ToInt32(txtidprenda.Text);
                    O.Nombrepren = txtnombrpren.Text;
                    O.Categoria2 = txtcat.Text;
                    //  O.Totalpp = Convert.ToInt32(0);


                    O.Sobremedidao = Convert.ToInt32(txtsobre.Text);

                    O.Xso = Convert.ToInt32(txtxs.Text);
                    O.So = Convert.ToInt32(txts.Text);
                    O.Mmo = Convert.ToInt32(txtm.Text);
                    O.Lo = Convert.ToInt32(txtl.Text);
                    O.Xlo = Convert.ToInt32(txtxl.Text);
                    O.Xxlo = Convert.ToInt32(txtxxl.Text);
                    O.T3xlo = Convert.ToInt32(txt3xl.Text);
                    O.T4xlo = Convert.ToInt32(txt4xl.Text);
                    O.T5xlo = Convert.ToInt32(txt5xl.Text);
                    O.T6xlo = Convert.ToInt32(txt6xl.Text);
                    O.Estado = Convert.ToInt32(2);
                    //   O.Fecha_de_registro = dateT1;

                     txtcantidadop.Text = O.sumaop().ToString();
                    O.Actualizaropp1();
                    MessageBox.Show("Se registro correctamente Ok!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                    re.Opu = Convert.ToInt32(txtop.Text);
                    re.Idprendu = Convert.ToInt32(txtidprenda.Text);
                    re.Nomprendu = txtnombrpren.Text;
                    //  O.Totalpp = Convert.ToInt32(0);
                    re.Cantidau = Convert.ToInt32(txtcantidadop.Text);
                    re.Registraropu();

                   // CargarListadooperacion2();
                    Busquedaops();
                  
                }
                 Verresul();

             

            }
            catch (Exception ex)
            {
                //MessageBox.Show("Solo se admiten el valor de la OP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



            //Verresul();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Busquedaop();

           

        }
       
       
      

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Verresul()
        {
            try
            {
                double total = 0;
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {

                    total += Convert.ToDouble(row.Cells["tiempopp"].Value) * Convert.ToDouble(row.Cells["cantidadop"].Value);
                    row.Cells[dataGridView2.Columns["totalop"].Index].Value = (Convert.ToDecimal(row.Cells[dataGridView2.Columns["tiempopp"].Index].Value) * Convert.ToDecimal(row.Cells[dataGridView2.Columns["cantidadop"].Index].Value));
                    //row.Cells[dataGridView2.Columns["idoper"].Index].Value = (Convert.ToDecimal(row.Cells[dataGridView2.Columns["idoper"].Index].Value) + Convert.ToDecimal(row.Cells[dataGridView2.Columns["opp1"].Index].Value));

                }
                textBox1.Text = total.ToString("N");
                textBox10.Text = dataGridView2.RowCount.ToString();
                //   Convert.ToString(ded.ToString("00.0"));
                int sum = 0;
                for (int i = 0; i < dataGridView2.Rows.Count; ++i)
                {
                    sum += Convert.ToInt32(dataGridView2.Rows[i].Cells[8].Value);
                }

                textBox5.Text = sum.ToString("N");

                for (int ip = 0; ip < dataGridView2.Rows.Count; ip++)
                {
                    int val = Int32.Parse(dataGridView2.Rows[ip].Cells[21].Value.ToString());


                    if (val == 3)
                    {
                        dataGridView2.Rows[ip].DefaultCellStyle.BackColor = Color.Tomato;
                        dataGridView2.ClearSelection();
                        // Cargarlistafinal();
                    }
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                // MessageBox.Show("Solo se admiten el valor de la OP", "Acviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

}



private void Busquedaop45()
        {
            DataTable dt = new DataTable();

            try
            {
                O.Opp1 = Convert.ToInt32(textBox3.Text);
                dt = O.Buscarnopp1(O.Opp1);
            
                for (int i = 0; i < dt.Rows.Count; i++)
                {O.Opp1 = Convert.ToInt32(txtop.Text);
                O.IDprendadd = Convert.ToInt32(txtidprenda.Text);
                O.Nombrepren = txtnombrpren.Text;
                O.Categoria2 = txtcat.Text;
                //  O.Totalpp = Convert.ToInt32(0);


                O.Sobremedidao = Convert.ToInt32(txtsobre.Text);

                O.Xso = Convert.ToInt32(txtxs.Text);
                O.So = Convert.ToInt32(txts.Text);
                O.Mmo = Convert.ToInt32(txtm.Text);
                O.Lo = Convert.ToInt32(txtl.Text);
                O.Xlo = Convert.ToInt32(txtxl.Text);
                O.Xxlo = Convert.ToInt32(txtxxl.Text);
                O.T3xlo = Convert.ToInt32(txt3xl.Text);
                O.T4xlo = Convert.ToInt32(txt4xl.Text);
                O.T5xlo = Convert.ToInt32(txt5xl.Text);
                O.T6xlo = Convert.ToInt32(txt6xl.Text);
                O.Estado = Convert.ToInt32(1);


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                // MessageBox.Show("Solo se admiten el valor de la OP", "Acviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
      

        }

        private void button4_Click(object sender, EventArgs e)
        {

         try
           {int m,l= 0;
                m = Convert.ToInt32(textBox29.Text);
                l = Convert.ToInt32(textBox31.Text);
                if (m==3)
                {
                    MessageBox.Show("¡No se puede asignar un valor ya asignado...!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                if(l>0)
                {
                    O.IDopera = Convert.ToInt32(textBox30.Text);

                    O.Opp1 = Convert.ToInt32(textBox31.Text);
                    O.IDprendadd = Convert.ToInt32(textBox14.Text);
                    O.Nombrepren = textBox11.Text;
                    O.Nombreoperpp = textBox13.Text;
                    O.Categoria2 = textBox12.Text;
                    O.Descripcionpp = richTextBox1.Text;

                    O.Tiempopp = Convert.ToDecimal(textBox26.Text);//tiempo
                    O.Cantidadpp = Convert.ToInt32(textBox27.Text);//cantidad
                    O.Totalpp = Convert.ToDecimal(textBox28.Text);//total


                    O.Sobremedidao = Convert.ToInt32(textBox25.Text);
                    O.Xso = Convert.ToInt32(textBox24.Text);
                    O.So = Convert.ToInt32(textBox23.Text);
                    O.Mmo = Convert.ToInt32(textBox22.Text);
                    O.Lo = Convert.ToInt32(textBox21.Text);
                    O.Xlo = Convert.ToInt32(textBox20.Text);

                    O.Xxlo = Convert.ToInt32(textBox15.Text);
                    O.T3xlo = Convert.ToInt32(textBox19.Text);
                    O.T4xlo = Convert.ToInt32(textBox18.Text);
                    O.T5xlo = Convert.ToInt32(textBox17.Text);
                    O.T6xl = Convert.ToInt32(textBox16.Text);

                    O.Estado = Convert.ToInt32(textBox29.Text);



                    MessageBox.Show(O.Registrar_operaultima(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //   textBox28.Text = row[21].ToString();

                    O.IDopera = Convert.ToInt32(textBox30.Text);

                    O.Estado = Convert.ToInt32(3);
                    //   O.Fecha_de_registro = dateT1;


                    O.Actualizarestado();
                    MessageBox.Show("Se registro correctamente Ok!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    btnfinal.Enabled = false;
                    btnfinal.BackColor = Color.SteelBlue;
                    btnfinal.ForeColor = Color.White;

                    Busquedaops();

                }
                else
                {
                    MessageBox.Show("¡No se puede asignar sin OP...!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
              





           }
           catch (Exception ex)
            {
                // MessageBox.Show("Registro de Orden de Produccion no Existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             MessageBox.Show("¡ Sin datos !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


           }

        }

       
        private void CargarListado()
        {
            DataTable dt = new DataTable();
            dt = S.Listadoop2();
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
                    FreezeBand1(dataopb.Columns[2]);


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataopb.ClearSelection();
        }
        private static void FreezeBand1(DataGridViewBand band)
        {
            band.Frozen = true;
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.BackColor = Color.LightGray;
            band.DefaultCellStyle = style;
        }
        private void Buscaropera1()
        {
            DataTable dt = new DataTable();

            try
            {
                O.Opp = Convert.ToInt32(textBox3.Text);

                dt = O.Buscarnopp12(O.Opp);
                dataGridView2.Rows.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dataGridView2.DefaultCellStyle.Font = new Font("Nirmala UI", 7);
                    dataGridView2.RowTemplate.Height = 13;
                    dataGridView2.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView2.Font, FontStyle.Bold);
                    dataGridView2.Rows.Add(dt.Rows[i][0]);
                    dataGridView2.Rows[i].Cells[0].Value = dt.Rows[i][0].ToString();
                    dataGridView2.Rows[i].Cells[1].Value = dt.Rows[i][1].ToString();
                    dataGridView2.Rows[i].Cells[2].Value = dt.Rows[i][2].ToString();
                    dataGridView2.Rows[i].Cells[3].Value = dt.Rows[i][3].ToString();
                    dataGridView2.Rows[i].Cells[4].Value = dt.Rows[i][4].ToString();
                    dataGridView2.Rows[i].Cells[5].Value = dt.Rows[i][5].ToString();
                    dataGridView2.Rows[i].Cells[6].Value = dt.Rows[i][6].ToString();
                    dataGridView2.Rows[i].Cells[7].Value = dt.Rows[i][7].ToString();
                    dataGridView2.Rows[i].Cells[8].Value = dt.Rows[i][8].ToString();
                    dataGridView2.Rows[i].Cells[9].Value = dt.Rows[i][9].ToString();
                    dataGridView2.Rows[i].Cells[10].Value = dt.Rows[i][10].ToString();
                    dataGridView2.Rows[i].Cells[11].Value = dt.Rows[i][11].ToString();
                    dataGridView2.Rows[i].Cells[12].Value = dt.Rows[i][12].ToString();
                    dataGridView2.Rows[i].Cells[13].Value = dt.Rows[i][13].ToString();
                    dataGridView2.Rows[i].Cells[14].Value = dt.Rows[i][14].ToString();
                    dataGridView2.Rows[i].Cells[15].Value = dt.Rows[i][15].ToString();
                    dataGridView2.Rows[i].Cells[16].Value = dt.Rows[i][16].ToString();
                    dataGridView2.Rows[i].Cells[17].Value = dt.Rows[i][17].ToString();
                    dataGridView2.Rows[i].Cells[18].Value = dt.Rows[i][18].ToString();
                    dataGridView2.Rows[i].Cells[19].Value = dt.Rows[i][19].ToString();
                    dataGridView2.Rows[i].Cells[20].Value = dt.Rows[i][20].ToString();
                    dataGridView2.Rows[i].Cells[21].Value = dt.Rows[i][21].ToString();

                    FreezeBand1(dataGridView2.Columns[1]);
                


                }
                Verresul();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Sin datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dataGridView2.ClearSelection();
        }
        private void registromultioperacion()
        {
            DataTable dt = new DataTable();

            try
            {

                O.Opp1 = Convert.ToInt32(textBox3.Text);
                dt = O.Buscarnopp1(O.Opp1);
                dataGridView3.Rows.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    label4.Text = Convert.ToString(i+1);
                    dataGridView3.DefaultCellStyle.Font = new Font("Nirmala UI", 7);
                    dataGridView3.RowTemplate.Height = 13;
                    dataGridView3.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView3.Font, FontStyle.Bold);
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
                    dataGridView3.Rows[i].Cells[11].Value = dt.Rows[i][11].ToString();
                    dataGridView3.Rows[i].Cells[12].Value = dt.Rows[i][12].ToString();
                    dataGridView3.Rows[i].Cells[13].Value = dt.Rows[i][13].ToString();
                    dataGridView3.Rows[i].Cells[14].Value = dt.Rows[i][14].ToString();
                    dataGridView3.Rows[i].Cells[15].Value = dt.Rows[i][15].ToString();
                    dataGridView3.Rows[i].Cells[16].Value = dt.Rows[i][16].ToString();
                    dataGridView3.Rows[i].Cells[17].Value = dt.Rows[i][17].ToString();
                    dataGridView3.Rows[i].Cells[18].Value = dt.Rows[i][18].ToString();
                    dataGridView3.Rows[i].Cells[19].Value = dt.Rows[i][19].ToString();
                    dataGridView3.Rows[i].Cells[20].Value = dt.Rows[i][20].ToString();
                    dataGridView3.Rows[i].Cells[21].Value = dt.Rows[i][21].ToString();

                    string q, ww;
                    int m, l = 0;
                 
                    l = Convert.ToInt32(q=dt.Rows[i][1].ToString());
                    m = Convert.ToInt32(ww=dt.Rows[i][21].ToString());

             
                    if (m == 3)
                    {
                       // MessageBox.Show("¡No se puede asignar un valor ya asignado...!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    if (l > 0)
                    {
                        string id, op, idpren, cat, tie, to, w, e, r, t, y, u, ii, o, p, a, s;


                        O.IDopera = Convert.ToInt32(id = dt.Rows[i][0].ToString());

                        O.Opp1 = Convert.ToInt32(op = dt.Rows[i][1].ToString());
                        O.IDprendadd = Convert.ToInt32(idpren = dt.Rows[i][2].ToString());
                        O.Nombrepren = dt.Rows[i][3].ToString();
                        O.Nombreoperpp = dt.Rows[i][4].ToString();
                        O.Categoria2 = dt.Rows[i][5].ToString();
                        O.Descripcionpp = dt.Rows[i][6].ToString();

                        O.Tiempopp = Convert.ToDecimal(tie = dt.Rows[i][7].ToString());//tiempo
                        O.Cantidadpp = Convert.ToInt32(cat = dt.Rows[i][8].ToString());//cantidad
                        O.Totalpp = Convert.ToDecimal(to = dt.Rows[i][9].ToString());//total


                        O.Sobremedidao = Convert.ToInt32(w = dt.Rows[i][10].ToString());
                        O.Xso = Convert.ToInt32(e = dt.Rows[i][11].ToString());
                        O.So = Convert.ToInt32(r = dt.Rows[i][12].ToString());
                        O.Mmo = Convert.ToInt32(t = dt.Rows[i][13].ToString());
                        O.Lo = Convert.ToInt32(y = dt.Rows[i][14].ToString());
                        O.Xlo = Convert.ToInt32(u = dt.Rows[i][15].ToString());

                        O.Xxlo = Convert.ToInt32(ii = dt.Rows[i][16].ToString());
                        O.T3xlo = Convert.ToInt32(o = dt.Rows[i][17].ToString());
                        O.T4xlo = Convert.ToInt32(p = dt.Rows[i][18].ToString());
                        O.T5xlo = Convert.ToInt32(a = dt.Rows[i][19].ToString());
                        O.T6xl = Convert.ToInt32(s = dt.Rows[i][20].ToString());

                        O.Estado = Convert.ToInt32(3);
                        O.Registrar_operaultima();

                      


                        O.Actualizarestado();


                    }
                    else
                    {
                        MessageBox.Show("¡No se puede asignar sin OP...!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                }
                Busquedaops();
                groupBox2.Visible = true;
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message);
                MessageBox.Show("Sin datos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dataGridView2.ClearSelection();
            Verresul();

        }
        private void Busquedaops()
        {
            DataTable dt = new DataTable();

            try
            {
                O.Opp1 = Convert.ToInt32(textBox3.Text);
                dt = O.Buscarnopp1(O.Opp1);
                dataGridView2.Rows.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dataGridView2.DefaultCellStyle.Font = new Font("Nirmala UI", 7);
                    dataGridView2.RowTemplate.Height = 13;
                    dataGridView2.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView2.Font, FontStyle.Bold);
                    dataGridView2.Rows.Add(dt.Rows[i][0]);
                    dataGridView2.Rows[i].Cells[0].Value = dt.Rows[i][0].ToString();
                    dataGridView2.Rows[i].Cells[1].Value = dt.Rows[i][1].ToString();
                    dataGridView2.Rows[i].Cells[2].Value = dt.Rows[i][2].ToString();
                    dataGridView2.Rows[i].Cells[3].Value = dt.Rows[i][3].ToString();
                    dataGridView2.Rows[i].Cells[4].Value = dt.Rows[i][4].ToString();
                    dataGridView2.Rows[i].Cells[5].Value = dt.Rows[i][5].ToString();
                    dataGridView2.Rows[i].Cells[6].Value = dt.Rows[i][6].ToString();
                    dataGridView2.Rows[i].Cells[7].Value = dt.Rows[i][7].ToString();
                    dataGridView2.Rows[i].Cells[8].Value = dt.Rows[i][8].ToString();
                    dataGridView2.Rows[i].Cells[9].Value = dt.Rows[i][9].ToString();
                    dataGridView2.Rows[i].Cells[10].Value = dt.Rows[i][10].ToString();
                    dataGridView2.Rows[i].Cells[11].Value = dt.Rows[i][11].ToString();
                    dataGridView2.Rows[i].Cells[12].Value = dt.Rows[i][12].ToString();
                    dataGridView2.Rows[i].Cells[13].Value = dt.Rows[i][13].ToString();
                    dataGridView2.Rows[i].Cells[14].Value = dt.Rows[i][14].ToString();
                    dataGridView2.Rows[i].Cells[15].Value = dt.Rows[i][15].ToString();
                    dataGridView2.Rows[i].Cells[16].Value = dt.Rows[i][16].ToString();
                    dataGridView2.Rows[i].Cells[17].Value = dt.Rows[i][17].ToString();
                    dataGridView2.Rows[i].Cells[18].Value = dt.Rows[i][18].ToString();
                    dataGridView2.Rows[i].Cells[19].Value = dt.Rows[i][19].ToString();
                    dataGridView2.Rows[i].Cells[20].Value = dt.Rows[i][20].ToString();
                    dataGridView2.Rows[i].Cells[21].Value = dt.Rows[i][21].ToString();

                    FreezeBand1(dataGridView2.Columns[1]);

                    for (int ip = 0; ip < dataGridView2.Rows.Count; ip++)
                    {
                        int val = Int32.Parse(dataGridView2.Rows[ip].Cells[21].Value.ToString());


                        if (val == 3)
                        {
                            dataGridView2.Rows[ip].DefaultCellStyle.BackColor = Color.Tomato;
                            dataGridView2.ClearSelection();
                            // Cargarlistafinal();
                        }
                    }

                }
                Verresul();
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message);
                //MessageBox.Show("Solo se admiten el valor de la OP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dataGridView2.ClearSelection();
           

        }
       
     
        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try

            {
                // textBox4.Text = dataGridView5.CurrentCell.Value.ToString();

               // if (dataGridView3.Rows.Count > 0)
              //  {
               //     dataGridView3.Rows[dataGridView3.CurrentRow.Index].Selected = true;
                   
              //  }

                //txtnupe2.Text = dataopb.CurrentCell.Value.ToString();


            }

            catch (Exception ex)
            {
                // MessageBox.Show("Dar Click unicamente en OP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }



        }

        private void dataGridView2_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (dataGridView2.SelectedRows.Count > 0)
                    dataGridView2.ClearSelection();
            }
        }

        private void dataGridView5_Click(object sender, EventArgs e)
        {

            if (dataGridView2.Rows.Count > 0)
            {
                dataGridView2.Rows[dataGridView2.CurrentRow.Index].Selected = true;
               
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            //botonenter = true;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == 13)
            {

               Busquedaops();
            }
            else
            {

               CargarListadooperacion2();
               
            }
        }

        private void dataGridView2_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count > 0)
            {
                dataGridView2.Rows[dataGridView2.CurrentRow.Index].Selected = true;
                
            }
        }
    
   
        private void buscaoppfinal()
        {
            try
            {


                DataTable dt = new DataTable();
                DataRow row;

                S.Opp1 = Convert.ToInt32(textBox3.Text);
                dt = S.Buscaropfinal(S.Opp1);

                if (dt.Rows.Count == 1)
                {
                    row = dt.Rows[0];
                    txtidprenda.Text = row[0].ToString();
                    //    txtop.Text = row[1].ToString();
                    txtnombrpren.Text = row[1].ToString();
                    txtcat.Text = row[2].ToString();
                    rtxtdescr.Text = row[3].ToString();
                    Verresul();
                }


                else
                {
                    MessageBox.Show("Registro no encontrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Solo se admiten el valor de la OP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

          //  dataGridView3.ClearSelection();

            Verresul();


        }
     
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if (e.KeyChar == 13)
            {
                Verresul();
                Busquedaops();
                
            }
            else
            {
              
            }
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

            }
        }

        private void dataGridView6_Click(object sender, EventArgs e)
        {
         //   if (dataGridView3.Rows.Count > 0)
          //  {
          //      dataGridView3.Rows[dataGridView2.CurrentRow.Index].Selected = true;
             
          //  }
        }

        private void dataGridView3_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
        }

        private void dataGridView3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
              //  if(dataGridView3.SelectedRows.Count > 0)
                   // dataGridView3.ClearSelection();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {

                txtidprenda.Text = dataGridView1.CurrentCell.Value.ToString();
                // txtidprenda.Text = textBox3.Text;
                Busquedaopconoperaciones();
           

                dataopb.ClearSelection();
                {
                    button1.Enabled = false;
                }
                if (dataopb.Rows.Count > 0)
                {
                    button1.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sin operaciones ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataopb.Rows.Count > 0)
            {
                dataopb.Rows[dataopb.CurrentRow.Index].Selected = true;
         
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

     
        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
           
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
                button1.Focus();
            }
            else
            {

            }
        }



    

   

     //   private void elimini()
       // {
       //     if (textBox6.Text != string.Empty)
        //    {
        //        button4.Enabled = true;
         //   }
         //   else
         //   {
         //       button4.Enabled = false;
         //   }


       // }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
           // elimini();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {


            try
            {
               
                 
                   if (MessageBox.Show(" Seleccionar Id....!!! ¿ Desea continuar ? ", "Insertar datos", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                   

                {
                   
                    textBox30.Text = dataGridView2.CurrentCell.Value.ToString();
                 // textBox30.Text="0";   kkk

                    Busquedaooid();

                    btnfinal.Enabled = true;
                    btnfinal.BackColor = Color.DarkOrange;
                    btnfinal.ForeColor = Color.Black;

                    O.IDopera = Convert.ToInt32(textBox30.Text);

                }


               

               

            }
            catch (Exception ex)
            {
                // MessageBox.Show("Registro de Orden de Produccion no Existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
               // label4.Text = "";
              //(dataGridView2.DataSource as DataTable).DefaultView.RowFilter = string.Format("opp1 = '{0}'", textBox3.Text);
               // Verresul();

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
               
                //CargarListadooperacion2();//Verresul2();
                // MessageBox.Show(ex.Message);
                //MessageBox.Show("Solo se admiten el valor de la OP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // label2.Text = "REGISTRO NO ENCONTRADO";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
        
                registromultioperacion();
            

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

        private void txtcantidadop_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void dataGridView1_VisibleChanged(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_Validating(object sender, CancelEventArgs e)
        {
            
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

        private void dataGridView2_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            dataGridView2.EnableHeadersVisualStyles = false;
            DataGridViewColumn dataGridViewColumn = dataGridView2.Columns[1];
            dataGridViewColumn.HeaderCell.Style.BackColor = Color.LightGray;
            dataGridViewColumn.HeaderCell.Style.ForeColor = Color.Black;

            Color cl = dataGridViewColumn.HeaderCell.Style.BackColor;
            //or   
            Color cl2 = dataGridView2.Columns[0].HeaderCell.Style.BackColor;
        }

        private void dataopb_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            dataopb.EnableHeadersVisualStyles = false;
            DataGridViewColumn dataGridViewColumn = dataopb.Columns[1];
            dataGridViewColumn.HeaderCell.Style.BackColor = Color.LightGray;
            dataGridViewColumn.HeaderCell.Style.ForeColor = Color.Black;

            Color cl = dataGridViewColumn.HeaderCell.Style.BackColor;
            //or   
            Color cl2 = dataopb.Columns[0].HeaderCell.Style.BackColor;
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            dataGridView1.EnableHeadersVisualStyles = false;
            DataGridViewColumn dataGridViewColumn = dataGridView1.Columns[0];
            dataGridViewColumn.HeaderCell.Style.BackColor = Color.LightGray;
            dataGridViewColumn.HeaderCell.Style.ForeColor = Color.Black;

            Color cl = dataGridViewColumn.HeaderCell.Style.BackColor;
            //or   
            Color cl2 = dataGridView1.Columns[0].HeaderCell.Style.BackColor;
        }
    }
}

