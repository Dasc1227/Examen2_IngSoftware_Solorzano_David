
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

        public Boolean validarEntradas(string ingre)
        {
            ValidacionModel modelo = new ValidacionModel();
            return modelo.validarEntrada(ingre);
        }


        public int getPrice(string masa, string tamanio, List<string>ingredientes)
        {
            modelo = new PizzaModel();
            return modelo.getPrice( masa, tamanio, ingredientes);
        }

        public int getMasaPrice(string masa)
        {
            modelo = new PizzaModel();
            return modelo.getMasaPrice(masa);
        }

        public int getTamanoPrice(string tamanio)
        {
            modelo = new PizzaModel();
            return modelo.getTamanoPrice( tamanio);
        }

        public int getIngrePrice(List<string> ingre)
        {
            modelo = new PizzaModel();
            return modelo.getIngrePrice(ingre);
        }


    }
}
