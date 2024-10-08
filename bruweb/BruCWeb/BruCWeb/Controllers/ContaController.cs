using Microsoft.AspNetCore.Mvc;
using CadastroWeb.Models; // Supondo que você tenha um modelo para as contas
using System.Linq;
using CadastroWeb.Data;

namespace CadastroWeb.Controllers
{
    public class ContaController : Controller
    {
        private readonly ApplicationDbContext _context; // A injeção do contexto do banco

        public ContaController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(string username, string firstName, string lastName, string email, DateTime birthdate, string gender, string password)
        {
            // Verifica se o nome de usuário já existe
            if (_context.Users.Any(u => u.Username == username))
            {
                ModelState.AddModelError("username", "Nome de usuário já existe. Escolha outro.");
                return View();
            }

            // Aqui você implementa a lógica de criação da conta, salvando no banco de dados
            var user = new User
            {
                Username = username,
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                Birthdate = birthdate,
                Gender = gender,
                Password = password // Não esqueça de criptografar a senha
            };

            _context.Users.Add(user);
            _context.SaveChanges();

            TempData["Message"] = "Conta criada com sucesso!";
            return RedirectToAction("Index", "Entrar");
        }
    }
}
