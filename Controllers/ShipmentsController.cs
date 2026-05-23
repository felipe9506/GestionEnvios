using GestionEnvios.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
//controlador para manejar las operaciones relacionadas con los envíos
namespace GestionEnvios.Controllers
{
    public class ShipmentsController : Controller
    {
        //constructor para inyectar el contexto de la base de datos
        private readonly AppDbContext _context;
        //El DBContext se inyecta a través del constructor para que el controlador pueda acceder a la base de datos y realizar operaciones CRUD en la tabla de envíos.
        public ShipmentsController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> List()
        {
            var shipments = await _context.Shipments.ToListAsync();
            return View(shipments);
        }
        //acción para mostrar la lista de envíos
        public async Task<IActionResult> Index()
        {
            var shipments = await _context.Shipments.ToListAsync();
            return View(shipments);

        }
        //acción para mostrar el formulario de creación de un nuevo envío
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        //acción para manejar la creación de un nuevo envío
        public async Task<IActionResult> Create(Shipment shipment)
        {
            if (shipment.PaisOrigen == shipment.PaisDestino)
            {
                ModelState.AddModelError("", "El país de destino no puede ser el mismo que el país de origen.");
                return View(shipment);

            }
            if (ModelState.IsValid)
            {
                shipment.FechaCreacion = DateTime.Now;
                _context.Shipments.Add(shipment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(shipment);

        }
        //acción para mostrar los detalles de un envío específico
        public async Task<IActionResult> Details(int id)
        {
            var shipment = await _context.Shipments.FindAsync(id);
            if (shipment == null)
            {
                return NotFound();
            }
            return View(shipment);
        }
        //acción para mostrar el formulario de edición de un envío existente
        public async Task<IActionResult> Edit(int id)
        {
            var shipment = await _context.Shipments.FindAsync(id);
            if (shipment == null)
            {
                return NotFound();
            }
            //no se permite deitar  si esta entregado o cancelado
            if (shipment.Estado == "Entregado" || shipment.Estado == "Cancelado")
            {
                TempData["ErrorMessage"] = "No se puede editar un envío que ya ha sido entregado o cancelado.";
                return RedirectToAction(nameof(Index));
            }
            return View(shipment);
        }
        [HttpPost]
        //acción para guardar los cambios de edicion
        public async Task<IActionResult> Edit(int id, Shipment shipment)
        {
            
            var envio = await _context.Shipments.FindAsync(id);
            if (shipment == null) 
            {
                return NotFound(); 
            }
            if(shipment.PaisOrigen == shipment.PaisDestino)
            {
                ModelState.AddModelError("", "El país de destino no puede ser el mismo que el país de origen.");
                return View(shipment);
            }
            if (!ModelState.IsValid)
            {
                envio.PaisOrigen = shipment.PaisOrigen;
                envio.PaisDestino = shipment.PaisDestino;
                envio.CiudadOrigen = shipment.CiudadOrigen;
                envio.CiudadDestino = shipment.CiudadDestino;
                envio.NombreRemitente = shipment.NombreRemitente;
                envio.NombreDestinatario = shipment.NombreDestinatario;
                envio.DescripcionMercancia = shipment.DescripcionMercancia;
                envio.PesoKg = shipment.PesoKg;
                envio.Estado = shipment.Estado;
                envio.FechaEstimadaEntrega = shipment.FechaEstimadaEntrega;

                await _context.SaveChangesAsync();
                return View(shipment);
            }
            return View(shipment);
        }
        //accion paara cancelar un envio
        public async Task<IActionResult> Cancel(int id)
        {
            var shipment = await _context.Shipments.FindAsync(id);
            if (shipment == null) return NotFound();

            shipment.Estado = "Cancelado";
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}
