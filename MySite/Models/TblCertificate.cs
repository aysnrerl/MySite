using System;
using System.Collections.Generic;

namespace MySite.Models
{
    public partial class TblCertificate
    {
        public int CertificateId { get; set; }
        public string? CertificateName { get; set; }
        public string? OrganizationName { get; set; }
        public string? Icon { get; set; }
        public string? CertificateYear { get; set; }
    }
}
