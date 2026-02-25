using System;
using System.Collections.Generic;

namespace MySite.Models
{
    public partial class TblFeature
    {
        public int FeatureId { get; set; }
        public string? FeatureTitle { get; set; }
        public string? FeatureName { get; set; }
        public string FeatureDescription { get; set; } = null!;
        public string? ImageUrl { get; set; }
    }
}
