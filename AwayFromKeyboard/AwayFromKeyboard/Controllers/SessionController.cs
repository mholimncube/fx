using Microsoft.Owin.Builder;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AwayFromKeyboard.Controllers
{
    public class SessionController : Controller
    {
        // GET: Session
        public ActionResult Index()
        {
            return View();
        }

        public DateTime getDateTime(IAppBuilder app)
        {
            if(app.Equals( true))
            {
                return DateTime.Now;
            }
            return DateTime.Today;
        }

    }
}