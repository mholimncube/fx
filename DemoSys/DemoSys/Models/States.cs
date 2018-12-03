using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoSys.Models
{
    public class States
    {
        private bool active = true;
        public bool Active
        {
            get
            {
                return active;
            }

            set
            {
                active = value;
            }
        }
        private bool inactive = false;
        public bool Inactive
        {
            get
            {
                return inactive;
            }

            set
            {
                inactive = value;
            }
        }

        
    }

}