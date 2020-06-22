﻿using Code360StudentApp.Models;
using EmployeeManagment.models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Code360StudentApp.ViewModel
{
    public class CreateStudentModel
    {
        [Required]
        [MaxLength(50, ErrorMessage = "Name cannot Exceed 50 characters")]
        public string Name { get; set; }
        public Gender? Gender { get; set; }
        [Display(Name = "Date of Birth")]
        public string DateOfBirth { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$", ErrorMessage = "Invalid Email Format")]
        [Display(Name = "Office Email")]
        public string Email { get; set; }
        [Required]
        public string Address { get; set; }
        public string Identification { get; set; }
        public Nationality? Nationalty { get; set; }
        public string PhoneNumber { get; set; }
        public string HealthCondition { get; set; }
        public MaritalStatus? MaritalStatus { get; set; }
        public Status? Status { get; set; }
        public AddmissionType? AdmissionType { get; set; }
        //[Required]
        [MaxLength(50, ErrorMessage = "Name cannot Exceed 50 characters")]
        public string NextOFKinName { get; set; }
        //[Required]
        public string NextOfKinNumber { get; set; }
        public string NextOfKinAddress { get; set; }
        public string NextOfKinDocuments { get; set; }
        public List<IFormFile> Photo { get; set; }
    }
}
