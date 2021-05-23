using System.Collections.Generic;

namespace SearchImplementation.Engines
{
    public class MsnEngine : BaseEngine, IA_SearchFactory.Interfaces.Engines.IEngine
    {
        public int Search(string keyword)
        {
            var url = "https://api.cognitive.microsoft.com/bingcustomsearch/v7.0/search" + "?q=" + keyword + "&customconfig=0";
            var res = Parser_Classes.ParseToSearchApi<MsnResults>.jsParse(GetResponse(url, new KeyValuePair<string, string>("Ocp-Apim-Subscription-Key", GetSecretKey("MsnSearchApiKey"))));
            return res.webPages.totalEstimatedMatches;
        }
        public class MsnResults
        {
            public WebPages webPages { get; set; }
        }
        public class WebPages
        {
            public string webSearchUrl { get; set; }
            public string webSearchUrlPingSuffix { get; set; }
            public int totalEstimatedMatches { get; set; }
            //public List<Value> value { get; set; }
        }
        


    }
}
