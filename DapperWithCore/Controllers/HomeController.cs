using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DapperWithCore.Models;
using DapperWithCore.Helper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Diagnostics;
using DapperWithCore.Business.Interfaces;
using DapperWithCore.Entities;

namespace DapperWithCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IStoreExceptionManager _storeExceptionManager;

        public HomeController(ILogger<HomeController> logger, IStoreExceptionManager storeExceptionManager)
        {
            _logger = logger;
            _storeExceptionManager = storeExceptionManager;
        }

        public IActionResult Index()
        {
            throw new Exception("type mine");
            //_logger.LogInformation("home index called");

            //CompareGeneric<string> compareGeneric = new CompareGeneric<string>();
            //bool result = compareGeneric.CompareTypes("A", "a");
            //return View();
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

        [Route("ErrorDb/{statusCode}")]
        [AllowAnonymous]
        public IActionResult ErrorDb(int statusCode)
        {
            var error = HttpContext.Features.Get<IExceptionHandlerPathFeature>();

            var msg = error.Error.Message;
            var stackTrace = error.Error.StackTrace;
            var innerException = error.Error.InnerException;
            var path = error.Path;

            ExceptionModel exceptionModel = new ExceptionModel
            {
                Path = error.Path,
                Message = error.Error.Message,
                StackTrace = error.Error.StackTrace,
                InnerException = error.Error.InnerException?.ToString()
            };
            _storeExceptionManager.StoreException(exceptionModel: exceptionModel);

            return View();
        }
    }
}
