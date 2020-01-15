namespace FactoryMethod
{
    public abstract class Load
    {
        public string  From{ get; set; }
        public string To { get; set; }

        public abstract void Deliver();
    }
}