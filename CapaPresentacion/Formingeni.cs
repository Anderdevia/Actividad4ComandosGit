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


namespace WindowsFormsApp1
{
    public partial class Formingeni : Form
    {

        clsadmini U = new clsadmini();
        

        public Formingeni()
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




                MessageBox.Show(U.RegistrarUsuariosad(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);





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
                U.Cedula = Convert.ToInt32(lblDni.Text);
                dt = U.BuscarEmpleados(U.Cedula.ToString());
                if (dt.Rows.Count == 1)
                {
                    row = dt.Rows[0];
                    lblDni.Text = row[0].ToString();
                    lblEmpleado.Text = row[1].ToString();
                    lblCargo.Text = row[2].ToString();


                    MessageBox.Show("Registro Encontrado Ok...!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUser.Enabled = true;
                    txtPassword.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Registro de Administrador no Existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Formingeni_Load(object sender, EventArgs e)
        {
            txtUser.Enabled = false;
            txtPassword.Enabled = false;
        }
    
    
    }
}
