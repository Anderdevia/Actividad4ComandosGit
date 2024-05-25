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
    public partial class Administradores : Form
    {
        public Administradores()
        {
            InitializeComponent();
        }
        clsusuarios O = new clsusuarios();

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Administradores_Load(object sender, EventArgs e)
        {
            // timer1.Start();
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;




        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel1.Size = new System.Drawing.Size(177, 977);
            panel10.Size = new System.Drawing.Size(550, 250);


        }

        private bool boton2 = false;

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {


            timer1.Stop();
            boton2 = true;
            panel10.Size = new System.Drawing.Size(1280, 1577);
            panel10.Location = new Point(150, 48);

            panel1.Size = new System.Drawing.Size(150, 1177);


            panel10.Location = new Point(150, 48);
            // panel10.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top);


            // FrmEmpleados xforme = new FrmEmpleados
            // {
            //     Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top)
            // };




        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (boton2)
            {

                timer1.Stop();


            }

            timer1.Interval = 600;
            //Operadm xform = new Operadm();
            //  xform.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top);
            // xform.Dock = DockStyle.Fill;
            //  FrmEmpleados xforme = new FrmEmpleados();
            // xforme.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top);

            // xform.Dock = DockStyle.Fill;


            //   panel1.Size = new System.Drawing.Size(40, anch);
            panel10.Location = new Point(65, 48);
            panel1.Size = new System.Drawing.Size(37, 1460);
            panel10.Location = new Point(38, 48);
            panel10.Size = new System.Drawing.Size(1280, 1600);

            panel10.Size = new System.Drawing.Size(1310, 1600);




        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {

            timer1.Stop();
            boton2 = true;
            panel10.Size = new System.Drawing.Size(1280, 1577);
            panel10.Location = new Point(150, 48);

            panel1.Size = new System.Drawing.Size(150, 1177);


            panel10.Location = new Point(150, 48);

            //Operadm xform = new Operadm();
            //xform.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top);


        }

        private void button4_MouseMove(object sender, MouseEventArgs e)
        {

            timer1.Stop();
            boton2 = true;
            panel10.Size = new System.Drawing.Size(1280, 1577);
            panel10.Location = new Point(150, 48);

            panel1.Size = new System.Drawing.Size(150, 1177);


            panel10.Location = new Point(150, 48);
            //Operadm xform = new Operadm();
            //  xform.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top);



        }

        private void button5_MouseMove(object sender, MouseEventArgs e)
        {


            timer1.Stop();
            boton2 = true;
            panel10.Size = new System.Drawing.Size(1280, 1577);
            panel10.Location = new Point(150, 48);

            panel1.Size = new System.Drawing.Size(150, 1177);


            panel10.Location = new Point(150, 48);
            // Operadm xform = new Operadm();
            // xform.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top);


        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
           // panel10.Location = new Point(10, 43);
            timer1.Start();
          
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
           // panel10.Location = new Point(10, 43);
            timer1.Start();
           
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
           // panel10.Location = new Point(10, 43);
            timer1.Start();
           
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
           // panel10.Location = new Point(10, 43);
            timer1.Start();
           
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

     

        private void button4_Click(object sender, EventArgs e)
        {

            panel10.Controls.Clear();
            Operadm xform = new Operadm();
            xform.TopLevel = false;
            panel10.Controls.Add(xform);
            panel10.Size = new System.Drawing.Size(1190, 1577);

            xform.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top);

            //  panel10.Size = new System.Drawing.Size(550, 250);
this.Cursor = Cursors.WaitCursor;
            xform.Show();
            // panel10.Size = new System.Drawing.Size(40, 977);
            
        }

        private void panel7_MouseLeave(object sender, EventArgs e)
        {
            // panel10.Location = new Point(10, 43);
           
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            
            // panel10.Location = new Point(10, 43);
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
           // timer2.Start();
           // panel10.Location = new Point(10, 43);
            timer1.Start();
            
        }

        private void button8_MouseMove(object sender, MouseEventArgs e)
        {


            timer1.Stop();
            boton2 = true;
            panel10.Size = new System.Drawing.Size(1280, 1577);
            panel10.Location = new Point(150, 48);

            panel1.Size = new System.Drawing.Size(150, 1100);


            panel10.Location = new Point(150, 48);
            // Operadm xform = new Operadm();
            //  xform.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top);
            //FrmEmpleados xforme = new FrmEmpleados();
            // xforme.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top);

        }

        private void panel7_MouseMove(object sender, MouseEventArgs e)
        {
            //  panel1.Size = new System.Drawing.Size(177, 977);
            //  panel10.Location = new Point(178, 52);
            //    panel1.Size = new System.Drawing.Size(177, 977);
            //  panel10.Size = new System.Drawing.Size(1077, 977);
         
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            timer2.Interval = 600;
            // int  anch ;
            // anch = Convert.ToInt32( AnchorStyles.Bottom );
            //panel1.Size = new System.Drawing.Size(40, anch);
            panel1.Size = new System.Drawing.Size(40, 977);
            this.Cursor = Cursors.WaitCursor;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            panel10.Controls.Clear();
            FrmEmpleados xforme = new FrmEmpleados();
            xforme.TopLevel = false;
            panel10.Controls.Add(xforme);
            panel10.Size = new System.Drawing.Size(1190, 1577);

            xforme.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top);

            //  panel10.Size = new System.Drawing.Size(550, 250);

            xforme.button1.Hide();
            xforme.Size = new System.Drawing.Size(706, 695);
            xforme.groupBox2.Size = new System.Drawing.Size(674, 648);
            xforme.groupBox2.Size = new System.Drawing.Size(674, 648);
            xforme.dataGridView1.Size = new System.Drawing.Size(467, 590);
            xforme.textBox2.Location = new Point( 241, 623);
            xforme.label7.Location = new Point(196, 625);
            xforme.FormBorderStyle = FormBorderStyle.None;
         this.Cursor = Cursors.WaitCursor;
            xforme.Show();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel10.Controls.Clear();
            Form1Orden_de_Produccion xforme = new Form1Orden_de_Produccion();
            xforme.TopLevel = false;
            panel10.Controls.Add(xforme);
            panel10.Size = new System.Drawing.Size(1190, 1577);

            xforme.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top);

            //  panel10.Size = new System.Drawing.Size(550, 250);
            this.Cursor = Cursors.WaitCursor;
            xforme.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
           
                  panel10.Controls.Clear();
            Cantiopera xforme = new Cantiopera();
            xforme.TopLevel = false;
            panel10.Controls.Add(xforme);
            panel10.Size = new System.Drawing.Size(1190, 1577);

            xforme.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top);

            //  panel10.Size = new System.Drawing.Size(550, 250);
 this.Cursor = Cursors.WaitCursor;
            xforme.Show();
           
        }

        private void button7_MouseMove(object sender, MouseEventArgs e)
        {

            timer1.Stop();
            boton2 = true;
            panel10.Size = new System.Drawing.Size(1280, 1577);
            panel10.Location = new Point(150, 48);

            panel1.Size = new System.Drawing.Size(150, 1177);


            panel10.Location = new Point(150, 48);
        }
        private void RecuperarDatosSesion()
        {
            //DataRow row;
           /// DataTable dt = new DataTable();
          //  dt = O.DevolverDatosSesion(label2.Text, label3.Text);
           // if (dt.Rows.Count == 1)
           // {
           //     row = dt.Rows[0];
            //    Program.IdEmpleadoLogueado = Convert.ToInt32(row[0].ToString());
            //    Program.NombreEmpleadoLogueado = row[1].ToString();
           // }
        }

        private void Administradores_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MessageBox.Show("¿ Desea Salir?", "Sistema Control Producción.", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {


                this.Hide();
                Formlogin L = new Formlogin();
                L.ShowDialog();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            panel10.Controls.Clear();
            Unico xform = new Unico();
            xform.TopLevel = false;
            panel10.Controls.Add(xform);
            panel10.Size = new System.Drawing.Size(1300, 1577);

            xform.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top);
            xform.Refresh();
            // xform.panel7.Location = new Point(12, 12);
            // xform.panel7.Size = new System.Drawing.Size(1249, 677);
            //  xform.panel7.Visible = true;
            //  panel10.Size = new System.Drawing.Size(550, 250);

            this.Cursor = Cursors.WaitCursor;

            xform.Show();
        }
    }
}
