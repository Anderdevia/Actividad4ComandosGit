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
    public class clsopinterna
    {
        private ClsConexionDatos M = new ClsConexionDatos();


        #region Campos

        private int op;
        private String nombrep;
        private String descripcionmodi;

        private String categoria;
        private Decimal tiempomodi;
        private int cantidad;

        private Decimal totalmodi;
        private int sobremedida;
        private int xs;
        private int s;
        private int mm;
        private int l;
        private int xl;
        private int xxl;
        private int t3xl;
        private int t4xl;
        private int t5xl;
        private int t6xl;

        private Double date;
        #endregion
        #region Campos
        private int id;
        private int cedula;
        private String nombreemple;
        private String cargo;

        private int opp1;
        private int idprendaop;
        private String nombreprendao;

        private String nombreoperaciono;
        private String descripcionpp1;
        private Decimal tiempopp;
        private int cantidadd;
        private Decimal totalpp;
        private string hora;
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
        private DateTime fechaini;
        private DateTime fechafin;


        #endregion

        #region Campos
        private int id1;

        private int estado1;

        private DateTime fechafin1;


        public int Id1
        {
            get { return id1; }
            set { id1 = value; }
        }
        public int Estado1
        {
            get { return estado1; }
            set { estado1 = value; }
        }
        public DateTime Fechafin1
        {
            get { return fechafin1; }
            set { fechafin1 = value; }
        }
        #endregion
        #region propiedades






        public int OP
        {
            get { return op; }
            set { op = value; }
        }
        public String Nombrep
        {
            get { return nombrep; }
            set { nombrep = value; }
        }
        public String Descripcionmodi
        {
            get { return descripcionmodi; }
            set { descripcionmodi = value; }
        }
        public String Categoriamodi
        {
            get { return categoria; }
            set { categoria = value; }
        }
        public Decimal Tiempomodi
        {
            get { return tiempomodi; }
            set { tiempomodi = value; }
        }


        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        public Decimal Totalmodi
        {
            get { return totalmodi; }
            set { totalmodi = value; }
        }

        public int Sobremedida
        {
            get { return sobremedida; }
            set { sobremedida = value; }
        }
        public int Xs
        {
            get { return xs; }
            set { xs = value; }
        }
        public int S
        {
            get { return s; }
            set { s = value; }
        }
        public int Mm
        {
            get { return mm; }
            set { mm = value; }
        }
        public int L
        {
            get { return l; }
            set { l = value; }
        }
        public int Xl
        {
            get { return xl; }
            set { xl = value; }
        }
        public int Xxl
        {
            get { return xxl; }
            set { xxl = value; }
        }
        public int T3xl
        {
            get { return t3xl; }
            set { t3xl = value; }
        }
        public int T4xl
        {
            get { return t4xl; }
            set { t4xl = value; }
        }
        public int T5xl
        {
            get { return t5xl; }
            set { t5xl = value; }
        }
        public int T6xl
        {
            get { return t6xl; }
            set { t6xl = value; }
        }

        public Double Minutes
        {
            get { return date; }
            set { date = value; }
        }

        



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

        public String Nombrepren
        {
            get { return nombreprendao; }
            set { nombreprendao = value; }
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
        #endregion
        public int sumaop()

        {
            int resultado = sobremedida + Xs + S + Mm + L + Xl + Xxl + T3xl + T4xl + T5xl + T6xl;
            return resultado;
        }

        public int Sumaop
        {
            get

            {
                int resultado = sobremedida + Xs + S + Mm + L + Xl + Xxl + T3xl + T4xl + T5xl + T6xl;
                return resultado;
            }

        }
        public String Registrar_opmodi()
        {

            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            String mensj = "";
            try
            {
                //pasamos  todos los parametros de entrada

                lst.Add(new ClsMetodosEmpleados("@Op", OP));
                lst.Add(new ClsMetodosEmpleados("@nombrepre", Nombrep));
                lst.Add(new ClsMetodosEmpleados("@descripcion", Descripcionmodi));
                lst.Add(new ClsMetodosEmpleados("@categoria", Categoriamodi));
                lst.Add(new ClsMetodosEmpleados("@tiempo", Tiempomodi));
                lst.Add(new ClsMetodosEmpleados("@cantidad ", Cantidad));
                lst.Add(new ClsMetodosEmpleados("@total", Totalmodi));
                lst.Add(new ClsMetodosEmpleados("@sobremedida", Sobremedida));
                lst.Add(new ClsMetodosEmpleados("@XS", Xs));
                lst.Add(new ClsMetodosEmpleados("@S", S));
                lst.Add(new ClsMetodosEmpleados("@M", Mm));
                lst.Add(new ClsMetodosEmpleados("@L", L));
                lst.Add(new ClsMetodosEmpleados("@XL", Xl));
                lst.Add(new ClsMetodosEmpleados("@XXL", Xxl));
                lst.Add(new ClsMetodosEmpleados("@_3XL", T3xl));
                lst.Add(new ClsMetodosEmpleados("@_4XL", T4xl));
                lst.Add(new ClsMetodosEmpleados("@_5XL", T5xl));
                lst.Add(new ClsMetodosEmpleados("@_6XL", T6xl));

                lst.Add(new ClsMetodosEmpleados("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));

                M.EjecutarSP("registraopmodi", ref lst);
                mensj = lst[18].Valor.ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mensj;
        }
        public String Actualizaropinter()
        {

            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            String mensj = "";
            try
            {
                //pasamos  todos los parametros de entrada

                lst.Add(new ClsMetodosEmpleados("@Op", OP));
                lst.Add(new ClsMetodosEmpleados("@nombrepre", Nombrep));
                lst.Add(new ClsMetodosEmpleados("@descripcion", Descripcionmodi));
                lst.Add(new ClsMetodosEmpleados("@categoria", Categoriamodi));
                lst.Add(new ClsMetodosEmpleados("@tiempo", Tiempomodi));
                lst.Add(new ClsMetodosEmpleados("@cantidad ", Sumaop));
                lst.Add(new ClsMetodosEmpleados("@total", Totalmodi));
                lst.Add(new ClsMetodosEmpleados("@sobremedida", Sobremedida));
                lst.Add(new ClsMetodosEmpleados("@XS", Xs));
                lst.Add(new ClsMetodosEmpleados("@S", S));
                lst.Add(new ClsMetodosEmpleados("@M", Mm));
                lst.Add(new ClsMetodosEmpleados("@L", L));
                lst.Add(new ClsMetodosEmpleados("@XL", Xl));
                lst.Add(new ClsMetodosEmpleados("@XXL", Xxl));
                lst.Add(new ClsMetodosEmpleados("@_3XL", T3xl));
                lst.Add(new ClsMetodosEmpleados("@_4XL", T4xl));
                lst.Add(new ClsMetodosEmpleados("@_5XL", T5xl));
                lst.Add(new ClsMetodosEmpleados("@_6XL", T6xl));

                lst.Add(new ClsMetodosEmpleados("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));

                M.EjecutarSP("actualizardatosopmodi", ref lst);
                mensj = lst[18].Valor.ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mensj;
        }
        public String Eliminaropinter()
        {
            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            String mensj = "";
            try
            {
                lst.Add(new ClsMetodosEmpleados("@Op", OP));
                lst.Add(new ClsMetodosEmpleados("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));

                M.EjecutarSP("eliminarop", ref lst);
                mensj = lst[1].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mensj;
        }
        public String Eliminaropmodi()
        {
            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            String mensj = "";
            try
            {
                lst.Add(new ClsMetodosEmpleados("@Op", OP));
                lst.Add(new ClsMetodosEmpleados("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));

                M.EjecutarSP("eliminaropmodi", ref lst);
                mensj = lst[1].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mensj;
        }
        public String Eliminaropimoditotal()
        {
            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            String mensj = "";
            try
            {
                //lst.Add(new ClsMetodosEmpleados("@Op", OP));
                lst.Add(new ClsMetodosEmpleados("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));

                M.EjecutarSP("elimiprendsmoditotal", ref lst);
                mensj = lst[0].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mensj;
        }
        public DataTable ListadoOpinter()
        {
            return M.Listado("listar_opinter", null);
        }
        public DataTable Buscarnopinter(int objDatos)
        {
            DataTable dt = new DataTable();
            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            try
            {
                lst.Add(new ClsMetodosEmpleados("@Datos", objDatos));
                dt = M.Listado("filtrardatosopmodi", lst);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }


        /// <summary>
        /// siginete tabla
        /// </summary>
        /// <returns></returns>

        public String Registraropyem()
        {

            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            String mensj = "";
            try
            {
                //pasamos  todos los parametros de entrada
                lst.Add(new ClsMetodosEmpleados("@id", IdInicio));
                lst.Add(new ClsMetodosEmpleados("@cedula", Cedula));
                lst.Add(new ClsMetodosEmpleados("@nombrepre", Nombreemplea));
                lst.Add(new ClsMetodosEmpleados("@cargo", Cargo));
                lst.Add(new ClsMetodosEmpleados("@opp1c", Opopera));

                lst.Add(new ClsMetodosEmpleados("@nomprendac", Nombrepren));



                lst.Add(new ClsMetodosEmpleados("@tiempoppc", Tiempoperac));
                lst.Add(new ClsMetodosEmpleados("@cantidadopc", Cantidadoperac));
                lst.Add(new ClsMetodosEmpleados("@totalopc", Totaoperac));
                lst.Add(new ClsMetodosEmpleados("@hora", Hora));
                lst.Add(new ClsMetodosEmpleados("@sobremedidaoc", Sobremedidao));
                lst.Add(new ClsMetodosEmpleados("@XSoc", Xso));
                lst.Add(new ClsMetodosEmpleados("@Soc", So));
                lst.Add(new ClsMetodosEmpleados("@Moc", Mmo));
                lst.Add(new ClsMetodosEmpleados("@Loc", Lo));
                lst.Add(new ClsMetodosEmpleados("@XLoc", Xlo));
                lst.Add(new ClsMetodosEmpleados("@XXLoc", Xxlo));
                lst.Add(new ClsMetodosEmpleados("@_3XLoc", T3xlo));
                lst.Add(new ClsMetodosEmpleados("@_4XLoc", T4xlo));
                lst.Add(new ClsMetodosEmpleados("@_5XLoc", T5xlo));
                lst.Add(new ClsMetodosEmpleados("@_6XLoc", T6xlo));

                lst.Add(new ClsMetodosEmpleados("@estado", Estado));
                lst.Add(new ClsMetodosEmpleados("@fechaini", Fechaini));
                lst.Add(new ClsMetodosEmpleados("@fechafin", Fechafin));

                lst.Add(new ClsMetodosEmpleados("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));

                M.EjecutarSP("regiopemple", ref lst);
                mensj = lst[24].Valor.ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mensj;
        }
        public String Actualizaropyem()
        {

            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            String mensj = "";
            try
            {
                //pasamos  todos los parametros de entrada
                lst.Add(new ClsMetodosEmpleados("@id", IdInicio));
                lst.Add(new ClsMetodosEmpleados("@cedula", Cedula));
                lst.Add(new ClsMetodosEmpleados("@nombrepre", Nombreemplea));
                lst.Add(new ClsMetodosEmpleados("@cargo", Cargo));
                lst.Add(new ClsMetodosEmpleados("@opp1c", Opopera));

                lst.Add(new ClsMetodosEmpleados("@nomprendac", Nombrepren));



                lst.Add(new ClsMetodosEmpleados("@tiempoppc", Tiempoperac));
                lst.Add(new ClsMetodosEmpleados("@cantidadopc", Cantidadoperac));
                lst.Add(new ClsMetodosEmpleados("@totalop", Totaoperac));
                lst.Add(new ClsMetodosEmpleados("@hora", Hora));
                lst.Add(new ClsMetodosEmpleados("@sobremedidaoc", Sobremedidao));
                lst.Add(new ClsMetodosEmpleados("@XSoc", Xso));
                lst.Add(new ClsMetodosEmpleados("@Soc", So));
                lst.Add(new ClsMetodosEmpleados("@Moc", Mmo));
                lst.Add(new ClsMetodosEmpleados("@Loc", Lo));
                lst.Add(new ClsMetodosEmpleados("@XLoc", Xlo));
                lst.Add(new ClsMetodosEmpleados("@XXLoc", Xxlo));
                lst.Add(new ClsMetodosEmpleados("@_3XLoc", T3xlo));
                lst.Add(new ClsMetodosEmpleados("@_4XLoc", T4xlo));
                lst.Add(new ClsMetodosEmpleados("@_5XLoc", T5xlo));
                lst.Add(new ClsMetodosEmpleados("@_6XLoc", T6xlo));

                lst.Add(new ClsMetodosEmpleados("@estado", Estado));
                lst.Add(new ClsMetodosEmpleados("@fechaini", Fechaini));
                lst.Add(new ClsMetodosEmpleados("@fechafin", Fechafin));


                lst.Add(new ClsMetodosEmpleados("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));

                M.EjecutarSP("actuaopyemple", ref lst);
                mensj = lst[24].Valor.ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mensj;
        }
        public String Eliminaropeyemid()
        {
            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            String mensj = "";
            try
            {
                lst.Add(new ClsMetodosEmpleados("@id", IdInicio));
                lst.Add(new ClsMetodosEmpleados("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));

                M.EjecutarSP("eliminaropyemple", ref lst);
                mensj = lst[1].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mensj;
        }
        public String Eliminaropeyemcedul()
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
        public DataTable Buscareopyem(int objDatos)
        {
            DataTable dt = new DataTable();
            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            try
            {
                lst.Add(new ClsMetodosEmpleados("@Datos", objDatos));

                dt = M.Listado("buscaropyemple", lst);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }
        public DataTable Buscareopyemcedu(int objDatos)
        {
            DataTable dt = new DataTable();
            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            try
            {
                lst.Add(new ClsMetodosEmpleados("@Datos", objDatos));

                dt = M.Listado("buscaropyemple2", lst);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }
        public DataTable Buscareopyid(int objDatos)
        {
            DataTable dt = new DataTable();
            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            try
            {
                lst.Add(new ClsMetodosEmpleados("@Datos", objDatos));

                dt = M.Listado("buscaropyid", lst);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }
        //la ope que se muestra y se copia ala tabla de una sola vez
        public DataTable Listadopyem()
        {
            return M.Listado("listaopyemple", null);
        }

        public String Actualiza1()
        {

            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            String mensj = "";
            try
            {
                //pasamos  todos los parametros de entrada
                lst.Add(new ClsMetodosEmpleados("@id", Id1));



                lst.Add(new ClsMetodosEmpleados("@estado", Estado1));

                lst.Add(new ClsMetodosEmpleados("@fechafin", Fechafin1));


                lst.Add(new ClsMetodosEmpleados("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));

                M.EjecutarSP("actuaopyemple1", ref lst);
                mensj = lst[3].Valor.ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mensj;
        }
        public DataTable Listardato1()
        {

            //List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            
            try
            {

                return M.Listado("listar_opyem", null);
               // mensj = lst[3].Valor.ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }
           
        }
    }
}
