using System;

namespace OOPLabb3
{
    class Program
    {
        static void Main(string[] args)
        {
            Teckning c1 = new Circle();

            Teckning f1 = new Fyrkant();

            Teckning r1 = new Rektangel();

            Console.WriteLine($"Area cirkel: {c1.Area():f2}");
            Console.WriteLine($"Area fyrkant: {f1.Area():f2}");
            Console.WriteLine($"Area rektangel: {r1.Area():f2}");
        }
    }
}
