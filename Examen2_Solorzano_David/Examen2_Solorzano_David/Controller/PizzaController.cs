using Examen2_Solorzano_David.Clases;
using Examen2_Solorzano_David.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examen2_Solorzano_David.Controller
{
    public class PizzaController
    {
        private PizzaModel modelo { get; set; }

        public PizzaController()
        {
            
        }

        public Boolean validarIngredientes(string ingre)
        {
            modelo = new PizzaModel();
            return modelo.validarIngredientes(ingre);
        }

        public int getPrice(string tamanio, List<string>ingredientes)
        {
            modelo = new PizzaModel();
            return modelo.getPrice(salsa, masa, queso, tamanio, ingredientes);
        }


    }
}
