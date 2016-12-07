using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SensatoDBService.Faults
{
    using System.Runtime.Serialization;

    [DataContract]
    public class PasswordValidationFault : ValidationFault
    {
        public PasswordValidationFault(string message) : base(message)
        {
        }
    }
}