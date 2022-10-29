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
                    aux.DNI = (string)datos.Lector["DNI"];
                    aux.IdPerfil = (int)datos.Lector["IdPerf"];
                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally 
            {
                datos.cerrarConexion();           
            } 
            
        }
        

    }
}
