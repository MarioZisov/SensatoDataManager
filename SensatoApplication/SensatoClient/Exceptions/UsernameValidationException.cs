using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensatoClient.Exceptions
{
    public class UsernameValidationException : ArgumentException
    {
        public UsernameValidationException(string message)
            : base(message)
        {
        }
    }
}
