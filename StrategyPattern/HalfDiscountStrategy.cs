﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class HalfDiscountStrategy : IPromoteStrategy
    {
        public double DoDiscount(double price)
        {
           return price * 0.5;
        }
    }
}
