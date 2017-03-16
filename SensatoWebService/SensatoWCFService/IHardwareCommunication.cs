using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Web;
using System.Web.Services;

namespace SensatoDBService
{
    [ServiceContract]
    public interface IHardwareCommunication
    {
        [WebGet(UriTemplate = "data/{testData}", BodyStyle = WebMessageBodyStyle.Wrapped, ResponseFormat = WebMessageFormat.Xml, RequestFormat = WebMessageFormat.Xml)]
        [OperationContract]
        string TestRenameHive(string testData);

        [WebGet(UriTemplate = "getHiveData", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        [OperationContract]
        string GetMeasurments();

        [WebGet(UriTemplate = "setHiveData/{measurmentsData}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        [OperationContract]
        void SetMeasurments(string measurmentsData);

        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "data")]
        string PostTest(string model);
    }
}