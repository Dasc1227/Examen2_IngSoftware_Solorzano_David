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
            this.modelo = new PizzaModel();
        }

        public Boolean validarIngredientes(string ingre)
        {
            return modelo.validarIngredientes(ingre);
        }

        public void guardarDatos(string salsa, string masa, string tamanio, string queso, List<string> ingredientes)
        {
            this.modelo.guardarDatos( salsa,  masa,  tamanio,  queso,  ingredientes);
        }
    }
}
