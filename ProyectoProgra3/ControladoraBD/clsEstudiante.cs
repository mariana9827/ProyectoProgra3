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
            command.CommandText = "INSERT INTO dbo.Estudiante(Carnet,IDDireccion,IDTipoCorreo,Nombre,Apellido1,Apellido2,Cedula)VALUES(@Carnet,@IDDireccionS,@Nombre,@Apellido1,@Apellido2,@Cedula)";
            command.Parameters.Add("@Carnet", SqlDbType.Int).Value = Estudiante.propCarnet;
            command.Parameters.Add("@IDDireccion", ) =;
           

            //return new Controladora().ejecutar(command);
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