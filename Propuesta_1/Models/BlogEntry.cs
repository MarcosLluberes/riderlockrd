using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Propuesta_1.Models
{
    public class BlogEntry
    {
        public int ID { get; set; }
        public string Img { get; set; }
        public string Nombre { get; set; }
        public string Fecha { get; set; }
        public string Contenido { get; set; }
        public string Autor { get; set; }
        public string Tag { get; set; }
    }
}