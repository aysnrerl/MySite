using System;
using System.Collections.Generic;

namespace MySite.Models
{
    public partial class TblFooter
    {
        public int FooterId { get; set; }
        public string? FooterTitle { get; set; }
        public string? FooterDescription { get; set; }
        public string? Icon { get; set; }
    }
}
