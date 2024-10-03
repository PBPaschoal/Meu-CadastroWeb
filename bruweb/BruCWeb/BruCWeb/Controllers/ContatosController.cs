using Microsoft.AspNetCore.Mvc;

namespace CadastroWeb.Controllers
{
    public class ContatosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
