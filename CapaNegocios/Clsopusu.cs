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
   public class Clsopusu
    {
        private ClsConexionDatos M = new ClsConexionDatos();

        #region Campos
        private int idopera;
        private int opp1;
        private int idprendaop;
        private String nombreprendao;
        private String nombreoperaciono;
        private String categoria;
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
        private int estado;

        #endregion

        #region Campos

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
        public String Categoria
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
        public int Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public int sumaop()
        {


            {
                int resultado =
                    sobremedidao + xso + so + mmo + lo + xlo + xxlo + t3xlo + t4xlo + t5xlo + t6xlo;

                return resultado;
            }


        }
        public int Sumaop
        {
            get

            {
                int resultado = sobremedidao + xso + so + mmo + lo + xlo + xxlo + t3xlo + t4xlo + t5xlo + t6xlo;

                return resultado;
            }

            #endregion
        }
        public String Registrarusu()
        {

            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            String mensj = "";
            try
            {
                //pasamos  todos los parametros de entrada
                lst.Add(new ClsMetodosEmpleados("@idoperc", IDopera));
                lst.Add(new ClsMetodosEmpleados("@opp1c", Opp1));
                lst.Add(new ClsMetodosEmpleados("@idprendac", IDprendadd));
                lst.Add(new ClsMetodosEmpleados("@nomprendac", Nombrepren));
               
                lst.Add(new ClsMetodosEmpleados("@nombre_operacionoc", Nombreoperpp));
                lst.Add(new ClsMetodosEmpleados("@categoria", Categoria));
                lst.Add(new ClsMetodosEmpleados("@descripcionopc", Descripcionpp));
                lst.Add(new ClsMetodosEmpleados("@tiempoppc", Tiempopp));
                lst.Add(new ClsMetodosEmpleados("@totalopc", Totalpp));

                lst.Add(new ClsMetodosEmpleados("@cantidadopc", Sumaop));

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

                M.EjecutarSP("registraropusu", ref lst);
                mensj = lst[22].Valor.ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mensj;

        }
        public String Actualizaropusu()
        {

            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            String mensj = "";
            try
            {
                //pasamos  todos los parametros de entrada
                lst.Add(new ClsMetodosEmpleados("@idoperc", IDopera));
                lst.Add(new ClsMetodosEmpleados("@opp1c", Opp1));
                lst.Add(new ClsMetodosEmpleados("@idprendac", IDprendadd));
                lst.Add(new ClsMetodosEmpleados("@nomprendac", Nombrepren));
                
                lst.Add(new ClsMetodosEmpleados("@nombre_operacionoc", Nombreoperpp));
                lst.Add(new ClsMetodosEmpleados("@categoria", Categoria));
                lst.Add(new ClsMetodosEmpleados("@descripcionopc", Descripcionpp));
                lst.Add(new ClsMetodosEmpleados("@tiempoppc", Tiempopp));
                lst.Add(new ClsMetodosEmpleados("@cantidadopc", Sumaop));
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

                M.EjecutarSP("actualizaropusu", ref lst);
                mensj = lst[22].Valor.ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mensj;
        }
        public String Eliminaropusutotal()
        {
            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            String mensj = "";
            try
            {
               // lst.Add(new ClsMetodosEmpleados("@idoperc", IDopera));
                lst.Add(new ClsMetodosEmpleados("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));

                M.EjecutarSP("elimipusutotal", ref lst);
                mensj = lst[0].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mensj;
        }
        public String Eliminaropusu()
        {
            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            String mensj = "";
            try
            {
                lst.Add(new ClsMetodosEmpleados("@idoperc", IDopera));
                lst.Add(new ClsMetodosEmpleados("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));

                M.EjecutarSP("eliminaropusu", ref lst);
                mensj = lst[1].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mensj;
        }
        public String Eliminaropusuop()
        {
            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            String mensj = "";
            try
            {
                lst.Add(new ClsMetodosEmpleados("@opp1c", Opp1));
                lst.Add(new ClsMetodosEmpleados("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));

                M.EjecutarSP("eliminaropusuop", ref lst);
                mensj = lst[1].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mensj;
        }
        public DataTable Buscaropusu(int objDatos)
            {
                DataTable dt = new DataTable();
                List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
                try
                {
                    lst.Add(new ClsMetodosEmpleados("@Datos", objDatos));

                    dt = M.Listado("buscaropusu", lst);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                return dt;
            }
        //la ope que se muestra y se copia ala tabla de una sola vez
        public DataTable ListadoOpusu()
        {
            return M.Listado("listaropusu", null);
        }

    }
}

