using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using App_Banco.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using App_Banco.Data;



namespace App_Banco.Controllers
{
    [Route("[controller]")]
    public class RegistroController : Controller
    {
        private readonly ILogger<RegistroController> _logger;
        private readonly ApplicationDbContext _context;

        public RegistroController(ILogger<RegistroController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Cuenta cuenta)
        {
            _logger.LogDebug("Ingreso a Crear cuenta");
            _context.Add(cuenta);
            _context.SaveChanges();
            return RedirectToAction("Index", "Cuentas");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}