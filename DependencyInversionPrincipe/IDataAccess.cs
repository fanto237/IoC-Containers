namespace DependencyInversionPrincipe;

public interface IDataAccess
{
    string GetCustomerById(int id);
}