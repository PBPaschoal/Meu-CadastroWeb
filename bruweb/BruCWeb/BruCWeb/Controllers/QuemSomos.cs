using Microsoft.AspNetCore.Mvc;

namespace CadastroWeb.Controllers
{
    public class QuemSomosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
