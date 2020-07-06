
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examen2_Solorzano_David.Modelos
{
    public class PizzaModel
    {
        
        public Boolean validarIngredientes(string ingre)
        {
            if (ingre.Equals(""))
            {
                return false;
            }
            return true;
        }
        public int getPrice(string masa,string tamanio, List<string> ingredientes)
        {
            int total = 0;
            total += 1000 + getMasaPrice(masa)+getTamanoPrice(tamanio)+(ingredientes.Count*500);  //Salsa, Queso
            return total;
        }

        public int getMasaPrice(string masa)
        {
            int precio = 0;
            if (masa.Equals("original"))
                precio += 1000;
            if (masa.Equals("crunchy"))
                precio += 1500;
            if (masa.Equals("sarten") || masa.Equals("queso"))
                precio += 2000;

            return precio;
        }

        public int getTamanoPrice(string masa)
        {
            int precio = 0;
            if (masa.Equals("peque"))
                precio += 4000;
            if (masa.Equals("media"))
                precio += 4500;
            if (masa.Equals("grande") )
                precio += 5000;
            if (masa.Equals("extra"))
                precio += 6000;
            return precio;
        }

    }
}
