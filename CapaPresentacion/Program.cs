using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocios;
using CapaEntidades;
using CapaPresentacion;

namespace WindowsFormsApp1
{
    public static class Program
    {


        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        // public static int Evento;C:\Users\family\Desktop\paginas web\produccion y eficiencia de empleados\CapaDatos\CapaPresentacion\Program.cs
        //datos op
        public static int op;
        public static Decimal tiempo;
        public static String nombreprendas;
        public static int cantidad;
        public static String categoriaop;
        //datos empleados
        public static int Cargo;
        public static int Cedula;

        //Variables de Sesion
        public static int IdEmpleadoLogueado;
        public static String NombreEmpleadoLogueado;

        public static int IdEmpleadoLogueado1;
        public static String NombreEmpleadoLogueado1;


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Formlogin());
        }


      
    }

     

        
}


