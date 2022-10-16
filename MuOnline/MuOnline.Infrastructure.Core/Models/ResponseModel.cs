namespace MuOnline.Infrastructure.Core.Models
{
    public class ResponseBase<T>
    {
        public ErrorModel Error { get; set; }

        public T Data { get; set; }
    }
}
