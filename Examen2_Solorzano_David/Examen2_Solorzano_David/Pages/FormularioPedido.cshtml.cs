using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Examen2_Solorzano_David.Controller;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Examen2_Solorzano_David.Pages
{
    public class FormularioPedidoModel : PageModel

    {
        [TempData]
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
        [TempData]
        public string Message { get; set; }

        [TempData]
        PizzaController controller { get; set; }
        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            controller = new PizzaController();
            salsa = Request.Form["salsa"].ToString();
            masa = Request.Form["masa"].ToString();
            queso = Request.Form["queso"].ToString();
            tamanio = Request.Form["tamano"].ToString();
            ingrediente = Request.Form["check"].ToString();

            if (ingrediente.Equals(""))
            {
                Message = "Hacen falta valores";
                return RedirectToPage("FormularioPedido");
            }
            List<string> ingredientes = ingrediente.Split(",").ToList();
            controller.guardarDatos(salsa, masa, queso, tamanio, ingredientes);
            precioIngredientes = controller.getIngredientesPrecio();
            precioTotal = 500 + 1000 + 1000 + precioIngredientes;
            return RedirectToPage("FormularioPedido");
        }
    }
}