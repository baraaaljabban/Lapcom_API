using System;
using System.Collections.Generic;

namespace Lapcom_API.Models
{
    public partial class Student
    {
        public Student()
        {
            Account = new HashSet<Account>();
            DocumentTime = new HashSet<DocumentTime>();
            GraduationNotice = new HashSet<GraduationNotice>();
            RegistreationDocument = new HashSet<RegistreationDocument>();
            SuspendRegisteration = new HashSet<SuspendRegisteration>();
            UnivercityLife = new HashSet<UnivercityLife>();
        }

        public int Id { get; set; }
        public string Number { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string BirthPlace { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Paddress { get; set; }
        public string Taddress { get; set; }
        public string Phone { get; set; }
        public string NameOfAcertificate { get; set; }
        public string Specilaization { get; set; }
        public string MinistryOfDonors { get; set; }
        public DateTime? GraduationYear { get; set; }
        public string Nationality { get; set; }
        public string Average { get; set; }
        public string RecitDivision { get; set; }
        public string CertificateImage { get; set; }
        public string AcceptanceMethode { get; set; }

        public ICollection<Account> Account { get; set; }
        public ICollection<DocumentTime> DocumentTime { get; set; }
        public ICollection<GraduationNotice> GraduationNotice { get; set; }
        public ICollection<RegistreationDocument> RegistreationDocument { get; set; }
        public ICollection<SuspendRegisteration> SuspendRegisteration { get; set; }
        public ICollection<UnivercityLife> UnivercityLife { get; set; }
    }
}
