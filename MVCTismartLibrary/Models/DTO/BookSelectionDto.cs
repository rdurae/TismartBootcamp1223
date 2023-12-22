using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTismartLibrary.Models
{
    public class BookSelectionDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsReserved { get; set; }
        public string Code { get; set; }

    }
}