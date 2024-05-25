using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDatos;
using System.Data;


namespace CapaNegocios
{
    public class ClsReglasEmpleados
    {
        //resgistrar empleados
       
        ClsConexionDatos M = new ClsConexionDatos();  //agregamos la referencia al clsmetodos empleados
        //registrar empleados
        public String Registrar_empleados(ClsTBL_EMPLEADOS objTblEmpleados)
        {
            String mensj = "";
            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            try
            {
                //pasamos todos los parametros de entrada
                lst.Add(new ClsMetodosEmpleados("@cedula", objTblEmpleados.Cedula));
                lst.Add(new ClsMetodosEmpleados("@nombre", objTblEmpleados.Nombre));
                lst.Add(new ClsMetodosEmpleados("@area", objTblEmpleados.Area));
                lst.Add(new ClsMetodosEmpleados("@cargo", objTblEmpleados.Cargo));
                lst.Add(new ClsMetodosEmpleados("@modalidad", objTblEmpleados.Modalidad));
                lst.Add(new ClsMetodosEmpleados("@fecha_de_ingreso", objTblEmpleados.Fecha_de_ingreso));
                lst.Add(new ClsMetodosEmpleados("@dia", objTblEmpleados.Dia));
                lst.Add(new ClsMetodosEmpleados("@sexo", objTblEmpleados.Sexo));
                lst.Add(new ClsMetodosEmpleados("@pro", objTblEmpleados.Pro));
                //pasamos los parametri de salida
                lst.Add(new ClsMetodosEmpleados("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 100));

                M.EjecutarSP("registrar_empleados", ref lst);
                mensj = lst[9].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return mensj;
        }
        //metodo para listado de empleados
        public DataTable ListadoEmpleados()
        {
            return M.Listado("listar_empleados", null);
        }

        public String EliminarRegistro(ClsTBL_EMPLEADOS objTblEmpleados)
        {
            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            String mensj = "";
            try
            {
                lst.Add(new ClsMetodosEmpleados("@cedula", objTblEmpleados.Cedula));
                lst.Add(new ClsMetodosEmpleados("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 100));
                M.EjecutarSP("eliminarregistros", ref lst);
                mensj = lst[1].Valor.ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mensj;
        }
        public String ActualizarDatos(ClsTBL_EMPLEADOS objTblEmpleados)
        {
            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            String mensj = "";
            try
            {
                lst.Add(new ClsMetodosEmpleados("@cedula", objTblEmpleados.Cedula));
                lst.Add(new ClsMetodosEmpleados("@nombre", objTblEmpleados.Nombre));
                lst.Add(new ClsMetodosEmpleados("@area", objTblEmpleados.Area));
                lst.Add(new ClsMetodosEmpleados("@cargo", objTblEmpleados.Cargo));
                lst.Add(new ClsMetodosEmpleados("@modalidad", objTblEmpleados.Modalidad));
                lst.Add(new ClsMetodosEmpleados("@fecha_de_ingreso", objTblEmpleados.Fecha_de_ingreso));
                lst.Add(new ClsMetodosEmpleados("@dia", objTblEmpleados.Dia));
                lst.Add(new ClsMetodosEmpleados("@sexo", objTblEmpleados.Sexo));
                lst.Add(new ClsMetodosEmpleados("@pro", objTblEmpleados.Pro));
                lst.Add(new ClsMetodosEmpleados("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 100));
                M.EjecutarSP("actualizardatos", ref lst);
                mensj = lst[9].Valor.ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mensj;
        }

        public DataTable BuscarEmpleados(String objTblEmpleados)
        {
            DataTable dt = new DataTable();
            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            try
            {
                lst.Add(new ClsMetodosEmpleados("@cedula", objTblEmpleados));
                dt = M.Listado("buscarempleados", lst);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }


    }
}