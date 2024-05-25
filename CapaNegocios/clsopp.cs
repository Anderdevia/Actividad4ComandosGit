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
    public class clsopp
    {

        private ClsConexionDatos M = new ClsConexionDatos();


        #region Campos
        
        private int idprenda;
        private int opp;
        private String nombreprenda;
        private String categoria;
        private String descripcion;
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
        private int cantidad;
        private int estado;
        private DateTime fecha_de_registro;
        private Double date;
        #endregion


        #region Campos
        private int numero;
        private int idopera;
        private int opp1;
        private int idprendaop;
        private String nombreprendao;
        private String nombreoperaciono;
        private String categoria2;
        private String descripcionpp1;
        private Decimal tiempopp;
        private int cantidadd;
        private Decimal totalpp;
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


        private int opp22;
        #endregion

        #region propiedades

        public int IDprenda
        {
            get { return idprenda; }
            set { idprenda = value; }
        }



        public int Opp
        {
            get { return opp; }
            set { opp = value; }
        }
        public String NombrePrenda
        {
            get { return nombreprenda; }
            set { nombreprenda = value; }
        }

        public String Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }
        public String Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
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
        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        public int Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        public DateTime Fecha_de_registro
        {
            get { return fecha_de_registro; }
            set { fecha_de_registro = value; }
        }
        public Double Minutes
        {
            get { return date; }
            set { date = value; }
        }
        #endregion

        #region propiedades
        public int Opp22
        {
            get { return opp22; }
            set { opp22 = value; }
        }



        public int IDopera
        {
            get { return idopera; }
            set { idopera = value; }
        }
        public int Opp1
        {
            get { return opp1; }
            set { opp1 = value; }
        }



        public int IDprendadd
        {
            get { return idprendaop; }
            set { idprendaop = value; }
        }
        public String Nombrepren
        {
            get { return nombreprendao; }
            set { nombreprendao = value; }
        }
        public String Nombreoperpp
        {
            get { return nombreoperaciono; }
            set { nombreoperaciono = value; }
        }
        public String Categoria2
        {
            get { return categoria; }
            set { categoria = value; }
        }
        public String Descripcionpp
        {
            get { return descripcionpp1; }
            set { descripcionpp1 = value; }
        }

        public Decimal Tiempopp
        {
            get { return tiempopp; }
            set { tiempopp = value; }
        }
        public int Cantidadpp
        {
            get { return cantidadd; }
            set { cantidadd = value; }
        }
        public Decimal Totalpp
        {
            get { return totalpp; }
            set { totalpp = value; }
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
        public int Numero1
        {
            get { return numero; }
            set { numero = value; }
        }


        public Decimal multiop()
        {

            {

                Decimal resultado =  tiempopp*cantidadd;
                return resultado;
            }

        }
        public Decimal Multiop
        {
            get
            {

                Decimal resultado = tiempopp * cantidadd;
                return resultado;
            }

        }
        public int sumaop()
        {


            {
                int resultado = 
                    sobremedidao +
                 xso +
                  so +
                  mmo +
                   lo +
               xlo +
                  xxlo +
                    t3xlo +
                   t4xlo +
                    t5xlo +
                  t6xlo;
                return resultado;
            }


        }
        public int Sumaop
        {
            get

            {
                int resultado =
                     sobremedidao +
         xso +
         so +
        mmo +
         lo +
         xlo +
         xxlo +
         t3xlo +
         t4xlo +
         t5xlo +
         t6xlo;
                return resultado;
            }


        }
        #endregion
        public String Registrar_opp()
        {

            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            String mensj = "";
            try
            {
                //pasamos  todos los parametros de entrada
                lst.Add(new ClsMetodosEmpleados("@id_prenda", IDprenda));
                lst.Add(new ClsMetodosEmpleados("@opp ", Opp));
                lst.Add(new ClsMetodosEmpleados("@nombre_prenda", NombrePrenda));
                lst.Add(new ClsMetodosEmpleados("@categoria", Categoria));
                lst.Add(new ClsMetodosEmpleados("@descripcion", Descripcion));
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
                lst.Add(new ClsMetodosEmpleados("@cantidad", Sumaop));
                lst.Add(new ClsMetodosEmpleados("@fecha_de_registro", Fecha_de_registro));
                lst.Add(new ClsMetodosEmpleados("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));

                M.EjecutarSP("registraropp", ref lst);
                mensj = lst[18].Valor.ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mensj;
        }
        //metodo para listado del registro de OP
        public DataTable ListadoOpp()
        {
            return M.Listado("listar_opp", null);
        }
        public String Actualizaropp()
        {
            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            String mensaje = "";
            try
            {
                lst.Add(new ClsMetodosEmpleados("@id_prenda", IDprenda));
                lst.Add(new ClsMetodosEmpleados("@opp ", Opp));
                lst.Add(new ClsMetodosEmpleados("@nombre_prenda", NombrePrenda));
                lst.Add(new ClsMetodosEmpleados("@categoria", Categoria));
                lst.Add(new ClsMetodosEmpleados("@descripcion", Descripcion));
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
                lst.Add(new ClsMetodosEmpleados("@cantidad", Sumaop));
                lst.Add(new ClsMetodosEmpleados("@fecha_de_registro", Fecha_de_registro));
                lst.Add(new ClsMetodosEmpleados("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));

                M.EjecutarSP("actualizaropp", ref lst);
                mensaje = lst[18].Valor.ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mensaje;
        }
        public String Eliminaropp()
        {
            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            String mensj = "";
            try
            {
                lst.Add(new ClsMetodosEmpleados("@opp", Opp));
                lst.Add(new ClsMetodosEmpleados("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));

                M.EjecutarSP("eliminaropp", ref lst);
                mensj = lst[1].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mensj;
        }
        public DataTable Buscarnopp12(int objDatos)
        {
            DataTable dt = new DataTable();
            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            try
            {
                lst.Add(new ClsMetodosEmpleados("@Datos", Opp));
                dt = M.Listado("buscaroptallae", lst);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }
        public DataTable Buscarnopp(int objDatos)
        {
            DataTable dt = new DataTable();
            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            try
            {
                lst.Add(new ClsMetodosEmpleados("@Datos", objDatos));
                dt = M.Listado("buscaropp", lst);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }

        /// <summary>
        /// inicio del otro paso
        /// </summary>
        /// <returns></returns>
        /// 
        public String Registrar_opp1()
        {

            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            String mensj = "";
            try
            {
                //pasamos  todos los parametros de entrada
               lst.Add(new ClsMetodosEmpleados("@numero1", Numero1));
                lst.Add(new ClsMetodosEmpleados("@opp1", Opp1));
                lst.Add(new ClsMetodosEmpleados("@idprenda", IDprendadd));
                lst.Add(new ClsMetodosEmpleados("@nomprenda", Nombrepren));
                lst.Add(new ClsMetodosEmpleados("@nombre_operaciono", Nombreoperpp));
                lst.Add(new ClsMetodosEmpleados("@categoria", Categoria2));
                lst.Add(new ClsMetodosEmpleados("@descripcionop", Descripcionpp));
                lst.Add(new ClsMetodosEmpleados("@tiempopp", Tiempopp));
                lst.Add(new ClsMetodosEmpleados("@totalop", Totalpp));

                lst.Add(new ClsMetodosEmpleados("@cantidadop", Sumaop));
              
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
                lst.Add(new ClsMetodosEmpleados("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));

                M.EjecutarSP("registraropop", ref lst);
                mensj = lst[22].Valor.ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mensj;
        }
        //metodo para listado del registro de OP
        public DataTable ListadoOpp1()
        {
            return M.Listado("listar_optalla", null);
        }
        public String Actualizaropp1numero()
        {
            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            String mensaje = "";
            try
            {
                //pasamos  todos los parametros de entrada
               lst.Add(new ClsMetodosEmpleados("@numero1", Numero1));
                lst.Add(new ClsMetodosEmpleados("@opp1", Opp1));
                lst.Add(new ClsMetodosEmpleados("@idprenda", IDprendadd));
                lst.Add(new ClsMetodosEmpleados("@nomprenda", Nombrepren));
                lst.Add(new ClsMetodosEmpleados("@nombre_operaciono", Nombreoperpp));
                lst.Add(new ClsMetodosEmpleados("@categoria", Categoria2));
                 lst.Add(new ClsMetodosEmpleados("@descripcionop", Descripcionpp)); 
                lst.Add(new ClsMetodosEmpleados("@tiempopp", Tiempopp));
                lst.Add(new ClsMetodosEmpleados("@cantidadop", Cantidad));
                lst.Add(new ClsMetodosEmpleados("@totalop", Totalpp));

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
                lst.Add(new ClsMetodosEmpleados("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));

                M.EjecutarSP("actualizaroptallanumero1", ref lst);
                mensaje = lst[22].Valor.ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mensaje;
        }
        public String Actualizaropp1()
        {
            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            String mensaje = "";
            try
            {
                //pasamos  todos los parametros de entrada
               // lst.Add(new ClsMetodosEmpleados("@idoper", IDopera));
                lst.Add(new ClsMetodosEmpleados("@opp1", Opp1));
                lst.Add(new ClsMetodosEmpleados("@idprenda", IDprendadd));
                lst.Add(new ClsMetodosEmpleados("@nomprenda", Nombrepren));
                // lst.Add(new ClsMetodosEmpleados("@nombre_operaciono", Nombreoperpp));
                lst.Add(new ClsMetodosEmpleados("@categoria", Categoria2));
                // lst.Add(new ClsMetodosEmpleados("@descripcionop", Descripcionpp)); 
                //  lst.Add(new ClsMetodosEmpleados("@tiempopp", Tiempopp));
                lst.Add(new ClsMetodosEmpleados("@cantidadop", Sumaop));
                lst.Add(new ClsMetodosEmpleados("@totalop", Totalpp));

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
                lst.Add(new ClsMetodosEmpleados("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));

                M.EjecutarSP("actualizaroptalla2", ref lst);
                mensaje = lst[18].Valor.ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mensaje;
        }
        public String Actualizaropp11()
        {
            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            String mensaje = "";
            try
            {
                //pasamos  todos los parametros de entrada
                // lst.Add(new ClsMetodosEmpleados("@idoper", IDopera));
                lst.Add(new ClsMetodosEmpleados("@opp1", Opp1));
                lst.Add(new ClsMetodosEmpleados("@idprenda", IDprendadd));
                lst.Add(new ClsMetodosEmpleados("@nomprenda", Nombrepren));
                // lst.Add(new ClsMetodosEmpleados("@nombre_operaciono", Nombreoperpp));
                lst.Add(new ClsMetodosEmpleados("@categoria", Categoria2));
                // lst.Add(new ClsMetodosEmpleados("@descripcionop", Descripcionpp)); 
                //  lst.Add(new ClsMetodosEmpleados("@tiempopp", Tiempopp));
                lst.Add(new ClsMetodosEmpleados("@cantidadop", Cantidad));
                lst.Add(new ClsMetodosEmpleados("@totalop", Totalpp));

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
                lst.Add(new ClsMetodosEmpleados("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));

                M.EjecutarSP("actualizaroptalla2", ref lst);
                mensaje = lst[18].Valor.ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mensaje;
        }
        public String Actualiza2()
        {
            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            String mensaje = "";
            try
            {
                //pasamos  todos los parametros de entrada
                // lst.Add(new ClsMetodosEmpleados("@idoper", IDopera));
                lst.Add(new ClsMetodosEmpleados("@opp1", Opp1));
                lst.Add(new ClsMetodosEmpleados("@idprenda", IDprendadd));
                lst.Add(new ClsMetodosEmpleados("@nomprenda", Nombrepren));
                // lst.Add(new ClsMetodosEmpleados("@nombre_operaciono", Nombreoperpp));
                lst.Add(new ClsMetodosEmpleados("@categoria", Categoria2));
                // lst.Add(new ClsMetodosEmpleados("@descripcionop", Descripcionpp)); 
               //  lst.Add(new ClsMetodosEmpleados("@tiempopp", Tiempopp));
                lst.Add(new ClsMetodosEmpleados("@cantidadop", Cantidadpp));
                lst.Add(new ClsMetodosEmpleados("@totalop", Totalpp));

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
                lst.Add(new ClsMetodosEmpleados("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));

                M.EjecutarSP("actualizaroperae", ref lst);
                mensaje = lst[18].Valor.ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mensaje;
        }
        public String Actualizarestado()
        {
            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            String mensaje = "";
            try
            {
                lst.Add(new ClsMetodosEmpleados("@numero1", IDopera));
                lst.Add(new ClsMetodosEmpleados("@estado", Estado));
                lst.Add(new ClsMetodosEmpleados("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));

                M.EjecutarSP("actualizaroptallaestado", ref lst);
                mensaje = lst[2].Valor.ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mensaje;
        }
        public String Actualiporop()
        {
            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            String mensaje = "";
            try
            {
                lst.Add(new ClsMetodosEmpleados("@opp1", Opp));
                lst.Add(new ClsMetodosEmpleados("@estado", Estado));
                lst.Add(new ClsMetodosEmpleados("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));

                M.EjecutarSP("actualizarop", ref lst);
                mensaje = lst[2].Valor.ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mensaje;
        }
        public String Actualizaropp21()
        {
            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            String mensaje = "";
            try
            {
                //pasamos  todos los parametros de entrada
                // lst.Add(new ClsMetodosEmpleados("@idoper", IDopera));
                lst.Add(new ClsMetodosEmpleados("@opp1", Opp1));
                lst.Add(new ClsMetodosEmpleados("@idprenda", IDprendadd));
                lst.Add(new ClsMetodosEmpleados("@nomprenda", Nombrepren));
                // lst.Add(new ClsMetodosEmpleados("@nombre_operaciono", Nombreoperpp));
                lst.Add(new ClsMetodosEmpleados("@categoria", Categoria2));
                // lst.Add(new ClsMetodosEmpleados("@descripcionop", Descripcionpp)); 
                //  lst.Add(new ClsMetodosEmpleados("@tiempopp", Tiempopp));
                lst.Add(new ClsMetodosEmpleados("@cantidadop", Sumaop));
                lst.Add(new ClsMetodosEmpleados("@totalop", Totalpp));

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
                lst.Add(new ClsMetodosEmpleados("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));

                M.EjecutarSP("actualizaroptalla21", ref lst);
                mensaje = lst[18].Valor.ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mensaje;
        }
        public String Eliminaropp22()
        {
            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            String mensj = "";
            try
            {
                lst.Add(new ClsMetodosEmpleados("@opp1c", Opp22));
                
                lst.Add(new ClsMetodosEmpleados("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));

                M.EjecutarSP("eliminaropetallae", ref lst);
                mensj = lst[1].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mensj;
        }
        public String Eliminaropp1()
        {
            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            String mensj = "";
            try
            {
                lst.Add(new ClsMetodosEmpleados("@opp1", Opp1));
                lst.Add(new ClsMetodosEmpleados("@idprenda", IDprendadd));
                lst.Add(new ClsMetodosEmpleados("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));

                M.EjecutarSP("eliminaroptalla", ref lst);
                mensj = lst[1].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mensj;
        }
        public DataTable Buscarnopp1(int objDatos)
        {
            DataTable dt = new DataTable();
            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            try
            {
                lst.Add(new ClsMetodosEmpleados("@Datos", Opp1));
                dt = M.Listado("buscaroptalla", lst);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }
        public DataTable Buscarid(int objDatos)
        {
            DataTable dt = new DataTable();
            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            try
            {
                lst.Add(new ClsMetodosEmpleados("@Datos", objDatos));
                dt = M.Listado("buscaroptallaid", lst);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }
        public String Actualizaropp12()
        {
            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            String mensaje = "";
            try
            {
                //pasamos  todos los parametros de entrada
                lst.Add(new ClsMetodosEmpleados("@opp1", Opp1));
                lst.Add(new ClsMetodosEmpleados("@idprenda", IDprendadd));
                 
                lst.Add(new ClsMetodosEmpleados("@nomprenda", Nombrepren));
                lst.Add(new ClsMetodosEmpleados("@nombre_operaciono", Nombreoperpp));
                lst.Add(new ClsMetodosEmpleados("@categoria", Categoria2));
                lst.Add(new ClsMetodosEmpleados("@descripcionop", Descripcionpp)); 
                lst.Add(new ClsMetodosEmpleados("@tiempopp", Tiempopp));
                lst.Add(new ClsMetodosEmpleados("@cantidadop", Cantidadpp));
                
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

                lst.Add(new ClsMetodosEmpleados("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));

                M.EjecutarSP("actualizaroptalla2", ref lst);
                mensaje = lst[20].Valor.ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mensaje;
        }


        ///la sigiente sentencia
        ///


        public String Registrar_opp2()
        {

            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            String mensj = "";
            try
            {
                //pasamos  todos los parametros de entrada
                lst.Add(new ClsMetodosEmpleados("@opp1", Opp1));
                lst.Add(new ClsMetodosEmpleados("@idprenda", IDprendadd));
                lst.Add(new ClsMetodosEmpleados("@nombre_operaciono", Nombreoperpp));
                lst.Add(new ClsMetodosEmpleados("@descripcionop", Descripcionpp));
                lst.Add(new ClsMetodosEmpleados("@tiempopp", Tiempopp));

                lst.Add(new ClsMetodosEmpleados("@cantidadop", Cantidadpp));
                lst.Add(new ClsMetodosEmpleados("@totalop", Multiop));
                lst.Add(new ClsMetodosEmpleados("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));

                M.EjecutarSP("registraropo2", ref lst);
                mensj = lst[7].Valor.ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mensj;
        }
        //metodo para listado del registro de OP
        public DataTable ListadoOpp2()
        {
            return M.Listado("listar_optalla2", null);
        }
        public String Actualizaropp2()
        {
            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            String mensaje = "";
            try
            {
                //pasamos  todos los parametros de entrada
                lst.Add(new ClsMetodosEmpleados("@opp1", Opp1));
                lst.Add(new ClsMetodosEmpleados("@idprenda", IDprendadd));
                lst.Add(new ClsMetodosEmpleados("@nombre_operaciono", Nombreoperpp));
                lst.Add(new ClsMetodosEmpleados("@descripcionop", Descripcionpp));
                lst.Add(new ClsMetodosEmpleados("@tiempopp", Tiempopp));

                lst.Add(new ClsMetodosEmpleados("@cantidadop", Cantidadpp));
                lst.Add(new ClsMetodosEmpleados("@totalop", Multiop));
                lst.Add(new ClsMetodosEmpleados("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));

                M.EjecutarSP("actualizaroptalla22", ref lst);
                mensaje = lst[7].Valor.ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mensaje;
        }
        public String Eliminaropp2()
        {
            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            String mensj = "";
            try
            {
                lst.Add(new ClsMetodosEmpleados("@opp1", Opp1));
                lst.Add(new ClsMetodosEmpleados("@idprenda", IDprendadd));
                lst.Add(new ClsMetodosEmpleados("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));

                M.EjecutarSP("eliminaroptalla2", ref lst);
                mensj = lst[1].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mensj;
        }
        public DataTable Buscarnopp2(int objDatos)
        {
            DataTable dt = new DataTable();
            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            try
            {
                lst.Add(new ClsMetodosEmpleados("@Datos", objDatos));
                dt = M.Listado("buscaroptalla2", lst);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }
        public String Registrar_operaultima()
        {

            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            String mensj = "";
            try
            {
                //pasamos  todos los parametros de entrada
                // lst.Add(new ClsMetodosEmpleados("@idoper", IDopera));
                lst.Add(new ClsMetodosEmpleados("@idoperc", IDopera ));
                lst.Add(new ClsMetodosEmpleados("@opp1c", Opp1));
                lst.Add(new ClsMetodosEmpleados("@idprendac", IDprendadd));
                lst.Add(new ClsMetodosEmpleados("@nomprendac", Nombrepren));
                lst.Add(new ClsMetodosEmpleados("@nombre_operacionoc", Nombreoperpp));
                lst.Add(new ClsMetodosEmpleados("@categoria", Categoria2));
                lst.Add(new ClsMetodosEmpleados("@descripcionopc", Descripcionpp));
                lst.Add(new ClsMetodosEmpleados("@tiempoppc", Tiempopp));
                lst.Add(new ClsMetodosEmpleados("@cantidadopc", Cantidadpp));
                lst.Add(new ClsMetodosEmpleados("@totalopc", Totalpp));
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
                lst.Add(new ClsMetodosEmpleados("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));

                M.EjecutarSP("registraropfinal", ref lst);
                mensj = lst[22].Valor.ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mensj;
        }
      
    }
}
