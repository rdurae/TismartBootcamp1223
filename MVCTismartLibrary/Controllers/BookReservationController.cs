using MVCTismartLibrary.Models;
using MVCTismartLibrary.TismartLibraryService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MVCTismartLibrary.Controllers
{
    public class BookReservationController : Controller
    {
        TismartLibraryService.Service1Client wcfTismartLibraryService = new TismartLibraryService.Service1Client();

        public ActionResult Index(User user)
        {
            if (Session["CurrentUser"] == null)
            {
                return RedirectToAction("Index", "Login");
            }

            var booksStatusList = wcfTismartLibraryService.ListBooksReservations();

            var currentUser = Session["CurrentUser"] as User;

            ViewBag.UserName = currentUser.FirstName;
            ViewBag.CurrentUserId = currentUser.Id;

            return View(booksStatusList);
        }

        public ActionResult RequestForReservation(int id)
        {
            var book = wcfTismartLibraryService.BookSelection(id);

            if (book == null || book.IsReserved == true)
            {
                return PartialView("_BookIsReserved");
            }
            else
            {
                var bookSelection = new BookSelectionDto()
                {
                    Id = book.Id,
                    IsReserved = book.IsReserved,
                    Title = book.Title,
                    Code = book.Code
                };

                return PartialView("_ToReserveBook", bookSelection);
            }
        }

        [HttpPost]
        public ActionResult Reserve(int id)
        {
            var book = wcfTismartLibraryService.BookSelection(id);
            //obtener id de usuario de la sesion actual 
            var currentUser = Session["CurrentUser"] as User;            

            if (book.IsReserved != true)
            {
                wcfTismartLibraryService.BookReservation(book, currentUser);
            }

            return RedirectToAction("Index", "BookReservation");
            //return Json(new { success = true, message = "Registrado con éxito" });
        }
    }
}
