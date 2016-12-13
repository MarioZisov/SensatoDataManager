namespace SensatoDBService
{
    using Faults;
    using System.Collections.Generic;
    using System.ServiceModel;
    using DataTransferObjects;

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

        [OperationContract]
        ICollection<FrameDTO> GetFramesByHiveName(string username, string hiveName);

        [OperationContract]
        void ChangeFrameStatusByHiveName(string username, string hivename,ICollection<int> activeFramesPositions);
    }
}
