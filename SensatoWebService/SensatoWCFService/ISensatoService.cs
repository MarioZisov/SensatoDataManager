using SensatoDBService.DataTransferObjects;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace SensatoDBService
{
    using Faults;
    using System.Collections.Generic;

    [ServiceContract]
    public interface ISensatoService
    {
        [OperationContract]
        [FaultContract(typeof(UsernameValidationFault))]
        bool CheckUserExists(string username);

        [OperationContract]
        [FaultContract(typeof(PasswordValidationFault))]
        bool CheckPassowrdMatch(string passwordHash,string username);

        [OperationContract]
        ICollection<HiveDTO> GetHivesByUser(string username);
    }
}
