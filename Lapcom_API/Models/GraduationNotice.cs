using System;
using System.Collections.Generic;

namespace Lapcom_API.Models
{
    public partial class GraduationNotice
    {
        public int Id { get; set; }
        public int? StudentId { get; set; }
        public byte[] IdImage { get; set; }

        public Student Student { get; set; }
    }
}
