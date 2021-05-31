﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotaMarket.Api.Model
{
    public class InstrumentModel
    {
        public int Id { get; set; }
        public string InstrumentName { get; set; }
        public string PhotoUrl { get; set; }

        public int InstrumentTypeId { get; set; }
        public string InstrumentTypeName { get; set; }
        //public InstrumentTypeModel InstrumentType { get; set; }
    }
}
