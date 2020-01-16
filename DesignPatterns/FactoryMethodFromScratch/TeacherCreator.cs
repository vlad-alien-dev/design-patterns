using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodFromScratch
{
    public class TeacherCreator : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new Teacher();
        }
    }
}
