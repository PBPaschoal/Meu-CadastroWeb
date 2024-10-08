using Microsoft.AspNetCore.Mvc;

namespace CadastroWeb.Controllers {
    public class EntrarController : Controller {
        public IActionResult Index() {
            return View();
        }

        public IActionResult Cadastrar() {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(string nome, string sobrenome, DateTime dataNascimento, string sexo, string email, string password) {
            if (ModelState.IsValid) {
                TempData["Message"] = "Conta criada com sucesso!";
                return RedirectToAction("Index");
            }

            return View();
        }
    }
}
