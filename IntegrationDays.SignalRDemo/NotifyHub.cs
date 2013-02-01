using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Microsoft.AspNet.SignalR.Hubs;

namespace IntegrationDays.SignalRDemo
{
    public class NotifyHub : Hub
    {
        /// <summary>
        /// Operation called by client code to lookup inventory for a given item #
        /// </summary>
        /// <param name="itemId"></param>
        public void LookupInventory(string itemId)
        {
            //get this caller's unique browser connection ID
            string clientId = Context.ConnectionId;

            LookupService.IntegrationDays_SignalRDemo_BT_ProcessInventoryRequest_ReceiveInventoryRequestPortClient c =
                new LookupService.IntegrationDays_SignalRDemo_BT_ProcessInventoryRequest_ReceiveInventoryRequestPortClient();

            LookupService.InventoryLookupRequest req = new LookupService.InventoryLookupRequest();
            req.ClientId = clientId;
            req.ItemId = itemId;

            //invoke async service
            c.LookupInventory(req);
        }
    }
}