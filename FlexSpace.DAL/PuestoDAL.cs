using MySql.Data.MySqlClient;
using FlexSpace.DAL.DTO;
using static FlexSpace.DAL.Datos;

namespace FlexSpace.DAL
{
    public class PuestoDAL
    {
        private Conexion conexion = new Conexion();

        public PuestoDTO Buscar(int id)
        {
            PuestoDTO puesto = null;

            using (MySqlConnection cn = conexion.ObtenerConexion())
            {
                string sql = "SELECT Id, Codigo, TipoPuesto, TarifaBasePorHora " +
                "FROM Puesto WHERE Id = @Id";

                MySqlCommand comando = new MySqlCommand(sql, cn);

                comando.Parameters.AddWithValue("@Id", id);

                cn.Open();

                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    puesto = new PuestoDTO();

                    puesto.id = Convert.ToInt32(reader["Id"]);
                    puesto.codigo = reader["Codigo"].ToString();
                    puesto.tipoPuesto = reader["TipoPuesto"].ToString();
                    puesto.tarifaBasePorHora =
                    Convert.ToDecimal(reader["TarifaBasePorHora"]);
                }
            }

            return puesto;
        }
    }
}