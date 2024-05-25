using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
using System.Data.SqlClient;

namespace CapaNegocios
{
    public class Clsunico
    {
        private ClsConexionDatos M = new ClsConexionDatos();

        private int id;
        private String proceso;
        private int proce;
        

        private int idp;//tabla ingresos de procesos
        private String nombre;
        private int cedula;
        public Decimal minutos;
        public Decimal minutos2;
        private String observaciones;
        private int procesoi;
        private int estado;
        private DateTime fecha;
        private String nombree;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public String Proceso
        {
            get { return proceso; }
            set { proceso = value; }
        }
        public int Proce
        {
            get { return proce; }
            set { proce = value; }
        }


        public int Idp
        {
            get { return idp; }
            set { idp = value; }
        }
        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }
        public Decimal Minutos
        {
            get { return minutos; }
            set { minutos = value; }
        }
        public Decimal Minutos2
        {
            get { return minutos2; }
            set { minutos2 = value; }
        }
        public String Observacion
        {
            get { return observaciones; }
            set { observaciones = value; }
        }
        public int Procesoi
        {
            get { return procesoi; }
            set { procesoi = value; }
        }
        public int Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        public String Nombree
        {
            get { return nombree; }
            set { nombree = value; }
        }
        public String Registrar_proceso()
        {

            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            String mensj = "";
            try
            {
                //pasamos  todos los parametros de entrada

                lst.Add(new ClsMetodosEmpleados("@proceso", Proceso));
                lst.Add(new ClsMetodosEmpleados("@proce", Proce));
                
                lst.Add(new ClsMetodosEmpleados("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));

                M.EjecutarSP("registrar_tproceso", ref lst);
                mensj = lst[2].Valor.ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mensj;
        }
        public DataTable Listadoproceso()
        {
            return M.Listado("listartproceso", null);
        }
        public DataTable Buscarproceso(string objDatos)
        {
            DataTable dt = new DataTable();
            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            try
            {
               
                lst.Add(new ClsMetodosEmpleados("@Datos", objDatos));
                dt = M.Listado("filproceso", lst);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }
        public String Registrar_procesoempleado()
        {

            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            String mensj = "";
            try
            {
                //pasamos  todos los parametros de entrada

                lst.Add(new ClsMetodosEmpleados("@nombre", Nombre));
                lst.Add(new ClsMetodosEmpleados("@cedula", Cedula));
                lst.Add(new ClsMetodosEmpleados("@minutos", Minutos));
                lst.Add(new ClsMetodosEmpleados("@minutos2", Minutos2));
                lst.Add(new ClsMetodosEmpleados("@observaciones", Observacion));
                lst.Add(new ClsMetodosEmpleados("@proceso", Procesoi));
                lst.Add(new ClsMetodosEmpleados("@estado", Estado));
                lst.Add(new ClsMetodosEmpleados("@fecha", Fecha));
                lst.Add(new ClsMetodosEmpleados("@nombree", Nombree));

                lst.Add(new ClsMetodosEmpleados("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));

                M.EjecutarSP("registrar_tprocesoempleado", ref lst);
                mensj = lst[9].Valor.ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mensj;
        }
        public String Eliminartproceso()
        {
            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            String mensj = "";
            try
            {
                lst.Add(new ClsMetodosEmpleados("@id", Id));
                lst.Add(new ClsMetodosEmpleados("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));

                M.EjecutarSP("eliminatproceso", ref lst);
                mensj = lst[1].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mensj;
        }
        public DataTable Listadoprocesoempleado()
        {
            return M.Listado("listartprocesoempleado", null);
        }

      
    }
}
