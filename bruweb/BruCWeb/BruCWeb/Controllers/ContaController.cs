using Microsoft.AspNetCore.Mvc;

namespace BruCWeb.Controllers
{
    public class ContaController : Controller
    {
        [HttpGet]
        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(string username, string password)
        {
            return RedirectToAction("Entrar", "Conta");
        }
    }
}
