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
        private string[] Pizza_base; //Salsa, Queso, Masa y Tamano

        public Pizza()
        {
            this.Pizza_base = new string[4];
        }

        public class Builder
        {
            private Pizza pisa;
            
            public Builder()
            {
                this.pisa = new Pizza();
            }

            public Builder agregarBase(string [] pizza_bases)
            {
                this.pisa.Pizza_base[0] = pizza_bases[0]; //Masa
                this.pisa.Pizza_base[1] = pizza_bases[1]; //Tamano
                this.pisa.Pizza_base[2] = pizza_bases[2]; //Salsa
                this.pisa.Pizza_base[3] = pizza_bases[3]; //Queso

                return this;
            }

            public Builder agregarIngredientes(List<string> ingredientes)
            {
                return this;
            }

            public Pizza build()
            {
                return this.pisa;
            }
        }

    }
}
        
    

