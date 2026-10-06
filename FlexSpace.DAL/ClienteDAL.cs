using MySql.Data.MySqlClient;
using FlexSpace.DAL.DTO;
using static FlexSpace.DAL.Datos;

namespace FlexSpace.DAL
{
    public class ClienteDAL
    {
        private Conexion conexion = new Conexion();

        public ClienteDTO Buscar(int id)
        {
            ClienteDTO cliente = null;

            using (MySqlConnection cn = conexion.ObtenerConexion())
            {
                string sql = "SELECT Id, Nombre, Email, TipoCliente, SancionesActivas " +
                "FROM Cliente WHERE Id = @Id";

                MySqlCommand comando = new MySqlCommand(sql, cn);

                comando.Parameters.AddWithValue("@Id", id);

                cn.Open();

                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    cliente = new ClienteDTO();

                    cliente.id = Convert.ToInt32(reader["Id"]);
                    cliente.nombre = reader["Nombre"].ToString();
                    cliente.email = reader["Email"].ToString();
                    cliente.tipoCliente = reader["TipoCliente"].ToString();
                    cliente.sancionesActivas =
                    Convert.ToInt32(reader["SancionesActivas"]);
                }
            }

            return cliente;
        }
    }
}