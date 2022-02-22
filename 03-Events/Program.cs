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
        public static void Sikerult(string nev)
        {
            Console.WriteLine("Rendelés teljesítve");
        }
        public static void NemSikerult(string nev)
        {
            Console.WriteLine("Nem sikerült teljesíteni");
        }
        static void Main(string[] args)
        {
            test1();
        }
    }
}
