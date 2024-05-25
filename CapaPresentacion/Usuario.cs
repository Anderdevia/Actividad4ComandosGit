using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();
        }

        private void Usuario_Load(object sender, EventArgs e)
        {
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }
        private bool boton2 = false;
        private Busempleado.Datos info;

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (boton2)
            {

                timer1.Stop();


            }

            timer1.Interval = 600;




          //  panel10.Size = new System.Drawing.Size(1310, 1300);
           // panel1.Size = new System.Drawing.Size(37, 1350);
           // panel10.Location = new Point(155, 48);
           // panel1.Size = new System.Drawing.Size(37, 1370);
           // panel10.Location = new Point(130, 48);
           // panel1.Size = new System.Drawing.Size(37, 1390);
           // panel10.Size = new System.Drawing.Size(1310, 1410);
           // panel10.Location = new Point(105, 48);
            //panel1.Size = new System.Drawing.Size(37, 1430);
            //panel10.Location = new Point(85, 48);
            //panel1.Size = new System.Drawing.Size(37, 14450);
            panel10.Location = new Point(65, 48);
            panel1.Size = new System.Drawing.Size(37, 1460);
            panel10.Location = new Point(38, 48);
            panel10.Size = new System.Drawing.Size(1280, 1600);

            panel10.Size = new System.Drawing.Size(1310, 1600);





        
    }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {


            timer1.Stop();
            boton2 = true;
            panel10.Size = new System.Drawing.Size(1280, 1577);
            panel10.Location = new Point(178, 48);

            panel1.Size = new System.Drawing.Size(177, 1177);


            panel10.Location = new Point(178, 48);
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {


            timer1.Stop();
            boton2 = true;
            panel10.Size = new System.Drawing.Size(1280, 1577);
            panel10.Location = new Point(178, 48);

            panel1.Size = new System.Drawing.Size(177, 1177);


            panel10.Location = new Point(178, 48);
        }

        private void button4_MouseMove(object sender, MouseEventArgs e)
        {


            timer1.Stop();
            boton2 = true;
            panel10.Size = new System.Drawing.Size(1280, 1577);
            panel10.Location = new Point(178, 48);

            panel1.Size = new System.Drawing.Size(177, 1177);


            panel10.Location = new Point(178, 48);
        }

        private void button5_MouseMove(object sender, MouseEventArgs e)
        {

            timer1.Stop();
            boton2 = true;
            panel10.Size = new System.Drawing.Size(1280, 1577);
            panel10.Location = new Point(178, 48);

            panel1.Size = new System.Drawing.Size(177, 1177);


            panel10.Location = new Point(178, 48);
        }

        private void button8_MouseMove(object sender, MouseEventArgs e)
        {


            timer1.Stop();
            boton2 = true;
            panel10.Size = new System.Drawing.Size(1280, 1577);
            panel10.Location = new Point(178, 48);

            panel1.Size = new System.Drawing.Size(177, 1177);


            panel10.Location = new Point(178, 48);
        }

        private void button7_MouseMove(object sender, MouseEventArgs e)
        {


            timer1.Stop();
            boton2 = true;
            panel10.Size = new System.Drawing.Size(1280, 1577);
            panel10.Location = new Point(178, 48);

            panel1.Size = new System.Drawing.Size(177, 1177);


            panel10.Location = new Point(178, 48);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            panel10.Controls.Clear();
            Empleoperacion xforme = new Empleoperacion();
            xforme.TopLevel = false;
            panel10.Controls.Add(xforme);
            panel10.Size = new System.Drawing.Size(1100, 1577);
            //panel2.Visible = false;

            xforme.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top);

            //  panel10.Size = new System.Drawing.Size(550, 250);

            xforme.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel10.Controls.Clear();
            Formopyem xforme = new Formopyem();
            xforme.TopLevel = false;
            panel10.Controls.Add(xforme);
           panel10.Size = new System.Drawing.Size(1100, 1577);

            xforme.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top);

            //  panel10.Size = new System.Drawing.Size(550, 250);

            xforme.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            panel10.Controls.Clear();
            Formhorario xforme = new Formhorario();
            xforme.TopLevel = false;
            panel10.Controls.Add(xforme);
            panel10.Size = new System.Drawing.Size(1100, 1577);

            xforme.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top);

            //  panel10.Size = new System.Drawing.Size(550, 250);

            xforme.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel10.Controls.Clear();
            Formotroconcepto xforme = new Formotroconcepto();
            xforme.TopLevel = false;
            panel10.Controls.Add(xforme);
            panel10.Size = new System.Drawing.Size(1190, 1577);

            xforme.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top);

            //  panel10.Size = new System.Drawing.Size(550, 250);

            xforme.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            panel10.Controls.Clear();
            Formtodas xforme = new Formtodas();
            xforme.TopLevel = false;
            panel10.Controls.Add(xforme);
            panel10.Size = new System.Drawing.Size(1190, 1577);

            xforme.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top);

            //  panel10.Size = new System.Drawing.Size(550, 250);

            xforme.Show();
        }

        private void Usuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MessageBox.Show("¿Está Seguro que Desea Salir.?", "Sistema Contro de Tiempos.", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {


                this.Hide();
                Formlogin L = new Formlogin();
                L.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel10.Controls.Clear();
            Busempleado xforme = new Busempleado();
            xforme.TopLevel = false;
            panel10.Controls.Add(xforme);
            panel10.Size = new System.Drawing.Size(1370, 1400);
            panel2.Visible = false;

            xforme.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top);

            //  panel10.Size = new System.Drawing.Size(550, 250);

            xforme.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
