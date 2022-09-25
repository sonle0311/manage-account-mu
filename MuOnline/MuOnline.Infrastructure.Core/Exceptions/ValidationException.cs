namespace MuOnline.Infrastructure.Core.Exceptions
{
    public class ValidationException : Exception
    {
        public List<string> Errors { get; set; }
        public ValidationException()
        {
            Errors = new List<string>();
        }

        public ValidationException(List<string> errorDictionary)
        {
            Errors = errorDictionary;
        }
    }
}
