using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using CadastroWeb.Models;
using CadastroWeb.Data;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroWeb.Controllers
{
    public class ContaController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ApplicationDbContext _context;

        public ContaController(UserManager<IdentityUser> userManager, ApplicationDbContext context)
        {
            _userManager = userManager;
            _context = context;
        }

        [HttpGet]
        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Criar(string username, string firstName, string lastName, string email, DateTime birthdate, string gender, string password)
        {
            // Verifica se o nome de usuário já existe
            if (_context.Users.Any(u => u.UserName == username))
            {
                ModelState.AddModelError("username", "Nome de usuário já existe. Escolha outro.");
                return View(); // Retorna a view com os dados inseridos, mas sem os valores
            }

            var user = new IdentityUser { UserName = username, Email = email };
            var result = await _userManager.CreateAsync(user, password); // Cria o usuário

            if (result.Succeeded)
            {
                TempData["Message"] = "Conta criada com sucesso!";
                return RedirectToAction("Index", "Entrar");
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }

            // Aqui é onde você deve retornar a view com os dados preenchidos
            return View(new User
            {
                Username = username,
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                Birthdate = birthdate,
                Gender = gender
            });
        }
    }
}
