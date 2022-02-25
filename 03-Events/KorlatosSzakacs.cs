using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Events
{
    internal class KorlatosSzakacs : Szakacs
    {
        int mennyiseg;

        public KorlatosSzakacs(string nev, string specialitas, int mennyiseg) : base(nev, specialitas)
        {
            this.mennyiseg = mennyiseg;
        }
        public HozzavaloElkeszultKezelo HozzavaloNemKeszithetoEl;
        public override void Foz()
        {
            if(mennyiseg > 0)
            {
                mennyiseg--;
                base.Foz();
            }else
            {
                HozzavaloNemKeszithetoEl(specialitas);
            }
        }
    }
}
