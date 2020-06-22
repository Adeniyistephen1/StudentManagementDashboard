using Code360StudentApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Code360StudentApp.ViewModel
{
    public class CreatePaymentViewModel
    {
        public int StudentId { get; set; }
        [Display(Name ="Amount Paid")]
        public double AmountPaid { get; set; }
        [Display(Name ="Payment Method")]
        public PayMethod PaymentMethod { get; set; }
        [Display(Name ="Date")]
        public DateTime PaymentDate { get; set; }
    }
}
