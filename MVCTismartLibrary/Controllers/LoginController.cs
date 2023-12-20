using Microsoft.Ajax.Utilities;
using MVCTismartLibrary.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.WebPages;

namespace MVCTismartLibrary.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {            
            return View();
        }

        [HttpPost]
        public ActionResult Index(LoginDto loginDto)
        {
            if (loginDto.Email.IsNullOrWhiteSpace() || loginDto.Password.IsNullOrWhiteSpace())
            {
                ViewBag.LoginError = "Ingrese datos válidos";
                return View();                
            }
   
            var wcfTismartLibraryService = new TismartLibraryService.Service1Client();

            bool isUserValid = wcfTismartLibraryService.IsValidUser(new TismartLibraryService.UserCredentials
            {
                Email = loginDto.Email,
                Password = loginDto.Password,
            });

            if (isUserValid == false)
            {
                ViewBag.LoginError = "Usuario inexistente o desactivado";
                return View();
            }

            var user = wcfTismartLibraryService.GetUser(loginDto.Email);

            if (user != null && loginDto.Email == user.Email && loginDto.Password == user.Password)
            {
                Session["CurrentUser"] = user;
                Session.Timeout = 1;
                return RedirectToAction("Index", "BookReservation");
            }
            else
            {
                ViewBag.LoginError = "El usuario no existe o contraseña incorrecta";
                return View();
            }
        }
    }
}