namespace DependencyInjection;

public class BusinessLogic
{
    private readonly IDataAccess _dataAccess;

    public BusinessLogic()
    {
        // _dataAccess = new DataAccess();

        // implementing Inversion of control by making BusinessLogic and DataAccess loosely coupled using 
        // Factory Pattern
        _dataAccess = DataAccessFactory.GetDataAccessObj();
    }

    public string GetCustomerById(int id)
    {
        return _dataAccess.GetCustomerById(id);
    }
}