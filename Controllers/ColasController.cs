using Microsoft.AspNetCore.Mvc;

namespace EstructuraDeDatos.Controllers
{
    public class ColasController : Controller
    {
        // --- Ejercicio 1: Ventanilla de un banco ---
        public IActionResult VentanillaBanco()
        {
            return View();
        }

        // --- Ejercicio 2: Juego pintar coches ---
        public IActionResult PintarCoches()
        {
            return View();
        }

        // --- Ejercicio 3: Estacionamiento para autos ---
        public IActionResult Estacionamiento()
        {
            return View();
        }
    }
}
