using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicadeNegocios
{
    internal class LogicaNegocio
    {
        private DBEstudiantes estudiantesDB = new DBEstudiantes();
        public void AgregarEstudiantes(string nombre, string apellido, DateTime fechaNacimiento, string nivelEstudio)
        {
              if(!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(apellido) && fechaNacimiento < DateTime.Now)
            {
                estudiantesDB.AgregarEstudiantes(nombre, apellido, fechaNacimiento, nivelEstudio);
            }
              else
            {
                throw new Exception("Los datos estan papus");
            }
        }
        public SqlDataAdapter ObtenerEstudiantes()
        {

        }
    }
}
