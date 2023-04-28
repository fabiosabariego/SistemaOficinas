using Microsoft.AspNetCore.Mvc;
using SistemaOficinas.Models;

namespace SistemaOficinas.Controllers
{
    public class VeiculosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CadastroVeiculos()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CadastroVeiculos(VeiculosModel veiculosModel)
        {
            return View(veiculosModel);
        }
    }
}
