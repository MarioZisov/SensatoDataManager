using SensatoDBService.DataTransferObjects;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace SensatoDBService
{
    using System.Collections.Generic;

    [ServiceContract]
    public interface ISensatoService
    {
        [OperationContract]
        bool CheckUserExists(string username);

        [OperationContract]
        bool CheckPassowrdMatch(string passwordHash,string username);

        [OperationContract]
        ICollection<HiveDTO> GetHivesByUser(string username);
    }
}
