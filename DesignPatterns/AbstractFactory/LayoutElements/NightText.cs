using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class NightText : LayoutElement, IText
    {
        public void Paint()
        {
            this.Color = Color.White;
        }
    }
}
