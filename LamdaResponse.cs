﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWSServerless2
{
    internal class LamdaResponse
    {
        public int StatusCode { get; set; }
        public IDictionary<string, string> Headers { get; set; }

        public string  Body { get; set; }
    }
}
