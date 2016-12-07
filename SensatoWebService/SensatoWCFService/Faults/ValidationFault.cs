namespace SensatoDBService.Faults
{
    public abstract class ValidationFault
    {
        protected ValidationFault(string message)
        {
            this.Message = message;
        }

        public string Message { get; set; }
    }
}