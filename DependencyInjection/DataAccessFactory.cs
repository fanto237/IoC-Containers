namespace DependencyInjection;

public static class DataAccessFactory
{
    public static IDataAccess GetDataAccessObj()
    {
        return new DataAccess();
    }
}