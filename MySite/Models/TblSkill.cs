using System;
using System.Collections.Generic;

namespace MySite.Models
{
    public partial class TblSkill
    {
        public int SkillId { get; set; }
        public string? SkillName { get; set; }
        public int? SkillPercent { get; set; }
    }
}
