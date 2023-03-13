using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using atvIII.Models;
namespace atvIII.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

         public IActionResult FCreturn()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Anunciantes()
        {
            return View();
        }
        
        public IActionResult faleConosco()
        {   return View();
            /* List<faleconoscoenviar> listagem = faleconoscoenviar.RegistroDoassunto.Listar(); */
        }
        [HttpPost]
          public IActionResult faleConosco(RegistroDoassunto registrofc)
        { 
            Databasefaleconosco dbfc = new Databasefaleconosco();
            dbfc.Insert(registrofc);
            return View();
        }
                           
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
