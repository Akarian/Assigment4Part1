﻿using System;
using System.Collections.Generic;
using Assignment4;
using Microsoft.VisualBasic;

namespace DatabaseService
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public DateTime Required { get; set; }
        public DateTime Shipped { get; set; }
        public int Freight { get; set; }
        public string ShipName { get; set; }
        public string ShipCity { get; set; }
        public List<OrderDetails> OrderDetails { get; set; }
    }
}