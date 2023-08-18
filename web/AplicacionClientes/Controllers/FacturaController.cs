using AplicacionClientes.Datos;
using AplicacionClientes.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace AplicacionClientes.Controllers
{
    public class FacturaController : Controller
    {
        private readonly AplicationDbContext _context;

        public FacturaController(AplicationDbContext context)
        {
            _context = context;
        }
        
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            //consular los datos existentes y enviarlos a la vista
            return View(await _context.Factura.ToListAsync());
        }

        [HttpGet]
        public async Task<IActionResult> Crear()
        {
            var listUsuarios = new List<Usuario>();
            listUsuarios = await _context.Usuario.ToListAsync<Usuario>();
            ViewBag.ListaUsuarios = listUsuarios;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Crear(Factura factura)
        {
            if (ModelState.IsValid)
            {
                _context.Factura.Add(factura);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Eliminar(int? id)
        {
            var listUsuarios = new List<Usuario>();
            listUsuarios = await _context.Usuario.ToListAsync<Usuario>();
            ViewBag.ListaUsuarios = listUsuarios;
            if (id == null)
            {
                return NotFound();

            }
            var factura = _context.Factura.Find(id);
            if (factura == null)
            {
                return NotFound();
            }
            return View(factura);
        }
        [HttpPost]
        public async Task<IActionResult> BorrarRegistro(int? id)
        {
            var factura = await _context.Factura.FindAsync(id);
            if (factura == null)
            {
                return NotFound();
            }
            _context.Factura.Remove(factura);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
