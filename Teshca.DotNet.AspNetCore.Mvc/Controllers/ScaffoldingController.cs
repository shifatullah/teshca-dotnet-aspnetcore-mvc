using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Teshca.DotNet.AspNetCore.Mvc.Controllers
{
    public class ScaffoldingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}