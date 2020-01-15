namespace AbstractFactory
{
    internal class RegularBorder : LayoutElement, IBorder
    {
        public void Paint()
        {
            this.Color = Color.Black;
        }
    }
}