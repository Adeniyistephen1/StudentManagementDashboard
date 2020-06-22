using EmployeeManagment.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Code360StudentApp.Models
{
    public interface IEmployment
    {
        public Student AddStudent();
        public Company AddCompany();
    }
}
