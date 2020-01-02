using System;
using System.Collections.Generic;
using System.Text;
/*
 La interfaz que permite compartir las caraccteristicas que puede tener un Objeto 
     */
namespace Pattern_Flyweight.Interfaces
{
    public interface IFlyweight 
    {
        String TipodeCafe();// Permite definir el tipo de cafe que se utiliza en la preparacion
        String TipodeLiquido();// Permite definir si se utiliza agua o leche de cualquier tipo
        String Extras();// Si se le añide algun extra como canela o caramelo
        String Precio();// Permite definir el costo de del producto 

    }
}
