using System;
using System.Collections.Generic;

namespace MySite.Models
{
    public partial class TblEducation
    {
        public int EducationId { get; set; }
        public string? EducationTitle { get; set; }
        public string? Subtitle { get; set; }
        public string? Icon { get; set; }
        public string? EducationYear { get; set; }
    }
}
