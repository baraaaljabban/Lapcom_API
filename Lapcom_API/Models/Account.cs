using System;
using System.Collections.Generic;

namespace Lapcom_API.Models
{
    public partial class Account
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int? StudentId { get; set; }

        public Student Student { get; set; }
    }
}
