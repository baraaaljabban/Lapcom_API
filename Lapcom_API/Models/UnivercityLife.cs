﻿using System;
using System.Collections.Generic;

namespace Lapcom_API.Models
{
    public partial class UnivercityLife
    {
        public int Id { get; set; }
        public int? StudentId { get; set; }
        public DateTime? Year { get; set; }
        public byte[] IdImage { get; set; }

        public Student Student { get; set; }
    }
}
