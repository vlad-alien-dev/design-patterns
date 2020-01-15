using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class NightLayoutFactory : ILayoutFactory
    {
        public IBackground CreateBackground()
        {
            return new NightBackground();
        }

        public IBorder CreateBorder()
        {
            return new NightBorder();
        }

        public IText CreateText()
        {
            return new NightText();
        }
    }
}
