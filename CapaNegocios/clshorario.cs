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
    public class clshorario
    {
        private ClsConexionDatos M = new ClsConexionDatos();

        #region campos
        private int id;
        private int cedula;
        private String nombre;
        private String horario;
        private String dia;
        private DateTime fechaod;
        private DateTime horaentrada;
        private DateTime horasalida;
        private Decimal improd;
        private Decimal mdia;
        private Decimal totalminutos;
        private Decimal sin;

        private int estado;

        private int ide;
        private int cedulae;

        public int Ide
        {
            get { return ide; }
            set { ide = value; }
        }
        public int Cedulae
        {
            get { return cedulae; }
            set { cedulae = value; }
        }

        #endregion

        #region propiedades
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int Cedulaem
        {
            get { return cedula; }
            set { cedula = value; }
        }
        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public String Horario
        {
            get { return horario; }
            set { horario = value; }
        }
        public String Dia
        {
            get { return dia; }
            set { dia = value; }
        }
        public DateTime Fecha
        {
            get { return fechaod; }
            set { fechaod = value; }
        }
        public DateTime Horaentrada

        {
            get { return horaentrada; }
            set { horaentrada = value; }
        }
        public DateTime Horasalida

        {
            get { return horasalida; }
            set { horasalida = value; }
        }
       
        public decimal Improd
        {
            get { return improd; }
            set { improd = value; }
        }
        public decimal Mdia
        {
            get { return mdia; }
            set { mdia = value; }
        }
        public decimal Totalminutos
        {
            get { return totalminutos; }
            set { totalminutos = value; }
        }
        
        public int Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        public decimal Sin
        {
            get { return sin; }
            set { sin = value; }
        }

        #endregion

        public String Registrarhorario()
        {

            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            String mensj = "";
            try
            {
                //pasamos  todos los parametros de entrada
           
                lst.Add(new ClsMetodosEmpleados("@cedula", Cedulaem));
                lst.Add(new ClsMetodosEmpleados("@nombre", nombre));
                lst.Add(new ClsMetodosEmpleados("@horario", Horario));
                lst.Add(new ClsMetodosEmpleados("@dia", Dia));
                lst.Add(new ClsMetodosEmpleados("@fechaod", Fecha));
                lst.Add(new ClsMetodosEmpleados("@hora_entrada", Horaentrada));
                lst.Add(new ClsMetodosEmpleados("@hora_salida", Horasalida));
                lst.Add(new ClsMetodosEmpleados("@improd", Improd));
                lst.Add(new ClsMetodosEmpleados("@total_dia", Mdia));
                lst.Add(new ClsMetodosEmpleados("@total_minutos", Totalminutos));
                
                lst.Add(new ClsMetodosEmpleados("@estado", Estado));
                lst.Add(new ClsMetodosEmpleados("@sinminutos", Sin));



                lst.Add(new ClsMetodosEmpleados("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));

                M.EjecutarSP("registrarhorario", ref lst);
                mensj = lst[12].Valor.ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mensj;

        }
        public String Actualizarhorario()
        {

            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            String mensj = "";
            try
            {
                //pasamos  todos los parametros de entrada
                
                lst.Add(new ClsMetodosEmpleados("@cedula", Cedulaem));
                lst.Add(new ClsMetodosEmpleados("@nombre", nombre));
                lst.Add(new ClsMetodosEmpleados("@horario", Horario));
                lst.Add(new ClsMetodosEmpleados("@dia", Dia));
                lst.Add(new ClsMetodosEmpleados("@fechaod", Fecha));
                lst.Add(new ClsMetodosEmpleados("@hora_entrada", Horaentrada));
                lst.Add(new ClsMetodosEmpleados("@hora_salida", Horasalida));
                lst.Add(new ClsMetodosEmpleados("@improd", Improd));
                lst.Add(new ClsMetodosEmpleados("@total_dia", Mdia));
                lst.Add(new ClsMetodosEmpleados("@total_minutos", Totalminutos));                
                lst.Add(new ClsMetodosEmpleados("@estado", Estado));


                lst.Add(new ClsMetodosEmpleados("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));

                M.EjecutarSP("actualizarhorario", ref lst);
                mensj = lst[11].Valor.ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mensj;

        }
        public String Eliminarhorario()
        {
            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            String mensj = "";
            try
            {
                lst.Add(new ClsMetodosEmpleados("@ide", Id));
                lst.Add(new ClsMetodosEmpleados("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));

                M.EjecutarSP("eliminarhorario1", ref lst);
                mensj = lst[1].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mensj;
        }
        public String Eliminarhorariocedu()
        {
            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            String mensj = "";
            try
            {
                lst.Add(new ClsMetodosEmpleados("@cedula", Cedulaem));
                lst.Add(new ClsMetodosEmpleados("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));

                M.EjecutarSP("eliminarhorariodecula", ref lst);
                mensj = lst[1].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mensj;
        }
        public String Eliminarhorarcedue()
        {
            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            String mensj = "";
            try
            {
                lst.Add(new ClsMetodosEmpleados("@cedula", Cedulae));
                lst.Add(new ClsMetodosEmpleados("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));

                M.EjecutarSP("eliminhorariocedul", ref lst);
                mensj = lst[1].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mensj;
        }
        public String Eliminarhorarioid()
        {
            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            String mensj = "";
            try
            {
                lst.Add(new ClsMetodosEmpleados("@ide", Ide));
                lst.Add(new ClsMetodosEmpleados("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));

                M.EjecutarSP("eliminhorarioid", ref lst);
                mensj = lst[1].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mensj;
        }
        public String Eliminarhorariototal2()
        {
            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            String mensj = "";
            try
            {
                //lst.Add(new ClsMetodosEmpleados("@ide", Id));
                lst.Add(new ClsMetodosEmpleados("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));

                M.EjecutarSP("elimihorariototal", ref lst);
                mensj = lst[0].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mensj;
        }
        public DataTable Buscarhorario(int objDatos)
        {
            DataTable dt = new DataTable();
            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            try
            {
                lst.Add(new ClsMetodosEmpleados("@Datos", objDatos));

                dt = M.Listado("buscarhorario", lst);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }
        public DataTable Buscarhorariocedu(int objDatos)
        {
            DataTable dt = new DataTable();
            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            try
            {
                lst.Add(new ClsMetodosEmpleados("@Datos", objDatos));

                dt = M.Listado("buscarhorarioce", lst);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }
        //metodo para listado del registro de horario
        public DataTable Listadohorario()
        {
            return M.Listado("listarhorario", null);
        }
        public DataTable verminutos()
        {
            return M.Listado("verminu", null);
        }
        public String Actualiza1()
        {

            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            String mensj = "";
            try
            {
                //pasamos  todos los parametros de entrada
                lst.Add(new ClsMetodosEmpleados("@ide", Id));               

                lst.Add(new ClsMetodosEmpleados("@fechaod", Fecha));
                lst.Add(new ClsMetodosEmpleados("@estado", Estado));


                lst.Add(new ClsMetodosEmpleados("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));

                M.EjecutarSP("actualihorari", ref lst);
                mensj = lst[3].Valor.ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mensj;
        }
        public String Elimireporttotal()
        {
            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            String mensj = "";
            try
            {
                // lst.Add(new ClsMetodosEmpleados("@cedulaid", Cedula));
                lst.Add(new ClsMetodosEmpleados("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));

                M.EjecutarSP("elimipusutotalhora", ref lst);
                mensj = lst[0].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mensj;
        }
    }
}
