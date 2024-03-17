namespace CustomExceptionLibrary
{
    public class NotEmptyException : Exception
    {
        public NotEmptyException(string message) : base(message) { }
    }
}
