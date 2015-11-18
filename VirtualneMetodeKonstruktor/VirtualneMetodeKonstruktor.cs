using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vsite.CSharp
{
    class Bazna
    {
        public Bazna()
        {
            Inicijalizacija();
        }

        protected virtual void Inicijalizacija()
        {
            // dodati kod za inicijalizaciju članova bazne
            Bazna clan = new Bazna();
        }

        public int a;
        public string b;
    }

    class Izvedena : Bazna
    {
        public Izvedena()
        {
        }

        protected override void Inicijalizacija()
        {
            // dodati kod za inicijalizaciju članova izvedene klase
            Izvedena clanI = new Izvedena();
        }

        public double c;
    }

    class VirtualneMetodeKonstruktor
    {
        static void Main(string[] args)
        {
            //stvoriti po jednu instancu bazne i izvedene klase i provjeriti jesu li inicijalizirani svi njihovi članovi. Napraviti potrebne promjene.
            Bazna prvi = new Bazna();
            Izvedena drugi = new Izvedena();

            Console.ReadKey();
        }
    }
}
