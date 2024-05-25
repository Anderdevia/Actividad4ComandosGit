using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades

{
    public class ClsTBL_EMPLEADOS
    {
        #region Campos
        private int cedula;
        private String nombre;
        private String area;
        private String cargo;
        private String modalidad;
        private int dia;
        private int pro;
   
        private DateTime fecha_de_ingreso;
        private char sexo;


        #endregion

        #region Propiedades
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
        public String Area
        {
            get { return area; }
            set { area = value; }
        }
        public String Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }
        public String Modalidad
        {
            get { return modalidad; }
            set { modalidad = value; }
        }
        public int Dia
        {
            get { return dia; }
            set { dia = value; }
        }
        public int Pro
        {
            get { return pro; }
            set { pro = value; }
        }
        public DateTime Fecha_de_ingreso
        {
            get { return fecha_de_ingreso; }
            set { fecha_de_ingreso = value; }
        }
        public char Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
        #endregion


    }
}
