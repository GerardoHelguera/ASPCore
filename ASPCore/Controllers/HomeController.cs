using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ASPCore.Models;

namespace ASPCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Array array;
            List<MaestrosModel> maestros = new List<MaestrosModel>();
            maestros.Add(new MaestrosModel
            {

                Matricula = 13004452,
                Nombre = "Carlos",
                Apellido_P = "Morales",
                Apellido_M = "Ponce ",
                Hora_Entrada = DateTime.Now,
                Hora_Salida = DateTime.Now,
            });
            maestros.Add(new MaestrosModel
            {
                
                Matricula = 13004453,
                Nombre = "Oscar",
                Apellido_P = "Hernández",
                Apellido_M = "Olvera ",
                Hora_Entrada = DateTime.Now,
                Hora_Salida = DateTime.Now,
        });
            maestros.Add(new MaestrosModel
            {

                Matricula = 13004456,
                Nombre = "Christian",
                Apellido_P = "Martinez",
                Apellido_M = "Vargas ",
                Hora_Entrada = DateTime.Now,
                Hora_Salida = DateTime.Now,
            });

            array = maestros.ToArray();
            ViewBag.maestros = array;



            return View();
        }

            public IActionResult Privacy()
            {
                return View();
            }

            [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
            public IActionResult Error()
            {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
            }

        }
}
