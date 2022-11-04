using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clases;

namespace DatoCallCenter
{
    public class DatosEstados
    {

        public List<Estados> Listar()
        {
            List<Estados> ListaE = new List<Estados>();
            AccesoDatos datos = new AccesoDatos();
            try
            {

                datos.setearQuery("select ID, Estados from Estados");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Estados aux = new Estados();
                    aux.Id = (int)datos.Lector["ID"];
                    aux.Estado = (string)datos.Lector["Estados"];
                    ListaE.Add(aux);

                }
                return ListaE;

            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
