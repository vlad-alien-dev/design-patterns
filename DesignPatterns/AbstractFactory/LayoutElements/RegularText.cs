namespace AbstractFactory
{
    internal class RegularText : LayoutElement, IText
    {
        public void Paint()
        {
            this.Color = Color.White;
        }
    }
}