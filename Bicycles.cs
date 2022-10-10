﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martin_Ship_It
{
    class Bicycles : IShippable
    {
        private decimal _shipCost = 20.50M;
        private string _product = "Bicycle";

        public string Product
        {
            get => _product;
        }

        public decimal ShipCost
        {
            get => _shipCost;
        }
    }
}
