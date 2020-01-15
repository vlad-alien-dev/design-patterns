using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class NightBackground : LayoutElement, IBackground
    {
        public void Paint()
        {
            this.Color = Color.Black;
        }
    }
}
