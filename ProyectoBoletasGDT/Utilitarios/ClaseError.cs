using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoBoletasGDT.Utilitarios
{
    public class ClaseError
    {
        public bool Respuesta { get; set; }
        public string Mensaje { get; set; }
        public ClaseError()
        {
            this.Respuesta = true;
            this.Mensaje = string.Empty;
        }
    }
}