using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class RegularLayoutFactory : ILayoutFactory
    {
        public IBackground CreateBackground()
        {
            return new RegularBackground();
        }

        public IBorder CreateBorder()
        {
            return new RegularBorder();
        }

        public IText CreateText()
        {
            return new RegularText();
        }
    }
}
