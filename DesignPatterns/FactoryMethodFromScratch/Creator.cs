using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodFromScratch
{
    public abstract class Creator
    {
        public abstract IProduct FactoryMethod();
    }
}
