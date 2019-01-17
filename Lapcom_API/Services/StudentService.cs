using Lapcom_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lapcom_API.Services
{
    public class StudentService
    {
        public List<Student> GetStudent(int UserId)
        {
            using (var context = new LapcomContext() )
            {
               return context.Student.ToList();
            }
        }
    }
}
