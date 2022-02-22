using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Events
{
    public delegate void HozzavaloElkeszultKezelo(string hozzavalo);
    internal class Szakacs
    {
        private string nev;
        public string Nev { get { return nev; } }
        string specialitas;
        public Szakacs(string nev, string specialitas)
        {
            this.nev = nev;
            this.specialitas = specialitas;
        }
        public void SefKerValamit(string hozzavalo)
        {
            if (hozzavalo == specialitas)
                Foz();
        }
        public void Foz()
        {
            HozzavaloElkeszultKezelo();
        }
    }
}
