using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public abstract class LayoutElement : IReport
    {
        public Color Color { get; set; }
        public string Report()
        {
            return this.Color.ToString();
        }
    }
}
