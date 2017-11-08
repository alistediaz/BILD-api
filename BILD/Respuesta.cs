using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BILD
{
    public class Respuesta
    {
        public int status { get; set; }
        public string error { get; set; }
        public Msg msg { get; set; }

    }
}