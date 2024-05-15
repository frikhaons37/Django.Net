using System.Text.Json.Serialization;

namespace djaginet.Models;

public class Categorie
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
    [JsonPropertyName("name")]
    public string Name { get; set; } = null!;
}
