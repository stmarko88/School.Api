using School.BusinessLogic.Interfaces;
using School.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.BusinessLogic
{
    public class StudentBusinessLogic : IStudentBusinessLogic
    {
        private readonly IStudentServices studentService;

        public StudentBusinessLogic(IStudentServices studentService)
        {
            this.studentService = studentService;
        }
        public bool Test()
        {
            return studentService.Test();
        }
    }
}
