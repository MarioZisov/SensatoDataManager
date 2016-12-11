using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace SensatoDBService.Faults
{
    [DataContract]
    public class AlreadyExistFault
    {
        public AlreadyExistFault(string message)
        {
            this.Message = message;
        }

        [DataMember]
        public string Message { get; set; }
    }
}