using System;
using System.Collections.Generic;

namespace MySite.Models
{
    public partial class TblAbout
    {
        public int AboutId { get; set; }
        public string? AboutTitle { get; set; }
        public string? AboutDescription { get; set; }
        public string? ImageUrl { get; set; }
    }
}
