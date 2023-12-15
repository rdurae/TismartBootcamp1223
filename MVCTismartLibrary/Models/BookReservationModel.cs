using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTismartLibrary.Models
{
    public class BookReservation
    {
        public string BookCode { get; set; }
        public string BookTitle { get; set; }
        public bool IsReserved { get; set; }
        public string DateTimeReservation { get; set; }

    }
}