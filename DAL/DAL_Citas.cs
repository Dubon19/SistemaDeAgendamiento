using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DAL;
using EL;

public static class DAL_Citas
{
    // Método para guardar una nueva cita
    public static void Guardar(Citas nuevaCita)
    {
        using (SqlConnection conn = new SqlConnection(Conexion.ConexionString()))
        {
            try
            {
                conn.Open();
                // Añadir EmpleadoId a la consulta
                string query = "INSERT INTO Citas (ClienteId, ServicioId, EmpleadoId, Fecha, HoraInicio, HoraFin, Activo, FechaCreacion, CreadoPor) " +
                               "VALUES (@ClienteId, @ServicioId, @EmpleadoId, @Fecha, @HoraInicio, @HoraFin, @Activo, @FechaCreacion, @CreadoPor)";
                SqlCommand cmd = new SqlCommand(query, conn);

                // Asignar valores a los parámetros
                cmd.Parameters.AddWithValue("@ClienteId", nuevaCita.ClienteId);
                cmd.Parameters.AddWithValue("@ServicioId", nuevaCita.ServicioId);
                cmd.Parameters.AddWithValue("@EmpleadoId", nuevaCita.EmpleadoId); // Aquí se agrega EmpleadoId
                cmd.Parameters.AddWithValue("@Fecha", nuevaCita.Fecha);
                cmd.Parameters.AddWithValue("@HoraInicio", nuevaCita.HoraInicio);
                cmd.Parameters.AddWithValue("@HoraFin", nuevaCita.HoraFin);
                cmd.Parameters.AddWithValue("@Activo", nuevaCita.Activo);
                cmd.Parameters.AddWithValue("@FechaCreacion", nuevaCita.FechaCreacion ?? DateTime.Now); // Si es null, usar la fecha actual
                cmd.Parameters.AddWithValue("@CreadoPor", nuevaCita.CreadoPor);

                // Ejecutar el comando
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Manejo de errores
                throw new Exception("Error al guardar la cita", ex);
            }
        }
    }

    // Método para listar todas las citas
    public static List<Citas> Listar()
    {
        List<Citas> citas = new List<Citas>();

        using (SqlConnection conn = new SqlConnection(Conexion.ConexionString()))
        {
            try
            {
                conn.Open();
                string query = "SELECT CitaId, ClienteId, ServicioId, EmpleadoId, Fecha, HoraInicio, HoraFin, Activo, FechaCreacion, CreadoPor FROM Citas";
                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Citas nuevaCita = new Citas
                    {
                        CitaId = reader.GetInt32(0),             // CitaId
                        ClienteId = reader.GetInt32(1),          // ClienteId
                        ServicioId = reader.GetInt32(2),         // ServicioId
                        EmpleadoId = reader.GetInt32(3),         // EmpleadoId
                        Fecha = reader.GetDateTime(4),           // Fecha
                        HoraInicio = reader.GetTimeSpan(5),      // HoraInicio
                        HoraFin = reader.GetTimeSpan(6),         // HoraFin
                        Activo = reader.GetBoolean(7),           // Activo
                        FechaCreacion = reader.IsDBNull(8) ? (DateTime?)null : reader.GetDateTime(8), // FechaCreacion
                        CreadoPor = reader.IsDBNull(9) ? null : reader.GetString(9)  // CreadoPor
                    };
                    citas.Add(nuevaCita);
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores
                throw new Exception("Error al listar las citas", ex);
            }
        }

        return citas;
    }

    // Método para eliminar una cita por su ID
    public static void Eliminar(int citaId)
    {
        using (SqlConnection conn = new SqlConnection(Conexion.ConexionString()))
        {
            try
            {
                conn.Open();
                string query = "DELETE FROM Citas WHERE CitaId = @CitaId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CitaId", citaId);

                // Ejecutar el comando
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Manejo de errores
                throw new Exception("Error al eliminar la cita", ex);
            }
        }
    }


    public static string ValidarDisponibilidad(int empleadoId, DateTime fecha, TimeSpan horaInicio, TimeSpan horaFin)
    {
        try
        {
            // Usar la función de la clase Conexion para obtener la cadena de conexión
            string connectionString = Conexion.ConexionString(); // Aquí utilizamos el método de tu clase Conexion

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Crear el comando para ejecutar el SP
                SqlCommand command = new SqlCommand("ValidarDisponibilidad", connection);
                command.CommandType = CommandType.StoredProcedure;

                // Agregar los parámetros al comando
                command.Parameters.AddWithValue("@EmpleadoId", empleadoId);
                command.Parameters.AddWithValue("@Fecha", fecha);
                command.Parameters.AddWithValue("@HoraInicio", horaInicio);
                command.Parameters.AddWithValue("@HoraFin", horaFin);

                // Ejecutar el SP y obtener el resultado
                SqlDataReader reader = command.ExecuteReader();

                // Leer el resultado
                if (reader.Read())
                {
                    return reader["Disponibilidad"].ToString(); // Asumiendo que "Disponibilidad" es el nombre correcto de la columna
                }
                else
                {
                    return "Error: No se obtuvo resultado de la disponibilidad.";
                }
            }
        }
        catch (Exception ex)
        {
            // Manejo de excepciones
            return "Error al validar disponibilidad: " + ex.Message;
        }
    }


}
