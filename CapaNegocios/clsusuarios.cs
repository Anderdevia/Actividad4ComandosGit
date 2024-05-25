using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;
using CapaNegocios;
using CapaEntidades;

namespace CapaNegocios
{
   public class clsusuarios
    {


        ClsConexionDatos M = new ClsConexionDatos();
        ClsReglasEmpleados Reglas = new ClsReglasEmpleados();
             ClsTBL_EMPLEADOS TblAtri = new ClsTBL_EMPLEADOS();

        private int cedula;
        public String user;
        public String password;

        public int Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }
        public String User
        {
            get { return user; }
            set { user = value; }
        }
        public String Password
        {
            get { return password; }
            set { password = value; }
        }

        public String RegistrarUsuarios()
        {
            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            String Mensaje = "";
            try
            {
                lst.Add(new ClsMetodosEmpleados("@cedula", Cedula));
                lst.Add(new ClsMetodosEmpleados("@Usuario", User));
                lst.Add(new ClsMetodosEmpleados("@Contraseña", Password));
                lst.Add(new ClsMetodosEmpleados("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                M.EjecutarSP("RegistrarUsuario", ref lst);
                return Mensaje = lst[3].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public String IniciarSesion()
        {
            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            String Mensaje = "";
            try
            {
                lst.Add(new ClsMetodosEmpleados("@Usuario", User));
                lst.Add(new ClsMetodosEmpleados("@Contraseña", Password));
                lst.Add(new ClsMetodosEmpleados("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                M.EjecutarSP("IniciarSesion", ref lst);
                return Mensaje = lst[2].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable DevolverDatosSesion(String objUser, String objPassword)
        {
            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            try
            {
                lst.Add(new ClsMetodosEmpleados("@Usuario", objUser));
                lst.Add(new ClsMetodosEmpleados("@Contraseña", objPassword));
                return M.Listado("DevolverDatosSesion", lst);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
