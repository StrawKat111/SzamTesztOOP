using System;
using SzamTesztOOP;

namespace SzamTesztOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SzamTeszt teszt1 = new SzamTeszt();
            teszt1.SetSzam1(7);
            teszt1.SetSzam2(7);
            teszt1.SetEredmeny();
            Console.WriteLine(teszt1.GetEredmeny());

            SzamTeszt teszt2 = new SzamTeszt();
            teszt2.SetSzam1(3);
            teszt2.SetSzam2(8);
            teszt2.SetEredmeny();
            Console.WriteLine(teszt2.GetEredmeny());
        }
    }
}