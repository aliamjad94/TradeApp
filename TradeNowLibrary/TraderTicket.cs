﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace TradeNowLibrary
{
    public class TraderTicket 
    {
        public string OrderID { get; set; }
        public string Order { get; set; }
        public string Symbol { get; set; }
        public string Quantity { get; set; }
        public string Price { get; set; }
        public string Route { get; set; }
        public string OrderType { get; set; }
        public string Tif { get; set; }
        public string OrderDate { get; set; }
    }
}
