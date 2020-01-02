using System;
using System.Collections.Generic;
using System.Text;
using Pattern_Flyweight.Interfaces;

namespace Pattern_Flyweight.Clases
{
    public class FlyweightFactory
    {
        Dictionary<string,IFlyweight> Cafes = new Dictionary<string,IFlyweight>(); // se define un diccionario para las opciones de productos
        
        public IFlyweight GetFlyweight(string nombre)
        {
            IFlyweight cafe = null;
            if (Cafes.ContainsKey(nombre))
            {
                 cafe=Cafes[nombre];
            }
            else
            {
                if (nombre == "Expresso") // si se pide un expresso salen las caracteristicas de esa bebida
                {
                    cafe = new Expresso();
                    Cafes.Add("Expresso", cafe); // se añade el producto al diccionario
                }
                else if (nombre == "Caramelo Macchiato")
                {
                    cafe = new CarameloMacchiato();
                    Cafes.Add("CarameloMacchiato", cafe);// se añade el producto al diccionario
                }
                else if (nombre == "Capuchino con Canela")
                {
                    cafe = new CapuchinoconCanela();
                    Cafes.Add("Capuchino con Canela", cafe);// se añade el producto al diccionario
                }
                else
                {
                    throw new Exception("Esta bebida no existe en el sistema");//salta una excepcion si el prodcucto no existe
                }
            }
            return cafe;
        }
    }
}
