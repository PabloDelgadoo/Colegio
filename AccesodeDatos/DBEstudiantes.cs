using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AccesodeDatos
{
    public class DBEstudiantes
    {
        private string conexion = "MiCadena";
        public void AgregarEstudiantes(string nombre, string apellido, DateTime fechanacimiento, string nivelstudio)
        {
            using (SqlConnection conectar = new SqlConnection(conexion))
            {
                conectar.Open();
                string query = "INSERT INTO ESTUDIANTES(Nombre, Apellido, FechaNacimiento,NivelEstudio)"+"VALUES(@Nombre, @Apellido, @FechaNacimiento,@NivelEstudio)";
                SqlCommand cmd = new SqlCommand(query, conectar);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Apellido", apellido);
                cmd.Parameters.AddWithValue("@FechaNacimiento", fechanacimiento);
                cmd.Parameters.AddWithValue("@NivelEstudio", nivelstudio);
                cmd.ExecuteNonQuery();
            }
        }
        public SqlDataReader ObtenerEstudiantes()
        {
            SqlConnection conectar = new SqlConnection(conexion);
            conectar.Open();
            string query = "SELECT * FROM ESTUDIANTES";
            SqlCommand cmd = new SqlCommand(query, conectar);
            return cmd.ExecuteReader();
        }
    }
}
