using IA_SearchFactory.Interfaces.Engines;

namespace IA_SearchFactory
{
    public abstract class Service
    {
        public abstract IEngine CreateEngine();
        public abstract string Name { get; }

        private string Winner = "No Winner Yet";
        private int WinnerResults = 0;

        public string GetResultsWinner() {
            return Winner;
        }
        public string WinnerToString() {
            return Name.Trim() + " winner: " + Winner.Trim();
        }
        public string GetResults(string keyword) {
            var SearchEngine = CreateEngine();
            var EngineResults = SearchEngine.Search(keyword);
            SetResultsWinner(keyword, EngineResults);
            return Name.Trim() + ": " + string.Format("{0:N}", EngineResults) + " result" + (EngineResults > 1 ? "s" : string.Empty) + ".";
            
        }
        protected void SetResultsWinner(string keyword, int results) {
            if (results > WinnerResults) {
                Winner = keyword;
                WinnerResults = results;
            }
        }
    }
}
