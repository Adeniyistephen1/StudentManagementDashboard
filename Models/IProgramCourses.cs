using EmployeeManagment.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Code360StudentApp.Models
{
    public interface IProgramCourses
    {
        Courses AddCourses (Courses courses);
        AcademyProgram AddProgram (AcademyProgram program);
        IEnumerable<AcademyProgram> academyPrograms();
        IEnumerable<Courses> courses();

        IEnumerable<AcademyProgram> GetAcademyPrograms(int id);
        IEnumerable<Courses> GetCourses(int id);

        AcademyProgram GetProgram(AcademyProgram academyProgram);

        Courses Update(Courses courses);
        AcademyProgram Update(AcademyProgram program);

        Courses DeleteCourse(int id);
        AcademyProgram DeleteProgram(int id);


        //program courses
        ProgrammeCourses addProgramCourse(ProgrammeCourses pc);
        IEnumerable<ProgrammeCourses> ProgrammeCourses();
        IEnumerable<ProgrammeCourses> ListOfCourses(int id);
    }
}
