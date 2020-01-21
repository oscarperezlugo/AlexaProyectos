using System;
using System.Collections.Generic;
using System.Text;

namespace AlexaProyectos.models
{
    public class Scan
    {
        public string articulo { get; set; }
        public string almacen { get; set; }
        public string proyecto { get; set; }
        public string lote { get; set; }
        public string capitulo { get; set; }
        public string unidad { get; set; }
        public string fecha { get; set; }

    }
    public class Send
    {
        public string CodigoProyecto { get; set; }
        public string AnaCapitulo { get; set; }
        public string AnaLote { get; set; }
    }
    public class Retorno
    {
        public string retorno { get; set; }
        public string message { get; set; }
    }
}
