using System.Text.Json;

namespace CS.User.Infrastructure.Dtos
{
    public class ExceptionDto
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
