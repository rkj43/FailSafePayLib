using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FailSafePayLib
{
    public interface IPaymentProcessor
    {
        TransactionResult ProcessPayment(PaymentDetails details);
    }
   
}
