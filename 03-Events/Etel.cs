using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Events
{
    internal class Etel
    {
        String megnevezes;
        public String Megnevezes { get => megnevezes; }
        string[] hozzavalok;
        public String[] Hozzavalok { get => hozzavalok; }
        public Etel(string megnevezes, string[] hozzavalok)
        {
            this.megnevezes = megnevezes;
            this.hozzavalok = hozzavalok;
        }
        public delegate void RendelesTeljesitesKezelo(string etelNeve);
        public delegate void HozzavaloSzuksegesKezelo(string hozzavalo);
        public delegate void HozzavaloElkeszultKezelo(string hozzavalo);
    }
}
