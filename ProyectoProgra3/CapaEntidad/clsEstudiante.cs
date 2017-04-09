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
        private String FechaNac;
        private int edad;
        private int IDcarrera;
        private int cedula;


        public clsEstudiante () { }

        public clsEstudiante (String Nombre, String Apellido1, String Apellido2, int carnet, int cedula, String FechaNac, int edad, int IDcarrera)
        {
            this.Nombre = Nombre;
            this.cedula = cedula;
            this.Apellido1 = Apellido1;
            this.Apellido2 = Apellido2;
            this.carnet = carnet;
            this.FechaNac = FechaNac;
            this.edad = edad;
            this.IDcarrera = IDcarrera;

        }
        public String propNombre { get { return this.Nombre; } set { this.Nombre = value; } }
        public String propApellido2 { get { return this.Apellido2; } set { this.Apellido2 = value; } }
        public String propApellido1 { get { return this.Apellido1; } set { this.Apellido1 = value; } }
        public int propCarnet { get { return this.carnet; } set { this.carnet = value; } }
        public int propCedula { get { return this.cedula; } set { this.cedula = value; } }
        public String propFechaNac { get { return this.FechaNac; } set { this.FechaNac = value; } }
        public int propEdad { get { return this.edad; } set { this.edad = value; } }
        public int propIDcarrera{ get { return this.IDcarrera; } set { this.IDcarrera = value; } }
    }

    
}