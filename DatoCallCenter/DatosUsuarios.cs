using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using clases;

namespace DatoCallCenter
{
    public class DatosUsuarios
    {
        public List<Usuarios> Listar() 
        {
            List<Usuarios> lista=new List<Usuarios>();
            AccesoDatos datos=new AccesoDatos();
            try
            {
                datos.setearQuery("Select Id, Nombre, Apellido,DNI,IdPerf From Usuarios");
                datos.ejecutarLectura();
                while( datos.Lector.Read())
                {
                    Usuarios aux = new Usuarios();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Apellido = (string)datos.Lector["Apellido"];
                    aux.DNI = (Int64)datos.Lector["DNI"];
                    aux.IdPerfil = (Int16)datos.Lector["IdPerf"];
                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception )
            {
                throw;
            }
            finally 
            {
                datos.cerrarConexion();           
            } 
        }
    }
}
