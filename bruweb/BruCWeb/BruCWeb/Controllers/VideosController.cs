using Microsoft.AspNetCore.Mvc;

namespace CadastroWeb.Controllers
{
    public class VideosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
