using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FailSafePayLib
{
    public class CircuitBreaker
    {
        private bool _isTripped = false;

        public void Trip()
        {
            _isTripped = true;
            //TODO  Additional logic to handle the trip
        }

        public bool IsTripped()
        {
            return _isTripped;
        }
    }

}
