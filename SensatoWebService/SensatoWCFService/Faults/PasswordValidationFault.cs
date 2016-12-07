using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SensatoDBService.Faults
{
    public class PasswordValidationFault : ValidationFault
    {
        public PasswordValidationFault(string message) : base(message)
        {
        }
    }
}