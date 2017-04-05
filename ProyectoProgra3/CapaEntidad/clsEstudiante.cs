using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoProgra3.CapaEntidad
{
    public class clsEstudiante
    {
        private String Nombre;
        private String Apellido1;
        private String Apellido2;
        private int carnet;
        private int cedula;

        public clsEstudiante () { }

        public clsEstudiante (String Nombre, String Apellido1, String Apellido2, int carnet, int cedula)
        {
            this.Nombre = Nombre;
            this.cedula = cedula;
            this.Apellido1 = Apellido1;
            this.Apellido2=Apellido2;
            this.carnet = carnet;
        }
        public String propNombre { get { return this.Nombre; } set { this.Nombre = value; } }
        public String propApellido2 { get { return this.Apellido2; } set { this.Apellido2 = value; } }
        public String propApellido1 { get { return this.Apellido1; } set { this.Apellido1 = value; } }
        public int propCarnet { get { return this.carnet; } set { this.carnet= value; } }
        public int propCedula { get{ return this.cedula; }set { this.cedula = value; } }
    }
}