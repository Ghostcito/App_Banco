using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using App_Banco.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace App_Banco.Controllers
{
    public class CuentasController : Controller
    {
        private readonly ILogger<CuentasController> _logger;
        private readonly ApplicationDbContext _context;

        public CuentasController(ILogger<CuentasController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var cuentas = _context.DataCuenta.OrderBy(m => m.Id).ToList();
            return View(cuentas);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}