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
   public class Clsreporte2
    {
        private ClsConexionDatos M = new ClsConexionDatos();


        #region Campos
        private int id;

        private int cedula;
        private String nombreemple;




        private String cargo;


        private String eficiencia;

        private Decimal valorminuto;

        private Decimal minuingeneria;
        private Decimal totalminuingeneri;
        private Decimal minutopresecial;
        private Decimal minutoimproductivo;
        private Decimal totalminutoimprocuctivo;
        private Decimal fectivo;
        private Decimal totalfectivo;
        private Decimal reunion;
        private Decimal totalreunion;
        private Decimal total;
        private DateTime fecha;

        #endregion

        #region Campos

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

        public String Efici
        {
            get { return eficiencia; }
            set { eficiencia = value; }
        }
        public Decimal Valorminut
        {
            get { return valorminuto; }
            set { valorminuto = value; }
        }
        public Decimal Minuingene
        {
            get { return minuingeneria; }
            set { minuingeneria = value; }
        }

        public Decimal Totalminuingene
        {
            get { return totalminuingeneri; }
            set { totalminuingeneri = value; }
        }

        public Decimal Minupresenc
        {
            get { return minutopresecial; }
            set { minutopresecial = value; }
        }
        public Decimal Minuimproduct
        {
            get { return minutoimproductivo; }
            set { minutoimproductivo = value; }
        }
        public Decimal TotalImpro
        {
            get { return totalminutoimprocuctivo; }
            set { totalminutoimprocuctivo = value; }
        }
        public Decimal Fectivo
        {
            get { return fectivo; }
            set { fectivo = value; }
        }
        public Decimal Totalfecti
        {
            get { return totalfectivo; }
            set { totalfectivo = value; }
        }
        public Decimal Reunio
        {
            get { return reunion; }
            set { reunion = value; }
        }
        public Decimal Totalreunion
        {
            get { return totalreunion; }
            set { totalreunion = value; }
        }
        public Decimal Totaltodo
        {
            get { return total; }
            set { total = value; }
        }
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        #endregion
        public String Registrefinal()
        {

            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            String mensj = "";
            try
            {
                //pasamos  todos los parametros de entrada
                lst.Add(new ClsMetodosEmpleados("@id", Id));
                lst.Add(new ClsMetodosEmpleados("@nombre", Nombreemplea));
                lst.Add(new ClsMetodosEmpleados("@cedula", Cedula));


                lst.Add(new ClsMetodosEmpleados("@cargo", Cargo));

                lst.Add(new ClsMetodosEmpleados("@eficiencia", Efici));
                lst.Add(new ClsMetodosEmpleados("@valorminuti", Valorminut));
                lst.Add(new ClsMetodosEmpleados("@minutosingene", Minuingene));
                lst.Add(new ClsMetodosEmpleados("@totalminuinge", Totalminuingene));
                lst.Add(new ClsMetodosEmpleados("@minutospresenci", Minupresenc));
                lst.Add(new ClsMetodosEmpleados("@minutoimproduc", Minuimproduct));
                lst.Add(new ClsMetodosEmpleados("@totalminuimproductivo", TotalImpro));
                lst.Add(new ClsMetodosEmpleados("@fectivo", Fectivo));
                lst.Add(new ClsMetodosEmpleados("@totalfestivo", Totalfecti));
                lst.Add(new ClsMetodosEmpleados("@reunion", Reunio));
                lst.Add(new ClsMetodosEmpleados("@totalreunio", Totalreunion));
                lst.Add(new ClsMetodosEmpleados("@total", Totaltodo));
                lst.Add(new ClsMetodosEmpleados("@fecha", Fecha));


                lst.Add(new ClsMetodosEmpleados("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));

                M.EjecutarSP("registrreporte2", ref lst);
                mensj = lst[17].Valor.ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mensj;
        }
        public String Actuareport()
        {

            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            String mensj = "";
            try
            {
                //pasamos  todos los parametros de entrada

                //pasamos  todos los parametros de entrada
                lst.Add(new ClsMetodosEmpleados("@id", Id));
                lst.Add(new ClsMetodosEmpleados("@nombre", Nombreemplea));
                lst.Add(new ClsMetodosEmpleados("@cedula", Cedula));

                lst.Add(new ClsMetodosEmpleados("@cargo", Cargo));

                lst.Add(new ClsMetodosEmpleados("@eficiencia", Efici));
                lst.Add(new ClsMetodosEmpleados("@valorminuti", Valorminut));
                lst.Add(new ClsMetodosEmpleados("@minutosingene", Minuingene));
                lst.Add(new ClsMetodosEmpleados("@totalminuinge", Totalminuingene));
                lst.Add(new ClsMetodosEmpleados("@minutospresenci", Minupresenc));
                lst.Add(new ClsMetodosEmpleados("@minutoimproduc", Minuimproduct));
                lst.Add(new ClsMetodosEmpleados("@totalminuimproductivo", TotalImpro));
                lst.Add(new ClsMetodosEmpleados("@fectivo", Fectivo));
                lst.Add(new ClsMetodosEmpleados("@totalfestivo", Totalfecti));
                lst.Add(new ClsMetodosEmpleados("@reunion", Reunio));
                lst.Add(new ClsMetodosEmpleados("@totalreunio", Totalreunion));
                lst.Add(new ClsMetodosEmpleados("@total", Totaltodo));
                lst.Add(new ClsMetodosEmpleados("@fecha", Fecha));

                lst.Add(new ClsMetodosEmpleados("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));

                M.EjecutarSP("actualeporte", ref lst);
                mensj = lst[17].Valor.ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mensj;
        }
        public String Elimireport()
        {
            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            String mensj = "";
            try
            {
                lst.Add(new ClsMetodosEmpleados("@id", Id));
                lst.Add(new ClsMetodosEmpleados("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));

                M.EjecutarSP("eliminereporte2", ref lst);
                mensj = lst[1].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mensj;
        }
        public String Elimireportcedu()
        {
            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            String mensj = "";
            try
            {
                lst.Add(new ClsMetodosEmpleados("@cedula", Cedula));
                lst.Add(new ClsMetodosEmpleados("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));

                M.EjecutarSP("eliminereporte2cedu", ref lst);
                mensj = lst[1].Valor.ToString();
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
              //  lst.Add(new ClsMetodosEmpleados("@cedula", Cedula));
                lst.Add(new ClsMetodosEmpleados("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));

                M.EjecutarSP("eliminereporte2total", ref lst);
                mensj = lst[1].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mensj;
        }
        public DataTable Buscarid(int objDatos)
        {
            DataTable dt = new DataTable();
            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            try
            {
                lst.Add(new ClsMetodosEmpleados("@Datos", objDatos));

                dt = M.Listado("buscareporte", lst);
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
        public DataTable Listareport()
        {
            return M.Listado("listareporte", null);
        }
    }

}

