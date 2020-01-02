using System;
using System.Collections.Generic;
using System.Text;
using Pattern_Flyweight.Interfaces;

namespace Pattern_Flyweight.Clases
{
    public class Expresso : IFlyweight // Utiliza la interfaz IFlyweight para definir las caracteristicas de este producto
    {
        public String TipodeCafe()
        {
            return "Amargo";
        }
        public String TipodeLiquido()
        {
            return "Agua";
        }
        public String Extras()
        {
            return "N/A";
        }
        public String Precio()
        {
            return "2 $";
        }
    }
}

