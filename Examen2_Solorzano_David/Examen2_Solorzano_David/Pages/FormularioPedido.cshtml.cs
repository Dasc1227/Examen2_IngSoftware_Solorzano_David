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
        PizzaController controller { get; set; }
        public void OnGet()
        {

        }

        public void OnPost()
        {
            controller = new PizzaController();
            string salsa = Request.Form["salsa"].ToString();
            string masa = Request.Form["masa"].ToString();
            string queso = Request.Form["queso"].ToString();
            string tamanio = Request.Form["tamano"].ToString();
            string valor = Request.Form["check"].ToString();
            List<string> ingredientes = valor.Split(",").ToList();
        }
    }
}