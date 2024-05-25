using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocios;
using CapaEntidades;

namespace WindowsFormsApp1
{
    public partial class Formlogin : Form
    {
        clsusuarios O = new clsusuarios();
        clsadmini U = new clsadmini();
        public Formlogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Formregisusuario b = new Formregisusuario();
            
            b.MdiParent = this.MdiParent; // defino que es el formulario hijo

            b.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtUser.Text.Trim() != "")
            {
                if (txtPassword.Text.Trim() != "")
                {
                    String Mensaje = "";
                    O.User = txtUser.Text;
                    O.Password = txtPassword.Text;
                    Mensaje = O.IniciarSesion();
                    if (Mensaje == "Su Contraseña es Incorrecta.")
                    {
                        MessageBox.Show(Mensaje, "Sistema Control Producción.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        txtPassword.Clear();
                        txtPassword.Focus();
                    }
                    else
                        if (Mensaje == "El Nombre de Usuario no Existe.")
                    {
                        MessageBox.Show(Mensaje, "Sistema Control Producción.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        txtUser.Clear();
                        txtPassword.Clear();
                        txtUser1.Focus();
                    }
                    else
                    {
                        MessageBox.Show(Mensaje, "Sistema Control Producción.", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        Usuario MP = new Usuario();
                        RecuperarDatosSesion();
                        MP.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show(" Ingrese su Contraseña.", "Sistema Control de Tiempos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Focus();
                }
            }
            else
            {
                MessageBox.Show(" Ingrese el Usuario.", "Sistema Control de Tiempos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUser.Focus();
            }
        }

        private void RecuperarDatosSesion()
        {
           
            DataRow row;
            DataTable dt = new DataTable();
            dt = O.DevolverDatosSesion(txtUser.Text, txtPassword.Text);
            if (dt.Rows.Count == 1)
            {
                row = dt.Rows[0];
                Program.IdEmpleadoLogueado = Convert.ToInt32(row[0].ToString());
                Program.NombreEmpleadoLogueado = row[1].ToString();
              
                
                
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Formingeni b = new Formingeni();

            b.MdiParent = this.MdiParent; // defino que es el formulario hijo

            b.ShowDialog();
        }

        private void btnentrar_Click(object sender, EventArgs e)
        {

            if (txtUser1.Text.Trim() != "")
            {
                if (txtPassword1.Text.Trim() != "")
                {
                    
                    String Mensaje = "";
                    U.User = txtUser1.Text;


                    U.Password = txtPassword1.Text;
                    Mensaje = U.IniciarSesion();
                    if (Mensaje == "Su Contraseña es Incorrecta.")
                    {
                        MessageBox.Show(Mensaje, "Sistema Control Producción.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        txtPassword1.Clear();
                        txtPassword1.Focus();
                    }
                    else
                        if (Mensaje == "El Nombre de Usuario no Existe.")
                    {
                        MessageBox.Show(Mensaje, "Sistema Control Producción.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        txtUser1.Clear();
                        txtPassword1.Clear();
                        txtUser1.Focus();
                    }
                    else
                    {
                      
                       // RecuperarDatosSesion1();

                        Administradores MP = new Administradores();
                        MessageBox.Show(Mensaje, "Sistema Control Producción", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    
                        MP.Show();
                       // MP.label2.Text == txtUser1.Text;

                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Por Favor Ingrese su Contraseña.", "Sistema Control de Tiempos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword1.Focus();
                }
            }
            else
            {
                MessageBox.Show("Por Favor Ingrese Nombre de Usuario.", "Sistema Control de Tiempos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUser1.Focus();
            }
        }
        private void RecuperarDatosSesion1()
        {
            DataRow row;
            DataTable dt = new DataTable();
            dt = U.DevolverDatosSesion1(txtUser1.Text, txtPassword1.Text);
            if (dt.Rows.Count == 1)
            {
                row = dt.Rows[0];
                Program.IdEmpleadoLogueado1 = Convert.ToInt32(row[0].ToString());
                Program.NombreEmpleadoLogueado1 = row[1].ToString();
            }
        }

      

        private void Formlogin_Load(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
           
            {
                DataRow row;
                DataTable dt = new DataTable();
                dt = U.DevolverDatosSesion1(txtUser1.Text, txtPassword1.Text);
                if (dt.Rows.Count == 1)
                {
                    row = dt.Rows[0];
                    Program.IdEmpleadoLogueado1 = Convert.ToInt32(row[0].ToString());
                    Program.NombreEmpleadoLogueado1 = row[1].ToString();
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            {
                DataRow row;
                DataTable dt = new DataTable();
                dt = U.DevolverDatosSesion1(txtUser1.Text, txtPassword1.Text);
                if (dt.Rows.Count == 1)
                {
                    row = dt.Rows[0];
                    Program.IdEmpleadoLogueado1 = Convert.ToInt32(row[0].ToString());
                    Program.NombreEmpleadoLogueado1 = row[1].ToString();
                }
            }
        }

        private void Formlogin_FormClosing(object sender, FormClosingEventArgs e)
        {
         //   if (MessageBox.Show("¿Está Seguro que Desea Salir?", "Sistema Contro Producción", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
          // {
                //Close();
                
              //  this.Hide();
            Application.Exit();
           // }
        }

        private void label4_Click(object sender, EventArgs e)
        {
        
        }
    }
    
}
