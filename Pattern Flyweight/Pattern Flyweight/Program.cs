using System;
using Pattern_Flyweight.Clases;
using Pattern_Flyweight.Interfaces;

namespace Pattern_Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            FlyweightFactory flyweightFactory = new FlyweightFactory();
            IFlyweight cafe = flyweightFactory.GetFlyweight("Expresso");
            Console.WriteLine("*************Expresso****************");
            Console.WriteLine("Tipo de Cafe = " + cafe.TipodeCafe());
            Console.WriteLine("Tipo de Liquido = " + cafe.TipodeLiquido());
            Console.WriteLine("Extras = " + cafe.Extras());
            Console.WriteLine("Precio = " + cafe.Precio());
            cafe = flyweightFactory.GetFlyweight("Caramelo Macchiato");
            Console.WriteLine("**********Caramelo Macchiato*********");
            Console.WriteLine("Tipo de Cafe = " + cafe.TipodeCafe());
            Console.WriteLine("Tipo de Liquido = " + cafe.TipodeLiquido());
            Console.WriteLine("Extras = " + cafe.Extras());
            Console.WriteLine("Precio = " + cafe.Precio());
            cafe = flyweightFactory.GetFlyweight("Capuchino con Canela");
            Console.WriteLine("*********Capuchino con Canela********");
            Console.WriteLine("Tipo de Cafe = " + cafe.TipodeCafe());
            Console.WriteLine("Tipo de Liquido = " + cafe.TipodeLiquido());
            Console.WriteLine("Extras = " + cafe.Extras());
            Console.WriteLine("Precio = " + cafe.Precio());
            cafe = flyweightFactory.GetFlyweight("Tea Verde");
            Console.WriteLine("**************Tea Verde**************");
            Console.WriteLine("Tipo de Cafe = " + cafe.TipodeCafe());
            Console.WriteLine("Tipo de Liquido = " + cafe.TipodeLiquido());
            Console.WriteLine("Extras = " + cafe.Extras());
            Console.WriteLine("Precio = " + cafe.Precio());
            Console.ReadKey();
        }
    }
}
