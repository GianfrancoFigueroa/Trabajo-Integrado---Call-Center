using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clases;

namespace DatoCallCenter
{
    public class DatosTipoIncidencia
    {
        public List<TiposIncidencias> Listar()
        {

            List<TiposIncidencias> ListaPrio = new List<TiposIncidencias>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearQuery("select ID, TipoInc from TipoIncidencia");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    TiposIncidencias aux = new TiposIncidencias();
                    aux.Id = (int)datos.Lector["ID"];
                    aux.Tipo = (string)datos.Lector["TipoInc"];
                    ListaPrio.Add(aux);

                }
                return ListaPrio;

            }
            catch (Exception)
            {

                throw;
            }

        }

    }
}
