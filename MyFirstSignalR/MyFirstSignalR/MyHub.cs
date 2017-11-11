using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace MyFirstSignalR
{
    public class MyHub : Hub
    {

        // Annoncer til alle klienter
        public void Announce(string message)
        {
            Clients.All.Announce(message);
        }

        public DateTime GetDate()
        {
            return DateTime.Now;
        }
    }
}