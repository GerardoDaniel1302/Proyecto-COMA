using AplicacionClientes.Datos;
using AplicacionClientes.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace AplicacionClientes.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly AplicationDbContext _context;

        public UsuarioController(AplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            //consular los datos existentes y enviarlos a la vista
            return View(await _context.Usuario.ToListAsync());
        }


        [HttpGet]
        public IActionResult Crear()
        {
            ViewBag.TiposUsuarios = new List<SelectListItem>{
                new SelectListItem{Value = "Cliente", Text = "Cliente"},
                new SelectListItem{Value = "Gerente", Text = "Gerente"},
                new SelectListItem{Value = "Administrador", Text = "Administrador"},
            };
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Crear(Usuario user)
        {
            if (ModelState.IsValid) 
            {
                _context.Usuario.Add(user);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public IActionResult Eliminar(int? id)
        {
            ViewBag.TiposUsuarios = new List<SelectListItem>{
                new SelectListItem{Value = "Cliente", Text = "Cliente"},
                new SelectListItem{Value = "Gerente", Text = "Gerente"},
                new SelectListItem{Value = "Administrador", Text = "Administrador"},
            };
            if (id ==null)
            {
                return NotFound();
                
            }
            var user = _context.Usuario.Find(id);
            if(user == null)
            {
                return NotFound();
            }
            return View(user);
        }
        [HttpPost]
        public async Task<IActionResult> BorrarRegistro(int? id)
        {
            var user = await _context.Usuario.FindAsync(id);
            if (user == null) 
            {
                return NotFound();
            }
            _context.Usuario.Remove(user);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}