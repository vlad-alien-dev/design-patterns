using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodFromScratch
{
    public class StudentCreator : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new Student();
        }
    }
}
