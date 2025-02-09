﻿using NotaMarket.UI.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotaMarket.UI.Models
{
    public class ResponseObjectModel<T> : IResponseObjectModel<T>
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public int StatusCode { get; set; }
        public T Response { get; set; }
    }
}
