using Code360StudentApp.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Code360StudentApp.Models
{
    public interface IPayment
    {
        IEnumerable<Payment> GetSpecifiedPayment(int id);
        List<Payment> GetPayments(int id);
        Payment AddPayment(Payment payment);
        Payment UpdatePayment(Payment paymentChanges);
        Payment DeletePayment(int id);
    }
}
