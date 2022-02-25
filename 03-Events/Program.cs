using System;

namespace _03_Events
{
    internal class Program
    {
        public static void test1()
        {
            Sef asef = new Sef();
            asef.RendelesTeljesitve += Sikerult;
            asef.RendelesNemTeljesitheto += NemSikerult;
            Szakacs aszak = new Szakacs("Szebasztián", "viz");
            asef.felvesz(aszak);
            asef.Megrendeles("poharviz");
            asef.Megrendeles("kecskesajt");
        }
        public static void test2()
        {
            Sef asef = new Sef();
            asef.RendelesTeljesitve += Sikerult;
            asef.RendelesNemTeljesitheto += NemSikerult;
            KorlatosSzakacs ksz = new KorlatosSzakacs("Szebi", "repa", 2);
            Szakacs aszak = new Szakacs("Szebasztián", "viz");
            asef.felvesz(ksz);
            asef.felvesz(aszak);
            asef.Megrendeles("poharviz");
            for (int i = 0; i < 5; i++)
                asef.Megrendeles("fozelek");
        }
        public static void Sikerult(string nev)
        {
            Console.WriteLine("* Rendelés teljesítve : '"+ nev +"'");
        }
        public static void NemSikerult(string nev)
        {
            Console.WriteLine("Nem sikerült teljesíteni a rendelést");
        }
        static void Main(string[] args)
        {
            test2();
        }
    }
}
