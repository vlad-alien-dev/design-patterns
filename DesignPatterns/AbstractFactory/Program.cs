using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var application = new Client();
            var currentLayoutPreferrence = "Night";
            if (currentLayoutPreferrence == "Regular")
            {
                application = new Client(new RegularLayoutFactory());
            }
            else if(currentLayoutPreferrence == "Night")
            {
                application = new Client(new NightLayoutFactory());
            }
            else
            {
                throw new InvalidOperationException("Unknown layout!");
            }
            application?.CreateUI();
            application?.Paint();
            var report = application.Report();
            Console.WriteLine(report);
        }
    }
}
