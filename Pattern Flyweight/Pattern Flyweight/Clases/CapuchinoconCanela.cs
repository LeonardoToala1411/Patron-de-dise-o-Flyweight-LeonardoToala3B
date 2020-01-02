using System;
using System.Collections.Generic;
using System.Text;
using Pattern_Flyweight.Interfaces;

namespace Pattern_Flyweight.Clases
{
    public class CapuchinoconCanela: IFlyweight // Utiliza la interfaz IFlyweight para definir las caracteristicas de este producto
    {
    
        public String TipodeCafe()
        {
            return "Normal";
        }
        public String TipodeLiquido()
        {
            return "Leche";
        }
        public String Extras()
        {
            return "Canela";
        }
        public String Precio()
        {
            return "3.5 $";
        }
    }
}
