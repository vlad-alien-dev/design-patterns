using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class NightBorder : LayoutElement, IBorder
    {
        public void Paint()
        {
            this.Color = Color.White;
        }
    }
}
