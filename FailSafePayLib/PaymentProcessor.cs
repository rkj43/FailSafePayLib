using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FailSafePayLib
{
    public class PaymentProcessor : IPaymentProcessor
    {
        private readonly ILoggingService _loggingService;

        public PaymentProcessor(ILoggingService loggingService)
        {
            _loggingService = loggingService;
        }

        public TransactionResult ProcessPayment(PaymentDetails details)
        {
            // TODO Implement the payment processing logic here
            // TODO This should be resilient and able to handle and recover from failures where possible
        }
    }

}
