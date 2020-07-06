using Examen2_Solorzano_David.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examen2_Solorzano_David.Modelos
{
    public class PizzaModel
    {
        private Pizza pizza;
        public Boolean validarIngredientes(string ingre)
        {
            if (ingre.Equals(""))
            {
                return false;
            }
            return true;
        }

        public void guardarDatos(string salsa, string masa, string tamanio, string queso, List<string> ingredientes)
        {
            this.pizza = new Pizza.Builder().agregarSalsa(salsa).agregarMasa(masa).agregarQueso(queso).agregarIngredientes(ingredientes).build();
        }
    }
}
