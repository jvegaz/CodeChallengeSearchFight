namespace SearchImplementation.FinalServices
{
    public class GoogleService : IA_SearchFactory.Service
    {
        public override string Name => "Google";

        public override IA_SearchFactory.Interfaces.Engines.IEngine CreateEngine()
        {
            return new Engines.GoogleEngine();
        }
    }
}
