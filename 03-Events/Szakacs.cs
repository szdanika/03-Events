using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Events
{
    internal class Szakacs
    {
        public event HozzavaloElkeszultKezelo HozzavaloElkeszult;
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
            Sef.kiiro(Nev + " főz '" + specialitas + "' -t");
            HozzavaloElkeszult?.Invoke(specialitas);
        }
    }
}
