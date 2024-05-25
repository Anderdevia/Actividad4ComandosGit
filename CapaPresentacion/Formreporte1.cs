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
namespace CapaPresentacion
{
    public partial class Formreporte1 : Form
    {
        public Formreporte1()
        {
            InitializeComponent();
        }
      
        CrystalReport22 info = new CrystalReport22();
        ParameterValues param = new ParameterValues();
        ParameterDiscreteValue myDiscreteValue = new ParameterDiscreteValue();

        CrystalReport22 info1 = new CrystalReport22();
        ParameterValues param1 = new ParameterValues();
        ParameterDiscreteValue myDiscreteValue1 = new ParameterDiscreteValue();
        private void Formreporte1_Load(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                param.Clear();
            myDiscreteValue.Value = textBox1.Text;
            param.Add(myDiscreteValue);
            info.DataDefinition.ParameterFields["@codigo"].ApplyCurrentValues(param);
            param.Clear();
            //  myDiscreteValue.Value = dateTimePicker2.Value;
            //  param.Add(myDiscreteValue);
            // info.DataDefinition.ParameterFields["@fecha"].ApplyCurrentValues(param);
            crystalReportViewer1.ReportSource = info;

            
            textBox1.Focus();
            crystalReportViewer1.Zoom(80);
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Datos incorrectos ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

              //  MessageBox.Show(ex.Message);
            }

        }
    }
    
}
