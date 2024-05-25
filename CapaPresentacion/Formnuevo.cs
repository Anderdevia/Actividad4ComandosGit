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
    public partial class Formnuevo : Form
    {
        public Formnuevo()
        {
            InitializeComponent();
        }
        Clsfinal F = new Clsfinal();
        public Iopfinal contrato101 { get; set; }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {

            F.Fecha = dateTimePicker6.Value;
            F.Cedula = Convert.ToInt32(textBox31.Text);
            F.Nombreemplea = textBox1.Text; 
            F.Estado = Convert.ToInt32(textBox2.Text);
            MessageBox.Show(F.Regisnuevo(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            buscarnumero();
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);
                MessageBox.Show("Campos Vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buscarnumero()
        {

            try
            {
                DataTable dt = new DataTable();
                dt = F.Listanumero();

                dataGridView1.Rows.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dataGridView1.Rows.Add(dt.Rows[i][0]);
                    dataGridView1.Rows[i].Cells[0].Value = dt.Rows[i][0].ToString();
                    dataGridView1.Visible = true;

                }
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message);

            }


            }

        private void Formnuevo_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            textBox1.Focus();
        }

        private void Formnuevo_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (DataGridViewRow dr in dataGridView1.Rows)
            {

                textBox3.Text = Convert.ToString(dr.Cells[0].Value);
                contrato101.Valor48op(textBox3.Text);
            }
                      
        }
    }
}
