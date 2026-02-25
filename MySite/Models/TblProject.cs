using System;
using System.Collections.Generic;

namespace MySite.Models
{
    public partial class TblProject
    {
        public int ProjectId { get; set; }
        public string? ProjectTitle { get; set; }
        public string? ProjectDescription { get; set; }
        public string? ImageUrl { get; set; }
        public int CategoryId { get; set; }

        public virtual TblCategory Category { get; set; } = null!;
    }
}
