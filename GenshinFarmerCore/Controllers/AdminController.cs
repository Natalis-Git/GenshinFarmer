
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Security.Claims;
using GenshinFarmerCore.Data;
using GenshinFarmerCore.Models;
using System.Diagnostics;



namespace GenshinFarmerCore.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly ILogger<AdminController> _logger;
        private readonly IConfiguration _config;
        private readonly IGenshinRepo _repo;


        public AdminController(ILogger<AdminController> logger, IConfiguration config, IGenshinRepo repo)
        {
            _logger = logger;
            _config = config;
            _repo = repo;
        }


        public IActionResult Index() 
        {
            return View();
        }

        
         // TODO: Make use of a view model or the viewbag to allow for editing entities in view.
         // Combine the four actions below into one, if seperate implementations aren't needed.
        public IActionResult EditCharacters()
        {
            return View("DatabaseEditor");
        }


        public IActionResult EditWeapons()
        {
            return View("DatabaseEditor");
        }


        public IActionResult EditUpgrades()
        {
            return View("DatabaseEditor");
        }

        public IActionResult EditMaterials()
        {
            return View("DatabaseEditor");
        }
        

        [AllowAnonymous]
        public IActionResult Authenticate()
        {
            return View("Login", new LoginViewModel());
        }


        [HttpPost]
        [AllowAnonymous]
        public IActionResult Login(string accessCode)
        {
            // TODO: Replace this code with real sign in (Azure key vault?)

            if (accessCode == _config["AdministratorData:AccessCode"])
            {
                var adminClaims = new List<Claim>() { 
                    new Claim(ClaimTypes.Role, "Admin"),
                    new Claim(ClaimTypes.NameIdentifier, _config["AdministratorData:Id"])
                };

                var adminPrincipal = new ClaimsPrincipal(new ClaimsIdentity(adminClaims, "Admin Access"));

                HttpContext.SignInAsync(adminPrincipal);

                return RedirectToAction("Index");
            }
            else
            {
                return View(new LoginViewModel() { EnteredIncorrectCode = true }); 
            }
        }


        [HttpPost]
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync();
            return RedirectToAction("Index"); 
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
