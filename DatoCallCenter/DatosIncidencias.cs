using clases;
using System;
using System.Collections.Generic;

namespace DatoCallCenter
{
    public class DatosIncidencias
    {
        /*
        public List<Incidencias> Listar()
        { /*
            List<Incidencias> lista = new List<Incidencias>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearQuery("Select id, idcliente, idestado, idusuario, problematica, comentarios, tipoincidencia, prioridad from incidencia");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Incidencias aux = new Incidencias();
                    aux.Id = (Int64)datos.Lector["id"];
                    aux.IdCliente = (Int64)datos.Lector["idcliente"];
                    Estados estados = new Estados();
                    estados.Id = (Int16)datos.Lector["idestado"];
                    estados.Estado = (string)datos.Lector["estado"];
                    aux.IdUsuario = (Int64)datos.Lector["idusuario"];
                    TiposIncidencias Tin = new TiposIncidencias();
                    Tin.Id = (Int16)datos.Lector["IDtipoincidencia"];
                    Tin.Tipo = (string)datos.Lector["Tipo incidencia"];
                    Prioridades prioridades = new Prioridades();
                    prioridades.Id = (Int16)datos.Lector["Idprioridad"];
                    prioridades.Preoridad = (string)datos.Lector["Prioridad"];
                    aux.Problemática = (string)datos.Lector["problematica"];
                    aux.Comentarios = (string)datos.Lector["comentarios"];
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
        */
}
}
