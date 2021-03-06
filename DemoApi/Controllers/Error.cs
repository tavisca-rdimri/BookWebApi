﻿using Microsoft.AspNetCore.Mvc;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoApi.Controllers
{
    public class Error : ActionResult
    {
        public string Message { get; set; }
        public int Code { get; set; }

        public Error(string message, int code = 400)
        {
            Log.Error(message);
            Message = message;
            Code = code;
        }
    }
}
