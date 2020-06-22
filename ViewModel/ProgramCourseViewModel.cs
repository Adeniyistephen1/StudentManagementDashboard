using Code360StudentApp.Models;
using EmployeeManagment.models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Code360StudentApp.ViewModel
{
    public class ProgramCourseViewModel
    {
        public List<Courses> courses { get; set; }
        public List<AcademyProgram> academyPrograms { get; set; }

        [Display(Name = "Course Name")]
        public CourseName CourseName { get; set; }
        public int AcademyProgramId { get; set; }
        public int CourseId { get; set; }

        [Display(Name = "Progaram Cost")]
        public double ProgramCost { get; set; }

        [Display(Name = "Progaram Name")]
        public ProgrammeNames ProgramName { get; set; }
        public ProgramDuration Duration { get; set; }

        
        public CourseLevel Level { get; set; }
        public double CourseCost { get; set; }
    }
}
