﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public abstract class ShipmentFactory
    {
        public abstract Load FactoryMethod(string from, string to);
    }
}