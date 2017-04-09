using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProyectoProgra3.Controladora
{
    public class clsEstudiante
    {
        public bool InsertarEstudiante(String Nombre, String Apellido1, String Apellido2, int carnet, int cedula, String FechaNac, int edad, int IDcarrera)
        {
            return new ControladoraBD.clsEstudiante().insertarEstudiante(new CapaEntidad.clsEstudiante(Nombre,Apellido1,Apellido2,carnet,cedula,FechaNac,edad,IDcarrera));
        }

        public DataTable verCarrerasControladora()
        {
            return new ControladoraBD.clsEstudiante().verCarrerasControladoraBD();
        }

    }
}