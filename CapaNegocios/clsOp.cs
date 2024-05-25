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
    public class clsOp
    {
        private ClsConexionDatos M = new ClsConexionDatos();


        #region Campos
        private int op;
        private Decimal tiempo;
        private String nombreprendas;
        private String categoriaop;
        private String descripcion;
        private int cantidad;
        private Decimal total;
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
        private DateTime fecha_de_registro;
        private Double date;
        #endregion

        #region propiedades
        public int OP
        {
            get { return op; }
            set { op = value; }
        }



        public Decimal Tiempo
        {
            get { return tiempo; }
            set { tiempo = value; }
        }
        public String NombrePrendas
        {
            get { return nombreprendas; }
            set { nombreprendas = value; }
        }
        public String Descrpcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
         public String Categoriaop
        {
            get { return categoriaop; }
            set { categoriaop = value; }
        }
        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        public Decimal Total
        {
            get { return total; }
            set { total = value; }
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
        public int sumaop ()

        {
            int resultado =     sobremedida + Xs + S + Mm + L + Xl + Xxl + T3xl + T4xl + T5xl + T6xl;
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
        public String Registrar_op()
        {
           
            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            String mensj = "";
            try
            {
                //pasamos  todos los parametros de entrada
                lst.Add(new ClsMetodosEmpleados("@Op", OP));
                lst.Add(new ClsMetodosEmpleados("@tiempo", Tiempo));
                lst.Add(new ClsMetodosEmpleados("@nombre_producto", NombrePrendas));
                lst.Add(new ClsMetodosEmpleados("@descripcion", Descrpcion));
                lst.Add(new ClsMetodosEmpleados("@categoria", Categoriaop));
                lst.Add(new ClsMetodosEmpleados("@cantidad", Cantidad));
                lst.Add(new ClsMetodosEmpleados("@total", Total));
                lst.Add(new ClsMetodosEmpleados("@sobremedida", Sobremedida));
                lst.Add(new ClsMetodosEmpleados("@XS", Xs));
                lst.Add(new ClsMetodosEmpleados("@S", S));
                lst.Add(new ClsMetodosEmpleados("@M", Mm));
                lst.Add(new ClsMetodosEmpleados("@L", L));
                lst.Add(new ClsMetodosEmpleados("@XL", Xl));
                lst.Add(new ClsMetodosEmpleados("@XXL", Xxl));
                lst.Add(new ClsMetodosEmpleados("@_3XL",T3xl));
                lst.Add(new ClsMetodosEmpleados("@_4XL", T4xl));
                lst.Add(new ClsMetodosEmpleados("@_5XL", T5xl));
                lst.Add(new ClsMetodosEmpleados("@_6XL", T6xl));
                lst.Add(new ClsMetodosEmpleados("@fecha_de_registro", Fecha_de_registro));
                lst.Add(new ClsMetodosEmpleados("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));

                M.EjecutarSP("registraop", ref lst);
                mensj = lst[19].Valor.ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mensj;
        }
        //metodo para listado del registro de OP
        public DataTable ListadoOp()
        {
            return M.Listado("Listadoop", null);
        }
        public String Actualizarop()
        {
            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            String mensaje = "";
            try
            {
                lst.Add(new ClsMetodosEmpleados("@Op", OP));
                lst.Add(new ClsMetodosEmpleados("@tiempo", Tiempo));
                lst.Add(new ClsMetodosEmpleados("@nombre_producto", NombrePrendas));
                lst.Add(new ClsMetodosEmpleados("@descripcion", Descrpcion));
                lst.Add(new ClsMetodosEmpleados("@categoria", Categoriaop));

                
                lst.Add(new ClsMetodosEmpleados("@cantidad", Cantidad));
                lst.Add(new ClsMetodosEmpleados("@total", Total));
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
                lst.Add(new ClsMetodosEmpleados("@fecha_de_registro", Fecha_de_registro));
                lst.Add(new ClsMetodosEmpleados("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));

                M.EjecutarSP("actualizardatosop", ref lst);
                mensaje = lst[19].Valor.ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mensaje;
        }
        public String eliminarop()
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
            catch(Exception ex)
            {
                throw ex;
            }
            return mensj;
        }
        public DataTable Buscarnop(int objDatos)
        {
            DataTable dt = new DataTable();
            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            try
            {
                lst.Add(new ClsMetodosEmpleados("@Datos", OP));
                dt = M.Listado("filtrardatosoprendas", lst);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }
        public String Eliminaropimoditotal()
        {
            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            String mensj = "";
            try
            {
                //lst.Add(new ClsMetodosEmpleados("@Op", OP));
                lst.Add(new ClsMetodosEmpleados("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));

                M.EjecutarSP("elimioptotal", ref lst);
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




