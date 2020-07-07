
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examen2_Solorzano_David.Modelos
{
    public class PizzaModel
    {
        

        public int getPrice(string masa,string tamanio, List<string> ingredientes)
        {
            int total = 0;
            total += 1000 + getMasaPrice(masa)+getTamanoPrice(tamanio)+(ingredientes.Count*500);  
            return total; //impuesto
        }

        public int getMasaPrice(string masa)
        {
            int precio = 0;
            switch (masa)
            {
                case "original":
                    precio += 1000;
                break;
                case "crunchy":
                    precio += 1500;
                break;
                case "sarten":
                    precio += 2000;
                break;
                case "queso":
                    precio += 2000;
                break;
            }

            return precio;
        }

        public int getTamanoPrice(string tamanio)
        {
            int precio = 0;
            switch (tamanio)
            {
                case "pequena":
                    precio += 4000;
                    break;
                case "mediana":
                    precio += 4500;
                    break;
                case "grande":
                    precio += 5000;
                    break;
                case "extra":
                    precio += 6000;
                    break;
            }

            return precio;
        }
        public int getIngrePrice(List<string> ingre)
        {
            return (ingre.Count * 500);
        }

    }
}
