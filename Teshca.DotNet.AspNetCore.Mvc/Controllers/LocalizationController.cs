using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Teshca.DotNet.AspNetCore.Mvc.ViewModels;

namespace Teshca.DotNet.AspNetCore.Mvc.Controllers
{
    public class LocalizationController : Controller
    {
        private IStringLocalizer<LocalizationController> _stringLocalizer;

        public LocalizationController(IStringLocalizer<LocalizationController> stringLocalizer)
        {
            _stringLocalizer = stringLocalizer;
        }

        public IActionResult Index()
        {
            LocalizationViewModel vm = new LocalizationViewModel();
            vm.MyHelloWorld = _stringLocalizer.GetString("MyHelloWorld");
            return View(vm);
        }
    }
}