using Code360StudentApp.models;
using Code360StudentApp.Models;
using EmployeeManagment.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Code360StudentApp.ViewModel
{
    public class HomeDetailsViewModel
    {
        public Student student { get; set; }
        public List<Guarantor> guarantors { get; set; }
        public string PageTitle { get; set; }
        public List<Payment> payment { get; set; }
    }
}
