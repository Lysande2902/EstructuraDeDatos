using Microsoft.AspNetCore.Mvc;

namespace EstructuraDeDatos.Controllers
{
    public class ListasController : Controller
    {
        // Ejercicio 1: Productos disponibles y retirados
        public IActionResult ProductosDisponiblesRetirados()
        {
            return View();
        }

        // Ejercicio 2: Pares e Impares
        public IActionResult ParesImpares()
        {
            return View();
        }

        // Ejercicio 3: Aprobados y Reprobados
        public IActionResult AprobadosReprobados()
        {
            return View();
        }

        // Ejercicio 4: Eliminar y ordenar productos
        public IActionResult EliminarOrdenarProductos()
        {
            return View();
        }

        // Ejercicio 5: Listar palabras por letra
        public IActionResult ListarPalabrasPorLetra()
        {
            return View();
        }
    }
}
