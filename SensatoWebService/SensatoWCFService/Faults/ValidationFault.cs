namespace SensatoDBService.Faults
{
    using System.Runtime.Serialization;

    [DataContract]
    public abstract class ValidationFault
    {
        protected ValidationFault(string message)
        {
            this.Message = message;
        }

        [DataMember]
        public string Message { get; set; }
    }
}