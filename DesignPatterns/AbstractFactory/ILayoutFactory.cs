using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public interface ILayoutFactory
    {
        public IBackground CreateBackground();
        public IBorder CreateBorder();
        public IText CreateText();
    }
}
