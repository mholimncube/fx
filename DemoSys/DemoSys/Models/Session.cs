using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoSys.Models
{
    public class Session
    {
         public DateTime logOnDateTime { get; set; }
        public DateTime logOutDateTime { get; set; }
    }
}