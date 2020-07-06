using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Examen2_Solorzano_David.Controller;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Examen2_Solorzano_David.Pages
{
    public class FacturacionModel : PageModel
    {
        public int precioTotal;

        public List<string> ingredientes;

        public string salsa;

        public string masa;

        public string tamanio;

        public string queso; 
        [TempData]
        PizzaController controller { get; set; }
        public void OnGet()
        {

        }
    }
}