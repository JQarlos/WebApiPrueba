﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiSegura.Models
{
    public class LoginRequest 
    {
        public string Username {get; set; }
        public string Password { get; set; }

    }
}
