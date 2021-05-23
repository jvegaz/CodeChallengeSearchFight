using System;
using System.Collections.Generic;

namespace SearchImplementation.Engines
{
    public class GoogleEngine : BaseEngine, IA_SearchFactory.Interfaces.Engines.IEngine
    {
        public int Search(string keyword) {
            var res = Parser_Classes.ParseToSearchApi<GoogleResults>.jsParse(GetResponse("https://www.googleapis.com/customsearch/v1?key=" + GetSecretKey("GoogleApiKey") + "&cx=006469441686315824696:jlvbuea85y8" + "&q=" + keyword));
            return Convert.ToInt32(res.queries.request[0].totalResults);
        }
        protected class GoogleResults {
            public Queries queries { get; set; }
        }
        protected class Queries {
            public List<Request> request { get; set; }
        }
        protected class Request {
            public string title { get; set; }
            public string totalResults { get; set; }
            public string searchTerms { get; set; }
            public int startIndex { get; set; }
        }
    }
}
