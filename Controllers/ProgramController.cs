
using Code360StudentApp.Models;
using Code360StudentApp.ViewModel;
using EmployeeManagment.models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Code360StudentApp.Controllers
{
    [Route("Program")]
    public class ProgramController : Controller
    {
        private IProgramCourses _programCourse;

        public ProgramController(IProgramCourses programCourse)
        {
            this._programCourse = programCourse;
        }
        [Route("Programs")]
        [HttpGet]
        public ViewResult Programs()
        {
            List<AcademyProgram> academyProgram = _programCourse.academyPrograms().ToList();
            List<Courses> course = _programCourse.courses().ToList();

            ProgramCourseViewModel programCourseViewModel = new ProgramCourseViewModel {
                academyPrograms = academyProgram,
                courses = course
            };
            return View(programCourseViewModel);
        }

        [Route("Programs/Create")]
        [HttpPost]
        public IActionResult CreateProgram(ProgramCourseViewModel program)
        {
            AcademyProgram ap = new AcademyProgram()
            {
                ProgramName = program.ProgramName,
                Duration = program.Duration,
                Cost = program.ProgramCost
            };
            _programCourse.AddProgram(ap);
            return RedirectToAction("Programs");
        }

        [Route("Course/Create")]
        [HttpPost]
        public IActionResult CreateCourse(ProgramCourseViewModel model)
        {
            Courses courses = new Courses()
            {
                Course_Name = model.CourseName,
                //Level = model.Level,
                Cost = model.CourseCost
            };
            _programCourse.AddCourses(courses);
            return RedirectToAction("Programs");
        }

        //[Route("Course/Create")]
        //[HttpPost]
        //public IActionResult EditProgramCourse(ProgramCourseViewModel model)
        //{
        //    _programCourse.ListOfCourses(model.AcademyProgramId).ToList();
        //    return;
        //}
    }
}
