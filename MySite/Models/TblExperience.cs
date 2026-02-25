using System;
using System.Collections.Generic;

namespace MySite.Models
{
    public partial class TblExperience
    {
        public int ExperienceId { get; set; }
        public string? ExperienceName { get; set; }
        public string? ExperienceIndustry { get; set; }
        public string? ExperienceDescripition { get; set; }
        public string? ExperienceYear { get; set; }
    }
}
