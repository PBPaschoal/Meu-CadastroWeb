using Microsoft.AspNetCore.Mvc;

namespace CadastroWeb.Controllers
{
    public class EntrarController : Controller
    {
        // Método GET para exibir a página de login
        public IActionResult Index()
        {
            return View();
        }

        // Método GET para exibir a página de criar conta
        public IActionResult Cadastrar()
        {
            return View();
        }

        // Método POST para processar o formulário de criação de conta
        [HttpPost]
        public IActionResult Cadastrar(string nome, string sobrenome, DateTime dataNascimento, string sexo, string email, string password)
        {
            // Aqui você pode fazer a validação dos dados e salvar no banco de dados.
            // Exemplo simples: Exibir uma mensagem de sucesso
            if (ModelState.IsValid)
            {
                // Você pode salvar esses dados em um banco de dados ou realizar outras operações
                ViewBag.Message = "Conta criada com sucesso!";
                return View("Index"); // Redireciona para a página de login ou para uma página de sucesso
            }

            // Se algo estiver errado, retornar à mesma página com os dados e mensagens de erro
            return View();
        }
    }
}
