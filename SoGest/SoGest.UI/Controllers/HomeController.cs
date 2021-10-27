using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

using AplicacionComercial.Web.Models;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

using SoGest.Data.Interaces;
using SoGest.Data.Repositories.Context;

namespace SoGest.UI.Controllers
{
    public class HomeController:Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController ( ILogger<HomeController> logger )
        {
            _logger = logger;
        }

        public IActionResult Index ()
        {
            return View( );
        }

        public IActionResult Privacy ()
        {
            return View( );
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error ()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
