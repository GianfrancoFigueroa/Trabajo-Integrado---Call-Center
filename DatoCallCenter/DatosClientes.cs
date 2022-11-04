using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using clases;

namespace DatoCallCenter
{
    public class DatosClientes
    {
        public List<Clientes> Listar()
        {
            List<Clientes>lista=new List<Clientes>();
            AccesoDatos datos= new AccesoDatos();
            try
            {
                datos.setearQuery("Select Id,NomClien,ApellClien,DNIClien,Tel,Email,Domicilio From Clientes");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Clientes aux = new Clientes();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Nombre = (string)datos.Lector["NomClien"];
                    aux.Apellido = (string)datos.Lector["ApellClien"];
                    aux.DNI = (int)datos.Lector["DNIClien"];
                    aux.Teléfono = (string)datos.Lector["Tel"];
                    aux.Email = (string)datos.Lector["Email"];
                    aux.Domicilio = (string)datos.Lector["Domicilio"];
                    lista.Add(aux);
                } 
                return lista;

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
