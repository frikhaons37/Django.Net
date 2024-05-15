using System.Text.Json.Serialization;

namespace djaginet.Models;

public class Product
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
    [JsonPropertyName("libelle")]
    public string Libelle { get; set; } = null!;
    [JsonPropertyName("description")]
    public string Description { get; set; } = null!;
    [JsonPropertyName("categorie")]
    public int CategorieId { get; set; }
    [JsonPropertyName("prix")]
    public double Prix { get; set; }
    [JsonPropertyName("img")]
    public string ImagePath { get; set; } = null!;

}


