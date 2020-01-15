using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            ShipmentFactory intFactory = new InternationalShipment();
            Load il1 = intFactory.FactoryMethod("Sofia", "Hamburg");
            Load il2 = intFactory.FactoryMethod("Plovdiv", "Barcelona");

            ShipmentFactory domFactory = new DomesticShipment();
            Load dl1 = domFactory.FactoryMethod("Sofia", "Plovdiv");
            Load dl2 = domFactory.FactoryMethod("Plovdiv", "Ruse");

            dl1.Deliver();
            dl2.Deliver();


            Console.WriteLine("Hello World!");
        }
    }
}
