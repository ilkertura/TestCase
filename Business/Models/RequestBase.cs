using System.Text.Json.Serialization;

namespace Business.Models
{
    public class RequestBase : IRequestBase
    {
        [JsonIgnore]
        public int Id { get; set; }
    }
}
