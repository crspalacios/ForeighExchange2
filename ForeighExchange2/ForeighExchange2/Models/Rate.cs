﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeighExchange2.Models
{
    public class Rate
    {
       
            public int RateId { get; set; }

            public string Code { get; set; }

            public double TaxRate { get; set; }

            public string Name { get; set; }
        
    }
}
