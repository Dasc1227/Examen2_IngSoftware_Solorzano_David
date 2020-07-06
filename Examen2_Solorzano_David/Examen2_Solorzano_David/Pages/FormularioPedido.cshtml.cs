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
        public string Message { get; set; }

        [TempData]
        PizzaController controller { get; set; }
        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            controller = new PizzaController();
            string salsa = Request.Form["salsa"].ToString();
            string masa = Request.Form["masa"].ToString();
            string queso = Request.Form["queso"].ToString();
            string tamanio = Request.Form["tamano"].ToString();
            string ingrediente = Request.Form["check"].ToString();

            if (!controller.validarIngredientes(ingrediente))
            {
                Message = "Hacen falta valores";
                return RedirectToPage("FormularioPedido");
            }
            List<string> ingredientes = ingrediente.Split(",").ToList();
            controller.guardarDatos(salsa, masa, queso, tamanio, ingredientes);

            return RedirectToPage("Facturacion");
        }
    }
}