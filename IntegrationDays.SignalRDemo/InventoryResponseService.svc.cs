using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using System.Web.Routing;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace IntegrationDays.SignalRDemo
{
    public class InventoryResponseService : IInventoryResponseService
    {
        /// <summary>
        /// Send message to single connected client
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="providerId"></param>
        /// <param name="itemId"></param>
        /// <param name="stockAmount"></param>
        public void PublishResults(string clientId, string providerId, string itemId, int stockAmount)
        {
            var context = GlobalHost.ConnectionManager.GetHubContext<NotifyHub>();
            
            context.Clients.Client(clientId).addLookupResponse(providerId, stockAmount);
        }
    }
}
