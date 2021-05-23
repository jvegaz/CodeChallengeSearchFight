namespace IA_SearchFactory.Interfaces
{
    public interface IServiceFactory {
        Service[] GetAvailableServices();
        string GetTotalWinner(Service[] services);
    }
}
