using System;
using System.Collections.Generic;

namespace Lapcom_API.Models
{
    public partial class RegisterationDocument
    {
        public int Id { get; set; }
        public int? StudentId { get; set; }

        public RegisterationDocument IdNavigation { get; set; }
        public RegisterationDocument InverseIdNavigation { get; set; }
    }
}
