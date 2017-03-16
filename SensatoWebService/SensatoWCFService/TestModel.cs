using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace SensatoDBService
{
    [DataContract]
    public class TestModel
    {
        [DataMember]
        public string Status { get; set; }
    }
}