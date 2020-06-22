using Code360StudentApp.models;
using Code360StudentApp.Models;
using Code360StudentApp.ViewModel;
using EmployeeManagment.models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Code360StudentApp.Controllers
{
    [Route("Home")]
    public class HomeController : Controller
    {
        private IStudentRepo _er;
        private readonly IHostingEnvironment henv;
        private readonly IGuarantorRepo _guarantorRepo;
        private readonly IPayment _payment;
        private readonly IProgramCourses _programcourse;

        public AddmissionType? PublicEnum { get; private set; }

        public HomeController(IStudentRepo employeeRepo, IHostingEnvironment henv, IGuarantorRepo guarantorRepo, IPayment payment, IProgramCourses programCourses)
        {
            this._er = employeeRepo;
            this.henv = henv;
            this._guarantorRepo = guarantorRepo;
            this._payment = payment;
            this._programcourse = programCourses;
        }

        [Route("")]
        [Route("Index")]
        [Route("~/")]
        public IActionResult Index()
        {
            var model = _er.GetAllStudent();
            return View(model);
        }

        [Route("Details/{id?}")]
        public ViewResult Details(int id)
        {
            List<Guarantor> guard = _guarantorRepo.GetGuarantor(id).ToList();
            List<Payment> pay = _payment.GetPayments(id).ToList();

            HomeDetailsViewModel viewmodel = new HomeDetailsViewModel()
            {
                student = _er.GetStudent(id),
                guarantors = guard,
                payment = pay,
                PageTitle = "Student Details"

         
            };
            
            return View(viewmodel);
        }

        [Route("Create")]
        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [Route("Create")]
        [HttpPost]
        public ActionResult Create(CreateStudentModel student)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = ProcessImage(student);

                Student sd = new Student
                {
                    Name = student.Name,
                    DateOfBirth = student.DateOfBirth,
                    Gender = student.Gender,
                    PhoneNumber = student.PhoneNumber,
                    Email = student.Email,
                    Address = student.Address,
                    MaritalStatus = student.MaritalStatus,
                    HealthCondition = student.HealthCondition,
                    Status = student.Status,
                    AdmissionType = student.AdmissionType,
                    Nationalty = student.Nationalty,
                    NextOFKinName = student.NextOFKinName,
                    NextOfKinAddress = student.NextOfKinAddress,
                    NextOfKinNumber = student.NextOfKinNumber,
                    Photo = uniqueFileName

                };


                var add = _er.Add(sd);

                ViewBag.Message = "Data Inserted Successful";

                return RedirectToAction("Guarantor", new { id = sd.Id }); 
            }
            return View();
        }

        [Route("Edit/{id?}")]
        [HttpGet]
        public ViewResult Edit(int id)
        {
            Student student = _er.GetStudent(id);
            EditDetailsViewModel st = new EditDetailsViewModel
            {
                Id = student.Id,
                Name = student.Name,
                DateOfBirth = student.DateOfBirth,
                Gender = student.Gender,
                PhoneNumber = student.PhoneNumber,
                Email = student.Email,
                Address = student.Address,
                MaritalStatus = student.MaritalStatus,
                HealthCondition = student.HealthCondition,
                Status = student.Status,
                AdmissionType = student.AdmissionType,
                Nationalty = student.Nationalty,
                NextOFKinName = student.NextOFKinName,
                NextOfKinAddress = student.NextOfKinAddress,
                NextOfKinNumber = student.NextOfKinNumber
            };
            return View(st);
        }

        [Route("Edit/{id?}")]
        [HttpPost]
        public IActionResult Edit(EditDetailsViewModel model)
        {
            if (ModelState.IsValid)
            {
                Student student = _er.GetStudent(model.Id);

                student.Name = model.Name;
                student.DateOfBirth = student.DateOfBirth;
                student.Gender = student.Gender;
                student.Email = model.Email;
                student.PhoneNumber = student.PhoneNumber;
                student.Address = model.Address;
                student.MaritalStatus = student.MaritalStatus;
                student.HealthCondition = student.HealthCondition;
                student.Status = student.Status;
                student.AdmissionType = student.AdmissionType;
                student.Nationalty = model.Nationalty;
                student.NextOFKinName = student.NextOFKinName;
                student.NextOfKinAddress = student.NextOfKinAddress;
                student.NextOfKinNumber = student.NextOfKinNumber;

                if (model.Photo != null)
                {
                    if (model.ExistingPath != null)
                    {
                        string filePath = Path.Combine(henv.WebRootPath, "img", model.ExistingPath);
                        System.IO.File.Delete(filePath);
                    }
                    student.Photo = ProcessImage(model);
                }

                _er.Update(student);
                return RedirectToAction("Index");
            }
            return View();

        }

        [Route("Guarantor/{id?}")]
        [HttpGet]
        public IActionResult Guarantor(int id)
        {
            GuarantorViewModel viewmodel = new GuarantorViewModel()
            {
                student = _er.GetStudent(id)
            };

            return View(viewmodel);

        }

        [Route("Guarantor/{id?}")]
        [HttpPost]
        public IActionResult Guarantor(GuarantorViewModel model)
        {
            
                Guarantor sd = new Guarantor
                {
                    Name = model.guarantor.Name,
                    StudentId = model.student.Id,
                    Email = model.guarantor.Email,
                    Phone = model.guarantor.Phone,
                    Address = model.guarantor.Address,
                    

                };


                var add = _er.AddGuarantor(sd);

                ViewBag.Message = "Data Inserted Successful";

                return RedirectToAction("Index");
           
        

        }

        [Route("CreatePayment/{id?}")]
        [HttpGet]
        public ViewResult CreatePayment(int id)
        {
            Student std = _er.GetStudent(id);
            CreatePaymentViewModel pvm = new CreatePaymentViewModel()
            {
                StudentId = id,
                AmountPaid = 0.00,
                PaymentDate = DateTime.Now,
                PaymentMethod = PayMethod.BankTransfer
            };

            return View(pvm);
        }
        [Route("CreatePayment/{id?}")]
        [HttpPost]
        public IActionResult CreatePayment(CreatePaymentViewModel model)
        {
            if (ModelState.IsValid)
            {
                Payment newPayment = new Payment
                {
                    StudentId = model.StudentId,
                    AmouontPaid = model.AmountPaid,
                    PaymentMethod = model.PaymentMethod,
                    PaymentDate = model.PaymentDate
                };


                var student = _er.GetStudent(newPayment.StudentId);
                ViewBag.Sum = 1000000;
                if (student.AdmissionType == AddmissionType.IncomeSharing)
                {
                    
                    var amounPaying = 1000000;
                    var balance = amounPaying - model.AmountPaid;
                    newPayment.AmouontPaid = balance;
                }

                var add = _payment.AddPayment(newPayment);
                return RedirectToAction("Details", new { id = newPayment.StudentId});

            }
            return View();
        }

        [Route("Delete/{id?}")]
        //[HttpPost]
        public IActionResult Delete(int id)
        {
           // Student student = _er.GetStudent(id);
            _er.Delete(id);
            return RedirectToAction("Index");
        }


        public IActionResult Privacy()
        {
            return View();
        }


        private string ProcessImage(CreateStudentModel student)
        {
            string uniqueFileName = null;
            if (student.Photo != null && student.Photo.Count > 0)
            {

                foreach (IFormFile photo in student.Photo)
                {
                    string uploadsFolder = Path.Combine(henv.WebRootPath, "img");
                    uniqueFileName = Guid.NewGuid().ToString() + " " + photo.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);

                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        photo.CopyTo(fileStream);
                    }

                }
            }

            return uniqueFileName;
        }
        
    }
}
