using System;

namespace Vsite.CSharp
{
    class MojaKlasa
    {
        //Dodati jedna privatno polje (podatkovni član)
        int x = 1;

        //Dodati javnu metodu koja će ispisati podatkovni član
        public int DajMiXa()
        {
            return this.x;
        }
    }


    struct MojaStruktura
    {
        //Dodati jedna privatno polje (podatkovni član)
        string s = "text";

        //Dodati javnu metodu koja će ispisati podatkovni član
        public string DajMiStringa()
        {
            return s;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            //Inicijalizirati objekt tipa MojaKlasa i pozvati njegovu metodu
            MojaKlasa broj = new MojaKlasa();
            Console.WriteLine(broj.DajMiXa());
            //Inicijalizirati objekt tipa MojaStruktura i pozvati njegovu metodu
            MojaStruktura rijec = new MojaStruktura();
            Console.WriteLine(rijec.DajMiStringa());
            Console.ReadKey();
        }
    }
}
