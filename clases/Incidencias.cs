﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases
{
    internal class Incidencias
    {
        public int      Id                  { get; set; }
        public int      NroIncidencias      { get; set; }
        public int      IdCliente           { get; set; }
        public int      IdEstado            { get; set; }
        public int      IdPreoridad         { get; set; }
        public int      IdTipoIncidencia    { get; set; }
        public int      IdUsuario           { get; set; }
        public string   Problemática        { get; set; }
    }
}