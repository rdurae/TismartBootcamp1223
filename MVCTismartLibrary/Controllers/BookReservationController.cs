using MVCTismartLibrary.Models;
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

        public ActionResult Index()
        {
            if (Session["CurrentUser"] == null)
            {
                return RedirectToAction("Index", "Login");
            }

            var booksStatusList = wcfTismartLibraryService.ListBooksReservations();

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

        //[Route("BookReservation/Reserve/{id}")]
        //[HttpPatch]
        [HttpPost]
        public ActionResult Reserve(int id)
        {
            var book = wcfTismartLibraryService.BookSelection(id);

            if (book.IsReserved != true)
            {
                wcfTismartLibraryService.BookReservation(book);
            }

            //return RedirectToAction("Index", "BookReservation");
            return Json(new { success = true, message = "Resource updated successfully" });
        }
    }
}
