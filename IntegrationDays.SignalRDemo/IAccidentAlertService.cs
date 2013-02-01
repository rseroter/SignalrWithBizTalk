using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace IntegrationDays.SignalRDemo
{
    [ServiceContract]
    public interface IAccidentAlertService
    {
        [OperationContract]
        void Notify(string site, string message);
    }
}
