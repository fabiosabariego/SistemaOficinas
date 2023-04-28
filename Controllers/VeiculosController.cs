using Microsoft.AspNetCore.Mvc;

namespace SistemaOficinas.Controllers
{
    public class VeiculosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
