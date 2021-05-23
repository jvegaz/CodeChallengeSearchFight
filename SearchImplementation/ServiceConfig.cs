using IA_SearchFactory;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SearchImplementation
{
    public class ServiceConfig : IA_SearchFactory.Interfaces.IServiceFactory
    {
        public Service[] GetAvailableServices() {
            return new Service[] {
                new FinalServices.GoogleService(),
                new FinalServices.MsnService()
            };
        }

        public string GetTotalWinner(Service[] services) {
            var listWinner = new List<String>();
            foreach (var service in services) listWinner.Add(service.GetResultsWinner());

            return listWinner.GroupBy(x => x).OrderByDescending(x => x.Count()).First().Key;
        }
    }
}
