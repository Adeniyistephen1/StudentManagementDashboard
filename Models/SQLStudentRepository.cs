using Code360StudentApp.models;
using EmployeeManagment.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Code360StudentApp.Models
{
    public class SQLStudentRepository : IStudentRepo, IGuarantorRepo, IProgramCourses, IPayment
    {
        private readonly AppDbContext context;

        public SQLStudentRepository(AppDbContext context)
        {
            this.context = context;
        }
        public Student Add(Student student)
        {
            context.Students.Add(student);
            context.SaveChanges();
            return student;
        }


        public Student Delete(int id)
        {
            Student employee = context.Students.Find(id);
            if (employee != null)
            {
                context.Students.Remove(employee);
                context.SaveChanges();
            }
            return employee;
        }



        public IEnumerable<Student> GetAllStudent()
        {
            return context.Students;
        }

        public Student GetStudent(int id)
        {
            return context.Students.Find(id);
        }

        public Student Update(Student student)
        {
            var employ = context.Students.Attach(student);
            employ.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return student;
        }

        //guarantor process
        public Guarantor AddGuarantor(Guarantor guarantor)
        {
            context.Guarantors.Add(guarantor);
            context.SaveChanges();
            return guarantor;
        }
        public IEnumerable<Guarantor> GetGuarantor(int Id)
        {
            return context.Guarantors.Where(e => e.StudentId == Id);

        }

        public IEnumerable<Guarantor> GetGuarantors()
        {
            return context.Guarantors;
        }

        public Guarantor UpdateGuarantor(Guarantor guarantorChanges)
        {
            var guarantor = context.Guarantors.Attach(guarantorChanges);
            guarantor.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return guarantorChanges;
        }

        public Guarantor DeleteGuarantor(int id)
        {
            Guarantor guarantor = context.Guarantors.Find(id);
            if (guarantor != null)
            {
                context.Guarantors.Remove(guarantor);
                context.SaveChanges();
            }
            return guarantor;
        }

        public Courses AddCourses(Courses courses)
        {
            context.Courses.Add(courses);
            context.SaveChanges();
            return courses;
        }

        public AcademyProgram AddProgram(AcademyProgram programs)
        {
            context.AcademyPrograms.Add(programs);
            context.SaveChanges();
            return programs;
        }

        public IEnumerable<AcademyProgram> academyPrograms()
        {
            return context.AcademyPrograms;
        }

        public IEnumerable<Courses> courses()
        {
            return context.Courses;
        }

        public IEnumerable<AcademyProgram> GetAcademyPrograms(int id)
        {
            return context.AcademyPrograms.Where(e => e.AcademyProgramId == id);
        }

        public IEnumerable<Courses> GetCourses(int id)
        {

            return context.Courses.Where(e => e.Id == id);
        }

        public Courses Update(Courses courses)
        {
            var update = context.Courses.Attach(courses);
            update.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return courses;
        }

        public AcademyProgram Update(AcademyProgram program)
        {
            var ap = context.AcademyPrograms.Attach(program);
            ap.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return program;
        }

        
        public AcademyProgram DeleteProgram(int id)
        {
            AcademyProgram ap = context.AcademyPrograms.Find(id);
            if (ap != null)
            {
                context.AcademyPrograms.Remove(ap);
                context.SaveChanges();
            }
            return ap;
        }

        public Courses DeleteCourse(int id)
        {
            Courses courses = context.Courses.Find(id);
            if (courses != null)
            {
                context.Courses.Remove(courses);
                context.SaveChanges();
            }
            return courses;
        }

        public ProgrammeCourses addProgramCourse(ProgrammeCourses pc)
        {
            context.programmeCourses.Add(pc);
            return pc;
        }

        public IEnumerable<ProgrammeCourses> ProgrammeCourses()
        {
            return context.programmeCourses;
        }

        public IEnumerable<ProgrammeCourses> ListOfCourses(int id)
        {
            return context.programmeCourses.Where(ee => ee.CoursesId == id);
        }

        public Payment AddPayment(Payment payment)
        {
            context.Payments.Add(payment);
            context.SaveChanges();
            return payment;
        }

        public List<Payment> GetPayments(int id)
        {
            return context.Payments.Where(p => p.StudentId == id).ToList();
        }
        public IEnumerable<Payment> GetSpecifiedPayment(int Id)
        {
            return context.Payments.Where(p => p.StudentId == Id);
        }
        
        public Payment UpdatePayment(Payment PaymentChanges)
        {
            var comingPayment = context.Payments.Attach(PaymentChanges);
            comingPayment.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return PaymentChanges;
        }
        public Payment DeletePayment(int id)
        {
            Payment payment = context.Payments.Find(id);
            if (payment != null)
            {
                context.Payments.Remove(payment);
                context.SaveChanges();
            }
            return payment;
        }

        public AcademyProgram GetProgram(AcademyProgram academyProgram, int id)
        {
            context.AcademyPrograms.FirstOrDefault(A => A.AcademyProgramId == id);
            context.SaveChanges();
            return academyProgram;
        }

        public AcademyProgram GetProgram(AcademyProgram academyProgram)
        {
            throw new NotImplementedException();
        }
    }
}
