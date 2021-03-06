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
            kiiro("Séf: Rendelés beérkezett '" + etelNeve + "'");
            bool volt = false;
            foreach(var item in receptek)
            {
                if(etelNeve == item.Megnevezes)
                {
                    volt = true;
                    Elkeszites(item);
                }
            }
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
            {
                kiiro("Séf:Elkészült a '" + hozzavalo + "'");
                RendelesTeljesitve?.Invoke(hozzavalo);
            }
        }
        public void felvesz(Szakacs szakacs)
        {
            HozzavaloSzukseges += szakacs.SefKerValamit;
            szakacs.HozzavaloElkeszult += SzakacsElkeszult;
            if(szakacs is KorlatosSzakacs)
            {
                (szakacs as KorlatosSzakacs).HozzavaloNemKeszithetoEl += SzakacsHibatJelez;
            }
        }
        public static void kiiro(string szoveg)
        {
            Console.WriteLine(szoveg);
        }
        public void SzakacsHibatJelez(string hozzavalo)
        {
            Console.WriteLine("Szakacs hibat jelez : '" + hozzavalo+"'");
            RendelesNemTeljesitheto(hozzavalo);
        }

    }
}
