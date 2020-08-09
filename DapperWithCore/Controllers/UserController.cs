using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DapperWithCore.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DapperWithCore.Controllers
{
    //[Route("[User]")]
    public class UserController : Controller
    {
        private readonly IUserManager _userManager;

        public UserController(IUserManager userManager)
        {
            _userManager = userManager;
        }
        // GET: /<controller>/
        [Route("User")]
        [Route("User/Index")]
        public IActionResult Index()
        {
            //throw new Exception("type mine");
            return View(_userManager.GetAllUsers());
        }
        [HttpGet]
        public IActionResult Create()
        {
            Entities.User user = new Entities.User();
            return View(user);
        }

        [HttpPost]
        public IActionResult Create(Entities.User user)
        {
            bool success = _userManager.AddUser(user);

            if (success)
            {
                return RedirectToAction("Index");
            }
            return View(user);
        }

        [Route("User/GetId/{id?}")]
        //[HttpGet("{id?}")]
        public IActionResult GetId(int id)
        {
            return View(_userManager.GetUser(id));
        }
    }
}
