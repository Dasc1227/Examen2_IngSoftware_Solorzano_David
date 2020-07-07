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
        public string ingrediente { get; set; }
        [TempData]
        public string salsa { get; set; }
  
        [TempData]
        public int precioMasa { get; set; }
        [TempData]
        public int precioTamano { get; set; }
        [TempData]
        public int precioIngre { get; set; }
        [TempData]
        public int precioTotal { get; set; }
        [TempData]
        public string masa { get; set; }
        [TempData]
        public string tamanio { get; set; }
        [TempData]
        public string direccion { get; set; }

        [TempData]
        public string queso { get; set; }
        [TempData]
        public string Message { get; set; }

 
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
            direccion = Request.Form["direccion"].ToString();
            if (!controller.validarEntradas(ingrediente))
            {
                Message = "Por favor escoga al menos un ingrediente";
                return RedirectToPage("FormularioPedido");
            }
            if (!controller.validarEntradas(direccion))
            {
                Message = "Por favor llene el campo de Direccion";
                return RedirectToPage("FormularioPedido");
            }
            List<string> ingredientes = ingrediente.Split(",").ToList();
            precioMasa = controller.getMasaPrice(masa);
            precioTamano = controller.getTamanoPrice(tamanio);
            precioTotal = controller.getPrice(masa, tamanio, ingredientes);
            precioIngre = controller.getIngrePrice(ingredientes);
    
            return RedirectToPage("Factura");
        }
    }
}