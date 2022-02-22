using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Events
{
    internal class Sef
    {
        public event RendelesTeljesitesKezelo RendelesTeljesitve;
        public event RendelesTeljesitesKezelo RendelesNemTeljesitheto;
        public event HozzavaloSzuksegesKezelo HozzavaloSzukseges;


        Etel[] receptek = new Etel[]
        {
            new Etel("poharviz", new string[] { "viz" } ),
            new Etel("leves", new string[] { "repa", "hus", "krumpli", "viz" } ),
            new Etel("rantothus", new string[] { "hus", "krumpli" } ),
            new Etel("fozelek", new string[] { "viz", "repa" } )
        };
        public void Megrendeles(string etelNeve)
        {
            bool volt = false;
            foreach(var item in receptek)
            {
                if(etelNeve == item.Megnevezes)
                {
                    volt = true;
                }
            }
            kiiro("beérkezett a rendelés:" + etelNeve);
            if (!volt)
                RendelesNemTeljesitheto?.Invoke(etelNeve);
        }
        private int szuksegesHozzavaloSzam;
        public void Elkeszites(Etel recept)
        {
            szuksegesHozzavaloSzam = recept.Hozzavalok.Length;
            foreach(string item in recept.Hozzavalok)
            {
                HozzavaloSzukseges?.Invoke(item);
            }
        }
        public void SzakacsElkeszult(string hozzavalo)
        {
            szuksegesHozzavaloSzam--;
            if (szuksegesHozzavaloSzam == 0)
                RendelesTeljesitve?.Invoke(hozzavalo);
        }
        public void felvesz(Szakacs szakacs)
        {
            HozzavaloSzukseges += szakacs.SefKerValamit;
            szakacs.HozzavaloElkeszult += SzakacsElkeszult;
        }
        public void kiiro(string szoveg)
        {
            Console.WriteLine(szoveg);
        }

    }
}
