﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models.VM
{
   public  class AuthTokenVM
    {
        public string status { get; set; }

        public string responseMessage { get; set; }
        public string data { get; set; }
    }
}
