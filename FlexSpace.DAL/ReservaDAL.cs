using MySql.Data.MySqlClient;
using FlexSpace.DAL.DTO;
using static FlexSpace.DAL.Datos;

namespace FlexSpace.DAL
{
    public class ReservaDAL
    {
        private Conexion conexion = new Conexion();

        public ReservaDTO Buscar(int id)
        {
            ReservaDTO reserva = null;

            using (MySqlConnection cn = conexion.ObtenerConexion())
            {
                string sql = "SELECT Id, ClienteId, PuestoId, FechaInicio, FechaFin, " +
                "Estado, CostoTotal " +
                "FROM Reserva WHERE Id = @Id";

                MySqlCommand comando = new MySqlCommand(sql, cn);

                comando.Parameters.AddWithValue("@Id", id);

                cn.Open();

                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    reserva = new ReservaDTO();

                    reserva.id = Convert.ToInt32(reader["Id"]);
                    reserva.clienteId = Convert.ToInt32(reader["ClienteId"]);
                    reserva.puestoId = Convert.ToInt32(reader["PuestoId"]);
                    reserva.fechaInicio = Convert.ToDateTime(reader["FechaInicio"]);
                    reserva.fechaFin = Convert.ToDateTime(reader["FechaFin"]);
                    reserva.estado = reader["Estado"].ToString();
                    reserva.costoTotal = Convert.ToDecimal(reader["CostoTotal"]);
                }
            }

            return reserva;
        }
    }
}