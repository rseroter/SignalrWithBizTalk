using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace IntegrationDays.SignalRDemo
{
    [ServiceContract]
    public interface IInventoryResponseService
    {
        [OperationContract]
        void PublishResults(string clientId, string providerId, string itemId, int stockAmount);
    }
}
