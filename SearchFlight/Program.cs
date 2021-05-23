using System;


namespace SearchFight
{
    class Program
    {
        static void Main(string[] args) {
            Run(args);
        }

        private static void Run(string[] args) {
            IA_SearchFactory.Interfaces.IServiceFactory fact = new SearchImplementation.ServiceConfig();
            var services = fact.GetAvailableServices();
            if (validateArgsQty(args)) {
                foreach (var arg in args) {
                    Console.Write(arg + ": ");
                    foreach (var service in services) {
                        Console.Write(service.GetResults(arg));
                    }
                    Console.WriteLine("");
                }
                foreach (var service in services) Console.WriteLine(service.WinnerToString());
                Console.WriteLine("Total Winner:" + fact.GetTotalWinner(services));
                Console.ReadLine();
            } else {
                Console.WriteLine("Enter at least 2 words.");
            }
        }

        private static bool validateArgsQty(string [] args) {
            return args.Length >= 2;
        }
    }
}
