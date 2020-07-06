using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Examen2_Solorzano_David.Pages
{
    public class FacturaModel : PageModel
    {
        public int precioTotal { get; set; }
        [TempData]
        public string ingrediente { get; set; }
        [TempData]
        public string salsa { get; set; }
        [TempData]
        public string masa { get; set; }
        [TempData]
        public string tamanio { get; set; }
        [TempData]
        public int precioIngredientes { get; set; }
        [TempData]
        public string queso { get; set; }
        public void OnGet()
        {

        }
    }
}