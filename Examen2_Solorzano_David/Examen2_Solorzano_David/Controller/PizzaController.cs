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
        private Pizza modelo { get; set; }

        public PizzaController()
        {
            
        }

        public Boolean validarIngredientes(string ingre)
        {
            return modelo.validarIngredientes(ingre);
        }

        public void guardarDatos(string salsa, string masa, string tamanio, string queso, List<string> ingredientes)
        {
            this.modelo  = new Pizza.Builder().agregarSalsa(salsa).agregarMasa(masa).agregarQueso(queso).agregarIngredientes(ingredientes).build();
        }

       public string getSalsa()
        {
            return modelo.getSalsa();
        }
        public string getMasa()
        {
            return modelo.getMasa();
        }
        public string getQueso()
        {
            return modelo.getQueso();
        }

        public string getTamanio()
        {
            return modelo.getTamanio();
        }

        public string getIngredientes()
        {
            return String.Join(", ", modelo.getIngredientes().ToArray());

        }

        public int getIngredientesPrecio()
        {
            return modelo.getIngredientesPrecio();
        }

        public int getPrecioTotal()
        {
            return modelo.getPrecioTotal();
        }

    }
}
