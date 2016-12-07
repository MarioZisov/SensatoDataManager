using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensatoClient.Exceptions
{
    public class PasswordValidationException : ArgumentException
    {
        public PasswordValidationException(string message)
            : base(message)
        {
        }
    }
}
