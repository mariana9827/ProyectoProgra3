using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProyectoProgra3.ControladoraBD
{
    public class clsEstudiante
    {
        public bool insertarEstudiante (CapaEntidad.clsEstudiante Estudiante)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO dbo.Estudiante (Carnet,Nombre,Apellido1,Apellido2,FechaNaci,Edad,Id_Persona,IDCarrera)VALUES(@Carnet,@Nombre,@Apellido1,@Apellido2,@FechaNaci,@Edad,@Id_Persona,@IDCarrera)";
            command.Parameters.Add("@Carnet", SqlDbType.Int).Value = Estudiante.propCarnet;
            command.Parameters.Add("@Nombre", SqlDbType.VarChar, 30).Value = Estudiante.propNombre;
            command.Parameters.Add("@Apellido1", SqlDbType.Int).Value = Estudiante.propApellido1;
            command.Parameters.Add("@Apellido2", SqlDbType.VarChar,30).Value = Estudiante.propApellido2;
            command.Parameters.Add("@FechaNaci", SqlDbType.VarChar, 20).Value = Estudiante.propFechaNac;
            command.Parameters.Add("@Edad", SqlDbType.Int).Value = Estudiante.propEdad;
            command.Parameters.Add("@Id_Persona", SqlDbType.Int).Value = Estudiante.propCedula;
            command.Parameters.Add("@IDCarrera", SqlDbType.Int).Value = Estudiante.propIDcarrera;

            return new Adaptador.clsConexion().ejecutar(command);
        }



        //public DataTable buscarRerva ()
        //{
        //    SqlCommand command = new SqlCommand("SELECT tipo_reserva as [Tipo de reserva], fecha_reserva as Fecha, nombre_cliente as Cliente, cedula_cliente as Cedula FROM reserva WHERE num_reserva = 1");
        //    return new Controladora().ejecutarSelect(command);
        //}


        //public DataTable verReservas ()
        //{
        //    SqlCommand command = new SqlCommand("SELECT tipo_reserva as [Tipo de reserva], fecha_reserva as Fecha, nombre_cliente as Cliente, cedula_cliente as Cedula FROM reserva");
        //    return new Controladora().ejecutarSelect(command);
        //}
    }
}