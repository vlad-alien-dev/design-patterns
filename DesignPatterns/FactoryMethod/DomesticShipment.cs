using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class DomesticShipment : ShipmentFactory
    {
        public override Load FactoryMethod(string from, string to)
        {
            return new DomesticLoad();
        }
    }
}
