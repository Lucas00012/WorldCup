namespace WorldCup.Domain.Validation
{
    public class DomainExceptionValidation : Exception
    {
        public DomainExceptionValidation(string error) : base(error)
        { }
        public static void When(bool hasError, string Error)
        {
            if (hasError)
            {
                throw new DomainExceptionValidation(Error);
            }
        }

    }
}
