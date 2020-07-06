using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examen2_Solorzano_David.Clases
{
    public class Pizza
    {
        private List<string> ingredientes;
        private List<int> precios;
        private int precioTotal;
        private string salsa;
        private string tamano;
        private string masa;
        private string queso;

        public Pizza()
        {
            
        }

        public List<string>getIngredientes()
        {
            return this.ingredientes;
        }

        public List<int> getPrecios()
        {
            return this.precios;
        }

        public int getPrecioTotal()
        {
            return this.precioTotal;
        }

        public class Builder
        {
            private Pizza pisa;
            
            public Builder()
            {
                this.pisa = new Pizza();
            }

            public Builder agregarSalsa(string sauce)
            {
                pisa.salsa = sauce;

                return this;
            }

            public Builder agregarQueso(string quesos)
            {
                pisa.queso = quesos;

                return this;
            }

            public Builder agregarMasa(string sauce)
            {
                pisa.masa = sauce;

                return this;
            }

            public Builder agregarTamano(string tamanio)
            {
                pisa.tamano = tamanio;
                if (tamanio.Equals("peque"))
                    pisa.precioTotal += 5000;
                if (tamanio.Equals("media"))
                    pisa.precioTotal += 5500;
                if (tamanio.Equals("grande"))
                    pisa.precioTotal += 6000;
                if (tamanio.Equals("extra"))
                    pisa.precioTotal += 6500;
                return this;
            }

            public Builder agregarIngredientes(List<string> ingrediente)
            {
                pisa.ingredientes = ingrediente;
                pisa.precioTotal += 500*ingrediente.Count;
                return this;
            }

            public Pizza build()
            {
                return this.pisa;
            }
        }

    }
}
        
    

