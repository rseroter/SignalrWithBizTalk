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
     public class AccidentAlertService : IAccidentAlertService
    {
        public void Notify(string site, string message)
        {
            var context = GlobalHost.ConnectionManager.GetHubContext<NotifyHub>();
            context.Clients.All.addAccident(message);
        }
    }
}
