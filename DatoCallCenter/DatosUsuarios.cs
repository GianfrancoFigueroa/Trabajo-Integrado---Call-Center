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
                    aux.DNI = (int)datos.Lector["DNI"];
                    aux.IdPerfil = (int)datos.Lector["IdPerf"];
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


        public bool Logueo(Usuarios usuarios)
        {
            Usuarios DatoDelUsuario = new Usuarios();
            AccesoDatos datos = new AccesoDatos();
           
            try
            {
                
                datos.setearQuery("Select ID, Nombre, Apellido, DNI, IDPerf From Usuarios where email = @email AND pass = @pass");
                datos.SetearPARAMETROS("@email", usuarios.email);
                datos.SetearPARAMETROS("@pass", usuarios.pass);

                datos.ejecutarLectura();
               
                while (datos.Lector.Read())
                {
                    
                    
                    usuarios.Id = (Int64)datos.Lector["Id"];
                    usuarios.Nombre = (string)datos.Lector["Nombre"];
                    usuarios.Apellido = (string)datos.Lector["Apellido"];
                    usuarios.DNI = (Int64)datos.Lector["DNI"];
                    usuarios.IdPerfil = (Int16)datos.Lector["IdPerf"];
                    ///usuarios.pass = (string)datos.Lector["pass"];
                    ///usuarios.email = (string)datos.Lector["email"];

                    return true;
                }
                return false;
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
