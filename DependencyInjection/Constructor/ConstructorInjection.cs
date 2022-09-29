namespace DependencyInjection.Constructor;

public class CustomerBusinessLogic
{
    readonly IDataAccess _dataAccess;

    public CustomerBusinessLogic(IDataAccess dataAccess)
    {
        _dataAccess = dataAccess;
    }

    public CustomerBusinessLogic()
    {
        _dataAccess = new DataAccess();
    }

    public string ProcessCustomerData(int id)
    {
        return _dataAccess.GetCustomerName(id);
    }
}

public interface IDataAccess
{
    string GetCustomerName(int id);
}

public class DataAccess: IDataAccess
{
    public DataAccess()
    {
    }

    public string GetCustomerName(int id) 
    {
        //get the customer name from the db in real application        
        return "Dummy Customer Name"; 
    }
}

public class CustomerService
{
    readonly CustomerBusinessLogic _customerBl;

    public CustomerService()
    {
        _customerBl = new CustomerBusinessLogic(new DataAccess());
    }

    public string GetCustomerName(int id) {
        return _customerBl.ProcessCustomerData(id);
    }
}