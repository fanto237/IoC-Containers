namespace DependencyInversionPrincipe;

public class DataAccess : IDataAccess
{
    public string GetCustomerById(int id)
    {
        return "Dummy customer";
    }
}