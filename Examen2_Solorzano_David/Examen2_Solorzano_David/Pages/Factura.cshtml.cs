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

        [TempData]
        public string ingrediente { get; set; }
        [TempData]
        public string salsa { get; set; }
        [TempData]
        public string masa { get; set; }
        [TempData]
        public string tamanio { get; set; }
        [TempData]
        public string direccion { get; set; }
        [TempData]
        public string queso { get; set; }
        [TempData]
        public int precioIngre { get; set; }
        [TempData]
        public int precioMasa { get; set; }
        [TempData]
        public int precioTamano { get; set; }
        [TempData]
        public int precioTotal { get; set; }
        public void OnGet()
        {

        }
    }
}