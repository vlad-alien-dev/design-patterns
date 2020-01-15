using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class Client
    {
        private IBackground background;
        private IBorder border;
        private IText text;
        private ILayoutFactory layoutFactory;
        public Client()
        {

        }
        public Client(ILayoutFactory layoutFactory)
        {
            this.layoutFactory = layoutFactory;
        }
        public void CreateUI()
        {
            this.background = layoutFactory.CreateBackground();
            this.border = layoutFactory.CreateBorder();
            this.text = layoutFactory.CreateText();
        }
        public void Paint()
        {
            this.background.Paint();
            this.border.Paint();
            this.text.Paint();
        }

        public string Report()
        {

            string s = this.background.Report() + this.border.Report() + this.text.Report();
            return s;
        }
    }
}