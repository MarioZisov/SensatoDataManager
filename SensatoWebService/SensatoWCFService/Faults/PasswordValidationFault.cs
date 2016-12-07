using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SensatoDBService.Faults
{
    using System.Runtime.Serialization;

    [DataContract]
    public class PasswordValidationFault
    {
        public PasswordValidationFault(string message)
        {
            this.Message = message;
        }

        [DataMember]
        public string Message { get; set; }
    }
}