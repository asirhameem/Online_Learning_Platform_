﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace MIdProject
{
    public class NotificationHub : Hub
    {
        public void Hello()
        {
            Clients.All.hello();
        }
    }
}