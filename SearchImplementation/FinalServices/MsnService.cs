namespace SearchImplementation.FinalServices
{
    public class MsnService : IA_SearchFactory.Service
    {
        public override string Name => "MSN";

        public override IA_SearchFactory.Interfaces.Engines.IEngine CreateEngine() {
            return new Engines.MsnEngine();
        }
    }
}
