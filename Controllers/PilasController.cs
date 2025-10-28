using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EstructuraDeDatos.Controllers
{
    public class PilasController : Controller
    {
        // --- Ejercicio 1: Invertir palabra ---
        [HttpGet]
        public IActionResult InvertirPalabra()
        {
            return View();
        }

        // --- Ejercicio 2: Palíndromo ---
        [HttpGet]
        public IActionResult Palindromo()
        {
            return View();
        }

        // --- Ejercicio 3: Suma números grandes ---
        [HttpGet]
        public IActionResult SumaNumerosGrandes()
        {
            return View();
        }

        // --- Ejercicio 4: Reemplazar valor ---
        [HttpGet]
        public IActionResult ReemplazarValor()
        {
            return View();
        }
    }
}
