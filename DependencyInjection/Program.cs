public class CustomerBusinessLogic
{
    private readonly IDataAccess _dataAccess;

    public CustomerBusinessLogic(IDataAccess custDataAccess)
    {
        _dataAccess = custDataAccess;
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