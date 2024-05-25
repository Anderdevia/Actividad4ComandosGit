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
    public class Clsopes
    {
        private ClsConexionDatos M = new ClsConexionDatos();
        #region

        private int numero;
        private int opint;
        private String referencia;
        private String nombrepredao;
        
        private String grupo;
        private String mq;
        private String nombreoperacion;
        private int unidad;
        private Decimal tiempo;
        private Decimal unidadhora;
        private String categoria;
        private String descripcionop;
        private String lugar;


        #region Campos
        private int idopera;
        private int opp1;
        private int idprendaop;
        private String nombreprendao;
        private String nombreoperaciono;
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

        #endregion
        public int Numero
        {
            get { return numero; }
            set { numero = value; }

        }
        public int Opint
        {
            get { return opint; }
            set { opint = value; }

        }
        public String Referencia
        {
            get { return referencia; }
            set { referencia = value; }
        }
        public String Grupo
        {
            get { return grupo; }
            set { grupo = value; }
        }
        public String Mq
        {
            get { return mq; }
            set { mq = value; }
        }
        public int Unidad
        {
            get { return unidad; }
            set { unidad = value; }

        }
        public Decimal Unidadhora
        {
            get { return unidadhora; }
            set { unidadhora = value; }

        }
        public String Lugar
        {
            get { return lugar; }
            set { lugar = value; }
        }
        public String Nombreprendaop
        {
            get { return nombrepredao; }
            set { nombrepredao = value; }
        }
        public String Nombreopera
        {
            get { return nombreoperacion; }
            set { nombreoperacion = value; }
        }
        public Decimal Tiempo
        {
            get { return tiempo; }
            set { tiempo = value; }

        }

        public String Descripcionopera
        {
            get { return descripcionop; }
            set { descripcionop = value; }

        }
        public String Categoria
        {
            get { return categoria; }
            set { categoria = value; }

        }
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
        #endregion
        public String Registrarope2()
        {

            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            String mensj = "";
            try
            {
                //pasamos  todos los parametros de entrada

                lst.Add(new ClsMetodosEmpleados("@idprenda", IDprendadd));
                lst.Add(new ClsMetodosEmpleados("@referencia", Referencia));
                lst.Add(new ClsMetodosEmpleados("@nomprenda ", Nombrepren));
          
                lst.Add(new ClsMetodosEmpleados("@grupo", Grupo));
                lst.Add(new ClsMetodosEmpleados("@mq", Mq));
                lst.Add(new ClsMetodosEmpleados("@nombre_operaciono", Nombreopera));
                lst.Add(new ClsMetodosEmpleados("@unidad", Unidad));
                lst.Add(new ClsMetodosEmpleados("@tiempopp", Tiempo));
                lst.Add(new ClsMetodosEmpleados("@unidadhora", Unidadhora));
                lst.Add(new ClsMetodosEmpleados("@categoria", Categoria));
                lst.Add(new ClsMetodosEmpleados("@descripcionop", Descripcionpp ));
                lst.Add(new ClsMetodosEmpleados("@Lugar", Lugar));



                lst.Add(new ClsMetodosEmpleados("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));

                M.EjecutarSP("registrarop2", ref lst);
                mensj = lst[12].Valor.ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mensj;

        }
        //metodo para listado del registro de horario
        public DataTable Listadoop2()
        {
            // listartiempotemp
            return M.Listado("listar_op2", null);
        }
        public String Actualizaropera2()
        {

            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            String mensj = "";
            try
            {
                //pasamos  todos los parametros de entrada


                lst.Add(new ClsMetodosEmpleados("@numero1", Numero));
                lst.Add(new ClsMetodosEmpleados("@idprenda", IDprendadd));
                lst.Add(new ClsMetodosEmpleados("@referencia", Referencia));
                lst.Add(new ClsMetodosEmpleados("@nomprenda ", Nombreprendaop));

                lst.Add(new ClsMetodosEmpleados("@grupo", Grupo));
                lst.Add(new ClsMetodosEmpleados("@mq", Mq));
                lst.Add(new ClsMetodosEmpleados("@nombre_operaciono", Nombreopera));
                lst.Add(new ClsMetodosEmpleados("@unidad", Unidad));
                lst.Add(new ClsMetodosEmpleados("@tiempopp", Tiempo));
                lst.Add(new ClsMetodosEmpleados("@unidadhora", Unidadhora));
                lst.Add(new ClsMetodosEmpleados("@categoria", Categoria));
                lst.Add(new ClsMetodosEmpleados("@descripcionop", Descripcionpp));
                lst.Add(new ClsMetodosEmpleados("@Lugar", Lugar));

                lst.Add(new ClsMetodosEmpleados("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));

                M.EjecutarSP("actualizarop2", ref lst);
                mensj = lst[13].Valor.ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mensj;
        }
        public String Eliminarop2()
        {
            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            String mensj = "";
            try
            {
                lst.Add(new ClsMetodosEmpleados("@numero1", Numero));
                lst.Add(new ClsMetodosEmpleados("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));

                M.EjecutarSP("eliminarop2", ref lst);
                mensj = lst[1].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mensj;
        }
        public String Eliminarop2op2()
        {
            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            String mensj = "";
            try
            {
                lst.Add(new ClsMetodosEmpleados("@numero1", Opint));
                lst.Add(new ClsMetodosEmpleados("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));

                M.EjecutarSP("eliminarop2op", ref lst);
                mensj = lst[1].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mensj;
        }
        public DataTable Buscarop2(int objDatos)
        {
            DataTable dt = new DataTable();
            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            try
            {
                lst.Add(new ClsMetodosEmpleados("@idprenda", Opint));

                dt = M.Listado("buscarop2", lst);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }
        public DataTable Listanumero()
        {
            return M.Listado("SP_Ultimo_Registroope", null);
        }

        public DataTable Buscarop3(int objDatos)
        {
            DataTable dt = new DataTable();
            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            try
            {
                lst.Add(new ClsMetodosEmpleados("@Datos", Numero));

                // lst.Add(new ClsMetodosEmpleados("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));

                dt = M.Listado("buscarol", lst);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }
        public DataTable Buscaropp(string objDatos)
        {
            DataTable dt = new DataTable();
            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            try
            {
                lst.Add(new ClsMetodosEmpleados("@idprenda", Descripcionopera));
              

                // lst.Add(new ClsMetodosEmpleados("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));

                dt = M.Listado("buscarop10", lst);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }
        public DataTable Buscarop5(string objDatos,string objDatos1)
        {
            DataTable dt = new DataTable();
            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            try
            {
                lst.Add(new ClsMetodosEmpleados("@idprenda", Descripcionopera));
                lst.Add(new ClsMetodosEmpleados("@id", Descripcionpp));

                // lst.Add(new ClsMetodosEmpleados("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));

                dt = M.Listado("buscarop5", lst);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }

        //la ope que se muestra y se copia ala tabla de una sola vez
        public DataTable ListadoOppfinal()
        {
            return M.Listado("listatallae", null);
        }
       
        public String Registraop1final()
        {

            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            String mensj = "";
            try
            {
                //pasamos  todos los parametros de entrada


                lst.Add(new ClsMetodosEmpleados("@opp1c", Opp1));




                lst.Add(new ClsMetodosEmpleados("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));

                M.EjecutarSP("registrarfinalop", ref lst);
                mensj = lst[1].Valor.ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mensj;

        }
        public String Registraropfinal()
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

                lst.Add(new ClsMetodosEmpleados("@cantidadopc", Cantidadpp));

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
                lst.Add(new ClsMetodosEmpleados("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));

                M.EjecutarSP("registraropfinal", ref lst);
                mensj = lst[20].Valor.ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mensj;

        }
        public DataTable Buscaropfinal(int objDatos)
        {
            DataTable dt = new DataTable();
            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            try
            {
                lst.Add(new ClsMetodosEmpleados("@Datos", Opp1));

                dt = M.Listado("buscaroptallae", lst);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }
        public DataTable Buscaridope(int objDatos)
        {
            DataTable dt = new DataTable();
            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            try
            {
                lst.Add(new ClsMetodosEmpleados("@Datos", IDopera));

                dt = M.Listado("buscaropidope", lst);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }
    }
}
