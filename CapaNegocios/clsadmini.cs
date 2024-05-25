using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocios
{
  public  class clsadmini

    {

        ClsConexionDatos M = new ClsConexionDatos();

        private int cedula;
        private String nombre;
        private String cargo;
        public String user;
        public String password;

        public int Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }
        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public String Cargo
        {
            get { return cargo; }
            set { cargo = value; }
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

        public String RegistrarUsuariosad()
        {
            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            String Mensaje = "";
            try
            {
                lst.Add(new ClsMetodosEmpleados("@cedula", Cedula));

                lst.Add(new ClsMetodosEmpleados("@Usuario", User));
                lst.Add(new ClsMetodosEmpleados("@Contraseña", Password));
                lst.Add(new ClsMetodosEmpleados("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                M.EjecutarSP("RegistrarUsuarioa", ref lst);
                return Mensaje = lst[3].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public String RegistrarUsuarios()
        {
            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            String Mensaje = "";
            try
            {
                lst.Add(new ClsMetodosEmpleados("@cedula", Cedula));
     
                lst.Add(new ClsMetodosEmpleados("@nombre", Nombre));
                lst.Add(new ClsMetodosEmpleados("@cargo", Cargo));
                lst.Add(new ClsMetodosEmpleados("@Usuario", User));
                lst.Add(new ClsMetodosEmpleados("@Contraseña", Password));
                lst.Add(new ClsMetodosEmpleados("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                M.EjecutarSP("RegistrarUsuarioa", ref lst);
                return Mensaje = lst[5].Valor.ToString();
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
                M.EjecutarSP("IniciarSesionad", ref lst);
                return Mensaje = lst[2].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable DevolverDatosSesion1(String objUser, String objPassword)
        {
            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            try
            {
                lst.Add(new ClsMetodosEmpleados("@Usuario", objUser));
                lst.Add(new ClsMetodosEmpleados("@Contraseña", objPassword));
                return M.Listado("DevolverDatosSesionad", lst);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable BuscarEmpleados(String objTblEmpleados)
        {
            DataTable dt = new DataTable();
            List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
            try
            {
                lst.Add(new ClsMetodosEmpleados("@cedula", objTblEmpleados));
                dt = M.Listado("buscarempleadosad", lst);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }
    }
}
