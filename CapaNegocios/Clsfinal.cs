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
   public class Clsfinal
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
        private String categoria;
        private Decimal tiempopp;
        private int cantidadd;
        private Decimal totalpp;
        private String hora;
        private DateTime fechaini;
        private DateTime fechafin;
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
        private DateTime fecha;
        private int estado;
        private int numero;


        private int valor1;
        private int valor2;
        private int valor3;
        private int valor4;
        private int valor5;
        private int valor6;
        private int valor7;
        private int valor8;
        private int valor9;

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

        public String Categoria
        {
            get { return categoria; }
            set { categoria = value; }
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
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        public int Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }




        public int Valor1
        {
            get { return valor1; }
            set { valor1 = value; }
        }
        public int Valor2
        {
            get { return valor2; }
            set { valor2 = value; }
        }
        public int Valor3
        {
            get { return valor3; }
            set { valor3 = value; }
        }
        public int Valor4
        {
            get { return valor4; }
            set { valor4 = value; }
        }
        public int Valor5
        {
            get { return valor5; }
            set { valor5 = value; }
        }
        public int Valor6
        {
            get { return valor6; }
            set { valor6 = value; }
        }
        public int Valor7
        {
            get { return valor7; }
            set { valor7 = value; }
        }
        public int Valor8
        {
            get { return valor8; }
            set { valor8 = value; }
        }
        public int Valor9
        {
            get { return valor9; }
            set { valor9 = value; }
        }
       


        #endregion

        public String Registrfinal()
        {

            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            String mensj = "";
            try
            {
                //pasamos  todos los parametros de entrada
                //lst.Add(new ClsMetodosEmpleados("@idi", IdInicio));
                lst.Add(new ClsMetodosEmpleados("@cedula", Cedula));
                lst.Add(new ClsMetodosEmpleados("@nombreple", Nombreemplea));
                lst.Add(new ClsMetodosEmpleados("@cargo", Cargo));
                lst.Add(new ClsMetodosEmpleados("@opp1c", Opopera));
                lst.Add(new ClsMetodosEmpleados("@idpren", Idprenda));
                lst.Add(new ClsMetodosEmpleados("@nomprendac", Nombrepren));
                lst.Add(new ClsMetodosEmpleados("@idopera", Idoperacion));
                lst.Add(new ClsMetodosEmpleados("@nombre_operaciono", Nombreoperacion));
                lst.Add(new ClsMetodosEmpleados("@categoria", Categoria));
                lst.Add(new ClsMetodosEmpleados("@tiempopp", Tiempoperac));
                lst.Add(new ClsMetodosEmpleados("@cantidadop", Cantidadoperac));
                lst.Add(new ClsMetodosEmpleados("@totalop", Totaoperac));
                lst.Add(new ClsMetodosEmpleados("@hora", Hora));
                lst.Add(new ClsMetodosEmpleados("@fechaini", Fechaini));
                lst.Add(new ClsMetodosEmpleados("@fechafin", Fechafin));
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
                lst.Add(new ClsMetodosEmpleados("@fechaid", Fecha));
                lst.Add(new ClsMetodosEmpleados("@estado", Estado));
                lst.Add(new ClsMetodosEmpleados("@numero", Numero));

                lst.Add(new ClsMetodosEmpleados("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));

                M.EjecutarSP("registraoperafin1", ref lst);
                mensj = lst[29].Valor.ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mensj;
        }
        public String Actualifinal()
        {

            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            String mensj = "";
            try
            {
                //pasamos  todos los parametros de entrada

                //pasamos  todos los parametros de entrada
                lst.Add(new ClsMetodosEmpleados("@idi", IdInicio));
                lst.Add(new ClsMetodosEmpleados("@cedula", Cedula));
                lst.Add(new ClsMetodosEmpleados("@nombreple", Nombreemplea));
                lst.Add(new ClsMetodosEmpleados("@cargo", Cargo));
                lst.Add(new ClsMetodosEmpleados("@opp1c", Opopera));
                lst.Add(new ClsMetodosEmpleados("@idpren", Idprenda));
                lst.Add(new ClsMetodosEmpleados("@nomprendac", Nombrepren));
                lst.Add(new ClsMetodosEmpleados("@idopera", Idoperacion));
                lst.Add(new ClsMetodosEmpleados("@nombre_operaciono", Nombreoperacion));
                lst.Add(new ClsMetodosEmpleados("@categoria", Categoria));
                lst.Add(new ClsMetodosEmpleados("@tiempopp", Tiempoperac));
                lst.Add(new ClsMetodosEmpleados("@cantidadop", Cantidadoperac));
                lst.Add(new ClsMetodosEmpleados("@totalop", Totaoperac));
                lst.Add(new ClsMetodosEmpleados("@hora", Hora));
                lst.Add(new ClsMetodosEmpleados("@fechaini", Fechaini));
                lst.Add(new ClsMetodosEmpleados("@fechafin", Fechafin));
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
                lst.Add(new ClsMetodosEmpleados("@fechaid", Fecha));
                lst.Add(new ClsMetodosEmpleados("@estado", Estado));
                lst.Add(new ClsMetodosEmpleados("@numero", Numero));

                lst.Add(new ClsMetodosEmpleados("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));

                M.EjecutarSP("actualoperafin1", ref lst);
                mensj = lst[29].Valor.ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mensj;
        }
        public DataTable Listadopfin()
        {
            return M.Listado("listaoperafin", null);
        }
        public String Eliminafinal()
        {
            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            String mensj = "";
            try
            {
                lst.Add(new ClsMetodosEmpleados("@idi", IdInicio));
                lst.Add(new ClsMetodosEmpleados("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));

                M.EjecutarSP("elimioperafin1", ref lst);
                mensj = lst[1].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mensj;
        }
        public String Eliminafinalcedu()
        {
            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            String mensj = "";
            try
            {
                lst.Add(new ClsMetodosEmpleados("@cedula", Cedula));
                lst.Add(new ClsMetodosEmpleados("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));

                M.EjecutarSP("elimioperafincedula", ref lst);
                mensj = lst[1].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mensj;
        }
        public String Eliminoperafintotal()
        {
            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            String mensj = "";
            try
            {
                //lst.Add(new ClsMetodosEmpleados("@ide", Id));
                lst.Add(new ClsMetodosEmpleados("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));

                M.EjecutarSP("elimihorariototaloperafin", ref lst);
                mensj = lst[0].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mensj;
        }
        public DataTable Buscaropfinale(int objDatos)
        {
            DataTable dt = new DataTable();
            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            try
            {
                lst.Add(new ClsMetodosEmpleados("@Datos", objDatos));

                dt = M.Listado("busoperafin", lst);
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

                dt = M.Listado("buscaoperafin", lst);
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

                dt = M.Listado("busoperafincedu", lst);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }
        public DataTable Listadooperaemple()
        {
            return M.Listado("listaoperafin", null);
        }
        public String Actualivalidacion()
        {

            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            String mensj = "";
            try
            {
                //pasamos  todos los parametros de entrada

                //pasamos  todos los parametros de entrada
                lst.Add(new ClsMetodosEmpleados("@valor1", Valor1));
                lst.Add(new ClsMetodosEmpleados("@valor2", Valor2));
                lst.Add(new ClsMetodosEmpleados("@valor3", Valor3));
                lst.Add(new ClsMetodosEmpleados("@valor4", Valor4));
                lst.Add(new ClsMetodosEmpleados("@valor5", Valor5));
                lst.Add(new ClsMetodosEmpleados("@valor6", Valor6));
                lst.Add(new ClsMetodosEmpleados("@valor7", Valor7));
                lst.Add(new ClsMetodosEmpleados("@valor8", Valor8));
                lst.Add(new ClsMetodosEmpleados("@valor9", Valor9));



                lst.Add(new ClsMetodosEmpleados("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));

                M.EjecutarSP("actualizardatosvalida", ref lst);
                mensj = lst[9].Valor.ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mensj;
        }
        public DataTable Buscarvalida(int objDatos)
        {
            DataTable dt = new DataTable();
            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            try
            {
                lst.Add(new ClsMetodosEmpleados("@Datos", objDatos));

                dt = M.Listado("buscarvalidacion", lst);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }
        public String Regisnuevo()
        {

            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            String mensj = "";
            try
            {
                //pasamos  todos los parametros de entrada
                //lst.Add(new ClsMetodosEmpleados("@idi", IdInicio));
                lst.Add(new ClsMetodosEmpleados("@cedula", Cedula));
                lst.Add(new ClsMetodosEmpleados("@nombre", Nombreemplea));
                lst.Add(new ClsMetodosEmpleados("@fecha", Fecha));
                lst.Add(new ClsMetodosEmpleados("@estado", Estado));

                lst.Add(new ClsMetodosEmpleados("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));

                M.EjecutarSP("registranuevoregistro", ref lst);
                mensj = lst[4].Valor.ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mensj;
        }
        public String Eliminanuevo()
        {
            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            String mensj = "";
            try
            {
                lst.Add(new ClsMetodosEmpleados("@id", IdInicio));
                lst.Add(new ClsMetodosEmpleados("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));

                M.EjecutarSP("eliminarnuevoregistro", ref lst);
                mensj = lst[1].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mensj;
        }
        public DataTable Listanumero()
        {
            return M.Listado("SP_Ultimo_Registro", null);
        }
        public String Aceptado()
        {

            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            String mensj = "";
            try
            {
                //pasamos  todos los parametros de entrada
                lst.Add(new ClsMetodosEmpleados("@id", IdInicio));
                lst.Add(new ClsMetodosEmpleados("@cedula", Cedula));
       
               lst.Add(new ClsMetodosEmpleados("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));

                M.EjecutarSP("aceptado", ref lst);
              mensj = lst[2].Valor.ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mensj;
        }
        public DataTable Listanu()
        {
            return M.Listado("aceptado", null);
        }
        public DataTable Buscarnuevo(int objDatos)
        {
            DataTable dt = new DataTable();
            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            try
            {
                lst.Add(new ClsMetodosEmpleados("@id", objDatos));

                dt = M.Listado("busnuevo", lst);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }

    }

}
