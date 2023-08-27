using System;
using System.Collections.Generic;

namespace ZkouskovaAPP.Models
{
    public class Books
    {

        public int ID { get; set; }
        public string Nazev { get; set; }
        public int PocetStran { get; set; }
        public string Autor { get; set; }
        public string Jazyk { get; set; }
        public DateTime DatumVydani { get; set; }
        public string Informace { get; set; }
    }
}
