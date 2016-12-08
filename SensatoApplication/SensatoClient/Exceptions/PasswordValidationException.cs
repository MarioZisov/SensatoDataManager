namespace SensatoClient.Exceptions
{
    using System;

    public class PasswordValidationException : ArgumentException
    {
        public PasswordValidationException(string message)
            : base(message)
        {
        }
    }
}
