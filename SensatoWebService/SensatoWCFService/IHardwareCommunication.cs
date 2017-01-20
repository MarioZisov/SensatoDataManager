using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Web;

namespace SensatoDBService
{
    [ServiceContract]
    public interface IHardwareCommunication
    {
        [WebGet(UriTemplate = "data/{testData}", BodyStyle = WebMessageBodyStyle.Wrapped, ResponseFormat = WebMessageFormat.Xml, RequestFormat = WebMessageFormat.Xml)]
        [OperationContract]
        string TestRenameHive(string testData);
    }
}