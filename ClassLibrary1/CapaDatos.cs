using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using CapaEntidades;



namespace CapaDatos
{
    public class ClsConexionDatos
    {
        //varianbles
        SqlConnection objCnn = new SqlConnection();
        string objCadenaCnn = string.Empty;

      

        public void Desconectar()
        {
            if (objCnn.State == ConnectionState.Open)
                objCnn.Close();
        }
        public SqlConnection Conectar()
        {
            try
            {
                //trae la cadena de conexion del archivo App.config
                objCadenaCnn = ConfigurationManager.ConnectionStrings["CnnORDEN"].ConnectionString;
                
               
                objCnn = new SqlConnection(objCadenaCnn);
                objCnn.Open();
                return objCnn;
            }
            catch (System.Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }



        //metodos para ejecutar sp(insert,delete,update)
        public DataTable Listado(String NombreSP, List<ClsMetodosEmpleados> lst)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da;
            try
            {
                Conectar();
                da = new SqlDataAdapter(NombreSP, objCnn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                if (lst != null)
                {
                    for (int i = 0; i < lst.Count; i++)
                    {
                        da.SelectCommand.Parameters.AddWithValue(lst[i].Nombre, lst[i].Valor);
                    }
                }
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            Desconectar();
            return dt;
        }

        public void EjecutarSP(String NombreSP, ref List<ClsMetodosEmpleados> lst)
        {
            SqlCommand cmd;
            try
            {
                Conectar();
                cmd = new SqlCommand(NombreSP, objCnn);
                cmd.CommandType = CommandType.StoredProcedure;
                if (lst != null)
                {
                    for (int i = 0; i < lst.Count; i++)
                    {
                        if (lst[i].Direccion == ParameterDirection.Input)
                            cmd.Parameters.AddWithValue(lst[i].Nombre, lst[i].Valor);
                        if (lst[i].Direccion == ParameterDirection.Output)
                            cmd.Parameters.Add(lst[i].Nombre, lst[i].TipoDato, lst[i].Tamaño).Direction = ParameterDirection.Output;
                    }
                    cmd.ExecuteNonQuery();
                    for (int i = 0; i < lst.Count; i++)
                    {
                        if (cmd.Parameters[i].Direction == ParameterDirection.Output)
                            lst[i].Valor = cmd.Parameters[i].Value;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            Desconectar();
        }

    }
}
