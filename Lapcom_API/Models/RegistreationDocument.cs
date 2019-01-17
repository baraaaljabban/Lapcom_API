using System;
using System.Collections.Generic;

namespace Lapcom_API.Models
{
    public partial class RegistreationDocument
    {
        public int Id { get; set; }
        public int? StudentId { get; set; }
        public byte[] IdImage { get; set; }

        public Student Student { get; set; }
    }
}
