using System.Text.Json.Serialization;

namespace WebAPIClient.Models
{

    public class IPResponse
    {
        [JsonPropertyName("ip")]
        public string IP { get; set; }
    }

}