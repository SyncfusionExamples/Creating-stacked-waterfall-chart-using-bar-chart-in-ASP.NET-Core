using CoreWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CoreWebApp.Controllers
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
           List<ChartData> chartData = new List<ChartData>
            {
              new ChartData { baseline= 0,x= "Total",y1=190, y2=12},
              new ChartData { baseline= 180,x= "Otros",y1=11, y2=10},
              new ChartData { baseline= 180,x= "Expert Monitoring",y1=31, y2=0},
              new ChartData { baseline= 195,x= "Liquidacion Nacional",y1=16, y2=0},
              new ChartData { baseline= 178,x= "Autorizacion Nacional",y1=17, y2=0},
              new ChartData { baseline= 155,x= "Cuentas & Tarjetas",y1=23, y2=0},
              new ChartData { baseline= 116,x= "Decision Intelligence",y1=39, y2=0},
              new ChartData { baseline= 0,x= "Ventas",y1=100, y2=16},
            };
            ViewBag.dataSource = chartData;
        
            return View();
        }
        public class ChartData
        {
            public string x { get; set; }
            public double baseline { get; set; }
            public double y1 { get; set; }
            public double y2 { get; set; }
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
