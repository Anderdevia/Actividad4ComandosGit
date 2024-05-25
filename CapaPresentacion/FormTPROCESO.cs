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
    public partial class FormTPROCESO : Form
    {
        public FormTPROCESO()
        {
            InitializeComponent();
        }
        CrystalReport1 info1 = new CrystalReport1();
        ParameterValues param1 = new ParameterValues();
        ParameterDiscreteValue myDiscreteValue1 = new ParameterDiscreteValue();
        private void button15_Click(object sender, EventArgs e)
        {
            try
            {  //reportegeneral();

                param1.Clear();
                myDiscreteValue1.Value = dateTimePicker4.Text;
                param1.Add(myDiscreteValue1);
                info1.DataDefinition.ParameterFields["@fechaini"].ApplyCurrentValues(param1);
                param1.Clear();
                myDiscreteValue1.Value = dateTimePicker5.Value;
                param1.Add(myDiscreteValue1);
                info1.DataDefinition.ParameterFields["@fechafinal"].ApplyCurrentValues(param1);
                crystalReportViewer1.ReportSource = info1;  // descomentado


                //  SqlDataAdapter da = new SqlDataAdapter("buscarfechasrepo2", cn);
                // da.SelectCommand.CommandType = CommandType.StoredProcedure;
                // da.SelectCommand.Parameters.Add("@fechaini", SqlDbType.DateTime).Value = dateTimePicker2.Text;
                //  da.SelectCommand.Parameters.Add("@fechafinal", SqlDbType.DateTime).Value = dateTimePicker3.Text;
                crystalReportViewer1.Zoom(80);
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Datos incorrectos ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // MessageBox.Show(ex.Message);
            }
        }
    }
}
