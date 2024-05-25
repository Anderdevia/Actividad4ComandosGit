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
   public class Adoperacion
    {

        private ClsConexionDatos M = new ClsConexionDatos();

        #region campos
        private int op;
        private String refe;
        private String nombrep;
        private String categoria;
        private String descripcion;
        private String descripcion2;
        private byte[] imagen;
        private DateTime fecha;

        private int opu;
        private int idprendau;
        private String nombrepren;
        private int cantidau;




        #endregion

        #region propiedades

        public int Op
        {
            get { return op; }
            set { op = value; }

        }

        public String Refe
        {
            get { return refe; }
            set { refe = value; }

        }
        public String Nombrep
        {
            get { return nombrep; }
            set { nombrep = value; }

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
        public String Descripcion2
        {
            get { return descripcion2; }
            set { descripcion2 = value; }

        }
        public byte[] Imagen
        {
            get { return imagen; }
            set { imagen = value; }

        }
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }

        }
        //operaciones

        public int Opu
        {
            get { return opu; }
            set { opu = value; }

        }
        public int Idprendu
        {
            get { return idprendau; }
            set { idprendau = value; }

        }
        public String Nomprendu
        {
            get { return nombrepren; }
            set { nombrepren = value; }
        }
        public int Cantidau
        {
            get { return cantidau; }
            set { cantidau = value; }

        }

        #endregion


        public String Registrarope1()
        {

            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            String mensj = "";
            try
          {
                //pasamos  todos los parametros de entrada

                lst.Add(new ClsMetodosEmpleados("@op", Refe));
                lst.Add(new ClsMetodosEmpleados("@nombre_prenda", Nombrep));
                lst.Add(new ClsMetodosEmpleados("@categoria", Categoria));
                lst.Add(new ClsMetodosEmpleados("@descripcion1", Descripcion));
                lst.Add(new ClsMetodosEmpleados("@descripcion2", Descripcion2));
                lst.Add(new ClsMetodosEmpleados("@imagen", Imagen));
                lst.Add(new ClsMetodosEmpleados("@fecha", Fecha));



                lst.Add(new ClsMetodosEmpleados("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));

                M.EjecutarSP("registraidprenda", ref lst);
                mensj = lst[7].Valor.ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mensj;

        }
        //metodo para listado del registro de horario
        public DataTable Listadoop1()
        {
            // listartiempotemp
            return M.Listado("listar_op1", null);
        }
        public String Actualizaropera1()
        {

            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            String mensj = "";
            try
            {
                //pasamos  todos los parametros de entrada
                lst.Add(new ClsMetodosEmpleados("@id", Op));
                lst.Add(new ClsMetodosEmpleados("@op", Refe));
                lst.Add(new ClsMetodosEmpleados("@nombre_prenda", Nombrep));
                lst.Add(new ClsMetodosEmpleados("@categoria", Categoria));
                lst.Add(new ClsMetodosEmpleados("@descripcion1", Descripcion));
                lst.Add(new ClsMetodosEmpleados("@descripcion2", Descripcion2));
                lst.Add(new ClsMetodosEmpleados("@fecha", Fecha));


                lst.Add(new ClsMetodosEmpleados("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));

                M.EjecutarSP("actualizarop1", ref lst);
                mensj = lst[7].Valor.ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mensj;
        }
        public String Eliminarop1()
        {
            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            String mensj = "";
            try
            {
                lst.Add(new ClsMetodosEmpleados("@id", Op));
                lst.Add(new ClsMetodosEmpleados("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));

                M.EjecutarSP("eliminarop1", ref lst);
                mensj = lst[1].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mensj;
        }
        public String Eliminaroperacion()
        {
            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            String mensj = "";
            try
            {
                lst.Add(new ClsMetodosEmpleados("@opp1c", Op));
                lst.Add(new ClsMetodosEmpleados("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));

                M.EjecutarSP("eliminaopoperaciones", ref lst);
                mensj = lst[1].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mensj;
        }
        public DataTable Buscarop1(int objDatos)
        {
            DataTable dt = new DataTable();
            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            try
            {
                lst.Add(new ClsMetodosEmpleados("@id", Op));
                dt = M.Listado("buscarop1", lst);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }
        public String Registraropu()
        {

            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            String mensj = "";
            try
            {
                //pasamos  todos los parametros de entrada

                lst.Add(new ClsMetodosEmpleados("@opp1c", Opu));
                lst.Add(new ClsMetodosEmpleados("@idprendac", Idprendu));
                lst.Add(new ClsMetodosEmpleados("@nomprendac", Nomprendu));
                lst.Add(new ClsMetodosEmpleados("@cantidadopc", Cantidau));            

                lst.Add(new ClsMetodosEmpleados("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));

                M.EjecutarSP("registraropu", ref lst);
                mensj = lst[4].Valor.ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mensj;

        }
        public DataTable Listadoopu()
        {
            // listartiempotemp
            return M.Listado("listaropu", null);
        }
        public DataTable Buscaropu(int objDatos)
        {
            DataTable dt = new DataTable();
            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            try
            {
                lst.Add(new ClsMetodosEmpleados("@Datos", objDatos));
                dt = M.Listado("buscaropu", lst);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }
    }
    
}