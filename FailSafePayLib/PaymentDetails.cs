using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FailSafePayLib
{
    public class PaymentDetails
    {
        //  Amount, Currency, CreditCardInfo, etc.
    }

    public class TransactionResult
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        // Additional transaction details as needed
    }

}
