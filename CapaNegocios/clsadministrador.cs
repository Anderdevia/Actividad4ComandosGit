using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaNegocios;
using CapaDatos;


namespace CapaNegocios
{
   public class clsadministrador
    {

        #region Campos
        private String id_usu;
        private int user_usu;
        private String contraseña_usu;
        #endregion

        #region Propiedades
        public String id_Usu
        {
            get { return id_usu; }
            set { id_usu = value; }
        }
        public int user_Usu
        {
            get { return user_usu; }
            set { user_usu = value; }
        }
        public String contraseña_Usu
        {
            get { return contraseña_usu; }
            set { contraseña_usu = value; }

        }
        #endregion
       // public String IniciarSesionadministrador()
       // {
        //    List<ClsMetodosEmpleados> lst = new List<ClsMetodosEmpleados>();
        //    String Mensaje = "";
           // try
            //{
              //  lst.Add(new (ClsMetodosEmpleados("@Usuario"));
               // lst.Add(new ClsMetodosEmpleados("@Contraseña", ));
               // lst.Add(new ClsMetodosEmpleados("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
               // M.EjecutarSP("IniciarSesion", ref lst);
               // return Mensaje = lst[2].Valor.ToString();
          //  }
          //  catch (Exception ex)
         //   {
          //      throw ex;
         //   }
        }
}
