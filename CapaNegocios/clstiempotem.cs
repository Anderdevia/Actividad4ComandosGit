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
   public class clstiempotem
    {
        private ClsConexionDatos M = new ClsConexionDatos();

        #region campos
        private int registro;
         private int cedula;
        private DateTime temporizador;
        private int hora;
        private int minutos;
        private int segundos;
        private char estado;


        #endregion

        #region propiedades
        public int Registro
        {
            get { return registro; }
            set { registro = value; }

        }
        public int Cedula
        {
            get { return cedula; }
            set { cedula = value; }

        }
        public DateTime Temporizador
        {
            get { return temporizador; }
            set { temporizador = value; }
        }
        public int Hora
        {
            get { return hora; }
            set { hora = value; }

        }
        public int Minutos
        {
            get { return minutos; }
            set { minutos = value; }

        }
        public int Segundos
        {
            get { return segundos; }
            set { segundos = value; }

        }
        public char Estado
        {
            get { return estado; }
            set { estado = value; }

        }
        #endregion


        public String Registrartiempotemp()
        {

            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            String mensj = "";
            try
            {
                //pasamos  todos los parametros de entrada

                lst.Add(new ClsMetodosEmpleados("@registro", Registro));
                lst.Add(new ClsMetodosEmpleados("@cedula", Cedula));
                lst.Add(new ClsMetodosEmpleados("@tiempo", Temporizador));
                lst.Add(new ClsMetodosEmpleados("@hora", Hora));
                lst.Add(new ClsMetodosEmpleados("@minutos", Minutos));
                lst.Add(new ClsMetodosEmpleados("@segundos", Segundos));
                lst.Add(new ClsMetodosEmpleados("@estado", Estado));


                lst.Add(new ClsMetodosEmpleados("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));

                M.EjecutarSP("registartiempotemp", ref lst);
                mensj = lst[6].Valor.ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mensj;

        }
        //metodo para listado del registro de horario
        public DataTable Listadotiempotemp()
        {
           // listartiempotemp
            return M.Listado("listartiempotemp", null);
        }
        public String Actualizartiemptemp()
        {

            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            String mensj = "";
            try
            {
                //pasamos  todos los parametros de entrada

                lst.Add(new ClsMetodosEmpleados("@registro", Registro));
                lst.Add(new ClsMetodosEmpleados("@cedula", Cedula));
                lst.Add(new ClsMetodosEmpleados("@tiempo", Temporizador));
                lst.Add(new ClsMetodosEmpleados("@hora", Hora));
                lst.Add(new ClsMetodosEmpleados("@minutos", Minutos));
                lst.Add(new ClsMetodosEmpleados("@segundos", Segundos));
                lst.Add(new ClsMetodosEmpleados("@estado", Estado));


                lst.Add(new ClsMetodosEmpleados("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));

                M.EjecutarSP("actualizartiempotemp", ref lst);
                mensj = lst[6].Valor.ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mensj;
        }
        public DataTable Buscartempo(int objDatos)
        {
            DataTable dt = new DataTable();
            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            try
            {
                lst.Add(new ClsMetodosEmpleados("@Datos", objDatos));
                dt = M.Listado("bustempo", lst);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }
        public DataTable Registroem(int objDatos)
        {
            DataTable dt = new DataTable();
            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            try
            {
                lst.Add(new ClsMetodosEmpleados("@Datos", objDatos));
                dt = M.Listado("bustempo", lst);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }
    }
}
