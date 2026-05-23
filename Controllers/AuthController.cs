using GestionEnvios.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GestionEnvios.Controllers
{
    public class AuthController : Controller
    {
        private readonly AppDbContext _context;

        public AuthController(AppDbContext context)
        {
            _context = context;
        }
        //mostrar pantalla de login
        public IActionResult Login()
        {
            return View();
        }
        //procesar el login
        [HttpPost]
        public async Task<IActionResult> Login(string username, string password)
        {
            var usuario = await _context.Usuarios
                .FirstOrDefaultAsync(u => u.Username == username
                                       && u.Password == password);

            if (usuario == null)
            {
                ViewBag.Error = "Usuario o contraseña incorrectos";
                return View();
            }

            // Guardar en sesión que el usuario está logueado
            HttpContext.Session.SetString("Usuario", usuario.Username);
            return RedirectToAction("Index", "Shipments");
        }
        //Cerrar sesión
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}
