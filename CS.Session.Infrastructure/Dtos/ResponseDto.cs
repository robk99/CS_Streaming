namespace CS.Session.Infrastructure.Dtos
{
    public class ResponseDto
    {
        public bool IsSuccess { get; set; } = true;
        public string? Message { get; set; }
        public string? Error { get; set; }
    }

    public class ResponseDto<T> : ResponseDto
    {
        public T? Result { get; set; }
    }
}
