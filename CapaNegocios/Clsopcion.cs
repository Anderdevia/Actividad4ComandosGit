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
    public class Clsopcion
    {

        private ClsConexionDatos M = new ClsConexionDatos();

        #region campos
        private int id;
        private int cedula;
        private String nombre;
        private String nombreopera;
        private String categoria;
        private int cantidad;
        private DateTime fecha;
        private DateTime fechaini;
        private DateTime fechafin;

        private Decimal minutotal;
       

        #endregion
        #region propiedades



        public int Id
        {
            get { return id; }
            set { id = value; }

        }
        public int Cedula
        {
            get { return cedula; }
            set { cedula = value; }

        }
        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }

        }
        public String Nombreopera
        {
            get { return nombreopera; }
            set { nombreopera = value; }

        }
        public String Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }
        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }

        }
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }

        }
        public DateTime Fechaini
        {
            get { return fechaini; }
            set { fechaini = value; }

        }
        public DateTime Fechafin
        {
            get { return fechafin; }
            set { fechafin = value; }

        }

        public decimal Minutotal
        {
            get { return minutotal; }
            set { minutotal = value; }

        }

        #endregion
        public String Registrarope()
        {

            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            String mensj = "";
            try
            {
                //pasamos  todos los parametros de entrada

                lst.Add(new ClsMetodosEmpleados("@id", Id));
                lst.Add(new ClsMetodosEmpleados("@cedula", Cedula));
                lst.Add(new ClsMetodosEmpleados("@nombre", Nombre));
                lst.Add(new ClsMetodosEmpleados("@nombreopera", Nombreopera));               
                lst.Add(new ClsMetodosEmpleados("@categoria", Categoria));
                lst.Add(new ClsMetodosEmpleados("@cantidad", Cantidad));
                lst.Add(new ClsMetodosEmpleados("@fecha", Fecha));
                lst.Add(new ClsMetodosEmpleados("@horaini", Fechaini));
                lst.Add(new ClsMetodosEmpleados("@horafin", Fechafin));              
                lst.Add(new ClsMetodosEmpleados("@total_minutos", Minutotal));



                lst.Add(new ClsMetodosEmpleados("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));

                M.EjecutarSP("registraopc", ref lst);
                mensj = lst[10].Valor.ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mensj;

        }
        public String Actualizarope()
        {

            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            String mensj = "";
            try
            {
                //pasamos  todos los parametros de entrada

                lst.Add(new ClsMetodosEmpleados("@id", Id));
                lst.Add(new ClsMetodosEmpleados("@cedula", Cedula));
                lst.Add(new ClsMetodosEmpleados("@nombre", Nombre));
                lst.Add(new ClsMetodosEmpleados("@nombreopera", Nombreopera));
                lst.Add(new ClsMetodosEmpleados("@categoria", Categoria));
                lst.Add(new ClsMetodosEmpleados("@cantidad", Cantidad));
                lst.Add(new ClsMetodosEmpleados("@fecha", Fecha));
                lst.Add(new ClsMetodosEmpleados("@horaini", Fechaini));
                lst.Add(new ClsMetodosEmpleados("@horafin", Fechafin));
                lst.Add(new ClsMetodosEmpleados("@total_minutos", Minutotal));


                lst.Add(new ClsMetodosEmpleados("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));

                M.EjecutarSP("actualizaropci", ref lst);
                mensj = lst[10].Valor.ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mensj;
        }
        //metodo para listado del registro de opcion
        public DataTable Listado1()
        {
            // listartiempotemp
            return M.Listado("listaropc", null);
        }
        public String Eliminarop1()
        {
            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            String mensj = "";
            try
            {
                lst.Add(new ClsMetodosEmpleados("@id", Id));
                lst.Add(new ClsMetodosEmpleados("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));

                M.EjecutarSP("eliminaopc", ref lst);
                mensj = lst[1].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mensj;
        }
        public DataTable Buscaid(int objDatos)
        {
            DataTable dt = new DataTable();
            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            try
            {
                lst.Add(new ClsMetodosEmpleados("@Datos", objDatos));
                dt = M.Listado("buscaopcid", lst);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }
        public DataTable Buscacedu(int objDatos)
        {
            DataTable dt = new DataTable();
            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            try
            {
                lst.Add(new ClsMetodosEmpleados("@Datos", objDatos));
                dt = M.Listado("buscaopcedu", lst);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }

    }
}
