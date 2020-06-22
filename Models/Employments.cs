using EmployeeManagment.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Code360StudentApp.Models
{
    public class Employments
    {
        public int Id { get; set; }

        public int CompanyId { get; set; }

        public int StudentId { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
