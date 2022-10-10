using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martin_Ship_It
{
    interface IShippable
    {
        public decimal ShipCost { get; }
        public string Product { get; }
    }
}
