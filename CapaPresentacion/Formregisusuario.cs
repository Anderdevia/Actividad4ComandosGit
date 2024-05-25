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
    public partial class Formregisusuario : Form
    {
        clsusuarios U = new clsusuarios();
        ClsReglasEmpleados Reglas = new ClsReglasEmpleados();

        ClsTBL_EMPLEADOS TblAtri = new ClsTBL_EMPLEADOS();


        public Formregisusuario()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                U.Cedula = Convert.ToInt32(lblDni.Text);
                U.User = txtUser.Text;
                U.Password = txtPassword.Text;
                



                MessageBox.Show(U.RegistrarUsuarios(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

              



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                DataRow row;
                TblAtri.Cedula = Convert.ToInt32(lblDni.Text);
                dt = Reglas.BuscarEmpleados(TblAtri.Cedula.ToString());
                if (dt.Rows.Count == 1)
                {
                    row = dt.Rows[0];
                    lblDni.Text = row[0].ToString();


                    MessageBox.Show("Registro Encontrado Ok...!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUser.Enabled = true;
                    txtPassword.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Registro de Empleado no Existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Formregisusuario_Load(object sender, EventArgs e)
        {
            txtUser.Enabled = false;
            txtPassword.Enabled = false;
        }
    }

  

       
    
}
