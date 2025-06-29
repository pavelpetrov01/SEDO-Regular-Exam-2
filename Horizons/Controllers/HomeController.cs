using Horizons.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;

namespace Horizons.Controllers
{
    [AllowAnonymous]
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            if (User?.Identity?.IsAuthenticated ?? false)
            {
                return RedirectToAction("Index", "Destination");
            }

            return View();
        }

       
    }
}
