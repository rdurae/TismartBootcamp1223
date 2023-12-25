using Microsoft.Ajax.Utilities;
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
        Service1Client wcfTismartLibraryService = new Service1Client();

        public ActionResult Index()
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
            var currentUser = Session["CurrentUser"] as User;
            var book = wcfTismartLibraryService.BookSelection(id);            
            var waitingListForBookCounter = wcfTismartLibraryService.WaitingListForBookCounter(book);
            var isUserInWaitingList = wcfTismartLibraryService.IsUserInWatingList(book, currentUser);
     

            var bookSelection = new BookSelectionDto()
            {
                Id = book.Id,
                IsReserved = book.IsReserved,
                Title = book.Title,
                Code = book.Code
            };

            if (book.IsReserved == true)
            {
                if (waitingListForBookCounter >= 3)
                {
                    return PartialView("_BookIsReserved", bookSelection);
                }

                if (isUserInWaitingList == true)
                {
                    return PartialView("_UserAlreadyInWaitingList");
                }
                else
                {
                    wcfTismartLibraryService.ReservationQueue(book, currentUser);

                    return PartialView("_UserForWaitingList");
                }
            }       

            return PartialView("_ToReserveBook", bookSelection);

        }

        [HttpPost]
        public ActionResult Reserve(int id)
        {
            var book = wcfTismartLibraryService.BookSelection(id);
            var currentUser = Session["CurrentUser"] as User;

            if (book.IsReserved != true)
            {
                wcfTismartLibraryService.BookReservation(book, currentUser);
            }

            return RedirectToAction("Index", "BookReservation");
        }
    }
}
