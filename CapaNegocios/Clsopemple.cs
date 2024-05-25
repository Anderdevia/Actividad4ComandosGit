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
   public class Clsopemple
    {
        private ClsConexionDatos M = new ClsConexionDatos();


        #region Campos
        private int id;
        private int cedula;
        private String nombreemple;
        private String cargo;
        
        private int opp1;
        private int idprendaop;
        private String nombreprendao;

        private int idopera;
       
        private String nombreoperaciono;
        private String descripcionpp1;
        private Decimal tiempopp;
        private int cantidadd;
        private Decimal totalpp;
        private String hora;
        private int sobremedidao;
        private int xso;
        private int so;
        private int mmo;
        private int lo;
        private int xlo;
        private int xxlo;
        private int t3xlo;
        private int t4xlo;
        private int t5xlo;
        private int t6xlo;
        
        private int estado;
        private DateTime fecha;
        private DateTime fechafin;



        #endregion

        #region Campos

        public int IdInicio
        {
            get { return id; }
            set { id = value; }
        }
        public int Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }
        public String Nombreemplea
        {
            get { return nombreemple; }
            set { nombreemple = value; }
        }
        public String Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }
        public int Opopera
        {
            get { return opp1; }
            set { opp1 = value; }
        }
        public int Idprenda
        {
            get { return idprendaop; }
            set { idprendaop = value; }
        }
        public String Nombrepren
        {
            get { return nombreprendao; }
            set { nombreprendao = value; }
        }



        public int Idoperacion
        {
            get { return idopera; }
            set { idopera = value; }
        }
        public String Nombreoperacion
        {
            get { return nombreoperaciono; }
            set { nombreoperaciono = value; }
        }
       
        public String Descripcionopera
        {
            get { return descripcionpp1; }
            set { descripcionpp1 = value; }
        }

        public Decimal Tiempoperac
        {
            get { return tiempopp; }
            set { tiempopp = value; }
        }
        public int Cantidadoperac
        {
            get { return cantidadd; }
            set { cantidadd = value; }
        }
        public Decimal Totaoperac
        {
            get { return totalpp; }
            set { totalpp = value; }
        }
        public String Hora
        {
            get { return hora; }
            set { hora = value; }
        }
        public int Sobremedidao
        {
            get { return sobremedidao; }
            set { sobremedidao = value; }
        }
        public int Xso
        {
            get { return xso; }
            set { xso = value; }
        }
        public int So
        {
            get { return so; }
            set { so = value; }
        }
        public int Mmo
        {
            get { return mmo; }
            set { mmo = value; }
        }
        public int Lo
        {
            get { return lo; }
            set { lo = value; }
        }
        public int Xlo
        {
            get { return xlo; }
            set { xlo = value; }
        }
        public int Xxlo
        {
            get { return xxlo; }
            set { xxlo = value; }
        }
        public int T3xlo
        {
            get { return t3xlo; }
            set { t3xlo = value; }
        }
        public int T4xlo
        {
            get { return t4xlo; }
            set { t4xlo = value; }
        }
        public int T5xlo
        {
            get { return t5xlo; }
            set { t5xlo = value; }
        }
        public int T6xlo
        {
            get { return t6xlo; }
            set { t6xlo = value; }
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
        public DateTime Fechafin
        {
            get { return fechafin; }
            set { fechafin = value; }
        }

        #endregion

        public String Registraroperacemple()
        {

            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            String mensj = "";
            try
            {
                //pasamos  todos los parametros de entrada
                lst.Add(new ClsMetodosEmpleados("@id", IdInicio));
                lst.Add(new ClsMetodosEmpleados("@cedula", Cedula));
                lst.Add(new ClsMetodosEmpleados("@nombreple", Nombreemplea));
                lst.Add(new ClsMetodosEmpleados("@cargo", Cargo));
                lst.Add(new ClsMetodosEmpleados("@opp1c", Opopera));
                lst.Add(new ClsMetodosEmpleados("@idpren", Idprenda));
                lst.Add(new ClsMetodosEmpleados("@nomprendac", Nombrepren));
                lst.Add(new ClsMetodosEmpleados("@idopera", Idoperacion));
                lst.Add(new ClsMetodosEmpleados("@nombre_operaciono", Nombreoperacion));
                lst.Add(new ClsMetodosEmpleados("@descripcionop", Descripcionopera));
                lst.Add(new ClsMetodosEmpleados("@tiempopp", Tiempoperac));
                lst.Add(new ClsMetodosEmpleados("@cantidadop", Cantidadoperac));
                lst.Add(new ClsMetodosEmpleados("@totalop", Totaoperac));
                lst.Add(new ClsMetodosEmpleados("@hora", Hora));
                lst.Add(new ClsMetodosEmpleados("@sobremedidao", Sobremedidao));
                lst.Add(new ClsMetodosEmpleados("@XSo", Xso));
                lst.Add(new ClsMetodosEmpleados("@So", So));
                lst.Add(new ClsMetodosEmpleados("@Mo", Mmo));
                lst.Add(new ClsMetodosEmpleados("@Lo", Lo));
                lst.Add(new ClsMetodosEmpleados("@XLo", Xlo));
                lst.Add(new ClsMetodosEmpleados("@XXLo", Xxlo));
                lst.Add(new ClsMetodosEmpleados("@_3XLo", T3xlo));
                lst.Add(new ClsMetodosEmpleados("@_4XLo", T4xlo));
                lst.Add(new ClsMetodosEmpleados("@_5XLo", T5xlo));
                lst.Add(new ClsMetodosEmpleados("@_6XLo", T6xlo));
                lst.Add(new ClsMetodosEmpleados("@estado", Estado));
                lst.Add(new ClsMetodosEmpleados("@fecha", Fecha));
                
                lst.Add(new ClsMetodosEmpleados("@fechafin", Fechafin));

                lst.Add(new ClsMetodosEmpleados("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));

                M.EjecutarSP("registraroperaemple", ref lst);
                mensj = lst[28].Valor.ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mensj;
        }
        public String Actualizaroperaemple()
        {

            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            String mensj = "";
            try
            {
                //pasamos  todos los parametros de entrada

                //pasamos  todos los parametros de entrada
                lst.Add(new ClsMetodosEmpleados("@id", IdInicio));
                lst.Add(new ClsMetodosEmpleados("@cedula", Cedula));
                lst.Add(new ClsMetodosEmpleados("@nombreple", Nombreemplea));
                lst.Add(new ClsMetodosEmpleados("@cargo", Cargo));
                lst.Add(new ClsMetodosEmpleados("@opp1c", Opopera));
                lst.Add(new ClsMetodosEmpleados("@idpren", Idprenda));
                lst.Add(new ClsMetodosEmpleados("@nomprendac", Nombrepren));
                lst.Add(new ClsMetodosEmpleados("@idopera", Idoperacion));
                lst.Add(new ClsMetodosEmpleados("@nombre_operaciono", Nombreoperacion));
                lst.Add(new ClsMetodosEmpleados("@descripcionop", Descripcionopera));
                lst.Add(new ClsMetodosEmpleados("@tiempopp", Tiempoperac));
                lst.Add(new ClsMetodosEmpleados("@cantidadop", Cantidadoperac));
                lst.Add(new ClsMetodosEmpleados("@totalop", Totaoperac));
                lst.Add(new ClsMetodosEmpleados("@hora", Hora));
                lst.Add(new ClsMetodosEmpleados("@sobremedidao", Sobremedidao));
                lst.Add(new ClsMetodosEmpleados("@XSo", Xso));
                lst.Add(new ClsMetodosEmpleados("@So", So));
                lst.Add(new ClsMetodosEmpleados("@Mo", Mmo));
                lst.Add(new ClsMetodosEmpleados("@Lo", Lo));
                lst.Add(new ClsMetodosEmpleados("@XLo", Xlo));
                lst.Add(new ClsMetodosEmpleados("@XXLo", Xxlo));
                lst.Add(new ClsMetodosEmpleados("@_3XLo", T3xlo));
                lst.Add(new ClsMetodosEmpleados("@_4XLo", T4xlo));
                lst.Add(new ClsMetodosEmpleados("@_5XLo", T5xlo));
                lst.Add(new ClsMetodosEmpleados("@_6XLo", T6xlo));
                lst.Add(new ClsMetodosEmpleados("@estado", Estado));
                lst.Add(new ClsMetodosEmpleados("@fecha", Fecha));

                lst.Add(new ClsMetodosEmpleados("@fechafin", Fechafin));

                lst.Add(new ClsMetodosEmpleados("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));

                M.EjecutarSP("actualizaopemple", ref lst);
                mensj = lst[28].Valor.ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mensj;
        }
        public String Eliminaroperaemple()
        {
            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            String mensj = "";
            try
            {
                lst.Add(new ClsMetodosEmpleados("@id", IdInicio));
                lst.Add(new ClsMetodosEmpleados("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));

                M.EjecutarSP("eliminaropemple", ref lst);
                mensj = lst[1].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mensj;
        }
        public String Eliminaroperaemplecedu()
        {
            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            String mensj = "";
            try
            {
                lst.Add(new ClsMetodosEmpleados("@cedula", Cedula));
                lst.Add(new ClsMetodosEmpleados("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));

                M.EjecutarSP("eliminaropemplecedu", ref lst);
                mensj = lst[1].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mensj;
        }
        public String Eliminaroperaempletotal()
        {
            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            String mensj = "";
            try
            {
               // lst.Add(new ClsMetodosEmpleados("@cedula", Cedula));
                lst.Add(new ClsMetodosEmpleados("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));

                M.EjecutarSP("eliminaropempletotal", ref lst);
                mensj = lst[1].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mensj;
        }
        public DataTable Buscaroperaemple(int objDatos)
        {
            DataTable dt = new DataTable();
            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            try
            {
                lst.Add(new ClsMetodosEmpleados("@Datos", objDatos));

                dt = M.Listado("buscaropemple", lst);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }
        public DataTable Buscareop(int objDatos)
        {
            DataTable dt = new DataTable();
            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            try
            {
                lst.Add(new ClsMetodosEmpleados("@Datos", objDatos));

                dt = M.Listado("buscarope", lst);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }
        //la ope que se muestra y se copia ala tabla de una sola vez
        public DataTable Buscacedu(int objDatos)
        {
            DataTable dt = new DataTable();
            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            try
            {
                lst.Add(new ClsMetodosEmpleados("@Datos", objDatos));

                dt = M.Listado("buscaropcedu", lst);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }
        public DataTable Listadooperaemple()
        {
            return M.Listado("listar_opempl", null);
        }

        public String Actualiza1()
        {

            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            String mensj = "";
            try
            {
                //pasamos  todos los parametros de entrada
                lst.Add(new ClsMetodosEmpleados("@id", IdInicio));



                lst.Add(new ClsMetodosEmpleados("@estado", Estado));

                lst.Add(new ClsMetodosEmpleados("@fechafin", Fechafin));


                lst.Add(new ClsMetodosEmpleados("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));

                M.EjecutarSP("actuaopyemple2", ref lst);
                mensj = lst[3].Valor.ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mensj;
        }
    }
}
