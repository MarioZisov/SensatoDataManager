namespace SensatoClient.Exceptions
{
    using System;

    public class UsernameValidationException : ArgumentException
    {
        public UsernameValidationException(string message)
            : base(message)
        {
        }
    }
}
