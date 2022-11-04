using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clases;

namespace DatoCallCenter
{
    public class DatosPrioridad
    {
        public List<Prioridades> Listar()
        {

            List<Prioridades> ListaPrio = new List<Prioridades>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearQuery("select ID, prioridad from prioridad");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Prioridades aux = new Prioridades();
                    aux.Id = (int)datos.Lector["ID"];
                    aux.Preoridad = (string)datos.Lector["prioridad"];
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
