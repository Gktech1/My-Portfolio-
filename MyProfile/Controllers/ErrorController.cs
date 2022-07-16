using System;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MyProfile.Controllers
{
    public class ErrorController : Controller
    {
        private readonly ILogger<ErrorController> _logger;
        

        public ErrorController(ILogger<ErrorController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            var expErrorPath = HttpContext.Features.Get<IExceptionHandlerPathFeature>();
            _logger.LogError($"{expErrorPath.Path}, Error that is thrown: {expErrorPath.Error}");
            return View();
        }

        public IActionResult Details()
        {
            /* throw new Exception("Deliberate Error!!!");*/
            // Rest of the code
                return View();
        }

    }
}
