using System;
using System.Collections.Generic;
using System.Text;

namespace CarteleraCine
{
    public class Funcion
    {
        public int Id { get; set; }
        public string Pelicula { get; set; } = "";
        public string Sala { get; set; } = "";
        public decimal Precio { get; set; }

        public override string ToString()
        {
            return $"{Id}. {Pelicula,-20} ({Sala}) - Q {Precio:N2}";
        }
    }
}