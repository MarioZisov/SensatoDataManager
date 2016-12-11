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
        bool CheckPassowrdMatch(string passwordHash, string username);

        [OperationContract]
        ICollection<HiveDTO> GetUserDataByUsername(string username);

        [OperationContract]
        [FaultContract(typeof(AlreadyExistFault))]
        void AddHive(string username, string hiveName);

        [OperationContract]
        [FaultContract(typeof(AlreadyExistFault))]
        bool RenameHive(string username, string newHiveName, string currentHiveName);

        [OperationContract]
        bool RemoveHive(string username, string hiveName);
    }
}
