namespace Exception_Library
{
    public class InvalidPetAgeException : Exception
    {
        public InvalidPetAgeException(string message) : base(message)
        {
        }
    }
    public class InsufficientFundsException : Exception
    {
        public InsufficientFundsException(string message) : base(message)
        {
        }
    }

}
