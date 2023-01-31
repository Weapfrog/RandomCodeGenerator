namespace RandomWordGenerator.Core
{
    public interface IDatabaseHelper
    {
        (bool Success, string Message) Insert(string wordName);
    }
}