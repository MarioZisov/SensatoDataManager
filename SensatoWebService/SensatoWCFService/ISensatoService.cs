namespace SensatoDBService
{
    using Faults;
    using System.Collections.Generic;
    using System.ServiceModel;
    using DataTransferObjects;
    using System;
    using System.ServiceModel.Web;

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
        IEnumerable<string> GetUserHivesByUsername(string username);

        [OperationContract]
        [FaultContract(typeof(AlreadyExistFault))]
        void AddHive(string username, string hiveName);

        [OperationContract]
        [FaultContract(typeof(AlreadyExistFault))]
        bool RenameHive(string username, string newHiveName, string currentHiveName);

        [OperationContract]
        bool RemoveHive(string username, string hiveName);

        [OperationContract]
        IEnumerable<int> GetFramesByHive(string username, string hiveName);

        [OperationContract]
        void ChangeFrameStatusByHive(string username, string hivename, IEnumerable<int> activeFramesPositions);

        [OperationContract]
        ICollection<FrameDTO> GetMeasurmentData(string username, string hiveName, DateTime startDate, DateTime endDate);

        [OperationContract]
        void UploadMeasurmentData(string usernama, string hiveName, IDictionary<int, object[][]> measurmentsData);

        [OperationContract]
        bool SendEmail(string emailTo, string subject, string body, bool isBodyHtml);

        [OperationContract]
        DateTime GetLastEntryDate(string username, string hiveName);

        //[OperationContract]
        //string GetMeasurments(string strHiveId);
    }
}
