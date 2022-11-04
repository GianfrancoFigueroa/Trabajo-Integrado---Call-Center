using clases;
using System;
using System.Collections.Generic;

namespace DatoCallCenter
{
    public class DatosIncidencias
    {
        
        public List<Incidencias> Listar()
        { 
            List<Incidencias> lista = new List<Incidencias>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearQuery("Select I.ID as 'ID', I.IDcliente as 'IdCliente', E.ID as 'idestado', E.Estados as 'Estado', T.ID as 'IDtipoincidencia', T.TipoInc as 'Tipo Incidencia', P.ID as 'IDprioridad', P.Prioridad as 'Prioridad', I.IDusuario as 'IDusuario', I.Problematica as 'Problematica' from Incidencia I, Clientes C, Estados E , Usuarios U, TipoIncidencia T, prioridad p where C.Id = I.IDcliente and E.Id = I.IDestado and U.ID = I.IDusuario and T.ID = I.TipoIncidencia And P.ID = I.Prioridad");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Incidencias aux = new Incidencias();
                    aux.Id = (int)datos.Lector["ID"];
                    aux.IdCliente = (int)datos.Lector["IdCliente"];
                    Estados estados = new Estados();
                    estados.Id = (int)datos.Lector["idestado"];
                    estados.Estado = (string)datos.Lector["Estado"];
                    aux.IdUsuario = (int)datos.Lector["IDusuario"];
                    TiposIncidencias Tin = new TiposIncidencias();
                    Tin.Id = (int)datos.Lector["IDtipoincidencia"];
                    Tin.Tipo = (string)datos.Lector["Tipo Incidencia"];
                    Prioridades prioridades = new Prioridades();
                    prioridades.Id = (int)datos.Lector["IDprioridad"];
                    prioridades.Preoridad = (string)datos.Lector["Prioridad"];
                    aux.Problemática = (string)datos.Lector["Problematica"];
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
