﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EC_Endpoint_Client.Classes
{
    public class EndPointState
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string SelectedEndPointName { get; set; }
        public string AgencyUserName { get; set; }
        public string AgencyPassword { get; set; }
    }
}
