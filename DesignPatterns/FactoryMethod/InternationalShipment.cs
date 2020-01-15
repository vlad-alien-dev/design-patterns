using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class InternationalShipment : ShipmentFactory
    {
        public override Load FactoryMethod(string from, string to)
        {
            return new InternationalLoad();
        }
    }
}
