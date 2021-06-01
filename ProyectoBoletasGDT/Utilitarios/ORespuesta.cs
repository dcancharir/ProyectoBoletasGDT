using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoBoletasGDT.Utilitarios
{
    public class ORespuesta
    {
        public string mensaje { get; set; }
        public bool respuesta { get; set; }
        public object data { get; set; }
        public ORespuesta()
        {
            mensaje = string.Empty;
            respuesta = false;
        }
    }
}