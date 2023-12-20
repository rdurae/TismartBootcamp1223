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

        // GET: BooksStatus
        public ActionResult Index()        
        {
            if (Session["CurrentUser"] == null)
            {
                return RedirectToAction("Index", "Login");
            }

            var booksStatusList = wcfTismartLibraryService.ListBooksReservations();
            return View(booksStatusList);
        }

        // GET: BooksStatus/Details/5
        [HttpGet]
        public ActionResult Details(int id)
        {
            var book = wcfTismartLibraryService.BookSelection(id);

            return View();
        }

        [HttpPost]
        public ActionResult Details(int id, int asdfd)
        {
            var book = wcfTismartLibraryService.BookSelection(id);

            return View();
        }

        // GET: BooksStatus/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BooksStatus/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: BooksStatus/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
            
        }

        // POST: BooksStatus/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: BooksStatus/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BooksStatus/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Reserve(int id)
        {
            //reconstruye objeto libro segun ind
            var book = wcfTismartLibraryService.BookSelection(id);

            if(book == null || book.IsReserved == true)
            {
                return View("Error");
            }
            else
            {
                wcfTismartLibraryService.BookReservation(book);
                return RedirectToAction("Index");
            }

            //

            



        }

        // POST: BooksStatus/Edit/5
        [HttpPatch]
        public ActionResult Reserve(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

    }
}
