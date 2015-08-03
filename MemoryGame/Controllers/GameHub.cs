using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace MemoryGame.Controllers
{
    [HubName("gameHub")]
    public class GameHub : Hub
    {
        //
        // GET: /Game/

        //public ActionResult Index()
        //{
        //    return View();
        //}

        public void Hello()
        {
            Clients.All.hello(DateTime.Now.ToString("T"));
        }

    }
}
