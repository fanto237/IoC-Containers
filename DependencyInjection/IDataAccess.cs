namespace DependencyInjection;

public interface IDataAccess
{
    string GetCustomerById(int id);
}