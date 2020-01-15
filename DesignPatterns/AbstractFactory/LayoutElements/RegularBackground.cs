namespace AbstractFactory
{
    internal class RegularBackground : LayoutElement, IBackground
    {
        public void Paint()
        {
            this.Color = Color.White;
        }
    }
}