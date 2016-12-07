using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SensatoDBService.Faults
{
    public class UsernameValidationFault :ValidationFault
    {
        public UsernameValidationFault(string message) : base(message)
        {
        }
    }
}