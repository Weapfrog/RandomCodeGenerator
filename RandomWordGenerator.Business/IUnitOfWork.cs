namespace RandomWordGenerator.Business
{
    public interface IUnitOfWork
    {
        (bool Success, string Message) Insert(string wordName);
    }
}