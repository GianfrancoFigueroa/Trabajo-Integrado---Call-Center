using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases
{
    public class Incidencias
    {
        public int Id                  { get; set; }
        public int IdCliente           { get; set; }
        public Estados  Estado            { get; set; }
        public Prioridades  Prioridad     { get; set; }
        public TiposIncidencias   TipoIncidencia    { get; set; }
        public int IdUsuario           { get; set; }
        public string   Problemática        { get; set; }
        public string   Comentarios         { get; set; }
    }
}
